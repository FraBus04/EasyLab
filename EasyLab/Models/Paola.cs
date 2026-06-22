using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Paola
{
    public string? Barcode { get; set; }

    public string Model { get; set; } = null!;

    public string Fabric { get; set; } = null!;

    public string ColourCode { get; set; } = null!;

    public string RenamingCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Season { get; set; } = null!;

    public string? Colour { get; set; }

    public string? Category { get; set; }

    public string Gender { get; set; } = null!;
}
