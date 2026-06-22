using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliTaglie
{
    public int Id { get; set; }

    public int IdMod { get; set; }

    public int IdSet { get; set; }

    public int IdTg { get; set; }

    public string Tg { get; set; } = null!;

    public int OrdPm { get; set; }

    public bool CkEnab { get; set; }
}
