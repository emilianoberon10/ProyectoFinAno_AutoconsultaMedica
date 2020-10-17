Imports System.Net
Imports System.Net.Mail
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Public Class DBEnvioCorreo
    Inherits ConexionBD
    Public Sub New()

    End Sub

    Public Function EnviarCorreo(ciPac As String, email_destino As String) As Boolean

        ' En este caso llamamos un método que nos devolverá el contenido del
        ' correo en HTML, pero tambien podria ser cualquier valor de tipo String
        ' que queramos enviar.
        Dim mensaje As String = getMensajeChatCorreo(ciPac)
        ' Servidor de correo
        Dim servidor_correo_smtp As String = "smtp.gmail.com"
        ' Puerto del servidor smtp, si fuera necesario
        Dim servidor_correo_smtp_puerto As Integer = 465
        ' Casilla de correo de Origen
        Dim casilla_origen As String = " vvbsoftware@gmail.com "
        ' Password Casilla de correo de Origen
        Dim pass_casilla_origen As String = "ingenieros2020"
        ' Asunto del mensaje
        Dim asunto As String = "AUTO CONSULTA MEDICA"
        ' Enviar con copia/s
        Dim cc_email_destino As String = "vvbsoftware@gmail.com"
        ' Enviar con copia/s Oculta
        'Dim cco_email_destino As String = "vvbsoftware@gmail.com"
        ' Solo en caso de adjuntar archivo
        'Dim archivoAdjunto As Attachment = Nothing
        Dim smtp As New SmtpClient()
        Dim resultado As Boolean = False
        Try
            Dim correo As New MailMessage()
            correo.From = New MailAddress(casilla_origen)
            correo.Subject = asunto
            correo.Priority = MailPriority.Normal
            correo.Body = mensaje
            correo.IsBodyHtml = True
            correo.DeliveryNotificationOptions =
            DeliveryNotificationOptions.OnFailure
            '==================================================================
            ' AGREGO LAS CASILLAS DE CORREO DONDE VA EL EMAIL
            '===================================================================
            correo.To.Add(email_destino)
            'Casilla Con Copia
            correo.CC.Add(cc_email_destino)

            '==================================================================
            ' ARCHIVOS ADJUNTOS
            '==================================================================
            'correo.Attachments.Add(archivoAdjunto)
            'correo.Attachments.Add(new Attachment("C:\\file.zip"));
            '==================================================================
            ' Parámetros de configuración del servidor de correo smtp, la
            ' configuracion de estos parámetros depende del servidor a utilizar
            '==================================================================
            smtp.Host = servidor_correo_smtp
            'smtp.Port = servidor_correo_smtp_puerto
            smtp.Credentials = New NetworkCredential(casilla_origen, pass_casilla_origen)
            ' Definir si tu servidor SMTP requiere autenticación
            'smtp.UseDefaultCredentials = True
            'smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.EnableSsl = True
            '==================================================================
            ' ENVÍO EL CORREO
            '==================================================================
            smtp.Send(correo)

            resultado = True
            '==================================================================
            ' Limpio el contenido de "correo" por si estuviera en un bucle
            correo.Dispose()
        Catch ex As SmtpFailedRecipientsException
            ' Captura los errores que corresponden a la casilla de correo destino
            For i As Integer = 0 To ex.InnerExceptions.Length - 1
                Dim status As SmtpStatusCode = ex.InnerExceptions(i).StatusCode
                If status = SmtpStatusCode.MailboxBusy Then
                    Throw New SmtpException("ERROR en EnviarCorreo :: " +
                    ex.Message)
                ElseIf status = SmtpStatusCode.MailboxUnavailable Then
                    Throw New SmtpException("ERROR en EnviarCorreo :: " +
                    ex.Message)
                Else
                    Throw New SmtpException("ERROR en EnviarCorreo :: " +
                    ex.Message)
                End If
            Next
        Catch ex As SmtpException
            ' Otros errores distintos a los anteriores que puede dar el envio
            ' Ejemplo no existe el servidor de correo
            Throw New SmtpException("ERROR en EnviarCorreo :: " + ex.Message)
        Catch ex As Exception
            ' Cualquier otro error
            Throw New Exception("ERROR en EnviarCorreo :: " + ex.Message)
        End Try
        Return resultado

    End Function

    Private Function getMensajeChatCorreo(ciP) As String
        Dim mensaje As String = "<html>
                                <head> 
                                    <style type='text/css'>
                                    .tftable {
                                        font-size:12px;
                                        color:#333333;
                                        width:100%;
                                        border:1px solid #333333;
                                    }
                                    .tftable th {
                                        font-size:12px;
                                        padding: 8px;
                                        text-align:left;
                                        border-bottom:1px solid #333333;
                                    }
                                    </style>
                                </head>
                                <body>
                                    <br>
                                        <h2>CHAT AUTOCONSULTA MEDICA</h2>
                                    <br>
                                    <table class='tftable'>
                                        <tr>
                                            <th>Contenido del chat</th>
                                        </tr>"

        Dim sql As String = "SELECT txt FROM mensaje
                             JOIN chat ON chat.idchat=mensaje.idChat
                             WHERE ciPac='" & ciP & "' AND chat.estado='Proceso'"

        For Each row As DataRow In DevolverTabla(sql).Rows
            mensaje &= "<tr>"
            mensaje &= "<td>" & row("txt") & "</td>"
            mensaje &= "</tr>"
        Next row

        mensaje &= "</table></body></html>"
        Return mensaje

    End Function
End Class
