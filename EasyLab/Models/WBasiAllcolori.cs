using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class WBasiAllcolori
{
    public string? Tipo { get; set; }

    public int? IdContatto { get; set; }

    public string? Cd { get; set; }

    public string? CdAll { get; set; }

    public string? Stato { get; set; }

    public int? IdStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public string ParteCol { get; set; } = null!;

    public string ParteColDesc { get; set; } = null!;

    public string? CodColForn { get; set; }

    public int? OrdPm { get; set; }

    public string? PathImg { get; set; }

    public bool Enab { get; set; }

    public int? IdCart { get; set; }

    public string? Cartella { get; set; }

    public int? CkSkCalcolo { get; set; }

    public string? Nota { get; set; }

    public string? StatoPv { get; set; }

    public string? Parte { get; set; }

    public string? ParteDesc { get; set; }

    public int? IdMod { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdModCol { get; set; }
}
