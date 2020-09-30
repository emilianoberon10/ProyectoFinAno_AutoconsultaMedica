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
        Me.DgvHistorial = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEntre = New Guna.UI2.WinForms.Guna2Button()
        Me.switch = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        CType(Me.DgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvHistorial
        '
        Me.DgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvHistorial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.DgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvHistorial.ColumnHeadersHeight = 30
        Me.DgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvHistorial.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvHistorial.EnableHeadersVisualStyles = False
        Me.DgvHistorial.GridColor = System.Drawing.Color.SteelBlue
        Me.DgvHistorial.Location = New System.Drawing.Point(268, 218)
        Me.DgvHistorial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DgvHistorial.Name = "DgvHistorial"
        Me.DgvHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHistorial.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvHistorial.Size = New System.Drawing.Size(242, 258)
        Me.DgvHistorial.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(198, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 36)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "HISTORIAL DE CONSULTAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(13, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Esta fecha debe ser mayor"
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
        Me.btnFiltrar.Location = New System.Drawing.Point(265, 54)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnFiltrar.ShadowDecoration.BorderRadius = 20
        Me.btnFiltrar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnFiltrar.ShadowDecoration.Depth = 15
        Me.btnFiltrar.ShadowDecoration.Enabled = True
        Me.btnFiltrar.ShadowDecoration.Parent = Me.btnFiltrar
        Me.btnFiltrar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btnFiltrar.Size = New System.Drawing.Size(150, 36)
        Me.btnFiltrar.TabIndex = 45
        Me.btnFiltrar.Text = "FILTRAR"
        '
        'btnEntre
        '
        Me.btnEntre.Animated = True
        Me.btnEntre.AutoRoundedCorners = True
        Me.btnEntre.BackColor = System.Drawing.Color.Transparent
        Me.btnEntre.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEntre.BorderRadius = 17
        Me.btnEntre.CheckedState.Parent = Me.btnEntre
        Me.btnEntre.CustomImages.Parent = Me.btnEntre
        Me.btnEntre.Enabled = False
        Me.btnEntre.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEntre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntre.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEntre.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEntre.HoverState.Parent = Me.btnEntre
        Me.btnEntre.Location = New System.Drawing.Point(265, 105)
        Me.btnEntre.Name = "btnEntre"
        Me.btnEntre.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnEntre.ShadowDecoration.BorderRadius = 20
        Me.btnEntre.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnEntre.ShadowDecoration.Depth = 15
        Me.btnEntre.ShadowDecoration.Enabled = True
        Me.btnEntre.ShadowDecoration.Parent = Me.btnEntre
        Me.btnEntre.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btnEntre.Size = New System.Drawing.Size(150, 36)
        Me.btnEntre.TabIndex = 46
        Me.btnEntre.Text = "ENTRE"
        '
        'switch
        '
        Me.switch.Animated = True
        Me.switch.AutoRoundedCorners = True
        Me.switch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.switch.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.switch.CheckedState.InnerColor = System.Drawing.Color.White
        Me.switch.CheckedState.Parent = Me.switch
        Me.switch.Location = New System.Drawing.Point(421, 113)
        Me.switch.Name = "switch"
        Me.switch.ShadowDecoration.Parent = Me.switch
        Me.switch.Size = New System.Drawing.Size(35, 20)
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
        Me.DateTimePicker2.Location = New System.Drawing.Point(16, 109)
        Me.DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShadowDecoration.Parent = Me.DateTimePicker2
        Me.DateTimePicker2.Size = New System.Drawing.Size(238, 28)
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(16, 58)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShadowDecoration.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.Size = New System.Drawing.Size(238, 28)
        Me.DateTimePicker1.TabIndex = 48
        Me.DateTimePicker1.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'FrmHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 699)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.switch)
        Me.Controls.Add(Me.btnEntre)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvHistorial)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmHistorial"
        Me.Text = "FrmHistorial"
        CType(Me.DgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvHistorial As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFiltrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEntre As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents switch As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
