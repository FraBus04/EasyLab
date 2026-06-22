using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiNote
{
    public int Id { get; set; }

    public int IdClasse { get; set; }

    public int IdTipoNota { get; set; }

    public int IdLang { get; set; }

    public int IdRif { get; set; }

    public string Nota { get; set; } = null!;

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }
}
