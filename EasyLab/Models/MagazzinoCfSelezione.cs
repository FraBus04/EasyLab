using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MagazzinoCfSelezione
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdUte { get; set; }

    public int Modo { get; set; }

    public string? CodMag { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? Nr { get; set; }

    public int? Negativi { get; set; }

    public int? MagAss { get; set; }

    public int? MagDaAss { get; set; }

    public int? MagDispDaAss { get; set; }

    public int? MagDisp { get; set; }

    public DateTime? DataIns { get; set; }
}
