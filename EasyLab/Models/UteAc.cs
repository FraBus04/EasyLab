using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class UteAc
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public int IdItem { get; set; }

    public int IdUte { get; set; }

    public bool CkVis { get; set; }

    public bool CkIns { get; set; }

    public bool CkUpd { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
