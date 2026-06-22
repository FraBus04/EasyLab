using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliComposizioni
{
    public int Id { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdComm { get; set; }

    public string? Po { get; set; }

    public string? Supplier { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? ModCol { get; set; }

    public string? ModColDesc { get; set; }

    public string? MadeIn { get; set; }

    public string? Tg { get; set; }

    public string? Comp1 { get; set; }

    public string? Comp2 { get; set; }

    public string? Comp3 { get; set; }

    public string? Comp4 { get; set; }

    public string? Comp5 { get; set; }

    public string? NotaCare { get; set; }

    public string? CareLabel { get; set; }

    public int? CommCapi { get; set; }

    public string? CommNr { get; set; }

    public string? CommOrdTipo { get; set; }

    public string? CommText { get; set; }

    public string? CommStag { get; set; }

    public string? Lav0NotaAgg { get; set; }

    public string? NotaCare2 { get; set; }

    public string? DocCaptiv { get; set; }

    public string? DocNomeCom { get; set; }

    public string? DocNomeSci { get; set; }

    public string? DocProveni { get; set; }

    public string? DocTrattamento { get; set; }
}
