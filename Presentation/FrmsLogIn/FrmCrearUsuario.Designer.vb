<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrearUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCrear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.cbSexo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtDomicilio = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEdad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSape = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPape = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPNom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSnom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCedula = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbDomi = New System.Windows.Forms.Label()
        Me.lbEdad = New System.Windows.Forms.Label()
        Me.lbTel = New System.Windows.Forms.Label()
        Me.lbSape = New System.Windows.Forms.Label()
        Me.lbSnom = New System.Windows.Forms.Label()
        Me.lbSexo = New System.Windows.Forms.Label()
        Me.lbCorreo = New System.Windows.Forms.Label()
        Me.lbPape = New System.Windows.Forms.Label()
        Me.lbPnom = New System.Windows.Forms.Label()
        Me.lbCi = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.ErrorProvider1.SetIconAlignment(Me.Label1, System.Windows.Forms.ErrorIconAlignment.TopRight)
        Me.ErrorProvider1.SetIconPadding(Me.Label1, 5)
        Me.Label1.Location = New System.Drawing.Point(216, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CREAR NUEVO USUARIO"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'btnCrear
        '
        Me.btnCrear.Animated = True
        Me.btnCrear.BackColor = System.Drawing.Color.Transparent
        Me.btnCrear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrear.BorderRadius = 15
        Me.btnCrear.BorderThickness = 2
        Me.btnCrear.CheckedState.Parent = Me.btnCrear
        Me.btnCrear.CustomImages.Parent = Me.btnCrear
        Me.btnCrear.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnCrear.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCrear.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCrear.HoverState.Parent = Me.btnCrear
        Me.btnCrear.Location = New System.Drawing.Point(494, 272)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnCrear.ShadowDecoration.BorderRadius = 20
        Me.btnCrear.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrear.ShadowDecoration.Depth = 25
        Me.btnCrear.ShadowDecoration.Enabled = True
        Me.btnCrear.ShadowDecoration.Parent = Me.btnCrear
        Me.btnCrear.Size = New System.Drawing.Size(267, 36)
        Me.btnCrear.TabIndex = 15
        Me.btnCrear.Text = "CREAR"
        '
        'btnCancelar
        '
        Me.btnCancelar.Animated = True
        Me.btnCancelar.AutoRoundedCorners = True
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancelar.BorderRadius = 14
        Me.btnCancelar.BorderThickness = 2
        Me.btnCancelar.CheckedState.Parent = Me.btnCancelar
        Me.btnCancelar.CustomImages.Parent = Me.btnCancelar
        Me.btnCancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCancelar.HoverState.Parent = Me.btnCancelar
        Me.btnCancelar.Location = New System.Drawing.Point(30, 355)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnCancelar.ShadowDecoration.BorderRadius = 20
        Me.btnCancelar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancelar.ShadowDecoration.Depth = 25
        Me.btnCancelar.ShadowDecoration.Enabled = True
        Me.btnCancelar.ShadowDecoration.Parent = Me.btnCancelar
        Me.btnCancelar.Size = New System.Drawing.Size(94, 31)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "CANCELAR"
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
        Me.cbSexo.Location = New System.Drawing.Point(30, 143)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.ShadowDecoration.Parent = Me.cbSexo
        Me.cbSexo.Size = New System.Drawing.Size(220, 36)
        Me.cbSexo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSexo.TabIndex = 81
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
        Me.txtDomicilio.Location = New System.Drawing.Point(530, 214)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDomicilio.MaxLength = 255
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDomicilio.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtDomicilio.PlaceholderText = ""
        Me.txtDomicilio.SelectedText = ""
        Me.txtDomicilio.ShadowDecoration.Parent = Me.txtDomicilio
        Me.txtDomicilio.Size = New System.Drawing.Size(224, 30)
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
        Me.txtEdad.Location = New System.Drawing.Point(32, 214)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEdad.MaxLength = 2
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
        Me.txtTelefono.Location = New System.Drawing.Point(281, 214)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelefono.MaxLength = 9
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
        Me.txtSape.Location = New System.Drawing.Point(534, 149)
        Me.txtSape.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSape.MaxLength = 30
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
        Me.txtPape.Location = New System.Drawing.Point(530, 86)
        Me.txtPape.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPape.MaxLength = 30
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
        'txtCorreo
        '
        Me.txtCorreo.Animated = True
        Me.txtCorreo.BorderThickness = 2
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreo.DefaultText = ""
        Me.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.DisabledState.Parent = Me.txtCorreo
        Me.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCorreo.FocusedState.Parent = Me.txtCorreo
        Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCorreo.HoverState.Parent = Me.txtCorreo
        Me.txtCorreo.Location = New System.Drawing.Point(30, 278)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCorreo.MaxLength = 255
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCorreo.PlaceholderText = ""
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.ShadowDecoration.Parent = Me.txtCorreo
        Me.txtCorreo.Size = New System.Drawing.Size(457, 30)
        Me.txtCorreo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCorreo.TabIndex = 72
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
        Me.txtPNom.Location = New System.Drawing.Point(281, 86)
        Me.txtPNom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPNom.MaxLength = 30
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
        Me.txtSnom.Location = New System.Drawing.Point(281, 149)
        Me.txtSnom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSnom.MaxLength = 30
        Me.txtSnom.Name = "txtSnom"
        Me.txtSnom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSnom.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSnom.PlaceholderText = ""
        Me.txtSnom.SelectedText = ""
        Me.txtSnom.ShadowDecoration.Parent = Me.txtSnom
        Me.txtSnom.Size = New System.Drawing.Size(220, 30)
        Me.txtSnom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSnom.TabIndex = 79
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
        Me.txtCedula.Location = New System.Drawing.Point(30, 85)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCedula.MaxLength = 8
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
        'lbDomi
        '
        Me.lbDomi.AutoSize = True
        Me.lbDomi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDomi.ForeColor = System.Drawing.Color.Silver
        Me.lbDomi.Location = New System.Drawing.Point(530, 188)
        Me.lbDomi.Name = "lbDomi"
        Me.lbDomi.Size = New System.Drawing.Size(76, 21)
        Me.lbDomi.TabIndex = 68
        Me.lbDomi.Text = "Domicilio"
        '
        'lbEdad
        '
        Me.lbEdad.AutoSize = True
        Me.lbEdad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEdad.ForeColor = System.Drawing.Color.Silver
        Me.lbEdad.Location = New System.Drawing.Point(32, 188)
        Me.lbEdad.Name = "lbEdad"
        Me.lbEdad.Size = New System.Drawing.Size(44, 21)
        Me.lbEdad.TabIndex = 66
        Me.lbEdad.Text = "Edad"
        '
        'lbTel
        '
        Me.lbTel.AutoSize = True
        Me.lbTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTel.ForeColor = System.Drawing.Color.Silver
        Me.lbTel.Location = New System.Drawing.Point(281, 184)
        Me.lbTel.Name = "lbTel"
        Me.lbTel.Size = New System.Drawing.Size(121, 21)
        Me.lbTel.TabIndex = 65
        Me.lbTel.Text = "Telefono Celular"
        '
        'lbSape
        '
        Me.lbSape.AutoSize = True
        Me.lbSape.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSape.ForeColor = System.Drawing.Color.Silver
        Me.lbSape.Location = New System.Drawing.Point(530, 121)
        Me.lbSape.Name = "lbSape"
        Me.lbSape.Size = New System.Drawing.Size(133, 21)
        Me.lbSape.TabIndex = 64
        Me.lbSape.Text = "Segundo Apellido"
        '
        'lbSnom
        '
        Me.lbSnom.AutoSize = True
        Me.lbSnom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSnom.ForeColor = System.Drawing.Color.Silver
        Me.lbSnom.Location = New System.Drawing.Point(281, 121)
        Me.lbSnom.Name = "lbSnom"
        Me.lbSnom.Size = New System.Drawing.Size(134, 21)
        Me.lbSnom.TabIndex = 63
        Me.lbSnom.Text = "Segundo Nombre"
        '
        'lbSexo
        '
        Me.lbSexo.AutoSize = True
        Me.lbSexo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSexo.ForeColor = System.Drawing.Color.Silver
        Me.lbSexo.Location = New System.Drawing.Point(30, 119)
        Me.lbSexo.Name = "lbSexo"
        Me.lbSexo.Size = New System.Drawing.Size(43, 21)
        Me.lbSexo.TabIndex = 62
        Me.lbSexo.Text = "Sexo"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCorreo.ForeColor = System.Drawing.Color.Silver
        Me.lbCorreo.Location = New System.Drawing.Point(30, 256)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(138, 21)
        Me.lbCorreo.TabIndex = 61
        Me.lbCorreo.Text = "Correo Electronico"
        '
        'lbPape
        '
        Me.lbPape.AutoSize = True
        Me.lbPape.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPape.ForeColor = System.Drawing.Color.Silver
        Me.lbPape.Location = New System.Drawing.Point(530, 60)
        Me.lbPape.Name = "lbPape"
        Me.lbPape.Size = New System.Drawing.Size(118, 21)
        Me.lbPape.TabIndex = 60
        Me.lbPape.Text = "Primer Apellido"
        '
        'lbPnom
        '
        Me.lbPnom.AutoSize = True
        Me.lbPnom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPnom.ForeColor = System.Drawing.Color.Silver
        Me.lbPnom.Location = New System.Drawing.Point(281, 59)
        Me.lbPnom.Name = "lbPnom"
        Me.lbPnom.Size = New System.Drawing.Size(119, 21)
        Me.lbPnom.TabIndex = 69
        Me.lbPnom.Text = "Primer Nombre"
        '
        'lbCi
        '
        Me.lbCi.AutoSize = True
        Me.lbCi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCi.ForeColor = System.Drawing.Color.Silver
        Me.lbCi.Location = New System.Drawing.Point(30, 59)
        Me.lbCi.Name = "lbCi"
        Me.lbCi.Size = New System.Drawing.Size(58, 21)
        Me.lbCi.TabIndex = 58
        Me.lbCi.Text = "Cedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(82, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "(Sin puntos ni guines)"
        '
        'FrmCrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(773, 398)
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtSape)
        Me.Controls.Add(Me.txtPape)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtPNom)
        Me.Controls.Add(Me.txtSnom)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lbDomi)
        Me.Controls.Add(Me.lbEdad)
        Me.Controls.Add(Me.lbTel)
        Me.Controls.Add(Me.lbSape)
        Me.Controls.Add(Me.lbSnom)
        Me.Controls.Add(Me.lbSexo)
        Me.Controls.Add(Me.lbCorreo)
        Me.Controls.Add(Me.lbPape)
        Me.Controls.Add(Me.lbPnom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbCi)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmCrearUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCrearUsuario"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnCrear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbSexo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtDomicilio As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEdad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSape As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPape As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPNom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSnom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCedula As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbDomi As Label
    Friend WithEvents lbEdad As Label
    Friend WithEvents lbTel As Label
    Friend WithEvents lbSape As Label
    Friend WithEvents lbSnom As Label
    Friend WithEvents lbSexo As Label
    Friend WithEvents lbCorreo As Label
    Friend WithEvents lbPape As Label
    Friend WithEvents lbPnom As Label
    Friend WithEvents lbCi As Label
    Friend WithEvents Label2 As Label
End Class
