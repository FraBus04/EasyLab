using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzGeneCommesseExp
{
    public int IdComm { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int NrScheda { get; set; }

    public DateTime DataComm { get; set; }

    public string OrdTipo { get; set; } = null!;

    public DateTime? DataRicRientro { get; set; }

    public DateTime? DataConfRientro { get; set; }

    public bool? CkConf { get; set; }

    public bool? CkInvMatLogistTesta { get; set; }

    public string StatoTesta { get; set; } = null!;

    public int? TotCapiTesta { get; set; }

    public string SaldoTesta { get; set; } = null!;

    public string? NotaTesta { get; set; }

    public string? CdValuta { get; set; }

    public double? Prezzo { get; set; }

    public int? CkExp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public int? IdFase { get; set; }

    public int? Expr1 { get; set; }

    public int? IdModCol { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? Anag1 { get; set; }

    public int? IdImport { get; set; }

    public string? Tg { get; set; }

    public int? OrdTg { get; set; }

    public string? Stag { get; set; }

    public string? StagAnno { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }
}
