using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSidLog
{
    public int Id { get; set; }

    public DateTime? DataIns { get; set; }

    public string? Testo { get; set; }

    public bool? Err { get; set; }

    public int? IdSp { get; set; }

    public string? Attivita { get; set; }

    public string? Sp { get; set; }

    public DateTime? Prossimo { get; set; }

    public bool? CkMsgSp { get; set; }
}
