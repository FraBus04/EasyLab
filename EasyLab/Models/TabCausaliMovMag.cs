using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabCausaliMovMag
{
    public int Id { get; set; }

    public int IdClasseDoc { get; set; }

    public int IdContatto { get; set; }

    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public int? IdCausale { get; set; }
}
