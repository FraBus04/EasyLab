using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzBuonoPrelievoMpRiepilogo
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdTesta { get; set; }

    public int NrBuono { get; set; }

    public int? IdComm { get; set; }

    public int IdStag { get; set; }

    public int IdLab { get; set; }

    public int NrScheda { get; set; }

    public int? IdFornBuonoRiep { get; set; }

    public string? FornBuonoRiep { get; set; }

    public int? IdFornDestBuonoRiep { get; set; }

    public string? FornDestBuonoRiep { get; set; }

    public string? CdMat { get; set; }

    public string Lotto { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public string? Mis { get; set; }

    public string? NrPezza { get; set; }

    public double? Qta { get; set; }

    public string? MagLogico { get; set; }

    public string? CdMag { get; set; }

    public string? Nota { get; set; }

    public string? Stag { get; set; }

    public string? LabAnag1 { get; set; }

    public string? LabAnag2 { get; set; }

    public string? LabCitta { get; set; }

    public string? OrdTipo { get; set; }

    public int? IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? DescMat { get; set; }

    public string? Lab { get; set; }

    public string? CodArtFornitore { get; set; }

    public string? MacroGruppo { get; set; }

    public int? TotCapiComm { get; set; }

    public string Stato { get; set; } = null!;

    public bool? CommCkInvMatLogist { get; set; }

    public double? MagLordo { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public string? DescCol { get; set; }

    public string? CodColForn { get; set; }

    public int? IdForn { get; set; }

    public string? FornAnag1 { get; set; }

    public string? FornAnag2 { get; set; }

    public string? FornCitta { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }
}
