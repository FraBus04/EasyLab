using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class GridSetting
{
    public string GridName { get; set; } = null!;

    public int GridVersion { get; set; }

    public byte[]? GridSet { get; set; }
}
