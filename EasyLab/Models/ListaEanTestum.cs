using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListaEanTestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int NrLista { get; set; }

    public int IdUte { get; set; }

    public DateTime DataIns { get; set; }

    public string? Nota { get; set; }

    public int? IdCcli { get; set; }

    public bool Lock { get; set; }
}
