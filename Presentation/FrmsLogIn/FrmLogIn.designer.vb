<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogIn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogIn))
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.llbForgotPassEs = New System.Windows.Forms.LinkLabel()
        Me.llbCrearUsuarioEs = New System.Windows.Forms.LinkLabel()
        Me.ErrorProviderLogIn = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbContraseña = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVerPass = New System.Windows.Forms.PictureBox()
        Me.btnInfo = New System.Windows.Forms.PictureBox()
        Me.btnChangeLanguage = New System.Windows.Forms.PictureBox()
        Me.ErrorProviderUserMal = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderUserBien = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderPass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.topPanel.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderLogIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVerPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnChangeLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderUserMal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderUserBien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.topPanel.Controls.Add(Me.btnClose)
        Me.topPanel.Controls.Add(Me.btnMinimize)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(430, 24)
        Me.topPanel.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.Presentation.My.Resources.Resources.Close_Icon
        Me.btnClose.Location = New System.Drawing.Point(408, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(16, 16)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 1
        Me.btnClose.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = Global.Presentation.My.Resources.Resources.Minimize_Icon
        Me.btnMinimize.Location = New System.Drawing.Point(386, 4)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.TabStop = False
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.CausesValidation = False
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.Silver
        Me.txtUser.Location = New System.Drawing.Point(40, 265)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUser.MaxLength = 8
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(350, 21)
        Me.txtUser.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(430, 600)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Silver
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 41
        Me.LineShape3.X2 = 390
        Me.LineShape3.Y1 = 534
        Me.LineShape3.Y2 = 534
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 39
        Me.LineShape2.X2 = 390
        Me.LineShape2.Y1 = 356
        Me.LineShape2.Y2 = 356
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 39
        Me.LineShape1.X2 = 390
        Me.LineShape1.Y1 = 287
        Me.LineShape1.Y2 = 287
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Silver
        Me.ErrorProviderLogIn.SetIconAlignment(Me.txtPass, System.Windows.Forms.ErrorIconAlignment.BottomRight)
        Me.txtPass.Location = New System.Drawing.Point(41, 334)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPass.MaxLength = 150
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(350, 21)
        Me.txtPass.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(38, 463)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(352, 50)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "INICIAR"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 590)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 10)
        Me.Panel1.TabIndex = 7
        '
        'llbForgotPassEs
        '
        Me.llbForgotPassEs.AutoSize = True
        Me.llbForgotPassEs.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbForgotPassEs.LinkColor = System.Drawing.Color.Silver
        Me.llbForgotPassEs.Location = New System.Drawing.Point(123, 545)
        Me.llbForgotPassEs.Name = "llbForgotPassEs"
        Me.llbForgotPassEs.Size = New System.Drawing.Size(184, 21)
        Me.llbForgotPassEs.TabIndex = 0
        Me.llbForgotPassEs.TabStop = True
        Me.llbForgotPassEs.Text = "Olvido su contraseña?"
        '
        'llbCrearUsuarioEs
        '
        Me.llbCrearUsuarioEs.AutoSize = True
        Me.llbCrearUsuarioEs.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbCrearUsuarioEs.LinkColor = System.Drawing.Color.Silver
        Me.llbCrearUsuarioEs.Location = New System.Drawing.Point(155, 566)
        Me.llbCrearUsuarioEs.Name = "llbCrearUsuarioEs"
        Me.llbCrearUsuarioEs.Size = New System.Drawing.Size(113, 21)
        Me.llbCrearUsuarioEs.TabIndex = 0
        Me.llbCrearUsuarioEs.TabStop = True
        Me.llbCrearUsuarioEs.Text = "Crear usuario"
        '
        'ErrorProviderLogIn
        '
        Me.ErrorProviderLogIn.ContainerControl = Me
        Me.ErrorProviderLogIn.Icon = CType(resources.GetObject("ErrorProviderLogIn.Icon"), System.Drawing.Icon)
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderUserBien.SetIconAlignment(Me.lbUsuario, System.Windows.Forms.ErrorIconAlignment.TopRight)
        Me.lbUsuario.Location = New System.Drawing.Point(40, 241)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(75, 19)
        Me.lbUsuario.TabIndex = 10
        Me.lbUsuario.Text = "USUARIO"
        '
        'lbContraseña
        '
        Me.lbContraseña.AutoSize = True
        Me.lbContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContraseña.Location = New System.Drawing.Point(41, 308)
        Me.lbContraseña.Name = "lbContraseña"
        Me.lbContraseña.Size = New System.Drawing.Size(114, 19)
        Me.lbContraseña.TabIndex = 10
        Me.lbContraseña.Text = "CONTRASEÑA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.Presentation.My.Resources.Resources.isotipoProyectowhite
        Me.PictureBox1.Location = New System.Drawing.Point(130, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnVerPass
        '
        Me.btnVerPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerPass.Image = Global.Presentation.My.Resources.Resources.password
        Me.btnVerPass.Location = New System.Drawing.Point(394, 334)
        Me.btnVerPass.Name = "btnVerPass"
        Me.btnVerPass.Size = New System.Drawing.Size(24, 24)
        Me.btnVerPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVerPass.TabIndex = 9
        Me.btnVerPass.TabStop = False
        '
        'btnInfo
        '
        Me.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInfo.Image = Global.Presentation.My.Resources.Resources.information
        Me.btnInfo.Location = New System.Drawing.Point(10, 265)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(24, 24)
        Me.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnInfo.TabIndex = 9
        Me.btnInfo.TabStop = False
        '
        'btnChangeLanguage
        '
        Me.btnChangeLanguage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeLanguage.Image = Global.Presentation.My.Resources.Resources.spain
        Me.btnChangeLanguage.Location = New System.Drawing.Point(12, 29)
        Me.btnChangeLanguage.Name = "btnChangeLanguage"
        Me.btnChangeLanguage.Size = New System.Drawing.Size(35, 35)
        Me.btnChangeLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnChangeLanguage.TabIndex = 8
        Me.btnChangeLanguage.TabStop = False
        '
        'ErrorProviderUserMal
        '
        Me.ErrorProviderUserMal.ContainerControl = Me
        Me.ErrorProviderUserMal.Icon = CType(resources.GetObject("ErrorProviderUserMal.Icon"), System.Drawing.Icon)
        '
        'ErrorProviderUserBien
        '
        Me.ErrorProviderUserBien.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProviderUserBien.ContainerControl = Me
        Me.ErrorProviderUserBien.Icon = CType(resources.GetObject("ErrorProviderUserBien.Icon"), System.Drawing.Icon)
        '
        'ErrorProviderPass
        '
        Me.ErrorProviderPass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProviderPass.ContainerControl = Me
        Me.ErrorProviderPass.Icon = CType(resources.GetObject("ErrorProviderPass.Icon"), System.Drawing.Icon)
        '
        'FrmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 600)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbContraseña)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.btnVerPass)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.llbCrearUsuarioEs)
        Me.Controls.Add(Me.btnChangeLanguage)
        Me.Controls.Add(Me.llbForgotPassEs)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.topPanel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogIn"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderLogIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVerPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnChangeLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderUserMal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderUserBien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents topPanel As Panel
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents txtPass As TextBox
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents Panel1 As Panel
    Friend WithEvents llbForgotPassEs As LinkLabel
    Friend WithEvents btnChangeLanguage As PictureBox
    Friend WithEvents llbCrearUsuarioEs As LinkLabel
    Friend WithEvents btnInfo As PictureBox
    Friend WithEvents ErrorProviderLogIn As ErrorProvider
    Friend WithEvents btnVerPass As PictureBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbContraseña As Label
    Friend WithEvents ErrorProviderUserMal As ErrorProvider
    Friend WithEvents ErrorProviderUserBien As ErrorProvider
    Friend WithEvents ErrorProviderPass As ErrorProvider
End Class
