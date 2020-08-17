Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Logic

<TestClass()> Public Class TestPaciente

    <TestMethod()> Public Sub TestGuradarPaciente()
        Dim paciente As New Logic.Paciente
        Dim esperado As Boolean = False
        Dim actual As Boolean

        With paciente
            ._ci = "53498903"
            ._contraseña = "micontraseña"
            ._domicilio = "Cno.Carrasco 2671"
            ._edad = "19"
            ._fechaNac = "2001-02-10"
            ._mail = "miemail@gmail.com"
            ._pNom = "Emiliano"
            ._sNom = ""
            ._pApe = "Beron"
            ._sApe = "Martinel"
            ._sexo = "Hombre"
            ._tel_cel = "25220455"
        End With

        actual = paciente.Guardar

        Assert.AreEqual(actual, esperado)

    End Sub

End Class