using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiModelliAvanz
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? Tipo { get; set; }

    public string? TipoModello { get; set; }

    public string? StatoMod { get; set; }

    public string? PathLogo { get; set; }

    public int? IdStag { get; set; }

    public string? StagCod { get; set; }

    public string? StagDesc { get; set; }

    public string? Linea { get; set; }

    public int IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public int IdAvanzMod { get; set; }

    public string? AvanzCod { get; set; }

    public string? AvanzMod { get; set; }

    public string? AvanzModBreve { get; set; }

    public int? AvanzOrdPm { get; set; }

    public int? IdModellista { get; set; }

    public string? ModellistaMov { get; set; }

    public string? Nota { get; set; }

    public double? Time { get; set; }

    public DateTime? DataAvanz { get; set; }

    public byte[]? ImmagineMod { get; set; }

    public string? CatMerc { get; set; }

    public string? ModellistaMod { get; set; }

    public string? NotaMod { get; set; }

    public int? AvanzPerc { get; set; }
}
