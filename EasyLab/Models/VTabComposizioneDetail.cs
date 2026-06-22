using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VTabComposizioneDetail
{
    public int Id { get; set; }

    public int IdComp { get; set; }

    public int IdFibra { get; set; }

    public int Perc { get; set; }

    public int OrdPm { get; set; }

    public string? Cod { get; set; }

    public string? Fibra { get; set; }

    public string? Composizione { get; set; }

    public string? CdImp { get; set; }
}
