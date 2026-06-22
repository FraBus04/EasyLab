using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VSchedaTecnica
{
    public int? IdTesta { get; set; }

    public string? Stato { get; set; }

    public string? StatoDesc { get; set; }

    public int? IdContatto { get; set; }

    public string? Contatto { get; set; }

    public string? PathLogo { get; set; }

    public int? IdSchedaTecnicaTipo { get; set; }

    public string? SchedaTecnicaTipo { get; set; }

    public string? Cod { get; set; }

    public int? IdMod { get; set; }

    public int? IdStag { get; set; }

    public string? Stag { get; set; }

    public string? TipoModello { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? Nome { get; set; }

    public string? GenderCod { get; set; }

    public string? GenderDesc { get; set; }

    public string? Linea { get; set; }

    public string? LineaDesc { get; set; }

    public int? IdCatMerc { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public int? IdModellista { get; set; }

    public string? Modellista { get; set; }

    public string? Composizione { get; set; }

    public string? Lav1 { get; set; }

    public string? Lav2 { get; set; }

    public string? Lav3 { get; set; }

    public string? Lav4 { get; set; }

    public string? Lav5 { get; set; }

    public string? Lav6 { get; set; }

    public string? PathImg { get; set; }

    public string? RichText { get; set; }

    public bool? CkEffettiva { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? StatoModCod { get; set; }

    public string? StatoMod { get; set; }

    public string? StatoModBreve { get; set; }

    public string? BaseProv { get; set; }

    public string? FilatoCucit { get; set; }

    public string? FilatoImp { get; set; }

    public string? TipoPunto { get; set; }

    public string? HsCode { get; set; }

    public string? Op { get; set; }

    public string? Stiro { get; set; }

    public string? Imballo { get; set; }

    public string? TagliaDa { get; set; }

    public string? TagliaA { get; set; }

    public string? TagliaBase { get; set; }

    public string? Trattamento { get; set; }

    public int IdGruppo { get; set; }

    public string? Gruppo { get; set; }

    public int IdDett { get; set; }

    public string? Dett1 { get; set; }

    public string? Dett2 { get; set; }

    public string Descr { get; set; } = null!;

    public int OrdPm { get; set; }

    public string? PathImgSchedaTecnica { get; set; }

    public bool? CkEasy { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public string? Composizione2 { get; set; }

    public string? Composizione3 { get; set; }

    public string? Composizione4 { get; set; }

    public string? Composizione5 { get; set; }

    public string? Pos1 { get; set; }

    public string? Pos2 { get; set; }

    public string? Pos3 { get; set; }

    public string? Pos4 { get; set; }

    public string? Pos5 { get; set; }

    public string? Cad { get; set; }

    public string? Nota { get; set; }

    public string? MadeIn { get; set; }
}
