using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VDocTestaLink
{
    public int Id { get; set; }

    public int IdDoc { get; set; }

    public string? TipoDoc { get; set; }

    public int IdDocLink { get; set; }

    public string? DocLinkTipoDoc { get; set; }

    public int? DocLinkIdTipoDoc { get; set; }

    public string? DocLinkForn { get; set; }

    public string? DocLinkNrDoc { get; set; }

    public DateOnly? DocLinkDataDoc { get; set; }

    public int? DocLinkIdTipoMov1 { get; set; }

    public string? DocLinkMovCod1 { get; set; }

    public string? DocLinkMovDesc1 { get; set; }

    public int? DocLinkIdTipoMov2 { get; set; }

    public string? DocLinkMovCod2 { get; set; }

    public string? DocLinkMovDesc2 { get; set; }

    public string? DocLinkMag1 { get; set; }

    public string? DocLinkMag2 { get; set; }
}
