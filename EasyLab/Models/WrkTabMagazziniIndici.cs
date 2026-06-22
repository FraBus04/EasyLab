using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class WrkTabMagazziniIndici
{
    public int Id { get; set; }

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public string CodUbic { get; set; } = null!;

    public int Nr { get; set; }
}
