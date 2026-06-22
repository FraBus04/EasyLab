using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ReportsCompany
{
    public int Id { get; set; }

    public string ReportName { get; set; } = null!;

    public string ReportNameCompany { get; set; } = null!;
}
