<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipalPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipalPaciente))
        Me.PanelMenuPac = New System.Windows.Forms.Panel()
        Me.btn_cerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Agenda = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_historial = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_consultar = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelinfoPac = New System.Windows.Forms.Panel()
        Me.btnChangeLanguage = New System.Windows.Forms.PictureBox()
        Me.fotoPerfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnOpciones = New System.Windows.Forms.PictureBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.app_titulo = New System.Windows.Forms.Label()
        Me.PanelChildFormPac = New System.Windows.Forms.Panel()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.PanelMenuPac.SuspendLayout()
        Me.PanelinfoPac.SuspendLayout()
        CType(Me.btnChangeLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenuPac
        '
        Me.PanelMenuPac.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PanelMenuPac.Controls.Add(Me.btn_cerrarSesion)
        Me.PanelMenuPac.Controls.Add(Me.btn_Agenda)
        Me.PanelMenuPac.Controls.Add(Me.btn_historial)
        Me.PanelMenuPac.Controls.Add(Me.btn_consultar)
        Me.PanelMenuPac.Controls.Add(Me.PanelinfoPac)
        Me.PanelMenuPac.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuPac.Location = New System.Drawing.Point(0, 37)
        Me.PanelMenuPac.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelMenuPac.Name = "PanelMenuPac"
        Me.PanelMenuPac.Size = New System.Drawing.Size(222, 683)
        Me.PanelMenuPac.TabIndex = 0
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
        Me.btn_cerrarSesion.Location = New System.Drawing.Point(0, 636)
        Me.btn_cerrarSesion.Name = "btn_cerrarSesion"
        Me.btn_cerrarSesion.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cerrarSesion.ShadowDecoration.Parent = Me.btn_cerrarSesion
        Me.btn_cerrarSesion.Size = New System.Drawing.Size(222, 46)
        Me.btn_cerrarSesion.TabIndex = 302
        Me.btn_cerrarSesion.Text = "CERRAR SESION"
        Me.btn_cerrarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Agenda
        '
        Me.btn_Agenda.Animated = True
        Me.btn_Agenda.BorderColor = System.Drawing.Color.Transparent
        Me.btn_Agenda.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Agenda.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_Agenda.CheckedState.Parent = Me.btn_Agenda
        Me.btn_Agenda.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Agenda.CustomImages.Parent = Me.btn_Agenda
        Me.btn_Agenda.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_Agenda.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agenda.ForeColor = System.Drawing.Color.White
        Me.btn_Agenda.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_Agenda.HoverState.Parent = Me.btn_Agenda
        Me.btn_Agenda.Image = Global.Presentation.My.Resources.Resources.agenda
        Me.btn_Agenda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_Agenda.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_Agenda.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_Agenda.Location = New System.Drawing.Point(0, 277)
        Me.btn_Agenda.Name = "btn_Agenda"
        Me.btn_Agenda.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Agenda.ShadowDecoration.Parent = Me.btn_Agenda
        Me.btn_Agenda.Size = New System.Drawing.Size(222, 46)
        Me.btn_Agenda.TabIndex = 302
        Me.btn_Agenda.Text = "AGENDA MEDICA"
        Me.btn_Agenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_historial
        '
        Me.btn_historial.Animated = True
        Me.btn_historial.BorderColor = System.Drawing.Color.Transparent
        Me.btn_historial.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_historial.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_historial.CheckedState.Parent = Me.btn_historial
        Me.btn_historial.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_historial.CustomImages.Parent = Me.btn_historial
        Me.btn_historial.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_historial.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_historial.ForeColor = System.Drawing.Color.White
        Me.btn_historial.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_historial.HoverState.Parent = Me.btn_historial
        Me.btn_historial.Image = Global.Presentation.My.Resources.Resources.form
        Me.btn_historial.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_historial.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_historial.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_historial.Location = New System.Drawing.Point(0, 231)
        Me.btn_historial.Name = "btn_historial"
        Me.btn_historial.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_historial.ShadowDecoration.Parent = Me.btn_historial
        Me.btn_historial.Size = New System.Drawing.Size(222, 46)
        Me.btn_historial.TabIndex = 302
        Me.btn_historial.Text = "HISTORIAL"
        Me.btn_historial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_consultar
        '
        Me.btn_consultar.Animated = True
        Me.btn_consultar.BorderColor = System.Drawing.Color.Transparent
        Me.btn_consultar.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_consultar.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_consultar.CheckedState.Parent = Me.btn_consultar
        Me.btn_consultar.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_consultar.CustomImages.Parent = Me.btn_consultar
        Me.btn_consultar.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_consultar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar.ForeColor = System.Drawing.Color.White
        Me.btn_consultar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_consultar.HoverState.Parent = Me.btn_consultar
        Me.btn_consultar.Image = Global.Presentation.My.Resources.Resources.consulting
        Me.btn_consultar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_consultar.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_consultar.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_consultar.Location = New System.Drawing.Point(0, 185)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_consultar.ShadowDecoration.Parent = Me.btn_consultar
        Me.btn_consultar.Size = New System.Drawing.Size(222, 46)
        Me.btn_consultar.TabIndex = 302
        Me.btn_consultar.Text = "CONSULTAR"
        Me.btn_consultar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelinfoPac
        '
        Me.PanelinfoPac.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PanelinfoPac.Controls.Add(Me.btnChangeLanguage)
        Me.PanelinfoPac.Controls.Add(Me.fotoPerfil)
        Me.PanelinfoPac.Controls.Add(Me.btnOpciones)
        Me.PanelinfoPac.Controls.Add(Me.lbNombre)
        Me.PanelinfoPac.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelinfoPac.Location = New System.Drawing.Point(0, 0)
        Me.PanelinfoPac.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelinfoPac.Name = "PanelinfoPac"
        Me.PanelinfoPac.Size = New System.Drawing.Size(222, 184)
        Me.PanelinfoPac.TabIndex = 0
        '
        'btnChangeLanguage
        '
        Me.btnChangeLanguage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeLanguage.Image = Global.Presentation.My.Resources.Resources.spain
        Me.btnChangeLanguage.Location = New System.Drawing.Point(8, 10)
        Me.btnChangeLanguage.Name = "btnChangeLanguage"
        Me.btnChangeLanguage.Size = New System.Drawing.Size(25, 25)
        Me.btnChangeLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnChangeLanguage.TabIndex = 9
        Me.btnChangeLanguage.TabStop = False
        '
        'fotoPerfil
        '
        Me.fotoPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fotoPerfil.Image = Global.Presentation.My.Resources.Resources.profileEmpty
        Me.fotoPerfil.Location = New System.Drawing.Point(45, 10)
        Me.fotoPerfil.Name = "fotoPerfil"
        Me.fotoPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.fotoPerfil.ShadowDecoration.Parent = Me.fotoPerfil
        Me.fotoPerfil.Size = New System.Drawing.Size(130, 130)
        Me.fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoPerfil.TabIndex = 0
        Me.fotoPerfil.TabStop = False
        '
        'btnOpciones
        '
        Me.btnOpciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpciones.Image = Global.Presentation.My.Resources.Resources.settings
        Me.btnOpciones.Location = New System.Drawing.Point(189, 7)
        Me.btnOpciones.Name = "btnOpciones"
        Me.btnOpciones.Size = New System.Drawing.Size(25, 25)
        Me.btnOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnOpciones.TabIndex = 2
        Me.btnOpciones.TabStop = False
        '
        'lbNombre
        '
        Me.lbNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbNombre.Location = New System.Drawing.Point(0, 152)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(222, 19)
        Me.lbNombre.TabIndex = 0
        Me.lbNombre.Text = "NOMBRE"
        Me.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.PictureBox5)
        Me.TopPanel.Controls.Add(Me.app_titulo)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1024, 37)
        Me.TopPanel.TabIndex = 1
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Presentation.My.Resources.Resources.isotipoProyectowhite
        Me.PictureBox5.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'app_titulo
        '
        Me.app_titulo.AutoSize = True
        Me.app_titulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.app_titulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.app_titulo.Location = New System.Drawing.Point(40, 6)
        Me.app_titulo.Name = "app_titulo"
        Me.app_titulo.Size = New System.Drawing.Size(353, 25)
        Me.app_titulo.TabIndex = 8
        Me.app_titulo.Text = "SISTEMA DE AUTOCONSULTA MEDICA"
        '
        'PanelChildFormPac
        '
        Me.PanelChildFormPac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildFormPac.Location = New System.Drawing.Point(222, 37)
        Me.PanelChildFormPac.Name = "PanelChildFormPac"
        Me.PanelChildFormPac.Size = New System.Drawing.Size(802, 683)
        Me.PanelChildFormPac.TabIndex = 2
        '
        'ofdFoto
        '
        Me.ofdFoto.FileName = "OpenFileDialog1"
        '
        'FrmPrincipalPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 720)
        Me.Controls.Add(Me.PanelChildFormPac)
        Me.Controls.Add(Me.PanelMenuPac)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmPrincipalPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PanelMenuPac.ResumeLayout(False)
        Me.PanelinfoPac.ResumeLayout(False)
        CType(Me.btnChangeLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuPac As Panel
    Friend WithEvents PanelinfoPac As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents PanelChildFormPac As Panel
    Friend WithEvents lbNombre As Label
    Friend WithEvents btnOpciones As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents app_titulo As Label
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents btn_consultar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Agenda As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_historial As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cerrarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents fotoPerfil As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnChangeLanguage As PictureBox
End Class
