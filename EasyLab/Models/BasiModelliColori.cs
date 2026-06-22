using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliColori
{
    public int Id { get; set; }

    public string? Cd { get; set; }

    public string? Stato { get; set; }

    public int? IdStag { get; set; }

    public int IdMod { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public string CodCol { get; set; } = null!;

    public string DescCol { get; set; } = null!;

    public string? CodColForn { get; set; }

    public int? OrdPm { get; set; }

    public string? PathImg { get; set; }

    public string? PathImg2 { get; set; }

    public bool Enabled { get; set; }

    public string? Cartella { get; set; }

    public bool? CkSkCalcolo { get; set; }

    public string? StatoPv { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public string? Nota { get; set; }

    public DateTime? DataImp { get; set; }

    public string? CdAll { get; set; }
}
