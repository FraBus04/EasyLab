using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TwsLodImportDoc
{
    public int Id { get; set; }

    public int? NumeroOrdine { get; set; }

    public string? CodiceDocumento { get; set; }

    public string? NumeroDocOrigine { get; set; }

    public DateTime? DataIns { get; set; }

    public long? KeyDdtTs { get; set; }
}
