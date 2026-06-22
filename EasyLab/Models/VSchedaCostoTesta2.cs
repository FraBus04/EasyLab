using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSchedaCostoTesta2
{
    public string Stato { get; set; } = null!;

    public int IdMod { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string Tess { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public double? TotFasi { get; set; }

    public double? TotMatT { get; set; }

    public double? TotMatC { get; set; }

    public double? TotMatL { get; set; }

    public double? Pezzi { get; set; }

    public double? MtTape { get; set; }

    public double? Param1 { get; set; }

    public double? Param2 { get; set; }

    public double? Param3 { get; set; }

    public double? Param4 { get; set; }

    public double? Param5 { get; set; }

    public double? Costo1 { get; set; }

    public double? Costo2 { get; set; }

    public double? Costo3 { get; set; }

    public double? Correz1 { get; set; }

    public double? Correz2 { get; set; }

    public double? Fase1 { get; set; }

    public double? Fase2 { get; set; }

    public double? Fase3 { get; set; }

    public double? MarkUp1 { get; set; }

    public double? MarkUp2 { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdTipoSk { get; set; }

    public string? TipoSkCod { get; set; }

    public string? TipoSkDesc { get; set; }

    public double? TotMatN { get; set; }

    public int? IdTesta { get; set; }

    public int? Pezzi2 { get; set; }

    public double? PezziAcc { get; set; }

    public double? PezziAcc2 { get; set; }

    public int? Pers { get; set; }

    public double? MtTape2 { get; set; }

    public double? TotM { get; set; }

    public double? PezziGg { get; set; }
}
