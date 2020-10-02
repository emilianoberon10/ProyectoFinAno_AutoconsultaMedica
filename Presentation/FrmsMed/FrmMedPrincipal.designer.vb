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
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSolicitudes = New Guna.UI2.WinForms.Guna2Button()
        Me.btnChats = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnOpciones = New System.Windows.Forms.PictureBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.panelChildMedico = New System.Windows.Forms.Panel()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.fotoPerfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.TopPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btnOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.PictureBox1)
        Me.TopPanel.Controls.Add(Me.lbTitulo)
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
        Me.PictureBox1.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.Silver
        Me.lbTitulo.Location = New System.Drawing.Point(48, 8)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(345, 23)
        Me.lbTitulo.TabIndex = 3
        Me.lbTitulo.Text = "SISTEMA DE AUTOCONSULTA MEDICA"
        '
        'btnMinimize
        '
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = Global.Presentation.My.Resources.Resources.Minimize_Icon
        Me.btnMinimize.Location = New System.Drawing.Point(964, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Presentation.My.Resources.Resources.Close_Icon
        Me.btnClose.Location = New System.Drawing.Point(996, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(16, 16)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSolicitudes)
        Me.Panel2.Controls.Add(Me.btnChats)
        Me.Panel2.Controls.Add(Me.btnCerrar)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(222, 683)
        Me.Panel2.TabIndex = 1
        '
        'btnSolicitudes
        '
        Me.btnSolicitudes.Animated = True
        Me.btnSolicitudes.BorderColor = System.Drawing.Color.Transparent
        Me.btnSolicitudes.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSolicitudes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnSolicitudes.CheckedState.Parent = Me.btnSolicitudes
        Me.btnSolicitudes.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSolicitudes.CustomImages.Parent = Me.btnSolicitudes
        Me.btnSolicitudes.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnSolicitudes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitudes.ForeColor = System.Drawing.Color.White
        Me.btnSolicitudes.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSolicitudes.HoverState.Parent = Me.btnSolicitudes
        Me.btnSolicitudes.Image = Global.Presentation.My.Resources.Resources.question
        Me.btnSolicitudes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSolicitudes.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnSolicitudes.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnSolicitudes.Location = New System.Drawing.Point(0, 190)
        Me.btnSolicitudes.Name = "btnSolicitudes"
        Me.btnSolicitudes.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSolicitudes.ShadowDecoration.Parent = Me.btnSolicitudes
        Me.btnSolicitudes.Size = New System.Drawing.Size(222, 46)
        Me.btnSolicitudes.TabIndex = 303
        Me.btnSolicitudes.Text = "SOLICITUDES"
        Me.btnSolicitudes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnChats
        '
        Me.btnChats.Animated = True
        Me.btnChats.BorderColor = System.Drawing.Color.Transparent
        Me.btnChats.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChats.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnChats.CheckedState.Parent = Me.btnChats
        Me.btnChats.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChats.CustomImages.Parent = Me.btnChats
        Me.btnChats.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnChats.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChats.ForeColor = System.Drawing.Color.White
        Me.btnChats.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnChats.HoverState.Parent = Me.btnChats
        Me.btnChats.Image = Global.Presentation.My.Resources.Resources.chat
        Me.btnChats.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnChats.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnChats.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnChats.Location = New System.Drawing.Point(0, 236)
        Me.btnChats.Name = "btnChats"
        Me.btnChats.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChats.ShadowDecoration.Parent = Me.btnChats
        Me.btnChats.Size = New System.Drawing.Size(222, 46)
        Me.btnChats.TabIndex = 304
        Me.btnChats.Text = "CHATS"
        Me.btnChats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCerrar
        '
        Me.btnCerrar.Animated = True
        Me.btnCerrar.BorderColor = System.Drawing.Color.Transparent
        Me.btnCerrar.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCerrar.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnCerrar.CheckedState.Parent = Me.btnCerrar
        Me.btnCerrar.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCerrar.CustomImages.Parent = Me.btnCerrar
        Me.btnCerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCerrar.HoverState.Parent = Me.btnCerrar
        Me.btnCerrar.Image = Global.Presentation.My.Resources.Resources.logout
        Me.btnCerrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCerrar.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnCerrar.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnCerrar.Location = New System.Drawing.Point(0, 637)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCerrar.ShadowDecoration.Parent = Me.btnCerrar
        Me.btnCerrar.Size = New System.Drawing.Size(222, 46)
        Me.btnCerrar.TabIndex = 305
        Me.btnCerrar.Text = "CERRAR SESION"
        Me.btnCerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel3.Controls.Add(Me.fotoPerfil)
        Me.Panel3.Controls.Add(Me.btnOpciones)
        Me.Panel3.Controls.Add(Me.lbNombre)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(222, 184)
        Me.Panel3.TabIndex = 0
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
        'FrmMedPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 720)
        Me.Controls.Add(Me.panelChildMedico)
        Me.Controls.Add(Me.Panel2)
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelChildMedico As Panel
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnOpciones As PictureBox
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents btnSolicitudes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnChats As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents fotoPerfil As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
