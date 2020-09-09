Public Class FrmOpciones

    Private Sub FrmOpciones_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim brush As New SolidBrush(BackColor)

        e.Graphics.FillRectangle(brush, ClientRectangle)
        e.Graphics.DrawRectangle(Pens.DarkGray, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1)
    End Sub

End Class