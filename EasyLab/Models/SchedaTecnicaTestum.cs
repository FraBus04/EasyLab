using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SchedaTecnicaTestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdMod { get; set; }

    public int IdSchedaTecnicaTipo { get; set; }

    public string Cod { get; set; } = null!;

    public string? RichText { get; set; }

    public bool CkEffettiva { get; set; }

    public bool CkEasy { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }
}
