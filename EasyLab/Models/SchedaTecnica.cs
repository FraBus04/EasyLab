using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SchedaTecnica
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public int IdGruppo { get; set; }

    public int IdDett { get; set; }

    public int OrdPm { get; set; }

    public string RichText { get; set; } = null!;

    public string? PathImg { get; set; }

    public int StatoEdit { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
