using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Documenti
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdClasse { get; set; }

    public int IdClasseDocumento { get; set; }

    public int IdRif { get; set; }

    public string? BarCode { get; set; }

    public int? TipoDoc { get; set; }

    public string? DocRich { get; set; }

    public string? NomeFile { get; set; }

    public string? Estn { get; set; }

    public string? Nota { get; set; }

    public int? IdStag { get; set; }

    public DateOnly? ValidDa { get; set; }

    public DateOnly? ValidA { get; set; }

    public string? CdOp { get; set; }

    public int? IdNomeComune { get; set; }

    public int? IdNomeScientifico { get; set; }

    public int? IdProvenienza { get; set; }

    public int? IdDescPellame { get; set; }

    public int? IdNazione { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? Cartella { get; set; }

    public string? StatoAppDesc { get; set; }
}
