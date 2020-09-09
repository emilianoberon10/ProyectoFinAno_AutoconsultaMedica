<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipalGerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipalGerente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnIngresarMedico = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.fotoPerfil = New System.Windows.Forms.PictureBox()
        Me.btnOpciones = New System.Windows.Forms.PictureBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnIngresarMedico)
        Me.Panel1.Controls.Add(Me.btnIngresar)
        Me.Panel1.Controls.Add(Me.BtnEliminar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 683)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Presentation.My.Resources.Resources.logout
        Me.PictureBox5.Location = New System.Drawing.Point(11, 650)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 302
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Presentation.My.Resources.Resources.column
        Me.PictureBox4.Location = New System.Drawing.Point(11, 343)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 302
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Presentation.My.Resources.Resources.update
        Me.PictureBox3.Location = New System.Drawing.Point(11, 293)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 302
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Presentation.My.Resources.Resources.file_upload
        Me.PictureBox6.Location = New System.Drawing.Point(11, 200)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 302
        Me.PictureBox6.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Presentation.My.Resources.Resources.file_upload
        Me.PictureBox2.Location = New System.Drawing.Point(11, 247)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 302
        Me.PictureBox2.TabStop = False
        '
        'btnIngresarMedico
        '
        Me.btnIngresarMedico.FlatAppearance.BorderSize = 0
        Me.btnIngresarMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnIngresarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarMedico.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarMedico.Location = New System.Drawing.Point(0, 239)
        Me.btnIngresarMedico.Name = "btnIngresarMedico"
        Me.btnIngresarMedico.Size = New System.Drawing.Size(222, 41)
        Me.btnIngresarMedico.TabIndex = 300
        Me.btnIngresarMedico.Text = "MEDICOS"
        Me.btnIngresarMedico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIngresarMedico.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(0, 192)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(222, 41)
        Me.btnIngresar.TabIndex = 300
        Me.btnIngresar.Text = "PATOLOGIAS"
        Me.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(0, 335)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(222, 41)
        Me.BtnEliminar.TabIndex = 300
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(0, 285)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(222, 41)
        Me.btnModificar.TabIndex = 300
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(0, 642)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(222, 41)
        Me.btnLogOut.TabIndex = 300
        Me.btnLogOut.Text = "CERRAR SESION"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
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
        'fotoPerfil
        '
        Me.fotoPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fotoPerfil.Image = Global.Presentation.My.Resources.Resources.profileEmpty
        Me.fotoPerfil.Location = New System.Drawing.Point(46, 16)
        Me.fotoPerfil.Name = "fotoPerfil"
        Me.fotoPerfil.Size = New System.Drawing.Size(130, 130)
        Me.fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoPerfil.TabIndex = 4
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
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(76, 149)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(74, 19)
        Me.lbNombre.TabIndex = 2
        Me.lbNombre.Text = "NOMBRE"
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.PictureBox1)
        Me.TopPanel.Controls.Add(Me.btnClose)
        Me.TopPanel.Controls.Add(Me.lbTitulo)
        Me.TopPanel.Controls.Add(Me.btnMinimize)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(997, 37)
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
        Me.btnClose.Location = New System.Drawing.Point(969, 11)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(16, 16)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.Silver
        Me.lbTitulo.Location = New System.Drawing.Point(42, 8)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(345, 23)
        Me.lbTitulo.TabIndex = 8
        Me.lbTitulo.Text = "SISTEMA DE AUTOCONSULTA MEDICA"
        '
        'btnMinimize
        '
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = Global.Presentation.My.Resources.Resources.Minimize_Icon
        Me.btnMinimize.Location = New System.Drawing.Point(947, 11)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.TabStop = False
        '
        'PanelChildForm
        '
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(222, 37)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(775, 683)
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
        Me.ClientSize = New System.Drawing.Size(997, 720)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmPrincipalGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.fotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnIngresarMedico As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbTitulo As Label
    Friend WithEvents btnOpciones As PictureBox
    Friend WithEvents fotoPerfil As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents ofdFoto As OpenFileDialog
End Class
