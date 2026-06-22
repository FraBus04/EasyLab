using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiMaterialiColori
{
    public int Id { get; set; }

    public string? Cd { get; set; }

    public int IdMat { get; set; }

    public int IdContatto { get; set; }

    public string Mat { get; set; } = null!;

    public string CodCol { get; set; } = null!;

    public string DescCol { get; set; } = null!;

    public string? CodColForn { get; set; }

    public string? PathImg { get; set; }

    public string? Nota { get; set; }

    public bool Enabled { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? Cartella { get; set; }

    public DateTime? DataImp { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? Nota2 { get; set; }

    public string? Nota3 { get; set; }

    public int? IdCart { get; set; }

    public string Stato { get; set; } = null!;

    public string? CdAll { get; set; }
}
