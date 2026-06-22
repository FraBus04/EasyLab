using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class QbLoroArticoli
{
    public string? Idarticolo { get; set; }

    public string? Articolo { get; set; }

    public string? Composizione { get; set; }

    public short? PesoGMq { get; set; }

    public byte? TolleranzaPesoGMq { get; set; }

    public short? PesoGMl { get; set; }

    public byte? AltezzaUtile { get; set; }

    public byte? TolleranzaAltUtile { get; set; }

    public byte? StabilitDimensionaleTrama { get; set; }

    public byte? StabilitrDimensionaleCatena { get; set; }

    public int? PlmPesoMttl { get; set; }

    public int? PlmHutil { get; set; }

    public int? PlmRitX { get; set; }

    public int? PlmRitY { get; set; }

    public int? PlmIdMat { get; set; }

    public int? PlmPesoMtQ { get; set; }
}
