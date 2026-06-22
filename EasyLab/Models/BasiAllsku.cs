using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiAllsku
{
    public long Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string CdAll { get; set; } = null!;

    public string CdAllcol { get; set; } = null!;

    public string CdAllmis { get; set; } = null!;

    public string Lotto { get; set; } = null!;

    public string NrPezza { get; set; } = null!;
}
