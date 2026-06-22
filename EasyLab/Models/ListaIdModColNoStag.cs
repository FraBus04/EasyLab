using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ListaIdModColNoStag
{
    public int Id { get; set; }

    public int IdTesta { get; set; }

    public int IdModColNoStag { get; set; }

    public DateTime DataIns { get; set; }

    public int IdUte { get; set; }
}
