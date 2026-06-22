using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SelFabbisogni
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public int IdUte { get; set; }

    public int IdFabb { get; set; }
}
