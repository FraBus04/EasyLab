using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelItem
{
    public int Id { get; set; }

    public int IdUtente { get; set; }

    public int IdTipo { get; set; }

    public int? IdSel { get; set; }

    public string? CdSel { get; set; }

    public string? Tipo { get; set; }
}
