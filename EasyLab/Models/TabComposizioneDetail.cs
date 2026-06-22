using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabComposizioneDetail
{
    public int Id { get; set; }

    public int IdComp { get; set; }

    public int IdFibra { get; set; }

    public int Perc { get; set; }

    public int OrdPm { get; set; }
}
