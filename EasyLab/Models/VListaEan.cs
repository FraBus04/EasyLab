using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VListaEan
{
    public int Id { get; set; }

    public int? IdTesta { get; set; }

    public int? NrLista { get; set; }

    public string? NotaTesta { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int IdUte { get; set; }

    public string Ean { get; set; } = null!;

    public string? Epc { get; set; }

    public DateTime DataIns { get; set; }

    public string? StagCod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? Colore { get; set; }

    public string? DescCol { get; set; }

    public string? Taglia { get; set; }

    public int IdEan { get; set; }

    public int? OrdTg { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdStag { get; set; }

    public int? IdSet { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSetGroup { get; set; }

    public int? IdDoc { get; set; }
}
