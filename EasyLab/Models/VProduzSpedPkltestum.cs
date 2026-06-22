using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzSpedPkltestum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdOrd { get; set; }

    public int IdCcli { get; set; }

    public int IdCcliDest { get; set; }

    public DateOnly DataPkl { get; set; }

    public int? TotCapi { get; set; }

    public int? NrBox { get; set; }

    public decimal? PesoLordo { get; set; }

    public decimal? PesoNetto { get; set; }

    public decimal? Tara { get; set; }

    public string? Contatto { get; set; }

    public string? Stag { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag1Dest { get; set; }

    public int? OrdNr { get; set; }

    public string? OrdTipo { get; set; }

    public string? Rif { get; set; }

    public bool CkBp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public DateTime? DataClose { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime? DataSel { get; set; }

    public int? IdLinea { get; set; }
}
