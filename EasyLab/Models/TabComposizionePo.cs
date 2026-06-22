using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabComposizionePo
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Posizione { get; set; }

    public int? OrdPm { get; set; }

    public string? CdPos { get; set; }
}
