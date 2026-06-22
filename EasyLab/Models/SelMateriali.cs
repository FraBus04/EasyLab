using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelMateriali
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string CdMat { get; set; } = null!;

    public int? IdMat { get; set; }
}
