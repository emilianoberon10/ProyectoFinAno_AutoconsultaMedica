<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultaPaciente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaPaciente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn_chat = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_consultar = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvDiagnostico = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cbSintoma9 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma6 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma8 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma5 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma7 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma4 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSintoma1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.chb8 = New System.Windows.Forms.CheckBox()
        Me.chb7 = New System.Windows.Forms.CheckBox()
        Me.chb6 = New System.Windows.Forms.CheckBox()
        Me.chb5 = New System.Windows.Forms.CheckBox()
        Me.chb4 = New System.Windows.Forms.CheckBox()
        Me.chb3 = New System.Windows.Forms.CheckBox()
        Me.chb2 = New System.Windows.Forms.CheckBox()
        Me.chb1 = New System.Windows.Forms.CheckBox()
        Me.consu_titulo = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDiagnostico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, -126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 39)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "INGRESE SUS SINTOMAS"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'btn_chat
        '
        Me.btn_chat.Animated = True
        Me.btn_chat.BackColor = System.Drawing.Color.Transparent
        Me.btn_chat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_chat.BorderRadius = 20
        Me.btn_chat.CheckedState.Parent = Me.btn_chat
        Me.btn_chat.CustomImages.Parent = Me.btn_chat
        Me.btn_chat.FillColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_chat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_chat.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_chat.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_chat.HoverState.Parent = Me.btn_chat
        Me.btn_chat.Location = New System.Drawing.Point(533, 347)
        Me.btn_chat.Name = "btn_chat"
        Me.btn_chat.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_chat.ShadowDecoration.BorderRadius = 20
        Me.btn_chat.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_chat.ShadowDecoration.Depth = 15
        Me.btn_chat.ShadowDecoration.Enabled = True
        Me.btn_chat.ShadowDecoration.Parent = Me.btn_chat
        Me.btn_chat.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_chat.Size = New System.Drawing.Size(233, 50)
        Me.btn_chat.TabIndex = 60
        Me.btn_chat.Text = "CHAT"
        '
        'btn_consultar
        '
        Me.btn_consultar.Animated = True
        Me.btn_consultar.BackColor = System.Drawing.Color.Transparent
        Me.btn_consultar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_consultar.BorderRadius = 20
        Me.btn_consultar.BorderThickness = 2
        Me.btn_consultar.CheckedState.Parent = Me.btn_consultar
        Me.btn_consultar.CustomImages.Parent = Me.btn_consultar
        Me.btn_consultar.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_consultar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_consultar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_consultar.HoverState.Parent = Me.btn_consultar
        Me.btn_consultar.Location = New System.Drawing.Point(12, 347)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_consultar.ShadowDecoration.BorderRadius = 20
        Me.btn_consultar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_consultar.ShadowDecoration.Depth = 15
        Me.btn_consultar.ShadowDecoration.Enabled = True
        Me.btn_consultar.ShadowDecoration.Parent = Me.btn_consultar
        Me.btn_consultar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_consultar.Size = New System.Drawing.Size(233, 50)
        Me.btn_consultar.TabIndex = 59
        Me.btn_consultar.Text = "CONSULTAR"
        '
        'dgvDiagnostico
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgvDiagnostico.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDiagnostico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDiagnostico.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.dgvDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDiagnostico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDiagnostico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDiagnostico.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDiagnostico.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDiagnostico.Enabled = False
        Me.dgvDiagnostico.EnableHeadersVisualStyles = False
        Me.dgvDiagnostico.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.dgvDiagnostico.Location = New System.Drawing.Point(315, 408)
        Me.dgvDiagnostico.Name = "dgvDiagnostico"
        Me.dgvDiagnostico.ReadOnly = True
        Me.dgvDiagnostico.RowHeadersVisible = False
        Me.dgvDiagnostico.RowTemplate.Height = 24
        Me.dgvDiagnostico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDiagnostico.Size = New System.Drawing.Size(163, 266)
        Me.dgvDiagnostico.TabIndex = 58
        Me.dgvDiagnostico.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue
        Me.dgvDiagnostico.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgvDiagnostico.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDiagnostico.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDiagnostico.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDiagnostico.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDiagnostico.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.dgvDiagnostico.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.dgvDiagnostico.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.dgvDiagnostico.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDiagnostico.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDiagnostico.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDiagnostico.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDiagnostico.ThemeStyle.HeaderStyle.Height = 23
        Me.dgvDiagnostico.ThemeStyle.ReadOnly = True
        Me.dgvDiagnostico.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDiagnostico.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDiagnostico.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDiagnostico.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvDiagnostico.ThemeStyle.RowsStyle.Height = 24
        Me.dgvDiagnostico.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.dgvDiagnostico.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'cbSintoma9
        '
        Me.cbSintoma9.Animated = True
        Me.cbSintoma9.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma9.Enabled = False
        Me.cbSintoma9.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma9.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma9.FocusedState.Parent = Me.cbSintoma9
        Me.cbSintoma9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma9.ForeColor = System.Drawing.Color.White
        Me.cbSintoma9.FormattingEnabled = True
        Me.cbSintoma9.HoverState.Parent = Me.cbSintoma9
        Me.cbSintoma9.ItemHeight = 30
        Me.cbSintoma9.ItemsAppearance.Parent = Me.cbSintoma9
        Me.cbSintoma9.Location = New System.Drawing.Point(536, 220)
        Me.cbSintoma9.Name = "cbSintoma9"
        Me.cbSintoma9.ShadowDecoration.Parent = Me.cbSintoma9
        Me.cbSintoma9.Size = New System.Drawing.Size(213, 36)
        Me.cbSintoma9.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma9.TabIndex = 56
        '
        'cbSintoma6
        '
        Me.cbSintoma6.Animated = True
        Me.cbSintoma6.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma6.Enabled = False
        Me.cbSintoma6.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma6.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma6.FocusedState.Parent = Me.cbSintoma6
        Me.cbSintoma6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma6.ForeColor = System.Drawing.Color.White
        Me.cbSintoma6.FormattingEnabled = True
        Me.cbSintoma6.HoverState.Parent = Me.cbSintoma6
        Me.cbSintoma6.ItemHeight = 30
        Me.cbSintoma6.ItemsAppearance.Parent = Me.cbSintoma6
        Me.cbSintoma6.Location = New System.Drawing.Point(536, 155)
        Me.cbSintoma6.Name = "cbSintoma6"
        Me.cbSintoma6.ShadowDecoration.Parent = Me.cbSintoma6
        Me.cbSintoma6.Size = New System.Drawing.Size(213, 36)
        Me.cbSintoma6.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma6.TabIndex = 55
        '
        'cbSintoma8
        '
        Me.cbSintoma8.Animated = True
        Me.cbSintoma8.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma8.Enabled = False
        Me.cbSintoma8.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma8.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma8.FocusedState.Parent = Me.cbSintoma8
        Me.cbSintoma8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma8.ForeColor = System.Drawing.Color.White
        Me.cbSintoma8.FormattingEnabled = True
        Me.cbSintoma8.HoverState.Parent = Me.cbSintoma8
        Me.cbSintoma8.ItemHeight = 30
        Me.cbSintoma8.ItemsAppearance.Parent = Me.cbSintoma8
        Me.cbSintoma8.Location = New System.Drawing.Point(296, 220)
        Me.cbSintoma8.Name = "cbSintoma8"
        Me.cbSintoma8.ShadowDecoration.Parent = Me.cbSintoma8
        Me.cbSintoma8.Size = New System.Drawing.Size(213, 36)
        Me.cbSintoma8.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma8.TabIndex = 54
        '
        'cbSintoma5
        '
        Me.cbSintoma5.Animated = True
        Me.cbSintoma5.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma5.Enabled = False
        Me.cbSintoma5.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma5.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma5.FocusedState.Parent = Me.cbSintoma5
        Me.cbSintoma5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma5.ForeColor = System.Drawing.Color.White
        Me.cbSintoma5.FormattingEnabled = True
        Me.cbSintoma5.HoverState.Parent = Me.cbSintoma5
        Me.cbSintoma5.ItemHeight = 30
        Me.cbSintoma5.ItemsAppearance.Parent = Me.cbSintoma5
        Me.cbSintoma5.Location = New System.Drawing.Point(296, 155)
        Me.cbSintoma5.Name = "cbSintoma5"
        Me.cbSintoma5.ShadowDecoration.Parent = Me.cbSintoma5
        Me.cbSintoma5.Size = New System.Drawing.Size(213, 36)
        Me.cbSintoma5.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma5.TabIndex = 53
        '
        'cbSintoma7
        '
        Me.cbSintoma7.Animated = True
        Me.cbSintoma7.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma7.Enabled = False
        Me.cbSintoma7.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma7.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma7.FocusedState.Parent = Me.cbSintoma7
        Me.cbSintoma7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma7.ForeColor = System.Drawing.Color.White
        Me.cbSintoma7.FormattingEnabled = True
        Me.cbSintoma7.HoverState.Parent = Me.cbSintoma7
        Me.cbSintoma7.ItemHeight = 30
        Me.cbSintoma7.ItemsAppearance.Parent = Me.cbSintoma7
        Me.cbSintoma7.Location = New System.Drawing.Point(37, 220)
        Me.cbSintoma7.Name = "cbSintoma7"
        Me.cbSintoma7.ShadowDecoration.Parent = Me.cbSintoma7
        Me.cbSintoma7.Size = New System.Drawing.Size(213, 36)
        Me.cbSintoma7.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma7.TabIndex = 52
        '
        'cbSintoma3
        '
        Me.cbSintoma3.Animated = True
        Me.cbSintoma3.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma3.Enabled = False
        Me.cbSintoma3.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma3.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma3.FocusedState.Parent = Me.cbSintoma3
        Me.cbSintoma3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma3.ForeColor = System.Drawing.Color.White
        Me.cbSintoma3.FormattingEnabled = True
        Me.cbSintoma3.HoverState.Parent = Me.cbSintoma3
        Me.cbSintoma3.ItemHeight = 30
        Me.cbSintoma3.ItemsAppearance.Parent = Me.cbSintoma3
        Me.cbSintoma3.Location = New System.Drawing.Point(536, 96)
        Me.cbSintoma3.Name = "cbSintoma3"
        Me.cbSintoma3.ShadowDecoration.Parent = Me.cbSintoma3
        Me.cbSintoma3.Size = New System.Drawing.Size(213, 36)
        Me.cbSintoma3.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma3.TabIndex = 51
        '
        'cbSintoma4
        '
        Me.cbSintoma4.Animated = True
        Me.cbSintoma4.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma4.Enabled = False
        Me.cbSintoma4.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma4.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma4.FocusedState.Parent = Me.cbSintoma4
        Me.cbSintoma4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma4.ForeColor = System.Drawing.Color.White
        Me.cbSintoma4.FormattingEnabled = True
        Me.cbSintoma4.HoverState.Parent = Me.cbSintoma4
        Me.cbSintoma4.ItemHeight = 30
        Me.cbSintoma4.ItemsAppearance.Parent = Me.cbSintoma4
        Me.cbSintoma4.Location = New System.Drawing.Point(37, 155)
        Me.cbSintoma4.Name = "cbSintoma4"
        Me.cbSintoma4.ShadowDecoration.Parent = Me.cbSintoma4
        Me.cbSintoma4.Size = New System.Drawing.Size(213, 36)
        Me.cbSintoma4.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma4.TabIndex = 57
        '
        'cbSintoma2
        '
        Me.cbSintoma2.Animated = True
        Me.cbSintoma2.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma2.Enabled = False
        Me.cbSintoma2.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma2.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma2.FocusedState.Parent = Me.cbSintoma2
        Me.cbSintoma2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma2.ForeColor = System.Drawing.Color.White
        Me.cbSintoma2.FormattingEnabled = True
        Me.cbSintoma2.HoverState.Parent = Me.cbSintoma2
        Me.cbSintoma2.ItemHeight = 30
        Me.cbSintoma2.ItemsAppearance.Parent = Me.cbSintoma2
        Me.cbSintoma2.Location = New System.Drawing.Point(296, 96)
        Me.cbSintoma2.Name = "cbSintoma2"
        Me.cbSintoma2.ShadowDecoration.Parent = Me.cbSintoma2
        Me.cbSintoma2.Size = New System.Drawing.Size(213, 36)
        Me.cbSintoma2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma2.TabIndex = 50
        '
        'cbSintoma1
        '
        Me.cbSintoma1.Animated = True
        Me.cbSintoma1.BackColor = System.Drawing.Color.Transparent
        Me.cbSintoma1.BorderThickness = 0
        Me.cbSintoma1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSintoma1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma1.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma1.FocusedColor = System.Drawing.Color.Empty
        Me.cbSintoma1.FocusedState.Parent = Me.cbSintoma1
        Me.cbSintoma1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSintoma1.ForeColor = System.Drawing.Color.White
        Me.cbSintoma1.FormattingEnabled = True
        Me.cbSintoma1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.cbSintoma1.HoverState.Parent = Me.cbSintoma1
        Me.cbSintoma1.ItemHeight = 30
        Me.cbSintoma1.ItemsAppearance.Parent = Me.cbSintoma1
        Me.cbSintoma1.Location = New System.Drawing.Point(37, 96)
        Me.cbSintoma1.Name = "cbSintoma1"
        Me.cbSintoma1.ShadowDecoration.Parent = Me.cbSintoma1
        Me.cbSintoma1.Size = New System.Drawing.Size(213, 36)
        Me.cbSintoma1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSintoma1.TabIndex = 49
        Me.cbSintoma1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chb8
        '
        Me.chb8.AutoSize = True
        Me.chb8.Location = New System.Drawing.Point(515, 227)
        Me.chb8.Name = "chb8"
        Me.chb8.Size = New System.Drawing.Size(15, 14)
        Me.chb8.TabIndex = 47
        Me.chb8.UseVisualStyleBackColor = True
        '
        'chb7
        '
        Me.chb7.AutoSize = True
        Me.chb7.Location = New System.Drawing.Point(275, 227)
        Me.chb7.Name = "chb7"
        Me.chb7.Size = New System.Drawing.Size(15, 14)
        Me.chb7.TabIndex = 46
        Me.chb7.UseVisualStyleBackColor = True
        '
        'chb6
        '
        Me.chb6.AutoSize = True
        Me.chb6.Location = New System.Drawing.Point(16, 227)
        Me.chb6.Name = "chb6"
        Me.chb6.Size = New System.Drawing.Size(15, 14)
        Me.chb6.TabIndex = 45
        Me.chb6.UseVisualStyleBackColor = True
        '
        'chb5
        '
        Me.chb5.AutoSize = True
        Me.chb5.Location = New System.Drawing.Point(515, 162)
        Me.chb5.Name = "chb5"
        Me.chb5.Size = New System.Drawing.Size(15, 14)
        Me.chb5.TabIndex = 44
        Me.chb5.UseVisualStyleBackColor = True
        '
        'chb4
        '
        Me.chb4.AutoSize = True
        Me.chb4.Location = New System.Drawing.Point(275, 162)
        Me.chb4.Name = "chb4"
        Me.chb4.Size = New System.Drawing.Size(15, 14)
        Me.chb4.TabIndex = 43
        Me.chb4.UseVisualStyleBackColor = True
        '
        'chb3
        '
        Me.chb3.AutoSize = True
        Me.chb3.Location = New System.Drawing.Point(16, 162)
        Me.chb3.Name = "chb3"
        Me.chb3.Size = New System.Drawing.Size(15, 14)
        Me.chb3.TabIndex = 42
        Me.chb3.UseVisualStyleBackColor = True
        '
        'chb2
        '
        Me.chb2.AutoSize = True
        Me.chb2.Location = New System.Drawing.Point(515, 109)
        Me.chb2.Name = "chb2"
        Me.chb2.Size = New System.Drawing.Size(15, 14)
        Me.chb2.TabIndex = 41
        Me.chb2.UseVisualStyleBackColor = True
        '
        'chb1
        '
        Me.chb1.AutoSize = True
        Me.chb1.Location = New System.Drawing.Point(275, 109)
        Me.chb1.Name = "chb1"
        Me.chb1.Size = New System.Drawing.Size(15, 14)
        Me.chb1.TabIndex = 48
        Me.chb1.UseVisualStyleBackColor = True
        '
        'consu_titulo
        '
        Me.consu_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consu_titulo.ForeColor = System.Drawing.Color.Silver
        Me.consu_titulo.Location = New System.Drawing.Point(0, 24)
        Me.consu_titulo.Name = "consu_titulo"
        Me.consu_titulo.Size = New System.Drawing.Size(778, 40)
        Me.consu_titulo.TabIndex = 40
        Me.consu_titulo.Text = "SELECCIONE SUS SINTOMAS"
        Me.consu_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmConsultaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 699)
        Me.Controls.Add(Me.btn_chat)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.dgvDiagnostico)
        Me.Controls.Add(Me.cbSintoma9)
        Me.Controls.Add(Me.cbSintoma6)
        Me.Controls.Add(Me.cbSintoma8)
        Me.Controls.Add(Me.cbSintoma5)
        Me.Controls.Add(Me.cbSintoma7)
        Me.Controls.Add(Me.cbSintoma3)
        Me.Controls.Add(Me.cbSintoma4)
        Me.Controls.Add(Me.cbSintoma2)
        Me.Controls.Add(Me.cbSintoma1)
        Me.Controls.Add(Me.chb8)
        Me.Controls.Add(Me.chb7)
        Me.Controls.Add(Me.chb6)
        Me.Controls.Add(Me.chb5)
        Me.Controls.Add(Me.chb4)
        Me.Controls.Add(Me.chb3)
        Me.Controls.Add(Me.chb2)
        Me.Controls.Add(Me.chb1)
        Me.Controls.Add(Me.consu_titulo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmConsultaPaciente"
        Me.Text = "Consulta"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDiagnostico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btn_chat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_consultar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvDiagnostico As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cbSintoma9 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma6 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma8 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma5 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma7 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma4 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSintoma1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents chb8 As CheckBox
    Friend WithEvents chb7 As CheckBox
    Friend WithEvents chb6 As CheckBox
    Friend WithEvents chb5 As CheckBox
    Friend WithEvents chb4 As CheckBox
    Friend WithEvents chb3 As CheckBox
    Friend WithEvents chb2 As CheckBox
    Friend WithEvents chb1 As CheckBox
    Friend WithEvents consu_titulo As Label
End Class
