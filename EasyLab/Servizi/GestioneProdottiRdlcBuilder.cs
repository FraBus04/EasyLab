using System.Data;
using EasyLab.Models;

namespace EasyLab.Servizi
{
    // Costruisce la DataTable "DataSet1" attesa da Report_Modellario_Prodotto1.rdlc (report per
    // prodotti, non materiali). I nomi/tipi di colonna devono corrispondere esattamente ai
    // <Field><DataField> definiti nel report. Fonte dati: VElencoProdotti2 (la view che il file
    // .rdlc originale referenziava come "V_ElencoProdotti2"), con due lookup aggiuntive che quella
    // view non risolve gia': il logo del brand (Contatti.PathLogo) e la descrizione dello stato
    // modello (TabStatoModello.StatoMod/Cod, risolti da IdStatoMod).
    public static class GestioneProdottiRdlcBuilder
    {
        public static DataTable Build(
            IEnumerable<VElencoProdotti2> righe,
            IReadOnlyDictionary<int, string?> loghiPerContatto,
            IReadOnlyDictionary<int, (string? StatoMod, string? Cod)> statiModello)
        {
            var table = new DataTable("DataSet1");

            table.Columns.Add("id", typeof(int));
            table.Columns.Add("idContatto", typeof(int));
            table.Columns.Add("Contatto", typeof(string));
            table.Columns.Add("idSTAG", typeof(int));
            table.Columns.Add("Stag", typeof(string));
            table.Columns.Add("DescStag1", typeof(string));
            table.Columns.Add("Mod", typeof(string));
            table.Columns.Add("Tess", typeof(string));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Linea", typeof(string));
            table.Columns.Add("LineaDesc", typeof(string));
            table.Columns.Add("CAD", typeof(string));
            table.Columns.Add("idSetTaglia", typeof(int));
            table.Columns.Add("idTagliaBase", typeof(int));
            table.Columns.Add("Nota", typeof(string));
            table.Columns.Add("PathImg", typeof(string));
            table.Columns.Add("BaseProv", typeof(string));
            table.Columns.Add("ck_modello", typeof(bool));
            table.Columns.Add("NotaCostruz", typeof(string));
            table.Columns.Add("Stato", typeof(string));
            table.Columns.Add("Modellista", typeof(string));
            table.Columns.Add("CatMerc", typeof(string));
            table.Columns.Add("Tg", typeof(string));
            table.Columns.Add("codSetTg", typeof(string));
            table.Columns.Add("idTagliaDa", typeof(short));
            table.Columns.Add("idTagliaA", typeof(short));
            table.Columns.Add("DescSetTg", typeof(string));
            table.Columns.Add("Trattamento", typeof(string));
            table.Columns.Add("StatoMod", typeof(string));
            table.Columns.Add("TipoModello", typeof(string));
            table.Columns.Add("TipoPunto", typeof(string));
            table.Columns.Add("TipoFilatoCucit", typeof(string));
            table.Columns.Add("TipoFilatoImp", typeof(string));
            table.Columns.Add("Listino", typeof(double));
            table.Columns.Add("TotVend", typeof(int));
            table.Columns.Add("Tg1", typeof(string));
            table.Columns.Add("Tg2", typeof(string));
            table.Columns.Add("Tg3", typeof(string));
            table.Columns.Add("Tg4", typeof(string));
            table.Columns.Add("Tg5", typeof(string));
            table.Columns.Add("Tg6", typeof(string));
            table.Columns.Add("Tg7", typeof(string));
            table.Columns.Add("Tg8", typeof(string));
            table.Columns.Add("Tg9", typeof(string));
            table.Columns.Add("Tg10", typeof(string));
            table.Columns.Add("Tg11", typeof(string));
            table.Columns.Add("MagSede", typeof(int));
            table.Columns.Add("Assegnati", typeof(int));
            table.Columns.Add("TotTag", typeof(int));
            table.Columns.Add("TotSped", typeof(int));
            table.Columns.Add("TotAnn", typeof(int));
            table.Columns.Add("idComp", typeof(short));
            table.Columns.Add("Composizione", typeof(string));
            table.Columns.Add("List1", typeof(double));
            table.Columns.Add("StatoModCod", typeof(string));
            table.Columns.Add("CatMercMacroCod", typeof(string));
            table.Columns.Add("CatMercMacroDesc", typeof(string));
            table.Columns.Add("DescCommerc", typeof(string));
            table.Columns.Add("PathLogo", typeof(string));
            table.Columns.Add("Lav1", typeof(string));
            table.Columns.Add("Lav2", typeof(string));
            table.Columns.Add("Lav3", typeof(string));
            table.Columns.Add("Lav4", typeof(string));
            table.Columns.Add("Lav5", typeof(string));
            table.Columns.Add("Lav6", typeof(string));
            table.Columns.Add("Peso", typeof(short));
            table.Columns.Add("KW", typeof(string));
            table.Columns.Add("OP", typeof(string));
            table.Columns.Add("MadeIn", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("HsCode", typeof(string));
            table.Columns.Add("ckSemilav", typeof(bool));
            table.Columns.Add("idCatMercMacro2", typeof(int));
            table.Columns.Add("CatMercMacroDesc2", typeof(string));
            table.Columns.Add("idCatMerc2", typeof(int));
            table.Columns.Add("CatMerc2", typeof(string));
            table.Columns.Add("Vest", typeof(string));
            table.Columns.Add("Stagionalita", typeof(string));

            foreach (var r in righe.OrderBy(r => r.Mod))
            {
                var row = table.NewRow();

                row["id"] = r.Id;
                row["idContatto"] = r.IdContatto;
                row["Contatto"] = (object?)r.Contatto ?? DBNull.Value;
                row["idSTAG"] = r.IdStag;
                row["Stag"] = (object?)r.Stag ?? DBNull.Value;
                row["DescStag1"] = DBNull.Value;
                row["Mod"] = (object?)r.Mod ?? DBNull.Value;
                row["Tess"] = (object?)r.Tess ?? DBNull.Value;
                row["Nome"] = (object?)r.Nome ?? DBNull.Value;
                row["Linea"] = (object?)r.Linea ?? DBNull.Value;
                row["LineaDesc"] = (object?)r.LineaDesc ?? DBNull.Value;
                row["CAD"] = (object?)r.Cad ?? DBNull.Value;
                row["idSetTaglia"] = (object?)r.IdSetTaglia ?? DBNull.Value;
                row["idTagliaBase"] = (object?)r.IdTagliaBase ?? DBNull.Value;
                row["Nota"] = (object?)r.Nota ?? DBNull.Value;
                row["PathImg"] = (object?)r.PathImg ?? DBNull.Value;
                row["BaseProv"] = (object?)r.BaseProv ?? DBNull.Value;
                row["ck_modello"] = (object?)r.CkModello ?? DBNull.Value;
                row["NotaCostruz"] = (object?)r.NotaCostruz ?? DBNull.Value;
                row["Stato"] = (object?)r.Stato ?? DBNull.Value;
                row["Modellista"] = (object?)r.Modellista ?? DBNull.Value;
                row["CatMerc"] = (object?)r.CatMerc ?? DBNull.Value;
                row["Tg"] = (object?)r.Tg ?? DBNull.Value;
                row["codSetTg"] = (object?)r.CodSetTg ?? DBNull.Value;
                row["idTagliaDa"] = (object?)r.IdTagliaDa ?? DBNull.Value;
                row["idTagliaA"] = (object?)r.IdTagliaA ?? DBNull.Value;
                row["DescSetTg"] = (object?)r.DescSetTg ?? DBNull.Value;
                row["Trattamento"] = (object?)r.Trattamento ?? DBNull.Value;

                var statoMod = r.IdStatoMod.HasValue && statiModello.TryGetValue(r.IdStatoMod.Value, out var sm) ? sm : (null, null);
                row["StatoMod"] = (object?)statoMod.Item1 ?? DBNull.Value;
                row["StatoModCod"] = (object?)statoMod.Item2 ?? DBNull.Value;

                row["TipoModello"] = (object?)r.TipoModello ?? DBNull.Value;
                row["TipoPunto"] = (object?)r.TipoPunto ?? DBNull.Value;
                row["TipoFilatoCucit"] = (object?)r.TipoFilatoCucit ?? DBNull.Value;
                row["TipoFilatoImp"] = (object?)r.TipoFilatoImp ?? DBNull.Value;
                row["Listino"] = (object?)r.Listino ?? DBNull.Value;
                row["TotVend"] = r.TotVend;
                row["Tg1"] = (object?)r.Tg1 ?? DBNull.Value;
                row["Tg2"] = (object?)r.Tg2 ?? DBNull.Value;
                row["Tg3"] = (object?)r.Tg3 ?? DBNull.Value;
                row["Tg4"] = (object?)r.Tg4 ?? DBNull.Value;
                row["Tg5"] = (object?)r.Tg5 ?? DBNull.Value;
                row["Tg6"] = (object?)r.Tg6 ?? DBNull.Value;
                row["Tg7"] = (object?)r.Tg7 ?? DBNull.Value;
                row["Tg8"] = (object?)r.Tg8 ?? DBNull.Value;
                row["Tg9"] = (object?)r.Tg9 ?? DBNull.Value;
                row["Tg10"] = (object?)r.Tg10 ?? DBNull.Value;
                row["Tg11"] = (object?)r.Tg11 ?? DBNull.Value;
                row["MagSede"] = r.MagSede;
                row["Assegnati"] = r.Assegnati;
                row["TotTag"] = r.TotTag;
                row["TotSped"] = r.TotSped;
                row["TotAnn"] = r.TotAnn;
                row["idComp"] = (object?)r.IdComp ?? DBNull.Value;
                row["Composizione"] = (object?)r.Composizione ?? DBNull.Value;
                row["List1"] = r.List1;
                row["CatMercMacroCod"] = (object?)r.CatMercMacroCod ?? DBNull.Value;
                row["CatMercMacroDesc"] = (object?)r.CatMercMacroDesc ?? DBNull.Value;
                row["DescCommerc"] = (object?)r.DescCommerc ?? DBNull.Value;

                row["PathLogo"] = loghiPerContatto.TryGetValue(r.IdContatto, out var logo) && logo != null
                    ? logo
                    : DBNull.Value;

                row["Lav1"] = (object?)r.Lav1 ?? DBNull.Value;
                row["Lav2"] = (object?)r.Lav2 ?? DBNull.Value;
                row["Lav3"] = (object?)r.Lav3 ?? DBNull.Value;
                row["Lav4"] = (object?)r.Lav4 ?? DBNull.Value;
                row["Lav5"] = (object?)r.Lav5 ?? DBNull.Value;
                row["Lav6"] = (object?)r.Lav6 ?? DBNull.Value;
                row["Peso"] = (object?)r.Peso ?? DBNull.Value;
                row["KW"] = (object?)r.Kw ?? DBNull.Value;
                row["OP"] = (object?)r.CdOp ?? DBNull.Value;
                row["MadeIn"] = (object?)r.MadeIn ?? DBNull.Value;
                row["Gender"] = (object?)r.GenderDesc ?? DBNull.Value;
                row["HsCode"] = (object?)r.HsCode ?? DBNull.Value;
                row["ckSemilav"] = r.CkSemilav;
                row["idCatMercMacro2"] = (object?)r.IdCatMercMacro2 ?? DBNull.Value;
                row["CatMercMacroDesc2"] = (object?)r.CatMercMacroDesc2 ?? DBNull.Value;
                row["idCatMerc2"] = (object?)r.IdCatMerc2 ?? DBNull.Value;
                row["CatMerc2"] = (object?)r.CatMerc2 ?? DBNull.Value;
                row["Vest"] = (object?)r.Vestibilita ?? DBNull.Value;
                row["Stagionalita"] = (object?)r.Stagionalita ?? DBNull.Value;

                table.Rows.Add(row);
            }

            return table;
        }
    }
}
