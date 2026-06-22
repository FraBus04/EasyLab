using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzBuonoPrelievoMpRiepilogoTestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Stato { get; set; } = null!;

    public int? NrBuonoRiep { get; set; }

    public int IdStag { get; set; }

    public int? IdForn { get; set; }

    public int? IdFornDest { get; set; }

    public DateTime DataIns { get; set; }

    public string? Nota { get; set; }

    public bool? CkExp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
