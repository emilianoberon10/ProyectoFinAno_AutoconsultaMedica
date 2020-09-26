<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIngresarGerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresarGerente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIngresarSintoma = New System.Windows.Forms.Button()
        Me.btnIngresarEnfermedad = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreEnfermedad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreSintoma = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbRiesgo = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lbNomEnf = New System.Windows.Forms.Label()
        Me.lbNomSint = New System.Windows.Forms.Label()
        Me.ErrorProviderNomSint = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderNomDesEnf = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderSintEnf = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chb8 = New System.Windows.Forms.CheckBox()
        Me.chb7 = New System.Windows.Forms.CheckBox()
        Me.chb6 = New System.Windows.Forms.CheckBox()
        Me.chb5 = New System.Windows.Forms.CheckBox()
        Me.chb4 = New System.Windows.Forms.CheckBox()
        Me.chb3 = New System.Windows.Forms.CheckBox()
        Me.chb2 = New System.Windows.Forms.CheckBox()
        Me.chb1 = New System.Windows.Forms.CheckBox()
        Me.cbSintoma5 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma8 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma4 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma7 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma2 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma6 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma9 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma3 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma1 = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorProviderNomSint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderNomDesEnf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderSintEnf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(79, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar sintomas/enfermadad"
        '
        'btnIngresarSintoma
        '
        Me.btnIngresarSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnIngresarSintoma.FlatAppearance.BorderSize = 0
        Me.btnIngresarSintoma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnIngresarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarSintoma.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarSintoma.ForeColor = System.Drawing.Color.Silver
        Me.btnIngresarSintoma.Location = New System.Drawing.Point(443, 124)
        Me.btnIngresarSintoma.Name = "btnIngresarSintoma"
        Me.btnIngresarSintoma.Size = New System.Drawing.Size(190, 40)
        Me.btnIngresarSintoma.TabIndex = 2
        Me.btnIngresarSintoma.Text = "Ingresar"
        Me.btnIngresarSintoma.UseVisualStyleBackColor = False
        '
        'btnIngresarEnfermedad
        '
        Me.btnIngresarEnfermedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnIngresarEnfermedad.FlatAppearance.BorderSize = 0
        Me.btnIngresarEnfermedad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnIngresarEnfermedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarEnfermedad.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarEnfermedad.ForeColor = System.Drawing.Color.Silver
        Me.btnIngresarEnfermedad.Location = New System.Drawing.Point(433, 503)
        Me.btnIngresarEnfermedad.Name = "btnIngresarEnfermedad"
        Me.btnIngresarEnfermedad.Size = New System.Drawing.Size(200, 40)
        Me.btnIngresarEnfermedad.TabIndex = 12
        Me.btnIngresarEnfermedad.Text = "Ingresar"
        Me.btnIngresarEnfermedad.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(253, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enfermedad"
        '
        'txtNombreEnfermedad
        '
        Me.txtNombreEnfermedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNombreEnfermedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEnfermedad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEnfermedad.ForeColor = System.Drawing.Color.Silver
        Me.txtNombreEnfermedad.Location = New System.Drawing.Point(14, 264)
        Me.txtNombreEnfermedad.MaxLength = 30
        Me.txtNombreEnfermedad.Name = "txtNombreEnfermedad"
        Me.txtNombreEnfermedad.Size = New System.Drawing.Size(241, 27)
        Me.txtNombreEnfermedad.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(276, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sintoma"
        '
        'txtNombreSintoma
        '
        Me.txtNombreSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNombreSintoma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreSintoma.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreSintoma.ForeColor = System.Drawing.Color.Silver
        Me.txtNombreSintoma.Location = New System.Drawing.Point(14, 133)
        Me.txtNombreSintoma.MaxLength = 30
        Me.txtNombreSintoma.Name = "txtNombreSintoma"
        Me.txtNombreSintoma.Size = New System.Drawing.Size(241, 27)
        Me.txtNombreSintoma.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(21, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Sintomas relacionados"
        '
        'cbRiesgo
        '
        Me.cbRiesgo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbRiesgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRiesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRiesgo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRiesgo.ForeColor = System.Drawing.Color.Silver
        Me.cbRiesgo.FormattingEnabled = True
        Me.cbRiesgo.Items.AddRange(New Object() {"azul", "verde", "amarillo", "naranja", "Rojo"})
        Me.cbRiesgo.Location = New System.Drawing.Point(18, 317)
        Me.cbRiesgo.Name = "cbRiesgo"
        Me.cbRiesgo.Size = New System.Drawing.Size(181, 29)
        Me.cbRiesgo.TabIndex = 4
        Me.cbRiesgo.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Silver
        Me.txtDescripcion.Location = New System.Drawing.Point(261, 264)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(372, 82)
        Me.txtDescripcion.TabIndex = 3
        '
        'lbNomEnf
        '
        Me.lbNomEnf.AutoSize = True
        Me.lbNomEnf.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomEnf.ForeColor = System.Drawing.Color.Silver
        Me.ErrorProviderNomSint.SetIconAlignment(Me.lbNomEnf, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.ErrorProviderNomDesEnf.SetIconAlignment(Me.lbNomEnf, System.Windows.Forms.ErrorIconAlignment.TopRight)
        Me.ErrorProviderSintEnf.SetIconAlignment(Me.lbNomEnf, System.Windows.Forms.ErrorIconAlignment.TopRight)
        Me.lbNomEnf.Location = New System.Drawing.Point(14, 243)
        Me.lbNomEnf.Name = "lbNomEnf"
        Me.lbNomEnf.Size = New System.Drawing.Size(74, 20)
        Me.lbNomEnf.TabIndex = 3
        Me.lbNomEnf.Text = "NOMBRE"
        '
        'lbNomSint
        '
        Me.lbNomSint.AutoSize = True
        Me.lbNomSint.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomSint.ForeColor = System.Drawing.Color.Silver
        Me.lbNomSint.Location = New System.Drawing.Point(14, 112)
        Me.lbNomSint.Name = "lbNomSint"
        Me.lbNomSint.Size = New System.Drawing.Size(74, 20)
        Me.lbNomSint.TabIndex = 3
        Me.lbNomSint.Text = "NOMBRE"
        '
        'ErrorProviderNomSint
        '
        Me.ErrorProviderNomSint.ContainerControl = Me
        Me.ErrorProviderNomSint.Icon = CType(resources.GetObject("ErrorProviderNomSint.Icon"), System.Drawing.Icon)
        '
        'ErrorProviderNomDesEnf
        '
        Me.ErrorProviderNomDesEnf.ContainerControl = Me
        '
        'ErrorProviderSintEnf
        '
        Me.ErrorProviderSintEnf.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(14, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RIESGO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(257, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "DESCRIPCION"
        '
        'chb8
        '
        Me.chb8.AutoSize = True
        Me.chb8.Location = New System.Drawing.Point(458, 477)
        Me.chb8.Name = "chb8"
        Me.chb8.Size = New System.Drawing.Size(15, 14)
        Me.chb8.TabIndex = 44
        Me.chb8.UseVisualStyleBackColor = True
        '
        'chb7
        '
        Me.chb7.AutoSize = True
        Me.chb7.Location = New System.Drawing.Point(230, 476)
        Me.chb7.Name = "chb7"
        Me.chb7.Size = New System.Drawing.Size(15, 14)
        Me.chb7.TabIndex = 45
        Me.chb7.UseVisualStyleBackColor = True
        '
        'chb6
        '
        Me.chb6.AutoSize = True
        Me.chb6.Location = New System.Drawing.Point(4, 476)
        Me.chb6.Name = "chb6"
        Me.chb6.Size = New System.Drawing.Size(15, 14)
        Me.chb6.TabIndex = 46
        Me.chb6.UseVisualStyleBackColor = True
        '
        'chb5
        '
        Me.chb5.AutoSize = True
        Me.chb5.Location = New System.Drawing.Point(458, 437)
        Me.chb5.Name = "chb5"
        Me.chb5.Size = New System.Drawing.Size(15, 14)
        Me.chb5.TabIndex = 47
        Me.chb5.UseVisualStyleBackColor = True
        '
        'chb4
        '
        Me.chb4.AutoSize = True
        Me.chb4.Location = New System.Drawing.Point(230, 431)
        Me.chb4.Name = "chb4"
        Me.chb4.Size = New System.Drawing.Size(15, 14)
        Me.chb4.TabIndex = 48
        Me.chb4.UseVisualStyleBackColor = True
        '
        'chb3
        '
        Me.chb3.AutoSize = True
        Me.chb3.Location = New System.Drawing.Point(4, 425)
        Me.chb3.Name = "chb3"
        Me.chb3.Size = New System.Drawing.Size(15, 14)
        Me.chb3.TabIndex = 49
        Me.chb3.UseVisualStyleBackColor = True
        '
        'chb2
        '
        Me.chb2.AutoSize = True
        Me.chb2.Location = New System.Drawing.Point(458, 387)
        Me.chb2.Name = "chb2"
        Me.chb2.Size = New System.Drawing.Size(15, 14)
        Me.chb2.TabIndex = 50
        Me.chb2.UseVisualStyleBackColor = True
        '
        'chb1
        '
        Me.chb1.AutoSize = True
        Me.chb1.Location = New System.Drawing.Point(230, 386)
        Me.chb1.Name = "chb1"
        Me.chb1.Size = New System.Drawing.Size(15, 14)
        Me.chb1.TabIndex = 51
        Me.chb1.UseVisualStyleBackColor = True
        '
        'cbSintoma5
        '
        Me.cbSintoma5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma5.Enabled = False
        Me.cbSintoma5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma5.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma5.FormattingEnabled = True
        Me.cbSintoma5.Location = New System.Drawing.Point(251, 422)
        Me.cbSintoma5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma5.Name = "cbSintoma5"
        Me.cbSintoma5.Size = New System.Drawing.Size(153, 29)
        Me.cbSintoma5.TabIndex = 42
        '
        'cbSintoma8
        '
        Me.cbSintoma8.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma8.Enabled = False
        Me.cbSintoma8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma8.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma8.FormattingEnabled = True
        Me.cbSintoma8.Location = New System.Drawing.Point(251, 467)
        Me.cbSintoma8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma8.Name = "cbSintoma8"
        Me.cbSintoma8.Size = New System.Drawing.Size(153, 29)
        Me.cbSintoma8.TabIndex = 43
        '
        'cbSintoma4
        '
        Me.cbSintoma4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma4.Enabled = False
        Me.cbSintoma4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma4.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma4.FormattingEnabled = True
        Me.cbSintoma4.Location = New System.Drawing.Point(25, 416)
        Me.cbSintoma4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma4.Name = "cbSintoma4"
        Me.cbSintoma4.Size = New System.Drawing.Size(153, 29)
        Me.cbSintoma4.TabIndex = 40
        '
        'cbSintoma7
        '
        Me.cbSintoma7.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma7.Enabled = False
        Me.cbSintoma7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma7.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma7.FormattingEnabled = True
        Me.cbSintoma7.Location = New System.Drawing.Point(25, 468)
        Me.cbSintoma7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma7.Name = "cbSintoma7"
        Me.cbSintoma7.Size = New System.Drawing.Size(153, 29)
        Me.cbSintoma7.TabIndex = 41
        '
        'cbSintoma2
        '
        Me.cbSintoma2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma2.Enabled = False
        Me.cbSintoma2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma2.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma2.FormattingEnabled = True
        Me.cbSintoma2.Location = New System.Drawing.Point(251, 377)
        Me.cbSintoma2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma2.Name = "cbSintoma2"
        Me.cbSintoma2.Size = New System.Drawing.Size(153, 29)
        Me.cbSintoma2.TabIndex = 39
        '
        'cbSintoma6
        '
        Me.cbSintoma6.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma6.Enabled = False
        Me.cbSintoma6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma6.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma6.FormattingEnabled = True
        Me.cbSintoma6.Location = New System.Drawing.Point(479, 422)
        Me.cbSintoma6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma6.Name = "cbSintoma6"
        Me.cbSintoma6.Size = New System.Drawing.Size(153, 29)
        Me.cbSintoma6.TabIndex = 37
        '
        'cbSintoma9
        '
        Me.cbSintoma9.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma9.Enabled = False
        Me.cbSintoma9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma9.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma9.FormattingEnabled = True
        Me.cbSintoma9.Location = New System.Drawing.Point(479, 467)
        Me.cbSintoma9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma9.Name = "cbSintoma9"
        Me.cbSintoma9.Size = New System.Drawing.Size(153, 29)
        Me.cbSintoma9.TabIndex = 38
        '
        'cbSintoma3
        '
        Me.cbSintoma3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma3.Enabled = False
        Me.cbSintoma3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma3.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma3.FormattingEnabled = True
        Me.cbSintoma3.Location = New System.Drawing.Point(479, 377)
        Me.cbSintoma3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma3.Name = "cbSintoma3"
        Me.cbSintoma3.Size = New System.Drawing.Size(153, 29)
        Me.cbSintoma3.TabIndex = 36
        '
        'cbSintoma1
        '
        Me.cbSintoma1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSintoma1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma1.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma1.FormattingEnabled = True
        Me.cbSintoma1.Location = New System.Drawing.Point(25, 375)
        Me.cbSintoma1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma1.Name = "cbSintoma1"
        Me.cbSintoma1.Size = New System.Drawing.Size(153, 29)
        Me.cbSintoma1.TabIndex = 52
        '
        'FrmIngresarGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(683, 565)
        Me.Controls.Add(Me.cbSintoma1)
        Me.Controls.Add(Me.chb8)
        Me.Controls.Add(Me.chb7)
        Me.Controls.Add(Me.chb6)
        Me.Controls.Add(Me.chb5)
        Me.Controls.Add(Me.chb4)
        Me.Controls.Add(Me.chb3)
        Me.Controls.Add(Me.chb2)
        Me.Controls.Add(Me.chb1)
        Me.Controls.Add(Me.cbSintoma5)
        Me.Controls.Add(Me.cbSintoma8)
        Me.Controls.Add(Me.cbSintoma4)
        Me.Controls.Add(Me.cbSintoma7)
        Me.Controls.Add(Me.cbSintoma2)
        Me.Controls.Add(Me.cbSintoma6)
        Me.Controls.Add(Me.cbSintoma9)
        Me.Controls.Add(Me.cbSintoma3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbNomSint)
        Me.Controls.Add(Me.lbNomEnf)
        Me.Controls.Add(Me.txtNombreSintoma)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombreEnfermedad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIngresarEnfermedad)
        Me.Controls.Add(Me.btnIngresarSintoma)
        Me.Controls.Add(Me.cbRiesgo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmIngresarGerente"
        Me.Text = "FrmIngresar"
        CType(Me.ErrorProviderNomSint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderNomDesEnf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderSintEnf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnIngresarSintoma As Button
    Friend WithEvents btnIngresarEnfermedad As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreEnfermedad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombreSintoma As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbRiesgo As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lbNomEnf As Label
    Friend WithEvents lbNomSint As Label
    Friend WithEvents ErrorProviderNomSint As ErrorProvider
    Friend WithEvents ErrorProviderNomDesEnf As ErrorProvider
    Friend WithEvents ErrorProviderSintEnf As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chb8 As CheckBox
    Friend WithEvents chb7 As CheckBox
    Friend WithEvents chb6 As CheckBox
    Friend WithEvents chb5 As CheckBox
    Friend WithEvents chb4 As CheckBox
    Friend WithEvents chb3 As CheckBox
    Friend WithEvents chb2 As CheckBox
    Friend WithEvents chb1 As CheckBox
    Friend WithEvents cbSintoma5 As ComboBox
    Friend WithEvents cbSintoma8 As ComboBox
    Friend WithEvents cbSintoma4 As ComboBox
    Friend WithEvents cbSintoma7 As ComboBox
    Friend WithEvents cbSintoma2 As ComboBox
    Friend WithEvents cbSintoma6 As ComboBox
    Friend WithEvents cbSintoma9 As ComboBox
    Friend WithEvents cbSintoma3 As ComboBox
    Friend WithEvents cbSintoma1 As ComboBox
End Class
