using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VMovimentiClv
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

    public string Lotto { get; set; } = null!;

    public int IdCcli { get; set; }

    public int IdDocRiga { get; set; }

    public int IdMov { get; set; }

    public int IdFase { get; set; }

    public double Qta { get; set; }

    public string Nota { get; set; } = null!;

    public DateOnly? DataRicRientro { get; set; }

    public DateOnly? DataConfRientro { get; set; }

    public bool? CkConfRientro { get; set; }

    public double Prz { get; set; }

    public string CdValuta { get; set; } = null!;

    public string? NrDoc { get; set; }

    public string? Forn { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Parte { get; set; }

    public string? ParteDesc { get; set; }

    public string? MovCod { get; set; }

    public string? MovDesc { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public int? NrComm { get; set; }

    public string? StagCod { get; set; }

    public string? StagDesc { get; set; }

    public string? OrdTipo { get; set; }

    public bool CkOpen { get; set; }

    public int? IdRigaCar { get; set; }

    public string? Contatto { get; set; }

    public int? OrdPmfase { get; set; }

    public DateTime DataIns { get; set; }
}
