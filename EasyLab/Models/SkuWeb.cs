using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SkuWeb
{
    public short? Id { get; set; }

    public string? NameIt { get; set; }

    public string? NameEn { get; set; }

    public string? ArtCode { get; set; }

    public string? SkuSize { get; set; }

    public long? Barcode { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public short? Total { get; set; }

    public byte? N001 { get; set; }

    public byte? Ml01 { get; set; }

    public byte? Ch01 { get; set; }

    public byte? Ml05 { get; set; }

    public short? T001 { get; set; }

    public byte? T002 { get; set; }

    public byte? T003 { get; set; }
}
