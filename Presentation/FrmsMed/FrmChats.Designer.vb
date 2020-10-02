<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChats))
        Me.txtDiagnostico = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEnviarMensaje = New Guna.UI2.WinForms.Guna2Button()
        Me.btnModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVerFichaMedica = New Guna.UI2.WinForms.Guna2Button()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnostico.Location = New System.Drawing.Point(5, 713)
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(178, 29)
        Me.txtDiagnostico.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(5, 692)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Diagnostico"
        '
        'txtMensaje
        '
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(5, 659)
        Me.txtMensaje.MaxLength = 255
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(458, 30)
        Me.txtMensaje.TabIndex = 1
        '
        'txtChat
        '
        Me.txtChat.BackColor = System.Drawing.Color.White
        Me.txtChat.Enabled = False
        Me.txtChat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChat.ForeColor = System.Drawing.Color.Black
        Me.txtChat.Location = New System.Drawing.Point(5, 78)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChat.Size = New System.Drawing.Size(575, 576)
        Me.txtChat.TabIndex = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'DataRepeater1
        '
        Me.DataRepeater1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.DataRepeater1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataRepeater1.ForeColor = System.Drawing.Color.Silver
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Label2)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.DataRepeater1.ItemTemplate.Margin = New System.Windows.Forms.Padding(2)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(184, 35)
        Me.DataRepeater1.Location = New System.Drawing.Point(586, 28)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(192, 731)
        Me.DataRepeater1.TabIndex = 11
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.Presentation.My.Resources.Resources.profileEmpty
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(2, 5)
        Me.Guna2CirclePictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(22, 23)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
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
        Me.TopPanel.Size = New System.Drawing.Size(778, 28)
        Me.TopPanel.TabIndex = 12
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Presentation.My.Resources.Resources.isotipoProyectowhite
        Me.PictureBox5.Location = New System.Drawing.Point(5, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.Silver
        Me.lbTitulo.Location = New System.Drawing.Point(38, 2)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(344, 25)
        Me.lbTitulo.TabIndex = 8
        Me.lbTitulo.Text = "SISTEMA DE AUTOCONSULTA MEDICA"
        '
        'btnCerrar
        '
        Me.btnCerrar.Animated = True
        Me.btnCerrar.BorderColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BorderRadius = 10
        Me.btnCerrar.CheckedState.Parent = Me.btnCerrar
        Me.btnCerrar.CustomImages.Parent = Me.btnCerrar
        Me.btnCerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.HoverState.Parent = Me.btnCerrar
        Me.btnCerrar.Location = New System.Drawing.Point(12, 36)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.ShadowDecoration.Parent = Me.btnCerrar
        Me.btnCerrar.Size = New System.Drawing.Size(120, 30)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.Text = "SALIR"
        '
        'btnEnviarMensaje
        '
        Me.btnEnviarMensaje.Animated = True
        Me.btnEnviarMensaje.BackColor = System.Drawing.Color.Transparent
        Me.btnEnviarMensaje.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEnviarMensaje.BorderThickness = 2
        Me.btnEnviarMensaje.CheckedState.Parent = Me.btnEnviarMensaje
        Me.btnEnviarMensaje.CustomImages.Parent = Me.btnEnviarMensaje
        Me.btnEnviarMensaje.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnEnviarMensaje.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarMensaje.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEnviarMensaje.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEnviarMensaje.HoverState.Parent = Me.btnEnviarMensaje
        Me.btnEnviarMensaje.Location = New System.Drawing.Point(464, 658)
        Me.btnEnviarMensaje.Name = "btnEnviarMensaje"
        Me.btnEnviarMensaje.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnEnviarMensaje.ShadowDecoration.BorderRadius = 20
        Me.btnEnviarMensaje.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnEnviarMensaje.ShadowDecoration.Depth = 15
        Me.btnEnviarMensaje.ShadowDecoration.Enabled = True
        Me.btnEnviarMensaje.ShadowDecoration.Parent = Me.btnEnviarMensaje
        Me.btnEnviarMensaje.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(6)
        Me.btnEnviarMensaje.Size = New System.Drawing.Size(113, 32)
        Me.btnEnviarMensaje.TabIndex = 14
        Me.btnEnviarMensaje.Text = "ENVIAR"
        '
        'btnModificar
        '
        Me.btnModificar.Animated = True
        Me.btnModificar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificar.BorderRadius = 10
        Me.btnModificar.BorderThickness = 2
        Me.btnModificar.CheckedState.Parent = Me.btnModificar
        Me.btnModificar.CustomImages.Parent = Me.btnModificar
        Me.btnModificar.FillColor = System.Drawing.Color.Empty
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.HoverState.Parent = Me.btnModificar
        Me.btnModificar.Location = New System.Drawing.Point(189, 713)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.ShadowDecoration.Parent = Me.btnModificar
        Me.btnModificar.Size = New System.Drawing.Size(120, 30)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "MODIFICAR"
        '
        'btnVerFichaMedica
        '
        Me.btnVerFichaMedica.Animated = True
        Me.btnVerFichaMedica.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVerFichaMedica.BorderRadius = 10
        Me.btnVerFichaMedica.BorderThickness = 2
        Me.btnVerFichaMedica.CheckedState.Parent = Me.btnVerFichaMedica
        Me.btnVerFichaMedica.CustomImages.Parent = Me.btnVerFichaMedica
        Me.btnVerFichaMedica.FillColor = System.Drawing.Color.Empty
        Me.btnVerFichaMedica.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerFichaMedica.ForeColor = System.Drawing.Color.White
        Me.btnVerFichaMedica.HoverState.Parent = Me.btnVerFichaMedica
        Me.btnVerFichaMedica.Location = New System.Drawing.Point(457, 713)
        Me.btnVerFichaMedica.Name = "btnVerFichaMedica"
        Me.btnVerFichaMedica.ShadowDecoration.Parent = Me.btnVerFichaMedica
        Me.btnVerFichaMedica.Size = New System.Drawing.Size(120, 30)
        Me.btnVerFichaMedica.TabIndex = 15
        Me.btnVerFichaMedica.Text = "FICHA"
        '
        'FrmChats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 760)
        Me.Controls.Add(Me.btnVerFichaMedica)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEnviarMensaje)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmChats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDiagnostico As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents txtChat As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents TopPanel As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lbTitulo As Label
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEnviarMensaje As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVerFichaMedica As Guna.UI2.WinForms.Guna2Button
End Class
