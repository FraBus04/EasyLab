using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTipoDocReport
{
    public int Id { get; set; }

    public int IdTipoDoc { get; set; }

    public string Report { get; set; } = null!;

    public int OrdPm { get; set; }
}
