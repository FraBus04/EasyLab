using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ClasseSklock
{
    public int Id { get; set; }

    public int IdForm { get; set; }

    public int? IdRif { get; set; }

    public int IdUte { get; set; }

    public DateTime DataIns { get; set; }

    public string? CdAll { get; set; }
}
