using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Contatti
{
    public int Id { get; set; }

    public string Societa1 { get; set; } = null!;

    public string? Societa2 { get; set; }

    public string? Chedere { get; set; }

    public string? Posizione { get; set; }

    public string? Nota { get; set; }

    public string? Cell { get; set; }

    public string? Tel { get; set; }

    public string? Email { get; set; }

    public string? Via { get; set; }

    public string? Cap { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Stato { get; set; }

    public int? IdTabAnagCliFor { get; set; }

    public int? IdTabClassiDocumentiListiniMp { get; set; }

    public string? PathLogo { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public byte[]? Immagine { get; set; }

    public decimal PercAddCosti { get; set; }

    public decimal SchedaCostoCostoFisso { get; set; }

    public decimal MarkUpIni { get; set; }

    public bool? CreaEan { get; set; }

    public int? EanKey { get; set; }

    public string? EanDaDove { get; set; }

    public int? IdTipoListBase { get; set; }

    public string? CdMagAss { get; set; }

    public int? IdSkvalMp { get; set; }

    public string? RegIvaerp { get; set; }

    public string? RegLinea { get; set; }

    public virtual ICollection<ProduzBuonoPrelievoMpRiepilogo> ProduzBuonoPrelievoMpRiepilogos { get; set; } = new List<ProduzBuonoPrelievoMpRiepilogo>();
}
