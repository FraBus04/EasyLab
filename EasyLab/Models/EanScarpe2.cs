using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class EanScarpe2
{
    public string? NrOrdine { get; set; }

    public short? NrOrdineCliente { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Col { get; set; }

    public string? Descrizione { get; set; }

    public DateOnly? Consegna { get; set; }

    public string? CodAgente { get; set; }

    public string? Marchio { get; set; }

    public string? StagioneOrd { get; set; }

    public int? CodArtInt { get; set; }

    public string? CodArt { get; set; }

    public string? DescrArt { get; set; }

    public double? CodColore { get; set; }

    public string? DescrColore { get; set; }

    public double? Prezzo { get; set; }

    public byte? Sconto { get; set; }

    public double? PrezzoConsPubbl { get; set; }

    public double? Taglia { get; set; }

    public byte? QTConfermata { get; set; }

    public byte? QTSpedita { get; set; }

    public byte? QTInevasa { get; set; }

    public byte? QTStornata { get; set; }

    public double? TotaleValore { get; set; }

    public double? ValoreSconto { get; set; }

    public long? EanCode { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdSet { get; set; }

    public int? IdStag { get; set; }

    public string? Tg { get; set; }
}
