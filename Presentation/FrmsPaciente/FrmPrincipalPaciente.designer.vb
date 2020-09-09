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
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAgendaMedica = New System.Windows.Forms.Button()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lbInstrucciones = New System.Windows.Forms.Label()
        Me.PanelinfoPac = New System.Windows.Forms.Panel()
        Me.fotoPerfil = New System.Windows.Forms.PictureBox()
        Me.btnOpciones = New System.Windows.Forms.PictureBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.PanelChildFormPac = New System.Windows.Forms.Panel()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.PanelMenuPac.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelMenuPac.Controls.Add(Me.PictureBox4)
        Me.PanelMenuPac.Controls.Add(Me.PictureBox3)
        Me.PanelMenuPac.Controls.Add(Me.PictureBox2)
        Me.PanelMenuPac.Controls.Add(Me.PictureBox1)
        Me.PanelMenuPac.Controls.Add(Me.btnAgendaMedica)
        Me.PanelMenuPac.Controls.Add(Me.btnConsulta)
        Me.PanelMenuPac.Controls.Add(Me.btnHistorial)
        Me.PanelMenuPac.Controls.Add(Me.btnCerrar)
        Me.PanelMenuPac.Controls.Add(Me.lbInstrucciones)
        Me.PanelMenuPac.Controls.Add(Me.PanelinfoPac)
        Me.PanelMenuPac.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuPac.Location = New System.Drawing.Point(0, 37)
        Me.PanelMenuPac.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelMenuPac.Name = "PanelMenuPac"
        Me.PanelMenuPac.Size = New System.Drawing.Size(222, 683)
        Me.PanelMenuPac.TabIndex = 0
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Presentation.My.Resources.Resources.logout
        Me.PictureBox4.Location = New System.Drawing.Point(5, 650)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 301
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Presentation.My.Resources.Resources.agenda
        Me.PictureBox3.Location = New System.Drawing.Point(5, 294)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 301
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Presentation.My.Resources.Resources.form
        Me.PictureBox2.Location = New System.Drawing.Point(4, 247)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 301
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentation.My.Resources.Resources.consulting
        Me.PictureBox1.Location = New System.Drawing.Point(4, 199)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 301
        Me.PictureBox1.TabStop = False
        '
        'btnAgendaMedica
        '
        Me.btnAgendaMedica.FlatAppearance.BorderSize = 0
        Me.btnAgendaMedica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnAgendaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendaMedica.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendaMedica.Location = New System.Drawing.Point(0, 285)
        Me.btnAgendaMedica.Name = "btnAgendaMedica"
        Me.btnAgendaMedica.Size = New System.Drawing.Size(222, 41)
        Me.btnAgendaMedica.TabIndex = 300
        Me.btnAgendaMedica.Text = "AGENDA MEDICA"
        Me.btnAgendaMedica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgendaMedica.UseVisualStyleBackColor = True
        '
        'btnConsulta
        '
        Me.btnConsulta.FlatAppearance.BorderSize = 0
        Me.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsulta.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.Location = New System.Drawing.Point(0, 191)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(222, 41)
        Me.btnConsulta.TabIndex = 300
        Me.btnConsulta.Text = "CONSULTAR"
        Me.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.FlatAppearance.BorderSize = 0
        Me.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorial.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.Location = New System.Drawing.Point(0, 238)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(222, 41)
        Me.btnHistorial.TabIndex = 300
        Me.btnHistorial.Text = "HISTORIAL"
        Me.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(0, 642)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(222, 41)
        Me.btnCerrar.TabIndex = 300
        Me.btnCerrar.Text = "CERRAR SESION"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = True
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
        Me.fotoPerfil.Location = New System.Drawing.Point(45, 20)
        Me.fotoPerfil.Name = "fotoPerfil"
        Me.fotoPerfil.Size = New System.Drawing.Size(130, 130)
        Me.fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoPerfil.TabIndex = 10
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
        Me.PictureBox5.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.Silver
        Me.lbTitulo.Location = New System.Drawing.Point(41, 8)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(345, 23)
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
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lbInstrucciones As Label
    Friend WithEvents btnAgendaMedica As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnConsulta As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnOpciones As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lbTitulo As Label
    Friend WithEvents fotoPerfil As PictureBox
    Friend WithEvents ofdFoto As OpenFileDialog
End Class
