using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentiBst
{
    public string? Deposito { get; set; }

    public string? Doc { get; set; }

    public string? DataDoc { get; set; }

    public string? Numero { get; set; }

    public int? Riga { get; set; }

    public string? Modello { get; set; }

    public string? Parte { get; set; }

    public string? Colore { get; set; }

    public string? Taglia { get; set; }

    public string? Segno { get; set; }

    public int? Quatint { get; set; }

    public string? Descrizione { get; set; }

    public double? PrezzoListino { get; set; }

    public double? PrezzoApplicato { get; set; }

    public double? TotaleValore { get; set; }

    public string? OpSconto { get; set; }

    public int? Sconto { get; set; }

    public string? CodOper { get; set; }

    public string? DescOper { get; set; }

    public string? TipoCli { get; set; }

    public string? DepCli { get; set; }

    public string? CodCli { get; set; }

    public string? CodSpe { get; set; }

    public string? RagioneSociale { get; set; }

    public DateTime? DataImp { get; set; }
}
