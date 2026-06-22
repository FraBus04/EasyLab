using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class TabProduz
{
    public int Id { get; set; }

    public string? Cod { get; set; }

    public string Produz { get; set; } = null!;
}
