using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiImmaginiFiltri
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdClasse { get; set; }

    public string Filtro { get; set; } = null!;

    public byte[]? Immagine { get; set; }

    public int OrdPm { get; set; }
}
