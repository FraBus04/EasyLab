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

        public DbSet<ParametroUtente> ParametriUtente { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PermessiLetturaTabelle>().ToTable("PermessiLetturaTabelle", t => t.ExcludeFromMigrations());
            builder.Entity<ParametroUtente>().ToTable("ParametriUtente", t => t.ExcludeFromMigrations());
        }
    }
}
