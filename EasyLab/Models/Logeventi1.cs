using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Logeventi1
{
    public int Chiave { get; set; }

    public DateOnly? Datalog { get; set; }

    public string? Utente { get; set; }

    public string? Evento { get; set; }
}
