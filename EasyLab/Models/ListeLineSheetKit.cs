using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListeLineSheetKit
{
    public int Id { get; set; }

    public int IdLista { get; set; }

    public int? IdTema { get; set; }

    public int IdKit { get; set; }

    public int? IdOutFit { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public string? Nota { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public int? OrdPm { get; set; }
}
