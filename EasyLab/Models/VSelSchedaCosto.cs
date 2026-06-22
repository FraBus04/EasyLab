using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSelSchedaCosto
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdUte { get; set; }

    public int IdTestaSk { get; set; }

    public int? IdTipoSk { get; set; }

    public string? TipoSk { get; set; }

    public string? TipoSkdesc { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? StagDesc { get; set; }

    public string? Stato { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }
}
