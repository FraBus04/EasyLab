using Microsoft.AspNetCore.Identity;

namespace EasyLab.Models.Local
{
    public class ApplicationUser :IdentityUser
    {
        public int idEasyPLM { get; set; }

        public int idLaboratorio { get; set; }

        public int idCompagnia { get; set; }
    }
}
