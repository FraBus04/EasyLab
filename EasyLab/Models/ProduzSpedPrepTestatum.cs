using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzSpedPrepTestatum
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdStag { get; set; }

    public int IdContatto { get; set; }

    public int IdCcli { get; set; }

    public int IdOrdNr { get; set; }

    public DateTime? DataIni { get; set; }
}
