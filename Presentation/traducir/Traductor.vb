Public Class Traductor

    'Public Shared Sub Traducir(frm As Form, idioma As String)
    '    For Each control As Control In frm.Controls

    '        If TypeOf control Is Label Then
    '            Dim label As Label = DirectCast(control, Label)
    '            label.Text = CambiarIdioma(label.Text, idioma)
    '        End If
    '        If TypeOf control Is Button Then
    '            Dim boton As Button = DirectCast(control, Button)
    '            boton.Text = CambiarIdioma(boton.Text, idioma)
    '        End If
    '    Next
    'End Sub

    Public Shared Sub CambiarIdioma(idioma)
        If idioma = "Español" Then
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("es-ES")
        ElseIf idioma = "Ingles" Then
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("en-US")
        End If
    End Sub

    Private Sub SetTextos()

    End Sub

End Class