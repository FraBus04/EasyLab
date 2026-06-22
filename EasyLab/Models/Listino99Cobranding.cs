using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Listino99Cobranding
{
    public string Articolo { get; set; } = null!;

    public byte QtaAbs { get; set; }

    public double Listino99 { get; set; }
}
