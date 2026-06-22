using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LogImport
{
    public int Id { get; set; }

    public DateTime? Ts { get; set; }

    public string Sp { get; set; } = null!;

    public string Tabella { get; set; } = null!;

    public int? NrRecordIns { get; set; }

    public int? Esito { get; set; }
}
