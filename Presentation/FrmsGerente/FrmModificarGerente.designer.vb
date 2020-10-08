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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.modificar = New System.Windows.Forms.Label()
        Me.DgvDatos = New System.Windows.Forms.DataGridView()
        Me.modifAclaracion = New System.Windows.Forms.Label()
        Me.PanelModSintoma = New System.Windows.Forms.Panel()
        Me.txtNombreSintoma = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbNomSint = New System.Windows.Forms.Label()
        Me.PanelModEnfermedad = New System.Windows.Forms.Panel()
        Me.groupBoxSintomas = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cbSintoma6 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma8 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma5 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma7 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma4 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.chb7 = New System.Windows.Forms.CheckBox()
        Me.chb6 = New System.Windows.Forms.CheckBox()
        Me.chb5 = New System.Windows.Forms.CheckBox()
        Me.chb4 = New System.Windows.Forms.CheckBox()
        Me.chb3 = New System.Windows.Forms.CheckBox()
        Me.chb2 = New System.Windows.Forms.CheckBox()
        Me.chb1 = New System.Windows.Forms.CheckBox()
        Me.txtDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbRiesgo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtNombreEnfermedad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.lbRiesgo = New System.Windows.Forms.Label()
        Me.lbNomEnf = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbFiltro = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_modificar = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelModifMedico = New System.Windows.Forms.Panel()
        Me.Persona_sNom = New System.Windows.Forms.Label()
        Me.txtSnom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Persona_domicilio = New System.Windows.Forms.Label()
        Me.Persona_numMed = New System.Windows.Forms.Label()
        Me.Persona_edad = New System.Windows.Forms.Label()
        Me.Persona_tel = New System.Windows.Forms.Label()
        Me.Persona_sApe = New System.Windows.Forms.Label()
        Me.Persona_sexo = New System.Windows.Forms.Label()
        Me.Persona_lugarTrabajo = New System.Windows.Forms.Label()
        Me.Persona_pApe = New System.Windows.Forms.Label()
        Me.Persona_especialidad = New System.Windows.Forms.Label()
        Me.Persona_pNom = New System.Windows.Forms.Label()
        Me.Persona_ci = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkDom = New System.Windows.Forms.CheckBox()
        Me.chkJuev = New System.Windows.Forms.CheckBox()
        Me.chkSab = New System.Windows.Forms.CheckBox()
        Me.chkMier = New System.Windows.Forms.CheckBox()
        Me.chkMar = New System.Windows.Forms.CheckBox()
        Me.chkVier = New System.Windows.Forms.CheckBox()
        Me.chkLun = New System.Windows.Forms.CheckBox()
        Me.Jue = New System.Windows.Forms.Label()
        Me.txtHoraEntradaDomingo = New System.Windows.Forms.TextBox()
        Me.Sab = New System.Windows.Forms.Label()
        Me.txtHoraEntradaSabado = New System.Windows.Forms.TextBox()
        Me.Dom = New System.Windows.Forms.Label()
        Me.txtHoraEntradaViernes = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaMiercoles = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaJueves = New System.Windows.Forms.TextBox()
        Me.Vie = New System.Windows.Forms.Label()
        Me.txtHoraEntradaMartes = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaLunes = New System.Windows.Forms.TextBox()
        Me.Mie = New System.Windows.Forms.Label()
        Me.Mar = New System.Windows.Forms.Label()
        Me.Lun = New System.Windows.Forms.Label()
        Me.horaEjemplo = New System.Windows.Forms.Label()
        Me.Mhora = New System.Windows.Forms.Label()
        Me.cbSexo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbEsp = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtDomicilio = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEdad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNumMed = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSape = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPape = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLugarTrabajo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPNom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCedula = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelModSintoma.SuspendLayout()
        Me.PanelModEnfermedad.SuspendLayout()
        Me.groupBoxSintomas.SuspendLayout()
        Me.PanelModifMedico.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'modificar
        '
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Default
        Me.modificar.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.ForeColor = System.Drawing.Color.Silver
        Me.modificar.Location = New System.Drawing.Point(1, 9)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(775, 40)
        Me.modificar.TabIndex = 5
        Me.modificar.Text = "MODIFICAR"
        Me.modificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DgvDatos
        '
        Me.DgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.DgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDatos.ColumnHeadersHeight = 30
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDatos.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDatos.EnableHeadersVisualStyles = False
        Me.DgvDatos.GridColor = System.Drawing.Color.SteelBlue
        Me.DgvDatos.Location = New System.Drawing.Point(12, 66)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvDatos.Size = New System.Drawing.Size(748, 141)
        Me.DgvDatos.TabIndex = 6
        '
        'modifAclaracion
        '
        Me.modifAclaracion.AutoSize = True
        Me.modifAclaracion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifAclaracion.ForeColor = System.Drawing.Color.Silver
        Me.modifAclaracion.Location = New System.Drawing.Point(13, 46)
        Me.modifAclaracion.Name = "modifAclaracion"
        Me.modifAclaracion.Size = New System.Drawing.Size(337, 17)
        Me.modifAclaracion.TabIndex = 4
        Me.modifAclaracion.Text = "Haga doble click en una celda para seleccionar el elemento"
        '
        'PanelModSintoma
        '
        Me.PanelModSintoma.Controls.Add(Me.txtNombreSintoma)
        Me.PanelModSintoma.Controls.Add(Me.lbNomSint)
        Me.PanelModSintoma.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelModSintoma.Location = New System.Drawing.Point(17, 285)
        Me.PanelModSintoma.Name = "PanelModSintoma"
        Me.PanelModSintoma.Size = New System.Drawing.Size(498, 77)
        Me.PanelModSintoma.TabIndex = 10
        Me.PanelModSintoma.Visible = False
        '
        'txtNombreSintoma
        '
        Me.txtNombreSintoma.Animated = True
        Me.txtNombreSintoma.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreSintoma.BorderRadius = 10
        Me.txtNombreSintoma.BorderThickness = 2
        Me.txtNombreSintoma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreSintoma.DefaultText = ""
        Me.txtNombreSintoma.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombreSintoma.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombreSintoma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreSintoma.DisabledState.Parent = Me.txtNombreSintoma
        Me.txtNombreSintoma.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreSintoma.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNombreSintoma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNombreSintoma.FocusedState.Parent = Me.txtNombreSintoma
        Me.txtNombreSintoma.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreSintoma.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtNombreSintoma.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNombreSintoma.HoverState.Parent = Me.txtNombreSintoma
        Me.txtNombreSintoma.Location = New System.Drawing.Point(7, 31)
        Me.txtNombreSintoma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombreSintoma.Name = "txtNombreSintoma"
        Me.txtNombreSintoma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreSintoma.PlaceholderText = ""
        Me.txtNombreSintoma.SelectedText = ""
        Me.txtNombreSintoma.ShadowDecoration.BorderRadius = 10
        Me.txtNombreSintoma.ShadowDecoration.Parent = Me.txtNombreSintoma
        Me.txtNombreSintoma.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.txtNombreSintoma.Size = New System.Drawing.Size(474, 30)
        Me.txtNombreSintoma.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtNombreSintoma.TabIndex = 55
        '
        'lbNomSint
        '
        Me.lbNomSint.AutoSize = True
        Me.lbNomSint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomSint.ForeColor = System.Drawing.Color.Silver
        Me.lbNomSint.Location = New System.Drawing.Point(3, 5)
        Me.lbNomSint.Name = "lbNomSint"
        Me.lbNomSint.Size = New System.Drawing.Size(68, 21)
        Me.lbNomSint.TabIndex = 4
        Me.lbNomSint.Text = "Nombre"
        '
        'PanelModEnfermedad
        '
        Me.PanelModEnfermedad.Controls.Add(Me.groupBoxSintomas)
        Me.PanelModEnfermedad.Controls.Add(Me.txtDescripcion)
        Me.PanelModEnfermedad.Controls.Add(Me.cbRiesgo)
        Me.PanelModEnfermedad.Controls.Add(Me.txtNombreEnfermedad)
        Me.PanelModEnfermedad.Controls.Add(Me.lbDescripcion)
        Me.PanelModEnfermedad.Controls.Add(Me.lbRiesgo)
        Me.PanelModEnfermedad.Controls.Add(Me.lbNomEnf)
        Me.PanelModEnfermedad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelModEnfermedad.Location = New System.Drawing.Point(12, 285)
        Me.PanelModEnfermedad.Name = "PanelModEnfermedad"
        Me.PanelModEnfermedad.Size = New System.Drawing.Size(748, 384)
        Me.PanelModEnfermedad.TabIndex = 11
        Me.PanelModEnfermedad.Visible = False
        '
        'groupBoxSintomas
        '
        Me.groupBoxSintomas.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.groupBoxSintomas.BorderThickness = 2
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma6)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma8)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma5)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma7)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma3)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma4)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma2)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma1)
        Me.groupBoxSintomas.Controls.Add(Me.chb7)
        Me.groupBoxSintomas.Controls.Add(Me.chb6)
        Me.groupBoxSintomas.Controls.Add(Me.chb5)
        Me.groupBoxSintomas.Controls.Add(Me.chb4)
        Me.groupBoxSintomas.Controls.Add(Me.chb3)
        Me.groupBoxSintomas.Controls.Add(Me.chb2)
        Me.groupBoxSintomas.Controls.Add(Me.chb1)
        Me.groupBoxSintomas.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.groupBoxSintomas.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.groupBoxSintomas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxSintomas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.groupBoxSintomas.Location = New System.Drawing.Point(12, 138)
        Me.groupBoxSintomas.Name = "groupBoxSintomas"
        Me.groupBoxSintomas.ShadowDecoration.Parent = Me.groupBoxSintomas
        Me.groupBoxSintomas.Size = New System.Drawing.Size(627, 229)
        Me.groupBoxSintomas.TabIndex = 65
        Me.groupBoxSintomas.Text = "RELACIONADOS"
        '
        'cbSintoma6
        '
        Me.cbSintoma6.Animated = True
        Me.cbSintoma6.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma6.Enabled = False
        Me.cbSintoma6.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma6.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma6.FocusedState.Parent = Me.cbSintoma6
        Me.cbSintoma6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma6.ForeColor = System.Drawing.Color.White
        Me.cbSintoma6.FormattingEnabled = True
        Me.cbSintoma6.HoverState.Parent = Me.cbSintoma6
        Me.cbSintoma6.ItemHeight = 30
        Me.cbSintoma6.ItemsAppearance.Parent = Me.cbSintoma6
        Me.cbSintoma6.Location = New System.Drawing.Point(439, 108)
        Me.cbSintoma6.Name = "cbSintoma6"
        Me.cbSintoma6.ShadowDecoration.Parent = Me.cbSintoma6
        Me.cbSintoma6.Size = New System.Drawing.Size(170, 36)
        Me.cbSintoma6.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma6.TabIndex = 45
        '
        'cbSintoma8
        '
        Me.cbSintoma8.Animated = True
        Me.cbSintoma8.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma8.Enabled = False
        Me.cbSintoma8.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma8.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma8.FocusedState.Parent = Me.cbSintoma8
        Me.cbSintoma8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma8.ForeColor = System.Drawing.Color.White
        Me.cbSintoma8.FormattingEnabled = True
        Me.cbSintoma8.HoverState.Parent = Me.cbSintoma8
        Me.cbSintoma8.ItemHeight = 30
        Me.cbSintoma8.ItemsAppearance.Parent = Me.cbSintoma8
        Me.cbSintoma8.Location = New System.Drawing.Point(240, 169)
        Me.cbSintoma8.Name = "cbSintoma8"
        Me.cbSintoma8.ShadowDecoration.Parent = Me.cbSintoma8
        Me.cbSintoma8.Size = New System.Drawing.Size(170, 36)
        Me.cbSintoma8.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma8.TabIndex = 46
        '
        'cbSintoma5
        '
        Me.cbSintoma5.Animated = True
        Me.cbSintoma5.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma5.Enabled = False
        Me.cbSintoma5.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma5.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma5.FocusedState.Parent = Me.cbSintoma5
        Me.cbSintoma5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma5.ForeColor = System.Drawing.Color.White
        Me.cbSintoma5.FormattingEnabled = True
        Me.cbSintoma5.HoverState.Parent = Me.cbSintoma5
        Me.cbSintoma5.ItemHeight = 30
        Me.cbSintoma5.ItemsAppearance.Parent = Me.cbSintoma5
        Me.cbSintoma5.Location = New System.Drawing.Point(240, 108)
        Me.cbSintoma5.Name = "cbSintoma5"
        Me.cbSintoma5.ShadowDecoration.Parent = Me.cbSintoma5
        Me.cbSintoma5.Size = New System.Drawing.Size(170, 36)
        Me.cbSintoma5.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma5.TabIndex = 47
        '
        'cbSintoma7
        '
        Me.cbSintoma7.Animated = True
        Me.cbSintoma7.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma7.Enabled = False
        Me.cbSintoma7.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma7.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma7.FocusedState.Parent = Me.cbSintoma7
        Me.cbSintoma7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma7.ForeColor = System.Drawing.Color.White
        Me.cbSintoma7.FormattingEnabled = True
        Me.cbSintoma7.HoverState.Parent = Me.cbSintoma7
        Me.cbSintoma7.ItemHeight = 30
        Me.cbSintoma7.ItemsAppearance.Parent = Me.cbSintoma7
        Me.cbSintoma7.Location = New System.Drawing.Point(35, 169)
        Me.cbSintoma7.Name = "cbSintoma7"
        Me.cbSintoma7.ShadowDecoration.Parent = Me.cbSintoma7
        Me.cbSintoma7.Size = New System.Drawing.Size(170, 36)
        Me.cbSintoma7.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma7.TabIndex = 48
        '
        'cbSintoma3
        '
        Me.cbSintoma3.Animated = True
        Me.cbSintoma3.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma3.Enabled = False
        Me.cbSintoma3.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma3.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma3.FocusedState.Parent = Me.cbSintoma3
        Me.cbSintoma3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma3.ForeColor = System.Drawing.Color.White
        Me.cbSintoma3.FormattingEnabled = True
        Me.cbSintoma3.HoverState.Parent = Me.cbSintoma3
        Me.cbSintoma3.ItemHeight = 30
        Me.cbSintoma3.ItemsAppearance.Parent = Me.cbSintoma3
        Me.cbSintoma3.Location = New System.Drawing.Point(439, 49)
        Me.cbSintoma3.Name = "cbSintoma3"
        Me.cbSintoma3.ShadowDecoration.Parent = Me.cbSintoma3
        Me.cbSintoma3.Size = New System.Drawing.Size(170, 36)
        Me.cbSintoma3.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma3.TabIndex = 49
        '
        'cbSintoma4
        '
        Me.cbSintoma4.Animated = True
        Me.cbSintoma4.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma4.Enabled = False
        Me.cbSintoma4.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma4.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma4.FocusedState.Parent = Me.cbSintoma4
        Me.cbSintoma4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma4.ForeColor = System.Drawing.Color.White
        Me.cbSintoma4.FormattingEnabled = True
        Me.cbSintoma4.HoverState.Parent = Me.cbSintoma4
        Me.cbSintoma4.ItemHeight = 30
        Me.cbSintoma4.ItemsAppearance.Parent = Me.cbSintoma4
        Me.cbSintoma4.Location = New System.Drawing.Point(35, 108)
        Me.cbSintoma4.Name = "cbSintoma4"
        Me.cbSintoma4.ShadowDecoration.Parent = Me.cbSintoma4
        Me.cbSintoma4.Size = New System.Drawing.Size(170, 36)
        Me.cbSintoma4.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma4.TabIndex = 50
        '
        'cbSintoma2
        '
        Me.cbSintoma2.Animated = True
        Me.cbSintoma2.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma2.Enabled = False
        Me.cbSintoma2.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma2.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma2.FocusedState.Parent = Me.cbSintoma2
        Me.cbSintoma2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma2.ForeColor = System.Drawing.Color.White
        Me.cbSintoma2.FormattingEnabled = True
        Me.cbSintoma2.HoverState.Parent = Me.cbSintoma2
        Me.cbSintoma2.ItemHeight = 30
        Me.cbSintoma2.ItemsAppearance.Parent = Me.cbSintoma2
        Me.cbSintoma2.Location = New System.Drawing.Point(240, 49)
        Me.cbSintoma2.Name = "cbSintoma2"
        Me.cbSintoma2.ShadowDecoration.Parent = Me.cbSintoma2
        Me.cbSintoma2.Size = New System.Drawing.Size(170, 36)
        Me.cbSintoma2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma2.TabIndex = 51
        '
        'cbSintoma1
        '
        Me.cbSintoma1.Animated = True
        Me.cbSintoma1.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma1.BorderThickness = 0
        Me.cbSintoma1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma1.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma1.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma1.FocusedState.Parent = Me.cbSintoma1
        Me.cbSintoma1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma1.ForeColor = System.Drawing.Color.White
        Me.cbSintoma1.FormattingEnabled = True
        Me.cbSintoma1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.cbSintoma1.HoverState.Parent = Me.cbSintoma1
        Me.cbSintoma1.ItemHeight = 30
        Me.cbSintoma1.ItemsAppearance.Parent = Me.cbSintoma1
        Me.cbSintoma1.Location = New System.Drawing.Point(35, 49)
        Me.cbSintoma1.Name = "cbSintoma1"
        Me.cbSintoma1.ShadowDecoration.Parent = Me.cbSintoma1
        Me.cbSintoma1.Size = New System.Drawing.Size(170, 36)
        Me.cbSintoma1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma1.TabIndex = 52
        Me.cbSintoma1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chb7
        '
        Me.chb7.AutoSize = True
        Me.chb7.Location = New System.Drawing.Point(219, 180)
        Me.chb7.Name = "chb7"
        Me.chb7.Size = New System.Drawing.Size(15, 14)
        Me.chb7.TabIndex = 38
        Me.chb7.UseVisualStyleBackColor = True
        '
        'chb6
        '
        Me.chb6.AutoSize = True
        Me.chb6.Location = New System.Drawing.Point(14, 180)
        Me.chb6.Name = "chb6"
        Me.chb6.Size = New System.Drawing.Size(15, 14)
        Me.chb6.TabIndex = 39
        Me.chb6.UseVisualStyleBackColor = True
        '
        'chb5
        '
        Me.chb5.AutoSize = True
        Me.chb5.Location = New System.Drawing.Point(423, 119)
        Me.chb5.Name = "chb5"
        Me.chb5.Size = New System.Drawing.Size(15, 14)
        Me.chb5.TabIndex = 40
        Me.chb5.UseVisualStyleBackColor = True
        '
        'chb4
        '
        Me.chb4.AutoSize = True
        Me.chb4.Location = New System.Drawing.Point(219, 119)
        Me.chb4.Name = "chb4"
        Me.chb4.Size = New System.Drawing.Size(15, 14)
        Me.chb4.TabIndex = 41
        Me.chb4.UseVisualStyleBackColor = True
        '
        'chb3
        '
        Me.chb3.AutoSize = True
        Me.chb3.Location = New System.Drawing.Point(14, 119)
        Me.chb3.Name = "chb3"
        Me.chb3.Size = New System.Drawing.Size(15, 14)
        Me.chb3.TabIndex = 42
        Me.chb3.UseVisualStyleBackColor = True
        '
        'chb2
        '
        Me.chb2.AutoSize = True
        Me.chb2.Location = New System.Drawing.Point(423, 60)
        Me.chb2.Name = "chb2"
        Me.chb2.Size = New System.Drawing.Size(15, 14)
        Me.chb2.TabIndex = 43
        Me.chb2.UseVisualStyleBackColor = True
        '
        'chb1
        '
        Me.chb1.AutoSize = True
        Me.chb1.Location = New System.Drawing.Point(219, 60)
        Me.chb1.Name = "chb1"
        Me.chb1.Size = New System.Drawing.Size(15, 14)
        Me.chb1.TabIndex = 44
        Me.chb1.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Animated = True
        Me.txtDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.txtDescripcion.BorderRadius = 10
        Me.txtDescripcion.BorderThickness = 2
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion.DefaultText = ""
        Me.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescripcion.DisabledState.Parent = Me.txtDescripcion
        Me.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescripcion.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtDescripcion.FocusedState.Parent = Me.txtDescripcion
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtDescripcion.HoverState.Parent = Me.txtDescripcion
        Me.txtDescripcion.Location = New System.Drawing.Point(10, 100)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.PlaceholderText = ""
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.ShadowDecoration.BorderRadius = 10
        Me.txtDescripcion.ShadowDecoration.Parent = Me.txtDescripcion
        Me.txtDescripcion.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.txtDescripcion.Size = New System.Drawing.Size(380, 30)
        Me.txtDescripcion.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtDescripcion.TabIndex = 63
        '
        'cbRiesgo
        '
        Me.cbRiesgo.Animated = True
        Me.cbRiesgo.BackColor = System.Drawing.Color.Transparent
        Me.cbRiesgo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbRiesgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRiesgo.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbRiesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRiesgo.FocusedColor = System.Drawing.Color.Empty
        Me.cbRiesgo.FocusedState.Parent = Me.cbRiesgo
        Me.cbRiesgo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbRiesgo.ForeColor = System.Drawing.Color.White
        Me.cbRiesgo.FormattingEnabled = True
        Me.cbRiesgo.HoverState.Parent = Me.cbRiesgo
        Me.cbRiesgo.ItemHeight = 30
        Me.cbRiesgo.Items.AddRange(New Object() {"Azul", "verde", "amarillo", "naranja", "Rojo"})
        Me.cbRiesgo.ItemsAppearance.Parent = Me.cbRiesgo
        Me.cbRiesgo.Location = New System.Drawing.Point(419, 32)
        Me.cbRiesgo.Name = "cbRiesgo"
        Me.cbRiesgo.ShadowDecoration.Parent = Me.cbRiesgo
        Me.cbRiesgo.Size = New System.Drawing.Size(170, 36)
        Me.cbRiesgo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbRiesgo.TabIndex = 62
        '
        'txtNombreEnfermedad
        '
        Me.txtNombreEnfermedad.Animated = True
        Me.txtNombreEnfermedad.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreEnfermedad.BorderRadius = 10
        Me.txtNombreEnfermedad.BorderThickness = 2
        Me.txtNombreEnfermedad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreEnfermedad.DefaultText = ""
        Me.txtNombreEnfermedad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombreEnfermedad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombreEnfermedad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreEnfermedad.DisabledState.Parent = Me.txtNombreEnfermedad
        Me.txtNombreEnfermedad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreEnfermedad.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNombreEnfermedad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNombreEnfermedad.FocusedState.Parent = Me.txtNombreEnfermedad
        Me.txtNombreEnfermedad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEnfermedad.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtNombreEnfermedad.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNombreEnfermedad.HoverState.Parent = Me.txtNombreEnfermedad
        Me.txtNombreEnfermedad.Location = New System.Drawing.Point(10, 38)
        Me.txtNombreEnfermedad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombreEnfermedad.Name = "txtNombreEnfermedad"
        Me.txtNombreEnfermedad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreEnfermedad.PlaceholderText = ""
        Me.txtNombreEnfermedad.SelectedText = ""
        Me.txtNombreEnfermedad.ShadowDecoration.BorderRadius = 10
        Me.txtNombreEnfermedad.ShadowDecoration.Parent = Me.txtNombreEnfermedad
        Me.txtNombreEnfermedad.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.txtNombreEnfermedad.Size = New System.Drawing.Size(380, 30)
        Me.txtNombreEnfermedad.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtNombreEnfermedad.TabIndex = 64
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescripcion.ForeColor = System.Drawing.Color.Silver
        Me.lbDescripcion.Location = New System.Drawing.Point(10, 76)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(109, 21)
        Me.lbDescripcion.TabIndex = 59
        Me.lbDescripcion.Text = "DESCRIPCION"
        '
        'lbRiesgo
        '
        Me.lbRiesgo.AutoSize = True
        Me.lbRiesgo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRiesgo.ForeColor = System.Drawing.Color.Silver
        Me.lbRiesgo.Location = New System.Drawing.Point(422, 8)
        Me.lbRiesgo.Name = "lbRiesgo"
        Me.lbRiesgo.Size = New System.Drawing.Size(64, 21)
        Me.lbRiesgo.TabIndex = 60
        Me.lbRiesgo.Text = "RIESGO"
        '
        'lbNomEnf
        '
        Me.lbNomEnf.AutoSize = True
        Me.lbNomEnf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomEnf.ForeColor = System.Drawing.Color.Silver
        Me.lbNomEnf.Location = New System.Drawing.Point(10, 8)
        Me.lbNomEnf.Name = "lbNomEnf"
        Me.lbNomEnf.Size = New System.Drawing.Size(75, 21)
        Me.lbNomEnf.TabIndex = 61
        Me.lbNomEnf.Text = "NOMBRE"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Silver
        Me.Label20.Location = New System.Drawing.Point(16, 165)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 21)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Filtro"
        '
        'cbFiltro
        '
        Me.cbFiltro.Animated = True
        Me.cbFiltro.BackColor = System.Drawing.Color.Transparent
        Me.cbFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltro.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFiltro.FocusedColor = System.Drawing.Color.Empty
        Me.cbFiltro.FocusedState.Parent = Me.cbFiltro
        Me.cbFiltro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.HoverState.Parent = Me.cbFiltro
        Me.cbFiltro.ItemHeight = 30
        Me.cbFiltro.Items.AddRange(New Object() {"Medicos", "Enfermedades", "Sintomas"})
        Me.cbFiltro.ItemsAppearance.Parent = Me.cbFiltro
        Me.cbFiltro.Location = New System.Drawing.Point(12, 213)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.ShadowDecoration.Parent = Me.cbFiltro
        Me.cbFiltro.Size = New System.Drawing.Size(213, 36)
        Me.cbFiltro.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbFiltro.TabIndex = 49
        '
        'btn_modificar
        '
        Me.btn_modificar.Animated = True
        Me.btn_modificar.AutoRoundedCorners = True
        Me.btn_modificar.BackColor = System.Drawing.Color.Transparent
        Me.btn_modificar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_modificar.BorderRadius = 17
        Me.btn_modificar.CheckedState.Parent = Me.btn_modificar
        Me.btn_modificar.CustomImages.Parent = Me.btn_modificar
        Me.btn_modificar.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_modificar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_modificar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_modificar.HoverState.Parent = Me.btn_modificar
        Me.btn_modificar.Location = New System.Drawing.Point(582, 213)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_modificar.ShadowDecoration.BorderRadius = 20
        Me.btn_modificar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_modificar.ShadowDecoration.Depth = 15
        Me.btn_modificar.ShadowDecoration.Enabled = True
        Me.btn_modificar.ShadowDecoration.Parent = Me.btn_modificar
        Me.btn_modificar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_modificar.Size = New System.Drawing.Size(180, 36)
        Me.btn_modificar.TabIndex = 50
        Me.btn_modificar.Text = "MODIFICAR"
        '
        'PanelModifMedico
        '
        Me.PanelModifMedico.Controls.Add(Me.Persona_sNom)
        Me.PanelModifMedico.Controls.Add(Me.txtSnom)
        Me.PanelModifMedico.Controls.Add(Me.Persona_domicilio)
        Me.PanelModifMedico.Controls.Add(Me.Persona_numMed)
        Me.PanelModifMedico.Controls.Add(Me.Persona_edad)
        Me.PanelModifMedico.Controls.Add(Me.Persona_tel)
        Me.PanelModifMedico.Controls.Add(Me.Persona_sApe)
        Me.PanelModifMedico.Controls.Add(Me.Persona_sexo)
        Me.PanelModifMedico.Controls.Add(Me.Persona_lugarTrabajo)
        Me.PanelModifMedico.Controls.Add(Me.Persona_pApe)
        Me.PanelModifMedico.Controls.Add(Me.Persona_especialidad)
        Me.PanelModifMedico.Controls.Add(Me.Persona_pNom)
        Me.PanelModifMedico.Controls.Add(Me.Persona_ci)
        Me.PanelModifMedico.Controls.Add(Me.Panel1)
        Me.PanelModifMedico.Controls.Add(Me.cbSexo)
        Me.PanelModifMedico.Controls.Add(Me.cbEsp)
        Me.PanelModifMedico.Controls.Add(Me.txtDomicilio)
        Me.PanelModifMedico.Controls.Add(Me.txtEdad)
        Me.PanelModifMedico.Controls.Add(Me.txtTelefono)
        Me.PanelModifMedico.Controls.Add(Me.txtNumMed)
        Me.PanelModifMedico.Controls.Add(Me.txtSape)
        Me.PanelModifMedico.Controls.Add(Me.txtPape)
        Me.PanelModifMedico.Controls.Add(Me.txtLugarTrabajo)
        Me.PanelModifMedico.Controls.Add(Me.txtPNom)
        Me.PanelModifMedico.Controls.Add(Me.txtCedula)
        Me.PanelModifMedico.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelModifMedico.Location = New System.Drawing.Point(12, 257)
        Me.PanelModifMedico.Name = "PanelModifMedico"
        Me.PanelModifMedico.Size = New System.Drawing.Size(751, 412)
        Me.PanelModifMedico.TabIndex = 51
        Me.PanelModifMedico.Visible = False
        '
        'Persona_sNom
        '
        Me.Persona_sNom.AutoSize = True
        Me.Persona_sNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_sNom.ForeColor = System.Drawing.Color.Silver
        Me.Persona_sNom.Location = New System.Drawing.Point(509, 4)
        Me.Persona_sNom.Name = "Persona_sNom"
        Me.Persona_sNom.Size = New System.Drawing.Size(134, 21)
        Me.Persona_sNom.TabIndex = 96
        Me.Persona_sNom.Text = "Segundo Nombre"
        '
        'txtSnom
        '
        Me.txtSnom.BorderThickness = 2
        Me.txtSnom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSnom.DefaultText = ""
        Me.txtSnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSnom.DisabledState.Parent = Me.txtSnom
        Me.txtSnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSnom.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtSnom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSnom.FocusedState.Parent = Me.txtSnom
        Me.txtSnom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSnom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSnom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSnom.HoverState.Parent = Me.txtSnom
        Me.txtSnom.Location = New System.Drawing.Point(506, 27)
        Me.txtSnom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSnom.Name = "txtSnom"
        Me.txtSnom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSnom.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSnom.PlaceholderText = ""
        Me.txtSnom.SelectedText = ""
        Me.txtSnom.ShadowDecoration.Parent = Me.txtSnom
        Me.txtSnom.Size = New System.Drawing.Size(220, 30)
        Me.txtSnom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSnom.TabIndex = 95
        '
        'Persona_domicilio
        '
        Me.Persona_domicilio.AutoSize = True
        Me.Persona_domicilio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_domicilio.ForeColor = System.Drawing.Color.Silver
        Me.Persona_domicilio.Location = New System.Drawing.Point(4, 180)
        Me.Persona_domicilio.Name = "Persona_domicilio"
        Me.Persona_domicilio.Size = New System.Drawing.Size(76, 21)
        Me.Persona_domicilio.TabIndex = 83
        Me.Persona_domicilio.Text = "Domicilio"
        '
        'Persona_numMed
        '
        Me.Persona_numMed.AutoSize = True
        Me.Persona_numMed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_numMed.ForeColor = System.Drawing.Color.Silver
        Me.Persona_numMed.Location = New System.Drawing.Point(506, 182)
        Me.Persona_numMed.Name = "Persona_numMed"
        Me.Persona_numMed.Size = New System.Drawing.Size(123, 21)
        Me.Persona_numMed.TabIndex = 84
        Me.Persona_numMed.Text = "Numero Medico"
        '
        'Persona_edad
        '
        Me.Persona_edad.AutoSize = True
        Me.Persona_edad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_edad.ForeColor = System.Drawing.Color.Silver
        Me.Persona_edad.Location = New System.Drawing.Point(246, 120)
        Me.Persona_edad.Name = "Persona_edad"
        Me.Persona_edad.Size = New System.Drawing.Size(44, 21)
        Me.Persona_edad.TabIndex = 85
        Me.Persona_edad.Text = "Edad"
        '
        'Persona_tel
        '
        Me.Persona_tel.AutoSize = True
        Me.Persona_tel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_tel.ForeColor = System.Drawing.Color.Silver
        Me.Persona_tel.Location = New System.Drawing.Point(506, 120)
        Me.Persona_tel.Name = "Persona_tel"
        Me.Persona_tel.Size = New System.Drawing.Size(68, 21)
        Me.Persona_tel.TabIndex = 86
        Me.Persona_tel.Text = "Telefono"
        '
        'Persona_sApe
        '
        Me.Persona_sApe.AutoSize = True
        Me.Persona_sApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_sApe.ForeColor = System.Drawing.Color.Silver
        Me.Persona_sApe.Location = New System.Drawing.Point(509, 60)
        Me.Persona_sApe.Name = "Persona_sApe"
        Me.Persona_sApe.Size = New System.Drawing.Size(133, 21)
        Me.Persona_sApe.TabIndex = 87
        Me.Persona_sApe.Text = "Segundo Apellido"
        '
        'Persona_sexo
        '
        Me.Persona_sexo.AutoSize = True
        Me.Persona_sexo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_sexo.ForeColor = System.Drawing.Color.Silver
        Me.Persona_sexo.Location = New System.Drawing.Point(4, 120)
        Me.Persona_sexo.Name = "Persona_sexo"
        Me.Persona_sexo.Size = New System.Drawing.Size(43, 21)
        Me.Persona_sexo.TabIndex = 89
        Me.Persona_sexo.Text = "Sexo"
        '
        'Persona_lugarTrabajo
        '
        Me.Persona_lugarTrabajo.AutoSize = True
        Me.Persona_lugarTrabajo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_lugarTrabajo.ForeColor = System.Drawing.Color.Silver
        Me.Persona_lugarTrabajo.Location = New System.Drawing.Point(4, 241)
        Me.Persona_lugarTrabajo.Name = "Persona_lugarTrabajo"
        Me.Persona_lugarTrabajo.Size = New System.Drawing.Size(126, 21)
        Me.Persona_lugarTrabajo.TabIndex = 90
        Me.Persona_lugarTrabajo.Text = "Lugar de Trabajo"
        '
        'Persona_pApe
        '
        Me.Persona_pApe.AutoSize = True
        Me.Persona_pApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_pApe.ForeColor = System.Drawing.Color.Silver
        Me.Persona_pApe.Location = New System.Drawing.Point(246, 63)
        Me.Persona_pApe.Name = "Persona_pApe"
        Me.Persona_pApe.Size = New System.Drawing.Size(118, 21)
        Me.Persona_pApe.TabIndex = 91
        Me.Persona_pApe.Text = "Primer Apellido"
        '
        'Persona_especialidad
        '
        Me.Persona_especialidad.AutoSize = True
        Me.Persona_especialidad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_especialidad.ForeColor = System.Drawing.Color.Silver
        Me.Persona_especialidad.Location = New System.Drawing.Point(6, 60)
        Me.Persona_especialidad.Name = "Persona_especialidad"
        Me.Persona_especialidad.Size = New System.Drawing.Size(109, 21)
        Me.Persona_especialidad.TabIndex = 92
        Me.Persona_especialidad.Text = "Especialidad"
        '
        'Persona_pNom
        '
        Me.Persona_pNom.AutoSize = True
        Me.Persona_pNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_pNom.ForeColor = System.Drawing.Color.Silver
        Me.Persona_pNom.Location = New System.Drawing.Point(246, 1)
        Me.Persona_pNom.Name = "Persona_pNom"
        Me.Persona_pNom.Size = New System.Drawing.Size(119, 21)
        Me.Persona_pNom.TabIndex = 93
        Me.Persona_pNom.Text = "Primer Nombre"
        '
        'Persona_ci
        '
        Me.Persona_ci.AutoSize = True
        Me.Persona_ci.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_ci.ForeColor = System.Drawing.Color.Silver
        Me.Persona_ci.Location = New System.Drawing.Point(7, 1)
        Me.Persona_ci.Name = "Persona_ci"
        Me.Persona_ci.Size = New System.Drawing.Size(58, 21)
        Me.Persona_ci.TabIndex = 94
        Me.Persona_ci.Text = "Cedula"
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
        Me.Panel1.Controls.Add(Me.Jue)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaDomingo)
        Me.Panel1.Controls.Add(Me.Sab)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaSabado)
        Me.Panel1.Controls.Add(Me.Dom)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaViernes)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaMiercoles)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaJueves)
        Me.Panel1.Controls.Add(Me.Vie)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaMartes)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaLunes)
        Me.Panel1.Controls.Add(Me.Mie)
        Me.Panel1.Controls.Add(Me.Mar)
        Me.Panel1.Controls.Add(Me.Lun)
        Me.Panel1.Controls.Add(Me.horaEjemplo)
        Me.Panel1.Controls.Add(Me.Mhora)
        Me.Panel1.Location = New System.Drawing.Point(2, 297)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 112)
        Me.Panel1.TabIndex = 82
        '
        'chkDom
        '
        Me.chkDom.AutoSize = True
        Me.chkDom.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkDom.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDom.ForeColor = System.Drawing.Color.Silver
        Me.chkDom.Location = New System.Drawing.Point(690, 28)
        Me.chkDom.Name = "chkDom"
        Me.chkDom.Size = New System.Drawing.Size(15, 14)
        Me.chkDom.TabIndex = 4
        Me.chkDom.UseVisualStyleBackColor = False
        '
        'chkJuev
        '
        Me.chkJuev.AutoSize = True
        Me.chkJuev.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkJuev.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJuev.ForeColor = System.Drawing.Color.Silver
        Me.chkJuev.Location = New System.Drawing.Point(387, 28)
        Me.chkJuev.Name = "chkJuev"
        Me.chkJuev.Size = New System.Drawing.Size(15, 14)
        Me.chkJuev.TabIndex = 4
        Me.chkJuev.UseVisualStyleBackColor = False
        '
        'chkSab
        '
        Me.chkSab.AutoSize = True
        Me.chkSab.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkSab.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSab.ForeColor = System.Drawing.Color.Silver
        Me.chkSab.Location = New System.Drawing.Point(585, 28)
        Me.chkSab.Name = "chkSab"
        Me.chkSab.Size = New System.Drawing.Size(15, 14)
        Me.chkSab.TabIndex = 4
        Me.chkSab.UseVisualStyleBackColor = False
        '
        'chkMier
        '
        Me.chkMier.AutoSize = True
        Me.chkMier.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkMier.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMier.ForeColor = System.Drawing.Color.Silver
        Me.chkMier.Location = New System.Drawing.Point(282, 28)
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
        Me.chkMar.Location = New System.Drawing.Point(198, 28)
        Me.chkMar.Name = "chkMar"
        Me.chkMar.Size = New System.Drawing.Size(15, 14)
        Me.chkMar.TabIndex = 4
        Me.chkMar.UseVisualStyleBackColor = False
        '
        'chkVier
        '
        Me.chkVier.AutoSize = True
        Me.chkVier.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkVier.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVier.ForeColor = System.Drawing.Color.Silver
        Me.chkVier.Location = New System.Drawing.Point(487, 28)
        Me.chkVier.Name = "chkVier"
        Me.chkVier.Size = New System.Drawing.Size(15, 14)
        Me.chkVier.TabIndex = 4
        Me.chkVier.UseVisualStyleBackColor = False
        '
        'chkLun
        '
        Me.chkLun.AutoSize = True
        Me.chkLun.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkLun.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLun.ForeColor = System.Drawing.Color.Silver
        Me.chkLun.Location = New System.Drawing.Point(98, 28)
        Me.chkLun.Name = "chkLun"
        Me.chkLun.Size = New System.Drawing.Size(15, 14)
        Me.chkLun.TabIndex = 4
        Me.chkLun.UseVisualStyleBackColor = False
        '
        'Jue
        '
        Me.Jue.AutoSize = True
        Me.Jue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jue.ForeColor = System.Drawing.Color.Silver
        Me.Jue.Location = New System.Drawing.Point(366, 4)
        Me.Jue.Name = "Jue"
        Me.Jue.Size = New System.Drawing.Size(56, 21)
        Me.Jue.TabIndex = 0
        Me.Jue.Text = "Jueves"
        '
        'txtHoraEntradaDomingo
        '
        Me.txtHoraEntradaDomingo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaDomingo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaDomingo.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaDomingo.Location = New System.Drawing.Point(654, 43)
        Me.txtHoraEntradaDomingo.MaxLength = 12
        Me.txtHoraEntradaDomingo.Name = "txtHoraEntradaDomingo"
        Me.txtHoraEntradaDomingo.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaDomingo.TabIndex = 1
        '
        'Sab
        '
        Me.Sab.AutoSize = True
        Me.Sab.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sab.ForeColor = System.Drawing.Color.Silver
        Me.Sab.Location = New System.Drawing.Point(561, 5)
        Me.Sab.Name = "Sab"
        Me.Sab.Size = New System.Drawing.Size(62, 21)
        Me.Sab.TabIndex = 0
        Me.Sab.Text = "Sabado"
        '
        'txtHoraEntradaSabado
        '
        Me.txtHoraEntradaSabado.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaSabado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaSabado.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaSabado.Location = New System.Drawing.Point(556, 43)
        Me.txtHoraEntradaSabado.MaxLength = 12
        Me.txtHoraEntradaSabado.Name = "txtHoraEntradaSabado"
        Me.txtHoraEntradaSabado.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaSabado.TabIndex = 1
        '
        'Dom
        '
        Me.Dom.AutoSize = True
        Me.Dom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dom.ForeColor = System.Drawing.Color.Silver
        Me.Dom.Location = New System.Drawing.Point(660, 5)
        Me.Dom.Name = "Dom"
        Me.Dom.Size = New System.Drawing.Size(75, 21)
        Me.Dom.TabIndex = 0
        Me.Dom.Text = "Domingo"
        '
        'txtHoraEntradaViernes
        '
        Me.txtHoraEntradaViernes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaViernes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaViernes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaViernes.Location = New System.Drawing.Point(458, 43)
        Me.txtHoraEntradaViernes.MaxLength = 12
        Me.txtHoraEntradaViernes.Name = "txtHoraEntradaViernes"
        Me.txtHoraEntradaViernes.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaViernes.TabIndex = 1
        '
        'txtHoraEntradaMiercoles
        '
        Me.txtHoraEntradaMiercoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaMiercoles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaMiercoles.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaMiercoles.Location = New System.Drawing.Point(262, 43)
        Me.txtHoraEntradaMiercoles.MaxLength = 12
        Me.txtHoraEntradaMiercoles.Name = "txtHoraEntradaMiercoles"
        Me.txtHoraEntradaMiercoles.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaMiercoles.TabIndex = 1
        '
        'txtHoraEntradaJueves
        '
        Me.txtHoraEntradaJueves.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaJueves.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaJueves.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaJueves.Location = New System.Drawing.Point(360, 43)
        Me.txtHoraEntradaJueves.MaxLength = 12
        Me.txtHoraEntradaJueves.Name = "txtHoraEntradaJueves"
        Me.txtHoraEntradaJueves.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaJueves.TabIndex = 1
        '
        'Vie
        '
        Me.Vie.AutoSize = True
        Me.Vie.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vie.ForeColor = System.Drawing.Color.Silver
        Me.Vie.Location = New System.Drawing.Point(463, 4)
        Me.Vie.Name = "Vie"
        Me.Vie.Size = New System.Drawing.Size(62, 21)
        Me.Vie.TabIndex = 0
        Me.Vie.Text = "Viernes"
        '
        'txtHoraEntradaMartes
        '
        Me.txtHoraEntradaMartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaMartes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaMartes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaMartes.Location = New System.Drawing.Point(164, 43)
        Me.txtHoraEntradaMartes.MaxLength = 12
        Me.txtHoraEntradaMartes.Name = "txtHoraEntradaMartes"
        Me.txtHoraEntradaMartes.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaMartes.TabIndex = 1
        '
        'txtHoraEntradaLunes
        '
        Me.txtHoraEntradaLunes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaLunes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaLunes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaLunes.Location = New System.Drawing.Point(66, 43)
        Me.txtHoraEntradaLunes.MaxLength = 12
        Me.txtHoraEntradaLunes.Name = "txtHoraEntradaLunes"
        Me.txtHoraEntradaLunes.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaLunes.TabIndex = 1
        '
        'Mie
        '
        Me.Mie.AutoSize = True
        Me.Mie.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mie.ForeColor = System.Drawing.Color.Silver
        Me.Mie.Location = New System.Drawing.Point(251, 4)
        Me.Mie.Name = "Mie"
        Me.Mie.Size = New System.Drawing.Size(77, 21)
        Me.Mie.TabIndex = 0
        Me.Mie.Text = "Miercoles"
        '
        'Mar
        '
        Me.Mar.AutoSize = True
        Me.Mar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mar.ForeColor = System.Drawing.Color.Silver
        Me.Mar.Location = New System.Drawing.Point(176, 4)
        Me.Mar.Name = "Mar"
        Me.Mar.Size = New System.Drawing.Size(58, 21)
        Me.Mar.TabIndex = 0
        Me.Mar.Text = "Martes"
        '
        'Lun
        '
        Me.Lun.AutoSize = True
        Me.Lun.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lun.ForeColor = System.Drawing.Color.Silver
        Me.Lun.Location = New System.Drawing.Point(80, 5)
        Me.Lun.Name = "Lun"
        Me.Lun.Size = New System.Drawing.Size(51, 21)
        Me.Lun.TabIndex = 0
        Me.Lun.Text = "Lunes"
        '
        'horaEjemplo
        '
        Me.horaEjemplo.AutoSize = True
        Me.horaEjemplo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaEjemplo.ForeColor = System.Drawing.Color.Silver
        Me.horaEjemplo.Location = New System.Drawing.Point(7, 73)
        Me.horaEjemplo.Name = "horaEjemplo"
        Me.horaEjemplo.Size = New System.Drawing.Size(168, 21)
        Me.horaEjemplo.TabIndex = 0
        Me.horaEjemplo.Text = "Ejemplo: 09:00 a 19:30"
        '
        'Mhora
        '
        Me.Mhora.AutoSize = True
        Me.Mhora.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mhora.ForeColor = System.Drawing.Color.Silver
        Me.Mhora.Location = New System.Drawing.Point(9, 43)
        Me.Mhora.Name = "Mhora"
        Me.Mhora.Size = New System.Drawing.Size(44, 21)
        Me.Mhora.TabIndex = 0
        Me.Mhora.Text = "Hora"
        '
        'cbSexo
        '
        Me.cbSexo.Animated = True
        Me.cbSexo.BackColor = System.Drawing.Color.Transparent
        Me.cbSexo.BorderThickness = 2
        Me.cbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSexo.FocusedColor = System.Drawing.Color.Empty
        Me.cbSexo.FocusedState.Parent = Me.cbSexo
        Me.cbSexo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.HoverState.Parent = Me.cbSexo
        Me.cbSexo.ItemHeight = 30
        Me.cbSexo.Items.AddRange(New Object() {"Hombre", "Mujer", "Otro"})
        Me.cbSexo.ItemsAppearance.Parent = Me.cbSexo
        Me.cbSexo.Location = New System.Drawing.Point(4, 143)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.ShadowDecoration.Parent = Me.cbSexo
        Me.cbSexo.Size = New System.Drawing.Size(220, 36)
        Me.cbSexo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSexo.TabIndex = 81
        '
        'cbEsp
        '
        Me.cbEsp.Animated = True
        Me.cbEsp.BackColor = System.Drawing.Color.Transparent
        Me.cbEsp.BorderThickness = 2
        Me.cbEsp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbEsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEsp.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEsp.FocusedColor = System.Drawing.Color.Empty
        Me.cbEsp.FocusedState.Parent = Me.cbEsp
        Me.cbEsp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEsp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbEsp.FormattingEnabled = True
        Me.cbEsp.HoverState.Parent = Me.cbEsp
        Me.cbEsp.ItemHeight = 30
        Me.cbEsp.Items.AddRange(New Object() {"Medicos", "Enfermedades", "Sintomas"})
        Me.cbEsp.ItemsAppearance.Parent = Me.cbEsp
        Me.cbEsp.Location = New System.Drawing.Point(4, 80)
        Me.cbEsp.Name = "cbEsp"
        Me.cbEsp.ShadowDecoration.Parent = Me.cbEsp
        Me.cbEsp.Size = New System.Drawing.Size(220, 36)
        Me.cbEsp.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbEsp.TabIndex = 80
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Animated = True
        Me.txtDomicilio.BorderThickness = 2
        Me.txtDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDomicilio.DefaultText = ""
        Me.txtDomicilio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDomicilio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDomicilio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDomicilio.DisabledState.Parent = Me.txtDomicilio
        Me.txtDomicilio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDomicilio.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDomicilio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtDomicilio.FocusedState.Parent = Me.txtDomicilio
        Me.txtDomicilio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtDomicilio.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtDomicilio.HoverState.Parent = Me.txtDomicilio
        Me.txtDomicilio.Location = New System.Drawing.Point(4, 206)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDomicilio.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtDomicilio.PlaceholderText = ""
        Me.txtDomicilio.SelectedText = ""
        Me.txtDomicilio.ShadowDecoration.Parent = Me.txtDomicilio
        Me.txtDomicilio.Size = New System.Drawing.Size(457, 30)
        Me.txtDomicilio.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtDomicilio.TabIndex = 78
        '
        'txtEdad
        '
        Me.txtEdad.Animated = True
        Me.txtEdad.BorderThickness = 2
        Me.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEdad.DefaultText = ""
        Me.txtEdad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEdad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEdad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEdad.DisabledState.Parent = Me.txtEdad
        Me.txtEdad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEdad.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtEdad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtEdad.FocusedState.Parent = Me.txtEdad
        Me.txtEdad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtEdad.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtEdad.HoverState.Parent = Me.txtEdad
        Me.txtEdad.Location = New System.Drawing.Point(243, 146)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEdad.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtEdad.PlaceholderText = ""
        Me.txtEdad.SelectedText = ""
        Me.txtEdad.ShadowDecoration.Parent = Me.txtEdad
        Me.txtEdad.Size = New System.Drawing.Size(220, 30)
        Me.txtEdad.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtEdad.TabIndex = 77
        '
        'txtTelefono
        '
        Me.txtTelefono.Animated = True
        Me.txtTelefono.BorderThickness = 2
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.DefaultText = ""
        Me.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefono.DisabledState.Parent = Me.txtTelefono
        Me.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefono.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtTelefono.FocusedState.Parent = Me.txtTelefono
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtTelefono.HoverState.Parent = Me.txtTelefono
        Me.txtTelefono.Location = New System.Drawing.Point(506, 146)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtTelefono.PlaceholderText = ""
        Me.txtTelefono.SelectedText = ""
        Me.txtTelefono.ShadowDecoration.Parent = Me.txtTelefono
        Me.txtTelefono.Size = New System.Drawing.Size(220, 30)
        Me.txtTelefono.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtTelefono.TabIndex = 76
        '
        'txtNumMed
        '
        Me.txtNumMed.Animated = True
        Me.txtNumMed.BorderThickness = 2
        Me.txtNumMed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumMed.DefaultText = ""
        Me.txtNumMed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumMed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumMed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumMed.DisabledState.Parent = Me.txtNumMed
        Me.txtNumMed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumMed.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNumMed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNumMed.FocusedState.Parent = Me.txtNumMed
        Me.txtNumMed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumMed.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumMed.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNumMed.HoverState.Parent = Me.txtNumMed
        Me.txtNumMed.Location = New System.Drawing.Point(506, 206)
        Me.txtNumMed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumMed.Name = "txtNumMed"
        Me.txtNumMed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumMed.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumMed.PlaceholderText = ""
        Me.txtNumMed.SelectedText = ""
        Me.txtNumMed.ShadowDecoration.Parent = Me.txtNumMed
        Me.txtNumMed.Size = New System.Drawing.Size(220, 30)
        Me.txtNumMed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtNumMed.TabIndex = 75
        '
        'txtSape
        '
        Me.txtSape.Animated = True
        Me.txtSape.BorderThickness = 2
        Me.txtSape.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSape.DefaultText = ""
        Me.txtSape.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSape.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSape.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSape.DisabledState.Parent = Me.txtSape
        Me.txtSape.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSape.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtSape.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSape.FocusedState.Parent = Me.txtSape
        Me.txtSape.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSape.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSape.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSape.HoverState.Parent = Me.txtSape
        Me.txtSape.Location = New System.Drawing.Point(506, 83)
        Me.txtSape.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSape.Name = "txtSape"
        Me.txtSape.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSape.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSape.PlaceholderText = ""
        Me.txtSape.SelectedText = ""
        Me.txtSape.ShadowDecoration.Parent = Me.txtSape
        Me.txtSape.Size = New System.Drawing.Size(220, 30)
        Me.txtSape.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSape.TabIndex = 74
        '
        'txtPape
        '
        Me.txtPape.Animated = True
        Me.txtPape.BorderThickness = 2
        Me.txtPape.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPape.DefaultText = ""
        Me.txtPape.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPape.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPape.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPape.DisabledState.Parent = Me.txtPape
        Me.txtPape.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPape.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtPape.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPape.FocusedState.Parent = Me.txtPape
        Me.txtPape.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPape.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPape.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPape.HoverState.Parent = Me.txtPape
        Me.txtPape.Location = New System.Drawing.Point(246, 86)
        Me.txtPape.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPape.Name = "txtPape"
        Me.txtPape.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPape.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPape.PlaceholderText = ""
        Me.txtPape.SelectedText = ""
        Me.txtPape.ShadowDecoration.Parent = Me.txtPape
        Me.txtPape.Size = New System.Drawing.Size(220, 30)
        Me.txtPape.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPape.TabIndex = 73
        '
        'txtLugarTrabajo
        '
        Me.txtLugarTrabajo.Animated = True
        Me.txtLugarTrabajo.BorderThickness = 2
        Me.txtLugarTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLugarTrabajo.DefaultText = ""
        Me.txtLugarTrabajo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLugarTrabajo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLugarTrabajo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLugarTrabajo.DisabledState.Parent = Me.txtLugarTrabajo
        Me.txtLugarTrabajo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLugarTrabajo.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtLugarTrabajo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtLugarTrabajo.FocusedState.Parent = Me.txtLugarTrabajo
        Me.txtLugarTrabajo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTrabajo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtLugarTrabajo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtLugarTrabajo.HoverState.Parent = Me.txtLugarTrabajo
        Me.txtLugarTrabajo.Location = New System.Drawing.Point(4, 262)
        Me.txtLugarTrabajo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLugarTrabajo.Name = "txtLugarTrabajo"
        Me.txtLugarTrabajo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLugarTrabajo.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtLugarTrabajo.PlaceholderText = ""
        Me.txtLugarTrabajo.SelectedText = ""
        Me.txtLugarTrabajo.ShadowDecoration.Parent = Me.txtLugarTrabajo
        Me.txtLugarTrabajo.Size = New System.Drawing.Size(461, 30)
        Me.txtLugarTrabajo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtLugarTrabajo.TabIndex = 72
        '
        'txtPNom
        '
        Me.txtPNom.Animated = True
        Me.txtPNom.BorderThickness = 2
        Me.txtPNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPNom.DefaultText = ""
        Me.txtPNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPNom.DisabledState.Parent = Me.txtPNom
        Me.txtPNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPNom.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtPNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPNom.FocusedState.Parent = Me.txtPNom
        Me.txtPNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPNom.HoverState.Parent = Me.txtPNom
        Me.txtPNom.Location = New System.Drawing.Point(246, 24)
        Me.txtPNom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPNom.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPNom.PlaceholderText = ""
        Me.txtPNom.SelectedText = ""
        Me.txtPNom.ShadowDecoration.Parent = Me.txtPNom
        Me.txtPNom.Size = New System.Drawing.Size(220, 30)
        Me.txtPNom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPNom.TabIndex = 71
        '
        'txtCedula
        '
        Me.txtCedula.Animated = True
        Me.txtCedula.BorderThickness = 2
        Me.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCedula.DefaultText = ""
        Me.txtCedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCedula.DisabledState.Parent = Me.txtCedula
        Me.txtCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCedula.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCedula.FocusedState.Parent = Me.txtCedula
        Me.txtCedula.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCedula.HoverState.Parent = Me.txtCedula
        Me.txtCedula.Location = New System.Drawing.Point(7, 24)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCedula.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCedula.PlaceholderText = ""
        Me.txtCedula.SelectedText = ""
        Me.txtCedula.ShadowDecoration.Parent = Me.txtCedula
        Me.txtCedula.Size = New System.Drawing.Size(220, 30)
        Me.txtCedula.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCedula.TabIndex = 70
        '
        'FrmModificarGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(775, 681)
        Me.Controls.Add(Me.PanelModifMedico)
        Me.Controls.Add(Me.PanelModEnfermedad)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.DgvDatos)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.modifAclaracion)
        Me.Controls.Add(Me.PanelModSintoma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmModificarGerente"
        Me.Text = "FrmModificar"
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelModSintoma.ResumeLayout(False)
        Me.PanelModSintoma.PerformLayout()
        Me.PanelModEnfermedad.ResumeLayout(False)
        Me.PanelModEnfermedad.PerformLayout()
        Me.groupBoxSintomas.ResumeLayout(False)
        Me.groupBoxSintomas.PerformLayout()
        Me.PanelModifMedico.ResumeLayout(False)
        Me.PanelModifMedico.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents modificar As Label
    Friend WithEvents DgvDatos As DataGridView
    Friend WithEvents modifAclaracion As Label
    Friend WithEvents PanelModSintoma As Panel
    Friend WithEvents lbNomSint As Label
    Friend WithEvents PanelModEnfermedad As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents cbFiltro As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_modificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtDescripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbRiesgo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtNombreEnfermedad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents lbRiesgo As Label
    Friend WithEvents lbNomEnf As Label
    Friend WithEvents txtNombreSintoma As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PanelModifMedico As Panel
    Friend WithEvents Persona_sNom As Label
    Friend WithEvents txtSnom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Persona_domicilio As Label
    Friend WithEvents Persona_numMed As Label
    Friend WithEvents Persona_edad As Label
    Friend WithEvents Persona_tel As Label
    Friend WithEvents Persona_sApe As Label
    Friend WithEvents Persona_sexo As Label
    Friend WithEvents Persona_lugarTrabajo As Label
    Friend WithEvents Persona_pApe As Label
    Friend WithEvents Persona_especialidad As Label
    Friend WithEvents Persona_pNom As Label
    Friend WithEvents Persona_ci As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkDom As CheckBox
    Friend WithEvents chkJuev As CheckBox
    Friend WithEvents chkSab As CheckBox
    Friend WithEvents chkMier As CheckBox
    Friend WithEvents chkMar As CheckBox
    Friend WithEvents chkVier As CheckBox
    Friend WithEvents chkLun As CheckBox
    Friend WithEvents Jue As Label
    Friend WithEvents txtHoraEntradaDomingo As TextBox
    Friend WithEvents Sab As Label
    Friend WithEvents txtHoraEntradaSabado As TextBox
    Friend WithEvents Dom As Label
    Friend WithEvents txtHoraEntradaViernes As TextBox
    Friend WithEvents txtHoraEntradaMiercoles As TextBox
    Friend WithEvents txtHoraEntradaJueves As TextBox
    Friend WithEvents Vie As Label
    Friend WithEvents txtHoraEntradaMartes As TextBox
    Friend WithEvents txtHoraEntradaLunes As TextBox
    Friend WithEvents Mie As Label
    Friend WithEvents Mar As Label
    Friend WithEvents Lun As Label
    Friend WithEvents horaEjemplo As Label
    Friend WithEvents Mhora As Label
    Friend WithEvents cbSexo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbEsp As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtDomicilio As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEdad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNumMed As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSape As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPape As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLugarTrabajo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPNom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCedula As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents groupBoxSintomas As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cbSintoma6 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma8 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma5 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma7 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma4 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents chb7 As CheckBox
    Friend WithEvents chb6 As CheckBox
    Friend WithEvents chb5 As CheckBox
    Friend WithEvents chb4 As CheckBox
    Friend WithEvents chb3 As CheckBox
    Friend WithEvents chb2 As CheckBox
    Friend WithEvents chb1 As CheckBox
End Class
