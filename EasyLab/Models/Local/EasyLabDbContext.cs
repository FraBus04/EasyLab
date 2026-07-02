using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyLab.Models.Local
{
    public class EasyLabDbContext : IdentityDbContext<ApplicationUser>
    {
        public EasyLabDbContext(DbContextOptions<EasyLabDbContext> options)
      : base(options)
        {
        }


    }
}
