using System.Collections.Concurrent;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace EasyLab.Servizi
{
    // I browser non sanno decodificare il contenitore/codec AVI nel tag <video>, quindi i
    // file .avi vengono convertiti al volo in mp4 (H.264/AAC) con ffmpeg prima di essere
    // serviti. Il risultato e' messo in cache su disco: la conversione (lenta) avviene una
    // sola volta per file, le richieste successive servono l'mp4 gia' pronto.
    public class AviTranscoderService
    {
        private readonly string _cacheDir = Path.Combine(Path.GetTempPath(), "EasyLab_DocPreviewCache");
        private readonly ConcurrentDictionary<string, SemaphoreSlim> _lock = new();

        public string FfmpegPath { get; set; } = "ffmpeg";

        public async Task<string> GetMp4Async(string sorgenteAvi, CancellationToken ct = default)
        {
            Directory.CreateDirectory(_cacheDir);

            var info = new FileInfo(sorgenteAvi);
            var chiave = Convert.ToHexString(SHA256.HashData(
                Encoding.UTF8.GetBytes($"{info.FullName}|{info.LastWriteTimeUtc.Ticks}")));
            var destinazione = Path.Combine(_cacheDir, chiave + ".mp4");

            if (File.Exists(destinazione)) return destinazione;

            // Evita che due richieste concorrenti per lo stesso file lancino due ffmpeg in parallelo.
            var gate = _lock.GetOrAdd(chiave, _ => new SemaphoreSlim(1, 1));
            await gate.WaitAsync(ct);
            try
            {
                if (File.Exists(destinazione)) return destinazione;

                var temp = destinazione + ".tmp";
                var psi = new ProcessStartInfo
                {
                    FileName = FfmpegPath,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                psi.ArgumentList.Add("-y");
                psi.ArgumentList.Add("-i");
                psi.ArgumentList.Add(sorgenteAvi);
                psi.ArgumentList.Add("-c:v");
                psi.ArgumentList.Add("libx264");
                psi.ArgumentList.Add("-preset");
                psi.ArgumentList.Add("veryfast");
                psi.ArgumentList.Add("-crf");
                psi.ArgumentList.Add("23");
                psi.ArgumentList.Add("-c:a");
                psi.ArgumentList.Add("aac");
                psi.ArgumentList.Add("-movflags");
                psi.ArgumentList.Add("+faststart");
                psi.ArgumentList.Add(temp);

                Process processo;
                try
                {
                    processo = Process.Start(psi) ?? throw new InvalidOperationException("Impossibile avviare ffmpeg.");
                }
                catch (System.ComponentModel.Win32Exception ex)
                {
                    throw new InvalidOperationException(
                        $"ffmpeg non trovato (percorso configurato: \"{FfmpegPath}\"). Installarlo sul server o impostare Ffmpeg:Path in appsettings.json.", ex);
                }

                using (processo)
                {
                    using var timeoutCts = CancellationTokenSource.CreateLinkedTokenSource(ct);
                    timeoutCts.CancelAfter(TimeSpan.FromMinutes(5));

                    var standardError = processo.StandardError.ReadToEndAsync();
                    try
                    {
                        await processo.WaitForExitAsync(timeoutCts.Token);
                    }
                    catch (OperationCanceledException) when (!ct.IsCancellationRequested)
                    {
                        processo.Kill(entireProcessTree: true);
                        throw new TimeoutException("Conversione del video interrotta: tempo massimo superato.");
                    }

                    if (processo.ExitCode != 0)
                    {
                        var errore = await standardError;
                        if (File.Exists(temp)) File.Delete(temp);
                        throw new InvalidOperationException($"ffmpeg ha restituito il codice {processo.ExitCode}: {errore}");
                    }
                }

                File.Move(temp, destinazione, overwrite: true);
                return destinazione;
            }
            finally
            {
                gate.Release();
            }
        }
    }
}
