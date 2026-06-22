using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Bom
{
    public int? Stagione { get; set; }

    public string? Versione { get; set; }

    public string? DescrizioneArticolo { get; set; }

    public string? Modello { get; set; }

    public string? Parte { get; set; }

    public string? Colore { get; set; }

    public string? IdTessuto { get; set; }

    public string? ParteDiba { get; set; }

    public string? ParteDibaDex { get; set; }

    public string? AbbColoreParte { get; set; }

    public string? ColoreParte { get; set; }

    public string? ColoreParteDex { get; set; }

    public string? Fornitore { get; set; }

    public string? FornitoreDex { get; set; }

    public string? Posizione { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? CodColFornitore { get; set; }

    public string? Composizione { get; set; }

    public string? Misura { get; set; }

    public string? UdM { get; set; }

    public string? ConsumoCapo { get; set; }

    public string? Consumo { get; set; }

    public string? Note { get; set; }

    public string? Trattamento { get; set; }

    public string? TrattamentoDex { get; set; }

    public int? IdFornitore { get; set; }

    public int? IdMateriale { get; set; }

    public int? IdMod { get; set; }

    public string? CdTipoModello { get; set; }

    public int? IdStagione { get; set; }
}
