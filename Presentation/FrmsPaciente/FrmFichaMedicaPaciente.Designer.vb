<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFichaMedicaPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFichaMedicaPaciente))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMedicina = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtOcupacion = New System.Windows.Forms.TextBox()
        Me.lbOcup = New System.Windows.Forms.Label()
        Me.ckbMedicina = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMotivoConsulta = New System.Windows.Forms.TextBox()
        Me.lbMotiv = New System.Windows.Forms.Label()
        Me.txtProcedencia = New System.Windows.Forms.TextBox()
        Me.lbProc = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtAntecedentes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chbAntecedentes = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(77, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 36)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "FICHA MEDICA"
        Me.Label2.UseWaitCursor = True
        '
        'txtMedicina
        '
        Me.txtMedicina.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtMedicina.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMedicina.Enabled = False
        Me.txtMedicina.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedicina.ForeColor = System.Drawing.Color.Silver
        Me.txtMedicina.Location = New System.Drawing.Point(25, 116)
        Me.txtMedicina.Name = "txtMedicina"
        Me.txtMedicina.Size = New System.Drawing.Size(144, 15)
        Me.txtMedicina.TabIndex = 31
        Me.txtMedicina.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(22, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Cual"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.UseWaitCursor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(399, 504)
        Me.ShapeContainer1.TabIndex = 33
        Me.ShapeContainer1.TabStop = False
        Me.ShapeContainer1.UseWaitCursor = True
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.UseWaitCursor = True
        Me.LineShape2.X1 = 228
        Me.LineShape2.X2 = 375
        Me.LineShape2.Y1 = 134
        Me.LineShape2.Y2 = 134
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.UseWaitCursor = True
        Me.LineShape1.X1 = 24
        Me.LineShape1.X2 = 171
        Me.LineShape1.Y1 = 134
        Me.LineShape1.Y2 = 134
        '
        'txtOcupacion
        '
        Me.txtOcupacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOcupacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacion.ForeColor = System.Drawing.Color.Silver
        Me.txtOcupacion.Location = New System.Drawing.Point(230, 116)
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.Size = New System.Drawing.Size(144, 15)
        Me.txtOcupacion.TabIndex = 31
        Me.txtOcupacion.UseWaitCursor = True
        '
        'lbOcup
        '
        Me.lbOcup.AutoSize = True
        Me.lbOcup.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOcup.ForeColor = System.Drawing.Color.Silver
        Me.lbOcup.Location = New System.Drawing.Point(226, 93)
        Me.lbOcup.Name = "lbOcup"
        Me.lbOcup.Size = New System.Drawing.Size(87, 17)
        Me.lbOcup.TabIndex = 32
        Me.lbOcup.Text = "Ocupacion*"
        Me.lbOcup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbOcup.UseWaitCursor = True
        '
        'ckbMedicina
        '
        Me.ckbMedicina.AutoSize = True
        Me.ckbMedicina.Location = New System.Drawing.Point(148, 71)
        Me.ckbMedicina.Name = "ckbMedicina"
        Me.ckbMedicina.Size = New System.Drawing.Size(15, 14)
        Me.ckbMedicina.TabIndex = 34
        Me.ckbMedicina.UseVisualStyleBackColor = True
        Me.ckbMedicina.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(21, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "¿Toma medicina?"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.UseWaitCursor = True
        '
        'txtMotivoConsulta
        '
        Me.txtMotivoConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtMotivoConsulta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoConsulta.ForeColor = System.Drawing.Color.Silver
        Me.txtMotivoConsulta.Location = New System.Drawing.Point(24, 171)
        Me.txtMotivoConsulta.Multiline = True
        Me.txtMotivoConsulta.Name = "txtMotivoConsulta"
        Me.txtMotivoConsulta.Size = New System.Drawing.Size(148, 72)
        Me.txtMotivoConsulta.TabIndex = 35
        Me.txtMotivoConsulta.UseWaitCursor = True
        '
        'lbMotiv
        '
        Me.lbMotiv.AutoSize = True
        Me.lbMotiv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMotiv.ForeColor = System.Drawing.Color.Silver
        Me.lbMotiv.Location = New System.Drawing.Point(23, 151)
        Me.lbMotiv.Name = "lbMotiv"
        Me.lbMotiv.Size = New System.Drawing.Size(155, 17)
        Me.lbMotiv.TabIndex = 32
        Me.lbMotiv.Text = "Motivo de la consulta*"
        Me.lbMotiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbMotiv.UseWaitCursor = True
        '
        'txtProcedencia
        '
        Me.txtProcedencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtProcedencia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcedencia.ForeColor = System.Drawing.Color.Silver
        Me.txtProcedencia.Location = New System.Drawing.Point(229, 171)
        Me.txtProcedencia.Multiline = True
        Me.txtProcedencia.Name = "txtProcedencia"
        Me.txtProcedencia.Size = New System.Drawing.Size(148, 72)
        Me.txtProcedencia.TabIndex = 35
        Me.txtProcedencia.UseWaitCursor = True
        '
        'lbProc
        '
        Me.lbProc.AutoSize = True
        Me.lbProc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProc.ForeColor = System.Drawing.Color.Silver
        Me.lbProc.Location = New System.Drawing.Point(228, 152)
        Me.lbProc.Name = "lbProc"
        Me.lbProc.Size = New System.Drawing.Size(96, 17)
        Me.lbProc.TabIndex = 32
        Me.lbProc.Text = "Procedencia*"
        Me.lbProc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbProc.UseWaitCursor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Silver
        Me.btnAceptar.Location = New System.Drawing.Point(24, 423)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(353, 49)
        Me.btnAceptar.TabIndex = 36
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        Me.btnAceptar.UseWaitCursor = True
        '
        'txtAntecedentes
        '
        Me.txtAntecedentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtAntecedentes.Enabled = False
        Me.txtAntecedentes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntecedentes.ForeColor = System.Drawing.Color.Silver
        Me.txtAntecedentes.Location = New System.Drawing.Point(23, 290)
        Me.txtAntecedentes.Multiline = True
        Me.txtAntecedentes.Name = "txtAntecedentes"
        Me.txtAntecedentes.Size = New System.Drawing.Size(351, 72)
        Me.txtAntecedentes.TabIndex = 35
        Me.txtAntecedentes.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(22, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Antecedentes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.UseWaitCursor = True
        '
        'chbAntecedentes
        '
        Me.chbAntecedentes.AutoSize = True
        Me.chbAntecedentes.Location = New System.Drawing.Point(125, 270)
        Me.chbAntecedentes.Name = "chbAntecedentes"
        Me.chbAntecedentes.Size = New System.Drawing.Size(15, 14)
        Me.chbAntecedentes.TabIndex = 34
        Me.chbAntecedentes.UseVisualStyleBackColor = True
        Me.chbAntecedentes.UseWaitCursor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'FrmFichaMedicaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(399, 504)
        Me.Controls.Add(Me.chbAntecedentes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAntecedentes)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lbProc)
        Me.Controls.Add(Me.txtProcedencia)
        Me.Controls.Add(Me.lbMotiv)
        Me.Controls.Add(Me.txtMotivoConsulta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ckbMedicina)
        Me.Controls.Add(Me.lbOcup)
        Me.Controls.Add(Me.txtOcupacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMedicina)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFichaMedicaPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.UseWaitCursor = True
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtMedicina As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents txtOcupacion As TextBox
    Friend WithEvents lbOcup As Label
    Friend WithEvents ckbMedicina As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMotivoConsulta As TextBox
    Friend WithEvents lbMotiv As Label
    Friend WithEvents txtProcedencia As TextBox
    Friend WithEvents lbProc As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtAntecedentes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chbAntecedentes As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
