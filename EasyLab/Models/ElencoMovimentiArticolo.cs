using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ElencoMovimentiArticolo
{
    public string? Articolo { get; set; }

    public string? Variante { get; set; }

    public string CliFor { get; set; } = null!;

    public string? RagioneSociale { get; set; }

    public string Documento { get; set; } = null!;

    public DateOnly? DataDoc { get; set; }

    public DateOnly? DataReg { get; set; }

    public string? Numero { get; set; }

    public decimal? QuantitàCarico { get; set; }

    public decimal? QuantitàScarico { get; set; }

    public string EU { get; set; } = null!;

    public string Deposito { get; set; } = null!;

    public string? DepositoCollegato { get; set; }

    public decimal? CausMagazzino { get; set; }

    public string? DescrCausMagazzino { get; set; }

    public decimal? MovFiscale { get; set; }

    public bool? MovGiacAtt { get; set; }
}
