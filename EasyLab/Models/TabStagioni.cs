using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabStagioni
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public int OrdPm { get; set; }

    public string? CodImp { get; set; }

    public int? Anno { get; set; }

    public string? TipoStag { get; set; }

    public string? AnnoDesc { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public DateOnly? ListValidDa { get; set; }

    public DateOnly? ListValidA { get; set; }

    public string? NotaCare { get; set; }

    public int? IdOrd { get; set; }
}
