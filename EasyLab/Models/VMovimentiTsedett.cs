using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMovimentiTsedett
{
    public string? StatoDoc { get; set; }

    public string? TipoDoc { get; set; }

    public string? SottotipoDoc { get; set; }

    public string? CodDocumento { get; set; }

    public string? CodDocumentoDesc { get; set; }

    public string? DataDoc { get; set; }

    public string? CliFor { get; set; }

    public string? RagioneSocialeAnagrafica { get; set; }

    public string? DataCons { get; set; }

    public double? TotImponibile { get; set; }

    public double? TotIva { get; set; }

    public double? TotDocumento { get; set; }

    public string? PoJoor { get; set; }

    public string? Dep { get; set; }

    public string? DescrizioneDeposito { get; set; }

    public string? AgentePref { get; set; }

    public string? RagioneSocialeAgentePref { get; set; }

    public string? Porto { get; set; }

    public string? CausTrasporto { get; set; }

    public string? Stagione { get; set; }

    public byte? RigaDoc { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodArticolo { get; set; }

    public string? DescrizioneArticolo { get; set; }

    public string? Um1 { get; set; }

    public double? Qta1Doc { get; set; }

    public double? Qta1Trasf { get; set; }

    public double? Qta1Res { get; set; }

    public int? Prezzo1 { get; set; }

    public byte? Sc1 { get; set; }

    public byte? Sc2 { get; set; }

    public double? ImportoRiga { get; set; }

    public int? PrezzoNetto1 { get; set; }

    public byte? Iva { get; set; }

    public string? AliquotaIvaEffettiva { get; set; }

    public string? DataConsInt { get; set; }

    public string? DescrizioneDep { get; set; }

    public string? CodArtCliFor { get; set; }

    public string? DescArtCliFor { get; set; }

    public string? TipoOmaggio { get; set; }

    public string? CausaleDiMagazzino { get; set; }

    public string? DocOrigine { get; set; }
}
