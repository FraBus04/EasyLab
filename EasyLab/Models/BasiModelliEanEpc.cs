using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliEanEpc
{
    public long Id { get; set; }

    public string Epc { get; set; } = null!;

    public int IdComm { get; set; }

    public int IdModCol { get; set; }

    public int IdSetOrd { get; set; }

    public int IdEan { get; set; }

    public string Ean { get; set; } = null!;

    public int Epccount { get; set; }

    public bool CkContr { get; set; }

    public bool CkStampa { get; set; }

    public string Stato { get; set; } = null!;

    public DateTime DataIns { get; set; }

    public int IdUteIns { get; set; }
}
