<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipalGerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipalGerente))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btn_dashBoard = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_eliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_modificar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_ingrMed = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnChangeLanguage = New System.Windows.Forms.PictureBox()
        Me.fotoPerfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnOpciones = New System.Windows.Forms.PictureBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.btn_patologia = New Guna.UI2.WinForms.Guna2Button()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.app_titulo = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.PanelMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnChangeLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btn_dashBoard)
        Me.PanelMenu.Controls.Add(Me.btn_eliminar)
        Me.PanelMenu.Controls.Add(Me.btn_modificar)
        Me.PanelMenu.Controls.Add(Me.btn_cerrarSesion)
        Me.PanelMenu.Controls.Add(Me.btn_ingrMed)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.btn_patologia)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 37)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(222, 683)
        Me.PanelMenu.TabIndex = 0
        '
        'btn_dashBoard
        '
        Me.btn_dashBoard.Animated = True
        Me.btn_dashBoard.BorderColor = System.Drawing.Color.Transparent
        Me.btn_dashBoard.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_dashBoard.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_dashBoard.CheckedState.Parent = Me.btn_dashBoard
        Me.btn_dashBoard.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_dashBoard.CustomImages.Parent = Me.btn_dashBoard
        Me.btn_dashBoard.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_dashBoard.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dashBoard.ForeColor = System.Drawing.Color.White
        Me.btn_dashBoard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_dashBoard.HoverState.Parent = Me.btn_dashBoard
        Me.btn_dashBoard.Image = Global.Presentation.My.Resources.Resources.dashboard
        Me.btn_dashBoard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_dashBoard.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_dashBoard.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_dashBoard.Location = New System.Drawing.Point(0, 381)
        Me.btn_dashBoard.Name = "btn_dashBoard"
        Me.btn_dashBoard.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_dashBoard.ShadowDecoration.Parent = Me.btn_dashBoard
        Me.btn_dashBoard.Size = New System.Drawing.Size(222, 46)
        Me.btn_dashBoard.TabIndex = 307
        Me.btn_dashBoard.Text = "DATOS USO"
        Me.btn_dashBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Animated = True
        Me.btn_eliminar.BorderColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_eliminar.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_eliminar.CheckedState.Parent = Me.btn_eliminar
        Me.btn_eliminar.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_eliminar.CustomImages.Parent = Me.btn_eliminar
        Me.btn_eliminar.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_eliminar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_eliminar.HoverState.Parent = Me.btn_eliminar
        Me.btn_eliminar.Image = Global.Presentation.My.Resources.Resources.column
        Me.btn_eliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_eliminar.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_eliminar.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_eliminar.Location = New System.Drawing.Point(0, 329)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_eliminar.ShadowDecoration.Parent = Me.btn_eliminar
        Me.btn_eliminar.Size = New System.Drawing.Size(222, 46)
        Me.btn_eliminar.TabIndex = 307
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_modificar
        '
        Me.btn_modificar.Animated = True
        Me.btn_modificar.BorderColor = System.Drawing.Color.Transparent
        Me.btn_modificar.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_modificar.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_modificar.CheckedState.Parent = Me.btn_modificar
        Me.btn_modificar.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_modificar.CustomImages.Parent = Me.btn_modificar
        Me.btn_modificar.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_modificar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.Color.White
        Me.btn_modificar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_modificar.HoverState.Parent = Me.btn_modificar
        Me.btn_modificar.Image = Global.Presentation.My.Resources.Resources.update
        Me.btn_modificar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_modificar.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_modificar.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_modificar.Location = New System.Drawing.Point(0, 283)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_modificar.ShadowDecoration.Parent = Me.btn_modificar
        Me.btn_modificar.Size = New System.Drawing.Size(222, 46)
        Me.btn_modificar.TabIndex = 306
        Me.btn_modificar.Text = "MODIFICAR"
        Me.btn_modificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_cerrarSesion
        '
        Me.btn_cerrarSesion.Animated = True
        Me.btn_cerrarSesion.BorderColor = System.Drawing.Color.Transparent
        Me.btn_cerrarSesion.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cerrarSesion.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_cerrarSesion.CheckedState.Parent = Me.btn_cerrarSesion
        Me.btn_cerrarSesion.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cerrarSesion.CustomImages.Parent = Me.btn_cerrarSesion
        Me.btn_cerrarSesion.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_cerrarSesion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btn_cerrarSesion.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_cerrarSesion.HoverState.Parent = Me.btn_cerrarSesion
        Me.btn_cerrarSesion.Image = Global.Presentation.My.Resources.Resources.logout
        Me.btn_cerrarSesion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_cerrarSesion.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_cerrarSesion.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_cerrarSesion.Location = New System.Drawing.Point(0, 637)
        Me.btn_cerrarSesion.Name = "btn_cerrarSesion"
        Me.btn_cerrarSesion.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cerrarSesion.ShadowDecoration.Parent = Me.btn_cerrarSesion
        Me.btn_cerrarSesion.Size = New System.Drawing.Size(222, 46)
        Me.btn_cerrarSesion.TabIndex = 306
        Me.btn_cerrarSesion.Text = "CERRAR SESION"
        Me.btn_cerrarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_ingrMed
        '
        Me.btn_ingrMed.Animated = True
        Me.btn_ingrMed.BorderColor = System.Drawing.Color.Transparent
        Me.btn_ingrMed.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_ingrMed.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_ingrMed.CheckedState.Parent = Me.btn_ingrMed
        Me.btn_ingrMed.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_ingrMed.CustomImages.Parent = Me.btn_ingrMed
        Me.btn_ingrMed.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_ingrMed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingrMed.ForeColor = System.Drawing.Color.White
        Me.btn_ingrMed.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_ingrMed.HoverState.Parent = Me.btn_ingrMed
        Me.btn_ingrMed.Image = Global.Presentation.My.Resources.Resources.file_upload
        Me.btn_ingrMed.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_ingrMed.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_ingrMed.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_ingrMed.Location = New System.Drawing.Point(0, 237)
        Me.btn_ingrMed.Name = "btn_ingrMed"
        Me.btn_ingrMed.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_ingrMed.ShadowDecoration.Parent = Me.btn_ingrMed
        Me.btn_ingrMed.Size = New System.Drawing.Size(222, 46)
        Me.btn_ingrMed.TabIndex = 305
        Me.btn_ingrMed.Text = "MEDICOS"
        Me.btn_ingrMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnChangeLanguage)
        Me.Panel2.Controls.Add(Me.fotoPerfil)
        Me.Panel2.Controls.Add(Me.btnOpciones)
        Me.Panel2.Controls.Add(Me.lbNombre)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(222, 184)
        Me.Panel2.TabIndex = 0
        '
        'btnChangeLanguage
        '
        Me.btnChangeLanguage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeLanguage.Image = Global.Presentation.My.Resources.Resources.spain
        Me.btnChangeLanguage.Location = New System.Drawing.Point(11, 7)
        Me.btnChangeLanguage.Name = "btnChangeLanguage"
        Me.btnChangeLanguage.Size = New System.Drawing.Size(25, 25)
        Me.btnChangeLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnChangeLanguage.TabIndex = 10
        Me.btnChangeLanguage.TabStop = False
        '
        'fotoPerfil
        '
        Me.fotoPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fotoPerfil.Image = Global.Presentation.My.Resources.Resources.profileEmpty
        Me.fotoPerfil.Location = New System.Drawing.Point(46, 27)
        Me.fotoPerfil.Name = "fotoPerfil"
        Me.fotoPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.fotoPerfil.ShadowDecoration.Parent = Me.fotoPerfil
        Me.fotoPerfil.Size = New System.Drawing.Size(130, 130)
        Me.fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoPerfil.TabIndex = 308
        Me.fotoPerfil.TabStop = False
        '
        'btnOpciones
        '
        Me.btnOpciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpciones.Image = Global.Presentation.My.Resources.Resources.settings
        Me.btnOpciones.Location = New System.Drawing.Point(191, 7)
        Me.btnOpciones.Name = "btnOpciones"
        Me.btnOpciones.Size = New System.Drawing.Size(24, 24)
        Me.btnOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnOpciones.TabIndex = 3
        Me.btnOpciones.TabStop = False
        '
        'lbNombre
        '
        Me.lbNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbNombre.Location = New System.Drawing.Point(0, 162)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(222, 19)
        Me.lbNombre.TabIndex = 2
        Me.lbNombre.Text = "NOMBRE"
        Me.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_patologia
        '
        Me.btn_patologia.Animated = True
        Me.btn_patologia.BorderColor = System.Drawing.Color.Transparent
        Me.btn_patologia.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_patologia.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_patologia.CheckedState.Parent = Me.btn_patologia
        Me.btn_patologia.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_patologia.CustomImages.Parent = Me.btn_patologia
        Me.btn_patologia.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_patologia.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_patologia.ForeColor = System.Drawing.Color.White
        Me.btn_patologia.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_patologia.HoverState.Parent = Me.btn_patologia
        Me.btn_patologia.Image = Global.Presentation.My.Resources.Resources.file_upload
        Me.btn_patologia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_patologia.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_patologia.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_patologia.Location = New System.Drawing.Point(0, 191)
        Me.btn_patologia.Name = "btn_patologia"
        Me.btn_patologia.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_patologia.ShadowDecoration.Parent = Me.btn_patologia
        Me.btn_patologia.Size = New System.Drawing.Size(222, 46)
        Me.btn_patologia.TabIndex = 304
        Me.btn_patologia.Text = "PATOLOGIAS"
        Me.btn_patologia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.PictureBox1)
        Me.TopPanel.Controls.Add(Me.btnClose)
        Me.TopPanel.Controls.Add(Me.app_titulo)
        Me.TopPanel.Controls.Add(Me.btnMinimize)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1024, 37)
        Me.TopPanel.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentation.My.Resources.Resources.isotipoProyectowhite
        Me.PictureBox1.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Presentation.My.Resources.Resources.Close_Icon
        Me.btnClose.Location = New System.Drawing.Point(990, 8)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(3)
        Me.btnClose.Size = New System.Drawing.Size(22, 22)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        '
        'app_titulo
        '
        Me.app_titulo.AutoSize = True
        Me.app_titulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.app_titulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.app_titulo.Location = New System.Drawing.Point(42, 8)
        Me.app_titulo.Name = "app_titulo"
        Me.app_titulo.Size = New System.Drawing.Size(353, 25)
        Me.app_titulo.TabIndex = 8
        Me.app_titulo.Text = "SISTEMA DE AUTOCONSULTA MEDICA"
        '
        'btnMinimize
        '
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = Global.Presentation.My.Resources.Resources.Minimize_Icon
        Me.btnMinimize.Location = New System.Drawing.Point(962, 8)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Padding = New System.Windows.Forms.Padding(3)
        Me.btnMinimize.Size = New System.Drawing.Size(22, 22)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.TabStop = False
        '
        'PanelChildForm
        '
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelChildForm.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PanelChildForm.Location = New System.Drawing.Point(222, 37)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(802, 683)
        Me.PanelChildForm.TabIndex = 2
        '
        'ofdFoto
        '
        Me.ofdFoto.FileName = "OpenFileDialog1"
        '
        'FrmPrincipalGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 720)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmPrincipalGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.btnChangeLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents lbNombre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents app_titulo As Label
    Friend WithEvents btnOpciones As PictureBox
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents btn_eliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_modificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_ingrMed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_patologia As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cerrarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents fotoPerfil As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnChangeLanguage As PictureBox
    Friend WithEvents btn_dashBoard As Guna.UI2.WinForms.Guna2Button
End Class
