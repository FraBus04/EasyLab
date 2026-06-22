using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagazzinoCfVertImportLog
{
    public int Id { get; set; }

    public string LogDesc { get; set; } = null!;

    public int? CapiSt { get; set; }

    public int? CapiImp { get; set; }

    public DateTime? Ts { get; set; }

    public int? IdContatto { get; set; }

    public int? Ragg { get; set; }
}
