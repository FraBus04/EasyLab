using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Error
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public string? Descr { get; set; }
}
