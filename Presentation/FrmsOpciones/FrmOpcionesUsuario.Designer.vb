<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpcionesUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpcionesUsuario))
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.txtContraseña1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbCambiarContraseña = New System.Windows.Forms.Label()
        Me.lbActuDatos = New System.Windows.Forms.Label()
        Me.RecuperarPass_passNueva2 = New System.Windows.Forms.Label()
        Me.RecuperarPass_passNueva = New System.Windows.Forms.Label()
        Me.txtContraseña2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_modificar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPnom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPape = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEdad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSnom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSape = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_guardar = New Guna.UI2.WinForms.Guna2Button()
        Me.Persona_pNom = New System.Windows.Forms.Label()
        Me.Persona_sNom = New System.Windows.Forms.Label()
        Me.Persona_pApe = New System.Windows.Forms.Label()
        Me.Persona_sApe = New System.Windows.Forms.Label()
        Me.Persona_edad = New System.Windows.Forms.Label()
        Me.fotoPerfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.dgvDatosUsuario = New System.Windows.Forms.DataGridView()
        Me.lbSelecImagen = New System.Windows.Forms.Label()
        Me.txtTel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Persona_tel = New System.Windows.Forms.Label()
        Me.txtDir = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Persona_direccion = New System.Windows.Forms.Label()
        Me.txtContraActual = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Persona_pass = New System.Windows.Forms.Label()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatosUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbUsuario
        '
        Me.lbUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbUsuario.Location = New System.Drawing.Point(2, 9)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(554, 40)
        Me.lbUsuario.TabIndex = 0
        Me.lbUsuario.Text = "USUARIO"
        Me.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtContraseña1
        '
        Me.txtContraseña1.Animated = True
        Me.txtContraseña1.BorderThickness = 2
        Me.txtContraseña1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña1.DefaultText = ""
        Me.txtContraseña1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContraseña1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContraseña1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña1.DisabledState.Parent = Me.txtContraseña1
        Me.txtContraseña1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña1.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtContraseña1.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtContraseña1.FocusedState.Parent = Me.txtContraseña1
        Me.txtContraseña1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtContraseña1.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtContraseña1.HoverState.Parent = Me.txtContraseña1
        Me.txtContraseña1.Location = New System.Drawing.Point(10, 169)
        Me.txtContraseña1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContraseña1.Name = "txtContraseña1"
        Me.txtContraseña1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContraseña1.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtContraseña1.PlaceholderText = ""
        Me.txtContraseña1.SelectedText = ""
        Me.txtContraseña1.ShadowDecoration.Parent = Me.txtContraseña1
        Me.txtContraseña1.Size = New System.Drawing.Size(180, 30)
        Me.txtContraseña1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtContraseña1.TabIndex = 2
        Me.txtContraseña1.UseSystemPasswordChar = True
        '
        'lbCambiarContraseña
        '
        Me.lbCambiarContraseña.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCambiarContraseña.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbCambiarContraseña.Location = New System.Drawing.Point(2, 72)
        Me.lbCambiarContraseña.Name = "lbCambiarContraseña"
        Me.lbCambiarContraseña.Size = New System.Drawing.Size(554, 21)
        Me.lbCambiarContraseña.TabIndex = 3
        Me.lbCambiarContraseña.Text = "Cambiar Contraseña"
        Me.lbCambiarContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbActuDatos
        '
        Me.lbActuDatos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbActuDatos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbActuDatos.Location = New System.Drawing.Point(3, 204)
        Me.lbActuDatos.Name = "lbActuDatos"
        Me.lbActuDatos.Size = New System.Drawing.Size(554, 21)
        Me.lbActuDatos.TabIndex = 3
        Me.lbActuDatos.Text = "Actualizar Datos Personales"
        Me.lbActuDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RecuperarPass_passNueva2
        '
        Me.RecuperarPass_passNueva2.AutoSize = True
        Me.RecuperarPass_passNueva2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecuperarPass_passNueva2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RecuperarPass_passNueva2.Location = New System.Drawing.Point(213, 143)
        Me.RecuperarPass_passNueva2.Name = "RecuperarPass_passNueva2"
        Me.RecuperarPass_passNueva2.Size = New System.Drawing.Size(180, 21)
        Me.RecuperarPass_passNueva2.TabIndex = 16
        Me.RecuperarPass_passNueva2.Text = "Repita contraseña nueva"
        '
        'RecuperarPass_passNueva
        '
        Me.RecuperarPass_passNueva.AutoSize = True
        Me.RecuperarPass_passNueva.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecuperarPass_passNueva.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RecuperarPass_passNueva.Location = New System.Drawing.Point(10, 143)
        Me.RecuperarPass_passNueva.Name = "RecuperarPass_passNueva"
        Me.RecuperarPass_passNueva.Size = New System.Drawing.Size(135, 21)
        Me.RecuperarPass_passNueva.TabIndex = 17
        Me.RecuperarPass_passNueva.Text = "Contraseña nueva"
        '
        'txtContraseña2
        '
        Me.txtContraseña2.Animated = True
        Me.txtContraseña2.BorderThickness = 2
        Me.txtContraseña2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña2.DefaultText = ""
        Me.txtContraseña2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContraseña2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContraseña2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña2.DisabledState.Parent = Me.txtContraseña2
        Me.txtContraseña2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña2.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtContraseña2.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtContraseña2.FocusedState.Parent = Me.txtContraseña2
        Me.txtContraseña2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtContraseña2.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtContraseña2.HoverState.Parent = Me.txtContraseña2
        Me.txtContraseña2.Location = New System.Drawing.Point(213, 169)
        Me.txtContraseña2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContraseña2.Name = "txtContraseña2"
        Me.txtContraseña2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContraseña2.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtContraseña2.PlaceholderText = ""
        Me.txtContraseña2.SelectedText = ""
        Me.txtContraseña2.ShadowDecoration.Parent = Me.txtContraseña2
        Me.txtContraseña2.Size = New System.Drawing.Size(180, 30)
        Me.txtContraseña2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtContraseña2.TabIndex = 3
        Me.txtContraseña2.UseSystemPasswordChar = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Animated = True
        Me.btn_modificar.BackColor = System.Drawing.Color.Transparent
        Me.btn_modificar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_modificar.BorderRadius = 15
        Me.btn_modificar.BorderThickness = 2
        Me.btn_modificar.CheckedState.Parent = Me.btn_modificar
        Me.btn_modificar.CustomImages.Parent = Me.btn_modificar
        Me.btn_modificar.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_modificar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_modificar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_modificar.HoverState.Parent = Me.btn_modificar
        Me.btn_modificar.Location = New System.Drawing.Point(410, 163)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_modificar.ShadowDecoration.BorderRadius = 20
        Me.btn_modificar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_modificar.ShadowDecoration.Depth = 25
        Me.btn_modificar.ShadowDecoration.Enabled = True
        Me.btn_modificar.ShadowDecoration.Parent = Me.btn_modificar
        Me.btn_modificar.Size = New System.Drawing.Size(137, 36)
        Me.btn_modificar.TabIndex = 4
        Me.btn_modificar.Text = "MODIFICAR"
        '
        'txtPnom
        '
        Me.txtPnom.Animated = True
        Me.txtPnom.BorderThickness = 2
        Me.txtPnom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPnom.DefaultText = ""
        Me.txtPnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPnom.DisabledState.Parent = Me.txtPnom
        Me.txtPnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPnom.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtPnom.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtPnom.FocusedState.Parent = Me.txtPnom
        Me.txtPnom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPnom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPnom.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtPnom.HoverState.Parent = Me.txtPnom
        Me.txtPnom.Location = New System.Drawing.Point(11, 293)
        Me.txtPnom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPnom.Name = "txtPnom"
        Me.txtPnom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPnom.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPnom.PlaceholderText = ""
        Me.txtPnom.SelectedText = ""
        Me.txtPnom.ShadowDecoration.Parent = Me.txtPnom
        Me.txtPnom.Size = New System.Drawing.Size(180, 30)
        Me.txtPnom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPnom.TabIndex = 5
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
        Me.txtPape.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtPape.FocusedState.Parent = Me.txtPape
        Me.txtPape.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPape.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPape.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtPape.HoverState.Parent = Me.txtPape
        Me.txtPape.Location = New System.Drawing.Point(11, 369)
        Me.txtPape.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPape.Name = "txtPape"
        Me.txtPape.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPape.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPape.PlaceholderText = ""
        Me.txtPape.SelectedText = ""
        Me.txtPape.ShadowDecoration.Parent = Me.txtPape
        Me.txtPape.Size = New System.Drawing.Size(180, 30)
        Me.txtPape.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPape.TabIndex = 7
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
        Me.txtEdad.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtEdad.FocusedState.Parent = Me.txtEdad
        Me.txtEdad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtEdad.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtEdad.HoverState.Parent = Me.txtEdad
        Me.txtEdad.Location = New System.Drawing.Point(11, 437)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEdad.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtEdad.PlaceholderText = ""
        Me.txtEdad.SelectedText = ""
        Me.txtEdad.ShadowDecoration.Parent = Me.txtEdad
        Me.txtEdad.Size = New System.Drawing.Size(180, 30)
        Me.txtEdad.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtEdad.TabIndex = 9
        '
        'txtSnom
        '
        Me.txtSnom.Animated = True
        Me.txtSnom.BorderThickness = 2
        Me.txtSnom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSnom.DefaultText = ""
        Me.txtSnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSnom.DisabledState.Parent = Me.txtSnom
        Me.txtSnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSnom.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtSnom.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtSnom.FocusedState.Parent = Me.txtSnom
        Me.txtSnom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSnom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSnom.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtSnom.HoverState.Parent = Me.txtSnom
        Me.txtSnom.Location = New System.Drawing.Point(214, 293)
        Me.txtSnom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSnom.Name = "txtSnom"
        Me.txtSnom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSnom.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSnom.PlaceholderText = ""
        Me.txtSnom.SelectedText = ""
        Me.txtSnom.ShadowDecoration.Parent = Me.txtSnom
        Me.txtSnom.Size = New System.Drawing.Size(180, 30)
        Me.txtSnom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSnom.TabIndex = 6
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
        Me.txtSape.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtSape.FocusedState.Parent = Me.txtSape
        Me.txtSape.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSape.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSape.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtSape.HoverState.Parent = Me.txtSape
        Me.txtSape.Location = New System.Drawing.Point(214, 369)
        Me.txtSape.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSape.Name = "txtSape"
        Me.txtSape.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSape.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSape.PlaceholderText = ""
        Me.txtSape.SelectedText = ""
        Me.txtSape.ShadowDecoration.Parent = Me.txtSape
        Me.txtSape.Size = New System.Drawing.Size(180, 30)
        Me.txtSape.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSape.TabIndex = 8
        '
        'btn_guardar
        '
        Me.btn_guardar.Animated = True
        Me.btn_guardar.BackColor = System.Drawing.Color.Transparent
        Me.btn_guardar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_guardar.BorderRadius = 15
        Me.btn_guardar.BorderThickness = 2
        Me.btn_guardar.CheckedState.Parent = Me.btn_guardar
        Me.btn_guardar.CustomImages.Parent = Me.btn_guardar
        Me.btn_guardar.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_guardar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_guardar.HoverState.Parent = Me.btn_guardar
        Me.btn_guardar.Location = New System.Drawing.Point(403, 431)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_guardar.ShadowDecoration.BorderRadius = 20
        Me.btn_guardar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_guardar.ShadowDecoration.Depth = 25
        Me.btn_guardar.ShadowDecoration.Enabled = True
        Me.btn_guardar.ShadowDecoration.Parent = Me.btn_guardar
        Me.btn_guardar.Size = New System.Drawing.Size(137, 36)
        Me.btn_guardar.TabIndex = 9
        Me.btn_guardar.Text = "GUARDAR"
        '
        'Persona_pNom
        '
        Me.Persona_pNom.AutoSize = True
        Me.Persona_pNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_pNom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_pNom.Location = New System.Drawing.Point(11, 267)
        Me.Persona_pNom.Name = "Persona_pNom"
        Me.Persona_pNom.Size = New System.Drawing.Size(119, 21)
        Me.Persona_pNom.TabIndex = 17
        Me.Persona_pNom.Text = "Primer Nombre"
        '
        'Persona_sNom
        '
        Me.Persona_sNom.AutoSize = True
        Me.Persona_sNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_sNom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_sNom.Location = New System.Drawing.Point(214, 267)
        Me.Persona_sNom.Name = "Persona_sNom"
        Me.Persona_sNom.Size = New System.Drawing.Size(134, 21)
        Me.Persona_sNom.TabIndex = 17
        Me.Persona_sNom.Text = "Segundo Nombre"
        '
        'Persona_pApe
        '
        Me.Persona_pApe.AutoSize = True
        Me.Persona_pApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_pApe.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_pApe.Location = New System.Drawing.Point(11, 339)
        Me.Persona_pApe.Name = "Persona_pApe"
        Me.Persona_pApe.Size = New System.Drawing.Size(118, 21)
        Me.Persona_pApe.TabIndex = 17
        Me.Persona_pApe.Text = "Primer Apellido"
        '
        'Persona_sApe
        '
        Me.Persona_sApe.AutoSize = True
        Me.Persona_sApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_sApe.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_sApe.Location = New System.Drawing.Point(214, 339)
        Me.Persona_sApe.Name = "Persona_sApe"
        Me.Persona_sApe.Size = New System.Drawing.Size(133, 21)
        Me.Persona_sApe.TabIndex = 17
        Me.Persona_sApe.Text = "Segundo Apellido"
        '
        'Persona_edad
        '
        Me.Persona_edad.AutoSize = True
        Me.Persona_edad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_edad.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_edad.Location = New System.Drawing.Point(11, 411)
        Me.Persona_edad.Name = "Persona_edad"
        Me.Persona_edad.Size = New System.Drawing.Size(44, 21)
        Me.Persona_edad.TabIndex = 17
        Me.Persona_edad.Text = "Edad"
        '
        'fotoPerfil
        '
        Me.fotoPerfil.Image = Global.Presentation.My.Resources.Resources.profileEmpty
        Me.fotoPerfil.Location = New System.Drawing.Point(410, 293)
        Me.fotoPerfil.Name = "fotoPerfil"
        Me.fotoPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.fotoPerfil.ShadowDecoration.Parent = Me.fotoPerfil
        Me.fotoPerfil.Size = New System.Drawing.Size(130, 130)
        Me.fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoPerfil.TabIndex = 19
        Me.fotoPerfil.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'ofdFoto
        '
        Me.ofdFoto.FileName = "OpenFileDialog1"
        '
        'dgvDatosUsuario
        '
        Me.dgvDatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosUsuario.Location = New System.Drawing.Point(13, 561)
        Me.dgvDatosUsuario.Name = "dgvDatosUsuario"
        Me.dgvDatosUsuario.Size = New System.Drawing.Size(533, 10)
        Me.dgvDatosUsuario.TabIndex = 20
        Me.dgvDatosUsuario.Visible = False
        '
        'lbSelecImagen
        '
        Me.lbSelecImagen.AutoSize = True
        Me.lbSelecImagen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSelecImagen.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbSelecImagen.Location = New System.Drawing.Point(413, 273)
        Me.lbSelecImagen.Name = "lbSelecImagen"
        Me.lbSelecImagen.Size = New System.Drawing.Size(127, 17)
        Me.lbSelecImagen.TabIndex = 17
        Me.lbSelecImagen.Text = "De click en la imagen"
        '
        'txtTel
        '
        Me.txtTel.Animated = True
        Me.txtTel.BorderThickness = 2
        Me.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTel.DefaultText = ""
        Me.txtTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTel.DisabledState.Parent = Me.txtTel
        Me.txtTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTel.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtTel.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtTel.FocusedState.Parent = Me.txtTel
        Me.txtTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtTel.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtTel.HoverState.Parent = Me.txtTel
        Me.txtTel.Location = New System.Drawing.Point(213, 437)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTel.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtTel.PlaceholderText = ""
        Me.txtTel.SelectedText = ""
        Me.txtTel.ShadowDecoration.Parent = Me.txtTel
        Me.txtTel.Size = New System.Drawing.Size(180, 30)
        Me.txtTel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtTel.TabIndex = 10
        '
        'Persona_tel
        '
        Me.Persona_tel.AutoSize = True
        Me.Persona_tel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_tel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_tel.Location = New System.Drawing.Point(213, 411)
        Me.Persona_tel.Name = "Persona_tel"
        Me.Persona_tel.Size = New System.Drawing.Size(68, 21)
        Me.Persona_tel.TabIndex = 17
        Me.Persona_tel.Text = "Telefono"
        '
        'txtDir
        '
        Me.txtDir.Animated = True
        Me.txtDir.BorderThickness = 2
        Me.txtDir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDir.DefaultText = ""
        Me.txtDir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDir.DisabledState.Parent = Me.txtDir
        Me.txtDir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDir.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDir.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtDir.FocusedState.Parent = Me.txtDir
        Me.txtDir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtDir.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtDir.HoverState.Parent = Me.txtDir
        Me.txtDir.Location = New System.Drawing.Point(15, 505)
        Me.txtDir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDir.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtDir.PlaceholderText = ""
        Me.txtDir.SelectedText = ""
        Me.txtDir.ShadowDecoration.Parent = Me.txtDir
        Me.txtDir.Size = New System.Drawing.Size(379, 30)
        Me.txtDir.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtDir.TabIndex = 11
        '
        'Persona_direccion
        '
        Me.Persona_direccion.AutoSize = True
        Me.Persona_direccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_direccion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_direccion.Location = New System.Drawing.Point(15, 479)
        Me.Persona_direccion.Name = "Persona_direccion"
        Me.Persona_direccion.Size = New System.Drawing.Size(75, 21)
        Me.Persona_direccion.TabIndex = 17
        Me.Persona_direccion.Text = "Direccion"
        '
        'txtContraActual
        '
        Me.txtContraActual.Animated = True
        Me.txtContraActual.BorderThickness = 2
        Me.txtContraActual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraActual.DefaultText = ""
        Me.txtContraActual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContraActual.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContraActual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraActual.DisabledState.Parent = Me.txtContraActual
        Me.txtContraActual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraActual.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtContraActual.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtContraActual.FocusedState.Parent = Me.txtContraActual
        Me.txtContraActual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraActual.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtContraActual.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtContraActual.HoverState.Parent = Me.txtContraActual
        Me.txtContraActual.Location = New System.Drawing.Point(10, 108)
        Me.txtContraActual.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContraActual.Name = "txtContraActual"
        Me.txtContraActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContraActual.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtContraActual.PlaceholderText = ""
        Me.txtContraActual.SelectedText = ""
        Me.txtContraActual.ShadowDecoration.Parent = Me.txtContraActual
        Me.txtContraActual.Size = New System.Drawing.Size(180, 30)
        Me.txtContraActual.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtContraActual.TabIndex = 1
        Me.txtContraActual.UseSystemPasswordChar = True
        '
        'Persona_pass
        '
        Me.Persona_pass.AutoSize = True
        Me.Persona_pass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_pass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_pass.Location = New System.Drawing.Point(10, 82)
        Me.Persona_pass.Name = "Persona_pass"
        Me.Persona_pass.Size = New System.Drawing.Size(89, 21)
        Me.Persona_pass.TabIndex = 17
        Me.Persona_pass.Text = "Contraseña"
        '
        'FrmOpcionesUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(557, 583)
        Me.Controls.Add(Me.dgvDatosUsuario)
        Me.Controls.Add(Me.fotoPerfil)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.RecuperarPass_passNueva2)
        Me.Controls.Add(Me.Persona_sApe)
        Me.Controls.Add(Me.Persona_direccion)
        Me.Controls.Add(Me.Persona_tel)
        Me.Controls.Add(Me.Persona_edad)
        Me.Controls.Add(Me.Persona_pApe)
        Me.Controls.Add(Me.lbSelecImagen)
        Me.Controls.Add(Me.Persona_sNom)
        Me.Controls.Add(Me.Persona_pNom)
        Me.Controls.Add(Me.Persona_pass)
        Me.Controls.Add(Me.RecuperarPass_passNueva)
        Me.Controls.Add(Me.txtContraseña2)
        Me.Controls.Add(Me.txtSape)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtSnom)
        Me.Controls.Add(Me.txtPape)
        Me.Controls.Add(Me.txtPnom)
        Me.Controls.Add(Me.txtContraActual)
        Me.Controls.Add(Me.txtContraseña1)
        Me.Controls.Add(Me.lbActuDatos)
        Me.Controls.Add(Me.lbCambiarContraseña)
        Me.Controls.Add(Me.lbUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOpcionesUsuario"
        Me.Text = "FrmOpcionesUsuario"
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatosUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUsuario As Label
    Friend WithEvents txtContraseña1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbCambiarContraseña As Label
    Friend WithEvents lbActuDatos As Label
    Friend WithEvents RecuperarPass_passNueva2 As Label
    Friend WithEvents RecuperarPass_passNueva As Label
    Friend WithEvents txtContraseña2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_modificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPnom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPape As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEdad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSnom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSape As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_guardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Persona_pNom As Label
    Friend WithEvents Persona_sNom As Label
    Friend WithEvents Persona_pApe As Label
    Friend WithEvents Persona_sApe As Label
    Friend WithEvents Persona_edad As Label
    Friend WithEvents fotoPerfil As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents dgvDatosUsuario As DataGridView
    Friend WithEvents lbSelecImagen As Label
    Friend WithEvents Persona_direccion As Label
    Friend WithEvents Persona_tel As Label
    Friend WithEvents txtDir As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Persona_pass As Label
    Friend WithEvents txtContraActual As Guna.UI2.WinForms.Guna2TextBox
End Class
