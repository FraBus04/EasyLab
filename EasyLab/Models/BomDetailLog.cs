using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BomDetailLog
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string CodColProd { get; set; } = null!;

    public int Seq { get; set; }

    public string CdMat { get; set; } = null!;

    public string? CodColMat { get; set; }

    public string? CdUm { get; set; }

    public string? Misura { get; set; }

    public double? Cons { get; set; }

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public string? CdClasseImpegno { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public int? IdMod { get; set; }

    public string? Tp { get; set; }

    public string? Tp2 { get; set; }

    public DateTime? Ts { get; set; }

    public string? AbbinamentoColori { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public DateTime? IdUteIns { get; set; }

    public DateTime? IdUteUpd { get; set; }

    public string? Misura1 { get; set; }

    public string? Misura2 { get; set; }

    public string? Misura3 { get; set; }

    public string? Misura4 { get; set; }

    public string? Misura5 { get; set; }

    public string? Misura6 { get; set; }

    public string? Misura7 { get; set; }

    public string? Misura8 { get; set; }

    public string? Misura9 { get; set; }

    public string? Misura10 { get; set; }

    public string? Misura11 { get; set; }

    public double? Cons1 { get; set; }

    public double? Cons2 { get; set; }

    public double? Cons3 { get; set; }

    public double? Cons4 { get; set; }

    public double? Cons5 { get; set; }

    public double? Cons6 { get; set; }

    public double? Cons7 { get; set; }

    public double? Cons8 { get; set; }

    public double? Cons9 { get; set; }

    public double? Cons10 { get; set; }

    public double? Cons11 { get; set; }

    public string? AbbinamentoTaglie { get; set; }

    public string? Tg1 { get; set; }

    public string? Tg2 { get; set; }

    public string? Tg3 { get; set; }

    public string? Tg4 { get; set; }

    public string? Tg5 { get; set; }

    public string? Tg6 { get; set; }

    public string? Tg7 { get; set; }

    public string? Tg8 { get; set; }

    public string? Tg9 { get; set; }

    public string? Tg10 { get; set; }

    public string? Tg11 { get; set; }

    public bool? CkMatMis { get; set; }
}
