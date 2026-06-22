using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VListaEanTestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int NrLista { get; set; }

    public int IdUte { get; set; }

    public DateTime DataIns { get; set; }

    public string? Nota { get; set; }

    public string? Ute { get; set; }

    public int? IdCcli { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? Citta { get; set; }

    public string? Prov { get; set; }

    public string? Chiedere { get; set; }

    public string? CapNew { get; set; }

    public int? TotCapi { get; set; }

    public bool Lock { get; set; }
}
