using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzIndici
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public int IdNextId { get; set; }

    public int? Anno { get; set; }

    public string? Pref { get; set; }
}
