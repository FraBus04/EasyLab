using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class PianifDateLancio
{
    public int Id { get; set; }

    public int IdFase { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public DateOnly? DataPianif { get; set; }

    public int? LeadTimeGg { get; set; }

    public DateTime DataIns { get; set; }

    public int IdUteIns { get; set; }
}
