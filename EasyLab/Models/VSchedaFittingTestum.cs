using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSchedaFittingTestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public string? StatoDescr { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public string? TipoModello { get; set; }

    public int? IdStag { get; set; }

    public string? StagCod { get; set; }

    public int IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string Cod { get; set; } = null!;

    public string? RichText { get; set; }

    public DateOnly? DataScheda { get; set; }

    public string? Luogo { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public string? Cad { get; set; }

    public string? Nota { get; set; }

    public string? PathImg { get; set; }

    public int? IdModellista { get; set; }

    public string? Modellista { get; set; }

    public string? CatMercMacro { get; set; }

    public string? CatMercMacroDescr { get; set; }

    public string? CatMerc { get; set; }

    public string? CatMercDescr { get; set; }

    public string? Trattamento { get; set; }

    public string? Stiro { get; set; }

    public string? Imballo { get; set; }

    public string StatoModCod { get; set; } = null!;

    public string StatoModDescr { get; set; } = null!;

    public int? IdAvanzMod { get; set; }

    public string? AvanzCod { get; set; }

    public string? AvamzMod { get; set; }

    public bool? CkEffettiva { get; set; }
}
