using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingGridVisteUtenti
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public int IdUte { get; set; }

    public string? Nome { get; set; }
}
