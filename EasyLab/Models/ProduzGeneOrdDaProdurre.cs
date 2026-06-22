using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneOrdDaProdurre
{
    public int Id { get; set; }

    public int IdRigaOrd { get; set; }

    public string Tipo { get; set; } = null!;

    public int Livello { get; set; }

    public string Stato { get; set; } = null!;

    public int IdTesta { get; set; }

    public int IdContatto { get; set; }

    public int? IdOrd { get; set; }

    public int IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? ACdAll { get; set; }

    public string? ACdAllcol { get; set; }

    public string? ACdAllmis { get; set; }

    public int? IdCanale { get; set; }

    public int? IdRagg1Ord { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int OrdNr { get; set; }

    public DateTime? OrdData { get; set; }

    public int Ccli { get; set; }

    public int? CcliDest { get; set; }

    public int? ProgRiga { get; set; }

    public string Mod { get; set; } = null!;

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public double? PzArt { get; set; }

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

    public int? TotCapi { get; set; }

    public int? NrCommessa { get; set; }

    public int? CkDiba { get; set; }

    public int? CkDibaMod { get; set; }

    public int? CkDibaModCol { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

    public DateOnly? DataCons { get; set; }

    public string? TipoOrdSel { get; set; }

    public DateTime? DataIns { get; set; }

    public int? TotCapiLordi { get; set; }

    public int? IdClasse { get; set; }
}
