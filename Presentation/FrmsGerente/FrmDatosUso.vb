Public Class FrmDatosUso
    Private Sub FrmDatosUso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nomE As ArrayList = FrmLogIn.gere.NomEmasDiag
        Dim cantEnf As ArrayList = FrmLogIn.gere.CantEnfMasDiag

        Dim sint As ArrayList = FrmLogIn.gere.NomSintMasSelec
        Dim cantSint As ArrayList = FrmLogIn.gere.CantSintMasSelec

        Dim meses As ArrayList = FrmLogIn.gere.MesesChats
        Dim cantChat As ArrayList = FrmLogIn.gere.cantChatMes

        charTopEnfermedades.Series(0).Points.DataBindXY(nomE, cantEnf)

        chartTopSintomas.Series(0).Points.DataBindXY(sint, cantSint)

        chartChatsMes.Series(0).Points.DataBindXY(meses, cantChat)


    End Sub
End Class