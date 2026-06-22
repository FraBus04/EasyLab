using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentiCf
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdCausale { get; set; }

    public int IdTipoMov { get; set; }

    public int IdEan { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int IdSet { get; set; }

    public int IdSetTaglia { get; set; }

    public int IdSetOrd { get; set; }

    public string CdMag { get; set; } = null!;

    public short? Nr { get; set; }

    public int? IdTesta { get; set; }

    public int? IdComm { get; set; }

    public int? IdDoc { get; set; }

    public int? IdDocRiga { get; set; }

    public int? IdOrd { get; set; }

    public int? IdOrdRiga { get; set; }

    public int? IdScontrino { get; set; }

    public int? IdScontrinoDett { get; set; }

    public int? IdRigaAvanz { get; set; }

    public int? IdRigaMovOriz { get; set; }

    public string? Nota { get; set; }

    public DateTime DataMov { get; set; }

    public int? CodUbicazione { get; set; }

    public string? RifCliente { get; set; }

    public string? CodUbic { get; set; }

    public string? Mov { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public double? Pz { get; set; }

    public string Lotto { get; set; } = null!;

    public int? IdBp { get; set; }

    public int? IdBpriga { get; set; }

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public bool? Lock { get; set; }

    public DateTime? DataLock { get; set; }

    public int? IdUteLock { get; set; }
}
