<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIngresarGerente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSintoma1 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma7 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma4 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma2 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma5 = New System.Windows.Forms.ComboBox()
        Me.btnIngresarSintoma = New System.Windows.Forms.Button()
        Me.btnIngresarEnfermedad = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreEnfermedad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreSintoma = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbSintoma8 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma3 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma6 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma9 = New System.Windows.Forms.ComboBox()
        Me.cbRiesgo = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(79, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar sintomas/enfermadad"
        '
        'cbSintoma1
        '
        Me.cbSintoma1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma1.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma1.FormattingEnabled = True
        Me.cbSintoma1.Location = New System.Drawing.Point(15, 392)
        Me.cbSintoma1.Name = "cbSintoma1"
        Me.cbSintoma1.Size = New System.Drawing.Size(200, 25)
        Me.cbSintoma1.TabIndex = 4
        Me.cbSintoma1.TabStop = False
        '
        'cbSintoma7
        '
        Me.cbSintoma7.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma7.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma7.FormattingEnabled = True
        Me.cbSintoma7.Location = New System.Drawing.Point(15, 455)
        Me.cbSintoma7.Name = "cbSintoma7"
        Me.cbSintoma7.Size = New System.Drawing.Size(200, 25)
        Me.cbSintoma7.TabIndex = 8
        '
        'cbSintoma4
        '
        Me.cbSintoma4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma4.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma4.FormattingEnabled = True
        Me.cbSintoma4.Location = New System.Drawing.Point(15, 424)
        Me.cbSintoma4.Name = "cbSintoma4"
        Me.cbSintoma4.Size = New System.Drawing.Size(200, 25)
        Me.cbSintoma4.TabIndex = 6
        '
        'cbSintoma2
        '
        Me.cbSintoma2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma2.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma2.FormattingEnabled = True
        Me.cbSintoma2.Location = New System.Drawing.Point(227, 392)
        Me.cbSintoma2.Name = "cbSintoma2"
        Me.cbSintoma2.Size = New System.Drawing.Size(200, 25)
        Me.cbSintoma2.TabIndex = 5
        '
        'cbSintoma5
        '
        Me.cbSintoma5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma5.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma5.FormattingEnabled = True
        Me.cbSintoma5.Location = New System.Drawing.Point(227, 424)
        Me.cbSintoma5.Name = "cbSintoma5"
        Me.cbSintoma5.Size = New System.Drawing.Size(200, 25)
        Me.cbSintoma5.TabIndex = 7
        '
        'btnIngresarSintoma
        '
        Me.btnIngresarSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnIngresarSintoma.FlatAppearance.BorderSize = 0
        Me.btnIngresarSintoma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnIngresarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarSintoma.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarSintoma.ForeColor = System.Drawing.Color.Silver
        Me.btnIngresarSintoma.Location = New System.Drawing.Point(443, 126)
        Me.btnIngresarSintoma.Name = "btnIngresarSintoma"
        Me.btnIngresarSintoma.Size = New System.Drawing.Size(190, 40)
        Me.btnIngresarSintoma.TabIndex = 2
        Me.btnIngresarSintoma.Text = "Ingresar"
        Me.btnIngresarSintoma.UseVisualStyleBackColor = False
        '
        'btnIngresarEnfermedad
        '
        Me.btnIngresarEnfermedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnIngresarEnfermedad.FlatAppearance.BorderSize = 0
        Me.btnIngresarEnfermedad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnIngresarEnfermedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarEnfermedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarEnfermedad.ForeColor = System.Drawing.Color.Silver
        Me.btnIngresarEnfermedad.Location = New System.Drawing.Point(433, 498)
        Me.btnIngresarEnfermedad.Name = "btnIngresarEnfermedad"
        Me.btnIngresarEnfermedad.Size = New System.Drawing.Size(200, 40)
        Me.btnIngresarEnfermedad.TabIndex = 12
        Me.btnIngresarEnfermedad.Text = "Ingresar"
        Me.btnIngresarEnfermedad.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(7, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre de la Enfermedad"
        '
        'txtNombreEnfermedad
        '
        Me.txtNombreEnfermedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNombreEnfermedad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEnfermedad.ForeColor = System.Drawing.Color.Silver
        Me.txtNombreEnfermedad.Location = New System.Drawing.Point(15, 266)
        Me.txtNombreEnfermedad.Name = "txtNombreEnfermedad"
        Me.txtNombreEnfermedad.Size = New System.Drawing.Size(415, 22)
        Me.txtNombreEnfermedad.TabIndex = 3
        Me.txtNombreEnfermedad.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(8, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre del Sintoma"
        '
        'txtNombreSintoma
        '
        Me.txtNombreSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNombreSintoma.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreSintoma.ForeColor = System.Drawing.Color.Silver
        Me.txtNombreSintoma.Location = New System.Drawing.Point(15, 136)
        Me.txtNombreSintoma.Name = "txtNombreSintoma"
        Me.txtNombreSintoma.Size = New System.Drawing.Size(415, 22)
        Me.txtNombreSintoma.TabIndex = 1
        Me.txtNombreSintoma.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(12, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Sintomas relacionados"
        '
        'cbSintoma8
        '
        Me.cbSintoma8.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma8.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma8.FormattingEnabled = True
        Me.cbSintoma8.Location = New System.Drawing.Point(227, 455)
        Me.cbSintoma8.Name = "cbSintoma8"
        Me.cbSintoma8.Size = New System.Drawing.Size(200, 25)
        Me.cbSintoma8.TabIndex = 9
        '
        'cbSintoma3
        '
        Me.cbSintoma3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma3.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma3.FormattingEnabled = True
        Me.cbSintoma3.Location = New System.Drawing.Point(433, 392)
        Me.cbSintoma3.Name = "cbSintoma3"
        Me.cbSintoma3.Size = New System.Drawing.Size(200, 25)
        Me.cbSintoma3.TabIndex = 5
        '
        'cbSintoma6
        '
        Me.cbSintoma6.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma6.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma6.FormattingEnabled = True
        Me.cbSintoma6.Location = New System.Drawing.Point(433, 424)
        Me.cbSintoma6.Name = "cbSintoma6"
        Me.cbSintoma6.Size = New System.Drawing.Size(200, 25)
        Me.cbSintoma6.TabIndex = 7
        '
        'cbSintoma9
        '
        Me.cbSintoma9.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma9.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma9.FormattingEnabled = True
        Me.cbSintoma9.Location = New System.Drawing.Point(433, 455)
        Me.cbSintoma9.Name = "cbSintoma9"
        Me.cbSintoma9.Size = New System.Drawing.Size(200, 25)
        Me.cbSintoma9.TabIndex = 9
        '
        'cbRiesgo
        '
        Me.cbRiesgo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbRiesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRiesgo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRiesgo.ForeColor = System.Drawing.Color.Silver
        Me.cbRiesgo.FormattingEnabled = True
        Me.cbRiesgo.Items.AddRange(New Object() {"azul", "verde", "amarillo", "naranja", "Rojo"})
        Me.cbRiesgo.Location = New System.Drawing.Point(15, 294)
        Me.cbRiesgo.Name = "cbRiesgo"
        Me.cbRiesgo.Size = New System.Drawing.Size(200, 25)
        Me.cbRiesgo.TabIndex = 4
        Me.cbRiesgo.TabStop = False
        Me.cbRiesgo.Text = "Riesgo"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Silver
        Me.txtDescripcion.Location = New System.Drawing.Point(227, 294)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(406, 83)
        Me.txtDescripcion.TabIndex = 3
        Me.txtDescripcion.Text = "Descripcion"
        '
        'FrmIngresarGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(645, 570)
        Me.Controls.Add(Me.txtNombreSintoma)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombreEnfermedad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIngresarEnfermedad)
        Me.Controls.Add(Me.btnIngresarSintoma)
        Me.Controls.Add(Me.cbSintoma9)
        Me.Controls.Add(Me.cbSintoma8)
        Me.Controls.Add(Me.cbSintoma6)
        Me.Controls.Add(Me.cbSintoma3)
        Me.Controls.Add(Me.cbSintoma5)
        Me.Controls.Add(Me.cbSintoma2)
        Me.Controls.Add(Me.cbSintoma4)
        Me.Controls.Add(Me.cbSintoma7)
        Me.Controls.Add(Me.cbRiesgo)
        Me.Controls.Add(Me.cbSintoma1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmIngresarGerente"
        Me.Text = "FrmIngresar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbSintoma1 As ComboBox
    Friend WithEvents cbSintoma7 As ComboBox
    Friend WithEvents cbSintoma4 As ComboBox
    Friend WithEvents cbSintoma2 As ComboBox
    Friend WithEvents cbSintoma5 As ComboBox
    Friend WithEvents btnIngresarSintoma As Button
    Friend WithEvents btnIngresarEnfermedad As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreEnfermedad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombreSintoma As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbSintoma8 As ComboBox
    Friend WithEvents cbSintoma3 As ComboBox
    Friend WithEvents cbSintoma6 As ComboBox
    Friend WithEvents cbSintoma9 As ComboBox
    Friend WithEvents cbRiesgo As ComboBox
    Friend WithEvents txtDescripcion As TextBox
End Class
