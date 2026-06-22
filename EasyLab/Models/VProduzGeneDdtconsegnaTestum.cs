using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzGeneDdtconsegnaTestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public int NrDoc { get; set; }

    public DateTime DataDoc { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public int OrdNr { get; set; }

    public string? Rif { get; set; }

    public int? NrColli { get; set; }

    public double? KgTot { get; set; }

    public string? Nota { get; set; }

    public int? TotCapi { get; set; }

    public double? TotVal { get; set; }

    public string? StrVettore { get; set; }

    public int? IdDdtCausale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public bool? FlagGiaExp { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? CapNew { get; set; }

    public string? NazioneCod { get; set; }

    public string? NazioneDesc { get; set; }

    public string? Anag1Dest { get; set; }

    public string? Anag2Dest { get; set; }

    public string? ViaDest { get; set; }

    public string? CittaDest { get; set; }

    public string? ProvDest { get; set; }

    public string? Capdest { get; set; }

    public string? NazioneCodDest { get; set; }

    public string? NazioneDescDest { get; set; }

    public string? Causale { get; set; }

    public string? TraspCura { get; set; }

    public string? Vettore { get; set; }

    public string? Aspetto { get; set; }
}
