using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImportPartiLog
{
    public int Id { get; set; }

    public DateTime? Ts { get; set; }

    public string? Parte { get; set; }

    public string? TipoAcquistoProdotto { get; set; }

    public string? Idtessuto { get; set; }

    public string? StagNascita { get; set; }

    public string? MatTaglio { get; set; }

    public string? AbbModello { get; set; }

    public string? Descrizione { get; set; }

    public string? FornPrefCod { get; set; }

    public string? FornDesc { get; set; }

    public string? CodiceArtFornitore { get; set; }

    public string? TipoCosto { get; set; }

    public double? CostoSt { get; set; }

    public string? Annullato { get; set; }

    public string? MatAColore { get; set; }

    public string? ClasseMercCod { get; set; }

    public string? ClasseMercDesc { get; set; }

    public string? SottoClasseCod { get; set; }

    public string? SottoClasseDesc { get; set; }

    public string? TipoMatCod { get; set; }

    public string? TipoMatDesc { get; set; }

    public string? GestioneAmisura { get; set; }

    public string? EtichettaLavaggi1 { get; set; }

    public string? EtichettaLavaggi2 { get; set; }

    public string? EtichettaLavaggi3 { get; set; }

    public string? EtichettaLavaggi4 { get; set; }

    public string? EtichettaLavaggi5 { get; set; }

    public string? EtichettaLavaggi6 { get; set; }

    public string? CompCod { get; set; }

    public string? CompDesc { get; set; }

    public string? MadeInCod { get; set; }

    public string? Uminterna { get; set; }

    public string? Umacquisti { get; set; }

    public string? Umpeso { get; set; }

    public double? Peso { get; set; }

    public string? TrattCod { get; set; }

    public string? TrattDesc { get; set; }

    public double? HPezzaSt { get; set; }

    public double? HPezzaUti { get; set; }

    public string? ClasseSfridoCod { get; set; }

    public string? ClasseSfridoDesc { get; set; }

    public string? AttrOriginePreferenziale { get; set; }

    public string? LeadTime { get; set; }

    public double? LungPezze { get; set; }

    public double? MinProduzione { get; set; }

    public string? HsCode { get; set; }

    public string? ColAbilitatoCod { get; set; }

    public string? ColAbilitatoDesc { get; set; }

    public string? ColAbilitato { get; set; }

    public string? MisureAbilitateCod { get; set; }

    public string? MisureAbilitatoDesc { get; set; }

    public string? MisureAbilitato { get; set; }

    public double? MisureAbilitatoCostoSt { get; set; }
}
