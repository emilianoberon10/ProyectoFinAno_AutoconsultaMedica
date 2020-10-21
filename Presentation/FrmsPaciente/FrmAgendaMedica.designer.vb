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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgendaMedica))
        Me.Agenda_titulo = New System.Windows.Forms.Label()
        Me.btn_Filtrar = New Guna.UI2.WinForms.Guna2Button()
        Me.cbFiltro = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_Buscar = New Guna.UI2.WinForms.Guna2Button()
        Me.Persona_pNom = New System.Windows.Forms.Label()
        Me.switch = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.dgvAgenda = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtNomBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Agenda_titulo
        '
        Me.Agenda_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agenda_titulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Agenda_titulo.Location = New System.Drawing.Point(0, 7)
        Me.Agenda_titulo.Name = "Agenda_titulo"
        Me.Agenda_titulo.Size = New System.Drawing.Size(802, 43)
        Me.Agenda_titulo.TabIndex = 30
        Me.Agenda_titulo.Text = "AGENDA MEDICOS"
        Me.Agenda_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Filtrar
        '
        Me.btn_Filtrar.Animated = True
        Me.btn_Filtrar.AutoRoundedCorners = True
        Me.btn_Filtrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Filtrar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Filtrar.BorderRadius = 19
        Me.btn_Filtrar.CheckedState.Parent = Me.btn_Filtrar
        Me.btn_Filtrar.CustomImages.Parent = Me.btn_Filtrar
        Me.btn_Filtrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Filtrar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Filtrar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Filtrar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Filtrar.HoverState.Parent = Me.btn_Filtrar
        Me.btn_Filtrar.Location = New System.Drawing.Point(289, 89)
        Me.btn_Filtrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Filtrar.Name = "btn_Filtrar"
        Me.btn_Filtrar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_Filtrar.ShadowDecoration.BorderRadius = 20
        Me.btn_Filtrar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_Filtrar.ShadowDecoration.Depth = 15
        Me.btn_Filtrar.ShadowDecoration.Enabled = True
        Me.btn_Filtrar.ShadowDecoration.Parent = Me.btn_Filtrar
        Me.btn_Filtrar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_Filtrar.Size = New System.Drawing.Size(180, 40)
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
        Me.cbFiltro.Location = New System.Drawing.Point(16, 89)
        Me.cbFiltro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.ShadowDecoration.Parent = Me.cbFiltro
        Me.cbFiltro.Size = New System.Drawing.Size(269, 36)
        Me.cbFiltro.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbFiltro.TabIndex = 41
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Animated = True
        Me.btn_Buscar.AutoRoundedCorners = True
        Me.btn_Buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Buscar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Buscar.BorderRadius = 19
        Me.btn_Buscar.CheckedState.Parent = Me.btn_Buscar
        Me.btn_Buscar.CustomImages.Parent = Me.btn_Buscar
        Me.btn_Buscar.Enabled = False
        Me.btn_Buscar.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Buscar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Buscar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Buscar.HoverState.Parent = Me.btn_Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(290, 160)
        Me.btn_Buscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_Buscar.ShadowDecoration.BorderRadius = 20
        Me.btn_Buscar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_Buscar.ShadowDecoration.Depth = 15
        Me.btn_Buscar.ShadowDecoration.Enabled = True
        Me.btn_Buscar.ShadowDecoration.Parent = Me.btn_Buscar
        Me.btn_Buscar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_Buscar.Size = New System.Drawing.Size(180, 40)
        Me.btn_Buscar.TabIndex = 40
        Me.btn_Buscar.Text = "BUSCAR"
        '
        'Persona_pNom
        '
        Me.Persona_pNom.AutoSize = True
        Me.Persona_pNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_pNom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_pNom.Location = New System.Drawing.Point(16, 144)
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
        Me.switch.Location = New System.Drawing.Point(476, 170)
        Me.switch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.switch.Name = "switch"
        Me.switch.ShadowDecoration.Parent = Me.switch
        Me.switch.Size = New System.Drawing.Size(40, 20)
        Me.switch.TabIndex = 44
        Me.switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.switch.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.switch.UncheckedState.Parent = Me.switch
        '
        'dgvAgenda
        '
        Me.dgvAgenda.AllowUserToAddRows = False
        Me.dgvAgenda.AllowUserToDeleteRows = False
        Me.dgvAgenda.AllowUserToResizeColumns = False
        Me.dgvAgenda.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAgenda.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvAgenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvAgenda.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAgenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvAgenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAgenda.ColumnHeadersHeight = 45
        Me.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAgenda.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAgenda.EnableHeadersVisualStyles = False
        Me.dgvAgenda.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.dgvAgenda.Location = New System.Drawing.Point(15, 240)
        Me.dgvAgenda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvAgenda.MultiSelect = False
        Me.dgvAgenda.Name = "dgvAgenda"
        Me.dgvAgenda.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvAgenda.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAgenda.RowHeadersVisible = False
        Me.dgvAgenda.RowHeadersWidth = 50
        Me.dgvAgenda.RowTemplate.Height = 50
        Me.dgvAgenda.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAgenda.Size = New System.Drawing.Size(772, 432)
        Me.dgvAgenda.TabIndex = 45
        Me.dgvAgenda.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvAgenda.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAgenda.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAgenda.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAgenda.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAgenda.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAgenda.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAgenda.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.dgvAgenda.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.dgvAgenda.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAgenda.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAgenda.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAgenda.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAgenda.ThemeStyle.HeaderStyle.Height = 45
        Me.dgvAgenda.ThemeStyle.ReadOnly = True
        Me.dgvAgenda.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAgenda.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAgenda.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAgenda.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.dgvAgenda.ThemeStyle.RowsStyle.Height = 50
        Me.dgvAgenda.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgvAgenda.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        '
        'txtNomBuscar
        '
        Me.txtNomBuscar.Animated = True
        Me.txtNomBuscar.BorderThickness = 2
        Me.txtNomBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNomBuscar.DefaultText = ""
        Me.txtNomBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNomBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNomBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNomBuscar.DisabledState.Parent = Me.txtNomBuscar
        Me.txtNomBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNomBuscar.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNomBuscar.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtNomBuscar.FocusedState.Parent = Me.txtNomBuscar
        Me.txtNomBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomBuscar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtNomBuscar.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtNomBuscar.HoverState.Parent = Me.txtNomBuscar
        Me.txtNomBuscar.Location = New System.Drawing.Point(16, 170)
        Me.txtNomBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNomBuscar.Name = "txtNomBuscar"
        Me.txtNomBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomBuscar.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtNomBuscar.PlaceholderText = ""
        Me.txtNomBuscar.SelectedText = ""
        Me.txtNomBuscar.ShadowDecoration.Parent = Me.txtNomBuscar
        Me.txtNomBuscar.Size = New System.Drawing.Size(267, 30)
        Me.txtNomBuscar.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtNomBuscar.TabIndex = 46
        '
        'FrmAgendaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 683)
        Me.Controls.Add(Me.txtNomBuscar)
        Me.Controls.Add(Me.dgvAgenda)
        Me.Controls.Add(Me.switch)
        Me.Controls.Add(Me.Persona_pNom)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.btn_Filtrar)
        Me.Controls.Add(Me.Agenda_titulo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAgendaMedica"
        Me.Text = "FrmAgendaMedica"
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Agenda_titulo As Label
    Friend WithEvents btn_Filtrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbFiltro As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_Buscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Persona_pNom As Label
    Friend WithEvents switch As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents dgvAgenda As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtNomBuscar As Guna.UI2.WinForms.Guna2TextBox
End Class
