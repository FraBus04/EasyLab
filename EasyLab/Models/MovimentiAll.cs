using System;
using System.Collections.Generic;

namespace EasyLab.Models;

/// <summary>
/// BST
/// TSE
/// WEB
/// </summary>
public partial class MovimentiAll
{
    public int Id { get; set; }

    public string? CdCanale { get; set; }

    public string? DocBi { get; set; }

    public string? Doc { get; set; }

    public DateOnly? DataDoc { get; set; }

    public string? NrDoc { get; set; }

    public string? DocRiga { get; set; }

    public int? IdEan { get; set; }

    public string? Ean { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string? Tg { get; set; }

    public string? Nome { get; set; }

    public string? ModColDesc { get; set; }

    public string? Descrizione { get; set; }

    public int? Qt { get; set; }

    public string? CdMag { get; set; }

    public string? CdValuta { get; set; }

    public string? Segno { get; set; }

    public double? Vatperc { get; set; }

    public double? Scoperc { get; set; }

    public double? ScotestaPerc { get; set; }

    public bool? CkPrezzzoRetail { get; set; }

    public double? PrezzoIvatoLordoValuta { get; set; }

    public double? PrezzoIvatoNettoScValuta { get; set; }

    public double? PrezzoIvatoScoValuta { get; set; }

    public double? PrezzoIvatoLordoEuro { get; set; }

    public double? PrezzoIvatoNettoScEuro { get; set; }

    public double? PrezzoIvatoScoEuro { get; set; }

    public double? ImponibLordoEuro { get; set; }

    public double? ImponibNettoEuro { get; set; }

    public double? ImponibScoEuro { get; set; }

    public double? ImponibLordoRigaEuro { get; set; }

    public double? ImponibNettoRigaEuro { get; set; }

    public string? VatEuro { get; set; }

    public string? CodOperBst { get; set; }

    public string? DescOperBst { get; set; }

    public string? TipoCli { get; set; }

    public string? DepCli { get; set; }

    public string? CodCli { get; set; }

    public string? CodSpe { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliCrm { get; set; }

    public string? RagioneSociale { get; set; }

    public string? Email { get; set; }

    public string? BstcodOper { get; set; }

    public string? BstdescOper { get; set; }

    public int? IdErp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? StatoPv { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public double? TotImponibModTessNettoEuro { get; set; }

    public double? TotImponibModTessColNettoEuro { get; set; }

    public double? MediaModTessNettoEuro { get; set; }

    public double? MediaModTessColNettoEuro { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTg { get; set; }

    public int? IdSetOrd { get; set; }
}
