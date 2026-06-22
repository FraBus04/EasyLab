using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzSpedPklbox
{
    public int Id { get; set; }

    public int IdPkltesta { get; set; }

    public int? IdDdtDimensioniColli { get; set; }

    public int? NrCollo { get; set; }

    public decimal? PesoLordo { get; set; }

    public decimal? PesoNetto { get; set; }

    public decimal? Tara { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
