using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SchedaTecnicaOperazioni
{
    public int Id { get; set; }

    public int IdSchedaTecnica { get; set; }

    public int IdOperazione { get; set; }

    public string? Nota { get; set; }

    public int? Ord { get; set; }

    public string? Nota1 { get; set; }
}
