using System.Collections.Concurrent;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace EasyLab.Servizi
{
    // DevExpress non offre alcun visualizzatore per Word/Excel/PowerPoint (legacy o
    // OpenDocument): questi formati vengono convertiti al volo in PDF con LibreOffice
    // in modalita' headless, poi mostrati con lo stesso iframe gia' usato per i PDF
    // nativi. Il risultato e' in cache su disco, la conversione (lenta) avviene una
    // sola volta per file.
    public class OfficeToPdfConverterService
    {
        private readonly string _cacheDir = Path.Combine(Path.GetTempPath(), "EasyLab_DocPreviewCache");
        private readonly ConcurrentDictionary<string, SemaphoreSlim> _lock = new();

        public string SofficePath { get; set; } = "soffice";

        public async Task<string> GetPdfAsync(string sorgente, CancellationToken ct = default)
        {
            Directory.CreateDirectory(_cacheDir);

            var info = new FileInfo(sorgente);
            var chiave = Convert.ToHexString(SHA256.HashData(
                Encoding.UTF8.GetBytes($"{info.FullName}|{info.LastWriteTimeUtc.Ticks}")));
            var destinazione = Path.Combine(_cacheDir, chiave + ".pdf");

            if (File.Exists(destinazione)) return destinazione;

            var gate = _lock.GetOrAdd(chiave, _ => new SemaphoreSlim(1, 1));
            await gate.WaitAsync(ct);
            try
            {
                if (File.Exists(destinazione)) return destinazione;

                // LibreOffice non permette di scegliere il nome del file generato: scrive
                // "<nomefile>.pdf" nella cartella di --outdir. Si usa una sottocartella
                // dedicata per evitare collisioni tra conversioni concorrenti di file diversi.
                var outDir = Path.Combine(_cacheDir, "tmp_" + chiave);
                Directory.CreateDirectory(outDir);
                try
                {
                    var psi = new ProcessStartInfo
                    {
                        FileName = SofficePath,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    psi.ArgumentList.Add("--headless");
                    psi.ArgumentList.Add("--norestore");
                    psi.ArgumentList.Add("--convert-to");
                    psi.ArgumentList.Add("pdf");
                    psi.ArgumentList.Add("--outdir");
                    psi.ArgumentList.Add(outDir);
                    psi.ArgumentList.Add(sorgente);

                    Process processo;
                    try
                    {
                        processo = Process.Start(psi) ?? throw new InvalidOperationException("Impossibile avviare soffice (LibreOffice).");
                    }
                    catch (System.ComponentModel.Win32Exception ex)
                    {
                        throw new InvalidOperationException(
                            $"LibreOffice non trovato (percorso configurato: \"{SofficePath}\"). Installarlo sul server o impostare LibreOffice:Path in appsettings.json.", ex);
                    }

                    using (processo)
                    {
                        using var timeoutCts = CancellationTokenSource.CreateLinkedTokenSource(ct);
                        timeoutCts.CancelAfter(TimeSpan.FromMinutes(3));

                        var standardError = processo.StandardError.ReadToEndAsync();
                        try
                        {
                            await processo.WaitForExitAsync(timeoutCts.Token);
                        }
                        catch (OperationCanceledException) when (!ct.IsCancellationRequested)
                        {
                            processo.Kill(entireProcessTree: true);
                            throw new TimeoutException("Conversione del documento interrotta: tempo massimo superato.");
                        }

                        if (processo.ExitCode != 0)
                        {
                            var errore = await standardError;
                            throw new InvalidOperationException($"soffice ha restituito il codice {processo.ExitCode}: {errore}");
                        }
                    }

                    var pdfGenerato = Directory.GetFiles(outDir, "*.pdf").FirstOrDefault();
                    if (pdfGenerato == null)
                        throw new InvalidOperationException("La conversione non ha prodotto alcun PDF.");

                    File.Move(pdfGenerato, destinazione, overwrite: true);
                    return destinazione;
                }
                finally
                {
                    try { Directory.Delete(outDir, recursive: true); } catch { /* best effort */ }
                }
            }
            finally
            {
                gate.Release();
            }
        }
    }
}
