<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIngresarGerente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresarGerente))
        Me.ingGerente = New System.Windows.Forms.Label()
        Me.enfermedad = New System.Windows.Forms.Label()
        Me.sintoma = New System.Windows.Forms.Label()
        Me.lbNomEnf = New System.Windows.Forms.Label()
        Me.lbNomSint = New System.Windows.Forms.Label()
        Me.ErrorProviderNomSint = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderNomDesEnf = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderSintEnf = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lbRiesgo = New System.Windows.Forms.Label()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.txtNombreSintoma = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_ingresar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_ingresar2 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNombreEnfermedad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.groupBoxSintomas = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cbSintoma6 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.comboSintoma9 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma8 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma5 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma7 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma4 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chb7 = New System.Windows.Forms.CheckBox()
        Me.chb6 = New System.Windows.Forms.CheckBox()
        Me.chb5 = New System.Windows.Forms.CheckBox()
        Me.chb4 = New System.Windows.Forms.CheckBox()
        Me.chb3 = New System.Windows.Forms.CheckBox()
        Me.chb2 = New System.Windows.Forms.CheckBox()
        Me.chb1 = New System.Windows.Forms.CheckBox()
        Me.cbRiesgo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.llbCargarExcel = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ErrorProviderNomSint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderNomDesEnf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderSintEnf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxSintomas.SuspendLayout()
        Me.SuspendLayout()
        '
        'ingGerente
        '
        Me.ingGerente.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingGerente.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ingGerente.Location = New System.Drawing.Point(1, 9)
        Me.ingGerente.Name = "ingGerente"
        Me.ingGerente.Size = New System.Drawing.Size(804, 40)
        Me.ingGerente.TabIndex = 0
        Me.ingGerente.Text = "INGRESAR SINTOMAS/ENFERMEDADES"
        Me.ingGerente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'enfermedad
        '
        Me.enfermedad.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enfermedad.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.enfermedad.Location = New System.Drawing.Point(1, 186)
        Me.enfermedad.Name = "enfermedad"
        Me.enfermedad.Size = New System.Drawing.Size(804, 30)
        Me.enfermedad.TabIndex = 3
        Me.enfermedad.Text = "Enfermedad"
        Me.enfermedad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sintoma
        '
        Me.sintoma.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sintoma.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.sintoma.Location = New System.Drawing.Point(1, 55)
        Me.sintoma.Name = "sintoma"
        Me.sintoma.Size = New System.Drawing.Size(774, 30)
        Me.sintoma.TabIndex = 3
        Me.sintoma.Text = "Sintoma"
        Me.sintoma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbNomEnf
        '
        Me.lbNomEnf.AutoSize = True
        Me.lbNomEnf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomEnf.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ErrorProviderNomSint.SetIconAlignment(Me.lbNomEnf, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.ErrorProviderNomDesEnf.SetIconAlignment(Me.lbNomEnf, System.Windows.Forms.ErrorIconAlignment.TopRight)
        Me.ErrorProviderSintEnf.SetIconAlignment(Me.lbNomEnf, System.Windows.Forms.ErrorIconAlignment.TopRight)
        Me.lbNomEnf.Location = New System.Drawing.Point(97, 206)
        Me.lbNomEnf.Name = "lbNomEnf"
        Me.lbNomEnf.Size = New System.Drawing.Size(75, 21)
        Me.lbNomEnf.TabIndex = 3
        Me.lbNomEnf.Text = "NOMBRE"
        '
        'lbNomSint
        '
        Me.lbNomSint.AutoSize = True
        Me.lbNomSint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomSint.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbNomSint.Location = New System.Drawing.Point(97, 90)
        Me.lbNomSint.Name = "lbNomSint"
        Me.lbNomSint.Size = New System.Drawing.Size(75, 21)
        Me.lbNomSint.TabIndex = 3
        Me.lbNomSint.Text = "NOMBRE"
        '
        'ErrorProviderNomSint
        '
        Me.ErrorProviderNomSint.ContainerControl = Me
        Me.ErrorProviderNomSint.Icon = CType(resources.GetObject("ErrorProviderNomSint.Icon"), System.Drawing.Icon)
        '
        'ErrorProviderNomDesEnf
        '
        Me.ErrorProviderNomDesEnf.ContainerControl = Me
        '
        'ErrorProviderSintEnf
        '
        Me.ErrorProviderSintEnf.ContainerControl = Me
        '
        'lbRiesgo
        '
        Me.lbRiesgo.AutoSize = True
        Me.lbRiesgo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRiesgo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbRiesgo.Location = New System.Drawing.Point(532, 268)
        Me.lbRiesgo.Name = "lbRiesgo"
        Me.lbRiesgo.Size = New System.Drawing.Size(64, 21)
        Me.lbRiesgo.TabIndex = 3
        Me.lbRiesgo.Text = "RIESGO"
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescripcion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbDescripcion.Location = New System.Drawing.Point(97, 274)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(109, 21)
        Me.lbDescripcion.TabIndex = 3
        Me.lbDescripcion.Text = "DESCRIPCION"
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
        Me.txtNombreSintoma.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtNombreSintoma.FocusedState.Parent = Me.txtNombreSintoma
        Me.txtNombreSintoma.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreSintoma.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtNombreSintoma.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtNombreSintoma.HoverState.Parent = Me.txtNombreSintoma
        Me.txtNombreSintoma.Location = New System.Drawing.Point(97, 114)
        Me.txtNombreSintoma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombreSintoma.Name = "txtNombreSintoma"
        Me.txtNombreSintoma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreSintoma.PlaceholderText = ""
        Me.txtNombreSintoma.SelectedText = ""
        Me.txtNombreSintoma.ShadowDecoration.BorderRadius = 10
        Me.txtNombreSintoma.ShadowDecoration.Parent = Me.txtNombreSintoma
        Me.txtNombreSintoma.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.txtNombreSintoma.Size = New System.Drawing.Size(380, 30)
        Me.txtNombreSintoma.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtNombreSintoma.TabIndex = 53
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Animated = True
        Me.btn_ingresar.BackColor = System.Drawing.Color.Transparent
        Me.btn_ingresar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_ingresar.BorderRadius = 15
        Me.btn_ingresar.BorderThickness = 2
        Me.btn_ingresar.CheckedState.Parent = Me.btn_ingresar
        Me.btn_ingresar.CustomImages.Parent = Me.btn_ingresar
        Me.btn_ingresar.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_ingresar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingresar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_ingresar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_ingresar.HoverState.Parent = Me.btn_ingresar
        Me.btn_ingresar.Location = New System.Drawing.Point(575, 104)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_ingresar.ShadowDecoration.BorderRadius = 20
        Me.btn_ingresar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_ingresar.ShadowDecoration.Depth = 15
        Me.btn_ingresar.ShadowDecoration.Enabled = True
        Me.btn_ingresar.ShadowDecoration.Parent = Me.btn_ingresar
        Me.btn_ingresar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_ingresar.Size = New System.Drawing.Size(200, 40)
        Me.btn_ingresar.TabIndex = 54
        Me.btn_ingresar.Text = "INGRESAR"
        '
        'btn_ingresar2
        '
        Me.btn_ingresar2.Animated = True
        Me.btn_ingresar2.BackColor = System.Drawing.Color.Transparent
        Me.btn_ingresar2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_ingresar2.BorderRadius = 15
        Me.btn_ingresar2.BorderThickness = 2
        Me.btn_ingresar2.CheckedState.Parent = Me.btn_ingresar2
        Me.btn_ingresar2.CustomImages.Parent = Me.btn_ingresar2
        Me.btn_ingresar2.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_ingresar2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingresar2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_ingresar2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_ingresar2.HoverState.Parent = Me.btn_ingresar2
        Me.btn_ingresar2.Location = New System.Drawing.Point(575, 617)
        Me.btn_ingresar2.Name = "btn_ingresar2"
        Me.btn_ingresar2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_ingresar2.ShadowDecoration.BorderRadius = 20
        Me.btn_ingresar2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_ingresar2.ShadowDecoration.Depth = 15
        Me.btn_ingresar2.ShadowDecoration.Enabled = True
        Me.btn_ingresar2.ShadowDecoration.Parent = Me.btn_ingresar2
        Me.btn_ingresar2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_ingresar2.Size = New System.Drawing.Size(200, 40)
        Me.btn_ingresar2.TabIndex = 55
        Me.btn_ingresar2.Text = "INGRESAR"
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
        Me.txtNombreEnfermedad.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtNombreEnfermedad.FocusedState.Parent = Me.txtNombreEnfermedad
        Me.txtNombreEnfermedad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEnfermedad.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtNombreEnfermedad.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtNombreEnfermedad.HoverState.Parent = Me.txtNombreEnfermedad
        Me.txtNombreEnfermedad.Location = New System.Drawing.Point(97, 225)
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
        Me.txtNombreEnfermedad.TabIndex = 53
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
        Me.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtDescripcion.FocusedState.Parent = Me.txtDescripcion
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtDescripcion.HoverState.Parent = Me.txtDescripcion
        Me.txtDescripcion.Location = New System.Drawing.Point(97, 298)
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
        Me.txtDescripcion.TabIndex = 53
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(1, 173)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(804, 11)
        Me.Guna2Separator1.TabIndex = 56
        '
        'groupBoxSintomas
        '
        Me.groupBoxSintomas.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.groupBoxSintomas.BorderThickness = 2
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma6)
        Me.groupBoxSintomas.Controls.Add(Me.comboSintoma9)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma8)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma5)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma7)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma3)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma4)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma2)
        Me.groupBoxSintomas.Controls.Add(Me.cbSintoma1)
        Me.groupBoxSintomas.Controls.Add(Me.CheckBox1)
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
        Me.groupBoxSintomas.Location = New System.Drawing.Point(26, 361)
        Me.groupBoxSintomas.Name = "groupBoxSintomas"
        Me.groupBoxSintomas.ShadowDecoration.Parent = Me.groupBoxSintomas
        Me.groupBoxSintomas.Size = New System.Drawing.Size(749, 234)
        Me.groupBoxSintomas.TabIndex = 57
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
        Me.cbSintoma6.FocusedColor = System.Drawing.Color.Cyan
        Me.cbSintoma6.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma6.FocusedState.Parent = Me.cbSintoma6
        Me.cbSintoma6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbSintoma6.FormattingEnabled = True
        Me.cbSintoma6.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma6.HoverState.Parent = Me.cbSintoma6
        Me.cbSintoma6.ItemHeight = 30
        Me.cbSintoma6.ItemsAppearance.Parent = Me.cbSintoma6
        Me.cbSintoma6.Location = New System.Drawing.Point(509, 108)
        Me.cbSintoma6.Name = "cbSintoma6"
        Me.cbSintoma6.ShadowDecoration.Parent = Me.cbSintoma6
        Me.cbSintoma6.Size = New System.Drawing.Size(205, 36)
        Me.cbSintoma6.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma6.TabIndex = 45
        '
        'comboSintoma9
        '
        Me.comboSintoma9.Animated = True
        Me.comboSintoma9.BackColor = System.Drawing.Color.Transparent
        Me.comboSintoma9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboSintoma9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSintoma9.Enabled = False
        Me.comboSintoma9.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.comboSintoma9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboSintoma9.FocusedColor = System.Drawing.Color.Cyan
        Me.comboSintoma9.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.comboSintoma9.FocusedState.Parent = Me.comboSintoma9
        Me.comboSintoma9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.comboSintoma9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.comboSintoma9.FormattingEnabled = True
        Me.comboSintoma9.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.comboSintoma9.HoverState.Parent = Me.comboSintoma9
        Me.comboSintoma9.ItemHeight = 30
        Me.comboSintoma9.ItemsAppearance.Parent = Me.comboSintoma9
        Me.comboSintoma9.Location = New System.Drawing.Point(509, 169)
        Me.comboSintoma9.Name = "comboSintoma9"
        Me.comboSintoma9.ShadowDecoration.Parent = Me.comboSintoma9
        Me.comboSintoma9.Size = New System.Drawing.Size(205, 36)
        Me.comboSintoma9.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.comboSintoma9.TabIndex = 46
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
        Me.cbSintoma8.FocusedColor = System.Drawing.Color.Cyan
        Me.cbSintoma8.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma8.FocusedState.Parent = Me.cbSintoma8
        Me.cbSintoma8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbSintoma8.FormattingEnabled = True
        Me.cbSintoma8.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma8.HoverState.Parent = Me.cbSintoma8
        Me.cbSintoma8.ItemHeight = 30
        Me.cbSintoma8.ItemsAppearance.Parent = Me.cbSintoma8
        Me.cbSintoma8.Location = New System.Drawing.Point(285, 169)
        Me.cbSintoma8.Name = "cbSintoma8"
        Me.cbSintoma8.ShadowDecoration.Parent = Me.cbSintoma8
        Me.cbSintoma8.Size = New System.Drawing.Size(205, 36)
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
        Me.cbSintoma5.FocusedColor = System.Drawing.Color.Cyan
        Me.cbSintoma5.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma5.FocusedState.Parent = Me.cbSintoma5
        Me.cbSintoma5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbSintoma5.FormattingEnabled = True
        Me.cbSintoma5.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma5.HoverState.Parent = Me.cbSintoma5
        Me.cbSintoma5.ItemHeight = 30
        Me.cbSintoma5.ItemsAppearance.Parent = Me.cbSintoma5
        Me.cbSintoma5.Location = New System.Drawing.Point(285, 108)
        Me.cbSintoma5.Name = "cbSintoma5"
        Me.cbSintoma5.ShadowDecoration.Parent = Me.cbSintoma5
        Me.cbSintoma5.Size = New System.Drawing.Size(205, 36)
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
        Me.cbSintoma7.FocusedColor = System.Drawing.Color.Cyan
        Me.cbSintoma7.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma7.FocusedState.Parent = Me.cbSintoma7
        Me.cbSintoma7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbSintoma7.FormattingEnabled = True
        Me.cbSintoma7.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma7.HoverState.Parent = Me.cbSintoma7
        Me.cbSintoma7.ItemHeight = 30
        Me.cbSintoma7.ItemsAppearance.Parent = Me.cbSintoma7
        Me.cbSintoma7.Location = New System.Drawing.Point(55, 169)
        Me.cbSintoma7.Name = "cbSintoma7"
        Me.cbSintoma7.ShadowDecoration.Parent = Me.cbSintoma7
        Me.cbSintoma7.Size = New System.Drawing.Size(205, 36)
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
        Me.cbSintoma3.FocusedColor = System.Drawing.Color.Cyan
        Me.cbSintoma3.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma3.FocusedState.Parent = Me.cbSintoma3
        Me.cbSintoma3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbSintoma3.FormattingEnabled = True
        Me.cbSintoma3.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma3.HoverState.Parent = Me.cbSintoma3
        Me.cbSintoma3.ItemHeight = 30
        Me.cbSintoma3.ItemsAppearance.Parent = Me.cbSintoma3
        Me.cbSintoma3.Location = New System.Drawing.Point(509, 49)
        Me.cbSintoma3.Name = "cbSintoma3"
        Me.cbSintoma3.ShadowDecoration.Parent = Me.cbSintoma3
        Me.cbSintoma3.Size = New System.Drawing.Size(205, 36)
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
        Me.cbSintoma4.FocusedColor = System.Drawing.Color.Cyan
        Me.cbSintoma4.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma4.FocusedState.Parent = Me.cbSintoma4
        Me.cbSintoma4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbSintoma4.FormattingEnabled = True
        Me.cbSintoma4.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma4.HoverState.Parent = Me.cbSintoma4
        Me.cbSintoma4.ItemHeight = 30
        Me.cbSintoma4.ItemsAppearance.Parent = Me.cbSintoma4
        Me.cbSintoma4.Location = New System.Drawing.Point(55, 108)
        Me.cbSintoma4.Name = "cbSintoma4"
        Me.cbSintoma4.ShadowDecoration.Parent = Me.cbSintoma4
        Me.cbSintoma4.Size = New System.Drawing.Size(205, 36)
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
        Me.cbSintoma2.FocusedColor = System.Drawing.Color.Cyan
        Me.cbSintoma2.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma2.FocusedState.Parent = Me.cbSintoma2
        Me.cbSintoma2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbSintoma2.FormattingEnabled = True
        Me.cbSintoma2.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma2.HoverState.Parent = Me.cbSintoma2
        Me.cbSintoma2.ItemHeight = 30
        Me.cbSintoma2.ItemsAppearance.Parent = Me.cbSintoma2
        Me.cbSintoma2.Location = New System.Drawing.Point(285, 49)
        Me.cbSintoma2.Name = "cbSintoma2"
        Me.cbSintoma2.ShadowDecoration.Parent = Me.cbSintoma2
        Me.cbSintoma2.Size = New System.Drawing.Size(205, 36)
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
        Me.cbSintoma1.FocusedColor = System.Drawing.Color.Cyan
        Me.cbSintoma1.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma1.FocusedState.Parent = Me.cbSintoma1
        Me.cbSintoma1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbSintoma1.FormattingEnabled = True
        Me.cbSintoma1.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.cbSintoma1.HoverState.Parent = Me.cbSintoma1
        Me.cbSintoma1.ItemHeight = 30
        Me.cbSintoma1.ItemsAppearance.Parent = Me.cbSintoma1
        Me.cbSintoma1.Location = New System.Drawing.Point(55, 49)
        Me.cbSintoma1.Name = "cbSintoma1"
        Me.cbSintoma1.ShadowDecoration.Parent = Me.cbSintoma1
        Me.cbSintoma1.Size = New System.Drawing.Size(205, 36)
        Me.cbSintoma1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma1.TabIndex = 52
        Me.cbSintoma1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(493, 180)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 38
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chb7
        '
        Me.chb7.AutoSize = True
        Me.chb7.Location = New System.Drawing.Point(264, 180)
        Me.chb7.Name = "chb7"
        Me.chb7.Size = New System.Drawing.Size(15, 14)
        Me.chb7.TabIndex = 38
        Me.chb7.UseVisualStyleBackColor = True
        '
        'chb6
        '
        Me.chb6.AutoSize = True
        Me.chb6.Location = New System.Drawing.Point(34, 180)
        Me.chb6.Name = "chb6"
        Me.chb6.Size = New System.Drawing.Size(15, 14)
        Me.chb6.TabIndex = 39
        Me.chb6.UseVisualStyleBackColor = True
        '
        'chb5
        '
        Me.chb5.AutoSize = True
        Me.chb5.Location = New System.Drawing.Point(493, 119)
        Me.chb5.Name = "chb5"
        Me.chb5.Size = New System.Drawing.Size(15, 14)
        Me.chb5.TabIndex = 40
        Me.chb5.UseVisualStyleBackColor = True
        '
        'chb4
        '
        Me.chb4.AutoSize = True
        Me.chb4.Location = New System.Drawing.Point(264, 119)
        Me.chb4.Name = "chb4"
        Me.chb4.Size = New System.Drawing.Size(15, 14)
        Me.chb4.TabIndex = 41
        Me.chb4.UseVisualStyleBackColor = True
        '
        'chb3
        '
        Me.chb3.AutoSize = True
        Me.chb3.Location = New System.Drawing.Point(34, 119)
        Me.chb3.Name = "chb3"
        Me.chb3.Size = New System.Drawing.Size(15, 14)
        Me.chb3.TabIndex = 42
        Me.chb3.UseVisualStyleBackColor = True
        '
        'chb2
        '
        Me.chb2.AutoSize = True
        Me.chb2.Location = New System.Drawing.Point(493, 60)
        Me.chb2.Name = "chb2"
        Me.chb2.Size = New System.Drawing.Size(15, 14)
        Me.chb2.TabIndex = 43
        Me.chb2.UseVisualStyleBackColor = True
        '
        'chb1
        '
        Me.chb1.AutoSize = True
        Me.chb1.Location = New System.Drawing.Point(264, 60)
        Me.chb1.Name = "chb1"
        Me.chb1.Size = New System.Drawing.Size(15, 14)
        Me.chb1.TabIndex = 44
        Me.chb1.UseVisualStyleBackColor = True
        '
        'cbRiesgo
        '
        Me.cbRiesgo.Animated = True
        Me.cbRiesgo.BackColor = System.Drawing.Color.Transparent
        Me.cbRiesgo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbRiesgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRiesgo.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbRiesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRiesgo.FocusedColor = System.Drawing.Color.Cyan
        Me.cbRiesgo.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.cbRiesgo.FocusedState.Parent = Me.cbRiesgo
        Me.cbRiesgo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbRiesgo.ForeColor = System.Drawing.Color.White
        Me.cbRiesgo.FormattingEnabled = True
        Me.cbRiesgo.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.cbRiesgo.HoverState.Parent = Me.cbRiesgo
        Me.cbRiesgo.ItemHeight = 30
        Me.cbRiesgo.Items.AddRange(New Object() {"Azul", "Verde", "Amarillo", "Naranja", "Rojo"})
        Me.cbRiesgo.ItemsAppearance.Parent = Me.cbRiesgo
        Me.cbRiesgo.Location = New System.Drawing.Point(536, 292)
        Me.cbRiesgo.Name = "cbRiesgo"
        Me.cbRiesgo.ShadowDecoration.Parent = Me.cbRiesgo
        Me.cbRiesgo.Size = New System.Drawing.Size(170, 36)
        Me.cbRiesgo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbRiesgo.TabIndex = 49
        '
        'llbCargarExcel
        '
        Me.llbCargarExcel.AutoSize = True
        Me.llbCargarExcel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.llbCargarExcel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.llbCargarExcel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.llbCargarExcel.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.llbCargarExcel.Location = New System.Drawing.Point(671, 49)
        Me.llbCargarExcel.Name = "llbCargarExcel"
        Me.llbCargarExcel.Size = New System.Drawing.Size(119, 19)
        Me.llbCargarExcel.TabIndex = 58
        Me.llbCargarExcel.TabStop = True
        Me.llbCargarExcel.Text = "Cargar desde CSV"
        Me.llbCargarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.llbCargarExcel.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmIngresarGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 683)
        Me.Controls.Add(Me.llbCargarExcel)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.btn_ingresar2)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cbRiesgo)
        Me.Controls.Add(Me.txtNombreEnfermedad)
        Me.Controls.Add(Me.txtNombreSintoma)
        Me.Controls.Add(Me.lbDescripcion)
        Me.Controls.Add(Me.lbRiesgo)
        Me.Controls.Add(Me.lbNomSint)
        Me.Controls.Add(Me.lbNomEnf)
        Me.Controls.Add(Me.sintoma)
        Me.Controls.Add(Me.enfermedad)
        Me.Controls.Add(Me.ingGerente)
        Me.Controls.Add(Me.groupBoxSintomas)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIngresarGerente"
        Me.Text = "FrmIngresar"
        CType(Me.ErrorProviderNomSint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderNomDesEnf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderSintEnf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxSintomas.ResumeLayout(False)
        Me.groupBoxSintomas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ingGerente As Label
    Friend WithEvents enfermedad As Label
    Friend WithEvents sintoma As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbNomEnf As Label
    Friend WithEvents lbNomSint As Label
    Friend WithEvents ErrorProviderNomSint As ErrorProvider
    Friend WithEvents ErrorProviderNomDesEnf As ErrorProvider
    Friend WithEvents ErrorProviderSintEnf As ErrorProvider
    Friend WithEvents lbRiesgo As Label
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents chb8 As CheckBox
    Friend WithEvents cbSintoma9 As ComboBox
    Friend WithEvents txtNombreSintoma As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_ingresar2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_ingresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNombreEnfermedad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDescripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
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
    Friend WithEvents cbRiesgo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents comboSintoma9 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents llbCargarExcel As LinkLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
