using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VWrkMovimentiMagazzino
{
    public int IdMov { get; set; }

    public string StatoMov { get; set; } = null!;

    public short? IdCcli { get; set; }

    public short? IdStag { get; set; }

    public int? IdTesta { get; set; }

    public int? IdMod { get; set; }

    public int? IdModelloColore { get; set; }

    public int? MovId { get; set; }

    public string? MovCod { get; set; }

    public string? MovDesc { get; set; }

    public DateTime DataMov { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? Colore { get; set; }

    public string? Tg { get; set; }

    public int? TgOrd { get; set; }

    public string CodMag { get; set; } = null!;

    public int CodUbicazione { get; set; }

    public string? RifCliente { get; set; }

    public string? Nota { get; set; }

    public short? Nr { get; set; }

    public int IdCausale { get; set; }

    public int? IdRigaOrd { get; set; }

    public int? IdRigaMovOriz { get; set; }

    public string? CodUbic { get; set; }

    public DateOnly? DataMovTesta { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int? IdModCol { get; set; }

    public string? DescCol { get; set; }

    public int? IdScontrino { get; set; }

    public int? IdSetTaglia { get; set; }

    public string? CodMagDa { get; set; }

    public string? NrDdt { get; set; }

    public DateOnly? DataDdt { get; set; }

    public string? Ddtanag1 { get; set; }

    public string? Ddtanag2 { get; set; }

    public string? Ddtvia { get; set; }

    public string? Ddtcitta { get; set; }

    public string? Ddtprov { get; set; }

    public string? Ddtcap { get; set; }

    public int? CcliDdt { get; set; }

    public string? NotaTesta { get; set; }

    public string? StagCod { get; set; }

    public string? StagDescr { get; set; }

    public int? IdDdtCausale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public int? NrColli { get; set; }

    public double? KgTot { get; set; }

    public string? Mov { get; set; }

    public int? IdDoc { get; set; }

    public int? IdTipoDoc { get; set; }

    public string? TipoDoc { get; set; }

    public int? Expr1 { get; set; }

    public int? IdRigaAvanz { get; set; }

    public string? NrDoc { get; set; }

    public DateOnly? DataDoc { get; set; }

    public string? Anag1Doc { get; set; }

    public int? IdCatMerc { get; set; }
}
