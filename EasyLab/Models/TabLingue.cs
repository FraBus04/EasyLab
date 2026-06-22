using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabLingue
{
    public int Id { get; set; }

    public string Cod { get; set; } = null!;

    public byte[]? Immagine { get; set; }
}
