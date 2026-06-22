using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiModelliEanEpc
{
    public long Id { get; set; }

    public string Epc { get; set; } = null!;

    public int IdComm { get; set; }

    public int IdModCol { get; set; }

    public int IdSetOrd { get; set; }

    public int IdEan { get; set; }

    public string Ean { get; set; } = null!;

    public int Epccount { get; set; }

    public bool CkStampa { get; set; }

    public DateTime DataIns { get; set; }

    public int IdUteIns { get; set; }

    public int? NrComm { get; set; }

    public string? OrdTipo { get; set; }

    public int? IdMod { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? ModCol { get; set; }

    public string? Tg { get; set; }

    public string? DescCol { get; set; }

    public bool CkContr { get; set; }

    public string Stato { get; set; } = null!;

    public int? IdSet { get; set; }

    public int? IdSetGroup { get; set; }
}
