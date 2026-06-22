using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SetMyPath
{
    public short Id { get; set; }

    public string Descr { get; set; } = null!;

    public string Path { get; set; } = null!;
}
