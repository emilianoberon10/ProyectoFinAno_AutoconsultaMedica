Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports DataAccess
Imports Logic
<TestClass()> Public Class UnitTest1
    Dim cont As Integer = 1
    <TestMethod()> Public Sub EnviarCorreo()
        Dim esperado As Boolean = True
        Dim actual As Boolean

        'Dim c As New DBEnvioCorreo

        Dim pac As New Paciente()
        pac._ci = "22222222"
        pac._mail = "emilianoberon10@gmail.com"

        actual = pac.EnviarChatPorCorreo
        'c.EnviarCorreo("emilianoberon10@gmail.com", mensjae)

        Assert.AreEqual(actual, esperado)
        cont = cont + 1
    End Sub

End Class