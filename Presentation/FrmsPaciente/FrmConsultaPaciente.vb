Imports Logic

Public Class FrmConsultaPaciente

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.traducirForm(Me)
        btn_chat.Visible = False
        CargarComboBoxSintomas(cbSintoma1)
        CargarComboBoxSintomas(cbSintoma2)
        CargarComboBoxSintomas(cbSintoma3)
        CargarComboBoxSintomas(cbSintoma4)
        CargarComboBoxSintomas(cbSintoma5)
        CargarComboBoxSintomas(cbSintoma6)
        CargarComboBoxSintomas(cbSintoma7)
        CargarComboBoxSintomas(cbSintoma8)
    End Sub

    Private Sub btnConsul_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        guardarSintomas()
        'apartir de la tabla selec genero el diagnostico y lo muestro en un dataGridView
        guardarEnfermedades()

        btn_chat.Show()

        Dim f As New FrmFichaMedicaPaciente
        f.ShowDialog()
    End Sub

    Private Sub guardarSintomas()
        'creo un array de los sintomas seleccionados
        Dim _sintomas As New ArrayList
        'agrego cada sintoma del comboBox al array
        If cbSintoma1.Enabled = True Then _sintomas.Add(cbSintoma1.Text)
        If cbSintoma2.Enabled = True Then _sintomas.Add(cbSintoma2.Text)
        If cbSintoma3.Enabled = True Then _sintomas.Add(cbSintoma3.Text)
        If cbSintoma4.Enabled = True Then _sintomas.Add(cbSintoma4.Text)
        If cbSintoma5.Enabled = True Then _sintomas.Add(cbSintoma5.Text)
        If cbSintoma6.Enabled = True Then _sintomas.Add(cbSintoma6.Text)
        If cbSintoma7.Enabled = True Then _sintomas.Add(cbSintoma7.Text)
        If cbSintoma8.Enabled = True Then _sintomas.Add(cbSintoma8.Text)

        'agrego los sintomas seleccionados para diagnosticar
        Try
            FrmLogIn.paci.Selcciona(_sintomas)
        Catch ex As Exception
            General.GetForm(Estado.Error, ex.Message)
        End Try
    End Sub

    Private Sub guardarEnfermedades()
        Try
            dgvDiagnostico.DataSource = FrmLogIn.paci.Generar()
            Try
                Dim enfermedad As String

                For filas As Integer = 0 To dgvDiagnostico.RowCount - 1

                    For Columnas As Integer = 0 To dgvDiagnostico.ColumnCount - 1

                        enfermedad = dgvDiagnostico.Item(Columnas, filas).Value
                        If enfermedad IsNot Nothing Then
                            FrmLogIn.paci._diagnostico = enfermedad
                            FrmLogIn.paci.GuardarDiagnostico()
                        End If

                    Next

                Next
            Catch ex As Exception
                ErrorProvider1.SetError(Me.consu_titulo, ex.Message)
                General.GetForm(Estado.Error, ex.Message)
            End Try
        Catch ex As Exception
            ErrorProvider1.SetError(Me.consu_titulo, ex.Message)
            General.GetForm(Estado.Error, ex.Message)

        End Try

    End Sub

    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btn_chat.Click
        FrmLogIn.paci.Solicita()
        Dim formwelcome As New FrmEsperaChat()
        formwelcome.ShowDialog()
    End Sub

#Region "Activar sintomas"

    Private Sub chb1_CheckedChanged(sender As Object, e As EventArgs) Handles chb1.CheckedChanged
        If chb1.Checked Then
            cbSintoma2.Enabled = True
        Else
            cbSintoma2.Enabled = False
        End If
    End Sub

    Private Sub chb2_CheckedChanged(sender As Object, e As EventArgs) Handles chb2.CheckedChanged
        If chb2.Checked Then
            cbSintoma3.Enabled = True
        Else
            cbSintoma3.Enabled = False
        End If
    End Sub

    Private Sub chb3_CheckedChanged(sender As Object, e As EventArgs) Handles chb3.CheckedChanged
        If chb3.Checked Then
            cbSintoma4.Enabled = True
        Else
            cbSintoma4.Enabled = False
        End If
    End Sub

    Private Sub chb4_CheckedChanged(sender As Object, e As EventArgs) Handles chb4.CheckedChanged
        cbSintoma5.Enabled = True
        If chb4.Checked Then
            cbSintoma5.Enabled = True
        Else
            cbSintoma5.Enabled = False
        End If
    End Sub

    Private Sub chb5_CheckedChanged(sender As Object, e As EventArgs) Handles chb5.CheckedChanged
        If chb5.Checked Then
            cbSintoma6.Enabled = True
        Else
            cbSintoma6.Enabled = False
        End If
    End Sub

    Private Sub chb6_CheckedChanged(sender As Object, e As EventArgs) Handles chb6.CheckedChanged
        If chb6.Checked Then
            cbSintoma7.Enabled = True
        Else
            cbSintoma7.Enabled = False
        End If
    End Sub

    Private Sub chb7_CheckedChanged(sender As Object, e As EventArgs) Handles chb7.CheckedChanged
        If chb7.Checked Then
            cbSintoma8.Enabled = True
        Else
            cbSintoma8.Enabled = False
        End If
    End Sub

    Private Sub chb8_CheckedChanged(sender As Object, e As EventArgs) Handles chb8.CheckedChanged
        If chb8.Checked Then
            cbSintoma9.Enabled = True
        Else
            cbSintoma9.Enabled = False
        End If
    End Sub

#End Region

#Region "styles"

    Private Sub btnChat_Paint(sender As Object, e As PaintEventArgs)
        'BotonRedondeado(btnConsul)
        'BotonRedondeado(btnChat)
    End Sub

#End Region

End Class