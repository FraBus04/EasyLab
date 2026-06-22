using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBolDetail
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public string? CdAll { get; set; }

    public string? Parte { get; set; }

    public string? ParteDesc { get; set; }

    public int IdMod { get; set; }

    public int IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? Fase { get; set; }

    public string? Nota { get; set; }

    public string? CdValuta { get; set; }

    public double Pz { get; set; }

    public int? IdLab { get; set; }

    public string? Lab { get; set; }

    public string? Um { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public double? Qt { get; set; }

    public int? OrdPm { get; set; }

    public double? Tempo { get; set; }

    public int? IdContatto { get; set; }

    public int? IdStag { get; set; }

    public int? IdForn { get; set; }

    public string? Forn { get; set; }

    public int? Gg { get; set; }
}
