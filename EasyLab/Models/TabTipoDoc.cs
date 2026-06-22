using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTipoDoc
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdClasseDoc { get; set; }

    public string TipoDoc { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public bool CkMov1 { get; set; }

    public bool CkMov2 { get; set; }

    public bool CkMovFasi1 { get; set; }

    public bool CkMovFasi2 { get; set; }

    public bool CkNum { get; set; }

    public int IdTipoAnagStake { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public int IdNum { get; set; }

    public bool CkExp { get; set; }

    public bool CkImpegna { get; set; }

    public int IdAvanzOrdine { get; set; }

    public int IdMov1 { get; set; }

    public int IdMov2 { get; set; }

    public string CdMag1 { get; set; } = null!;

    public string CdMag2 { get; set; } = null!;

    public string ComportForm { get; set; } = null!;

    public bool? CkMagDest { get; set; }

    public string? MagDest { get; set; }

    public bool CkChiudiDoc { get; set; }

    public bool CkDocSped { get; set; }

    public bool CkBp { get; set; }

    public bool CkCdc { get; set; }

    public int? IdCdc { get; set; }

    public string StatoBp { get; set; } = null!;

    public bool CkAvanzOrdine { get; set; }

    public bool CkOrdMp { get; set; }

    public bool? CkComm { get; set; }

    public string? CdReport { get; set; }

    public string? TipoDocErp { get; set; }

    public int? IdDdtCausale { get; set; }

    public int? IdDdtTraspCura { get; set; }

    public int? IdDdtVettore { get; set; }

    public int? IdDdtAspetto { get; set; }

    public int? IdDdtResa { get; set; }

    public string? StatoExp { get; set; }

    public string? Nota { get; set; }

    public bool? CkArchivia { get; set; }

    public int? IdClasseDocumento { get; set; }
}
