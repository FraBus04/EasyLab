using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LogAccessi
{
    public int Id { get; set; }

    public DateTime DataIns { get; set; }

    public string Ute { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string Versione { get; set; } = null!;

    public string Pc { get; set; } = null!;

    public bool Esito { get; set; }
}
