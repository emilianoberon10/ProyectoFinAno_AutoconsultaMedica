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
        Me.llbCrearUsuario = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn_crear = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cancelar = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Persona_domicilio = New System.Windows.Forms.Label()
        Me.Persona_edad = New System.Windows.Forms.Label()
        Me.Persona_tel = New System.Windows.Forms.Label()
        Me.Persona_sApe = New System.Windows.Forms.Label()
        Me.Persona_sNom = New System.Windows.Forms.Label()
        Me.Persona_sexo = New System.Windows.Forms.Label()
        Me.Persona_correo = New System.Windows.Forms.Label()
        Me.Persona_pApe = New System.Windows.Forms.Label()
        Me.Persona_pNom = New System.Windows.Forms.Label()
        Me.Persona_ci = New System.Windows.Forms.Label()
        Me.Persona_aclaracionCi = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'llbCrearUsuario
        '
        Me.llbCrearUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbCrearUsuario.ForeColor = System.Drawing.Color.Silver
        Me.ErrorProvider1.SetIconAlignment(Me.llbCrearUsuario, System.Windows.Forms.ErrorIconAlignment.TopRight)
        Me.ErrorProvider1.SetIconPadding(Me.llbCrearUsuario, 5)
        Me.llbCrearUsuario.Location = New System.Drawing.Point(1, 9)
        Me.llbCrearUsuario.Name = "llbCrearUsuario"
        Me.llbCrearUsuario.Size = New System.Drawing.Size(772, 40)
        Me.llbCrearUsuario.TabIndex = 0
        Me.llbCrearUsuario.Text = "CREAR NUEVO USUARIO"
        Me.llbCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'btn_crear
        '
        Me.btn_crear.Animated = True
        Me.btn_crear.BackColor = System.Drawing.Color.Transparent
        Me.btn_crear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_crear.BorderRadius = 15
        Me.btn_crear.BorderThickness = 2
        Me.btn_crear.CheckedState.Parent = Me.btn_crear
        Me.btn_crear.CustomImages.Parent = Me.btn_crear
        Me.btn_crear.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_crear.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_crear.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_crear.HoverState.Parent = Me.btn_crear
        Me.btn_crear.Location = New System.Drawing.Point(494, 272)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_crear.ShadowDecoration.BorderRadius = 20
        Me.btn_crear.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_crear.ShadowDecoration.Depth = 25
        Me.btn_crear.ShadowDecoration.Enabled = True
        Me.btn_crear.ShadowDecoration.Parent = Me.btn_crear
        Me.btn_crear.Size = New System.Drawing.Size(267, 36)
        Me.btn_crear.TabIndex = 15
        Me.btn_crear.Text = "CREAR"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Animated = True
        Me.btn_cancelar.AutoRoundedCorners = True
        Me.btn_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancelar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cancelar.BorderRadius = 14
        Me.btn_cancelar.BorderThickness = 2
        Me.btn_cancelar.CheckedState.Parent = Me.btn_cancelar
        Me.btn_cancelar.CustomImages.Parent = Me.btn_cancelar
        Me.btn_cancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancelar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_cancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_cancelar.HoverState.Parent = Me.btn_cancelar
        Me.btn_cancelar.Location = New System.Drawing.Point(30, 355)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_cancelar.ShadowDecoration.BorderRadius = 20
        Me.btn_cancelar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cancelar.ShadowDecoration.Depth = 25
        Me.btn_cancelar.ShadowDecoration.Enabled = True
        Me.btn_cancelar.ShadowDecoration.Parent = Me.btn_cancelar
        Me.btn_cancelar.Size = New System.Drawing.Size(94, 31)
        Me.btn_cancelar.TabIndex = 15
        Me.btn_cancelar.Text = "CANCELAR"
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
        'Persona_domicilio
        '
        Me.Persona_domicilio.AutoSize = True
        Me.Persona_domicilio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_domicilio.ForeColor = System.Drawing.Color.Silver
        Me.Persona_domicilio.Location = New System.Drawing.Point(530, 188)
        Me.Persona_domicilio.Name = "Persona_domicilio"
        Me.Persona_domicilio.Size = New System.Drawing.Size(76, 21)
        Me.Persona_domicilio.TabIndex = 68
        Me.Persona_domicilio.Text = "Domicilio"
        '
        'Persona_edad
        '
        Me.Persona_edad.AutoSize = True
        Me.Persona_edad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_edad.ForeColor = System.Drawing.Color.Silver
        Me.Persona_edad.Location = New System.Drawing.Point(32, 188)
        Me.Persona_edad.Name = "Persona_edad"
        Me.Persona_edad.Size = New System.Drawing.Size(44, 21)
        Me.Persona_edad.TabIndex = 66
        Me.Persona_edad.Text = "Edad"
        '
        'Persona_tel
        '
        Me.Persona_tel.AutoSize = True
        Me.Persona_tel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_tel.ForeColor = System.Drawing.Color.Silver
        Me.Persona_tel.Location = New System.Drawing.Point(281, 184)
        Me.Persona_tel.Name = "Persona_tel"
        Me.Persona_tel.Size = New System.Drawing.Size(121, 21)
        Me.Persona_tel.TabIndex = 65
        Me.Persona_tel.Text = "Telefono Celular"
        '
        'Persona_sApe
        '
        Me.Persona_sApe.AutoSize = True
        Me.Persona_sApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_sApe.ForeColor = System.Drawing.Color.Silver
        Me.Persona_sApe.Location = New System.Drawing.Point(530, 121)
        Me.Persona_sApe.Name = "Persona_sApe"
        Me.Persona_sApe.Size = New System.Drawing.Size(133, 21)
        Me.Persona_sApe.TabIndex = 64
        Me.Persona_sApe.Text = "Segundo Apellido"
        '
        'Persona_sNom
        '
        Me.Persona_sNom.AutoSize = True
        Me.Persona_sNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_sNom.ForeColor = System.Drawing.Color.Silver
        Me.Persona_sNom.Location = New System.Drawing.Point(281, 121)
        Me.Persona_sNom.Name = "Persona_sNom"
        Me.Persona_sNom.Size = New System.Drawing.Size(134, 21)
        Me.Persona_sNom.TabIndex = 63
        Me.Persona_sNom.Text = "Segundo Nombre"
        '
        'Persona_sexo
        '
        Me.Persona_sexo.AutoSize = True
        Me.Persona_sexo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_sexo.ForeColor = System.Drawing.Color.Silver
        Me.Persona_sexo.Location = New System.Drawing.Point(30, 119)
        Me.Persona_sexo.Name = "Persona_sexo"
        Me.Persona_sexo.Size = New System.Drawing.Size(43, 21)
        Me.Persona_sexo.TabIndex = 62
        Me.Persona_sexo.Text = "Sexo"
        '
        'Persona_correo
        '
        Me.Persona_correo.AutoSize = True
        Me.Persona_correo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_correo.ForeColor = System.Drawing.Color.Silver
        Me.Persona_correo.Location = New System.Drawing.Point(30, 256)
        Me.Persona_correo.Name = "Persona_correo"
        Me.Persona_correo.Size = New System.Drawing.Size(138, 21)
        Me.Persona_correo.TabIndex = 61
        Me.Persona_correo.Text = "Correo Electronico"
        '
        'Persona_pApe
        '
        Me.Persona_pApe.AutoSize = True
        Me.Persona_pApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_pApe.ForeColor = System.Drawing.Color.Silver
        Me.Persona_pApe.Location = New System.Drawing.Point(530, 60)
        Me.Persona_pApe.Name = "Persona_pApe"
        Me.Persona_pApe.Size = New System.Drawing.Size(118, 21)
        Me.Persona_pApe.TabIndex = 60
        Me.Persona_pApe.Text = "Primer Apellido"
        '
        'Persona_pNom
        '
        Me.Persona_pNom.AutoSize = True
        Me.Persona_pNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_pNom.ForeColor = System.Drawing.Color.Silver
        Me.Persona_pNom.Location = New System.Drawing.Point(281, 59)
        Me.Persona_pNom.Name = "Persona_pNom"
        Me.Persona_pNom.Size = New System.Drawing.Size(119, 21)
        Me.Persona_pNom.TabIndex = 69
        Me.Persona_pNom.Text = "Primer Nombre"
        '
        'Persona_ci
        '
        Me.Persona_ci.AutoSize = True
        Me.Persona_ci.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_ci.ForeColor = System.Drawing.Color.Silver
        Me.Persona_ci.Location = New System.Drawing.Point(30, 59)
        Me.Persona_ci.Name = "Persona_ci"
        Me.Persona_ci.Size = New System.Drawing.Size(58, 21)
        Me.Persona_ci.TabIndex = 58
        Me.Persona_ci.Text = "Cedula"
        '
        'Persona_aclaracionCi
        '
        Me.Persona_aclaracionCi.AutoSize = True
        Me.Persona_aclaracionCi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_aclaracionCi.ForeColor = System.Drawing.Color.Silver
        Me.Persona_aclaracionCi.Location = New System.Drawing.Point(33, 42)
        Me.Persona_aclaracionCi.Name = "Persona_aclaracionCi"
        Me.Persona_aclaracionCi.Size = New System.Drawing.Size(126, 17)
        Me.Persona_aclaracionCi.TabIndex = 58
        Me.Persona_aclaracionCi.Text = "(Sin puntos ni guines)"
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
        Me.Controls.Add(Me.Persona_domicilio)
        Me.Controls.Add(Me.Persona_edad)
        Me.Controls.Add(Me.Persona_tel)
        Me.Controls.Add(Me.Persona_sApe)
        Me.Controls.Add(Me.Persona_sNom)
        Me.Controls.Add(Me.Persona_sexo)
        Me.Controls.Add(Me.Persona_correo)
        Me.Controls.Add(Me.Persona_pApe)
        Me.Controls.Add(Me.Persona_pNom)
        Me.Controls.Add(Me.Persona_aclaracionCi)
        Me.Controls.Add(Me.Persona_ci)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.llbCrearUsuario)
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

    Friend WithEvents llbCrearUsuario As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btn_crear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cancelar As Guna.UI2.WinForms.Guna2Button
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
    Friend WithEvents Persona_domicilio As Label
    Friend WithEvents Persona_edad As Label
    Friend WithEvents Persona_tel As Label
    Friend WithEvents Persona_sApe As Label
    Friend WithEvents Persona_sNom As Label
    Friend WithEvents Persona_sexo As Label
    Friend WithEvents Persona_correo As Label
    Friend WithEvents Persona_pApe As Label
    Friend WithEvents Persona_pNom As Label
    Friend WithEvents Persona_ci As Label
    Friend WithEvents Persona_aclaracionCi As Label
End Class
