using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CkCommPrz
{
    public string Tdo { get; set; } = null!;

    public DateOnly DataDoc { get; set; }

    public int NrComm { get; set; }

    public int TipoCf { get; set; }

    public int IdCcli { get; set; }

    public string Art { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public string Deposito { get; set; } = null!;

    public string Um { get; set; } = null!;

    public double Qta { get; set; }

    public double Prz { get; set; }

    public string? Sku { get; set; }

    public double? PrzPlm { get; set; }

    public int? QtaPlm { get; set; }

    public int? IdComm { get; set; }

    public int? TotComm { get; set; }

    public int? TotCommPlm { get; set; }
}
