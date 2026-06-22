using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabLang
{
    public int Id { get; set; }

    public string Lang { get; set; } = null!;

    public byte[]? Immagine { get; set; }
}
