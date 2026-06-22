using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class FilaFw25
{
    public byte? Id { get; set; }

    public string? Barcode { get; set; }

    public string? Model { get; set; }

    public string? Fabric { get; set; }

    public string? Tg { get; set; }

    public string? ColorCode { get; set; }

    public string? RenamingCode { get; set; }

    public string? Description { get; set; }

    public string? Season { get; set; }

    public string? ColorDescription { get; set; }

    public string? Category { get; set; }

    public string? MacroCategory { get; set; }
}
