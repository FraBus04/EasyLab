using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzSpedPklEpc
{
    public int Id { get; set; }

    public int IdPkltesta { get; set; }

    public int IdPklbox { get; set; }

    public int IdEan { get; set; }

    public string Epc { get; set; } = null!;

    public DateTime DataIns { get; set; }

    public int IdUteIns { get; set; }

    public int? IdRigaOrd { get; set; }

    public int? IdModCol { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetGroup { get; set; }

    public int? IdSetOrd { get; set; }
}
