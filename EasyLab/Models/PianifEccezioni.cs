using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class PianifEccezioni
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }
}
