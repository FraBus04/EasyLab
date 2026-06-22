namespace EasyLab.Servizi
{
    public class StateKeeperService
    {
        public bool isLoading = false;
        public string? CurrentUsername { get; set; } = null;

        public event Action? OnChange;

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
