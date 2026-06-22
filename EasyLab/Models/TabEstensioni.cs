using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabEstensioni
{
    public string Estn { get; set; } = null!;

    public byte[]? Immagine16 { get; set; }

    public byte[]? Immagine20 { get; set; }

    public byte[]? Immagine32 { get; set; }
}
