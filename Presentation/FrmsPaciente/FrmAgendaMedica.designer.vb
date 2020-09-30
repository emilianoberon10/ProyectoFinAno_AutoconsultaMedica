<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgendaMedica
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgendaMedica))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvAgenda = New System.Windows.Forms.DataGridView()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtNomBuscar = New System.Windows.Forms.TextBox()
        Me.btnFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.cbFiltro = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnBuscarMed = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.switch = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(255, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 40)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "AGENDA MEDICOS"
        '
        'dgvAgenda
        '
        Me.dgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAgenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAgenda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.dgvAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAgenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAgenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAgenda.ColumnHeadersHeight = 30
        Me.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAgenda.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAgenda.EnableHeadersVisualStyles = False
        Me.dgvAgenda.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvAgenda.Location = New System.Drawing.Point(22, 232)
        Me.dgvAgenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvAgenda.Name = "dgvAgenda"
        Me.dgvAgenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAgenda.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAgenda.Size = New System.Drawing.Size(735, 258)
        Me.dgvAgenda.TabIndex = 31
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(778, 699)
        Me.ShapeContainer1.TabIndex = 34
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 16
        Me.LineShape2.X2 = 229
        Me.LineShape2.Y1 = 206
        Me.LineShape2.Y2 = 206
        '
        'txtNomBuscar
        '
        Me.txtNomBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNomBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomBuscar.Enabled = False
        Me.txtNomBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomBuscar.ForeColor = System.Drawing.Color.Silver
        Me.txtNomBuscar.Location = New System.Drawing.Point(16, 180)
        Me.txtNomBuscar.MaxLength = 30
        Me.txtNomBuscar.Name = "txtNomBuscar"
        Me.txtNomBuscar.Size = New System.Drawing.Size(211, 22)
        Me.txtNomBuscar.TabIndex = 35
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Animated = True
        Me.btnFiltrar.AutoRoundedCorners = True
        Me.btnFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.btnFiltrar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnFiltrar.BorderRadius = 17
        Me.btnFiltrar.CheckedState.Parent = Me.btnFiltrar
        Me.btnFiltrar.CustomImages.Parent = Me.btnFiltrar
        Me.btnFiltrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnFiltrar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnFiltrar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnFiltrar.HoverState.Parent = Me.btnFiltrar
        Me.btnFiltrar.Location = New System.Drawing.Point(235, 110)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnFiltrar.ShadowDecoration.BorderRadius = 20
        Me.btnFiltrar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnFiltrar.ShadowDecoration.Depth = 15
        Me.btnFiltrar.ShadowDecoration.Enabled = True
        Me.btnFiltrar.ShadowDecoration.Parent = Me.btnFiltrar
        Me.btnFiltrar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btnFiltrar.Size = New System.Drawing.Size(180, 36)
        Me.btnFiltrar.TabIndex = 40
        Me.btnFiltrar.Text = "FILTRAR"
        '
        'cbFiltro
        '
        Me.cbFiltro.Animated = True
        Me.cbFiltro.BackColor = System.Drawing.Color.Transparent
        Me.cbFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltro.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFiltro.FocusedColor = System.Drawing.Color.Empty
        Me.cbFiltro.FocusedState.Parent = Me.cbFiltro
        Me.cbFiltro.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.HoverState.Parent = Me.cbFiltro
        Me.cbFiltro.ItemHeight = 30
        Me.cbFiltro.ItemsAppearance.Parent = Me.cbFiltro
        Me.cbFiltro.Location = New System.Drawing.Point(16, 110)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.ShadowDecoration.Parent = Me.cbFiltro
        Me.cbFiltro.Size = New System.Drawing.Size(213, 36)
        Me.cbFiltro.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbFiltro.TabIndex = 41
        '
        'btnBuscarMed
        '
        Me.btnBuscarMed.Animated = True
        Me.btnBuscarMed.AutoRoundedCorners = True
        Me.btnBuscarMed.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarMed.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBuscarMed.BorderRadius = 17
        Me.btnBuscarMed.CheckedState.Parent = Me.btnBuscarMed
        Me.btnBuscarMed.CustomImages.Parent = Me.btnBuscarMed
        Me.btnBuscarMed.Enabled = False
        Me.btnBuscarMed.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBuscarMed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarMed.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscarMed.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnBuscarMed.HoverState.Parent = Me.btnBuscarMed
        Me.btnBuscarMed.Location = New System.Drawing.Point(235, 171)
        Me.btnBuscarMed.Name = "btnBuscarMed"
        Me.btnBuscarMed.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnBuscarMed.ShadowDecoration.BorderRadius = 20
        Me.btnBuscarMed.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnBuscarMed.ShadowDecoration.Depth = 15
        Me.btnBuscarMed.ShadowDecoration.Enabled = True
        Me.btnBuscarMed.ShadowDecoration.Parent = Me.btnBuscarMed
        Me.btnBuscarMed.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btnBuscarMed.Size = New System.Drawing.Size(180, 36)
        Me.btnBuscarMed.TabIndex = 40
        Me.btnBuscarMed.Text = "BUSCAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(12, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 21)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "PRIMER NOMBRE"
        '
        'switch
        '
        Me.switch.Animated = True
        Me.switch.AutoRoundedCorners = True
        Me.switch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.switch.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.switch.CheckedState.InnerColor = System.Drawing.Color.White
        Me.switch.CheckedState.Parent = Me.switch
        Me.switch.Location = New System.Drawing.Point(421, 179)
        Me.switch.Name = "switch"
        Me.switch.ShadowDecoration.Parent = Me.switch
        Me.switch.Size = New System.Drawing.Size(35, 20)
        Me.switch.TabIndex = 44
        Me.switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.switch.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.switch.UncheckedState.Parent = Me.switch
        '
        'FrmAgendaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 699)
        Me.Controls.Add(Me.switch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscarMed)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.txtNomBuscar)
        Me.Controls.Add(Me.dgvAgenda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAgendaMedica"
        Me.Text = "FrmAgendaMedica"
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgvAgenda As DataGridView
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents txtNomBuscar As TextBox
    Friend WithEvents btnFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbFiltro As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnBuscarMed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents switch As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
