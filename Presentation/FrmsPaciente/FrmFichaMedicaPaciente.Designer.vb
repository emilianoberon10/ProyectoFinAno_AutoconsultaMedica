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
        Me.PFicha_titulo = New System.Windows.Forms.Label()
        Me.txtMedicina = New System.Windows.Forms.TextBox()
        Me.PFicha_cual = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtOcupacion = New System.Windows.Forms.TextBox()
        Me.PFicha_ocup = New System.Windows.Forms.Label()
        Me.ckbMedicina = New System.Windows.Forms.CheckBox()
        Me.PFicha_tomaMed = New System.Windows.Forms.Label()
        Me.txtMotivoConsulta = New System.Windows.Forms.TextBox()
        Me.PFicha_motCons = New System.Windows.Forms.Label()
        Me.txtProcedencia = New System.Windows.Forms.TextBox()
        Me.PFicha_proced = New System.Windows.Forms.Label()
        Me.txtAntecedentes = New System.Windows.Forms.TextBox()
        Me.PFicha_antecedentes = New System.Windows.Forms.Label()
        Me.chbAntecedentes = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn_aceptar = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PFicha_titulo
        '
        Me.PFicha_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PFicha_titulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PFicha_titulo.Location = New System.Drawing.Point(0, 9)
        Me.PFicha_titulo.Name = "PFicha_titulo"
        Me.PFicha_titulo.Size = New System.Drawing.Size(359, 40)
        Me.PFicha_titulo.TabIndex = 30
        Me.PFicha_titulo.Text = "FICHA MEDICA"
        Me.PFicha_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PFicha_titulo.UseWaitCursor = True
        '
        'txtMedicina
        '
        Me.txtMedicina.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtMedicina.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMedicina.Enabled = False
        Me.txtMedicina.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedicina.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtMedicina.Location = New System.Drawing.Point(5, 112)
        Me.txtMedicina.Name = "txtMedicina"
        Me.txtMedicina.Size = New System.Drawing.Size(144, 22)
        Me.txtMedicina.TabIndex = 31
        Me.txtMedicina.UseWaitCursor = True
        '
        'PFicha_cual
        '
        Me.PFicha_cual.AutoSize = True
        Me.PFicha_cual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PFicha_cual.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PFicha_cual.Location = New System.Drawing.Point(5, 89)
        Me.PFicha_cual.Name = "PFicha_cual"
        Me.PFicha_cual.Size = New System.Drawing.Size(41, 21)
        Me.PFicha_cual.TabIndex = 32
        Me.PFicha_cual.Text = "Cual"
        Me.PFicha_cual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PFicha_cual.UseWaitCursor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(359, 437)
        Me.ShapeContainer1.TabIndex = 33
        Me.ShapeContainer1.TabStop = False
        Me.ShapeContainer1.UseWaitCursor = True
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.UseWaitCursor = True
        Me.LineShape2.X1 = 204
        Me.LineShape2.X2 = 351
        Me.LineShape2.Y1 = 134
        Me.LineShape2.Y2 = 134
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.UseWaitCursor = True
        Me.LineShape1.X1 = 3
        Me.LineShape1.X2 = 150
        Me.LineShape1.Y1 = 134
        Me.LineShape1.Y2 = 134
        '
        'txtOcupacion
        '
        Me.txtOcupacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOcupacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtOcupacion.Location = New System.Drawing.Point(206, 112)
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.Size = New System.Drawing.Size(144, 22)
        Me.txtOcupacion.TabIndex = 31
        Me.txtOcupacion.UseWaitCursor = True
        '
        'PFicha_ocup
        '
        Me.PFicha_ocup.AutoSize = True
        Me.PFicha_ocup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PFicha_ocup.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PFicha_ocup.Location = New System.Drawing.Point(206, 89)
        Me.PFicha_ocup.Name = "PFicha_ocup"
        Me.PFicha_ocup.Size = New System.Drawing.Size(91, 21)
        Me.PFicha_ocup.TabIndex = 32
        Me.PFicha_ocup.Text = "Ocupacion*"
        Me.PFicha_ocup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PFicha_ocup.UseWaitCursor = True
        '
        'ckbMedicina
        '
        Me.ckbMedicina.AutoSize = True
        Me.ckbMedicina.Location = New System.Drawing.Point(128, 68)
        Me.ckbMedicina.Name = "ckbMedicina"
        Me.ckbMedicina.Size = New System.Drawing.Size(15, 14)
        Me.ckbMedicina.TabIndex = 34
        Me.ckbMedicina.UseVisualStyleBackColor = True
        Me.ckbMedicina.UseWaitCursor = True
        '
        'PFicha_tomaMed
        '
        Me.PFicha_tomaMed.AutoSize = True
        Me.PFicha_tomaMed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PFicha_tomaMed.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PFicha_tomaMed.Location = New System.Drawing.Point(1, 65)
        Me.PFicha_tomaMed.Name = "PFicha_tomaMed"
        Me.PFicha_tomaMed.Size = New System.Drawing.Size(128, 21)
        Me.PFicha_tomaMed.TabIndex = 32
        Me.PFicha_tomaMed.Text = "¿Toma medicina?"
        Me.PFicha_tomaMed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PFicha_tomaMed.UseWaitCursor = True
        '
        'txtMotivoConsulta
        '
        Me.txtMotivoConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtMotivoConsulta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoConsulta.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtMotivoConsulta.Location = New System.Drawing.Point(3, 167)
        Me.txtMotivoConsulta.Multiline = True
        Me.txtMotivoConsulta.Name = "txtMotivoConsulta"
        Me.txtMotivoConsulta.Size = New System.Drawing.Size(165, 72)
        Me.txtMotivoConsulta.TabIndex = 35
        Me.txtMotivoConsulta.UseWaitCursor = True
        '
        'PFicha_motCons
        '
        Me.PFicha_motCons.AutoSize = True
        Me.PFicha_motCons.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PFicha_motCons.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PFicha_motCons.Location = New System.Drawing.Point(3, 147)
        Me.PFicha_motCons.Name = "PFicha_motCons"
        Me.PFicha_motCons.Size = New System.Drawing.Size(165, 21)
        Me.PFicha_motCons.TabIndex = 32
        Me.PFicha_motCons.Text = "Motivo de la consulta*"
        Me.PFicha_motCons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PFicha_motCons.UseWaitCursor = True
        '
        'txtProcedencia
        '
        Me.txtProcedencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtProcedencia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcedencia.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtProcedencia.Location = New System.Drawing.Point(206, 167)
        Me.txtProcedencia.Multiline = True
        Me.txtProcedencia.Name = "txtProcedencia"
        Me.txtProcedencia.Size = New System.Drawing.Size(148, 72)
        Me.txtProcedencia.TabIndex = 35
        Me.txtProcedencia.UseWaitCursor = True
        '
        'PFicha_proced
        '
        Me.PFicha_proced.AutoSize = True
        Me.PFicha_proced.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PFicha_proced.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PFicha_proced.Location = New System.Drawing.Point(206, 143)
        Me.PFicha_proced.Name = "PFicha_proced"
        Me.PFicha_proced.Size = New System.Drawing.Size(101, 21)
        Me.PFicha_proced.TabIndex = 32
        Me.PFicha_proced.Text = "Procedencia*"
        Me.PFicha_proced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PFicha_proced.UseWaitCursor = True
        '
        'txtAntecedentes
        '
        Me.txtAntecedentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtAntecedentes.Enabled = False
        Me.txtAntecedentes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntecedentes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtAntecedentes.Location = New System.Drawing.Point(3, 286)
        Me.txtAntecedentes.Multiline = True
        Me.txtAntecedentes.Name = "txtAntecedentes"
        Me.txtAntecedentes.Size = New System.Drawing.Size(351, 72)
        Me.txtAntecedentes.TabIndex = 35
        Me.txtAntecedentes.UseWaitCursor = True
        '
        'PFicha_antecedentes
        '
        Me.PFicha_antecedentes.AutoSize = True
        Me.PFicha_antecedentes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PFicha_antecedentes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PFicha_antecedentes.Location = New System.Drawing.Point(2, 266)
        Me.PFicha_antecedentes.Name = "PFicha_antecedentes"
        Me.PFicha_antecedentes.Size = New System.Drawing.Size(103, 21)
        Me.PFicha_antecedentes.TabIndex = 32
        Me.PFicha_antecedentes.Text = "Antecedentes"
        Me.PFicha_antecedentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PFicha_antecedentes.UseWaitCursor = True
        '
        'chbAntecedentes
        '
        Me.chbAntecedentes.AutoSize = True
        Me.chbAntecedentes.Location = New System.Drawing.Point(105, 270)
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
        'btn_aceptar
        '
        Me.btn_aceptar.Animated = True
        Me.btn_aceptar.BackColor = System.Drawing.Color.Transparent
        Me.btn_aceptar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_aceptar.BorderRadius = 20
        Me.btn_aceptar.BorderThickness = 2
        Me.btn_aceptar.CheckedState.Parent = Me.btn_aceptar
        Me.btn_aceptar.CustomImages.Parent = Me.btn_aceptar
        Me.btn_aceptar.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_aceptar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_aceptar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_aceptar.HoverState.Parent = Me.btn_aceptar
        Me.btn_aceptar.Location = New System.Drawing.Point(3, 380)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_aceptar.ShadowDecoration.BorderRadius = 20
        Me.btn_aceptar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_aceptar.ShadowDecoration.Depth = 15
        Me.btn_aceptar.ShadowDecoration.Enabled = True
        Me.btn_aceptar.ShadowDecoration.Parent = Me.btn_aceptar
        Me.btn_aceptar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(6)
        Me.btn_aceptar.Size = New System.Drawing.Size(353, 50)
        Me.btn_aceptar.TabIndex = 37
        Me.btn_aceptar.Text = "ACEPTAR"
        Me.btn_aceptar.UseWaitCursor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView1.TabIndex = 38
        Me.DataGridView1.Visible = False
        '
        'FrmFichaMedicaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(359, 437)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.chbAntecedentes)
        Me.Controls.Add(Me.PFicha_antecedentes)
        Me.Controls.Add(Me.txtAntecedentes)
        Me.Controls.Add(Me.PFicha_proced)
        Me.Controls.Add(Me.txtProcedencia)
        Me.Controls.Add(Me.PFicha_motCons)
        Me.Controls.Add(Me.txtMotivoConsulta)
        Me.Controls.Add(Me.PFicha_tomaMed)
        Me.Controls.Add(Me.ckbMedicina)
        Me.Controls.Add(Me.PFicha_ocup)
        Me.Controls.Add(Me.txtOcupacion)
        Me.Controls.Add(Me.PFicha_cual)
        Me.Controls.Add(Me.txtMedicina)
        Me.Controls.Add(Me.PFicha_titulo)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFichaMedicaPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.UseWaitCursor = True
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PFicha_titulo As Label
    Friend WithEvents txtMedicina As TextBox
    Friend WithEvents PFicha_cual As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents txtOcupacion As TextBox
    Friend WithEvents PFicha_ocup As Label
    Friend WithEvents ckbMedicina As CheckBox
    Friend WithEvents PFicha_tomaMed As Label
    Friend WithEvents txtMotivoConsulta As TextBox
    Friend WithEvents PFicha_motCons As Label
    Friend WithEvents txtProcedencia As TextBox
    Friend WithEvents PFicha_proced As Label
    Friend WithEvents txtAntecedentes As TextBox
    Friend WithEvents PFicha_antecedentes As Label
    Friend WithEvents chbAntecedentes As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btn_aceptar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
