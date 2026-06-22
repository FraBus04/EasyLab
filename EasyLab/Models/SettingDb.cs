using System;
using System.Collections.Generic;

namespace EasyLab.Models;

/// <summary>
/// 0&gt; CO 100%  1&gt;100% CO
/// </summary>
public partial class SettingDb
{
    public int IdContattoMaster { get; set; }

    public string? Skin { get; set; }

    public string? MagSede { get; set; }

    public string? CdMagMp { get; set; }

    public string? Intest1 { get; set; }

    public string? Intest2 { get; set; }

    public string? Intest3 { get; set; }

    public string? Intest4 { get; set; }

    public string? Intest5 { get; set; }

    public string? Intest6 { get; set; }

    public bool? CkMagNostag { get; set; }

    public bool? CkCatMercRelaz { get; set; }

    public int? NrSize { get; set; }

    public bool? TabBomTp2 { get; set; }

    public bool? TabBomTp3 { get; set; }

    public bool? TabCatMerc { get; set; }

    public bool? TabCatMercMacro { get; set; }

    public bool? TabCatTaglio { get; set; }

    public bool? TabCaractProdotto { get; set; }

    public bool? TabMovimentiMp { get; set; }

    public bool? TabMovimentiFasi { get; set; }

    public bool? TabMovimentiCf { get; set; }

    public bool? TabComposizione { get; set; }

    public bool? TabComposizionePos { get; set; }

    public bool? TabFasiLavorazione { get; set; }

    public bool? TabFasiCommessa { get; set; }

    public bool? TabImballo { get; set; }

    public bool? TabMagazzini { get; set; }

    public bool? TabMagazziniUbicIndici { get; set; }

    public bool? TabModellisti { get; set; }

    public bool? TabStatoModello { get; set; }

    public bool? TabTipoFilato { get; set; }

    public bool? TabTipoListino { get; set; }

    public bool? TabTipoMateriale { get; set; }

    public bool? TabTipoPunto { get; set; }

    public bool? TabTipoSk { get; set; }

    public bool? TabTrattamento { get; set; }

    public bool? TabUtenti { get; set; }

    public bool? TabVociDoganali { get; set; }

    public bool? TabStiro { get; set; }

    public bool? TabBomTp { get; set; }

    public bool? TabGender { get; set; }

    public bool? TabCausaliAnnullamenti { get; set; }

    public int? DiBaModoOrdinamento { get; set; }

    public bool? TabPagamenti { get; set; }

    public bool? TabDdtResa { get; set; }

    public bool? TabNoteDdt { get; set; }

    public bool? Commessa { get; set; }

    public bool? MagazzinoCfVertEan { get; set; }

    public bool? DdtMp { get; set; }

    public bool? MagCfNoStag { get; set; }

    public bool? TabLab { get; set; }

    public int? IdCcli { get; set; }

    public string? PathLogo { get; set; }

    public bool? OrdMp { get; set; }

    public bool? OrdCf { get; set; }

    public bool? TipoMpScar { get; set; }

    public bool? LstEan { get; set; }

    public bool? TabAnagCliFor { get; set; }

    public bool? TabAnagCliForVoto { get; set; }

    public bool? TabAnagCliFor1 { get; set; }

    public bool? TabAnagCliFor2 { get; set; }

    public bool? TabAnagCliFor4 { get; set; }

    public bool? TabAnagCliForDestLibero { get; set; }

    public bool? TabTabellaMisure { get; set; }

    public bool? SchedaTecnica { get; set; }

    public bool? TabSchedaTecnica { get; set; }

    public bool? RiepLogist { get; set; }

    public bool? Sped { get; set; }

    public bool? TipoGalleriaImg { get; set; }

    public bool? TabReport { get; set; }

    public bool? TabVestibilita { get; set; }

    public bool? TabStagionalita { get; set; }

    public bool? TabTipoNote { get; set; }

    public bool? TabRagg { get; set; }

    public bool? TabAnagCliForArea { get; set; }

    public bool? TabAnagCliForRagg { get; set; }

    public bool? TabAnagCliForModoCorrisp { get; set; }

    public bool? TabCausaliMovMag { get; set; }

    public bool? TabTipoDoc { get; set; }

    public bool? TabArea { get; set; }

    public bool? TabCodIva { get; set; }

    public string? CdValuta { get; set; }

    public string? Umpeso { get; set; }

    public bool? CkCreaEanComm { get; set; }

    public bool? CkCdc { get; set; }

    public bool? DocNumerazione { get; set; }

    public bool? CkScaricoCfdaAssegnaz { get; set; }

    public bool? TabAvanzModello { get; set; }

    public byte[]? Immagine { get; set; }

    public bool? CkExpStake { get; set; }

    public bool? CkExpMp { get; set; }

    public bool? CkExpProd { get; set; }

    public bool? CkExpList { get; set; }

    public bool? CkExpSk { get; set; }

    public bool? CkExpEan { get; set; }

    public bool? CkExpComm { get; set; }

    public bool? CkExpOrdiniCl { get; set; }

    public string? XfrmOrdiniClInsDetail { get; set; }

    public bool? TabLinee { get; set; }

    public bool? CkCompFibre { get; set; }

    public bool? CkExpComp { get; set; }

    public bool? CkCompFormat { get; set; }

    public bool? CkTipoMatRelaz { get; set; }

    public int? EticNrCopie { get; set; }

    public bool? CkFabbDitta { get; set; }

    public bool? CkExpPkl { get; set; }

    public string? IpAntenneEpc { get; set; }

    public DateOnly DataLockMovMp { get; set; }

    public int IdUteLockMovMp { get; set; }

    public DateOnly DataLockMovPf { get; set; }

    public int IdUteLockMovPf { get; set; }
}
