using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ProduzGeneOrd
{
    public int Id { get; set; }

    public string Stato { get; set; } = null!;

    public int IdContatto { get; set; }

    public int? IdOrd { get; set; }

    public int IdStag { get; set; }

    public int IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public string OrdTipo { get; set; } = null!;

    public int OrdNr { get; set; }

    public DateOnly? OrdData { get; set; }

    public int Ccli { get; set; }

    public int? CcliDest { get; set; }

    public int? ProgRiga { get; set; }

    public string Mod { get; set; } = null!;

    public string Tess { get; set; } = null!;

    public string? Variante { get; set; }

    public string? ColOrd { get; set; }

    public string? CodProd { get; set; }

    public double? PzArt { get; set; }

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

    public int? TotCapi { get; set; }

    public int? TotBlk { get; set; }

    public string? CodMag { get; set; }

    public DateOnly? DataCons { get; set; }

    public string? StrVettore { get; set; }

    public string? StrPorto { get; set; }

    public string? StrPagamento { get; set; }

    public string? StrNota { get; set; }

    public string? RifIdContatto { get; set; }

    public int? NrCommessa { get; set; }

    public int? Nr01 { get; set; }

    public int? Nr02 { get; set; }

    public int? Nr03 { get; set; }

    public int? Nr04 { get; set; }

    public int? Nr05 { get; set; }

    public int? Nr06 { get; set; }

    public int? Nr07 { get; set; }

    public int? Nr08 { get; set; }

    public int? Nr09 { get; set; }

    public int? Nr010 { get; set; }

    public int? Nr011 { get; set; }

    public int? TotNr0 { get; set; }

    public short? Nr111 { get; set; }

    public short? Nr121 { get; set; }

    public short? Nr131 { get; set; }

    public short? Nr141 { get; set; }

    public short? Nr151 { get; set; }

    public short? Nr161 { get; set; }

    public short? Nr17 { get; set; }

    public short? Nr18 { get; set; }

    public short? Nr19 { get; set; }

    public short? Nr110 { get; set; }

    public short? Nr1111 { get; set; }

    public short? TotNr1 { get; set; }

    public short? Nr21 { get; set; }

    public short? Nr22 { get; set; }

    public short? Nr23 { get; set; }

    public short? Nr24 { get; set; }

    public short? Nr25 { get; set; }

    public short? Nr26 { get; set; }

    public short? Nr27 { get; set; }

    public short? Nr28 { get; set; }

    public short? Nr29 { get; set; }

    public short? Nr210 { get; set; }

    public short? Nr211 { get; set; }

    public short? TotNr2 { get; set; }

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

    public short? TotNr5 { get; set; }

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

    public short? TotNr6 { get; set; }

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

    public short? TotNr7 { get; set; }

    public int? NrDdt { get; set; }

    public int? IdLab { get; set; }

    public DateOnly? DataPrevMag { get; set; }

    public DateOnly? DataConsDa { get; set; }

    public DateOnly? DataConsA { get; set; }

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

    public string? L { get; set; }

    public string? MagPrel { get; set; }

    public string? CodUbic { get; set; }

    public bool? PosMagPrint { get; set; }

    public bool? Sped { get; set; }

    public bool? Saldo { get; set; }

    public int? IdDdt { get; set; }

    public int? IdComm { get; set; }

    public int? IdBuonoPrelievo { get; set; }

    public long? IdErpDoc { get; set; }

    public int? IdErpRiga { get; set; }

    public string? CdValuta { get; set; }

    public double? Sco1 { get; set; }

    public DateTime? DataIns { get; set; }

    public DateTime? DataUpd { get; set; }

    public int? IdUteIns { get; set; }

    public int? IdUteUpd { get; set; }

    public int? Nr012 { get; set; }

    public int? Nr013 { get; set; }

    public int? Nr014 { get; set; }

    public int? Nr015 { get; set; }

    public int? Nr016 { get; set; }

    public short? Nr112 { get; set; }

    public short? Nr113 { get; set; }

    public short? Nr114 { get; set; }

    public short? Nr115 { get; set; }

    public short? Nr116 { get; set; }

    public short? Nr212 { get; set; }

    public short? Nr213 { get; set; }

    public short? Nr214 { get; set; }

    public short? Nr215 { get; set; }

    public short? Nr216 { get; set; }

    public short? Nr512 { get; set; }

    public short? Nr513 { get; set; }

    public short? Nr514 { get; set; }

    public short? Nr515 { get; set; }

    public short? Nr516 { get; set; }

    public short? Nr612 { get; set; }

    public short? Nr613 { get; set; }

    public short? Nr614 { get; set; }

    public short? Nr615 { get; set; }

    public short? Nr616 { get; set; }

    public short? Nr712 { get; set; }

    public short? Nr713 { get; set; }

    public short? Nr714 { get; set; }

    public short? Nr715 { get; set; }

    public short? Nr716 { get; set; }

    public string? St12 { get; set; }

    public string? St13 { get; set; }

    public string? St14 { get; set; }

    public string? St15 { get; set; }

    public string? St16 { get; set; }

    public int? IdImballo { get; set; }

    public int IdSet { get; set; }

    public int IdSetGroup { get; set; }

    public int? IdStagMod { get; set; }

    public int? IdRigaPadre { get; set; }

    public bool? CkRigaFiglia { get; set; }

    public string? Lotto { get; set; }

    public string? StatoApp { get; set; }

    public int? ProgPadre { get; set; }

    public string? NrDoc { get; set; }

    public int? IdVotoRiga { get; set; }
}
