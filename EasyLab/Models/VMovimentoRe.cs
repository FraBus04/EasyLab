using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMovimentoRe
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public int? IdRetail { get; set; }

    public string? Retail { get; set; }

    public int? IdUte { get; set; }

    public string? Ute { get; set; }

    public DateTime? DataMov { get; set; }

    public string? StagCod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? Tg { get; set; }

    public string Ean { get; set; } = null!;

    public int IdCausale { get; set; }

    public int IdMov { get; set; }

    public string CodMag { get; set; } = null!;

    public bool Ck { get; set; }

    public string Nota { get; set; } = null!;

    public int Qt { get; set; }

    public double Pz { get; set; }

    public double Sconto { get; set; }

    public double Tot { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdEan { get; set; }

    public int? IdMod { get; set; }

    public string? PathImg { get; set; }

    public bool? CkTesta { get; set; }

    public int? IdContatto { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? OrdTg { get; set; }

    public int? IdModCol { get; set; }

    public int QtMag { get; set; }

    public string? CatMerc { get; set; }

    public int? IdCcli { get; set; }

    public string? Cliente { get; set; }

    public string? NotaScontrino { get; set; }

    public bool? CkVenditaWeb { get; set; }
}
