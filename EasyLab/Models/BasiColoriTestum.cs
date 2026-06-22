using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiColoriTestum
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public string Cartella { get; set; } = null!;

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? Nota { get; set; }
}
