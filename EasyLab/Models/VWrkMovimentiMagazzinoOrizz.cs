using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VWrkMovimentiMagazzinoOrizz
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public string Stato { get; set; } = null!;

    public int IdMod { get; set; }

    public int? Nr1 { get; set; }

    public int? Nr2 { get; set; }

    public int? Nr3 { get; set; }

    public int? Nr4 { get; set; }

    public int? Nr5 { get; set; }

    public int? Nr6 { get; set; }

    public int? Nr7 { get; set; }

    public int? Nr8 { get; set; }

    public int? Nr9 { get; set; }

    public int? Nr10 { get; set; }

    public int? Nr11 { get; set; }

    public int? TotCapi { get; set; }

    public string? CodCol { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdContatto { get; set; }

    public DateOnly? DataMov { get; set; }

    public string? MovCod { get; set; }

    public string? MovDesc { get; set; }

    public string? CodMagDa { get; set; }

    public string? CodMagA { get; set; }

    public string? NrDdt { get; set; }

    public DateOnly? DataDdt { get; set; }

    public string? Lab { get; set; }

    public bool? Aperto { get; set; }

    public int? TotCapiTesta { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public int? IdCausale { get; set; }

    public int? IdCausaleOpp { get; set; }

    public string? MovOppCod { get; set; }

    public string? MovOppDesc { get; set; }

    public int? IdSet { get; set; }

    public int? IdRigaOrd { get; set; }

    public string? CodUbic { get; set; }

    public string? Tg1 { get; set; }

    public string? Tg2 { get; set; }

    public string? Tg3 { get; set; }

    public string? Tg4 { get; set; }

    public string? Tg5 { get; set; }

    public string? Tg6 { get; set; }

    public string? Tg7 { get; set; }

    public string? Tg8 { get; set; }

    public string? Tg9 { get; set; }

    public string? Tg10 { get; set; }

    public string? Tg11 { get; set; }

    public string? DescCol { get; set; }

    public int? TotVal { get; set; }

    public double? KgTot { get; set; }

    public int? NrColli { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public int? IdDdtCausale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public int? IdComm { get; set; }

    public int? IdLista { get; set; }
}
