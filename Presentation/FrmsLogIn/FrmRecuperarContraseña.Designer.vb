<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecuperarContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecuperarContraseña))
        Me.RecuperarPass_titulo = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Persona_ci = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Persona_correo = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.RecuperarPass_passNueva2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.RecuperarPass_passNueva = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RecuperarPass_usuario = New System.Windows.Forms.Label()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btn_recuperar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_restablecer = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RecuperarPass_titulo
        '
        Me.RecuperarPass_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecuperarPass_titulo.Location = New System.Drawing.Point(0, 5)
        Me.RecuperarPass_titulo.Name = "RecuperarPass_titulo"
        Me.RecuperarPass_titulo.Size = New System.Drawing.Size(454, 40)
        Me.RecuperarPass_titulo.TabIndex = 0
        Me.RecuperarPass_titulo.Text = "Recuperar contraseña"
        Me.RecuperarPass_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Silver
        Me.TextBox1.Location = New System.Drawing.Point(24, 85)
        Me.TextBox1.MaxLength = 8
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Persona_ci
        '
        Me.Persona_ci.AutoSize = True
        Me.Persona_ci.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_ci.ForeColor = System.Drawing.Color.Silver
        Me.Persona_ci.Location = New System.Drawing.Point(20, 61)
        Me.Persona_ci.Name = "Persona_ci"
        Me.Persona_ci.Size = New System.Drawing.Size(127, 21)
        Me.Persona_ci.TabIndex = 3
        Me.Persona_ci.Text = "Cedula identidad"
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 23
        Me.LineShape1.X2 = 203
        Me.LineShape1.Y1 = 107
        Me.LineShape1.Y2 = 107
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(454, 444)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 243
        Me.LineShape2.X2 = 423
        Me.LineShape2.Y1 = 109
        Me.LineShape2.Y2 = 109
        '
        'Persona_correo
        '
        Me.Persona_correo.AutoSize = True
        Me.Persona_correo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_correo.ForeColor = System.Drawing.Color.Silver
        Me.Persona_correo.Location = New System.Drawing.Point(240, 62)
        Me.Persona_correo.Name = "Persona_correo"
        Me.Persona_correo.Size = New System.Drawing.Size(138, 21)
        Me.Persona_correo.TabIndex = 3
        Me.Persona_correo.Text = "Correo electronico"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Silver
        Me.TextBox2.Location = New System.Drawing.Point(244, 86)
        Me.TextBox2.MaxLength = 255
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 22)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Silver
        Me.TextBox5.Location = New System.Drawing.Point(28, 133)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(180, 22)
        Me.TextBox5.TabIndex = 2
        '
        'RecuperarPass_passNueva2
        '
        Me.RecuperarPass_passNueva2.AutoSize = True
        Me.RecuperarPass_passNueva2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecuperarPass_passNueva2.ForeColor = System.Drawing.Color.Silver
        Me.RecuperarPass_passNueva2.Location = New System.Drawing.Point(28, 109)
        Me.RecuperarPass_passNueva2.Name = "RecuperarPass_passNueva2"
        Me.RecuperarPass_passNueva2.Size = New System.Drawing.Size(180, 21)
        Me.RecuperarPass_passNueva2.TabIndex = 3
        Me.RecuperarPass_passNueva2.Text = "Repita contraseña nueva"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Silver
        Me.TextBox4.Location = New System.Drawing.Point(28, 84)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(180, 22)
        Me.TextBox4.TabIndex = 2
        '
        'RecuperarPass_passNueva
        '
        Me.RecuperarPass_passNueva.AutoSize = True
        Me.RecuperarPass_passNueva.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecuperarPass_passNueva.ForeColor = System.Drawing.Color.Silver
        Me.RecuperarPass_passNueva.Location = New System.Drawing.Point(28, 60)
        Me.RecuperarPass_passNueva.Name = "RecuperarPass_passNueva"
        Me.RecuperarPass_passNueva.Size = New System.Drawing.Size(135, 21)
        Me.RecuperarPass_passNueva.TabIndex = 3
        Me.RecuperarPass_passNueva.Text = "Contraseña nueva"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Silver
        Me.TextBox3.Location = New System.Drawing.Point(28, 31)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(180, 22)
        Me.TextBox3.TabIndex = 2
        '
        'RecuperarPass_usuario
        '
        Me.RecuperarPass_usuario.AutoSize = True
        Me.RecuperarPass_usuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecuperarPass_usuario.ForeColor = System.Drawing.Color.Silver
        Me.RecuperarPass_usuario.Location = New System.Drawing.Point(28, 7)
        Me.RecuperarPass_usuario.Name = "RecuperarPass_usuario"
        Me.RecuperarPass_usuario.Size = New System.Drawing.Size(103, 21)
        Me.RecuperarPass_usuario.TabIndex = 3
        Me.RecuperarPass_usuario.Text = "Su usuario es"
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.Silver
        Me.LineShape5.Enabled = False
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 27
        Me.LineShape5.X2 = 207
        Me.LineShape5.Y1 = 158
        Me.LineShape5.Y2 = 158
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Silver
        Me.LineShape4.Enabled = False
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 27
        Me.LineShape4.X2 = 207
        Me.LineShape4.Y1 = 108
        Me.LineShape4.Y2 = 108
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Silver
        Me.LineShape3.Enabled = False
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 25
        Me.LineShape3.X2 = 205
        Me.LineShape3.Y1 = 55
        Me.LineShape3.Y2 = 55
        '
        'btn_recuperar
        '
        Me.btn_recuperar.Animated = True
        Me.btn_recuperar.BorderColor = System.Drawing.Color.Transparent
        Me.btn_recuperar.BorderRadius = 20
        Me.btn_recuperar.CheckedState.Parent = Me.btn_recuperar
        Me.btn_recuperar.CustomImages.Parent = Me.btn_recuperar
        Me.btn_recuperar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_recuperar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_recuperar.ForeColor = System.Drawing.Color.White
        Me.btn_recuperar.HoverState.Parent = Me.btn_recuperar
        Me.btn_recuperar.Location = New System.Drawing.Point(163, 119)
        Me.btn_recuperar.Name = "btn_recuperar"
        Me.btn_recuperar.ShadowDecoration.Parent = Me.btn_recuperar
        Me.btn_recuperar.Size = New System.Drawing.Size(129, 39)
        Me.btn_recuperar.TabIndex = 7
        Me.btn_recuperar.Text = "RECUPERAR"
        '
        'btn_restablecer
        '
        Me.btn_restablecer.Animated = True
        Me.btn_restablecer.BorderColor = System.Drawing.Color.Transparent
        Me.btn_restablecer.BorderRadius = 20
        Me.btn_restablecer.CheckedState.Parent = Me.btn_restablecer
        Me.btn_restablecer.CustomImages.Parent = Me.btn_restablecer
        Me.btn_restablecer.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_restablecer.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_restablecer.ForeColor = System.Drawing.Color.White
        Me.btn_restablecer.HoverState.Parent = Me.btn_restablecer
        Me.btn_restablecer.Location = New System.Drawing.Point(53, 171)
        Me.btn_restablecer.Name = "btn_restablecer"
        Me.btn_restablecer.ShadowDecoration.Parent = Me.btn_restablecer
        Me.btn_restablecer.Size = New System.Drawing.Size(129, 39)
        Me.btn_restablecer.TabIndex = 7
        Me.btn_restablecer.Text = "RESTABLECER"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Animated = True
        Me.btn_cancelar.BorderColor = System.Drawing.Color.Transparent
        Me.btn_cancelar.BorderRadius = 20
        Me.btn_cancelar.CheckedState.Parent = Me.btn_cancelar
        Me.btn_cancelar.CustomImages.Parent = Me.btn_cancelar
        Me.btn_cancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.HoverState.Parent = Me.btn_cancelar
        Me.btn_cancelar.Location = New System.Drawing.Point(8, 393)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.ShadowDecoration.Parent = Me.btn_cancelar
        Me.btn_cancelar.Size = New System.Drawing.Size(129, 39)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "CANCELAR"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.btn_restablecer)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TextBox5)
        Me.Guna2ShadowPanel1.Controls.Add(Me.RecuperarPass_passNueva2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TextBox4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.RecuperarPass_passNueva)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TextBox3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.RecuperarPass_usuario)
        Me.Guna2ShadowPanel1.Controls.Add(Me.ShapeContainer2)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(113, 164)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ShadowPanel1.ShadowDepth = 70
        Me.Guna2ShadowPanel1.ShadowShift = 6
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(229, 223)
        Me.Guna2ShadowPanel1.TabIndex = 8
        Me.Guna2ShadowPanel1.Visible = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(229, 223)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'FrmRecuperarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(454, 444)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_recuperar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Persona_correo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Persona_ci)
        Me.Controls.Add(Me.RecuperarPass_titulo)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmRecuperarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRecuperarContraseña"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecuperarPass_titulo As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Persona_ci As Label
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents Persona_correo As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents RecuperarPass_passNueva2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RecuperarPass_passNueva As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RecuperarPass_usuario As Label
    Friend WithEvents LineShape5 As PowerPacks.LineShape
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents btn_recuperar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_restablecer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
End Class
