using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class DocNumerazione
{
    public int Id { get; set; }

    public int IdClasseDoc { get; set; }

    public string TipoNum { get; set; } = null!;

    public int NextNum { get; set; }

    public int? Anno { get; set; }

    public string? Pref { get; set; }

    public int? IdContatto { get; set; }
}
