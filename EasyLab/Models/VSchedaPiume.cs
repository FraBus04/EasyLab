using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSchedaPiume
{
    public int Id { get; set; }

    public int IdMod { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public string? TipoModello { get; set; }

    public string? TipoModelloDesc { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? Cad { get; set; }

    public string? DataCad { get; set; }

    public int Tipo { get; set; }

    public string Pezzo { get; set; } = null!;

    public int OrdPm { get; set; }

    public string? Cod { get; set; }

    public string? Descr { get; set; }

    public string? Mat { get; set; }

    public int? NrMat { get; set; }

    public int? Qt { get; set; }

    public int? Coppia { get; set; }

    public double? Coeff { get; set; }

    public double? AreaTot { get; set; }

    public double? Area1 { get; set; }

    public double? Area2 { get; set; }

    public double? Area3 { get; set; }

    public double? Area4 { get; set; }

    public double? Area5 { get; set; }

    public double? Area6 { get; set; }

    public double? Area7 { get; set; }

    public double? Area8 { get; set; }

    public double? Area9 { get; set; }

    public double? Area10 { get; set; }

    public double? Area11 { get; set; }

    public double? Peso1 { get; set; }

    public double? Peso2 { get; set; }

    public double? Peso3 { get; set; }

    public double? Peso4 { get; set; }

    public double? Peso5 { get; set; }

    public double? Peso6 { get; set; }

    public double? Peso7 { get; set; }

    public double? Peso8 { get; set; }

    public double? Peso9 { get; set; }

    public double? Peso10 { get; set; }

    public double? Peso11 { get; set; }

    public double? PeriTot { get; set; }

    public string? Tg1 { get; set; }

    public string? Tg2 { get; set; }

    public string? Tg3 { get; set; }

    public string? Tg4 { get; set; }

    public string? Tg5 { get; set; }

    public string? Tg6 { get; set; }

    public string? Tg7 { get; set; }

    public string? Tg8 { get; set; }

    public string? Tg9 { get; set; }

    public string? Tg10 { get; set; }

    public string? Tg11 { get; set; }

    public int? IdTg1 { get; set; }

    public int? IdTg2 { get; set; }

    public int? IdTg3 { get; set; }

    public int? IdTg4 { get; set; }

    public int? IdTg5 { get; set; }

    public int? IdTg6 { get; set; }

    public int? IdTg7 { get; set; }

    public int? IdTg8 { get; set; }

    public int? IdTg9 { get; set; }

    public int? IdTg10 { get; set; }

    public int? IdTg11 { get; set; }

    public string? Stato { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdContatto { get; set; }

    public byte[]? Immagine { get; set; }

    public string? Modellista { get; set; }
}
