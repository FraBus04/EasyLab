using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Bom3packVistum
{
    public int IdRigaReticolo { get; set; }

    public int IdUte { get; set; }

    public int? IdSet { get; set; }

    public int? IdTagliaDa { get; set; }

    public int? IdTagliaA { get; set; }

    public int Seq { get; set; }

    public int IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public int? OrdPmFase { get; set; }

    public string? TipoModello { get; set; }

    public int? BIdContatto { get; set; }

    public string? BContatto { get; set; }

    public string? BTipo { get; set; }

    public string BCdAll { get; set; } = null!;

    public string? BParte { get; set; }

    public string? BParteDesc { get; set; }

    public string? Tp { get; set; }

    public string? TpDesc { get; set; }

    public int? TpOrd { get; set; }

    public string Tp2 { get; set; } = null!;

    public string Tp3 { get; set; } = null!;

    public int? IdPos { get; set; }

    public string? CompPos { get; set; }

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public bool CkMatMis { get; set; }

    public bool CkColUnico { get; set; }

    public bool CkContr { get; set; }

    public string Posizione { get; set; } = null!;

    public string Note { get; set; } = null!;

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

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? OrdPmTp { get; set; }
}
