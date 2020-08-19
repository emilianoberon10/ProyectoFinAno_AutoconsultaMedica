Imports Logic

Public Class FrmConsultaPaciente

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnChat.Visible = False
        cargarComboBox(cbSintoma1)
        cargarComboBox(cbSintoma2)
        cargarComboBox(cbSintoma3)
        cargarComboBox(cbSintoma4)
        cargarComboBox(cbSintoma5)
        cargarComboBox(cbSintoma6)
        cargarComboBox(cbSintoma7)
        cargarComboBox(cbSintoma8)
    End Sub

    Private Sub btnConsul_Click(sender As Object, e As EventArgs) Handles btnConsul.Click
        Dim diag As New Diagnostico()

        'creo un array de los sintomas seleccionados
        Dim _sintomas As New ArrayList
        'agrego cada sintoma del comboBox al array
        If cbSintoma1.Text = "SINTOMA" Then Else _sintomas.Add(cbSintoma1.Text)
        If cbSintoma2.Text = "SINTOMA" Then Else _sintomas.Add(cbSintoma2.Text)
        If cbSintoma3.Text = "SINTOMA" Then Else _sintomas.Add(cbSintoma3.Text)
        If cbSintoma4.Text = "SINTOMA" Then Else _sintomas.Add(cbSintoma4.Text)
        If cbSintoma5.Text = "SINTOMA" Then Else _sintomas.Add(cbSintoma5.Text)
        If cbSintoma6.Text = "SINTOMA" Then Else _sintomas.Add(cbSintoma6.Text)
        If cbSintoma7.Text = "SINTOMA" Then Else _sintomas.Add(cbSintoma7.Text)
        If cbSintoma8.Text = "SINTOMA" Then Else _sintomas.Add(cbSintoma8.Text)

        'lo agrego para diagnosticar
        FrmLogIn.paci.Selcciona(_sintomas)
        'apartir de la tabla selec genero el diagnostico
        'y lo muestro en un dataGrid
        dgvDiagnostico.DataSource = diag.Generar(FrmLogIn.paci._ci)
        btnChat.Show()

        diag.GuardarDiagnostico(FrmLogIn.paci._ci, ObtenerValoresDataGrid(0))
    End Sub

    Private Function ObtenerValoresDataGrid(rowIndex As Integer) As String
        If ((rowIndex < 0) OrElse (rowIndex > dgvDiagnostico.Rows.Count - 1)) Then
            ' Si el índice especificado es menor que 0 o mayor que el número
            ' total de filas existentes en el control DataGridView, abandonar
            ' la función.
            Return Nothing
        End If
        ' Nº de columnas del control DataGridView
        Dim columnCount As Integer = dgvDiagnostico.ColumnCount - 1
        ' Crear un nuevo objeto ArrayList cuyo número de elementos
        ' será igual al número de columnas existentes en el control
        ' DataGridView
        Dim datosDGV As String
        ' Añadir los elementos del objeto ArrayList conforme recorremos
        ' las colección de celdas de la fila especificada
        For n As Integer = 0 To columnCount
            datosDGV = (dgvDiagnostico.Rows(rowIndex).Cells(n).Value)
        Next
        ' Devolver el objeto ArrayList.
        Return datosDGV
    End Function

    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click
        FrmLogIn.paci.Solicita()
        Dim formwelcome As New FrmEsperaChat()
        formwelcome.ShowDialog()
    End Sub

#Region "styles"

    Private currentForm As Form = Nothing 'form en el panel no esta visible porque es el inicio de la app

    'Metodo para abrir ventanas dentro de la principal
    Public Sub OpenChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close() 'prenguto si hay un form abierto
        currentForm = childForm 'cargo el form que quiero abrir
        'Le pongo los estilos que necesito
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnChildCons.Controls.Add(childForm)
        pnChildCons.Tag = childForm
        'muestro el form
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnChat_Paint(sender As Object, e As PaintEventArgs) Handles btnConsul.Paint, btnChat.Paint
        BotonRedondeado(btnConsul)
        BotonRedondeado(btnChat)
    End Sub

    Private Sub pnChildCons_Paint(sender As Object, e As PaintEventArgs) Handles pnChildCons.Paint

    End Sub

#End Region

End Class