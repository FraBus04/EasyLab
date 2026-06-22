using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzGeneCommesseTestaAvanzFasi
{
    public int IdComm { get; set; }

    public int? IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? NrScheda { get; set; }

    public string? OrdTipo { get; set; }

    public int? IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public int? IdLab { get; set; }

    public string? LabDesc { get; set; }

    public string? Saldo { get; set; }

    public int? TotCapi { get; set; }

    public string? Stato { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public DateTime? DataRicRientro { get; set; }

    public DateTime? DataConfRientro { get; set; }

    public bool? CkConf { get; set; }

    public bool? CkInvMatLogist { get; set; }

    public int? IdStatoMod { get; set; }

    public string? Nota { get; set; }

    public string? StatoDesc { get; set; }

    public string? Contatto { get; set; }

    public string? StagCod { get; set; }

    public string? PathLogo { get; set; }

    public int? NrAllegati { get; set; }

    public byte[]? NrAllegatiImg { get; set; }

    public string? PathImg { get; set; }

    public int? IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public string? CdValuta { get; set; }

    public double? Prezzo { get; set; }

    public int? CkExp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public int? IdCcli { get; set; }

    public string? Forn { get; set; }

    public int? IdCcliDest { get; set; }

    public string? FornDest { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public string? TraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public string? Vettore { get; set; }

    public DateOnly? DataComm { get; set; }

    public string? Po { get; set; }

    public int? IdPag { get; set; }

    public string? Pagamento { get; set; }

    public string? StatoApp { get; set; }

    public DateTime? DataApp { get; set; }

    public int? IdUteApp { get; set; }

    public bool? CkPrelTSaldo { get; set; }

    public bool? CkPrelCSaldo { get; set; }

    public bool? CkPrelSaldo { get; set; }

    public byte[]? FasiImg { get; set; }

    public int? IdFase1 { get; set; }

    public int? IdFase2 { get; set; }

    public int? IdFase3 { get; set; }

    public int? IdFase4 { get; set; }

    public int? IdFase5 { get; set; }

    public int? IdFase6 { get; set; }

    public int? IdFase7 { get; set; }

    public int? IdFase8 { get; set; }

    public int? IdFase9 { get; set; }

    public int? IdFase10 { get; set; }

    public int? IdFase11 { get; set; }

    public int? IdFase12 { get; set; }

    public int? IdFase13 { get; set; }

    public int? IdFase14 { get; set; }

    public int? IdFase15 { get; set; }

    public int? Car1 { get; set; }

    public int? Car2 { get; set; }

    public int? Car3 { get; set; }

    public int? Car4 { get; set; }

    public int? Car5 { get; set; }

    public int? Car6 { get; set; }

    public int? Car7 { get; set; }

    public int? Car8 { get; set; }

    public int? Car9 { get; set; }

    public int? Car10 { get; set; }

    public int? Car11 { get; set; }

    public int? Car12 { get; set; }

    public int? Car13 { get; set; }

    public int? Car14 { get; set; }

    public int? Car15 { get; set; }

    public int? Scr1 { get; set; }

    public int? Scr2 { get; set; }

    public int? Scr3 { get; set; }

    public int? Scr4 { get; set; }

    public int? Scr5 { get; set; }

    public int? Scr6 { get; set; }

    public int? Scr7 { get; set; }

    public int? Scr8 { get; set; }

    public int? Scr9 { get; set; }

    public int? Scr10 { get; set; }

    public int? Scr11 { get; set; }

    public int? Scr12 { get; set; }

    public int? Scr13 { get; set; }

    public int? Scr14 { get; set; }

    public int? Scr15 { get; set; }

    public int? Diff1 { get; set; }

    public int? Diff2 { get; set; }

    public int? Diff3 { get; set; }

    public int? Diff4 { get; set; }

    public int? Diff5 { get; set; }

    public int? Diff6 { get; set; }

    public int? Diff7 { get; set; }

    public int? Diff8 { get; set; }

    public int? Diff9 { get; set; }

    public int? Diff10 { get; set; }

    public int? Diff11 { get; set; }

    public int? Diff12 { get; set; }

    public int? Diff13 { get; set; }

    public int? Diff14 { get; set; }

    public int? Diff15 { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

    public int? TotCapiFin { get; set; }

    public double? PercTotCapiFin { get; set; }

    public string? Trattamento { get; set; }

    public string? Fase1 { get; set; }

    public string? Fase2 { get; set; }

    public string? Fase3 { get; set; }

    public string? Fase4 { get; set; }

    public string? Fase5 { get; set; }

    public string? Fase6 { get; set; }

    public string? Fase7 { get; set; }

    public string? Fase8 { get; set; }

    public string? Fase9 { get; set; }

    public string? Fase10 { get; set; }

    public string? Fase11 { get; set; }

    public string? Fase12 { get; set; }

    public string? Fase13 { get; set; }

    public string? Fase14 { get; set; }

    public string? Fase15 { get; set; }
}
