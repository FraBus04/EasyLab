using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzBuonoPrelievoMpRiepilogoTestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int? NrBuonoRiep { get; set; }

    public DateTime DataIns { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public string? StagCod { get; set; }

    public string? StagDesc { get; set; }

    public int? IdForn { get; set; }

    public string? Forn { get; set; }

    public string? Nota { get; set; }

    public int? IdFornDest { get; set; }

    public string? FornDest { get; set; }
}
