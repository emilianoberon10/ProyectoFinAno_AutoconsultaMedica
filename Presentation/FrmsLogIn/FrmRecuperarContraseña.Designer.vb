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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnRecuperar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRestablecer = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recuperar contraseña"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(20, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cedula identidad"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(240, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Correo electronico"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(28, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 21)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Repita contraseña nueva"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(28, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Contraseña nueva"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(28, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Su usuario es"
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
        'btnRecuperar
        '
        Me.btnRecuperar.Animated = True
        Me.btnRecuperar.BorderColor = System.Drawing.Color.Transparent
        Me.btnRecuperar.BorderRadius = 20
        Me.btnRecuperar.CheckedState.Parent = Me.btnRecuperar
        Me.btnRecuperar.CustomImages.Parent = Me.btnRecuperar
        Me.btnRecuperar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRecuperar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuperar.ForeColor = System.Drawing.Color.White
        Me.btnRecuperar.HoverState.Parent = Me.btnRecuperar
        Me.btnRecuperar.Location = New System.Drawing.Point(163, 119)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.ShadowDecoration.Parent = Me.btnRecuperar
        Me.btnRecuperar.Size = New System.Drawing.Size(129, 39)
        Me.btnRecuperar.TabIndex = 7
        Me.btnRecuperar.Text = "RECUPERAR"
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Animated = True
        Me.btnRestablecer.BorderColor = System.Drawing.Color.Transparent
        Me.btnRestablecer.BorderRadius = 20
        Me.btnRestablecer.CheckedState.Parent = Me.btnRestablecer
        Me.btnRestablecer.CustomImages.Parent = Me.btnRestablecer
        Me.btnRestablecer.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRestablecer.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestablecer.ForeColor = System.Drawing.Color.White
        Me.btnRestablecer.HoverState.Parent = Me.btnRestablecer
        Me.btnRestablecer.Location = New System.Drawing.Point(53, 171)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.ShadowDecoration.Parent = Me.btnRestablecer
        Me.btnRestablecer.Size = New System.Drawing.Size(129, 39)
        Me.btnRestablecer.TabIndex = 7
        Me.btnRestablecer.Text = "RESTABLECER"
        '
        'btnCancelar
        '
        Me.btnCancelar.Animated = True
        Me.btnCancelar.BorderColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BorderRadius = 20
        Me.btnCancelar.CheckedState.Parent = Me.btnCancelar
        Me.btnCancelar.CustomImages.Parent = Me.btnCancelar
        Me.btnCancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.HoverState.Parent = Me.btnCancelar
        Me.btnCancelar.Location = New System.Drawing.Point(8, 393)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.ShadowDecoration.Parent = Me.btnCancelar
        Me.btnCancelar.Size = New System.Drawing.Size(129, 39)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "CANCELAR"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnRestablecer)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TextBox5)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label6)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TextBox4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label5)
        Me.Guna2ShadowPanel1.Controls.Add(Me.TextBox3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label4)
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
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRecuperar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LineShape5 As PowerPacks.LineShape
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents btnRecuperar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRestablecer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
End Class
