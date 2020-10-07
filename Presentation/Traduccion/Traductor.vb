Public Class Traductor
    Shared Property idioma As String = "ES"

    Public Shared Function Traducir(clave As String)
        Dim traduccion As String = ""
        Select Case idioma
            Case "ES"
                traduccion = My.Resources.Español.ResourceManager.GetString(clave)
                If traduccion = Nothing Then
                    traduccion = clave
                End If
            Case "EN"
                traduccion = My.Resources.Ingles.ResourceManager.GetString(clave)
                If traduccion = Nothing Then
                    traduccion = clave
                End If
        End Select
        Return traduccion
    End Function

    Public Shared Sub traducirForm(frm As Form)
        For Each control As Control In frm.Controls

            If TypeOf control Is Label Then
                Dim label As Label = DirectCast(control, Label)
                label.Text = Traducir(label.Name)
            End If
            If TypeOf control Is Button Then
                Dim button As Button = DirectCast(control, Button)
                button.Text = Traducir(button.Name)
            End If
            If TypeOf control Is Guna.UI2.WinForms.Guna2Button Then
                Dim button As Guna.UI2.WinForms.Guna2Button = DirectCast(control, Guna.UI2.WinForms.Guna2Button)
                button.Text = Traducir(button.Name)
            End If
            If TypeOf control Is Guna.UI2.WinForms.Guna2GroupBox Then
                Dim button As Guna.UI2.WinForms.Guna2GroupBox = DirectCast(control, Guna.UI2.WinForms.Guna2GroupBox)
                button.Text = Traducir(button.Name)
            End If
        Next
    End Sub

    Public Shared Sub traducirPanel(frm As Panel)
        For Each control As Control In frm.Controls

            If TypeOf control Is Label Then
                Dim label As Label = DirectCast(control, Label)
                label.Text = Traducir(label.Name)
            End If
            If TypeOf control Is Button Then
                Dim button As Button = DirectCast(control, Button)
                button.Text = Traducir(button.Name)
            End If
            If TypeOf control Is Guna.UI2.WinForms.Guna2Button Then
                Dim button As Guna.UI2.WinForms.Guna2Button = DirectCast(control, Guna.UI2.WinForms.Guna2Button)
                button.Text = Traducir(button.Name)
            End If
            If TypeOf control Is Guna.UI2.WinForms.Guna2GroupBox Then
                Dim button As Guna.UI2.WinForms.Guna2GroupBox = DirectCast(control, Guna.UI2.WinForms.Guna2GroupBox)
                button.Text = Traducir(button.Name)
            End If
        Next
    End Sub

End Class