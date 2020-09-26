<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMedicoGerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMedicoGerente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPriNombre = New System.Windows.Forms.Label()
        Me.txtPNom = New System.Windows.Forms.TextBox()
        Me.txtSegNombre = New System.Windows.Forms.Label()
        Me.txtSnom = New System.Windows.Forms.TextBox()
        Me.txtPriApellido = New System.Windows.Forms.Label()
        Me.txtPApe = New System.Windows.Forms.TextBox()
        Me.txtSegApellido = New System.Windows.Forms.Label()
        Me.txtSape = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLugarTrabajo = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtNumMed = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbEsp = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkDom = New System.Windows.Forms.CheckBox()
        Me.chkJuev = New System.Windows.Forms.CheckBox()
        Me.chkSab = New System.Windows.Forms.CheckBox()
        Me.chkMier = New System.Windows.Forms.CheckBox()
        Me.chkMar = New System.Windows.Forms.CheckBox()
        Me.chkVier = New System.Windows.Forms.CheckBox()
        Me.chkLun = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtHoraEntradaDomingo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtHoraEntradaSabado = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtHoraEntradaViernes = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaMiercoles = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaJueves = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtHoraEntradaMartes = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaLunes = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(27, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtCedula.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.ForeColor = System.Drawing.Color.Silver
        Me.txtCedula.Location = New System.Drawing.Point(27, 68)
        Me.txtCedula.MaxLength = 8
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(180, 27)
        Me.txtCedula.TabIndex = 1
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.Silver
        Me.btnIngresar.Location = New System.Drawing.Point(459, 492)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(180, 40)
        Me.btnIngresar.TabIndex = 2
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(27, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Especialidad"
        '
        'txtPriNombre
        '
        Me.txtPriNombre.AutoSize = True
        Me.txtPriNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriNombre.ForeColor = System.Drawing.Color.Silver
        Me.txtPriNombre.Location = New System.Drawing.Point(222, 44)
        Me.txtPriNombre.Name = "txtPriNombre"
        Me.txtPriNombre.Size = New System.Drawing.Size(124, 21)
        Me.txtPriNombre.TabIndex = 0
        Me.txtPriNombre.Text = "Primer Nombre"
        '
        'txtPNom
        '
        Me.txtPNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtPNom.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNom.ForeColor = System.Drawing.Color.Silver
        Me.txtPNom.Location = New System.Drawing.Point(222, 68)
        Me.txtPNom.MaxLength = 30
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.Size = New System.Drawing.Size(180, 27)
        Me.txtPNom.TabIndex = 1
        '
        'txtSegNombre
        '
        Me.txtSegNombre.AutoSize = True
        Me.txtSegNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegNombre.ForeColor = System.Drawing.Color.Silver
        Me.txtSegNombre.Location = New System.Drawing.Point(222, 106)
        Me.txtSegNombre.Name = "txtSegNombre"
        Me.txtSegNombre.Size = New System.Drawing.Size(147, 21)
        Me.txtSegNombre.TabIndex = 0
        Me.txtSegNombre.Text = "Segundo Nombre"
        '
        'txtSnom
        '
        Me.txtSnom.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtSnom.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSnom.ForeColor = System.Drawing.Color.Silver
        Me.txtSnom.Location = New System.Drawing.Point(222, 130)
        Me.txtSnom.MaxLength = 30
        Me.txtSnom.Name = "txtSnom"
        Me.txtSnom.Size = New System.Drawing.Size(180, 27)
        Me.txtSnom.TabIndex = 1
        '
        'txtPriApellido
        '
        Me.txtPriApellido.AutoSize = True
        Me.txtPriApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriApellido.ForeColor = System.Drawing.Color.Silver
        Me.txtPriApellido.Location = New System.Drawing.Point(434, 44)
        Me.txtPriApellido.Name = "txtPriApellido"
        Me.txtPriApellido.Size = New System.Drawing.Size(125, 21)
        Me.txtPriApellido.TabIndex = 0
        Me.txtPriApellido.Text = "Primer Apellido"
        '
        'txtPApe
        '
        Me.txtPApe.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtPApe.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPApe.ForeColor = System.Drawing.Color.Silver
        Me.txtPApe.Location = New System.Drawing.Point(434, 68)
        Me.txtPApe.MaxLength = 30
        Me.txtPApe.Name = "txtPApe"
        Me.txtPApe.Size = New System.Drawing.Size(180, 27)
        Me.txtPApe.TabIndex = 1
        '
        'txtSegApellido
        '
        Me.txtSegApellido.AutoSize = True
        Me.txtSegApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegApellido.ForeColor = System.Drawing.Color.Silver
        Me.txtSegApellido.Location = New System.Drawing.Point(434, 106)
        Me.txtSegApellido.Name = "txtSegApellido"
        Me.txtSegApellido.Size = New System.Drawing.Size(148, 21)
        Me.txtSegApellido.TabIndex = 0
        Me.txtSegApellido.Text = "Segundo Apellido"
        '
        'txtSape
        '
        Me.txtSape.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtSape.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSape.ForeColor = System.Drawing.Color.Silver
        Me.txtSape.Location = New System.Drawing.Point(434, 130)
        Me.txtSape.MaxLength = 30
        Me.txtSape.Name = "txtSape"
        Me.txtSape.Size = New System.Drawing.Size(180, 27)
        Me.txtSape.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(27, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Lugar de Trabajo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(193, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(241, 36)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Ingeras Medico"
        '
        'txtLugarTrabajo
        '
        Me.txtLugarTrabajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtLugarTrabajo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTrabajo.ForeColor = System.Drawing.Color.Silver
        Me.txtLugarTrabajo.Location = New System.Drawing.Point(27, 182)
        Me.txtLugarTrabajo.MaxLength = 30
        Me.txtLugarTrabajo.Name = "txtLugarTrabajo"
        Me.txtLugarTrabajo.Size = New System.Drawing.Size(180, 27)
        Me.txtLugarTrabajo.TabIndex = 1
        '
        'cbSexo
        '
        Me.cbSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSexo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.ForeColor = System.Drawing.Color.Silver
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Hombre", "Mujer", "Otro"})
        Me.cbSexo.Location = New System.Drawing.Point(222, 180)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(180, 29)
        Me.cbSexo.TabIndex = 5
        Me.cbSexo.TabStop = False
        Me.cbSexo.Text = "Sexo"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.Silver
        Me.txtTelefono.Location = New System.Drawing.Point(434, 182)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(180, 27)
        Me.txtTelefono.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(434, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Telefono"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDomicilio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.ForeColor = System.Drawing.Color.Silver
        Me.txtDomicilio.Location = New System.Drawing.Point(222, 236)
        Me.txtDomicilio.MaxLength = 255
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(392, 27)
        Me.txtDomicilio.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(222, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Domicilio"
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtEdad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.ForeColor = System.Drawing.Color.Silver
        Me.txtEdad.Location = New System.Drawing.Point(27, 236)
        Me.txtEdad.MaxLength = 2
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(180, 27)
        Me.txtEdad.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(27, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Edad"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'txtNumMed
        '
        Me.txtNumMed.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNumMed.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumMed.ForeColor = System.Drawing.Color.Silver
        Me.txtNumMed.Location = New System.Drawing.Point(27, 296)
        Me.txtNumMed.MaxLength = 4
        Me.txtNumMed.Name = "txtNumMed"
        Me.txtNumMed.Size = New System.Drawing.Size(180, 27)
        Me.txtNumMed.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(27, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Numero Medico"
        '
        'cbEsp
        '
        Me.cbEsp.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEsp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEsp.ForeColor = System.Drawing.Color.Silver
        Me.cbEsp.FormattingEnabled = True
        Me.cbEsp.Items.AddRange(New Object() {"Medicos", "Enfermedades", "Sintomas"})
        Me.cbEsp.Location = New System.Drawing.Point(27, 130)
        Me.cbEsp.Name = "cbEsp"
        Me.cbEsp.Size = New System.Drawing.Size(180, 29)
        Me.cbEsp.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkDom)
        Me.Panel1.Controls.Add(Me.chkJuev)
        Me.Panel1.Controls.Add(Me.chkSab)
        Me.Panel1.Controls.Add(Me.chkMier)
        Me.Panel1.Controls.Add(Me.chkMar)
        Me.Panel1.Controls.Add(Me.chkVier)
        Me.Panel1.Controls.Add(Me.chkLun)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaDomingo)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaSabado)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaViernes)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaMiercoles)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaJueves)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaMartes)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaLunes)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Location = New System.Drawing.Point(7, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 147)
        Me.Panel1.TabIndex = 48
        '
        'chkDom
        '
        Me.chkDom.AutoSize = True
        Me.chkDom.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkDom.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDom.ForeColor = System.Drawing.Color.Silver
        Me.chkDom.Location = New System.Drawing.Point(383, 102)
        Me.chkDom.Name = "chkDom"
        Me.chkDom.Size = New System.Drawing.Size(15, 14)
        Me.chkDom.TabIndex = 4
        Me.chkDom.UseVisualStyleBackColor = False
        '
        'chkJuev
        '
        Me.chkJuev.AutoSize = True
        Me.chkJuev.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkJuev.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJuev.ForeColor = System.Drawing.Color.Silver
        Me.chkJuev.Location = New System.Drawing.Point(427, 32)
        Me.chkJuev.Name = "chkJuev"
        Me.chkJuev.Size = New System.Drawing.Size(15, 14)
        Me.chkJuev.TabIndex = 4
        Me.chkJuev.UseVisualStyleBackColor = False
        '
        'chkSab
        '
        Me.chkSab.AutoSize = True
        Me.chkSab.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkSab.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSab.ForeColor = System.Drawing.Color.Silver
        Me.chkSab.Location = New System.Drawing.Point(264, 102)
        Me.chkSab.Name = "chkSab"
        Me.chkSab.Size = New System.Drawing.Size(15, 14)
        Me.chkSab.TabIndex = 4
        Me.chkSab.UseVisualStyleBackColor = False
        '
        'chkMier
        '
        Me.chkMier.AutoSize = True
        Me.chkMier.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkMier.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMier.ForeColor = System.Drawing.Color.Silver
        Me.chkMier.Location = New System.Drawing.Point(318, 32)
        Me.chkMier.Name = "chkMier"
        Me.chkMier.Size = New System.Drawing.Size(15, 14)
        Me.chkMier.TabIndex = 4
        Me.chkMier.UseVisualStyleBackColor = False
        '
        'chkMar
        '
        Me.chkMar.AutoSize = True
        Me.chkMar.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkMar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMar.ForeColor = System.Drawing.Color.Silver
        Me.chkMar.Location = New System.Drawing.Point(209, 32)
        Me.chkMar.Name = "chkMar"
        Me.chkMar.Size = New System.Drawing.Size(15, 14)
        Me.chkMar.TabIndex = 4
        Me.chkMar.UseVisualStyleBackColor = False
        '
        'chkVier
        '
        Me.chkVier.AutoSize = True
        Me.chkVier.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkVier.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVier.ForeColor = System.Drawing.Color.Silver
        Me.chkVier.Location = New System.Drawing.Point(534, 32)
        Me.chkVier.Name = "chkVier"
        Me.chkVier.Size = New System.Drawing.Size(15, 14)
        Me.chkVier.TabIndex = 4
        Me.chkVier.UseVisualStyleBackColor = False
        '
        'chkLun
        '
        Me.chkLun.AutoSize = True
        Me.chkLun.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkLun.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLun.ForeColor = System.Drawing.Color.Silver
        Me.chkLun.Location = New System.Drawing.Point(100, 32)
        Me.chkLun.Name = "chkLun"
        Me.chkLun.Size = New System.Drawing.Size(15, 14)
        Me.chkLun.TabIndex = 4
        Me.chkLun.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Silver
        Me.Label14.Location = New System.Drawing.Point(402, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 21)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Jueves"
        '
        'txtHoraEntradaDomingo
        '
        Me.txtHoraEntradaDomingo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaDomingo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaDomingo.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaDomingo.Location = New System.Drawing.Point(339, 117)
        Me.txtHoraEntradaDomingo.MaxLength = 6
        Me.txtHoraEntradaDomingo.Name = "txtHoraEntradaDomingo"
        Me.txtHoraEntradaDomingo.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaDomingo.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Silver
        Me.Label16.Location = New System.Drawing.Point(235, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Sabado"
        '
        'txtHoraEntradaSabado
        '
        Me.txtHoraEntradaSabado.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaSabado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaSabado.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaSabado.Location = New System.Drawing.Point(220, 117)
        Me.txtHoraEntradaSabado.MaxLength = 6
        Me.txtHoraEntradaSabado.Name = "txtHoraEntradaSabado"
        Me.txtHoraEntradaSabado.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaSabado.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Silver
        Me.Label17.Location = New System.Drawing.Point(350, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 21)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Domingo"
        '
        'txtHoraEntradaViernes
        '
        Me.txtHoraEntradaViernes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaViernes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaViernes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaViernes.Location = New System.Drawing.Point(490, 47)
        Me.txtHoraEntradaViernes.MaxLength = 6
        Me.txtHoraEntradaViernes.Name = "txtHoraEntradaViernes"
        Me.txtHoraEntradaViernes.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaViernes.TabIndex = 1
        '
        'txtHoraEntradaMiercoles
        '
        Me.txtHoraEntradaMiercoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaMiercoles.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaMiercoles.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaMiercoles.Location = New System.Drawing.Point(274, 47)
        Me.txtHoraEntradaMiercoles.MaxLength = 6
        Me.txtHoraEntradaMiercoles.Name = "txtHoraEntradaMiercoles"
        Me.txtHoraEntradaMiercoles.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaMiercoles.TabIndex = 1
        '
        'txtHoraEntradaJueves
        '
        Me.txtHoraEntradaJueves.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaJueves.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaJueves.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaJueves.Location = New System.Drawing.Point(383, 47)
        Me.txtHoraEntradaJueves.MaxLength = 6
        Me.txtHoraEntradaJueves.Name = "txtHoraEntradaJueves"
        Me.txtHoraEntradaJueves.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaJueves.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Silver
        Me.Label15.Location = New System.Drawing.Point(509, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 21)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Viernes"
        '
        'txtHoraEntradaMartes
        '
        Me.txtHoraEntradaMartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaMartes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaMartes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaMartes.Location = New System.Drawing.Point(165, 47)
        Me.txtHoraEntradaMartes.MaxLength = 6
        Me.txtHoraEntradaMartes.Name = "txtHoraEntradaMartes"
        Me.txtHoraEntradaMartes.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaMartes.TabIndex = 1
        '
        'txtHoraEntradaLunes
        '
        Me.txtHoraEntradaLunes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaLunes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaLunes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaLunes.Location = New System.Drawing.Point(56, 47)
        Me.txtHoraEntradaLunes.MaxLength = 6
        Me.txtHoraEntradaLunes.Name = "txtHoraEntradaLunes"
        Me.txtHoraEntradaLunes.Size = New System.Drawing.Size(103, 27)
        Me.txtHoraEntradaLunes.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Silver
        Me.Label13.Location = New System.Drawing.Point(284, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 21)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Miercoles"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(184, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Martes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(81, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Lunes"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Silver
        Me.Label18.Location = New System.Drawing.Point(3, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(178, 21)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Ejemplo: 09:00 a 19:30"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Silver
        Me.Label24.Location = New System.Drawing.Point(3, 50)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 21)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Hora"
        '
        'FrmMedicoGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(645, 570)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbEsp)
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtSape)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSegApellido)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtNumMed)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtSnom)
        Me.Controls.Add(Me.txtSegNombre)
        Me.Controls.Add(Me.txtPApe)
        Me.Controls.Add(Me.txtLugarTrabajo)
        Me.Controls.Add(Me.txtPNom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPriApellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPriNombre)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMedicoGerente"
        Me.Text = "FrmMedico"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPriNombre As Label
    Friend WithEvents txtPNom As TextBox
    Friend WithEvents txtSegNombre As Label
    Friend WithEvents txtSnom As TextBox
    Friend WithEvents txtPriApellido As Label
    Friend WithEvents txtPApe As TextBox
    Friend WithEvents txtSegApellido As Label
    Friend WithEvents txtSape As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLugarTrabajo As TextBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumMed As TextBox
    Friend WithEvents cbEsp As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkDom As CheckBox
    Friend WithEvents chkJuev As CheckBox
    Friend WithEvents chkSab As CheckBox
    Friend WithEvents chkMier As CheckBox
    Friend WithEvents chkMar As CheckBox
    Friend WithEvents chkVier As CheckBox
    Friend WithEvents chkLun As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtHoraEntradaDomingo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtHoraEntradaSabado As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtHoraEntradaViernes As TextBox
    Friend WithEvents txtHoraEntradaMiercoles As TextBox
    Friend WithEvents txtHoraEntradaJueves As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtHoraEntradaMartes As TextBox
    Friend WithEvents txtHoraEntradaLunes As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label24 As Label
End Class
