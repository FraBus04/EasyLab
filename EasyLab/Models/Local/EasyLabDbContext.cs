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

        public DbSet<PermessiLetturaTabelle> PermessiLetturaTabelles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PermessiLetturaTabelle>().ToTable("PermessiLetturaTabelle", t => t.ExcludeFromMigrations());
        }
    }
}
