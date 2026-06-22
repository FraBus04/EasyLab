using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CkMovimentiTseBst
{
    public int Id { get; set; }

    public string? Articolo { get; set; }

    public string? Variante { get; set; }

    public string? BstDeposito { get; set; }

    public string? BstDoc { get; set; }

    public string? BstDataDoc { get; set; }

    public string? BstDocNr { get; set; }

    public int? BstRiga { get; set; }

    public int? BstQta { get; set; }

    public string? BstRagioneSociale { get; set; }

    public int? TseNrDocRiscontrati { get; set; }

    public string? TseCliFor { get; set; }

    public string? TseRagioneSociale { get; set; }

    public string? TseDocumento { get; set; }

    public DateOnly? TseDataDoc { get; set; }

    public DateOnly? TseDataReg { get; set; }

    public string? TseNumero { get; set; }

    public decimal? TseQuantitàCarico { get; set; }

    public decimal? TseQuantitàScarico { get; set; }

    public string? TseEu { get; set; }

    public string? TseDeposito { get; set; }

    public string? TseDepositoCollegato { get; set; }

    public decimal? TseCausMagazzino { get; set; }

    public string? TseDescrCausMagazzino { get; set; }

    public decimal? TseMovFiscale { get; set; }

    public string? TseMovGiacAtt { get; set; }

    public string? BstTipoDoc { get; set; }

    public string? BstDocDesc { get; set; }
}
