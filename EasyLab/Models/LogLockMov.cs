using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class LogLockMov
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdUte { get; set; }

    public DateOnly DataLock { get; set; }

    public DateTime DataIns { get; set; }
}
