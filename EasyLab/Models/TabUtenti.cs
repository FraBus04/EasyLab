using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabUtenti
{
    public int Id { get; set; }

    public int IdTipo { get; set; }

    public int IdContatto { get; set; }

    public string Ute { get; set; } = null!;

    public string Psw { get; set; } = null!;

    public string? PathFirma { get; set; }

    public int IdContattoMaster { get; set; }

    public string? Stato { get; set; }

    public int? IdGruppo { get; set; }

    public string? ListidFornitori { get; set; }

    public DateOnly? DataCambioPsw { get; set; }
}
