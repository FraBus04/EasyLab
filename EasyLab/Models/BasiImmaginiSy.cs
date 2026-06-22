using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiImmaginiSy
{
    public int Id { get; set; }

    public string PathImg { get; set; } = null!;

    public byte[]? Immagine16 { get; set; }

    public byte[]? Immagine20 { get; set; }

    public byte[]? Immagine32 { get; set; }

    public byte[]? Immagine16False { get; set; }

    public byte[]? Immagine20False { get; set; }

    public byte[]? Immagine32False { get; set; }

    public byte[]? Immagine100 { get; set; }

    public string? Filtro { get; set; }
}
