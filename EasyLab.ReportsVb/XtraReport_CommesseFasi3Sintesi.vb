Public Class XtraReport_CommesseFasi3Sintesi

    ' Il report e' stato esportato dal designer del vecchio gestionale VB.NET (WinForms), dove le
    ' due SqlDataSource puntavano a una connection string nominata nel My.Settings di
    ' quell'applicazione ("EASY_PLM.My.MySettings.MILUNA_PLMConnectionString"), inesistente qui.
    ' Le si ripunta esplicitamente alla connection string di EasyLab prima del rendering.
    Public Sub ImpostaConnessione(connectionString As String)
        Dim parametri As New DevExpress.DataAccess.ConnectionParameters.CustomStringConnectionParameters(connectionString)
        Me.SqlDataSource1.ConnectionParameters = parametri
        Me.SqlDataSource2.ConnectionParameters = parametri
    End Sub

    ' Unico parametro del report: passato alle due stored procedure (SP_V_Produz_GeneCommesse_Select_idComm
    ' e doc.SP_Doc3_MovFasi_SelectSintesi_idComm) che caricano i dati.
    Public Sub ImpostaIdCommessa(id As Integer)
        Me.idComm.Value = id
    End Sub

End Class
