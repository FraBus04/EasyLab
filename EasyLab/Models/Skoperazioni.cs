using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Skoperazioni
{
    public int Id { get; set; }

    public int IdSk { get; set; }

    public int IdOperaz { get; set; }

    public string? Nota { get; set; }

    public int? Ord { get; set; }
}
