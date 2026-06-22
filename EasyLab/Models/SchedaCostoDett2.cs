using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SchedaCostoDett2
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public int IdMod { get; set; }

    public int IdTipoSk { get; set; }

    public string? MatLav { get; set; }

    public short? OrdPm { get; set; }

    public string? MatOper { get; set; }

    public string? Tp { get; set; }

    public string? Tp2 { get; set; }

    public double? CostoUnit { get; set; }

    public double? Cons1 { get; set; }

    public double? Imp1 { get; set; }

    public string? Posizione { get; set; }

    public string? Note { get; set; }

    public int? IdFase { get; set; }

    public int? IdLab { get; set; }

    public int? IdMat { get; set; }

    public bool? CkMadre { get; set; }

    public int? IdContattoMat { get; set; }

    public int? Pezzi { get; set; }

    public DateTime? DataIns { get; set; }

    public string? Misura { get; set; }

    public double? PezziAcc { get; set; }
}
