using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabPresaMisureLang
{
    public int Id { get; set; }

    public int IdLang { get; set; }

    public int IdPresaMisure { get; set; }

    public string Descr { get; set; } = null!;
}
