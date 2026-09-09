using System.Text.Json.Nodes;

namespace EasyLab.Colori;

// Espone i colori definiti in wwwroot/Colori/Colori.json.
// Uso: PaletteEasyPLM.GetColor("saldo", "S", "dark") -> "#006400"
public static class PaletteEasyPLM
{
    private const string ColoreFallback = "#CCCCCC";

    private static readonly object _lock = new();
    private static JsonObject? _palette;

    public static string GetColor(params string[] percorso)
    {
        JsonNode? nodo = GetPalette();

        foreach (var chiave in percorso)
        {
            if (nodo is not JsonObject oggetto || !oggetto.TryGetPropertyValue(chiave, out nodo) || nodo == null)
            {
                return ColoreFallback;
            }
        }

        return nodo is JsonValue valore && valore.TryGetValue<string>(out var colore) ? colore : ColoreFallback;
    }

    private static JsonObject GetPalette()
    {
        if (_palette != null) return _palette;

        lock (_lock)
        {
            if (_palette != null) return _palette;

            var percorsoFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Colori", "Colori.json");
            var json = File.ReadAllText(percorsoFile);

            var radice = JsonNode.Parse(json) as JsonObject
                ?? throw new InvalidOperationException($"Impossibile leggere '{percorsoFile}'.");

            _palette = radice["palette"] as JsonObject
                ?? throw new InvalidOperationException($"Il file '{percorsoFile}' non contiene la chiave 'palette'.");
        }

        return _palette;
    }
}
