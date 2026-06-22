using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiModelliColori
{
    public int IdCol { get; set; }

    public string? Tipo { get; set; }

    public int IdMod { get; set; }

    public int? IdStag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string CodCol { get; set; } = null!;

    public string DescCol { get; set; } = null!;

    public int? OrdPm { get; set; }

    public string? PathImg { get; set; }

    public bool Enabled { get; set; }

    public string? StatoMod { get; set; }

    public int? IdContatto { get; set; }

    public string? PathImgMod { get; set; }

    public string? LineaCod { get; set; }

    public string? LineaDesc { get; set; }

    public string? Gender { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public int? Cont { get; set; }

    public int? IdModColNoStag { get; set; }

    public string? Stag { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? OrdPmstag { get; set; }

    public byte[]? ImmagineCol { get; set; }

    public string? CodColForn { get; set; }

    public DateTime? DataInsMod { get; set; }

    public string? Modellista { get; set; }

    public string? CatMercMacro { get; set; }

    public string? TipoPunto { get; set; }

    public string? Trattamento { get; set; }

    public string? Vestibilita { get; set; }

    public string? TgBase { get; set; }

    public string? TgDa { get; set; }

    public string? TgA { get; set; }

    public string? NotaCostruz { get; set; }

    public string? BaseProv { get; set; }

    public string? Nota { get; set; }

    public string? FornPref { get; set; }

    public string? Lab { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? TipoModello { get; set; }

    public string? StatoApp { get; set; }

    public string? NotaCol { get; set; }

    public string? PathImg2 { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdSet { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAll { get; set; }
}
