using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Bom3VistaMaxDetail
{
    public int Id { get; set; }

    public int IdUte { get; set; }

    public string? ATipo { get; set; }

    public string? BTipo { get; set; }

    public int? AIdContatto { get; set; }

    public string? AContatto { get; set; }

    public int? BIdContatto { get; set; }

    public string? BContatto { get; set; }

    public int? IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public int IdRigaBom3Ret { get; set; }

    public string VistaDett { get; set; } = null!;

    public int? AIdStag { get; set; }

    public string? AStag { get; set; }

    public string? ACdAll { get; set; }

    public string? AParte { get; set; }

    public string? AParteDesc { get; set; }

    public string? AMod { get; set; }

    public string? ATess { get; set; }

    public string? BCdAll { get; set; }

    public string? BParte { get; set; }

    public string? BParteDesc { get; set; }

    public int? IdMod { get; set; }

    public string? TipoModello { get; set; }

    public string? StatoMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public int? IdMat { get; set; }

    public string? Mat { get; set; }

    public string? DescBreve { get; set; }

    public string? BCodArtForn { get; set; }

    public int? BIdFornPref { get; set; }

    public string? BFornPref { get; set; }

    public int? Seq { get; set; }

    public string? BUm { get; set; }

    public string? BUmutil { get; set; }

    public double? BUmutilConv { get; set; }

    public bool? CkMp { get; set; }

    public bool? CkMrp { get; set; }

    public bool? CkFabb { get; set; }

    public bool? CkMatMis { get; set; }

    public bool? CkColUnico { get; set; }

    public bool? CkContr { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public string? Tp { get; set; }

    public string? TpDesc { get; set; }

    public int? TpOrd { get; set; }

    public string? Tp2 { get; set; }

    public string? Tp3 { get; set; }

    public string? Tm { get; set; }

    public string? TmDescr { get; set; }

    public double? Cons { get; set; }

    public string? Cons1 { get; set; }

    public string? Cons2 { get; set; }

    public string? Cons3 { get; set; }

    public string? Cons4 { get; set; }

    public string? Cons5 { get; set; }

    public string? Cons6 { get; set; }

    public string? Cons7 { get; set; }

    public string? Cons8 { get; set; }

    public string? Cons9 { get; set; }

    public string? Cons10 { get; set; }

    public string? Cons11 { get; set; }

    public string? Cons12 { get; set; }

    public string? Cons13 { get; set; }

    public string? Cons14 { get; set; }

    public string? Cons15 { get; set; }

    public string? Cons16 { get; set; }

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

    public byte[]? AColImg1 { get; set; }

    public byte[]? AColImg2 { get; set; }

    public byte[]? AColImg3 { get; set; }

    public byte[]? AColImg4 { get; set; }

    public byte[]? AColImg5 { get; set; }

    public byte[]? AColImg6 { get; set; }

    public byte[]? AColImg7 { get; set; }

    public byte[]? AColImg8 { get; set; }

    public byte[]? AColImg9 { get; set; }

    public byte[]? AColImg10 { get; set; }

    public byte[]? AColImg11 { get; set; }

    public byte[]? AColImg12 { get; set; }

    public byte[]? AColImg13 { get; set; }

    public byte[]? AColImg14 { get; set; }

    public byte[]? AColImg15 { get; set; }

    public byte[]? AColImg16 { get; set; }

    public byte[]? AColImg17 { get; set; }

    public byte[]? AColImg18 { get; set; }

    public byte[]? AColImg19 { get; set; }

    public byte[]? AColImg20 { get; set; }

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

    public string? BMis { get; set; }

    public string? BMis1 { get; set; }

    public string? BMis2 { get; set; }

    public string? BMis3 { get; set; }

    public string? BMis4 { get; set; }

    public string? BMis5 { get; set; }

    public string? BMis6 { get; set; }

    public string? BMis7 { get; set; }

    public string? BMis8 { get; set; }

    public string? BMis9 { get; set; }

    public string? BMis10 { get; set; }

    public string? BMis11 { get; set; }

    public string? BMis12 { get; set; }

    public string? BMis13 { get; set; }

    public string? BMis14 { get; set; }

    public string? BMis15 { get; set; }

    public string? BMis16 { get; set; }

    public bool? CkAColEnab1 { get; set; }

    public bool? CkAColEnab2 { get; set; }

    public bool? CkAColEnab3 { get; set; }

    public bool? CkAColEnab4 { get; set; }

    public bool? CkAColEnab5 { get; set; }

    public bool? CkAColEnab6 { get; set; }

    public bool? CkAColEnab7 { get; set; }

    public bool? CkAColEnab8 { get; set; }

    public bool? CkAColEnab9 { get; set; }

    public bool? CkAColEnab10 { get; set; }

    public bool? CkAColEnab11 { get; set; }

    public bool? CkAColEnab12 { get; set; }

    public bool? CkAColEnab13 { get; set; }

    public bool? CkAColEnab14 { get; set; }

    public bool? CkAColEnab15 { get; set; }

    public bool? CkAColEnab16 { get; set; }

    public bool? CkAColEnab17 { get; set; }

    public bool? CkAColEnab18 { get; set; }

    public bool? CkAColEnab19 { get; set; }

    public bool? CkAColEnab20 { get; set; }

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

    public byte[]? BColImg1 { get; set; }

    public byte[]? BColImg2 { get; set; }

    public byte[]? BColImg3 { get; set; }

    public byte[]? BColImg4 { get; set; }

    public byte[]? BColImg5 { get; set; }

    public byte[]? BColImg6 { get; set; }

    public byte[]? BColImg7 { get; set; }

    public byte[]? BColImg8 { get; set; }

    public byte[]? BColImg9 { get; set; }

    public byte[]? BColImg10 { get; set; }

    public byte[]? BColImg11 { get; set; }

    public byte[]? BColImg12 { get; set; }

    public byte[]? BColImg13 { get; set; }

    public byte[]? BColImg14 { get; set; }

    public byte[]? BColImg15 { get; set; }

    public byte[]? BColImg16 { get; set; }

    public byte[]? BColImg17 { get; set; }

    public byte[]? BColImg18 { get; set; }

    public byte[]? BColImg19 { get; set; }

    public byte[]? BColImg20 { get; set; }

    public string? LabPrev { get; set; }

    public decimal? PzMat { get; set; }

    public decimal? PzTot { get; set; }
}
