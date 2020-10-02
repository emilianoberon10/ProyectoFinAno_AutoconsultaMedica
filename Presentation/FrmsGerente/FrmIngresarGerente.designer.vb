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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbNomEnf = New System.Windows.Forms.Label()
        Me.lbNomSint = New System.Windows.Forms.Label()
        Me.ErrorProviderNomSint = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderNomDesEnf = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderSintEnf = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreSintoma = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnConsul = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNombreEnfermedad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
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
        Me.cbRiesgo = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.ErrorProviderNomSint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderNomDesEnf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderSintEnf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(177, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar sintomas/enfermadad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(323, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enfermedad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(337, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sintoma"
        '
        'lbNomEnf
        '
        Me.lbNomEnf.AutoSize = True
        Me.lbNomEnf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomEnf.ForeColor = System.Drawing.Color.Silver
        Me.ErrorProviderNomSint.SetIconAlignment(Me.lbNomEnf, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.ErrorProviderNomDesEnf.SetIconAlignment(Me.lbNomEnf, System.Windows.Forms.ErrorIconAlignment.TopRight)
        Me.ErrorProviderSintEnf.SetIconAlignment(Me.lbNomEnf, System.Windows.Forms.ErrorIconAlignment.TopRight)
        Me.lbNomEnf.Location = New System.Drawing.Point(22, 206)
        Me.lbNomEnf.Name = "lbNomEnf"
        Me.lbNomEnf.Size = New System.Drawing.Size(75, 21)
        Me.lbNomEnf.TabIndex = 3
        Me.lbNomEnf.Text = "NOMBRE"
        '
        'lbNomSint
        '
        Me.lbNomSint.AutoSize = True
        Me.lbNomSint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomSint.ForeColor = System.Drawing.Color.Silver
        Me.lbNomSint.Location = New System.Drawing.Point(22, 90)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(457, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RIESGO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(22, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "DESCRIPCION"
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
        Me.txtNombreSintoma.Location = New System.Drawing.Point(22, 114)
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
        'btnConsul
        '
        Me.btnConsul.Animated = True
        Me.btnConsul.BackColor = System.Drawing.Color.Transparent
        Me.btnConsul.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnConsul.BorderRadius = 15
        Me.btnConsul.BorderThickness = 2
        Me.btnConsul.CheckedState.Parent = Me.btnConsul
        Me.btnConsul.CustomImages.Parent = Me.btnConsul
        Me.btnConsul.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnConsul.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsul.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnConsul.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnConsul.HoverState.Parent = Me.btnConsul
        Me.btnConsul.Location = New System.Drawing.Point(563, 104)
        Me.btnConsul.Name = "btnConsul"
        Me.btnConsul.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnConsul.ShadowDecoration.BorderRadius = 20
        Me.btnConsul.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnConsul.ShadowDecoration.Depth = 15
        Me.btnConsul.ShadowDecoration.Enabled = True
        Me.btnConsul.ShadowDecoration.Parent = Me.btnConsul
        Me.btnConsul.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btnConsul.Size = New System.Drawing.Size(200, 40)
        Me.btnConsul.TabIndex = 54
        Me.btnConsul.Text = "INGRESAR"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(563, 612)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 20
        Me.Guna2Button1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Guna2Button1.ShadowDecoration.Depth = 15
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.Guna2Button1.Size = New System.Drawing.Size(200, 40)
        Me.Guna2Button1.TabIndex = 55
        Me.Guna2Button1.Text = "INGRESAR"
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
        Me.txtNombreEnfermedad.Location = New System.Drawing.Point(22, 225)
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
        Me.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtDescripcion.FocusedState.Parent = Me.txtDescripcion
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtDescripcion.HoverState.Parent = Me.txtDescripcion
        Me.txtDescripcion.Location = New System.Drawing.Point(22, 298)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescripcion.MaxLength = 255
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
        Me.Guna2Separator1.Location = New System.Drawing.Point(-4, 173)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(779, 11)
        Me.Guna2Separator1.TabIndex = 56
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2GroupBox1.BorderThickness = 2
        Me.Guna2GroupBox1.Controls.Add(Me.cbSintoma6)
        Me.Guna2GroupBox1.Controls.Add(Me.cbSintoma8)
        Me.Guna2GroupBox1.Controls.Add(Me.cbSintoma5)
        Me.Guna2GroupBox1.Controls.Add(Me.cbSintoma7)
        Me.Guna2GroupBox1.Controls.Add(Me.cbSintoma3)
        Me.Guna2GroupBox1.Controls.Add(Me.cbSintoma4)
        Me.Guna2GroupBox1.Controls.Add(Me.cbSintoma2)
        Me.Guna2GroupBox1.Controls.Add(Me.cbSintoma1)
        Me.Guna2GroupBox1.Controls.Add(Me.chb7)
        Me.Guna2GroupBox1.Controls.Add(Me.chb6)
        Me.Guna2GroupBox1.Controls.Add(Me.chb5)
        Me.Guna2GroupBox1.Controls.Add(Me.chb4)
        Me.Guna2GroupBox1.Controls.Add(Me.chb3)
        Me.Guna2GroupBox1.Controls.Add(Me.chb2)
        Me.Guna2GroupBox1.Controls.Add(Me.chb1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(22, 351)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(623, 245)
        Me.Guna2GroupBox1.TabIndex = 57
        Me.Guna2GroupBox1.Text = "SINTOMAS RELACIONADOS"
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
        Me.cbRiesgo.Location = New System.Drawing.Point(461, 292)
        Me.cbRiesgo.Name = "cbRiesgo"
        Me.cbRiesgo.ShadowDecoration.Parent = Me.cbRiesgo
        Me.cbRiesgo.Size = New System.Drawing.Size(170, 36)
        Me.cbRiesgo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbRiesgo.TabIndex = 49
        '
        'FrmIngresarGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(775, 681)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnConsul)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cbRiesgo)
        Me.Controls.Add(Me.txtNombreEnfermedad)
        Me.Controls.Add(Me.txtNombreSintoma)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbNomSint)
        Me.Controls.Add(Me.lbNomEnf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmIngresarGerente"
        Me.Text = "FrmIngresar"
        CType(Me.ErrorProviderNomSint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderNomDesEnf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderSintEnf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbNomEnf As Label
    Friend WithEvents lbNomSint As Label
    Friend WithEvents ErrorProviderNomSint As ErrorProvider
    Friend WithEvents ErrorProviderNomDesEnf As ErrorProvider
    Friend WithEvents ErrorProviderSintEnf As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chb8 As CheckBox
    Friend WithEvents cbSintoma9 As ComboBox
    Friend WithEvents txtNombreSintoma As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConsul As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNombreEnfermedad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDescripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
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
End Class
