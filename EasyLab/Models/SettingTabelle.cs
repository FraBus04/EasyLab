using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingTabelle
{
    public int Id { get; set; }

    public string Ragg { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    public string Form { get; set; } = null!;

    public int OrdPm { get; set; }

    public string Stato { get; set; } = null!;
}
