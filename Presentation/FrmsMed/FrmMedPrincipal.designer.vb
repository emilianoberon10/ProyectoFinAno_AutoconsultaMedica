<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMedPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMedPrincipal))
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.app_titulo = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btn_soliChat = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_chats = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.fotoPerfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnOpciones = New System.Windows.Forms.PictureBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.panelChildMedico = New System.Windows.Forms.Panel()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.btnChangeLanguage = New System.Windows.Forms.PictureBox()
        Me.TopPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnChangeLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.PictureBox1)
        Me.TopPanel.Controls.Add(Me.app_titulo)
        Me.TopPanel.Controls.Add(Me.btnMinimize)
        Me.TopPanel.Controls.Add(Me.btnClose)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1024, 37)
        Me.TopPanel.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentation.My.Resources.Resources.isotipoProyectowhite
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'app_titulo
        '
        Me.app_titulo.AutoSize = True
        Me.app_titulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.app_titulo.ForeColor = System.Drawing.Color.Silver
        Me.app_titulo.Location = New System.Drawing.Point(39, 8)
        Me.app_titulo.Name = "app_titulo"
        Me.app_titulo.Size = New System.Drawing.Size(353, 25)
        Me.app_titulo.TabIndex = 3
        Me.app_titulo.Text = "SISTEMA DE AUTOCONSULTA MEDICA"
        '
        'btnMinimize
        '
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = Global.Presentation.My.Resources.Resources.Minimize_Icon
        Me.btnMinimize.Location = New System.Drawing.Point(961, 8)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Padding = New System.Windows.Forms.Padding(3)
        Me.btnMinimize.Size = New System.Drawing.Size(22, 22)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Presentation.My.Resources.Resources.Close_Icon
        Me.btnClose.Location = New System.Drawing.Point(993, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(3)
        Me.btnClose.Size = New System.Drawing.Size(22, 22)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btn_soliChat)
        Me.PanelMenu.Controls.Add(Me.btn_chats)
        Me.PanelMenu.Controls.Add(Me.btn_cerrarSesion)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 37)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(222, 683)
        Me.PanelMenu.TabIndex = 1
        '
        'btn_soliChat
        '
        Me.btn_soliChat.Animated = True
        Me.btn_soliChat.BorderColor = System.Drawing.Color.Transparent
        Me.btn_soliChat.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_soliChat.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_soliChat.CheckedState.Parent = Me.btn_soliChat
        Me.btn_soliChat.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_soliChat.CustomImages.Parent = Me.btn_soliChat
        Me.btn_soliChat.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_soliChat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_soliChat.ForeColor = System.Drawing.Color.White
        Me.btn_soliChat.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_soliChat.HoverState.Parent = Me.btn_soliChat
        Me.btn_soliChat.Image = Global.Presentation.My.Resources.Resources.question
        Me.btn_soliChat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_soliChat.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_soliChat.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_soliChat.Location = New System.Drawing.Point(0, 190)
        Me.btn_soliChat.Name = "btn_soliChat"
        Me.btn_soliChat.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_soliChat.ShadowDecoration.Parent = Me.btn_soliChat
        Me.btn_soliChat.Size = New System.Drawing.Size(222, 46)
        Me.btn_soliChat.TabIndex = 303
        Me.btn_soliChat.Text = "SOLICITUDES"
        Me.btn_soliChat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_chats
        '
        Me.btn_chats.Animated = True
        Me.btn_chats.BorderColor = System.Drawing.Color.Transparent
        Me.btn_chats.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_chats.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_chats.CheckedState.Parent = Me.btn_chats
        Me.btn_chats.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_chats.CustomImages.Parent = Me.btn_chats
        Me.btn_chats.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_chats.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_chats.ForeColor = System.Drawing.Color.White
        Me.btn_chats.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_chats.HoverState.Parent = Me.btn_chats
        Me.btn_chats.Image = Global.Presentation.My.Resources.Resources.chat
        Me.btn_chats.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_chats.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_chats.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_chats.Location = New System.Drawing.Point(0, 236)
        Me.btn_chats.Name = "btn_chats"
        Me.btn_chats.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_chats.ShadowDecoration.Parent = Me.btn_chats
        Me.btn_chats.Size = New System.Drawing.Size(222, 46)
        Me.btn_chats.TabIndex = 304
        Me.btn_chats.Text = "CHATS"
        Me.btn_chats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.btn_cerrarSesion.TabIndex = 305
        Me.btn_cerrarSesion.Text = "CERRAR SESION"
        Me.btn_cerrarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnChangeLanguage)
        Me.Panel3.Controls.Add(Me.fotoPerfil)
        Me.Panel3.Controls.Add(Me.btnOpciones)
        Me.Panel3.Controls.Add(Me.lbNombre)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(222, 184)
        Me.Panel3.TabIndex = 0
        '
        'fotoPerfil
        '
        Me.fotoPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fotoPerfil.Image = Global.Presentation.My.Resources.Resources.profileEmpty
        Me.fotoPerfil.Location = New System.Drawing.Point(47, 24)
        Me.fotoPerfil.Name = "fotoPerfil"
        Me.fotoPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.fotoPerfil.ShadowDecoration.Parent = Me.fotoPerfil
        Me.fotoPerfil.Size = New System.Drawing.Size(130, 130)
        Me.fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoPerfil.TabIndex = 306
        Me.fotoPerfil.TabStop = False
        '
        'btnOpciones
        '
        Me.btnOpciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpciones.Image = Global.Presentation.My.Resources.Resources.settings
        Me.btnOpciones.Location = New System.Drawing.Point(191, 6)
        Me.btnOpciones.Name = "btnOpciones"
        Me.btnOpciones.Size = New System.Drawing.Size(25, 25)
        Me.btnOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnOpciones.TabIndex = 8
        Me.btnOpciones.TabStop = False
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.Color.Silver
        Me.lbNombre.Location = New System.Drawing.Point(75, 157)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(74, 19)
        Me.lbNombre.TabIndex = 2
        Me.lbNombre.Text = "NOMBRE"
        '
        'panelChildMedico
        '
        Me.panelChildMedico.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.panelChildMedico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelChildMedico.Location = New System.Drawing.Point(222, 37)
        Me.panelChildMedico.Name = "panelChildMedico"
        Me.panelChildMedico.Size = New System.Drawing.Size(802, 683)
        Me.panelChildMedico.TabIndex = 2
        '
        'ofdFoto
        '
        Me.ofdFoto.FileName = "OpenFileDialog1"
        '
        'btnChangeLanguage
        '
        Me.btnChangeLanguage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeLanguage.Image = Global.Presentation.My.Resources.Resources.spain
        Me.btnChangeLanguage.Location = New System.Drawing.Point(8, 6)
        Me.btnChangeLanguage.Name = "btnChangeLanguage"
        Me.btnChangeLanguage.Size = New System.Drawing.Size(25, 25)
        Me.btnChangeLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnChangeLanguage.TabIndex = 10
        Me.btnChangeLanguage.TabStop = False
        '
        'FrmMedPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 720)
        Me.Controls.Add(Me.panelChildMedico)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMedPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMedPrincipal"
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnChangeLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelChildMedico As Panel
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents app_titulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnOpciones As PictureBox
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents btn_soliChat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_chats As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cerrarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents fotoPerfil As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnChangeLanguage As PictureBox
End Class
