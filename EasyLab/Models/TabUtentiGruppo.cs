using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabUtentiGruppo
{
    public int Id { get; set; }

    public string Gruppo { get; set; } = null!;

    public int IdAdmim { get; set; }
}
