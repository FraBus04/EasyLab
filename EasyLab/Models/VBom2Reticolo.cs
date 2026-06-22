using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VBom2Reticolo
{
    public int Id { get; set; }

    public int IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string Tipo { get; set; } = null!;

    public int IdFase { get; set; }

    public string? FaseCod { get; set; }

    public string? FaseDesc { get; set; }

    public int IdStag { get; set; }

    public string? Stag { get; set; }

    public int IdMod { get; set; }

    public string? StatoMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public int IdMat { get; set; }

    public string Mat { get; set; } = null!;

    public string DescMat { get; set; } = null!;

    public string CodArtForn { get; set; } = null!;

    public int? IdFornitore { get; set; }

    public int Seq { get; set; }

    public string Um { get; set; } = null!;

    public bool CkMp { get; set; }

    public bool CkMrp { get; set; }

    public bool CkFabb { get; set; }

    public bool CkMatMis { get; set; }

    public bool CkColUnico { get; set; }

    public bool CkContr { get; set; }

    public string Posizione { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Tp { get; set; } = null!;

    public string? TpDesc { get; set; }

    public int? TpOrd { get; set; }

    public string Tp2 { get; set; } = null!;

    public string Tp3 { get; set; } = null!;

    public string Tg1 { get; set; } = null!;

    public string Tg2 { get; set; } = null!;

    public string Tg3 { get; set; } = null!;

    public string Tg4 { get; set; } = null!;

    public string Tg5 { get; set; } = null!;

    public string Tg6 { get; set; } = null!;

    public string Tg7 { get; set; } = null!;

    public string Tg8 { get; set; } = null!;

    public string Tg9 { get; set; } = null!;

    public string Tg10 { get; set; } = null!;

    public string Tg11 { get; set; } = null!;

    public string Tg12 { get; set; } = null!;

    public string Tg13 { get; set; } = null!;

    public string Tg14 { get; set; } = null!;

    public string Tg15 { get; set; } = null!;

    public string Tg16 { get; set; } = null!;

    public double Cons { get; set; }

    public double Cons1 { get; set; }

    public double Cons2 { get; set; }

    public double Cons3 { get; set; }

    public double Cons4 { get; set; }

    public double Cons5 { get; set; }

    public double Cons6 { get; set; }

    public double Cons7 { get; set; }

    public double Cons8 { get; set; }

    public double Cons9 { get; set; }

    public double Cons10 { get; set; }

    public double Cons11 { get; set; }

    public double Cons12 { get; set; }

    public double Cons13 { get; set; }

    public double Cons14 { get; set; }

    public double Cons15 { get; set; }

    public double Cons16 { get; set; }

    public int IdMatMis { get; set; }

    public int IdMatMis1 { get; set; }

    public int IdMatMis2 { get; set; }

    public int IdMatMis3 { get; set; }

    public int IdMatMis4 { get; set; }

    public int IdMatMis5 { get; set; }

    public int IdMatMis6 { get; set; }

    public int IdMatMis7 { get; set; }

    public int IdMatMis8 { get; set; }

    public int IdMatMis9 { get; set; }

    public int IdMatMis10 { get; set; }

    public int IdMatMis11 { get; set; }

    public int IdMatMis12 { get; set; }

    public int IdMatMis13 { get; set; }

    public int IdMatMis14 { get; set; }

    public int IdMatMis15 { get; set; }

    public int IdMatMis16 { get; set; }

    public string? OrdImp { get; set; }

    public int? IdOld { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public DateTime? DataImp { get; set; }

    public string? StatoExp { get; set; }

    public DateTime? DataExp { get; set; }

    public short? Hutile { get; set; }

    public int? IdContattoMat { get; set; }

    public string ContattoMat { get; set; } = null!;

    public string? MatMis { get; set; }

    public string? MatMis1 { get; set; }

    public string? MatMis2 { get; set; }

    public string? MatMis3 { get; set; }

    public string? MatMis4 { get; set; }

    public string? MatMis5 { get; set; }

    public string? MatMis6 { get; set; }

    public string? MatMis7 { get; set; }

    public string? MatMis8 { get; set; }

    public string? MatMis9 { get; set; }

    public string? MatMis10 { get; set; }

    public string? MatMis11 { get; set; }

    public string? MatMis12 { get; set; }

    public string? MatMis13 { get; set; }

    public string? MatMis14 { get; set; }

    public string? MatMis15 { get; set; }

    public string? MatMis16 { get; set; }

    public int? IdSet { get; set; }

    public string? CdTipoMat { get; set; }

    public string? FornMat { get; set; }

    public string? FornPref { get; set; }

    public string? Laboratorio { get; set; }

    public int? IdPos { get; set; }

    public string? CompPos { get; set; }

    public string? CdRegolaCons { get; set; }

    public string? TipoModello { get; set; }

    public int? IdRegMis { get; set; }

    public string? RegMisCod { get; set; }

    public short? IdTagliaDa { get; set; }

    public short? IdTagliaA { get; set; }

    public int? IdTipoMat { get; set; }

    public int Ver { get; set; }

    public string? NotaVer { get; set; }

    public DateTime? DataVer { get; set; }

    public int? IdUteVer { get; set; }

    public string? Umutil { get; set; }

    public int? UmutilConv { get; set; }

    public string? StatoAppDiBa { get; set; }
}
