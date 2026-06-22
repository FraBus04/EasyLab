using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingUtenti
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public int IdUte { get; set; }

    public int? IdAttr { get; set; }

    public bool? ValCk { get; set; }

    public int? ValInt { get; set; }

    public string? ValStr { get; set; }

    public string? Chiave { get; set; }

    public DateOnly? ValData { get; set; }

    public DateTime? DataIns { get; set; }
}
