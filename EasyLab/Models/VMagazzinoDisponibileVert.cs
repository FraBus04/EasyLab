using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMagazzinoDisponibileVert
{
    public int? Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public short? IdStag { get; set; }

    public string? StagCod { get; set; }

    public string? StagDesc { get; set; }

    public string? CodMag { get; set; }

    public string? CodMagDesc { get; set; }

    public bool? MagDisp { get; set; }

    public DateTime Ts { get; set; }

    public int IdBarcode { get; set; }

    public short? Nr { get; set; }

    public string? Ean { get; set; }

    public int? IdMdl { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? CodCol { get; set; }

    public string? DescCol { get; set; }

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? Taglia { get; set; }

    public int? IdSet { get; set; }

    public int? IdTaglia { get; set; }

    public string? Stato { get; set; }

    public string? MadeIn { get; set; }

    public string? MadeInDesc { get; set; }

    public string? HsCode { get; set; }

    public string? Op { get; set; }

    public string? Composizione { get; set; }

    public short? Peso { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public int? IdModColNoStag { get; set; }
}
