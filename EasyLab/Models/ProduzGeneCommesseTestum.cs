using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneCommesseTestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int NrScheda { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int IdMod { get; set; }

    public int IdLab { get; set; }

    public string Saldo { get; set; } = null!;

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public int? TotCapi { get; set; }

    public string Stato { get; set; } = null!;

    public DateTime? DataRicRientro { get; set; }

    public DateTime? DataConfRientro { get; set; }

    public bool? CkConf { get; set; }

    public bool? CkInvMatLogist { get; set; }

    public string? Nota { get; set; }

    public int? IdFase { get; set; }

    public string? CdValuta { get; set; }

    public double? Prezzo { get; set; }

    public int? CkExp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public DateOnly? DataComm { get; set; }

    public string? Po { get; set; }

    public int? IdPag { get; set; }

    public string? StatoApp { get; set; }

    public DateTime? DataApp { get; set; }

    public int? IdUteApp { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

    public int? TotCapiPersi { get; set; }

    public int? TotCapiFin { get; set; }

    public string? Lotto { get; set; }

    public double? RitX { get; set; }

    public double? RitY { get; set; }

    public double? PercTotCapiFin { get; set; }

    public string? CdMag { get; set; }

    public string Tipo { get; set; } = null!;

    public string? ACdAll { get; set; }

    public double? TotQta { get; set; }

    public int? IdDoc { get; set; }

    public double? TotQtaFin { get; set; }

    public double? PercTotQtaFin { get; set; }
}
