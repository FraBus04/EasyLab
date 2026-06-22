using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Listino
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdTipoList { get; set; }

    public string TipoList { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int IdModCol { get; set; }

    public int IdSetGroup { get; set; }

    public string ProdMat { get; set; } = null!;

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string ModCol { get; set; } = null!;

    public double List { get; set; }

    public int? QtDa { get; set; }

    public int? QtA { get; set; }

    public DateOnly? ValidDa { get; set; }

    public DateOnly? ValidA { get; set; }

    public int? OrdStag { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataImp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }
}
