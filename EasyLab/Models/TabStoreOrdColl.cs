using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabStoreOrdColl
{
    public int Id { get; set; }

    public int IdLista { get; set; }

    public int IdStag { get; set; }

    public string CdMag { get; set; } = null!;

    public int IdOrd { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? BudgetVal { get; set; }

    public int? BudgetCapi { get; set; }

    public int? OrdPm { get; set; }
}
