using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiModelliEan
{
    public int Id { get; set; }

    public string Ean { get; set; } = null!;

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int IdSet { get; set; }

    public int IdSetTaglia { get; set; }

    public int IdSetGroup { get; set; }

    public int IdSetOrd { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? ModCol { get; set; }

    public string Tg { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string? Nota { get; set; }

    public string? Nota1 { get; set; }

    public int? CkExp { get; set; }

    public DateTime? DataExp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public DateTime? DataImp { get; set; }

    public string Lotto { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string? CdAll { get; set; }

    public string? CdAllcol { get; set; }

    public string? CdAllmis { get; set; }

    public string? Cd { get; set; }
}
