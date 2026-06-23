namespace EasyLab.Models;

public static class LookupResolver
{
    public static string GetText(Dictionary<string, Dictionary<int, string>> lookups, string key, object? value)
    {
        if (value == null) return "";
        var id = Convert.ToInt32(value);
        if (lookups.TryGetValue(key, out var dict) && dict.TryGetValue(id, out var text) && !string.IsNullOrWhiteSpace(text))
        {
            return text;
        }
        return id.ToString();
    }
}
