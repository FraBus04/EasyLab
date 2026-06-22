using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class BasimodelliBk20211021
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int IdStag { get; set; }

    public string Mdl { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Cad { get; set; }

    public int? IdSetTaglia { get; set; }

    public int? IdTagliaBase { get; set; }

    public string? Nota { get; set; }

    public string? PathImg { get; set; }

    public string? BaseProv { get; set; }

    public bool? CkModello { get; set; }

    public string? NotaCostruz { get; set; }

    public int? IdCatMerc { get; set; }

    public int? IdModellista { get; set; }

    public short? IdTagliaDa { get; set; }

    public short? IdTagliaA { get; set; }

    public double? Listino { get; set; }

    public short? IdLinea { get; set; }

    public int? IdStatoMod { get; set; }

    public int? IdTrattamento { get; set; }

    public string TipoModello { get; set; } = null!;

    public int? IdTabAnagCliFor { get; set; }

    public short? IdFilCucit { get; set; }

    public short? IdFilImp { get; set; }

    public short? IdTipoPunto { get; set; }

    public short? CkStampa { get; set; }

    public short? IdComp { get; set; }

    public short? IdTema { get; set; }

    public short? IdTaric { get; set; }

    public short? IdNazione { get; set; }

    public int? IdLabPrev { get; set; }

    public short? Peso { get; set; }

    public string? Umpeso { get; set; }

    public string? CdOp { get; set; }

    public short? IdGender { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? IdScheda { get; set; }

    public int? IdStiro { get; set; }

    public int? IdImballo { get; set; }

    public int? IdKw { get; set; }

    public int? IdComp2 { get; set; }

    public int? IdComp3 { get; set; }

    public int? IdComp4 { get; set; }

    public int? IdComp5 { get; set; }

    public int? IdPos1 { get; set; }

    public int? IdPos2 { get; set; }

    public int? IdPos3 { get; set; }

    public int? IdPos4 { get; set; }

    public int? IdPos5 { get; set; }

    public string? Mid { get; set; }

    public string? DescCommerc { get; set; }

    public int? IdCatMercMacro { get; set; }

    public int? LeadTimeGg { get; set; }

    public DateOnly? DataPianifProd { get; set; }

    public int? Idlav1 { get; set; }

    public int? Idlav2 { get; set; }

    public int? Idlav3 { get; set; }

    public int? Idlav4 { get; set; }

    public int? Idlav5 { get; set; }

    public int? Idlav6 { get; set; }

    public bool CkSemilav { get; set; }

    public int? IdMat { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdCatMercMacro2 { get; set; }

    public int? IdCatMerc2 { get; set; }
}
