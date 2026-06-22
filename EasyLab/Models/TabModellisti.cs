using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabModellisti
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int IdContatto { get; set; }

    public string? Cod { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public byte[]? Immagine { get; set; }
}
