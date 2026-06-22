using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiImmagini
{
    public int Id { get; set; }

    public string PathImg { get; set; } = null!;

    public byte[]? Immagine { get; set; }

    public string Stato { get; set; } = null!;

    public byte[]? Immagine1 { get; set; }

    public byte[]? Immagine2 { get; set; }

    public int? Usato { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
