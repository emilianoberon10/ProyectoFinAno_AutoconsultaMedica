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
        Me.Agenda_titulo = New System.Windows.Forms.Label()
        Me.dgvAgenda = New System.Windows.Forms.DataGridView()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtNomBuscar = New System.Windows.Forms.TextBox()
        Me.btn_Filtrar = New Guna.UI2.WinForms.Guna2Button()
        Me.cbFiltro = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_Buscar = New Guna.UI2.WinForms.Guna2Button()
        Me.Persona_pNom = New System.Windows.Forms.Label()
        Me.switch = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agenda_titulo
        '
        Me.Agenda_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agenda_titulo.ForeColor = System.Drawing.Color.Silver
        Me.Agenda_titulo.Location = New System.Drawing.Point(0, 9)
        Me.Agenda_titulo.Name = "Agenda_titulo"
        Me.Agenda_titulo.Size = New System.Drawing.Size(778, 40)
        Me.Agenda_titulo.TabIndex = 30
        Me.Agenda_titulo.Text = "AGENDA MEDICOS"
        Me.Agenda_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dgvAgenda.ReadOnly = True
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
        'btn_Filtrar
        '
        Me.btn_Filtrar.Animated = True
        Me.btn_Filtrar.AutoRoundedCorners = True
        Me.btn_Filtrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Filtrar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Filtrar.BorderRadius = 17
        Me.btn_Filtrar.CheckedState.Parent = Me.btn_Filtrar
        Me.btn_Filtrar.CustomImages.Parent = Me.btn_Filtrar
        Me.btn_Filtrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Filtrar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Filtrar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Filtrar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Filtrar.HoverState.Parent = Me.btn_Filtrar
        Me.btn_Filtrar.Location = New System.Drawing.Point(235, 110)
        Me.btn_Filtrar.Name = "btn_Filtrar"
        Me.btn_Filtrar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_Filtrar.ShadowDecoration.BorderRadius = 20
        Me.btn_Filtrar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_Filtrar.ShadowDecoration.Depth = 15
        Me.btn_Filtrar.ShadowDecoration.Enabled = True
        Me.btn_Filtrar.ShadowDecoration.Parent = Me.btn_Filtrar
        Me.btn_Filtrar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_Filtrar.Size = New System.Drawing.Size(180, 36)
        Me.btn_Filtrar.TabIndex = 40
        Me.btn_Filtrar.Text = "FILTRAR"
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
        'btn_Buscar
        '
        Me.btn_Buscar.Animated = True
        Me.btn_Buscar.AutoRoundedCorners = True
        Me.btn_Buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Buscar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Buscar.BorderRadius = 17
        Me.btn_Buscar.CheckedState.Parent = Me.btn_Buscar
        Me.btn_Buscar.CustomImages.Parent = Me.btn_Buscar
        Me.btn_Buscar.Enabled = False
        Me.btn_Buscar.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Buscar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Buscar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Buscar.HoverState.Parent = Me.btn_Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(235, 171)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_Buscar.ShadowDecoration.BorderRadius = 20
        Me.btn_Buscar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_Buscar.ShadowDecoration.Depth = 15
        Me.btn_Buscar.ShadowDecoration.Enabled = True
        Me.btn_Buscar.ShadowDecoration.Parent = Me.btn_Buscar
        Me.btn_Buscar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_Buscar.Size = New System.Drawing.Size(180, 36)
        Me.btn_Buscar.TabIndex = 40
        Me.btn_Buscar.Text = "BUSCAR"
        '
        'Persona_pNom
        '
        Me.Persona_pNom.AutoSize = True
        Me.Persona_pNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_pNom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_pNom.Location = New System.Drawing.Point(12, 156)
        Me.Persona_pNom.Name = "Persona_pNom"
        Me.Persona_pNom.Size = New System.Drawing.Size(134, 21)
        Me.Persona_pNom.TabIndex = 42
        Me.Persona_pNom.Text = "PRIMER NOMBRE"
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
        Me.Controls.Add(Me.Persona_pNom)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.btn_Filtrar)
        Me.Controls.Add(Me.txtNomBuscar)
        Me.Controls.Add(Me.dgvAgenda)
        Me.Controls.Add(Me.Agenda_titulo)
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

    Friend WithEvents Agenda_titulo As Label
    Friend WithEvents dgvAgenda As DataGridView
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents txtNomBuscar As TextBox
    Friend WithEvents btn_Filtrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbFiltro As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_Buscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Persona_pNom As Label
    Friend WithEvents switch As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
