<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarGerente
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
        Me.elimiAclara = New System.Windows.Forms.Label()
        Me.lbEliminar = New System.Windows.Forms.Label()
        Me.selecFiltro = New System.Windows.Forms.Label()
        Me.idElemento = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.cbFiltro = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_eliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtFiltro = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'elimiAclara
        '
        Me.elimiAclara.AutoSize = True
        Me.elimiAclara.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elimiAclara.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.elimiAclara.Location = New System.Drawing.Point(12, 149)
        Me.elimiAclara.Name = "elimiAclara"
        Me.elimiAclara.Size = New System.Drawing.Size(337, 17)
        Me.elimiAclara.TabIndex = 9
        Me.elimiAclara.Text = "Haga doble click en una celda para seleccionar el elemento"
        '
        'lbEliminar
        '
        Me.lbEliminar.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEliminar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbEliminar.Location = New System.Drawing.Point(0, 9)
        Me.lbEliminar.Name = "lbEliminar"
        Me.lbEliminar.Size = New System.Drawing.Size(668, 40)
        Me.lbEliminar.TabIndex = 13
        Me.lbEliminar.Text = "Eliminar"
        Me.lbEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selecFiltro
        '
        Me.selecFiltro.AutoSize = True
        Me.selecFiltro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selecFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.selecFiltro.Location = New System.Drawing.Point(11, 67)
        Me.selecFiltro.Name = "selecFiltro"
        Me.selecFiltro.Size = New System.Drawing.Size(142, 21)
        Me.selecFiltro.TabIndex = 9
        Me.selecFiltro.Text = "Seleccione un filtro"
        '
        'idElemento
        '
        Me.idElemento.AutoSize = True
        Me.idElemento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idElemento.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.idElemento.Location = New System.Drawing.Point(259, 67)
        Me.idElemento.Name = "idElemento"
        Me.idElemento.Size = New System.Drawing.Size(191, 21)
        Me.idElemento.TabIndex = 9
        Me.idElemento.Text = "Identificador del Elemento"
        '
        'dgvDatos
        '
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDatos.ColumnHeadersHeight = 30
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDatos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatos.EnableHeadersVisualStyles = False
        Me.dgvDatos.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvDatos.Location = New System.Drawing.Point(12, 169)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDatos.Size = New System.Drawing.Size(640, 181)
        Me.dgvDatos.TabIndex = 15
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
        Me.cbFiltro.Items.AddRange(New Object() {"Sintomas", "Enfermedades", "Medicos"})
        Me.cbFiltro.ItemsAppearance.Parent = Me.cbFiltro
        Me.cbFiltro.Location = New System.Drawing.Point(15, 87)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.ShadowDecoration.Parent = Me.cbFiltro
        Me.cbFiltro.Size = New System.Drawing.Size(213, 36)
        Me.cbFiltro.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbFiltro.TabIndex = 42
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Animated = True
        Me.btn_eliminar.AutoRoundedCorners = True
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_eliminar.BorderRadius = 17
        Me.btn_eliminar.CheckedState.Parent = Me.btn_eliminar
        Me.btn_eliminar.CustomImages.Parent = Me.btn_eliminar
        Me.btn_eliminar.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_eliminar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_eliminar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_eliminar.HoverState.Parent = Me.btn_eliminar
        Me.btn_eliminar.Location = New System.Drawing.Point(472, 356)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_eliminar.ShadowDecoration.BorderRadius = 20
        Me.btn_eliminar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_eliminar.ShadowDecoration.Depth = 15
        Me.btn_eliminar.ShadowDecoration.Enabled = True
        Me.btn_eliminar.ShadowDecoration.Parent = Me.btn_eliminar
        Me.btn_eliminar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_eliminar.Size = New System.Drawing.Size(180, 36)
        Me.btn_eliminar.TabIndex = 43
        Me.btn_eliminar.Text = "ELIMINAR"
        '
        'txtFiltro
        '
        Me.txtFiltro.Animated = True
        Me.txtFiltro.BackColor = System.Drawing.Color.Transparent
        Me.txtFiltro.BorderRadius = 10
        Me.txtFiltro.BorderThickness = 2
        Me.txtFiltro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFiltro.DefaultText = ""
        Me.txtFiltro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFiltro.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFiltro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFiltro.DisabledState.Parent = Me.txtFiltro
        Me.txtFiltro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFiltro.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtFiltro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtFiltro.FocusedState.Parent = Me.txtFiltro
        Me.txtFiltro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtFiltro.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtFiltro.HoverState.Parent = Me.txtFiltro
        Me.txtFiltro.Location = New System.Drawing.Point(263, 93)
        Me.txtFiltro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFiltro.PlaceholderText = ""
        Me.txtFiltro.SelectedText = ""
        Me.txtFiltro.ShadowDecoration.BorderRadius = 10
        Me.txtFiltro.ShadowDecoration.Parent = Me.txtFiltro
        Me.txtFiltro.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.txtFiltro.Size = New System.Drawing.Size(219, 30)
        Me.txtFiltro.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtFiltro.TabIndex = 54
        '
        'FrmEliminarGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 570)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.lbEliminar)
        Me.Controls.Add(Me.idElemento)
        Me.Controls.Add(Me.selecFiltro)
        Me.Controls.Add(Me.elimiAclara)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEliminarGerente"
        Me.Text = "FrmEliminar"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents elimiAclara As Label
    Friend WithEvents lbEliminar As Label
    Friend WithEvents selecFiltro As Label
    Friend WithEvents idElemento As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents cbFiltro As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_eliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtFiltro As Guna.UI2.WinForms.Guna2TextBox
End Class
