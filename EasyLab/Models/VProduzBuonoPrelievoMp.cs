using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzBuonoPrelievoMp
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public DateOnly? DataComm { get; set; }

    public int? NrComm { get; set; }

    public int NrScheda { get; set; }

    public string CdMat { get; set; } = null!;

    public string Lotto { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public string Mis { get; set; } = null!;

    public string NrPezza { get; set; } = null!;

    public decimal Qta { get; set; }

    public decimal QtaEvaso { get; set; }

    public string? MagLogico { get; set; }

    public string? CdMag { get; set; }

    public bool? CkInvLogistica { get; set; }

    public bool? CkEvasoLogistica { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public DateOnly? DataEvaso { get; set; }

    public decimal? QtaLorda { get; set; }

    public string? DescMat { get; set; }

    public string? Forn { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? Um { get; set; }

    public string? OrdTipo { get; set; }

    public DateTime? DataRicRientro { get; set; }

    public DateTime? DataConfRientro { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CdFamMat { get; set; }

    public string? FamMatDesc { get; set; }

    public string? MacroGruppo { get; set; }

    public decimal? MagLordo { get; set; }

    public decimal? BuoniDaEvadere { get; set; }

    public double? FabbNetto { get; set; }

    public decimal? MagNetto { get; set; }

    public string? Nota { get; set; }

    public int? IdLab { get; set; }

    public short? Hutile { get; set; }

    public string? DescCol { get; set; }

    public string? PathImgCol { get; set; }

    public string Stato { get; set; } = null!;

    public int? NrBuono { get; set; }

    public string? StatoDesc { get; set; }

    public int? IdCommessa { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public int? IdBuono { get; set; }

    public int? IdMpscar { get; set; }

    public int? IdTipoMat { get; set; }

    public string? CdTipoMat { get; set; }

    public string? Tp { get; set; }

    public string? TpDesc { get; set; }

    public string? TipoMatDesc { get; set; }

    public int? TipoMatOrdPm { get; set; }

    public int? TpOrdPm { get; set; }

    public int? IdContattoMat { get; set; }

    public string? ContattoMat { get; set; }

    public decimal? QtaProvv { get; set; }

    public string? NotaMat { get; set; }

    public int? IdFornProdotto { get; set; }

    public string? FornProdotto { get; set; }

    public string? FornMat { get; set; }

    public decimal? QtaMov { get; set; }

    public decimal? ValEvaso { get; set; }

    public decimal? ValScr { get; set; }

    public decimal? ValSaldo { get; set; }

    public int? IdMod { get; set; }

    public int? IdOrdMp { get; set; }

    public decimal? QtOrd { get; set; }

    public string? CommSaldo { get; set; }

    public string? CommStato { get; set; }

    public double? CommPercTotCapiFin { get; set; }

    public int? CommTotCapi { get; set; }

    public int? CommTotCapiFin { get; set; }

    public int IdFase { get; set; }

    public string? CodColForn { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public string? MatColMis { get; set; }

    public string? MatColMisDesc { get; set; }

    public string? Ragg1ModCod { get; set; }

    public string? Ragg1ModDesc { get; set; }

    public string? IdEanstr { get; set; }

    public string? FornPrefProd { get; set; }

    public string? LabPrevProd { get; set; }

    public string? ACdAll { get; set; }

    public string? BCdAll { get; set; }

    public string? BCdAllcol { get; set; }

    public string? BCdAllmis { get; set; }

    public string? BTipo { get; set; }
}
