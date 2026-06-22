using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzBuonoPrelievoMpall
{
    public int Id { get; set; }

    public int IdComm { get; set; }

    public string? ATipo { get; set; }

    public string? ACdAll { get; set; }

    public string? AContatto { get; set; }

    public int? AIdContatto { get; set; }

    public int? AIdStag { get; set; }

    public string? AParte { get; set; }

    public string? AParteDesc { get; set; }

    public string? AStag { get; set; }

    public int? ANrComm { get; set; }

    public string? AOrdTipo { get; set; }

    public string? ASaldoComm { get; set; }

    public int? TotCapiComm { get; set; }

    public double? TotQtaComm { get; set; }

    public string? ACdMag { get; set; }

    public int IdFase { get; set; }

    public string? BTipo { get; set; }

    public string? BCdAll { get; set; }

    public string? BCdAllcol { get; set; }

    public string? BCdAllmis { get; set; }

    public string? BCdEan { get; set; }

    public string BLotto { get; set; } = null!;

    public string BNrPezza { get; set; } = null!;

    public string? BFaseCod { get; set; }

    public string? BFaseDesc { get; set; }

    public int? BIdTipoMat { get; set; }

    public int? BIdMpscar { get; set; }

    public string? BContatto { get; set; }

    public string? BParte { get; set; }

    public string? BParteDesc { get; set; }

    public string? BParteCol { get; set; }

    public string? BParteColDesc { get; set; }

    public string? BParteMis { get; set; }

    public string? BParteMisDesc { get; set; }

    public string? BParteColMis { get; set; }

    public string? BUm { get; set; }

    public string? BTp { get; set; }

    public string? BTpDesc { get; set; }

    public int? BTpOrdPm { get; set; }

    public string? BCdTipoMat { get; set; }

    public string? BTipoMatDesc { get; set; }

    public int? BTipoMatOrdPm { get; set; }

    public short? BHutile { get; set; }

    public string? BNota { get; set; }

    public string? BCdMag { get; set; }

    public string Stato { get; set; } = null!;

    public decimal BQta { get; set; }

    public decimal? BQtaLorda { get; set; }

    public decimal BQtaEvaso { get; set; }

    public decimal? BQtaMov { get; set; }

    public bool? CkInvLogistica { get; set; }

    public bool? CkEvasoLogistica { get; set; }

    public int? NrBuono { get; set; }

    public DateOnly? DataEvaso { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string? Lab { get; set; }

    public string? Forn { get; set; }

    public string? FornPrefProd { get; set; }

    public int? CkMatMis { get; set; }

    public string? Ragg1ModCod { get; set; }

    public string? Ragg1ModDesc { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? BFornPref { get; set; }
}
