Imports Logic

Public Class FrmFichaMedicaPaciente
    Dim ficha As FichaMedica


    Private Sub FrmFichaMedicaPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ficha = New FichaMedica(FrmLogIn.paci._ci)
        'procedencia,ocup,medicacion,Motiv_Cons,antecedentesFamiliares
        DataGridView1.DataSource = ficha.GetFicha()

        txtProcedencia.Text = DataGridView1.Item(0, 0).Value
        txtOcupacion.Text = DataGridView1.Item(1, 0).Value
        txtMedicina.Text = DataGridView1.Item(2, 0).Value
        txtMotivoConsulta.Text = DataGridView1.Item(3, 0).Value
        txtAntecedentes.Text = DataGridView1.Item(4, 0).Value
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        If txtProcedencia.Text = "" Or txtOcupacion.Text = "" Or txtMotivoConsulta.Text = "" Then
            ErrorProvider1.SetError(PFicha_motCons, "Los campos con ( * ) son obligatorios.")
            ErrorProvider1.SetError(PFicha_ocup, "Los campos con ( * ) son obligatorios.")
            ErrorProvider1.SetError(PFicha_proced, "Los campos con ( * ) son obligatorios.")
        Else
            ficha = New FichaMedica(FrmLogIn.paci._ci, txtProcedencia.Text,
                                     txtOcupacion.Text, txtMedicina.Text, txtMotivoConsulta.Text, txtAntecedentes.Text)
            If ficha.GuardarFicha() Then
                Me.Close()
            Else
                MsgBox("ERROR AL GUARDAR LA FICHA, por favor reintente.")
            End If
        End If
    End Sub

    Private Sub ckbMedicina_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMedicina.CheckedChanged
        If ckbMedicina.Checked Then
            txtMedicina.Enabled = True
        Else
            txtMedicina.Enabled = False
        End If
    End Sub

    Private Sub chbAntecedentes_CheckedChanged(sender As Object, e As EventArgs) Handles chbAntecedentes.CheckedChanged
        If chbAntecedentes.Checked Then
            txtAntecedentes.Enabled = True
        Else
            txtAntecedentes.Enabled = False
        End If
    End Sub

    Private Sub txtMedicina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProcedencia.KeyPress, txtOcupacion.KeyPress, txtMotivoConsulta.KeyPress, txtMedicina.KeyPress, txtAntecedentes.KeyPress
        DesecharCaracteresEspeciales(e)
    End Sub


End Class