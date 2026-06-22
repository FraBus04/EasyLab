using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class StoreStockMin
{
    public int Id { get; set; }

    public string CdMag { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdModColNoStag { get; set; }

    public int IdSetOrd { get; set; }

    public int IdModCol { get; set; }

    public int StockMin { get; set; }

    public DateTime DateIns { get; set; }

    public DateTime DateUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }
}
