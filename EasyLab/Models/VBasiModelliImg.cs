using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBasiModelliImg
{
    public int Id { get; set; }

    public int IdMod { get; set; }

    public string PathImg { get; set; } = null!;

    public string? NomeImg { get; set; }

    public int OrdPm { get; set; }

    public DateTime? DataIns { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdTipo { get; set; }

    public string? TipoImg { get; set; }

    public int? IdComm { get; set; }

    public string? TipoModello { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int? IdFitting { get; set; }

    public int? IdSk { get; set; }

    public string? Nota { get; set; }
}
