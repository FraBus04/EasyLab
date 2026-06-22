using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SidImpOrdinicl
{
    public int Id { get; set; }

    public long IdTse { get; set; }

    public int? IdTabFrontRiga { get; set; }

    public int OrdNr { get; set; }

    public DateOnly? DataDoc { get; set; }

    public int? Anno { get; set; }

    public string? TipoOrdTse { get; set; }

    public string? Po { get; set; }

    public int? RifidContatto { get; set; }

    public int? RifidContattoDest { get; set; }

    public string? CdValuta { get; set; }

    public string? CodPag { get; set; }

    public string? Stag { get; set; }

    public int? ProgParde { get; set; }

    public int? ProfRiga { get; set; }

    public string? CodiceArticolo { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public string? Tg { get; set; }

    public string? Um { get; set; }

    public int? Nr { get; set; }

    public double? PzArt { get; set; }

    public double? ScoRiga1 { get; set; }

    public double? ScoRiga2 { get; set; }

    public double? ScoRiga3 { get; set; }

    public string? CodIva { get; set; }

    public string? CodPorto { get; set; }

    public string? CodAgente { get; set; }

    public string? CodVettore { get; set; }

    public string? CodTipoSped { get; set; }

    public string? CodCausale { get; set; }

    public DateOnly? InizioTrasp { get; set; }

    public DateOnly? DataConsegna { get; set; }

    public DateTime? DataUpd { get; set; }

    public DateTime? DataExp { get; set; }

    public int? FlagExp { get; set; }

    public string? OrdTipo { get; set; }

    public int? IdDoc { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTg { get; set; }

    public int? OrdTg { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public int? IdRiga { get; set; }

    public int? IdPag { get; set; }

    public int? IdAg { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtResa { get; set; }

    public int? IdRagg1 { get; set; }

    public string? LineSheet { get; set; }

    public string? DescCol { get; set; }

    public string? Nota { get; set; }

    public int? IdCodIva { get; set; }

    public int? IdRigaPlm { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdStagMod { get; set; }

    public string? MagPrel { get; set; }

    public int? IdSetGroup { get; set; }
}
