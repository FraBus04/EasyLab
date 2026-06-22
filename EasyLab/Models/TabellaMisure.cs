using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabellaMisure
{
    public int Id { get; set; }

    public int IdTabMisure { get; set; }

    public int IdPresaMisure { get; set; }

    public string? Lab { get; set; }

    public string Nota { get; set; } = null!;

    public double MisTgBase { get; set; }

    public decimal? Toll { get; set; }

    public bool CkIncAut { get; set; }

    public double? IncLeft { get; set; }

    public double? IncRight { get; set; }

    public double? Mis1 { get; set; }

    public double? Mis2 { get; set; }

    public double? Mis3 { get; set; }

    public double? Mis4 { get; set; }

    public double? Mis5 { get; set; }

    public double? Mis6 { get; set; }

    public double? Mis7 { get; set; }

    public double? Mis8 { get; set; }

    public double? Mis9 { get; set; }

    public double? Mis10 { get; set; }

    public double? Mis11 { get; set; }

    public double? Mis12 { get; set; }

    public double? Mis13 { get; set; }

    public double? Mis14 { get; set; }

    public double? Mis15 { get; set; }

    public double? Mis16 { get; set; }

    public double? RisTgBase { get; set; }

    public double? Ris1 { get; set; }

    public double? Ris2 { get; set; }

    public double? Ris3 { get; set; }

    public double? Ris4 { get; set; }

    public double? Ris5 { get; set; }

    public double? Ris6 { get; set; }

    public double? Ris7 { get; set; }

    public double? Ris8 { get; set; }

    public double? Ris9 { get; set; }

    public double? Ris10 { get; set; }

    public double? Ris11 { get; set; }

    public double? Ris12 { get; set; }

    public double? Ris13 { get; set; }

    public double? Ris14 { get; set; }

    public double? Ris15 { get; set; }

    public double? Ris16 { get; set; }

    public double? Sc1 { get; set; }

    public double? Sc2 { get; set; }

    public double? Sc3 { get; set; }

    public double? Sc4 { get; set; }

    public double? Sc5 { get; set; }

    public double? Sc6 { get; set; }

    public double? Sc7 { get; set; }

    public double? Sc8 { get; set; }

    public double? Sc9 { get; set; }

    public double? Sc10 { get; set; }

    public double? Sc11 { get; set; }

    public double? Sc12 { get; set; }

    public double? Sc13 { get; set; }

    public double? Sc14 { get; set; }

    public double? Sc15 { get; set; }

    public int OrdPm { get; set; }

    public string? Stato { get; set; }

    public int? StatoEdit { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
