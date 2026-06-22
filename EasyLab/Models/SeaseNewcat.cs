using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class SeaseNewcat
{
    public string Code { get; set; } = null!;

    public string Siteid { get; set; } = null!;

    public string Tblcode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Dropped { get; set; }

    public string Attrc01 { get; set; } = null!;

    public string Attrc02 { get; set; } = null!;

    public string CodeLink1 { get; set; } = null!;

    public string CodeLink2 { get; set; } = null!;

    public string Category1 { get; set; } = null!;

    public string Category2 { get; set; } = null!;

    public string CodeJoor1 { get; set; } = null!;

    public string CodeJoor1famiglia { get; set; } = null!;

    public string CodeJoor2 { get; set; } = null!;

    public string CodeJoor2sottoFamiglia { get; set; } = null!;

    public string Gruppi { get; set; } = null!;

    public string SottoGruppi { get; set; } = null!;
}
