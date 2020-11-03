<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpciones))
        Me.optionPanel = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_usuario = New Guna.UI2.WinForms.Guna2Button()
        Me.childPanel = New System.Windows.Forms.Panel()
        Me.lbIconoHechos = New System.Windows.Forms.Label()
        Me.lbLinkIconos = New System.Windows.Forms.Label()
        Me.lbHechoPor = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.optionPanel.SuspendLayout()
        Me.childPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optionPanel
        '
        Me.optionPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.optionPanel.Controls.Add(Me.btn_cerrar)
        Me.optionPanel.Controls.Add(Me.btn_usuario)
        Me.optionPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.optionPanel.Location = New System.Drawing.Point(0, 0)
        Me.optionPanel.Name = "optionPanel"
        Me.optionPanel.Size = New System.Drawing.Size(150, 583)
        Me.optionPanel.TabIndex = 1
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Animated = True
        Me.btn_cerrar.BorderColor = System.Drawing.Color.Transparent
        Me.btn_cerrar.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cerrar.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_cerrar.CheckedState.Parent = Me.btn_cerrar
        Me.btn_cerrar.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cerrar.CustomImages.Parent = Me.btn_cerrar
        Me.btn_cerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_cerrar.HoverState.Parent = Me.btn_cerrar
        Me.btn_cerrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_cerrar.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_cerrar.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_cerrar.Location = New System.Drawing.Point(0, 553)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cerrar.ShadowDecoration.Parent = Me.btn_cerrar
        Me.btn_cerrar.Size = New System.Drawing.Size(150, 30)
        Me.btn_cerrar.TabIndex = 303
        Me.btn_cerrar.Text = "CERRAR"
        Me.btn_cerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_usuario
        '
        Me.btn_usuario.Animated = True
        Me.btn_usuario.BorderColor = System.Drawing.Color.Transparent
        Me.btn_usuario.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_usuario.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btn_usuario.CheckedState.Parent = Me.btn_usuario
        Me.btn_usuario.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_usuario.CustomImages.Parent = Me.btn_usuario
        Me.btn_usuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btn_usuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_usuario.ForeColor = System.Drawing.Color.White
        Me.btn_usuario.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btn_usuario.HoverState.Parent = Me.btn_usuario
        Me.btn_usuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_usuario.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_usuario.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_usuario.Location = New System.Drawing.Point(0, 64)
        Me.btn_usuario.Name = "btn_usuario"
        Me.btn_usuario.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_usuario.ShadowDecoration.Parent = Me.btn_usuario
        Me.btn_usuario.Size = New System.Drawing.Size(150, 30)
        Me.btn_usuario.TabIndex = 303
        Me.btn_usuario.Text = "USUARIO"
        Me.btn_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'childPanel
        '
        Me.childPanel.Controls.Add(Me.lbIconoHechos)
        Me.childPanel.Controls.Add(Me.lbLinkIconos)
        Me.childPanel.Controls.Add(Me.lbHechoPor)
        Me.childPanel.Controls.Add(Me.PictureBox1)
        Me.childPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.childPanel.Location = New System.Drawing.Point(150, 0)
        Me.childPanel.Name = "childPanel"
        Me.childPanel.Size = New System.Drawing.Size(557, 583)
        Me.childPanel.TabIndex = 2
        '
        'lbIconoHechos
        '
        Me.lbIconoHechos.AutoSize = True
        Me.lbIconoHechos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIconoHechos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbIconoHechos.Location = New System.Drawing.Point(151, 502)
        Me.lbIconoHechos.Name = "lbIconoHechos"
        Me.lbIconoHechos.Size = New System.Drawing.Size(144, 21)
        Me.lbIconoHechos.TabIndex = 1
        Me.lbIconoHechos.Text = "Iconos Hechos por:"
        '
        'lbLinkIconos
        '
        Me.lbLinkIconos.AutoSize = True
        Me.lbLinkIconos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLinkIconos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbLinkIconos.Location = New System.Drawing.Point(151, 523)
        Me.lbLinkIconos.Name = "lbLinkIconos"
        Me.lbLinkIconos.Size = New System.Drawing.Size(181, 21)
        Me.lbLinkIconos.TabIndex = 1
        Me.lbLinkIconos.Text = "http://www.freepik.com"
        '
        'lbHechoPor
        '
        Me.lbHechoPor.AutoSize = True
        Me.lbHechoPor.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHechoPor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbHechoPor.Location = New System.Drawing.Point(151, 476)
        Me.lbHechoPor.Name = "lbHechoPor"
        Me.lbHechoPor.Size = New System.Drawing.Size(254, 21)
        Me.lbHechoPor.TabIndex = 1
        Me.lbHechoPor.Text = "Software creado por VVB Software"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentation.My.Resources.Resources.isotipoProyectowhite
        Me.PictureBox1.Location = New System.Drawing.Point(193, 206)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(707, 583)
        Me.Controls.Add(Me.childPanel)
        Me.Controls.Add(Me.optionPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOpciones"
        Me.optionPanel.ResumeLayout(False)
        Me.childPanel.ResumeLayout(False)
        Me.childPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents optionPanel As Panel
    Friend WithEvents childPanel As Panel
    Friend WithEvents btn_cerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_usuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbIconoHechos As Label
    Friend WithEvents lbLinkIconos As Label
    Friend WithEvents lbHechoPor As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
