using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzBuonoPrelievoMpRiepilogo
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int NrBuono { get; set; }

    public int IdLab { get; set; }

    public int NrScheda { get; set; }

    public string? CdMat { get; set; }

    public string Lotto { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public string Mis { get; set; } = null!;

    public string? NrPezza { get; set; }

    public double? Qta { get; set; }

    public string? MagLogico { get; set; }

    public string? CdMag { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public string? Nota { get; set; }

    public string Stato { get; set; } = null!;

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public int? IdComm { get; set; }

    public int? IdTesta { get; set; }

    public int? IdForn { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public virtual Contatti IdContattoNavigation { get; set; } = null!;
}
