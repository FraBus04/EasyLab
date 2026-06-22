using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class StockTw1
{
    public string? Tipo { get; set; }

    public string? Magazzino { get; set; }

    public string? Stagione { get; set; }

    public string? Linea { get; set; }

    public string? Modello { get; set; }

    public string? Descrizionemodello { get; set; }

    public string? Codcolore { get; set; }

    public string? Taglia { get; set; }

    public long? Barcode { get; set; }

    public string? Categoria { get; set; }

    public byte? Quantit { get; set; }

    public int? IdMod { get; set; }

    public int? IdSet { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdEan { get; set; }

    public int? OrdTg { get; set; }

    public int? Impegnati { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public int? QtTse { get; set; }

    public int? QtTseT5 { get; set; }

    public int? QtTseT6 { get; set; }

    public int? QtTseT3 { get; set; }

    public int? Diff { get; set; }

    public string? ModTse { get; set; }

    public string? TessTse { get; set; }

    public string? CodColTse { get; set; }

    public string? TgTse { get; set; }

    public DateTime? DataIns { get; set; }

    public DateOnly? DataRif { get; set; }
}
