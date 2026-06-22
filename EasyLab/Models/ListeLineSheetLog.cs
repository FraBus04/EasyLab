using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListeLineSheetLog
{
    public int Id { get; set; }

    public int IdLista { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? LineSheetCod { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public string? ActionCode { get; set; }

    public int? Esiste { get; set; }
}
