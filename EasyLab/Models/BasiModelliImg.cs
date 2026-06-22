using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliImg
{
    public int Id { get; set; }

    public int IdMod { get; set; }

    public string PathImg { get; set; } = null!;

    public string? Nome { get; set; }

    public int OrdPm { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdTipo { get; set; }

    public int? IdComm { get; set; }

    public int? IdFitting { get; set; }

    public int? IdSk { get; set; }

    public string? Nota { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteUpd { get; set; }
}
