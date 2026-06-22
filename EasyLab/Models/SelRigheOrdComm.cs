using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelRigheOrdComm
{
    public int Id { get; set; }

    public int? IdOrd { get; set; }

    public int? IdStag { get; set; }

    public int? IdContatto { get; set; }

    public string? ACdAll { get; set; }

    public string? ACdAllcol { get; set; }

    public string? ACdAllmis { get; set; }

    public string? Parte { get; set; }

    public string? ParteDesc { get; set; }

    public string? ParteCol { get; set; }

    public string? ParteMis { get; set; }

    public int? OrdNr { get; set; }

    public int? IdRiga { get; set; }

    public int? DaL1 { get; set; }

    public int? DaL2 { get; set; }

    public int? DaL3 { get; set; }

    public int? DaL4 { get; set; }

    public int? DaL5 { get; set; }

    public int? DaL6 { get; set; }

    public int? DaL7 { get; set; }

    public int? DaL8 { get; set; }

    public int? DaL9 { get; set; }

    public int? DaL10 { get; set; }

    public int? DaL11 { get; set; }

    public int? TotCapi { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdMod { get; set; }

    public int? IdLab { get; set; }

    public DateOnly? DataRichiesta { get; set; }

    public string? CodCol { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? OrdTipo { get; set; }

    public int? IdModCol { get; set; }

    public int? DaL12 { get; set; }

    public int? DaL13 { get; set; }

    public int? DaL14 { get; set; }

    public int? DaL15 { get; set; }

    public int? DaL16 { get; set; }
}
