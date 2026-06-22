using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSchedaTecnicaTestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public string? StatoDesc { get; set; }

    public int IdContatto { get; set; }

    public int IdMod { get; set; }

    public int IdSchedaTecnicaTipo { get; set; }

    public string? SchedaTecnicaTipo { get; set; }

    public string Cod { get; set; } = null!;

    public string? RichText { get; set; }

    public bool CkEffettiva { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public bool CkEasy { get; set; }
}
