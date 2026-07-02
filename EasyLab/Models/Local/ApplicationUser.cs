using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyLab.Models.Local
{
    public class ApplicationUser :IdentityUser
    {
        public int idEasyPLM { get; set; }

        public int idLaboratorio { get; set; }

        public int idCompagnia { get; set; }

        // Usato solo nel form di creazione/reset password: non viene mai salvato su DB.
        [NotMapped]
        public string? Password { get; set; }
    }
}
