using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabTipoSkTipoCalcolo
{
    public int Id { get; set; }

    public string Descr { get; set; } = null!;

    /// <summary>
    /// Scheda
    /// ListMedio
    /// </summary>
    public string MatCosto { get; set; } = null!;

    /// <summary>
    /// DiBa
    /// BP
    /// 
    /// </summary>
    public string MatElenco { get; set; } = null!;

    /// <summary>
    /// BOL
    /// Commessa
    /// </summary>
    public string FasiCosto { get; set; } = null!;

    /// <summary>
    /// BOL
    /// ?
    /// </summary>
    public string FasiElenco { get; set; } = null!;
}
