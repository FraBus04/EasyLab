using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class StatoFasi
{
    public int Id { get; set; }

    public int IdMod { get; set; }

    public int IdLancio { get; set; }

    public int IdFase { get; set; }

    public int IdUte { get; set; }

    public DateTime? Data { get; set; }
}
