using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Bom3packReticolo
{
    public int Id { get; set; }

    public int IdPack { get; set; }

    public string ATipo { get; set; } = null!;

    public int AIdContatto { get; set; }

    public int AIdStag { get; set; }

    public string ACdAll { get; set; } = null!;

    public bool ACkSemilav { get; set; }

    public int IdFase { get; set; }

    public int Seq { get; set; }

    public string? BTipo { get; set; }

    public string? BCdAll { get; set; }

    public string? BCdAllcol { get; set; }

    public string? BParteCol { get; set; }

    public string Um { get; set; } = null!;

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public bool CkMatMis { get; set; }

    public bool CkColUnico { get; set; }

    public string Posizione { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Tp { get; set; } = null!;

    public string Tp2 { get; set; } = null!;

    public string Tp3 { get; set; } = null!;

    public int? IdPos { get; set; }

    public string? CdRegolaCons { get; set; }

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

    public string? ACdAllmis { get; set; }

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

    public string? ParteMis { get; set; }

    public string? ParteMis1 { get; set; }

    public string? ParteMis2 { get; set; }

    public string? ParteMis3 { get; set; }

    public string? ParteMis4 { get; set; }

    public string? ParteMis5 { get; set; }

    public string? ParteMis6 { get; set; }

    public string? ParteMis7 { get; set; }

    public string? ParteMis8 { get; set; }

    public string? ParteMis9 { get; set; }

    public string? ParteMis10 { get; set; }

    public string? ParteMis11 { get; set; }

    public string? ParteMis12 { get; set; }

    public string? ParteMis13 { get; set; }

    public string? ParteMis14 { get; set; }

    public string? ParteMis15 { get; set; }

    public string? ParteMis16 { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public bool? BCkSemilav { get; set; }
}
