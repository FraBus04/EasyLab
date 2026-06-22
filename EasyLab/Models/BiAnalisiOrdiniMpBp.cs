using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BiAnalisiOrdiniMpBp
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int? IdCanale { get; set; }

    public int? IdMat { get; set; }

    public int? IdMatCol { get; set; }

    public int? IdMatMis { get; set; }

    public double? OrdMp { get; set; }

    public double? OrdMp1 { get; set; }

    public double? OrdMp2 { get; set; }

    public double? OrdMpval { get; set; }

    public double? OrdMp1val { get; set; }

    public double? OrdMp2val { get; set; }

    public double? Bpevaso { get; set; }

    public double? PzMedioOrd { get; set; }

    public double? PzScheda { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUte { get; set; }

    public double? Mag { get; set; }

    public double? BpevasoVal { get; set; }
}
