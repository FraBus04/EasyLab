using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class CliLookbookFw21a3
{
    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string ShippingAddress { get; set; } = null!;

    public short ShippingZip { get; set; }

    public string ShippingCity { get; set; } = null!;

    public string ShippingCountry { get; set; } = null!;
}
