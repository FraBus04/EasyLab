using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpOrdiniMpBonadiman2
{
    public string? Causale { get; set; }

    public string? Intestatario { get; set; }

    public string? NumDoc { get; set; }

    public string? DataRegistrazione { get; set; }

    public string? CodiceArticolo { get; set; }

    public string? CodiceCliente { get; set; }

    public string? Descrizione { get; set; }

    public string? DescrizioneSupplementare { get; set; }

    public string? Um { get; set; }

    public string? QtaMovimentata { get; set; }

    public string? QtaResidua { get; set; }

    public string? QtaEvasaOrd { get; set; }

    public string? QtaEvasaDdt { get; set; }

    public string? QtaEvasaGen { get; set; }

    public string? EvasoTotalmenteEvasoTotalmente { get; set; }

    public string? DataConsegna { get; set; }

    public string? Mat { get; set; }

    public string? MatCol { get; set; }

    public string? MatMis { get; set; }

    public int? IdStag { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public string? TempStr { get; set; }

    public bool? CkMatMis { get; set; }

    public DateOnly? DataOrd { get; set; }

    public DateOnly? DataConfFor { get; set; }

    public int? IdOrdImp { get; set; }

    public double? QtOrd { get; set; }

    public double? QtArr { get; set; }

    public double? QtTotDaRicevere { get; set; }

    public bool? CkErr { get; set; }

    public bool? CkDataConf { get; set; }

    public int Id { get; set; }
}
