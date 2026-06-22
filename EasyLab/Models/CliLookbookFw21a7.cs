using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CliLookbookFw21a7
{
    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string ShippingAddress { get; set; } = null!;

    public int ShippingZip { get; set; }

    public string ShippingCity { get; set; } = null!;

    public string ShippingCountry { get; set; } = null!;
}
