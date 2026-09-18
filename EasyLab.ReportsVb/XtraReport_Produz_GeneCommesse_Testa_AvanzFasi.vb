Public Class XtraReport_Produz_GeneCommesse_Testa_AvanzFasi

    ' Stessa situazione di XtraReport_CommesseFasi3Sintesi: la SqlDataSource puntava a una
    ' connection string nominata nel My.Settings del vecchio gestionale, inesistente qui.
    Public Sub ImpostaConnessione(connectionString As String)
        Dim parametri As New DevExpress.DataAccess.ConnectionParameters.CustomStringConnectionParameters(connectionString)
        Me.SqlDataSource1.ConnectionParameters = parametri
    End Sub

    ' Il report non legge una singola commessa ma la selezione filtrata corrente, salvata su
    ' Sel_ST da FasiCommesse.razor (idClasse=130) con l'ultima ricerca: la SP
    ' Report.SP_Produz_GeneCommesse_Testa_AvanzFasi_CreaSelST la rilegge da li' usando idClasse+idUte.
    Public Sub ImpostaParametri(idClasseValore As Integer, idUteValore As Integer)
        Me.idClasse.Value = idClasseValore
        Me.idUte.Value = idUteValore
    End Sub

End Class
