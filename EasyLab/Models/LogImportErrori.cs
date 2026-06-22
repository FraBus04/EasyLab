using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LogImportErrori
{
    public int Id { get; set; }

    public DateTime? Ts { get; set; }

    public string Sp { get; set; } = null!;

    public string Tabella { get; set; } = null!;

    public string? ErrorDesc { get; set; }
}
