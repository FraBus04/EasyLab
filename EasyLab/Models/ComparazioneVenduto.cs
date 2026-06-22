using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ComparazioneVenduto
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdStag1 { get; set; }

    public int? IdStag2 { get; set; }

    public int? IdStag3 { get; set; }

    public int? IdStag4 { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int Ccli { get; set; }

    public int? CcliDest { get; set; }

    public int? IdAg { get; set; }

    public int? IdCatMerc { get; set; }

    public int? TotCapiStag1 { get; set; }

    public int? TotCapiStag2 { get; set; }

    public int? TotCapiStag3 { get; set; }

    public int? TotCapiStag4 { get; set; }

    public double? ValLordoStag1 { get; set; }

    public double? ValLordoStag2 { get; set; }

    public double? ValLordoStag3 { get; set; }

    public double? ValLordoStag4 { get; set; }

    public double? PercCapi2 { get; set; }

    public double? PercCapi3 { get; set; }

    public double? PercCapi4 { get; set; }

    public double? PercValLordo2 { get; set; }

    public double? PercValLordo3 { get; set; }

    public double? PercValLordo4 { get; set; }

    public DateTime? DataIns { get; set; }

    public int? DiffCapiStag2 { get; set; }

    public int? DiffCapiStag3 { get; set; }

    public int? DiffCapiStag4 { get; set; }

    public double? DiffValLordoStag2 { get; set; }

    public double? DiffValLordoStag3 { get; set; }

    public double? DiffValLordoStag4 { get; set; }

    public int? ModoStag { get; set; }

    public int? ModoReport { get; set; }
}
