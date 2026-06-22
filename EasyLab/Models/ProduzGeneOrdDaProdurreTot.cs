using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneOrdDaProdurreTot
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public string Stato { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int Livello { get; set; }

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public string? ACdAll { get; set; }

    public string? ACdAllcol { get; set; }

    public string? ACdAllmis { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string Mod { get; set; } = null!;

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public double? Nr1 { get; set; }

    public double? Nr2 { get; set; }

    public double? Nr3 { get; set; }

    public double? Nr4 { get; set; }

    public double? Nr5 { get; set; }

    public double? Nr6 { get; set; }

    public double? Nr7 { get; set; }

    public double? Nr8 { get; set; }

    public double? Nr9 { get; set; }

    public double? Nr10 { get; set; }

    public double? Nr11 { get; set; }

    public double? Nr12 { get; set; }

    public double? Nr13 { get; set; }

    public double? Nr14 { get; set; }

    public double? Nr15 { get; set; }

    public double? Nr16 { get; set; }

    public double? TotCapi { get; set; }

    public int? CkDiba { get; set; }

    public int? CkDibaMod { get; set; }

    public int? CkDibaModCol { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdMatMisSl1 { get; set; }

    public int? IdMatMisSl2 { get; set; }

    public int? IdMatMisSl3 { get; set; }

    public int? IdMatMisSl4 { get; set; }

    public int? IdMatMisSl5 { get; set; }

    public int? IdMatMisSl6 { get; set; }

    public int? IdMatMisSl7 { get; set; }

    public int? IdMatMisSl8 { get; set; }

    public int? IdMatMisSl9 { get; set; }

    public int? IdMatMisSl10 { get; set; }

    public int? IdMatMisSl11 { get; set; }

    public int? IdMatMisSl12 { get; set; }

    public int? IdMatMisSl13 { get; set; }

    public int? IdMatMisSl14 { get; set; }

    public int? IdMatMisSl15 { get; set; }

    public int? IdMatMisSl16 { get; set; }

    public string? MatMisSl1 { get; set; }

    public string? MatMisSl2 { get; set; }

    public string? MatMisSl3 { get; set; }

    public string? MatMisSl4 { get; set; }

    public string? MatMisSl5 { get; set; }

    public string? MatMisSl6 { get; set; }

    public string? MatMisSl7 { get; set; }

    public string? MatMisSl8 { get; set; }

    public string? MatMisSl9 { get; set; }

    public string? MatMisSl10 { get; set; }

    public string? MatMisSl11 { get; set; }

    public string? MatMisSl12 { get; set; }

    public string? MatMisSl13 { get; set; }

    public string? MatMisSl14 { get; set; }

    public string? MatMisSl15 { get; set; }

    public string? MatMisSl16 { get; set; }

    public bool? CkMatMis { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? TotCapiLordi { get; set; }
}
