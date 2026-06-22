using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasiNoteNoStag
{
    public int Id { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public int IdTipoNota { get; set; }

    public int IdLang { get; set; }

    public string Nota { get; set; } = null!;

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public int? IdContatto { get; set; }
}
