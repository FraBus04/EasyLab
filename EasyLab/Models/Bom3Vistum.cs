using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Bom3Vistum
{
    public int IdRigaReticolo { get; set; }

    public int IdUte { get; set; }

    public int? AIdContatto { get; set; }

    public string? AContatto { get; set; }

    public int? AIdStag { get; set; }

    public string? AStag { get; set; }

    public string? ATipo { get; set; }

    public string ACdAll { get; set; } = null!;

    public string? AParte { get; set; }

    public string? AParteDesc { get; set; }

    public string? AMod { get; set; }

    public string? ATess { get; set; }

    public string? ANome { get; set; }

    public int? IdSet { get; set; }

    public int? IdTagliaDa { get; set; }

    public int? IdTagliaA { get; set; }

    public int Seq { get; set; }

    public int IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public int? OrdPmFase { get; set; }

    public string? TipoModello { get; set; }

    public string? StatoMod { get; set; }

    public int? BIdContatto { get; set; }

    public string? BContatto { get; set; }

    public string? BTipo { get; set; }

    public string BCdAll { get; set; } = null!;

    public string? BParte { get; set; }

    public string? BParteDesc { get; set; }

    public string? BCodArtForn { get; set; }

    public int? BIdFornPref { get; set; }

    public string? BFornPref { get; set; }

    public short? Hutile { get; set; }

    public string? Tp { get; set; }

    public string? TpDesc { get; set; }

    public int? TpOrd { get; set; }

    public string Tp2 { get; set; } = null!;

    public string Tp3 { get; set; } = null!;

    public int? IdPos { get; set; }

    public string? CompPos { get; set; }

    public bool? ACkSemiLav { get; set; }

    public bool? BCkSemiLav { get; set; }

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public bool CkMatMis { get; set; }

    public bool CkColUnico { get; set; }

    public bool CkContr { get; set; }

    public string Posizione { get; set; } = null!;

    public string Note { get; set; } = null!;

    public double? Prz { get; set; }

    public string? CdRegolaCons { get; set; }

    public int? IdRegMis { get; set; }

    public string? RegMisCod { get; set; }

    public string? BUm { get; set; }

    public string? BUmutil { get; set; }

    public int? BUmutilConv { get; set; }

    public double Cons { get; set; }

    public double? Cons1 { get; set; }

    public double? Cons2 { get; set; }

    public double? Cons3 { get; set; }

    public double? Cons4 { get; set; }

    public double? Cons5 { get; set; }

    public double? Cons6 { get; set; }

    public double? Cons7 { get; set; }

    public double? Cons8 { get; set; }

    public double? Cons9 { get; set; }

    public double? Cons10 { get; set; }

    public double? Cons11 { get; set; }

    public double? Cons12 { get; set; }

    public double? Cons13 { get; set; }

    public double? Cons14 { get; set; }

    public double? Cons15 { get; set; }

    public double? Cons16 { get; set; }

    public string? ACdAllmis1 { get; set; }

    public string? ACdAllmis2 { get; set; }

    public string? ACdAllmis3 { get; set; }

    public string? ACdAllmis4 { get; set; }

    public string? ACdAllmis5 { get; set; }

    public string? ACdAllmis6 { get; set; }

    public string? ACdAllmis7 { get; set; }

    public string? ACdAllmis8 { get; set; }

    public string? ACdAllmis9 { get; set; }

    public string? ACdAllmis10 { get; set; }

    public string? ACdAllmis11 { get; set; }

    public string? ACdAllmis12 { get; set; }

    public string? ACdAllmis13 { get; set; }

    public string? ACdAllmis14 { get; set; }

    public string? ACdAllmis15 { get; set; }

    public string? ACdAllmis16 { get; set; }

    public string? AParteMis1 { get; set; }

    public string? AParteMis2 { get; set; }

    public string? AParteMis3 { get; set; }

    public string? AParteMis4 { get; set; }

    public string? AParteMis5 { get; set; }

    public string? AParteMis6 { get; set; }

    public string? AParteMis7 { get; set; }

    public string? AParteMis8 { get; set; }

    public string? AParteMis9 { get; set; }

    public string? AParteMis10 { get; set; }

    public string? AParteMis11 { get; set; }

    public string? AParteMis12 { get; set; }

    public string? AParteMis13 { get; set; }

    public string? AParteMis14 { get; set; }

    public string? AParteMis15 { get; set; }

    public string? AParteMis16 { get; set; }

    public bool? CkTg1 { get; set; }

    public bool? CkTg2 { get; set; }

    public bool? CkTg3 { get; set; }

    public bool? CkTg4 { get; set; }

    public bool? CkTg5 { get; set; }

    public bool? CkTg6 { get; set; }

    public bool? CkTg7 { get; set; }

    public bool? CkTg8 { get; set; }

    public bool? CkTg9 { get; set; }

    public bool? CkTg10 { get; set; }

    public bool? CkTg11 { get; set; }

    public bool? CkTg12 { get; set; }

    public bool? CkTg13 { get; set; }

    public bool? CkTg14 { get; set; }

    public bool? CkTg15 { get; set; }

    public bool? CkTg16 { get; set; }

    public string? ACdAllCol1 { get; set; }

    public string? ACdAllCol2 { get; set; }

    public string? ACdAllCol3 { get; set; }

    public string? ACdAllCol4 { get; set; }

    public string? ACdAllCol5 { get; set; }

    public string? ACdAllCol6 { get; set; }

    public string? ACdAllCol7 { get; set; }

    public string? ACdAllCol8 { get; set; }

    public string? ACdAllCol9 { get; set; }

    public string? ACdAllCol10 { get; set; }

    public string? ACdAllCol11 { get; set; }

    public string? ACdAllCol12 { get; set; }

    public string? ACdAllCol13 { get; set; }

    public string? ACdAllCol14 { get; set; }

    public string? ACdAllCol15 { get; set; }

    public string? ACdAllCol16 { get; set; }

    public string? ACdAllCol17 { get; set; }

    public string? ACdAllCol18 { get; set; }

    public string? ACdAllCol19 { get; set; }

    public string? ACdAllCol20 { get; set; }

    public string? ACol1 { get; set; }

    public string? ACol2 { get; set; }

    public string? ACol3 { get; set; }

    public string? ACol4 { get; set; }

    public string? ACol5 { get; set; }

    public string? ACol6 { get; set; }

    public string? ACol7 { get; set; }

    public string? ACol8 { get; set; }

    public string? ACol9 { get; set; }

    public string? ACol10 { get; set; }

    public string? ACol11 { get; set; }

    public string? ACol12 { get; set; }

    public string? ACol13 { get; set; }

    public string? ACol14 { get; set; }

    public string? ACol15 { get; set; }

    public string? ACol16 { get; set; }

    public string? ACol17 { get; set; }

    public string? ACol18 { get; set; }

    public string? ACol19 { get; set; }

    public string? ACol20 { get; set; }

    public string? AColDesc1 { get; set; }

    public string? AColDesc2 { get; set; }

    public string? AColDesc3 { get; set; }

    public string? AColDesc4 { get; set; }

    public string? AColDesc5 { get; set; }

    public string? AColDesc6 { get; set; }

    public string? AColDesc7 { get; set; }

    public string? AColDesc8 { get; set; }

    public string? AColDesc9 { get; set; }

    public string? AColDesc10 { get; set; }

    public string? AColDesc11 { get; set; }

    public string? AColDesc12 { get; set; }

    public string? AColDesc13 { get; set; }

    public string? AColDesc14 { get; set; }

    public string? AColDesc15 { get; set; }

    public string? AColDesc16 { get; set; }

    public string? AColDesc17 { get; set; }

    public string? AColDesc18 { get; set; }

    public string? AColDesc19 { get; set; }

    public string? AColDesc20 { get; set; }

    public byte[]? AImgCol1 { get; set; }

    public byte[]? AImgCol2 { get; set; }

    public byte[]? AImgCol3 { get; set; }

    public byte[]? AImgCol4 { get; set; }

    public byte[]? AImgCol5 { get; set; }

    public byte[]? AImgCol6 { get; set; }

    public byte[]? AImgCol7 { get; set; }

    public byte[]? AImgCol8 { get; set; }

    public byte[]? AImgCol9 { get; set; }

    public byte[]? AImgCol10 { get; set; }

    public byte[]? AImgCol11 { get; set; }

    public byte[]? AImgCol12 { get; set; }

    public byte[]? AImgCol13 { get; set; }

    public byte[]? AImgCol14 { get; set; }

    public byte[]? AImgCol15 { get; set; }

    public byte[]? AImgCol16 { get; set; }

    public byte[]? AImgCol17 { get; set; }

    public byte[]? AImgCol18 { get; set; }

    public byte[]? AImgCol19 { get; set; }

    public byte[]? AImgCol20 { get; set; }

    public bool? ACkColEnab1 { get; set; }

    public bool? ACkColEnab2 { get; set; }

    public bool? ACkColEnab3 { get; set; }

    public bool? ACkColEnab4 { get; set; }

    public bool? ACkColEnab5 { get; set; }

    public bool? ACkColEnab6 { get; set; }

    public bool? ACkColEnab7 { get; set; }

    public bool? ACkColEnab8 { get; set; }

    public bool? ACkColEnab9 { get; set; }

    public bool? ACkColEnab10 { get; set; }

    public bool? ACkColEnab11 { get; set; }

    public bool? ACkColEnab12 { get; set; }

    public bool? ACkColEnab13 { get; set; }

    public bool? ACkColEnab14 { get; set; }

    public bool? ACkColEnab15 { get; set; }

    public bool? ACkColEnab16 { get; set; }

    public bool? ACkColEnab17 { get; set; }

    public bool? ACkColEnab18 { get; set; }

    public bool? ACkColEnab19 { get; set; }

    public bool? ACkColEnab20 { get; set; }

    public bool? ACkMisEnab1 { get; set; }

    public bool? ACkMisEnab2 { get; set; }

    public bool? ACkMisEnab3 { get; set; }

    public bool? ACkMisEnab4 { get; set; }

    public bool? ACkMisEnab5 { get; set; }

    public bool? ACkMisEnab6 { get; set; }

    public bool? ACkMisEnab7 { get; set; }

    public bool? ACkMisEnab8 { get; set; }

    public bool? ACkMisEnab9 { get; set; }

    public bool? ACkMisEnab10 { get; set; }

    public bool? ACkMisEnab11 { get; set; }

    public bool? ACkMisEnab12 { get; set; }

    public bool? ACkMisEnab13 { get; set; }

    public bool? ACkMisEnab14 { get; set; }

    public bool? ACkMisEnab15 { get; set; }

    public bool? ACkMisEnab16 { get; set; }

    public string? BCdAllCol1 { get; set; }

    public string? BCdAllCol2 { get; set; }

    public string? BCdAllCol3 { get; set; }

    public string? BCdAllCol4 { get; set; }

    public string? BCdAllCol5 { get; set; }

    public string? BCdAllCol6 { get; set; }

    public string? BCdAllCol7 { get; set; }

    public string? BCdAllCol8 { get; set; }

    public string? BCdAllCol9 { get; set; }

    public string? BCdAllCol10 { get; set; }

    public string? BCdAllCol11 { get; set; }

    public string? BCdAllCol12 { get; set; }

    public string? BCdAllCol13 { get; set; }

    public string? BCdAllCol14 { get; set; }

    public string? BCdAllCol15 { get; set; }

    public string? BCdAllCol16 { get; set; }

    public string? BCdAllCol17 { get; set; }

    public string? BCdAllCol18 { get; set; }

    public string? BCdAllCol19 { get; set; }

    public string? BCdAllCol20 { get; set; }

    public string? BCol1 { get; set; }

    public string? BCol2 { get; set; }

    public string? BCol3 { get; set; }

    public string? BCol4 { get; set; }

    public string? BCol5 { get; set; }

    public string? BCol6 { get; set; }

    public string? BCol7 { get; set; }

    public string? BCol8 { get; set; }

    public string? BCol9 { get; set; }

    public string? BCol10 { get; set; }

    public string? BCol11 { get; set; }

    public string? BCol12 { get; set; }

    public string? BCol13 { get; set; }

    public string? BCol14 { get; set; }

    public string? BCol15 { get; set; }

    public string? BCol16 { get; set; }

    public string? BCol17 { get; set; }

    public string? BCol18 { get; set; }

    public string? BCol19 { get; set; }

    public string? BCol20 { get; set; }

    public string? BColDesc1 { get; set; }

    public string? BColDesc2 { get; set; }

    public string? BColDesc3 { get; set; }

    public string? BColDesc4 { get; set; }

    public string? BColDesc5 { get; set; }

    public string? BColDesc6 { get; set; }

    public string? BColDesc7 { get; set; }

    public string? BColDesc8 { get; set; }

    public string? BColDesc9 { get; set; }

    public string? BColDesc10 { get; set; }

    public string? BColDesc11 { get; set; }

    public string? BColDesc12 { get; set; }

    public string? BColDesc13 { get; set; }

    public string? BColDesc14 { get; set; }

    public string? BColDesc15 { get; set; }

    public string? BColDesc16 { get; set; }

    public string? BColDesc17 { get; set; }

    public string? BColDesc18 { get; set; }

    public string? BColDesc19 { get; set; }

    public string? BColDesc20 { get; set; }

    public string? BMatColForn1 { get; set; }

    public string? BMatColForn2 { get; set; }

    public string? BMatColForn3 { get; set; }

    public string? BMatColForn4 { get; set; }

    public string? BMatColForn5 { get; set; }

    public string? BMatColForn6 { get; set; }

    public string? BMatColForn7 { get; set; }

    public string? BMatColForn8 { get; set; }

    public string? BMatColForn9 { get; set; }

    public string? BMatColForn10 { get; set; }

    public string? BMatColForn11 { get; set; }

    public string? BMatColForn12 { get; set; }

    public string? BMatColForn13 { get; set; }

    public string? BMatColForn14 { get; set; }

    public string? BMatColForn15 { get; set; }

    public string? BMatColForn16 { get; set; }

    public string? BMatColForn17 { get; set; }

    public string? BMatColForn18 { get; set; }

    public string? BMatColForn19 { get; set; }

    public string? BMatColForn20 { get; set; }

    public byte[]? BImgCol1 { get; set; }

    public byte[]? BImgCol2 { get; set; }

    public byte[]? BImgCol3 { get; set; }

    public byte[]? BImgCol4 { get; set; }

    public byte[]? BImgCol5 { get; set; }

    public byte[]? BImgCol6 { get; set; }

    public byte[]? BImgCol7 { get; set; }

    public byte[]? BImgCol8 { get; set; }

    public byte[]? BImgCol9 { get; set; }

    public byte[]? BImgCol10 { get; set; }

    public byte[]? BImgCol11 { get; set; }

    public byte[]? BImgCol12 { get; set; }

    public byte[]? BImgCol13 { get; set; }

    public byte[]? BImgCol14 { get; set; }

    public byte[]? BImgCol15 { get; set; }

    public byte[]? BImgCol16 { get; set; }

    public byte[]? BImgCol17 { get; set; }

    public byte[]? BImgCol18 { get; set; }

    public byte[]? BImgCol19 { get; set; }

    public byte[]? BImgCol20 { get; set; }

    public string? BCdAllmis { get; set; }

    public string? BCdAllmis1 { get; set; }

    public string? BCdAllmis2 { get; set; }

    public string? BCdAllmis3 { get; set; }

    public string? BCdAllmis4 { get; set; }

    public string? BCdAllmis5 { get; set; }

    public string? BCdAllmis6 { get; set; }

    public string? BCdAllmis7 { get; set; }

    public string? BCdAllmis8 { get; set; }

    public string? BCdAllmis9 { get; set; }

    public string? BCdAllmis10 { get; set; }

    public string? BCdAllmis11 { get; set; }

    public string? BCdAllmis12 { get; set; }

    public string? BCdAllmis13 { get; set; }

    public string? BCdAllmis14 { get; set; }

    public string? BCdAllmis15 { get; set; }

    public string? BCdAllmis16 { get; set; }

    public string? BParteMis { get; set; }

    public string? BParteMis1 { get; set; }

    public string? BParteMis2 { get; set; }

    public string? BParteMis3 { get; set; }

    public string? BParteMis4 { get; set; }

    public string? BParteMis5 { get; set; }

    public string? BParteMis6 { get; set; }

    public string? BParteMis7 { get; set; }

    public string? BParteMis8 { get; set; }

    public string? BParteMis9 { get; set; }

    public string? BParteMis10 { get; set; }

    public string? BParteMis11 { get; set; }

    public string? BParteMis12 { get; set; }

    public string? BParteMis13 { get; set; }

    public string? BParteMis14 { get; set; }

    public string? BParteMis15 { get; set; }

    public string? BParteMis16 { get; set; }

    public string? StatoAppDesc { get; set; }

    public int? Ver { get; set; }

    public string? NotaVer { get; set; }

    public string? OrdImp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public DateTime? DataImp { get; set; }

    public int? NrColori { get; set; }

    public int? OrdPmTp { get; set; }

    public int? IdPack { get; set; }
}
