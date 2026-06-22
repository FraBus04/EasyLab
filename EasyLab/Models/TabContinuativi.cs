using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabContinuativi
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdUtente { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public int? IdModLast { get; set; }

    public int? IdModColLast { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdModColNoStag { get; set; }
}
