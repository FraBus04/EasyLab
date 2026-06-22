using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VCollPlanGroup
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdCollTesta { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public int? IdCatMerc2 { get; set; }

    public int? PrzDa { get; set; }

    public int? PrzA { get; set; }

    public int? Qta { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? CatMercMacro { get; set; }

    public string? CatMerc { get; set; }

    public string? CatMercMacro2 { get; set; }

    public string? CatMerc2 { get; set; }

    public string? Contatto { get; set; }

    public string? Stag { get; set; }

    public string? CollPlanCod { get; set; }

    public string? CollPlanDescr { get; set; }

    public int? IdStag { get; set; }

    public int? IdContatto { get; set; }

    public string? CollPlanGroupDescr { get; set; }
}
