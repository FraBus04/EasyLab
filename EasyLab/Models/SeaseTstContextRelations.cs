using Microsoft.EntityFrameworkCore;

namespace EasyLab.Models;

public partial class SeaseTstContext
{
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BasiAll>(entity =>
        {
            entity.HasOne(b => b.SetTaglie).WithMany().HasForeignKey(b => b.IdSet).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.SetTaglieDettBase).WithMany().HasForeignKey(b => b.IdTgBase).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.SetTaglieDettDa).WithMany().HasForeignKey(b => b.IdTgDa).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.SetTaglieDettA).WithMany().HasForeignKey(b => b.IdTgA).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabKw).WithMany().HasForeignKey(b => b.IdKw).HasPrincipalKey(k => k.IdKw).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.ContattiFornPref).WithMany().HasForeignKey(b => b.IdFornPref).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.ContattiLabPrev).WithMany().HasForeignKey(b => b.IdLabPrev).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabComposizione1).WithMany().HasForeignKey(b => b.IdComp1).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabComposizione2).WithMany().HasForeignKey(b => b.IdComp2).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabComposizione3).WithMany().HasForeignKey(b => b.IdComp3).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabComposizione4).WithMany().HasForeignKey(b => b.IdComp4).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabComposizione5).WithMany().HasForeignKey(b => b.IdComp5).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabComposizionePo1).WithMany().HasForeignKey(b => b.IdPos1).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabComposizionePo2).WithMany().HasForeignKey(b => b.IdPos2).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabComposizionePo3).WithMany().HasForeignKey(b => b.IdPos3).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabComposizionePo4).WithMany().HasForeignKey(b => b.IdPos4).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabComposizionePo5).WithMany().HasForeignKey(b => b.IdPos5).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav1).WithMany().HasForeignKey(b => b.Idlav1).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav2).WithMany().HasForeignKey(b => b.Idlav2).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav3).WithMany().HasForeignKey(b => b.Idlav3).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav4).WithMany().HasForeignKey(b => b.Idlav4).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav5).WithMany().HasForeignKey(b => b.Idlav5).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav6).WithMany().HasForeignKey(b => b.IdLav6).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav11).WithMany().HasForeignKey(b => b.Idlav11).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav12).WithMany().HasForeignKey(b => b.Idlav12).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav13).WithMany().HasForeignKey(b => b.Idlav13).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav14).WithMany().HasForeignKey(b => b.Idlav14).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav15).WithMany().HasForeignKey(b => b.Idlav15).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabSimboliLav16).WithMany().HasForeignKey(b => b.IdLav16).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabRagg1).WithMany().HasForeignKey(b => b.IdRagg1).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabRagg2).WithMany().HasForeignKey(b => b.IdRagg2).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabRagg3).WithMany().HasForeignKey(b => b.IdRagg3).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabRagg4).WithMany().HasForeignKey(b => b.IdRagg4).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabRagg5).WithMany().HasForeignKey(b => b.IdRagg5).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabCatMerceologica).WithMany().HasForeignKey(b => b.IdCatMerc).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabGender).WithMany().HasForeignKey(b => b.IdGender).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.TabTipoMpScar).WithMany().HasForeignKey(b => b.IdMpscar).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(b => b.BasiImmagini).WithMany().HasForeignKey(b => b.PathImg).HasPrincipalKey(i => i.PathImg).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
        });
    }
}
