using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabNazioni
{
    public int Id { get; set; }

    public string? Cod { get; set; }

    public string? Cod2 { get; set; }

    public string? CodNum { get; set; }

    public string? Nazione { get; set; }

    public int? Ue { get; set; }

    public string? Isolocali { get; set; }

    public string? Link { get; set; }

    public byte[]? Immagine { get; set; }

    public int? IdWiki { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
