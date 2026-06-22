namespace EasyLab.Components.Utils;

public static class CheckboxDropdownInterop
{
    public static event Action? OnCloseAll;

    public static void CloseAll() => OnCloseAll?.Invoke();
}
