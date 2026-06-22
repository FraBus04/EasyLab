using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VTabellaMisureTestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int IdTabellaMisureTipo { get; set; }

    public string? TabellaMisureTipo { get; set; }

    public bool CkTemplate { get; set; }

    public string Cod { get; set; } = null!;

    public string Nota { get; set; } = null!;

    public int IdSet { get; set; }

    public string? SetCod { get; set; }

    public string? DetDesc { get; set; }

    public int IdTgBase { get; set; }

    public string? TgBase { get; set; }

    public int? IdMod { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public int? IdComm { get; set; }

    public int? CommNr { get; set; }

    public int? TotCapi { get; set; }

    public string? CommStato { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string Stato { get; set; } = null!;

    public string? StatoDescr { get; set; }

    public bool? CkEffettiva { get; set; }
}
