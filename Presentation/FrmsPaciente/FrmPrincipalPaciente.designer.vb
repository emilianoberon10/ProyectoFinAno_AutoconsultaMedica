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
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAgendaMedica = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistorial = New Guna.UI2.WinForms.Guna2Button()
        Me.btnConsulta = New Guna.UI2.WinForms.Guna2Button()
        Me.lbInstrucciones = New System.Windows.Forms.Label()
        Me.PanelinfoPac = New System.Windows.Forms.Panel()
        Me.fotoPerfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnOpciones = New System.Windows.Forms.PictureBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.PanelChildFormPac = New System.Windows.Forms.Panel()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.PanelMenuPac.SuspendLayout()
        Me.PanelinfoPac.SuspendLayout()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenuPac
        '
        Me.PanelMenuPac.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PanelMenuPac.Controls.Add(Me.btnCerrar)
        Me.PanelMenuPac.Controls.Add(Me.btnAgendaMedica)
        Me.PanelMenuPac.Controls.Add(Me.btnHistorial)
        Me.PanelMenuPac.Controls.Add(Me.btnConsulta)
        Me.PanelMenuPac.Controls.Add(Me.lbInstrucciones)
        Me.PanelMenuPac.Controls.Add(Me.PanelinfoPac)
        Me.PanelMenuPac.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuPac.Location = New System.Drawing.Point(0, 37)
        Me.PanelMenuPac.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelMenuPac.Name = "PanelMenuPac"
        Me.PanelMenuPac.Size = New System.Drawing.Size(222, 683)
        Me.PanelMenuPac.TabIndex = 0
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
        Me.btnCerrar.Location = New System.Drawing.Point(0, 634)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCerrar.ShadowDecoration.Parent = Me.btnCerrar
        Me.btnCerrar.Size = New System.Drawing.Size(222, 46)
        Me.btnCerrar.TabIndex = 302
        Me.btnCerrar.Text = "CERRAR SESION"
        Me.btnCerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAgendaMedica
        '
        Me.btnAgendaMedica.Animated = True
        Me.btnAgendaMedica.BorderColor = System.Drawing.Color.Transparent
        Me.btnAgendaMedica.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgendaMedica.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnAgendaMedica.CheckedState.Parent = Me.btnAgendaMedica
        Me.btnAgendaMedica.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgendaMedica.CustomImages.Parent = Me.btnAgendaMedica
        Me.btnAgendaMedica.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnAgendaMedica.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendaMedica.ForeColor = System.Drawing.Color.White
        Me.btnAgendaMedica.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAgendaMedica.HoverState.Parent = Me.btnAgendaMedica
        Me.btnAgendaMedica.Image = Global.Presentation.My.Resources.Resources.agenda
        Me.btnAgendaMedica.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAgendaMedica.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnAgendaMedica.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnAgendaMedica.Location = New System.Drawing.Point(0, 283)
        Me.btnAgendaMedica.Name = "btnAgendaMedica"
        Me.btnAgendaMedica.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgendaMedica.ShadowDecoration.Parent = Me.btnAgendaMedica
        Me.btnAgendaMedica.Size = New System.Drawing.Size(222, 46)
        Me.btnAgendaMedica.TabIndex = 302
        Me.btnAgendaMedica.Text = "AGENDA MEDICA"
        Me.btnAgendaMedica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnHistorial
        '
        Me.btnHistorial.Animated = True
        Me.btnHistorial.BorderColor = System.Drawing.Color.Transparent
        Me.btnHistorial.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHistorial.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnHistorial.CheckedState.Parent = Me.btnHistorial
        Me.btnHistorial.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHistorial.CustomImages.Parent = Me.btnHistorial
        Me.btnHistorial.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnHistorial.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.ForeColor = System.Drawing.Color.White
        Me.btnHistorial.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnHistorial.HoverState.Parent = Me.btnHistorial
        Me.btnHistorial.Image = Global.Presentation.My.Resources.Resources.form
        Me.btnHistorial.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHistorial.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnHistorial.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnHistorial.Location = New System.Drawing.Point(0, 237)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHistorial.ShadowDecoration.Parent = Me.btnHistorial
        Me.btnHistorial.Size = New System.Drawing.Size(222, 46)
        Me.btnHistorial.TabIndex = 302
        Me.btnHistorial.Text = "HISTORIAL"
        Me.btnHistorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnConsulta
        '
        Me.btnConsulta.Animated = True
        Me.btnConsulta.BorderColor = System.Drawing.Color.Transparent
        Me.btnConsulta.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConsulta.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnConsulta.CheckedState.Parent = Me.btnConsulta
        Me.btnConsulta.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConsulta.CustomImages.Parent = Me.btnConsulta
        Me.btnConsulta.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnConsulta.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.ForeColor = System.Drawing.Color.White
        Me.btnConsulta.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnConsulta.HoverState.Parent = Me.btnConsulta
        Me.btnConsulta.Image = Global.Presentation.My.Resources.Resources.consulting
        Me.btnConsulta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConsulta.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnConsulta.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnConsulta.Location = New System.Drawing.Point(0, 191)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConsulta.ShadowDecoration.Parent = Me.btnConsulta
        Me.btnConsulta.Size = New System.Drawing.Size(222, 46)
        Me.btnConsulta.TabIndex = 302
        Me.btnConsulta.Text = "CONSULTAR"
        Me.btnConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbInstrucciones
        '
        Me.lbInstrucciones.AutoSize = True
        Me.lbInstrucciones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInstrucciones.Location = New System.Drawing.Point(1, 317)
        Me.lbInstrucciones.Name = "lbInstrucciones"
        Me.lbInstrucciones.Size = New System.Drawing.Size(0, 17)
        Me.lbInstrucciones.TabIndex = 1
        '
        'PanelinfoPac
        '
        Me.PanelinfoPac.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
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
        'fotoPerfil
        '
        Me.fotoPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fotoPerfil.Image = Global.Presentation.My.Resources.Resources.profileEmpty
        Me.fotoPerfil.Location = New System.Drawing.Point(47, 20)
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
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(75, 153)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(74, 19)
        Me.lbNombre.TabIndex = 0
        Me.lbNombre.Text = "NOMBRE"
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.PictureBox5)
        Me.TopPanel.Controls.Add(Me.lbTitulo)
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
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.Silver
        Me.lbTitulo.Location = New System.Drawing.Point(40, 6)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(369, 25)
        Me.lbTitulo.TabIndex = 8
        Me.lbTitulo.Text = "SISTEMA DE AUTOCONSULTA MEDICA"
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
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PanelMenuPac.ResumeLayout(False)
        Me.PanelMenuPac.PerformLayout()
        Me.PanelinfoPac.ResumeLayout(False)
        Me.PanelinfoPac.PerformLayout()
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
    Friend WithEvents lbInstrucciones As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents btnOpciones As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lbTitulo As Label
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents btnConsulta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAgendaMedica As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistorial As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents fotoPerfil As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
