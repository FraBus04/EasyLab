using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class Stagioni
{
    public int Id { get; set; }

    public string? Cod { get; set; }

    public string? Descrizione { get; set; }

    public int? OrdenId { get; set; }

    public string? CodImp { get; set; }

    public int? Anno { get; set; }

    public string? TipoStag { get; set; }

    public string? AnnoDesc { get; set; }
}
