using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzBuonoPrelievoMpDetail
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? ACdAll { get; set; }

    public string? ATipo { get; set; }

    public string? AParte { get; set; }

    public string? AParteDesc { get; set; }

    public string? AParteMis { get; set; }

    public int IdStag { get; set; }

    public int NrScheda { get; set; }

    public string? BCdAll { get; set; }

    public string? BCdAllcol { get; set; }

    public string? BCdAllmis { get; set; }

    public string? BParte { get; set; }

    public string? BParteDesc { get; set; }

    public string? BParteCol { get; set; }

    public string? BParteColDesc { get; set; }

    public string? BParteMis { get; set; }

    public string? BTp { get; set; }

    public string? BUm { get; set; }

    public double? FabbNetto { get; set; }

    public int? CapiFabbNetto { get; set; }

    public DateTime? DataEvaso { get; set; }

    public double? QtaLorda { get; set; }

    public string? Nota { get; set; }

    public double? Cons { get; set; }

    public bool? CkMatMis { get; set; }

    public string Lotto { get; set; } = null!;

    public string? CdMag { get; set; }

    public string? OrdTipo { get; set; }

    public int? IdLab { get; set; }

    public string? Lab { get; set; }

    public DateTime? DataComm { get; set; }

    public DateTime? DataRicRientro { get; set; }

    public DateTime? DataConfRientro { get; set; }

    public bool? CkConf { get; set; }

    public int? Hutile { get; set; }

    public int? IdTesta { get; set; }

    public string Stato { get; set; } = null!;

    public int? NrBuono { get; set; }

    public int? IdComm { get; set; }

    public int? IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }
}
