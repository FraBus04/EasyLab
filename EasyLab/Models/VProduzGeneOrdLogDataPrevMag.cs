using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VProduzGeneOrdLogDataPrevMag
{
    public int Id { get; set; }

    public int IdUte { get; set; }

    public int IdRiga { get; set; }

    public DateOnly? DataOld { get; set; }

    public DateOnly? DataNew { get; set; }

    public bool? CkDataConf { get; set; }

    public DateTime DataIns { get; set; }

    public string? Ute { get; set; }

    public string? Contatto { get; set; }

    public string? Stag { get; set; }

    public string? OrdTipo { get; set; }

    public int? OrdNr { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? ColOrd { get; set; }

    public string? Po { get; set; }

    public string? Anag1 { get; set; }

    public string? Citta { get; set; }
}
