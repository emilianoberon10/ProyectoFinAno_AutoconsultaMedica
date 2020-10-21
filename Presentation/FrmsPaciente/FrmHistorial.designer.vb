<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHistorial))
        Me.Histo_titulo = New System.Windows.Forms.Label()
        Me.Histo_aclara = New System.Windows.Forms.Label()
        Me.btn_Filtrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Entre = New Guna.UI2.WinForms.Guna2Button()
        Me.switch = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DgvHistorial = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.DgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Histo_titulo
        '
        Me.Histo_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Histo_titulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Histo_titulo.Location = New System.Drawing.Point(0, 7)
        Me.Histo_titulo.Name = "Histo_titulo"
        Me.Histo_titulo.Size = New System.Drawing.Size(803, 32)
        Me.Histo_titulo.TabIndex = 38
        Me.Histo_titulo.Text = "HISTORIAL DE CONSULTAS"
        Me.Histo_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Histo_aclara
        '
        Me.Histo_aclara.AutoSize = True
        Me.Histo_aclara.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Histo_aclara.ForeColor = System.Drawing.Color.Silver
        Me.Histo_aclara.Location = New System.Drawing.Point(31, 112)
        Me.Histo_aclara.Name = "Histo_aclara"
        Me.Histo_aclara.Size = New System.Drawing.Size(154, 17)
        Me.Histo_aclara.TabIndex = 44
        Me.Histo_aclara.Text = "Esta fecha debe ser mayor"
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
        Me.btn_Filtrar.Location = New System.Drawing.Point(273, 68)
        Me.btn_Filtrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Filtrar.Name = "btn_Filtrar"
        Me.btn_Filtrar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_Filtrar.ShadowDecoration.BorderRadius = 20
        Me.btn_Filtrar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_Filtrar.ShadowDecoration.Depth = 15
        Me.btn_Filtrar.ShadowDecoration.Enabled = True
        Me.btn_Filtrar.ShadowDecoration.Parent = Me.btn_Filtrar
        Me.btn_Filtrar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_Filtrar.Size = New System.Drawing.Size(168, 40)
        Me.btn_Filtrar.TabIndex = 45
        Me.btn_Filtrar.Text = "FILTRAR"
        '
        'btn_Entre
        '
        Me.btn_Entre.Animated = True
        Me.btn_Entre.AutoRoundedCorners = True
        Me.btn_Entre.BackColor = System.Drawing.Color.Transparent
        Me.btn_Entre.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Entre.BorderRadius = 19
        Me.btn_Entre.CheckedState.Parent = Me.btn_Entre
        Me.btn_Entre.CustomImages.Parent = Me.btn_Entre
        Me.btn_Entre.Enabled = False
        Me.btn_Entre.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Entre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Entre.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Entre.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Entre.HoverState.Parent = Me.btn_Entre
        Me.btn_Entre.Location = New System.Drawing.Point(273, 131)
        Me.btn_Entre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Entre.Name = "btn_Entre"
        Me.btn_Entre.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_Entre.ShadowDecoration.BorderRadius = 20
        Me.btn_Entre.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_Entre.ShadowDecoration.Depth = 15
        Me.btn_Entre.ShadowDecoration.Enabled = True
        Me.btn_Entre.ShadowDecoration.Parent = Me.btn_Entre
        Me.btn_Entre.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_Entre.Size = New System.Drawing.Size(166, 40)
        Me.btn_Entre.TabIndex = 46
        Me.btn_Entre.Text = "ENTRE"
        '
        'switch
        '
        Me.switch.Animated = True
        Me.switch.AutoRoundedCorners = True
        Me.switch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.switch.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.switch.CheckedState.InnerColor = System.Drawing.Color.White
        Me.switch.CheckedState.Parent = Me.switch
        Me.switch.Location = New System.Drawing.Point(445, 141)
        Me.switch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.switch.Name = "switch"
        Me.switch.ShadowDecoration.Parent = Me.switch
        Me.switch.Size = New System.Drawing.Size(40, 20)
        Me.switch.TabIndex = 47
        Me.switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.switch.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.switch.UncheckedState.Parent = Me.switch
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.BorderColor = System.Drawing.SystemColors.Window
        Me.DateTimePicker2.CheckedState.Parent = Me.DateTimePicker2
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.FillColor = System.Drawing.Color.White
        Me.DateTimePicker2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.HoverState.Parent = Me.DateTimePicker2
        Me.DateTimePicker2.Location = New System.Drawing.Point(31, 131)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShadowDecoration.Parent = Me.DateTimePicker2
        Me.DateTimePicker2.Size = New System.Drawing.Size(215, 40)
        Me.DateTimePicker2.TabIndex = 48
        Me.DateTimePicker2.Value = New Date(2020, 9, 27, 20, 15, 22, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BorderColor = System.Drawing.SystemColors.Window
        Me.DateTimePicker1.CheckedState.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.FillColor = System.Drawing.Color.White
        Me.DateTimePicker1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.HoverState.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.Location = New System.Drawing.Point(31, 68)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShadowDecoration.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.Size = New System.Drawing.Size(215, 40)
        Me.DateTimePicker1.TabIndex = 48
        Me.DateTimePicker1.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'DgvHistorial
        '
        Me.DgvHistorial.AllowUserToAddRows = False
        Me.DgvHistorial.AllowUserToDeleteRows = False
        Me.DgvHistorial.AllowUserToResizeColumns = False
        Me.DgvHistorial.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvHistorial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvHistorial.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvHistorial.ColumnHeadersHeight = 30
        Me.DgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHistorial.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvHistorial.EnableHeadersVisualStyles = False
        Me.DgvHistorial.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvHistorial.Location = New System.Drawing.Point(12, 234)
        Me.DgvHistorial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvHistorial.MultiSelect = False
        Me.DgvHistorial.Name = "DgvHistorial"
        Me.DgvHistorial.ReadOnly = True
        Me.DgvHistorial.RowHeadersVisible = False
        Me.DgvHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvHistorial.RowTemplate.Height = 30
        Me.DgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvHistorial.Size = New System.Drawing.Size(783, 323)
        Me.DgvHistorial.TabIndex = 49
        Me.DgvHistorial.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DgvHistorial.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvHistorial.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvHistorial.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvHistorial.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvHistorial.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvHistorial.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvHistorial.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvHistorial.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DgvHistorial.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvHistorial.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvHistorial.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgvHistorial.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvHistorial.ThemeStyle.HeaderStyle.Height = 30
        Me.DgvHistorial.ThemeStyle.ReadOnly = True
        Me.DgvHistorial.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvHistorial.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvHistorial.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvHistorial.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DgvHistorial.ThemeStyle.RowsStyle.Height = 30
        Me.DgvHistorial.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.DgvHistorial.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        '
        'FrmHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 683)
        Me.Controls.Add(Me.DgvHistorial)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.switch)
        Me.Controls.Add(Me.btn_Entre)
        Me.Controls.Add(Me.btn_Filtrar)
        Me.Controls.Add(Me.Histo_aclara)
        Me.Controls.Add(Me.Histo_titulo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHistorial"
        Me.Text = "FrmHistorial"
        CType(Me.DgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Histo_titulo As Label
    Friend WithEvents Histo_aclara As Label
    Friend WithEvents btn_Filtrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Entre As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents switch As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DgvHistorial As Guna.UI2.WinForms.Guna2DataGridView
End Class
