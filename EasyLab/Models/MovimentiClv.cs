using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentiClv
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdDoc { get; set; }

    public int IdComm { get; set; }

    public DateOnly DataMov { get; set; }

    public int IdCausale { get; set; }

    public int IdStag { get; set; }

    public string CdAll { get; set; } = null!;

    public int IdMod { get; set; }

    public int IdMat { get; set; }

    public string Lotto { get; set; } = null!;

    public int IdCcli { get; set; }

    public int IdDocRiga { get; set; }

    public int IdMov { get; set; }

    public int IdFase { get; set; }

    public int? IdRigaCar { get; set; }

    public bool CkOpen { get; set; }

    public double Qta { get; set; }

    public string Nota { get; set; } = null!;

    public DateOnly? DataRicRientro { get; set; }

    public DateOnly? DataConfRientro { get; set; }

    public bool? CkConfRientro { get; set; }

    public double Prz { get; set; }

    public string CdValuta { get; set; } = null!;

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }
}
