using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class OrdiniMpTestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string Stato { get; set; } = null!;

    public int IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public int? IdTipoStakDest { get; set; }

    public string NrOrd { get; set; } = null!;

    public string TipoOrd { get; set; } = null!;

    public string CdValuta { get; set; } = null!;

    public int? IdPag { get; set; }

    public DateOnly DataOrd { get; set; }

    public DateOnly? DataConfFor { get; set; }

    public DateOnly? DataConsConf { get; set; }

    public string? Nota { get; set; }

    public string? FlagApp { get; set; }

    public DateOnly? DataApp { get; set; }

    public string CdStatoOrdMp { get; set; } = null!;

    public int? IdStag { get; set; }

    public int? IdLinea { get; set; }

    public string? Po { get; set; }

    public double? ValQtOrd { get; set; }

    public double? ValQtArr { get; set; }

    public DateOnly DataPrev { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdResa { get; set; }

    public string? StatoApp { get; set; }

    public string StatoExp { get; set; } = null!;

    public int? IdUteApp { get; set; }

    public DateTime? DateApp { get; set; }

    public DateTime? DataExp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public DateTime? DataImp { get; set; }

    public double? Sco1 { get; set; }

    public double? Sco2 { get; set; }

    public double? Sco3 { get; set; }

    public string? CdMag { get; set; }
}
