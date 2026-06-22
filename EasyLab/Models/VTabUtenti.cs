using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VTabUtenti
{
    public int Id { get; set; }

    public int? IdContattoMaster { get; set; }

    public int IdContatto { get; set; }

    public string Ute { get; set; } = null!;

    public string Psw { get; set; } = null!;

    public string? PathFirma { get; set; }

    public string? Stato { get; set; }

    public int? IdTipo { get; set; }

    public string? Contatto { get; set; }
}
