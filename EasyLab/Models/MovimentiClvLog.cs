using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentiClvLog
{
    public int Id { get; set; }

    public int IdComm { get; set; }

    public string? Nota { get; set; }

    public int IdMov { get; set; }

    public int IdFase { get; set; }

    public DateTime DataIns { get; set; }

    public int IdUteIns { get; set; }
}
