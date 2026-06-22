using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBom3Reticolo
{
    public int Id { get; set; }

    public string ATipo { get; set; } = null!;

    public int AIdContatto { get; set; }

    public string? AContatto { get; set; }

    public int AIdStag { get; set; }

    public string? AStag { get; set; }

    public string ACdAll { get; set; } = null!;

    public string? AParte { get; set; }

    public string? AParteDesc { get; set; }

    public int Ver { get; set; }

    public bool? CkVer { get; set; }

    public string? NotaVer { get; set; }

    public int IdFase { get; set; }

    public int Seq { get; set; }

    public string? BTipo { get; set; }

    public string? BCdAll { get; set; }

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public bool CkMatMis { get; set; }

    public bool CkColUnico { get; set; }

    public bool CkContr { get; set; }

    public string Posizione { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string? Tp { get; set; }

    public string Tp2 { get; set; } = null!;

    public string Tp3 { get; set; } = null!;

    public int? IdPack { get; set; }

    public int? IdMatColPack { get; set; }

    public int? IdPos { get; set; }

    public string? CdRegolaCons { get; set; }

    public int? IdRegMis { get; set; }

    public double Cons { get; set; }

    public int? BIdContatto { get; set; }

    public string? BContatto { get; set; }

    public string? BStag { get; set; }

    public string? BParte { get; set; }

    public string? BParteDesc { get; set; }

    public string? BCodArtForn { get; set; }

    public string? BFornPref { get; set; }

    public string? BUm { get; set; }

    public string? BUmutil { get; set; }

    public int? BUmutilConv { get; set; }

    public bool? BCkSemiLav { get; set; }

    public string? BCdAllmis { get; set; }

    public string? BParteMis { get; set; }

    public string? RegMisCod { get; set; }

    public int? IdMat { get; set; }

    public string? Tm { get; set; }

    public string? TmDescr { get; set; }

    public string? AMod { get; set; }

    public string? ATess { get; set; }

    public string? ANome { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public int? IdMod { get; set; }

    public int? IdMatMis { get; set; }

    public int? BIdFornPref { get; set; }

    public string? TpDesc { get; set; }

    public int? TpOrd { get; set; }

    public string? TipoModello { get; set; }

    public int? IdTipoMat { get; set; }

    public string? AStato { get; set; }
}
