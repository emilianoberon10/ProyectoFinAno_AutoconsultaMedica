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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaPaciente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnChildCons = New System.Windows.Forms.Panel()
        Me.dgvDiagnostico = New System.Windows.Forms.DataGridView()
        Me.chb8 = New System.Windows.Forms.CheckBox()
        Me.chb7 = New System.Windows.Forms.CheckBox()
        Me.chb6 = New System.Windows.Forms.CheckBox()
        Me.chb5 = New System.Windows.Forms.CheckBox()
        Me.chb4 = New System.Windows.Forms.CheckBox()
        Me.chb3 = New System.Windows.Forms.CheckBox()
        Me.chb2 = New System.Windows.Forms.CheckBox()
        Me.chb1 = New System.Windows.Forms.CheckBox()
        Me.btnConsul = New System.Windows.Forms.Button()
        Me.cbSintoma5 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma8 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma4 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma7 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma2 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.cbSintoma6 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma9 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma3 = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnChildCons.SuspendLayout()
        CType(Me.dgvDiagnostico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pnChildCons
        '
        Me.pnChildCons.Controls.Add(Me.dgvDiagnostico)
        Me.pnChildCons.Controls.Add(Me.chb8)
        Me.pnChildCons.Controls.Add(Me.chb7)
        Me.pnChildCons.Controls.Add(Me.chb6)
        Me.pnChildCons.Controls.Add(Me.chb5)
        Me.pnChildCons.Controls.Add(Me.chb4)
        Me.pnChildCons.Controls.Add(Me.chb3)
        Me.pnChildCons.Controls.Add(Me.chb2)
        Me.pnChildCons.Controls.Add(Me.chb1)
        Me.pnChildCons.Controls.Add(Me.btnConsul)
        Me.pnChildCons.Controls.Add(Me.cbSintoma5)
        Me.pnChildCons.Controls.Add(Me.cbSintoma8)
        Me.pnChildCons.Controls.Add(Me.cbSintoma4)
        Me.pnChildCons.Controls.Add(Me.cbSintoma7)
        Me.pnChildCons.Controls.Add(Me.cbSintoma2)
        Me.pnChildCons.Controls.Add(Me.cbSintoma1)
        Me.pnChildCons.Controls.Add(Me.Label2)
        Me.pnChildCons.Controls.Add(Me.btnChat)
        Me.pnChildCons.Controls.Add(Me.cbSintoma6)
        Me.pnChildCons.Controls.Add(Me.cbSintoma9)
        Me.pnChildCons.Controls.Add(Me.cbSintoma3)
        Me.pnChildCons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnChildCons.Location = New System.Drawing.Point(0, 0)
        Me.pnChildCons.Name = "pnChildCons"
        Me.pnChildCons.Size = New System.Drawing.Size(778, 699)
        Me.pnChildCons.TabIndex = 12
        '
        'dgvDiagnostico
        '
        Me.dgvDiagnostico.AllowUserToAddRows = False
        Me.dgvDiagnostico.AllowUserToDeleteRows = False
        Me.dgvDiagnostico.AllowUserToOrderColumns = True
        Me.dgvDiagnostico.AllowUserToResizeColumns = False
        Me.dgvDiagnostico.AllowUserToResizeRows = False
        Me.dgvDiagnostico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDiagnostico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDiagnostico.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.dgvDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDiagnostico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDiagnostico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDiagnostico.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDiagnostico.ColumnHeadersHeight = 30
        Me.dgvDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDiagnostico.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDiagnostico.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDiagnostico.EnableHeadersVisualStyles = False
        Me.dgvDiagnostico.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvDiagnostico.Location = New System.Drawing.Point(69, 406)
        Me.dgvDiagnostico.Name = "dgvDiagnostico"
        Me.dgvDiagnostico.ReadOnly = True
        Me.dgvDiagnostico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDiagnostico.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDiagnostico.RowHeadersVisible = False
        Me.dgvDiagnostico.Size = New System.Drawing.Size(640, 181)
        Me.dgvDiagnostico.TabIndex = 36
        Me.dgvDiagnostico.TabStop = False
        '
        'chb8
        '
        Me.chb8.AutoSize = True
        Me.chb8.Location = New System.Drawing.Point(514, 212)
        Me.chb8.Name = "chb8"
        Me.chb8.Size = New System.Drawing.Size(15, 14)
        Me.chb8.TabIndex = 35
        Me.chb8.UseVisualStyleBackColor = True
        '
        'chb7
        '
        Me.chb7.AutoSize = True
        Me.chb7.Location = New System.Drawing.Point(265, 212)
        Me.chb7.Name = "chb7"
        Me.chb7.Size = New System.Drawing.Size(15, 14)
        Me.chb7.TabIndex = 35
        Me.chb7.UseVisualStyleBackColor = True
        '
        'chb6
        '
        Me.chb6.AutoSize = True
        Me.chb6.Location = New System.Drawing.Point(15, 212)
        Me.chb6.Name = "chb6"
        Me.chb6.Size = New System.Drawing.Size(15, 14)
        Me.chb6.TabIndex = 35
        Me.chb6.UseVisualStyleBackColor = True
        '
        'chb5
        '
        Me.chb5.AutoSize = True
        Me.chb5.Location = New System.Drawing.Point(515, 152)
        Me.chb5.Name = "chb5"
        Me.chb5.Size = New System.Drawing.Size(15, 14)
        Me.chb5.TabIndex = 35
        Me.chb5.UseVisualStyleBackColor = True
        '
        'chb4
        '
        Me.chb4.AutoSize = True
        Me.chb4.Location = New System.Drawing.Point(265, 152)
        Me.chb4.Name = "chb4"
        Me.chb4.Size = New System.Drawing.Size(15, 14)
        Me.chb4.TabIndex = 35
        Me.chb4.UseVisualStyleBackColor = True
        '
        'chb3
        '
        Me.chb3.AutoSize = True
        Me.chb3.Location = New System.Drawing.Point(15, 147)
        Me.chb3.Name = "chb3"
        Me.chb3.Size = New System.Drawing.Size(15, 14)
        Me.chb3.TabIndex = 35
        Me.chb3.UseVisualStyleBackColor = True
        '
        'chb2
        '
        Me.chb2.AutoSize = True
        Me.chb2.Location = New System.Drawing.Point(514, 87)
        Me.chb2.Name = "chb2"
        Me.chb2.Size = New System.Drawing.Size(15, 14)
        Me.chb2.TabIndex = 35
        Me.chb2.UseVisualStyleBackColor = True
        '
        'chb1
        '
        Me.chb1.AutoSize = True
        Me.chb1.Location = New System.Drawing.Point(265, 87)
        Me.chb1.Name = "chb1"
        Me.chb1.Size = New System.Drawing.Size(15, 14)
        Me.chb1.TabIndex = 35
        Me.chb1.UseVisualStyleBackColor = True
        '
        'btnConsul
        '
        Me.btnConsul.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnConsul.FlatAppearance.BorderSize = 0
        Me.btnConsul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsul.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsul.ForeColor = System.Drawing.Color.Silver
        Me.btnConsul.Location = New System.Drawing.Point(12, 327)
        Me.btnConsul.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsul.Name = "btnConsul"
        Me.btnConsul.Size = New System.Drawing.Size(233, 49)
        Me.btnConsul.TabIndex = 34
        Me.btnConsul.Text = "CONSULTAR"
        Me.btnConsul.UseVisualStyleBackColor = False
        '
        'cbSintoma5
        '
        Me.cbSintoma5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma5.Enabled = False
        Me.cbSintoma5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma5.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma5.FormattingEnabled = True
        Me.cbSintoma5.Location = New System.Drawing.Point(286, 142)
        Me.cbSintoma5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma5.Name = "cbSintoma5"
        Me.cbSintoma5.Size = New System.Drawing.Size(213, 24)
        Me.cbSintoma5.TabIndex = 33
        '
        'cbSintoma8
        '
        Me.cbSintoma8.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma8.Enabled = False
        Me.cbSintoma8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma8.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma8.FormattingEnabled = True
        Me.cbSintoma8.Location = New System.Drawing.Point(286, 207)
        Me.cbSintoma8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma8.Name = "cbSintoma8"
        Me.cbSintoma8.Size = New System.Drawing.Size(213, 24)
        Me.cbSintoma8.TabIndex = 33
        '
        'cbSintoma4
        '
        Me.cbSintoma4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma4.Enabled = False
        Me.cbSintoma4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma4.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma4.FormattingEnabled = True
        Me.cbSintoma4.Location = New System.Drawing.Point(36, 142)
        Me.cbSintoma4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma4.Name = "cbSintoma4"
        Me.cbSintoma4.Size = New System.Drawing.Size(213, 24)
        Me.cbSintoma4.TabIndex = 32
        '
        'cbSintoma7
        '
        Me.cbSintoma7.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma7.Enabled = False
        Me.cbSintoma7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma7.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma7.FormattingEnabled = True
        Me.cbSintoma7.Location = New System.Drawing.Point(36, 207)
        Me.cbSintoma7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma7.Name = "cbSintoma7"
        Me.cbSintoma7.Size = New System.Drawing.Size(213, 24)
        Me.cbSintoma7.TabIndex = 32
        '
        'cbSintoma2
        '
        Me.cbSintoma2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma2.Enabled = False
        Me.cbSintoma2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma2.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma2.FormattingEnabled = True
        Me.cbSintoma2.Location = New System.Drawing.Point(286, 82)
        Me.cbSintoma2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma2.Name = "cbSintoma2"
        Me.cbSintoma2.Size = New System.Drawing.Size(213, 24)
        Me.cbSintoma2.TabIndex = 31
        '
        'cbSintoma1
        '
        Me.cbSintoma1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma1.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma1.FormattingEnabled = True
        Me.cbSintoma1.Location = New System.Drawing.Point(36, 82)
        Me.cbSintoma1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma1.Name = "cbSintoma1"
        Me.cbSintoma1.Size = New System.Drawing.Size(213, 24)
        Me.cbSintoma1.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(176, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 36)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "SELECCIONE SUS SINTOMAS"
        '
        'btnChat
        '
        Me.btnChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnChat.FlatAppearance.BorderSize = 0
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChat.ForeColor = System.Drawing.Color.Silver
        Me.btnChat.Location = New System.Drawing.Point(535, 327)
        Me.btnChat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(233, 49)
        Me.btnChat.TabIndex = 23
        Me.btnChat.Text = "CHAT"
        Me.btnChat.UseVisualStyleBackColor = False
        '
        'cbSintoma6
        '
        Me.cbSintoma6.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma6.Enabled = False
        Me.cbSintoma6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma6.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma6.FormattingEnabled = True
        Me.cbSintoma6.Location = New System.Drawing.Point(535, 142)
        Me.cbSintoma6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma6.Name = "cbSintoma6"
        Me.cbSintoma6.Size = New System.Drawing.Size(213, 24)
        Me.cbSintoma6.TabIndex = 27
        '
        'cbSintoma9
        '
        Me.cbSintoma9.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma9.Enabled = False
        Me.cbSintoma9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma9.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma9.FormattingEnabled = True
        Me.cbSintoma9.Location = New System.Drawing.Point(535, 207)
        Me.cbSintoma9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma9.Name = "cbSintoma9"
        Me.cbSintoma9.Size = New System.Drawing.Size(213, 24)
        Me.cbSintoma9.TabIndex = 27
        '
        'cbSintoma3
        '
        Me.cbSintoma3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma3.Enabled = False
        Me.cbSintoma3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma3.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma3.FormattingEnabled = True
        Me.cbSintoma3.Location = New System.Drawing.Point(535, 82)
        Me.cbSintoma3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma3.Name = "cbSintoma3"
        Me.cbSintoma3.Size = New System.Drawing.Size(213, 24)
        Me.cbSintoma3.TabIndex = 22
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'FrmConsultaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 699)
        Me.Controls.Add(Me.pnChildCons)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmConsultaPaciente"
        Me.Text = "Consulta"
        Me.pnChildCons.ResumeLayout(False)
        Me.pnChildCons.PerformLayout()
        CType(Me.dgvDiagnostico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents pnChildCons As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnChat As Button
    Friend WithEvents cbSintoma9 As ComboBox
    Friend WithEvents cbSintoma3 As ComboBox
    Friend WithEvents btnConsul As Button
    Friend WithEvents cbSintoma8 As ComboBox
    Friend WithEvents cbSintoma7 As ComboBox
    Friend WithEvents cbSintoma2 As ComboBox
    Friend WithEvents cbSintoma1 As ComboBox
    Friend WithEvents cbSintoma5 As ComboBox
    Friend WithEvents cbSintoma4 As ComboBox
    Friend WithEvents cbSintoma6 As ComboBox
    Friend WithEvents chb8 As CheckBox
    Friend WithEvents chb7 As CheckBox
    Friend WithEvents chb6 As CheckBox
    Friend WithEvents chb5 As CheckBox
    Friend WithEvents chb4 As CheckBox
    Friend WithEvents chb3 As CheckBox
    Friend WithEvents chb2 As CheckBox
    Friend WithEvents chb1 As CheckBox
    Friend WithEvents dgvDiagnostico As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
