using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingAttributiCont
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public int IdClasse { get; set; }

    public string? Attributo { get; set; }

    public int? ValInt { get; set; }

    public bool? ValCk { get; set; }

    public string? ValStr { get; set; }
}
