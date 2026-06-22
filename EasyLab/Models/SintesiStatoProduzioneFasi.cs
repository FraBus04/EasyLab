using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SintesiStatoProduzioneFasi
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdFaseComm { get; set; }

    public int? IdCcli { get; set; }

    public int? TotCapi { get; set; }

    public double? TotVal { get; set; }

    public string? Color { get; set; }

    public int? Colore { get; set; }
}
