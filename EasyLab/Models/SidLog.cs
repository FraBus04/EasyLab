using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SidLog
{
    public int Id { get; set; }

    public DateTime? DataIns { get; set; }

    public string? Testo { get; set; }

    public bool? Err { get; set; }

    public int? IdSp { get; set; }

    public bool? CkMsgSp { get; set; }

    public int? Nr { get; set; }
}
