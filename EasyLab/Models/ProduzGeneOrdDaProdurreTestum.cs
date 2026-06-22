using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneOrdDaProdurreTestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public DateTime Ts { get; set; }

    public bool? CkIncludiSospesi { get; set; }

    public bool? CkEscludigiaAss { get; set; }

    public bool? CkIncludiL { get; set; }

    public bool? CkIncludiR { get; set; }

    public string? TipoOrdSel { get; set; }

    public string? MagSel { get; set; }

    public string? StagSel { get; set; }

    public string? TipoModSel { get; set; }

    public int? TotCapi { get; set; }

    public int? TotCapiLordi { get; set; }

    public double? PercAvanz { get; set; }

    public int? CkDiba { get; set; }

    public int? CkDibaMod { get; set; }

    public int? CkDibaModCol { get; set; }

    public int? IdModCol { get; set; }
}
