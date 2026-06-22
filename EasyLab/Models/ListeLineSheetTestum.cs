using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListeLineSheetTestum
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public string Cod { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public bool CkModCol { get; set; }

    public int? IdTipoList1 { get; set; }

    public int? IdTipoList2 { get; set; }

    public int? IdTipoList3 { get; set; }

    public int? IdTipoList4 { get; set; }

    public int? IdTipoList5 { get; set; }

    public int? IdTipoList6 { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public string? StatoApp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataLastExp { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

    public int? IdOrd { get; set; }
}
