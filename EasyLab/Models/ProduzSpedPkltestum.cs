using System;
using System.Collections.Generic;

namespace EasyLab.Models;

/// <summary>
/// OPEN CLOSE
/// </summary>
public partial class ProduzSpedPkltestum
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

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public string? Rif { get; set; }

    public bool CkBp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public DateTime? DataClose { get; set; }
}
