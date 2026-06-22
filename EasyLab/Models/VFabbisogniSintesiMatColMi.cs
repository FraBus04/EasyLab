using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VFabbisogniSintesiMatColMi
{
    public string Tipo { get; set; } = null!;

    public int? IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdMat { get; set; }

    public int IdMatCol { get; set; }

    public int IdMatMis { get; set; }

    public string Stato { get; set; } = null!;

    public string? Mat { get; set; }

    public string? ColMat { get; set; }

    public string? Misura { get; set; }

    public string? MatColMis { get; set; }

    public double? FabbNetto { get; set; }

    public double? FabbLordi { get; set; }

    public decimal? MagLordo { get; set; }

    public string? DescMat { get; set; }

    public string? Fornitore { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? Um { get; set; }

    public double? Pz { get; set; }

    public string? CdTipoMat { get; set; }

    public int? IdTesta { get; set; }

    public string? DescCol { get; set; }

    public string? CodColForn { get; set; }

    public string? NotaMatCol { get; set; }

    public int? IdContattoMat { get; set; }

    public string? ContattoMat { get; set; }

    public bool? CkSemilav { get; set; }

    public string? SelCdMag { get; set; }

    public string? NotaMatCol2 { get; set; }

    public string? NotaMatCol3 { get; set; }
}
