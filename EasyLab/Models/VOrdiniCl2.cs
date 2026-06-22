using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class VOrdiniCl2
{
    public int IdRiga { get; set; }

    public int? IdContatto { get; set; }

    public int? IdOrd { get; set; }

    public string? Contatto { get; set; }

    public string? StatoOrd { get; set; }

    public string? StatoMod { get; set; }

    public string StatoRigaOrd { get; set; } = null!;

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public string? OrdTipo { get; set; }

    public int OrdNr { get; set; }

    public DateOnly? OrdData { get; set; }

    public int Ccli { get; set; }

    public string? Anag1 { get; set; }

    public string? Anag2 { get; set; }

    public string? Via { get; set; }

    public string? Citta { get; set; }

    public string? CapDestNew { get; set; }

    public string? Anag1Dest { get; set; }

    public string? Anag2Dest { get; set; }

    public string? ViaDest { get; set; }

    public string? CapDest { get; set; }

    public string? CittaDest { get; set; }

    public string? ProvDest { get; set; }

    public string? ColOrd { get; set; }

    public string? DescCol { get; set; }

    public int? TotCapi { get; set; }

    public string? CdValuta { get; set; }

    public double? PzArt { get; set; }

    public string? CodMag { get; set; }

    public DateOnly? DataCons { get; set; }

    public string? Nazione { get; set; }

    public int? IdSetTaglia { get; set; }

    public string? StrNota { get; set; }

    public int? NrCommessa { get; set; }

    public short? Nr1TotCapi { get; set; }

    public short? Nr5TotCapi { get; set; }

    public short? Nr6TotCapi { get; set; }

    public short? Nr7TotCapi { get; set; }

    public int? NrDdt { get; set; }

    public string? Nome { get; set; }

    public string? NotaTesta { get; set; }

    public string? DataPrevCons { get; set; }

    public double? Sco1 { get; set; }

    public string? Stag { get; set; }

    public int? IdLab { get; set; }

    public string? Lab { get; set; }

    public DateOnly? DataPrevMag { get; set; }

    public string? St1 { get; set; }

    public string? St2 { get; set; }

    public string? St3 { get; set; }

    public string? St4 { get; set; }

    public string? St5 { get; set; }

    public string? St6 { get; set; }

    public string? St7 { get; set; }

    public string? St8 { get; set; }

    public string? St9 { get; set; }

    public string? St10 { get; set; }

    public string? St11 { get; set; }

    public string? St12 { get; set; }

    public string? St13 { get; set; }

    public string? St14 { get; set; }

    public string? St15 { get; set; }

    public string? St16 { get; set; }

    public string? L { get; set; }

    public DateTime? DataConsDa { get; set; }

    public DateTime? DataConsA { get; set; }

    public string? Po { get; set; }

    public string? CatMercMacroCod { get; set; }

    public string? CatMercMacroDesc { get; set; }

    public string? CatMercMacroEng { get; set; }

    public string? CatMercCod { get; set; }

    public string? CatMercDesc { get; set; }

    public string? CatMercEng { get; set; }

    public string? LineaCod { get; set; }

    public string? LineaDesc { get; set; }

    public short? Peso { get; set; }

    public string? CodUbic { get; set; }

    public bool? Sped { get; set; }

    public bool? Saldo { get; set; }

    public bool? PosMagPrint { get; set; }

    public DateTime? NrCommData { get; set; }

    public int? IdComm { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModColNoStag { get; set; }

    public string? NazioneDest { get; set; }

    public string? MagPrel { get; set; }

    public int? IdErpRiga { get; set; }

    public long? IdErpDoc { get; set; }

    public int? CcliDest { get; set; }

    public int IdSet { get; set; }

    public int IdSetGroup { get; set; }

    public int? IdStagMod { get; set; }

    public bool? CkRigaFiglia { get; set; }

    public string? Trattamento { get; set; }

    public string? FornPref { get; set; }

    public string? Lotto { get; set; }

    public string? Gender { get; set; }

    public string? VotoCli { get; set; }

    public string? StatoApp { get; set; }

    public int? IdTrattamento { get; set; }

    public double? Sco1Riga { get; set; }

    public string? DescCommerc { get; set; }

    public string? NrDoc { get; set; }

    public int? Nr1 { get; set; }

    public int? Nr2 { get; set; }

    public int? Nr3 { get; set; }

    public int? Nr4 { get; set; }

    public int? Nr5 { get; set; }

    public int? Nr6 { get; set; }

    public int? Nr7 { get; set; }

    public int? Nr8 { get; set; }

    public int? Nr9 { get; set; }

    public int? Nr10 { get; set; }

    public int? Nr11 { get; set; }

    public int? Nr12 { get; set; }

    public int? Nr13 { get; set; }

    public int? Nr14 { get; set; }

    public int? Nr15 { get; set; }

    public int? Nr16 { get; set; }

    public short? Nr51 { get; set; }

    public short? Nr52 { get; set; }

    public short? Nr53 { get; set; }

    public short? Nr54 { get; set; }

    public short? Nr55 { get; set; }

    public short? Nr56 { get; set; }

    public short? Nr57 { get; set; }

    public short? Nr58 { get; set; }

    public short? Nr59 { get; set; }

    public short? Nr510 { get; set; }

    public short? Nr511 { get; set; }

    public short? Nr512 { get; set; }

    public short? Nr513 { get; set; }

    public short? Nr514 { get; set; }

    public short? Nr515 { get; set; }

    public short? Nr516 { get; set; }

    public short? Nr61 { get; set; }

    public short? Nr62 { get; set; }

    public short? Nr63 { get; set; }

    public short? Nr64 { get; set; }

    public short? Nr65 { get; set; }

    public short? Nr66 { get; set; }

    public short? Nr67 { get; set; }

    public short? Nr68 { get; set; }

    public short? Nr69 { get; set; }

    public short? Nr610 { get; set; }

    public short? Nr611 { get; set; }

    public short? Nr612 { get; set; }

    public short? Nr613 { get; set; }

    public short? Nr614 { get; set; }

    public short? Nr615 { get; set; }

    public short? Nr616 { get; set; }

    public short? Nr71 { get; set; }

    public short? Nr72 { get; set; }

    public short? Nr73 { get; set; }

    public short? Nr74 { get; set; }

    public short? Nr75 { get; set; }

    public short? Nr76 { get; set; }

    public short? Nr77 { get; set; }

    public short? Nr78 { get; set; }

    public short? Nr79 { get; set; }

    public short? Nr710 { get; set; }

    public short? Nr711 { get; set; }

    public short? Nr712 { get; set; }

    public short? Nr713 { get; set; }

    public short? Nr714 { get; set; }

    public short? Nr715 { get; set; }

    public short? Nr716 { get; set; }

    public string? Composizione { get; set; }

    public int? IdVotoRiga { get; set; }

    public int? IdVotoCli { get; set; }
}
