using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabSimboliLav
{
    public int Id { get; set; }

    public string Cod { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string? DescEng { get; set; }

    public int? OrdPm { get; set; }

    public byte[]? Img { get; set; }

    public int? IdImp { get; set; }

    public string? NilornId { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? Ru { get; set; }
}
