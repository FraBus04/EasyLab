using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TestExpCartCol
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int? IdClasse { get; set; }

    public int? IdCart { get; set; }

    public string Cartella { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public string? DescCol { get; set; }

    public string? CodColForn { get; set; }

    public string? PathImg { get; set; }

    public byte[]? Immagine { get; set; }

    public byte[]? Immagine1 { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
