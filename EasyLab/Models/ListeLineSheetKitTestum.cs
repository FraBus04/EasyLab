using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListeLineSheetKitTestum
{
    public int Id { get; set; }

    public int IdLista { get; set; }

    public int IdTema { get; set; }

    public string Cod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public string? Nota { get; set; }

    public byte[]? Img { get; set; }

    public int? OrdPm { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
