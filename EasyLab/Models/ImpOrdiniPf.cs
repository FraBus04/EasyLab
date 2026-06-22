using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpOrdiniPf
{
    public int Id { get; set; }

    public string? Stato { get; set; }

    public long? IdErpOrd { get; set; }

    public int? IdErpRiga { get; set; }

    public int? IdOrdImp { get; set; }

    public int? IdStag { get; set; }

    public int? IdContatto { get; set; }

    public string? OrdTipo { get; set; }

    public int? OrdNr { get; set; }

    public DateOnly? OrdData { get; set; }

    public int? Ccli { get; set; }

    public int? CcliDest { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? ProgRiga { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public double? PzArt { get; set; }

    public short? Nr1 { get; set; }

    public short? Nr2 { get; set; }

    public short? Nr3 { get; set; }

    public short? Nr4 { get; set; }

    public short? Nr5 { get; set; }

    public short? Nr6 { get; set; }

    public short? Nr7 { get; set; }

    public short? Nr8 { get; set; }

    public short? Nr9 { get; set; }

    public short? Nr10 { get; set; }

    public short? Nr11 { get; set; }

    public int? TotCapi { get; set; }

    public string? CodMag { get; set; }

    public string? NotaRiga { get; set; }

    public string? MagPrel { get; set; }

    public string? StatoImp { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdModNoStag { get; set; }

    public short? Nr12 { get; set; }

    public short? Nr13 { get; set; }

    public short? Nr14 { get; set; }

    public short? Nr15 { get; set; }

    public short? Nr16 { get; set; }

    public int? IdSetGroup { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

    public DateOnly? DataCons { get; set; }

    public string? CdValuta { get; set; }

    public int? IdSet { get; set; }

    public int? IdStagMod { get; set; }

    public string? L { get; set; }

    public double? Sco1 { get; set; }

    public bool? CkErr { get; set; }
}
