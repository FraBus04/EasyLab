namespace EasyLab.Models.Local
{
    public class ParametroUtente
    {
        public int Id { get; set; }

        public string UtenteId { get; set; } = null!;

        public int TabellaId { get; set; }

        public string NomeTabella { get; set; } = null!;

        public List<string> Parametri { get; set; } = new();

        public DateTime DataUpd { get; set; }
    }
}
