using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabAnagCliFor
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string Anag1 { get; set; } = null!;

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? Nciv { get; set; }

    public string? Cap { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Chiedere { get; set; }

    public string? Email { get; set; }

    /// <summary>
    /// 1	Clienti
    /// 2	Fornitore
    /// 3	Proprietà
    /// 4	Laboratori
    /// 5                Agenti
    /// 6                Vettori
    /// 7                Clienti CRM
    /// </summary>
    public int IdTipoAnag { get; set; }

    public string? PathLogo { get; set; }

    public string Stato { get; set; } = null!;

    public string? Piva { get; set; }

    public string? CodFisc { get; set; }

    public int? IdPadre { get; set; }

    public string? CodFornitore { get; set; }

    public short? FladDestDiv { get; set; }

    public string? Nazione { get; set; }

    public int? IdContatto { get; set; }

    public string? RifIdContatto { get; set; }

    public double? Sco1 { get; set; }

    public string? CapNew { get; set; }

    public int? IdAg { get; set; }

    public int? IdAreaCf { get; set; }

    public int? IdRaggCf { get; set; }

    public string? Mid { get; set; }

    public int? IdNazione { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdImport { get; set; }

    public int? IdTipoList { get; set; }

    public string? CdValuta { get; set; }

    public int? IdTipo { get; set; }

    public int? IdCcliFather { get; set; }

    public int? IdCanale { get; set; }

    public int? IdVoto { get; set; }

    public int? IdRagg1 { get; set; }

    public int? IdRagg2 { get; set; }

    public int? IdRagg3 { get; set; }

    public int? IdRagg4 { get; set; }

    public int? IdRagg5 { get; set; }

    public DateOnly? DataAcq { get; set; }

    public string? TelCell { get; set; }

    public string? Sito { get; set; }

    public int? IdModoCorrisp { get; set; }

    public string? EmailPec { get; set; }

    public string? Nota { get; set; }

    public int? IdPag { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtResa { get; set; }

    public string? CdSdi { get; set; }

    public string? CdAbi { get; set; }

    public string? CdCab { get; set; }

    public string? CdCin { get; set; }

    public string? CdIban { get; set; }

    public string? CdCc { get; set; }

    public string? CdBanca { get; set; }

    public string? CdFiliale { get; set; }

    public string? Alias { get; set; }

    public int? IdImport2 { get; set; }

    public int? IdVb6 { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoExp { get; set; }

    public int? IdCodIva { get; set; }

    public string? CdMag { get; set; }

    public byte[]? Immagine { get; set; }

    public double? Tempo { get; set; }

    public string? StatoImp { get; set; }
}
