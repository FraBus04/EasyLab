using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VListeLineSheetKit
{
    public int Id { get; set; }

    public int IdLista { get; set; }

    public int IdKit { get; set; }

    public string? Lscod { get; set; }

    public string? Lsdesc { get; set; }

    public string? KitCod { get; set; }

    public string? KitDescr { get; set; }

    public string? KitNota { get; set; }

    public byte[]? KitImg { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public string? Nota { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? ModCol { get; set; }

    public string? DescCol { get; set; }

    public int? IdOutFit { get; set; }

    public string? OutFit { get; set; }

    public string? OutFitDesc { get; set; }

    public int? OrdPmtema { get; set; }

    public int? OrdPmkit { get; set; }

    public int? OrdPmoutFit { get; set; }

    public int? OrdPm { get; set; }

    public int? IdTema { get; set; }

    public string? Tema { get; set; }

    public string? TemaDesc { get; set; }
}
