using Microsoft.EntityFrameworkCore;

namespace EasyLab.Models.Local
{
    [PrimaryKey(nameof(TabellaId), nameof(UtenteId), nameof(RigaCod))]
    public class PermessiLetturaTabelle
    {
        public int TabellaId { get; set; }

        public string UtenteId { get; set; } = null!;

        public string RigaCod { get; set; } = null!;

        public bool Visualizza { get; set; }
    }
}
