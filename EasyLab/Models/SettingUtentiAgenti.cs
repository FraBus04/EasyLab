using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SettingUtentiAgenti
{
    public int Id { get; set; }

    public int? IdUte { get; set; }

    public int? IdContatto { get; set; }

    public int? IdAg { get; set; }
}
