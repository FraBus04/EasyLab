using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneDdtconsegna
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int NrDoc { get; set; }

    public DateTime DataDoc { get; set; }

    public int OrdNr { get; set; }

    public string? Rif { get; set; }

    public int? NrColli { get; set; }

    public double? KgTot { get; set; }

    public string? Nota { get; set; }

    public int? TotCapi { get; set; }

    public double? ValUnit { get; set; }

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

    public string? StrVettore { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public int? IdDdtCausale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public double? PzArt { get; set; }

    public int? IdCatMerc { get; set; }

    public int? NrRiga { get; set; }

    public bool? FlagGiaExp { get; set; }

    public int? IdTesta { get; set; }

    public int? IdBox { get; set; }

    public int? IdOrd { get; set; }

    public int? IdDoc { get; set; }

    public int? CkControllo { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdMovCf { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdRigaOrd { get; set; }
}
