using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelCommMp
{
    public int Id { get; set; }

    public int IdUte { get; set; }

    public string CdAll { get; set; } = null!;

    public string CdAllcol { get; set; } = null!;

    public string CdAllmis { get; set; } = null!;

    public decimal Qta { get; set; }

    public DateTime DataIns { get; set; }
}
