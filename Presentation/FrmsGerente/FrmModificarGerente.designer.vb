<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModificarGerente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DgvDatos = New System.Windows.Forms.DataGridView()
        Me.cbFiltro = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreSintoma = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombreEnfermedad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelModSintoma = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbRiesgo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelModEnfermedad = New System.Windows.Forms.Panel()
        Me.cbSintoma9 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma8 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma6 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma3 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma5 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma2 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma4 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma7 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma1 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSape = New System.Windows.Forms.TextBox()
        Me.txtSApellido = New System.Windows.Forms.Label()
        Me.txtSnom = New System.Windows.Forms.TextBox()
        Me.txtSegNombre = New System.Windows.Forms.Label()
        Me.txtPriApe = New System.Windows.Forms.TextBox()
        Me.txtLugarTrabajo = New System.Windows.Forms.TextBox()
        Me.txtPriNom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPriApellido = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPriNombre = New System.Windows.Forms.Label()
        Me.PanelModifMedico = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkDom = New System.Windows.Forms.CheckBox()
        Me.chkSab = New System.Windows.Forms.CheckBox()
        Me.chkVier = New System.Windows.Forms.CheckBox()
        Me.chkJuev = New System.Windows.Forms.CheckBox()
        Me.chkMier = New System.Windows.Forms.CheckBox()
        Me.chkMar = New System.Windows.Forms.CheckBox()
        Me.chkLun = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtHoraEntradaDomingo = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaSabado = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaViernes = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaMiercoles = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaJueves = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaMartes = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaLunes = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbEsp = New System.Windows.Forms.ComboBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.txtDom = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelModSintoma.SuspendLayout()
        Me.PanelModEnfermedad.SuspendLayout()
        Me.PanelModifMedico.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(227, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 36)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "MODIFICAR"
        '
        'DgvDatos
        '
        Me.DgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.DgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvDatos.ColumnHeadersHeight = 30
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDatos.DefaultCellStyle = DataGridViewCellStyle8
        Me.DgvDatos.EnableHeadersVisualStyles = False
        Me.DgvDatos.GridColor = System.Drawing.Color.SteelBlue
        Me.DgvDatos.Location = New System.Drawing.Point(12, 66)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DgvDatos.Size = New System.Drawing.Size(640, 117)
        Me.DgvDatos.TabIndex = 6
        '
        'cbFiltro
        '
        Me.cbFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFiltro.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltro.ForeColor = System.Drawing.Color.Silver
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Items.AddRange(New Object() {"Medicos", "Enfermedades", "Sintomas"})
        Me.cbFiltro.Location = New System.Drawing.Point(16, 209)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(180, 29)
        Me.cbFiltro.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(13, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(402, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Haga doble click en una celda para seleccionar el elemento"
        '
        'txtNombreSintoma
        '
        Me.txtNombreSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNombreSintoma.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreSintoma.ForeColor = System.Drawing.Color.Silver
        Me.txtNombreSintoma.Location = New System.Drawing.Point(0, 27)
        Me.txtNombreSintoma.Name = "txtNombreSintoma"
        Me.txtNombreSintoma.Size = New System.Drawing.Size(188, 22)
        Me.txtNombreSintoma.TabIndex = 9
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Silver
        Me.txtDescripcion.Location = New System.Drawing.Point(7, 79)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(238, 127)
        Me.txtDescripcion.TabIndex = 9
        '
        'txtNombreEnfermedad
        '
        Me.txtNombreEnfermedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNombreEnfermedad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEnfermedad.ForeColor = System.Drawing.Color.Silver
        Me.txtNombreEnfermedad.Location = New System.Drawing.Point(8, 25)
        Me.txtNombreEnfermedad.MaxLength = 30
        Me.txtNombreEnfermedad.Name = "txtNombreEnfermedad"
        Me.txtNombreEnfermedad.Size = New System.Drawing.Size(180, 27)
        Me.txtNombreEnfermedad.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(12, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Datos Seleccionados"
        '
        'PanelModSintoma
        '
        Me.PanelModSintoma.Controls.Add(Me.txtNombreSintoma)
        Me.PanelModSintoma.Controls.Add(Me.Label5)
        Me.PanelModSintoma.Location = New System.Drawing.Point(16, 349)
        Me.PanelModSintoma.Name = "PanelModSintoma"
        Me.PanelModSintoma.Size = New System.Drawing.Size(191, 66)
        Me.PanelModSintoma.TabIndex = 10
        Me.PanelModSintoma.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(3, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(251, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Riesgo"
        '
        'cbRiesgo
        '
        Me.cbRiesgo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbRiesgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRiesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRiesgo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRiesgo.ForeColor = System.Drawing.Color.Silver
        Me.cbRiesgo.FormattingEnabled = True
        Me.cbRiesgo.Location = New System.Drawing.Point(254, 28)
        Me.cbRiesgo.Name = "cbRiesgo"
        Me.cbRiesgo.Size = New System.Drawing.Size(180, 24)
        Me.cbRiesgo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(5, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripcion"
        '
        'PanelModEnfermedad
        '
        Me.PanelModEnfermedad.Controls.Add(Me.cbSintoma9)
        Me.PanelModEnfermedad.Controls.Add(Me.cbSintoma8)
        Me.PanelModEnfermedad.Controls.Add(Me.cbSintoma6)
        Me.PanelModEnfermedad.Controls.Add(Me.cbSintoma3)
        Me.PanelModEnfermedad.Controls.Add(Me.cbSintoma5)
        Me.PanelModEnfermedad.Controls.Add(Me.cbSintoma2)
        Me.PanelModEnfermedad.Controls.Add(Me.cbSintoma4)
        Me.PanelModEnfermedad.Controls.Add(Me.cbSintoma7)
        Me.PanelModEnfermedad.Controls.Add(Me.cbSintoma1)
        Me.PanelModEnfermedad.Controls.Add(Me.txtNombreEnfermedad)
        Me.PanelModEnfermedad.Controls.Add(Me.txtDescripcion)
        Me.PanelModEnfermedad.Controls.Add(Me.cbRiesgo)
        Me.PanelModEnfermedad.Controls.Add(Me.Label19)
        Me.PanelModEnfermedad.Controls.Add(Me.Label3)
        Me.PanelModEnfermedad.Controls.Add(Me.Label4)
        Me.PanelModEnfermedad.Controls.Add(Me.Label1)
        Me.PanelModEnfermedad.Location = New System.Drawing.Point(12, 349)
        Me.PanelModEnfermedad.Name = "PanelModEnfermedad"
        Me.PanelModEnfermedad.Size = New System.Drawing.Size(640, 209)
        Me.PanelModEnfermedad.TabIndex = 11
        Me.PanelModEnfermedad.Visible = False
        '
        'cbSintoma9
        '
        Me.cbSintoma9.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma9.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma9.FormattingEnabled = True
        Me.cbSintoma9.Location = New System.Drawing.Point(440, 55)
        Me.cbSintoma9.Name = "cbSintoma9"
        Me.cbSintoma9.Size = New System.Drawing.Size(182, 25)
        Me.cbSintoma9.TabIndex = 17
        '
        'cbSintoma8
        '
        Me.cbSintoma8.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma8.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma8.FormattingEnabled = True
        Me.cbSintoma8.Location = New System.Drawing.Point(440, 150)
        Me.cbSintoma8.Name = "cbSintoma8"
        Me.cbSintoma8.Size = New System.Drawing.Size(182, 25)
        Me.cbSintoma8.TabIndex = 18
        '
        'cbSintoma6
        '
        Me.cbSintoma6.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma6.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma6.FormattingEnabled = True
        Me.cbSintoma6.Location = New System.Drawing.Point(440, 181)
        Me.cbSintoma6.Name = "cbSintoma6"
        Me.cbSintoma6.Size = New System.Drawing.Size(182, 25)
        Me.cbSintoma6.TabIndex = 14
        '
        'cbSintoma3
        '
        Me.cbSintoma3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma3.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma3.FormattingEnabled = True
        Me.cbSintoma3.Location = New System.Drawing.Point(252, 181)
        Me.cbSintoma3.Name = "cbSintoma3"
        Me.cbSintoma3.Size = New System.Drawing.Size(182, 25)
        Me.cbSintoma3.TabIndex = 11
        '
        'cbSintoma5
        '
        Me.cbSintoma5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma5.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma5.FormattingEnabled = True
        Me.cbSintoma5.Location = New System.Drawing.Point(440, 119)
        Me.cbSintoma5.Name = "cbSintoma5"
        Me.cbSintoma5.Size = New System.Drawing.Size(182, 25)
        Me.cbSintoma5.TabIndex = 15
        '
        'cbSintoma2
        '
        Me.cbSintoma2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma2.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma2.FormattingEnabled = True
        Me.cbSintoma2.Location = New System.Drawing.Point(440, 87)
        Me.cbSintoma2.Name = "cbSintoma2"
        Me.cbSintoma2.Size = New System.Drawing.Size(182, 25)
        Me.cbSintoma2.TabIndex = 12
        '
        'cbSintoma4
        '
        Me.cbSintoma4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma4.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma4.FormattingEnabled = True
        Me.cbSintoma4.Location = New System.Drawing.Point(252, 119)
        Me.cbSintoma4.Name = "cbSintoma4"
        Me.cbSintoma4.Size = New System.Drawing.Size(182, 25)
        Me.cbSintoma4.TabIndex = 13
        '
        'cbSintoma7
        '
        Me.cbSintoma7.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma7.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma7.FormattingEnabled = True
        Me.cbSintoma7.Location = New System.Drawing.Point(252, 150)
        Me.cbSintoma7.Name = "cbSintoma7"
        Me.cbSintoma7.Size = New System.Drawing.Size(182, 25)
        Me.cbSintoma7.TabIndex = 16
        '
        'cbSintoma1
        '
        Me.cbSintoma1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma1.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma1.FormattingEnabled = True
        Me.cbSintoma1.Location = New System.Drawing.Point(252, 87)
        Me.cbSintoma1.Name = "cbSintoma1"
        Me.cbSintoma1.Size = New System.Drawing.Size(182, 25)
        Me.cbSintoma1.TabIndex = 10
        Me.cbSintoma1.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Silver
        Me.Label19.Location = New System.Drawing.Point(251, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(155, 20)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Sintomas que posee"
        '
        'txtSape
        '
        Me.txtSape.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtSape.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSape.ForeColor = System.Drawing.Color.Silver
        Me.txtSape.Location = New System.Drawing.Point(440, 76)
        Me.txtSape.MaxLength = 30
        Me.txtSape.Name = "txtSape"
        Me.txtSape.Size = New System.Drawing.Size(180, 27)
        Me.txtSape.TabIndex = 46
        '
        'txtSApellido
        '
        Me.txtSApellido.AutoSize = True
        Me.txtSApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSApellido.ForeColor = System.Drawing.Color.Silver
        Me.txtSApellido.Location = New System.Drawing.Point(440, 56)
        Me.txtSApellido.Name = "txtSApellido"
        Me.txtSApellido.Size = New System.Drawing.Size(148, 21)
        Me.txtSApellido.TabIndex = 25
        Me.txtSApellido.Text = "Segundo Apellido"
        '
        'txtSnom
        '
        Me.txtSnom.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtSnom.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSnom.ForeColor = System.Drawing.Color.Silver
        Me.txtSnom.Location = New System.Drawing.Point(226, 76)
        Me.txtSnom.MaxLength = 30
        Me.txtSnom.Name = "txtSnom"
        Me.txtSnom.Size = New System.Drawing.Size(180, 27)
        Me.txtSnom.TabIndex = 44
        '
        'txtSegNombre
        '
        Me.txtSegNombre.AutoSize = True
        Me.txtSegNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegNombre.ForeColor = System.Drawing.Color.Silver
        Me.txtSegNombre.Location = New System.Drawing.Point(226, 53)
        Me.txtSegNombre.Name = "txtSegNombre"
        Me.txtSegNombre.Size = New System.Drawing.Size(147, 21)
        Me.txtSegNombre.TabIndex = 23
        Me.txtSegNombre.Text = "Segundo Nombre"
        '
        'txtPriApe
        '
        Me.txtPriApe.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtPriApe.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriApe.ForeColor = System.Drawing.Color.Silver
        Me.txtPriApe.Location = New System.Drawing.Point(440, 26)
        Me.txtPriApe.MaxLength = 30
        Me.txtPriApe.Name = "txtPriApe"
        Me.txtPriApe.Size = New System.Drawing.Size(180, 27)
        Me.txtPriApe.TabIndex = 43
        '
        'txtLugarTrabajo
        '
        Me.txtLugarTrabajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtLugarTrabajo.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTrabajo.ForeColor = System.Drawing.Color.Silver
        Me.txtLugarTrabajo.Location = New System.Drawing.Point(7, 77)
        Me.txtLugarTrabajo.MaxLength = 30
        Me.txtLugarTrabajo.Name = "txtLugarTrabajo"
        Me.txtLugarTrabajo.Size = New System.Drawing.Size(180, 27)
        Me.txtLugarTrabajo.TabIndex = 30
        '
        'txtPriNom
        '
        Me.txtPriNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtPriNom.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriNom.ForeColor = System.Drawing.Color.Silver
        Me.txtPriNom.Location = New System.Drawing.Point(226, 26)
        Me.txtPriNom.MaxLength = 30
        Me.txtPriNom.Name = "txtPriNom"
        Me.txtPriNom.Size = New System.Drawing.Size(180, 27)
        Me.txtPriNom.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(7, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Lugar de Trabajo"
        '
        'txtPriApellido
        '
        Me.txtPriApellido.AutoSize = True
        Me.txtPriApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriApellido.ForeColor = System.Drawing.Color.Silver
        Me.txtPriApellido.Location = New System.Drawing.Point(440, 5)
        Me.txtPriApellido.Name = "txtPriApellido"
        Me.txtPriApellido.Size = New System.Drawing.Size(125, 21)
        Me.txtPriApellido.TabIndex = 19
        Me.txtPriApellido.Text = "Primer Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(7, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Especialidad"
        '
        'txtPriNombre
        '
        Me.txtPriNombre.AutoSize = True
        Me.txtPriNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriNombre.ForeColor = System.Drawing.Color.Silver
        Me.txtPriNombre.Location = New System.Drawing.Point(226, 5)
        Me.txtPriNombre.Name = "txtPriNombre"
        Me.txtPriNombre.Size = New System.Drawing.Size(124, 21)
        Me.txtPriNombre.TabIndex = 24
        Me.txtPriNombre.Text = "Primer Nombre"
        '
        'PanelModifMedico
        '
        Me.PanelModifMedico.Controls.Add(Me.Panel1)
        Me.PanelModifMedico.Controls.Add(Me.txtSape)
        Me.PanelModifMedico.Controls.Add(Me.txtSApellido)
        Me.PanelModifMedico.Controls.Add(Me.txtSnom)
        Me.PanelModifMedico.Controls.Add(Me.cbEsp)
        Me.PanelModifMedico.Controls.Add(Me.cbSexo)
        Me.PanelModifMedico.Controls.Add(Me.txtSegNombre)
        Me.PanelModifMedico.Controls.Add(Me.txtPriApe)
        Me.PanelModifMedico.Controls.Add(Me.txtDom)
        Me.PanelModifMedico.Controls.Add(Me.txtTel)
        Me.PanelModifMedico.Controls.Add(Me.txtLugarTrabajo)
        Me.PanelModifMedico.Controls.Add(Me.Label23)
        Me.PanelModifMedico.Controls.Add(Me.Label22)
        Me.PanelModifMedico.Controls.Add(Me.txtPriNom)
        Me.PanelModifMedico.Controls.Add(Me.Label21)
        Me.PanelModifMedico.Controls.Add(Me.Label7)
        Me.PanelModifMedico.Controls.Add(Me.txtPriApellido)
        Me.PanelModifMedico.Controls.Add(Me.Label6)
        Me.PanelModifMedico.Controls.Add(Me.txtPriNombre)
        Me.PanelModifMedico.Location = New System.Drawing.Point(9, 264)
        Me.PanelModifMedico.Name = "PanelModifMedico"
        Me.PanelModifMedico.Size = New System.Drawing.Size(640, 303)
        Me.PanelModifMedico.TabIndex = 47
        Me.PanelModifMedico.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkDom)
        Me.Panel1.Controls.Add(Me.chkJuev)
        Me.Panel1.Controls.Add(Me.chkSab)
        Me.Panel1.Controls.Add(Me.chkMier)
        Me.Panel1.Controls.Add(Me.chkMar)
        Me.Panel1.Controls.Add(Me.chkVier)
        Me.Panel1.Controls.Add(Me.chkLun)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaDomingo)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaSabado)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaViernes)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaMiercoles)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaJueves)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaMartes)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaLunes)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Location = New System.Drawing.Point(4, 153)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 147)
        Me.Panel1.TabIndex = 47
        '
        'chkDom
        '
        Me.chkDom.AutoSize = True
        Me.chkDom.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkDom.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDom.ForeColor = System.Drawing.Color.Silver
        Me.chkDom.Location = New System.Drawing.Point(383, 102)
        Me.chkDom.Name = "chkDom"
        Me.chkDom.Size = New System.Drawing.Size(15, 14)
        Me.chkDom.TabIndex = 4
        Me.chkDom.UseVisualStyleBackColor = False
        '
        'chkSab
        '
        Me.chkSab.AutoSize = True
        Me.chkSab.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkSab.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSab.ForeColor = System.Drawing.Color.Silver
        Me.chkSab.Location = New System.Drawing.Point(264, 102)
        Me.chkSab.Name = "chkSab"
        Me.chkSab.Size = New System.Drawing.Size(15, 14)
        Me.chkSab.TabIndex = 4
        Me.chkSab.UseVisualStyleBackColor = False
        '
        'chkVier
        '
        Me.chkVier.AutoSize = True
        Me.chkVier.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkVier.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVier.ForeColor = System.Drawing.Color.Silver
        Me.chkVier.Location = New System.Drawing.Point(534, 32)
        Me.chkVier.Name = "chkVier"
        Me.chkVier.Size = New System.Drawing.Size(15, 14)
        Me.chkVier.TabIndex = 4
        Me.chkVier.UseVisualStyleBackColor = False
        '
        'chkJuev
        '
        Me.chkJuev.AutoSize = True
        Me.chkJuev.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkJuev.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJuev.ForeColor = System.Drawing.Color.Silver
        Me.chkJuev.Location = New System.Drawing.Point(427, 32)
        Me.chkJuev.Name = "chkJuev"
        Me.chkJuev.Size = New System.Drawing.Size(15, 14)
        Me.chkJuev.TabIndex = 4
        Me.chkJuev.UseVisualStyleBackColor = False
        '
        'chkMier
        '
        Me.chkMier.AutoSize = True
        Me.chkMier.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkMier.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMier.ForeColor = System.Drawing.Color.Silver
        Me.chkMier.Location = New System.Drawing.Point(318, 32)
        Me.chkMier.Name = "chkMier"
        Me.chkMier.Size = New System.Drawing.Size(15, 14)
        Me.chkMier.TabIndex = 4
        Me.chkMier.UseVisualStyleBackColor = False
        '
        'chkMar
        '
        Me.chkMar.AutoSize = True
        Me.chkMar.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkMar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMar.ForeColor = System.Drawing.Color.Silver
        Me.chkMar.Location = New System.Drawing.Point(209, 32)
        Me.chkMar.Name = "chkMar"
        Me.chkMar.Size = New System.Drawing.Size(15, 14)
        Me.chkMar.TabIndex = 4
        Me.chkMar.UseVisualStyleBackColor = False
        '
        'chkLun
        '
        Me.chkLun.AutoSize = True
        Me.chkLun.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkLun.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLun.ForeColor = System.Drawing.Color.Silver
        Me.chkLun.Location = New System.Drawing.Point(100, 32)
        Me.chkLun.Name = "chkLun"
        Me.chkLun.Size = New System.Drawing.Size(15, 14)
        Me.chkLun.TabIndex = 4
        Me.chkLun.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Silver
        Me.Label16.Location = New System.Drawing.Point(235, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Sabado"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Silver
        Me.Label15.Location = New System.Drawing.Point(509, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 21)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Viernes"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Silver
        Me.Label14.Location = New System.Drawing.Point(402, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 21)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Jueves"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Silver
        Me.Label17.Location = New System.Drawing.Point(350, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 21)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Domingo"
        '
        'txtHoraEntradaDomingo
        '
        Me.txtHoraEntradaDomingo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaDomingo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaDomingo.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaDomingo.Location = New System.Drawing.Point(339, 117)
        Me.txtHoraEntradaDomingo.MaxLength = 6
        Me.txtHoraEntradaDomingo.Name = "txtHoraEntradaDomingo"
        Me.txtHoraEntradaDomingo.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaDomingo.TabIndex = 1
        '
        'txtHoraEntradaSabado
        '
        Me.txtHoraEntradaSabado.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaSabado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaSabado.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaSabado.Location = New System.Drawing.Point(220, 117)
        Me.txtHoraEntradaSabado.MaxLength = 6
        Me.txtHoraEntradaSabado.Name = "txtHoraEntradaSabado"
        Me.txtHoraEntradaSabado.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaSabado.TabIndex = 1
        '
        'txtHoraEntradaViernes
        '
        Me.txtHoraEntradaViernes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaViernes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaViernes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaViernes.Location = New System.Drawing.Point(490, 47)
        Me.txtHoraEntradaViernes.MaxLength = 6
        Me.txtHoraEntradaViernes.Name = "txtHoraEntradaViernes"
        Me.txtHoraEntradaViernes.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaViernes.TabIndex = 1
        '
        'txtHoraEntradaMiercoles
        '
        Me.txtHoraEntradaMiercoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaMiercoles.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaMiercoles.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaMiercoles.Location = New System.Drawing.Point(274, 47)
        Me.txtHoraEntradaMiercoles.MaxLength = 6
        Me.txtHoraEntradaMiercoles.Name = "txtHoraEntradaMiercoles"
        Me.txtHoraEntradaMiercoles.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaMiercoles.TabIndex = 1
        '
        'txtHoraEntradaJueves
        '
        Me.txtHoraEntradaJueves.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaJueves.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaJueves.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaJueves.Location = New System.Drawing.Point(383, 47)
        Me.txtHoraEntradaJueves.MaxLength = 6
        Me.txtHoraEntradaJueves.Name = "txtHoraEntradaJueves"
        Me.txtHoraEntradaJueves.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaJueves.TabIndex = 1
        '
        'txtHoraEntradaMartes
        '
        Me.txtHoraEntradaMartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaMartes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaMartes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaMartes.Location = New System.Drawing.Point(165, 47)
        Me.txtHoraEntradaMartes.MaxLength = 6
        Me.txtHoraEntradaMartes.Name = "txtHoraEntradaMartes"
        Me.txtHoraEntradaMartes.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaMartes.TabIndex = 1
        '
        'txtHoraEntradaLunes
        '
        Me.txtHoraEntradaLunes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaLunes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaLunes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaLunes.Location = New System.Drawing.Point(56, 47)
        Me.txtHoraEntradaLunes.MaxLength = 6
        Me.txtHoraEntradaLunes.Name = "txtHoraEntradaLunes"
        Me.txtHoraEntradaLunes.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaLunes.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Silver
        Me.Label13.Location = New System.Drawing.Point(284, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 21)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Miercoles"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(184, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Martes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(81, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Lunes"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Silver
        Me.Label18.Location = New System.Drawing.Point(3, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(178, 21)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Ejemplo: 09:00 a 19:30"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Silver
        Me.Label24.Location = New System.Drawing.Point(3, 50)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 21)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Hora"
        '
        'cbEsp
        '
        Me.cbEsp.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEsp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEsp.ForeColor = System.Drawing.Color.Silver
        Me.cbEsp.FormattingEnabled = True
        Me.cbEsp.Items.AddRange(New Object() {"Medicos", "Enfermedades", "Sintomas"})
        Me.cbEsp.Location = New System.Drawing.Point(9, 26)
        Me.cbEsp.Name = "cbEsp"
        Me.cbEsp.Size = New System.Drawing.Size(180, 29)
        Me.cbEsp.TabIndex = 7
        '
        'cbSexo
        '
        Me.cbSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSexo.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.ForeColor = System.Drawing.Color.Silver
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Hombre", "Mujer", "Otro"})
        Me.cbSexo.Location = New System.Drawing.Point(440, 118)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(180, 29)
        Me.cbSexo.TabIndex = 7
        '
        'txtDom
        '
        Me.txtDom.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDom.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDom.ForeColor = System.Drawing.Color.Silver
        Me.txtDom.Location = New System.Drawing.Point(226, 120)
        Me.txtDom.MaxLength = 255
        Me.txtDom.Name = "txtDom"
        Me.txtDom.Size = New System.Drawing.Size(180, 27)
        Me.txtDom.TabIndex = 30
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtTel.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.ForeColor = System.Drawing.Color.Silver
        Me.txtTel.Location = New System.Drawing.Point(7, 123)
        Me.txtTel.MaxLength = 9
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(180, 27)
        Me.txtTel.TabIndex = 30
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Silver
        Me.Label23.Location = New System.Drawing.Point(440, 99)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(46, 21)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "Sexo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Silver
        Me.Label22.Location = New System.Drawing.Point(226, 101)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 21)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Domicilio"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Silver
        Me.Label21.Location = New System.Drawing.Point(7, 103)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 21)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Telefono"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Silver
        Me.Label20.Location = New System.Drawing.Point(16, 186)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 20)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Filtro"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Silver
        Me.btnModificar.Location = New System.Drawing.Point(432, 195)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(200, 40)
        Me.btnModificar.TabIndex = 48
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'FrmModificarGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 570)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.PanelModifMedico)
        Me.Controls.Add(Me.PanelModEnfermedad)
        Me.Controls.Add(Me.PanelModSintoma)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.DgvDatos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmModificarGerente"
        Me.Text = "FrmModificar"
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelModSintoma.ResumeLayout(False)
        Me.PanelModSintoma.PerformLayout()
        Me.PanelModEnfermedad.ResumeLayout(False)
        Me.PanelModEnfermedad.PerformLayout()
        Me.PanelModifMedico.ResumeLayout(False)
        Me.PanelModifMedico.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents DgvDatos As DataGridView
    Friend WithEvents cbFiltro As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreSintoma As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombreEnfermedad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelModSintoma As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbRiesgo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelModEnfermedad As Panel
    Friend WithEvents txtSape As TextBox
    Friend WithEvents txtSApellido As Label
    Friend WithEvents txtSnom As TextBox
    Friend WithEvents txtSegNombre As Label
    Friend WithEvents txtPriApe As TextBox
    Friend WithEvents txtLugarTrabajo As TextBox
    Friend WithEvents txtPriNom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPriApellido As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPriNombre As Label
    Friend WithEvents PanelModifMedico As Panel
    Friend WithEvents cbSintoma9 As ComboBox
    Friend WithEvents cbSintoma8 As ComboBox
    Friend WithEvents cbSintoma6 As ComboBox
    Friend WithEvents cbSintoma3 As ComboBox
    Friend WithEvents cbSintoma5 As ComboBox
    Friend WithEvents cbSintoma2 As ComboBox
    Friend WithEvents cbSintoma4 As ComboBox
    Friend WithEvents cbSintoma7 As ComboBox
    Friend WithEvents cbSintoma1 As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtDom As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkDom As CheckBox
    Friend WithEvents chkSab As CheckBox
    Friend WithEvents chkVier As CheckBox
    Friend WithEvents chkJuev As CheckBox
    Friend WithEvents chkMier As CheckBox
    Friend WithEvents chkMar As CheckBox
    Friend WithEvents chkLun As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtHoraEntradaDomingo As TextBox
    Friend WithEvents txtHoraEntradaSabado As TextBox
    Friend WithEvents txtHoraEntradaViernes As TextBox
    Friend WithEvents txtHoraEntradaMiercoles As TextBox
    Friend WithEvents txtHoraEntradaJueves As TextBox
    Friend WithEvents txtHoraEntradaMartes As TextBox
    Friend WithEvents txtHoraEntradaLunes As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents cbEsp As ComboBox
End Class
