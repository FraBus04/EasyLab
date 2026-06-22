using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzSpedPklEan
{
    public int Id { get; set; }

    public int IdPkltesta { get; set; }

    public int IdPklbox { get; set; }

    public int IdEan { get; set; }

    public int? IdModCol { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetGroup { get; set; }

    public int? IdSetOrd { get; set; }

    public int? IdRigaOrd { get; set; }

    public DateTime DataIns { get; set; }

    public int IdUteIns { get; set; }
}
