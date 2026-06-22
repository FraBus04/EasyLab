using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneOrdLogDataPrevMag
{
    public int Id { get; set; }

    public int IdUte { get; set; }

    public int IdRiga { get; set; }

    public DateOnly? DataOld { get; set; }

    public DateOnly? DataNew { get; set; }

    public bool? CkDataConf { get; set; }

    public DateTime DataIns { get; set; }
}
