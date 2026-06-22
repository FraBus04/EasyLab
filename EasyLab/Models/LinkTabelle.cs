using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LinkTabelle
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Siteid { get; set; } = null!;

    public string Tblcode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? IdComp { get; set; }
}
