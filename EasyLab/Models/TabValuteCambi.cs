using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabValuteCambi
{
    public int Id { get; set; }

    public string CdValuta { get; set; } = null!;

    public DateOnly DataDa { get; set; }

    public DateOnly DataA { get; set; }

    public decimal Cambio { get; set; }

    public decimal CambioValutaEuro { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }
}
