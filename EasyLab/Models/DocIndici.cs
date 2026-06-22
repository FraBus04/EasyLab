using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class DocIndici
{
    public int Id { get; set; }

    public string TipoDoc { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdNextId { get; set; }

    public int? Anno { get; set; }

    public string? Pref { get; set; }
}
