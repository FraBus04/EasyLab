using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class OrdiniMp
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public string Stato { get; set; } = null!;

    public int ProgRiga { get; set; }

    public int? IdStag { get; set; }

    public int? IdLinea { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public string? Um { get; set; }

    public double QtOrd { get; set; }

    public double QtArr { get; set; }

    public string? CodMag { get; set; }

    public string FlagSaldo { get; set; } = null!;

    public DateTime? DataPrev { get; set; }

    public DateTime? DataArr { get; set; }

    public double? Prezzo { get; set; }

    public double? Sconto { get; set; }

    public string? FlagConf { get; set; }

    public double? QtDaConf { get; set; }

    public double? QtTotOrdAperto { get; set; }

    public double? QtTotDaRicevere { get; set; }

    public string? Nota { get; set; }

    public string? FlagNota { get; set; }

    public int? Sett { get; set; }

    public double? N1 { get; set; }

    public double? N2 { get; set; }

    public double? N3 { get; set; }

    public double? N4 { get; set; }

    public double? N5 { get; set; }

    public double? N6 { get; set; }

    public double? N7 { get; set; }

    public double? N8 { get; set; }

    public double? N9 { get; set; }

    public double? N10 { get; set; }

    public double? N11 { get; set; }

    public double? N12 { get; set; }

    public double? N13 { get; set; }

    public double? N14 { get; set; }

    public double? N15 { get; set; }

    public double? N16 { get; set; }

    public double? N17 { get; set; }

    public double? N18 { get; set; }

    public double? N19 { get; set; }

    public double? N20 { get; set; }

    public DateTime? D1 { get; set; }

    public DateTime? D2 { get; set; }

    public DateTime? D3 { get; set; }

    public DateTime? D4 { get; set; }

    public DateTime? D5 { get; set; }

    public DateTime? D6 { get; set; }

    public DateTime? D7 { get; set; }

    public DateTime? D8 { get; set; }

    public DateTime? D9 { get; set; }

    public DateTime? D10 { get; set; }

    public DateTime? D11 { get; set; }

    public DateTime? D12 { get; set; }

    public DateTime? D13 { get; set; }

    public DateTime? D14 { get; set; }

    public DateTime? D15 { get; set; }

    public DateTime? D16 { get; set; }

    public DateTime? D17 { get; set; }

    public DateTime? D18 { get; set; }

    public DateTime? D19 { get; set; }

    public DateTime? D20 { get; set; }

    public string? W1 { get; set; }

    public string? W2 { get; set; }

    public string? W3 { get; set; }

    public string? W4 { get; set; }

    public string? W5 { get; set; }

    public string? W6 { get; set; }

    public string? W7 { get; set; }

    public string? W8 { get; set; }

    public string? W9 { get; set; }

    public string? W10 { get; set; }

    public string? W11 { get; set; }

    public string? W12 { get; set; }

    public string? W13 { get; set; }

    public string? W14 { get; set; }

    public string? W15 { get; set; }

    public string? W16 { get; set; }

    public string? W17 { get; set; }

    public string? W18 { get; set; }

    public string? W19 { get; set; }

    public string? W20 { get; set; }

    public string CdStatoOrdMp { get; set; } = null!;

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public bool? Lock { get; set; }

    public int? ProgRigaMat { get; set; }

    public DateTime? DataExp { get; set; }

    public double? Sco1 { get; set; }

    public string? StatoExp { get; set; }

    public string? Azione { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }
}
