using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class StatoAppLog
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdClasse { get; set; }

    public int IdSottoClasse { get; set; }

    public int IdRif { get; set; }

    public string StatoApp { get; set; } = null!;

    public string Nota { get; set; } = null!;

    public bool CkLock { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }
}
