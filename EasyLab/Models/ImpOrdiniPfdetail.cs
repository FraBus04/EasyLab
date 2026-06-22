using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpOrdiniPfdetail
{
    public int Id { get; set; }

    public string? Stato { get; set; }

    public int? IdErpOrd { get; set; }

    public int? IdErpRiga { get; set; }

    public int? IdOrdImp { get; set; }

    public int? IdStag { get; set; }

    public int? IdContatto { get; set; }

    public string? OrdTipo { get; set; }

    public int? OrdNr { get; set; }

    public DateOnly? OrdData { get; set; }

    public int? Ccli { get; set; }

    public int? CcliDest { get; set; }

    public int? IdOrd { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTg { get; set; }

    public int? IdSetOrd { get; set; }

    public int? IdSetGroup { get; set; }

    public int? ProgRiga { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string? Tg { get; set; }

    public double? PzArt { get; set; }

    public short? Nr { get; set; }

    public decimal? Prz { get; set; }

    public string? CdMag { get; set; }

    public string? NotaRiga { get; set; }

    public string? MagPrel { get; set; }

    public string? StatoImp { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUteIns { get; set; }

    public bool? CkErr { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

    public DateOnly? DataCons { get; set; }

    public string? CdValuta { get; set; }

    public int? Sco1 { get; set; }
}
