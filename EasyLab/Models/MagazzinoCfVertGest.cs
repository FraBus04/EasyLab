using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagazzinoCfVertGest
{
    public int Id { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string? Nome { get; set; }

    public string CodCol { get; set; } = null!;

    public int? IdSet { get; set; }

    public int? IdTaglia { get; set; }

    public int? IdTagliaOrd { get; set; }

    public string Taglia { get; set; } = null!;

    public int IdBarcode { get; set; }

    public string? Ean13 { get; set; }

    public string? CodMag1 { get; set; }

    public int? Nr1 { get; set; }

    public int? Impeg1 { get; set; }

    public int? Libero1 { get; set; }

    public int? Spost1 { get; set; }

    public int? Nr1New { get; set; }

    public string? CodMag2 { get; set; }

    public int? Nr2 { get; set; }

    public int? Impeg2 { get; set; }

    public int? Libero2 { get; set; }

    public int? Spost2 { get; set; }

    public int? Nr2New { get; set; }

    public string? CodMag3 { get; set; }

    public int? Nr3 { get; set; }

    public int? Impeg3 { get; set; }

    public int? Libero3 { get; set; }

    public int? Spost3 { get; set; }

    public int? Nr3New { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? Mas { get; set; }

    public bool? CkAnagWeb { get; set; }

    public bool? LsFw21 { get; set; }

    public bool? LsFw21Saldi { get; set; }

    public bool? LsFw22 { get; set; }

    public bool? LsSs22 { get; set; }

    public string? StatoPv { get; set; }

    public int? Tws { get; set; }

    public int? LiberoTemp1 { get; set; }

    public int? LiberoTemp2 { get; set; }

    public int? LiberoTemp3 { get; set; }
}
