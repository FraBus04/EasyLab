using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabClassiDocumenti
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public string Documento { get; set; } = null!;

    public string DocAbbr { get; set; } = null!;

    public int OrdPm { get; set; }

    public bool? IdStag { get; set; }

    public bool? ValidDa { get; set; }

    public bool? ValidA { get; set; }

    public bool? CdOp { get; set; }

    public bool? IdNomeComune { get; set; }

    public bool? IdNomeScientifico { get; set; }

    public bool? IdProvenienza { get; set; }

    public bool? IdDescPellame { get; set; }

    public bool? IdNazione { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
