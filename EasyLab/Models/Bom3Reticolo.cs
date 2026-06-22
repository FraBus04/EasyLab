using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Bom3Reticolo
{
    public int Id { get; set; }

    public string ATipo { get; set; } = null!;

    public int AIdContatto { get; set; }

    public int AIdStag { get; set; }

    public string ACdAll { get; set; } = null!;

    public bool ACkSemilav { get; set; }

    public int Ver { get; set; }

    public bool? CkVer { get; set; }

    public string? NotaVer { get; set; }

    public int IdFase { get; set; }

    public int Seq { get; set; }

    public string? BTipo { get; set; }

    public string? BCdAll { get; set; }

    public bool? BCkSemilav { get; set; }

    public string Um { get; set; } = null!;

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public bool CkMatMis { get; set; }

    public bool CkColUnico { get; set; }

    public bool CkContr { get; set; }

    public string Posizione { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Tp { get; set; } = null!;

    public string Tp2 { get; set; } = null!;

    public string Tp3 { get; set; } = null!;

    public int? IdPack { get; set; }

    public int? IdMatColPack { get; set; }

    public int? IdPos { get; set; }

    public string? CdRegolaCons { get; set; }

    public int? IdRegMis { get; set; }

    public double Cons { get; set; }

    public string? ACdAllmis { get; set; }

    public string? BCdAllmis { get; set; }

    public string? OrdImp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public DateTime? DataVer { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdUteVer { get; set; }

    public DateTime? DataImp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public int? IdOld { get; set; }

    public int? IdRigaOld { get; set; }

    public int? IdPackDett { get; set; }
}
