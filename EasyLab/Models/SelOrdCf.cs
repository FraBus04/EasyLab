using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelOrdCf
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdUte { get; set; }

    public int IdOrd { get; set; }

    public int? OrdPm { get; set; }
}
