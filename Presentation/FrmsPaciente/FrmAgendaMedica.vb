Imports Logic

Public Class FrmAgendaMedica

    Private med As New Medico()

    Private Sub FrmAgendaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirPanel(helpPanel)
        Traductor.traducirForm(Me)
        dgvAgenda.DataSource = med.Agenda
        With cbFiltro
            .DataSource = med.Especialidad.Tables(0)
            .DisplayMember = "nombre" 'elnombre de tu columna de tu base de datos q deseas mostrar
            .ValueMember = "id" 'el id de tu tabla relacionada con el nombre que muestras muy importante para saber el ide de quien seleccionas en tu combobox
            .Text = "ESPECIALIDAD"
        End With
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btn_Filtrar.Click
        dgvAgenda.DataSource = med.AgendaFiltroEsp(cbFiltro.Text)
    End Sub

    Private Sub btnBuscarMed_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        dgvAgenda.DataSource = med.AgendaFiltroNom(txtNomBuscar.Text)
    End Sub

    Private Sub Switch1_CheckedChanged(sender As Object, e As EventArgs) Handles switch.CheckedChanged
        If switch.Checked Then
            btn_Buscar.Enabled = True
            txtNomBuscar.Enabled = True
        Else
            btn_Buscar.Enabled = False
            txtNomBuscar.Enabled = False
        End If

    End Sub

    Private Sub txtNomBuscar_KeyPress(sender As Object, e As KeyPressEventArgs)
        DesecharCaracteresEspeciales(e)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If helpPanel.Visible = True Then
            helpPanel.Visible = False
        Else
            helpPanel.Visible = True
        End If
    End Sub
End Class