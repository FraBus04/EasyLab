using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMovimentiCf
{
    public int Id { get; set; }

    public int IdTipoMov { get; set; }

    public string? TipoMovCod { get; set; }

    public string? TipoMovDesc { get; set; }

    public int IdCausale { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int IdSet { get; set; }

    public int IdSetTaglia { get; set; }

    public int IdSetOrd { get; set; }

    public string CdMag { get; set; } = null!;

    public short? Nr { get; set; }

    public int IdEan { get; set; }

    public string StatoMov { get; set; } = null!;

    public string? Stag { get; set; }

    public string? StagDescr { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? ModCol { get; set; }

    public string? DescCol { get; set; }

    public string? Tg { get; set; }

    public string? Ddtanag1 { get; set; }

    public string? Ddtanag2 { get; set; }

    public string? Ddtvia { get; set; }

    public string? Ddtcitta { get; set; }

    public string? Ddtprov { get; set; }

    public string? Ddtcap { get; set; }

    public DateTime DataMov { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdDoc { get; set; }

    public string? Nota { get; set; }

    public string? NrDoc { get; set; }

    public DateOnly? DataDoc { get; set; }

    public string? TipoDoc { get; set; }

    public string? TipoDocDesc { get; set; }

    public double? Pz { get; set; }

    public int? IdComm { get; set; }

    public int? CommNr { get; set; }

    public string? CommOrdTipo { get; set; }

    public bool? Lock { get; set; }
}
