using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Doc
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdClasseDoc { get; set; }

    public int IdContatto { get; set; }

    public int? IdDoc { get; set; }

    public int? IdTipoDati { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int IdModCol { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public int? IdOrd { get; set; }

    public int? IdOrdRiga { get; set; }

    public int? IdCcli { get; set; }

    public int? IdFase1 { get; set; }

    public int? IdFase2 { get; set; }

    public int? IdBp { get; set; }

    public int? IdBpriga { get; set; }

    public int? IdComm { get; set; }

    public int? IdLista { get; set; }

    public int? IdBox { get; set; }

    public int? OrdNr { get; set; }

    public decimal? PzArt { get; set; }

    public double? Sco1 { get; set; }

    public double? Sco2 { get; set; }

    public double? Sco3 { get; set; }

    public int? TotCapi { get; set; }

    public decimal? ValTot { get; set; }

    public short? Nr1 { get; set; }

    public short? Nr2 { get; set; }

    public short? Nr3 { get; set; }

    public short? Nr4 { get; set; }

    public short? Nr5 { get; set; }

    public short? Nr6 { get; set; }

    public short? Nr7 { get; set; }

    public short? Nr8 { get; set; }

    public short? Nr9 { get; set; }

    public short? Nr10 { get; set; }

    public short? Nr11 { get; set; }

    public short? Nr12 { get; set; }

    public short? Nr13 { get; set; }

    public short? Nr14 { get; set; }

    public short? Nr15 { get; set; }

    public short? Nr16 { get; set; }

    public short? Nr17 { get; set; }

    public short? Nr18 { get; set; }

    public short? Nr19 { get; set; }

    public short? Nr20 { get; set; }

    public decimal? Qta { get; set; }

    public string? CdMag1 { get; set; }

    public string? CdMag2 { get; set; }

    public string? MagPrel { get; set; }

    public string? CodUbic { get; set; }

    public bool? FlagGiaExp { get; set; }

    public int? CkControllo { get; set; }

    public string? Nota { get; set; }

    public string? NrDoc { get; set; }

    public bool CkImpegna { get; set; }

    public bool? CkConfRientro { get; set; }

    public DateOnly? DataRicRientro { get; set; }

    public DateOnly? DataConfRientro { get; set; }

    public DateTime? DataExp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string NrPezza { get; set; } = null!;

    public string Lotto { get; set; } = null!;

    public int? IdOrdMp { get; set; }

    public int? IdOrdMpriga { get; set; }

    public bool? CkStampa { get; set; }

    public string? Um { get; set; }

    public int? IdMpscar { get; set; }

    public int? IdExpRiga { get; set; }

    public int? IdSetGroup { get; set; }

    public int? IdSet { get; set; }

    public int? IdModDa { get; set; }

    public int? IdModColDa { get; set; }

    public int? Nr1Da { get; set; }

    public int? Nr2Da { get; set; }

    public int? Nr3Da { get; set; }

    public int? Nr4Da { get; set; }

    public int? Nr5Da { get; set; }

    public int? Nr6Da { get; set; }

    public int? Nr7Da { get; set; }

    public int? Nr8Da { get; set; }

    public int? Nr9Da { get; set; }

    public int? Nr10Da { get; set; }

    public int? Nr11Da { get; set; }

    public int? Nr12Da { get; set; }

    public int? Nr13Da { get; set; }

    public int? Nr14Da { get; set; }

    public int? Nr15Da { get; set; }

    public int? Nr16Da { get; set; }

    public int? Nr17Da { get; set; }

    public int? Nr18Da { get; set; }

    public int? Nr19Da { get; set; }

    public int? Nr20Da { get; set; }

    public int? TotCapiDa { get; set; }

    public double? PzArtDa { get; set; }

    public int? ProgRiga { get; set; }

    public int? IdRigaCar { get; set; }

    public string? Tipo { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public bool? CkBp { get; set; }

    public bool? CkComm { get; set; }

    public string? TipoOrd { get; set; }

    public int? IdSetOrd { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }
}
