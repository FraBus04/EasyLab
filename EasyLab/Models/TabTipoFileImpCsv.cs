using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTipoFileImpCsv
{
    public int Id { get; set; }

    public int IdClasseDoc { get; set; }

    public string Descr { get; set; } = null!;

    public string? RìStruttura { get; set; }

    public string? Sqlcode { get; set; }

    public string? NomeFile { get; set; }
}
