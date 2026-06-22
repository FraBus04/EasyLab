using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VTabellaMisure
{
    public int Id { get; set; }

    public int IdTabMisure { get; set; }

    public int IdPresaMisure { get; set; }

    public string? PresaMisure { get; set; }

    public string Nota { get; set; } = null!;

    public double MisTgBase { get; set; }

    public bool CkIncAut { get; set; }

    public double? IncLeft { get; set; }

    public double? IncRight { get; set; }

    public double? Mis1 { get; set; }

    public double? Mis2 { get; set; }

    public double? Mis3 { get; set; }

    public double? Mis4 { get; set; }

    public double? Mis5 { get; set; }

    public double? Mis6 { get; set; }

    public double? Mis7 { get; set; }

    public double? Mis8 { get; set; }

    public double? Mis9 { get; set; }

    public double? Mis10 { get; set; }

    public double? Mis11 { get; set; }

    public double? Mis12 { get; set; }

    public double? Mis13 { get; set; }

    public double? Mis14 { get; set; }

    public double? Mis15 { get; set; }

    public double? Mis16 { get; set; }

    public double? RisTgBase { get; set; }

    public double? Ris1 { get; set; }

    public double? Ris2 { get; set; }

    public double? Ris3 { get; set; }

    public double? Ris4 { get; set; }

    public double? Ris5 { get; set; }

    public double? Ris6 { get; set; }

    public double? Ris7 { get; set; }

    public double? Ris8 { get; set; }

    public double? Ris9 { get; set; }

    public double? Ris10 { get; set; }

    public double? Ris11 { get; set; }

    public double? Ris12 { get; set; }

    public double? Ris13 { get; set; }

    public double? Ris14 { get; set; }

    public double? Ris15 { get; set; }

    public double? Ris16 { get; set; }

    public int OrdPm { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int? IdTabellaMisureTipo { get; set; }

    public string? TabellaMisureTipo { get; set; }

    public bool? CkTemplate { get; set; }

    public string? Cod { get; set; }

    public string? NotaTesta { get; set; }

    public int? IdSet { get; set; }

    public string? SetCod { get; set; }

    public string? DetDesc { get; set; }

    public int? IdTgBase { get; set; }

    public string? TgBase { get; set; }

    public int? IdMod { get; set; }

    public int? IdStag { get; set; }

    public string? TipoModello { get; set; }

    public string? Stag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public int? IdComm { get; set; }

    public int? CommNr { get; set; }

    public int? TotCapi { get; set; }

    public string? CommStato { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? Tg1 { get; set; }

    public string? Tg2 { get; set; }

    public string? Tg3 { get; set; }

    public string? Tg4 { get; set; }

    public string? Tg5 { get; set; }

    public string? Tg6 { get; set; }

    public string? Tg7 { get; set; }

    public string? Tg8 { get; set; }

    public string? Tg9 { get; set; }

    public string? Tg10 { get; set; }

    public string? Tg11 { get; set; }

    public string? Tg12 { get; set; }

    public string? Tg13 { get; set; }

    public string? Tg14 { get; set; }

    public string? Tg15 { get; set; }

    public string? Tg16 { get; set; }

    public string? TgCli1 { get; set; }

    public string? TgCli2 { get; set; }

    public string? TgCli3 { get; set; }

    public string? TgCli4 { get; set; }

    public string? TgCli5 { get; set; }

    public string? TgCli6 { get; set; }

    public string? TgCli7 { get; set; }

    public string? TgCli8 { get; set; }

    public string? TgCli9 { get; set; }

    public string? TgCli10 { get; set; }

    public string? TgCli11 { get; set; }

    public string? TgCli12 { get; set; }

    public string? TgCli13 { get; set; }

    public string? TgCli14 { get; set; }

    public string? TgCli15 { get; set; }

    public string? TgCli16 { get; set; }

    public string? PathImgMod { get; set; }

    public string? GenderCod { get; set; }

    public string? GenderDescr { get; set; }

    public string? Modellista { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? Cad { get; set; }

    public string? Stato { get; set; }

    public string? StatoDescr { get; set; }

    public double? Sc1 { get; set; }

    public double? Sc2 { get; set; }

    public double? Sc3 { get; set; }

    public double? Sc4 { get; set; }

    public double? Sc5 { get; set; }

    public double? Sc6 { get; set; }

    public double? Sc7 { get; set; }

    public double? Sc8 { get; set; }

    public double? Sc9 { get; set; }

    public double? Sc10 { get; set; }

    public double? Sc11 { get; set; }

    public double? Sc12 { get; set; }

    public double? Sc13 { get; set; }

    public double? Sc14 { get; set; }

    public double? Sc15 { get; set; }

    public string? StatoTesta { get; set; }

    public double? CkTg1 { get; set; }

    public double? CkTg2 { get; set; }

    public double? CkTg3 { get; set; }

    public double? CkTg4 { get; set; }

    public double? CkTg5 { get; set; }

    public double? CkTg6 { get; set; }

    public double? CkTg7 { get; set; }

    public double? CkTg8 { get; set; }

    public double? CkTg9 { get; set; }

    public double? CkTg10 { get; set; }

    public double? CkTg11 { get; set; }

    public double? CkTg12 { get; set; }

    public double? CkTg13 { get; set; }

    public double? CkTg14 { get; set; }

    public double? CkTg15 { get; set; }

    public double? CkTg16 { get; set; }

    public bool? CkTgCli { get; set; }

    public bool? CkEffettiva { get; set; }

    public string? PathImgPresa { get; set; }

    public string? Lab { get; set; }

    public decimal? Toll { get; set; }
}
