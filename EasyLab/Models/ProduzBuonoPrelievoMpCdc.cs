using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzBuonoPrelievoMpCdc
{
    public int Id { get; set; }

    public int IdBpriga { get; set; }

    public int IdComm { get; set; }

    public int IdCdc { get; set; }

    public DateOnly DataMov { get; set; }

    public int? IdDoc { get; set; }

    public DateTime? DataIns { get; set; }
}
