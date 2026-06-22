using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabellaMisureTestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdTabellaMisureTipo { get; set; }

    public bool CkTemplate { get; set; }

    public bool? CkEffettiva { get; set; }

    public string Cod { get; set; } = null!;

    public string Nota { get; set; } = null!;

    public int IdSet { get; set; }

    public int IdTgBase { get; set; }

    public int? IdMod { get; set; }

    public int? IdComm { get; set; }

    public string Stato { get; set; } = null!;

    public string? PathImg { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
