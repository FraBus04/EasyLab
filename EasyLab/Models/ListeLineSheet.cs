using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListeLineSheet
{
    public int Id { get; set; }

    public int IdLista { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public string? StatoPv { get; set; }

    public int? IdStagMod { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public DateTime DataIns { get; set; }

    public DateTime DataUpd { get; set; }

    public int IdUteIns { get; set; }

    public int IdUteUpd { get; set; }

    public int? Sel { get; set; }

    public int? OrdPm { get; set; }

    public string? L { get; set; }

    public int? ForeCast { get; set; }
}
