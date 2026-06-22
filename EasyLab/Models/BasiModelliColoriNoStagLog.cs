using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliColoriNoStagLog
{
    public int Id { get; set; }

    public int IdColNoStag { get; set; }

    public DateTime DataIns { get; set; }

    public string StatoPv { get; set; } = null!;

    public int IdUteIns { get; set; }
}
