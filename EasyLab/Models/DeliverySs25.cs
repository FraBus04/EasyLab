using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class DeliverySs25
{
    public string Modello { get; set; } = null!;

    public string Parte { get; set; } = null!;

    public string CodColore { get; set; } = null!;

    public string DeliveryLaura { get; set; } = null!;

    public int? IdRagg { get; set; }
}
