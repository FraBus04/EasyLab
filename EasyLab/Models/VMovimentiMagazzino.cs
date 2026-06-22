using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMovimentiMagazzino
{
    public string Stato { get; set; } = null!;

    public int? IdContatto { get; set; }

    public string? Societa1 { get; set; }

    public int? IdStag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? CodCol { get; set; }

    public string CodMag { get; set; } = null!;

    public int CodUbicazione { get; set; }

    public string? RifCliente { get; set; }

    public int IdCausale { get; set; }

    public DateTime DataMov { get; set; }

    public string? Nota { get; set; }

    public short? Nr { get; set; }

    public string? CausaleDesc { get; set; }

    public string? StagDesc { get; set; }

    public string? Nome { get; set; }

    public string? Ean { get; set; }

    public string? Taglia { get; set; }

    public int? IdSet { get; set; }

    public int? IdTaglia { get; set; }

    public string? StatoBarcode { get; set; }

    public int IdModelloColore1 { get; set; }

    public int? IdTesta { get; set; }

    public int? IdMod { get; set; }
}
