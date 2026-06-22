using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMovimentiMpTestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdTipoDoc { get; set; }

    public string? TipoDoc { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int? IdForn { get; set; }

    public string? Forn { get; set; }

    public string? NrDdt { get; set; }

    public DateOnly? DataDdt { get; set; }

    public DateOnly DataMov { get; set; }

    public string CdMag { get; set; } = null!;

    public int IdTipoMov { get; set; }

    public string? MovCod { get; set; }

    public string? MovDesc { get; set; }

    public string? Nota { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public string? UteIns { get; set; }

    public int IdStag { get; set; }

    public string? StagCod { get; set; }

    public string CdValuta { get; set; } = null!;

    public int? IdDdtCausale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public int? IdCcliDest { get; set; }

    public int? NrColli { get; set; }

    public double? KgTot { get; set; }

    public int IdCausale { get; set; }

    public int? IdComm { get; set; }

    public int? NrComm { get; set; }
}
