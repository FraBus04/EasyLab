using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Esploso
{
    public string? CodParte { get; set; }

    public string? DesParte { get; set; }

    public string? Colore { get; set; }

    public double? Qta { get; set; }

    public string? Misura { get; set; }

    public string? Umis { get; set; }

    public string? CodFornitore { get; set; }

    public string? DesFornitore { get; set; }

    public string? CodiceArticoloFornitore { get; set; }

    public string? ModelloDiBa { get; set; }

    public string? DesModelloDiBa { get; set; }

    public string? ParteDiBa { get; set; }

    public string? DesParteDiBa { get; set; }

    public string? ColoreDiBa { get; set; }

    public string? ArticoloSease { get; set; }

    public string? DiBaParteCodFor { get; set; }

    public int? IdFornitore { get; set; }

    public int? IdMod { get; set; }
}
