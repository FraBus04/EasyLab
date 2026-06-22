using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListSs2421
{
    public string Season { get; set; } = null!;

    public string Style { get; set; } = null!;

    public string Fabric { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string CatMercMacroDesc { get; set; } = null!;

    public string CatMercDesc { get; set; } = null!;

    public string? DescCommercMod { get; set; }

    public string? TotVend { get; set; }

    public short WhsEuro { get; set; }

    public short RetailEuro { get; set; }

    public short _7wlsRow { get; set; }

    public short _8retRow { get; set; }

    public short _9wlsRu { get; set; }

    public short _10retRu { get; set; }
}
