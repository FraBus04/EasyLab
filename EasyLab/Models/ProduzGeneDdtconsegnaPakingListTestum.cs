using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneDdtconsegnaPakingListTestum
{
    public int Id { get; set; }

    public int? IdTesta { get; set; }

    public string? NrCollo { get; set; }

    public double? Peso { get; set; }

    public int? IdContatto { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdDimColli { get; set; }
}
