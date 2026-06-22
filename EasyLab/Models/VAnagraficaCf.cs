using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VAnagraficaCf
{
    public int? IdContatto { get; set; }

    public int Id { get; set; }

    public string Anag1 { get; set; } = null!;

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? CapNew { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Nazione { get; set; }

    public string? RifIdContatto { get; set; }

    public short? FladDestDiv { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Chiedere { get; set; }

    public string? Email { get; set; }

    public string? Piva { get; set; }

    public string? CodFisc { get; set; }

    public string Stato { get; set; } = null!;

    public int IdTipoAnag { get; set; }

    public double? Sco1 { get; set; }

    public short? IdAg { get; set; }

    public string? AreaCfcod { get; set; }

    public string? AreaCfdesc { get; set; }

    public int? IdAreaCf { get; set; }

    public string? Mid { get; set; }

    public short? IdNazione { get; set; }

    public string? NazioneCod { get; set; }

    public string? NazioneDesc { get; set; }

    public string? TipoListCod { get; set; }

    public string? TipoListDesc { get; set; }

    public int? IdCanale { get; set; }

    public string? Canale { get; set; }

    public string? CdValuta { get; set; }

    public string? Valuta { get; set; }

    public int? IdCcliFather { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
