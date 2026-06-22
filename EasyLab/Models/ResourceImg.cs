using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ResourceImg
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public byte[]? Immagine { get; set; }
}
