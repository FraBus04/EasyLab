using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class MovimentiBstImport
{
    public string? Deposito { get; set; }

    public string? Doc { get; set; }

    public string? DataDoc { get; set; }

    public string? Numero { get; set; }

    public string? Riga { get; set; }

    public string? Modello { get; set; }

    public string? Parte { get; set; }

    public string? Colore { get; set; }

    public string? Taglia { get; set; }

    public string? Quatintà { get; set; }

    public string? Descrizione { get; set; }

    public string? PrezzoListino { get; set; }

    public string? PrezzoApplicato { get; set; }

    public string? TotaleValore { get; set; }

    public string? OpSconto { get; set; }

    public string? Sconto { get; set; }

    public string? CodOper { get; set; }

    public string? DescOper { get; set; }

    public string? TipoCli { get; set; }

    public string? DepCli { get; set; }

    public string? CodCli { get; set; }

    public string? CodSpe { get; set; }

    public string? RagioneSociale { get; set; }

    public DateTime? DataImp { get; set; }
}
