using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabMagazziniUbicIndici
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string CodMag { get; set; } = null!;

    public string CodUbic { get; set; } = null!;

    public int Pos { get; set; }
}
