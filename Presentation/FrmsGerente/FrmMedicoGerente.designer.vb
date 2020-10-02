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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPriNombre = New System.Windows.Forms.Label()
        Me.txtSegNombre = New System.Windows.Forms.Label()
        Me.txtPriApellido = New System.Windows.Forms.Label()
        Me.txtSegApellido = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.btnConsul = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCedula = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSnom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLugarTrabajo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNumMed = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPNom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSape = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEdad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDomicilio = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPApe = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbEsp = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbSexo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(31, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(31, 106)
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
        Me.txtPriNombre.Location = New System.Drawing.Point(268, 44)
        Me.txtPriNombre.Name = "txtPriNombre"
        Me.txtPriNombre.Size = New System.Drawing.Size(124, 21)
        Me.txtPriNombre.TabIndex = 0
        Me.txtPriNombre.Text = "Primer Nombre"
        '
        'txtSegNombre
        '
        Me.txtSegNombre.AutoSize = True
        Me.txtSegNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegNombre.ForeColor = System.Drawing.Color.Silver
        Me.txtSegNombre.Location = New System.Drawing.Point(268, 106)
        Me.txtSegNombre.Name = "txtSegNombre"
        Me.txtSegNombre.Size = New System.Drawing.Size(147, 21)
        Me.txtSegNombre.TabIndex = 0
        Me.txtSegNombre.Text = "Segundo Nombre"
        '
        'txtPriApellido
        '
        Me.txtPriApellido.AutoSize = True
        Me.txtPriApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPriApellido.ForeColor = System.Drawing.Color.Silver
        Me.txtPriApellido.Location = New System.Drawing.Point(531, 45)
        Me.txtPriApellido.Name = "txtPriApellido"
        Me.txtPriApellido.Size = New System.Drawing.Size(125, 21)
        Me.txtPriApellido.TabIndex = 0
        Me.txtPriApellido.Text = "Primer Apellido"
        '
        'txtSegApellido
        '
        Me.txtSegApellido.AutoSize = True
        Me.txtSegApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegApellido.ForeColor = System.Drawing.Color.Silver
        Me.txtSegApellido.Location = New System.Drawing.Point(531, 106)
        Me.txtSegApellido.Name = "txtSegApellido"
        Me.txtSegApellido.Size = New System.Drawing.Size(148, 21)
        Me.txtSegApellido.TabIndex = 0
        Me.txtSegApellido.Text = "Segundo Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(31, 315)
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
        Me.Label8.Location = New System.Drawing.Point(267, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(241, 36)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Ingeras Medico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(530, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(31, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Domicilio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(272, 176)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(531, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Numero Medico"
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
        Me.Panel1.Location = New System.Drawing.Point(12, 370)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(756, 165)
        Me.Panel1.TabIndex = 48
        '
        'chkDom
        '
        Me.chkDom.AutoSize = True
        Me.chkDom.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkDom.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDom.ForeColor = System.Drawing.Color.Silver
        Me.chkDom.Location = New System.Drawing.Point(692, 55)
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
        Me.chkJuev.Location = New System.Drawing.Point(386, 55)
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
        Me.chkSab.Location = New System.Drawing.Point(590, 55)
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
        Me.chkMier.Location = New System.Drawing.Point(284, 55)
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
        Me.chkMar.Location = New System.Drawing.Point(182, 55)
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
        Me.chkVier.Location = New System.Drawing.Point(488, 55)
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
        Me.chkLun.Location = New System.Drawing.Point(80, 55)
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
        Me.Label14.Location = New System.Drawing.Point(359, 31)
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
        Me.txtHoraEntradaDomingo.Location = New System.Drawing.Point(661, 70)
        Me.txtHoraEntradaDomingo.MaxLength = 6
        Me.txtHoraEntradaDomingo.Name = "txtHoraEntradaDomingo"
        Me.txtHoraEntradaDomingo.Size = New System.Drawing.Size(78, 27)
        Me.txtHoraEntradaDomingo.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Silver
        Me.Label16.Location = New System.Drawing.Point(554, 32)
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
        Me.txtHoraEntradaSabado.Location = New System.Drawing.Point(560, 70)
        Me.txtHoraEntradaSabado.MaxLength = 6
        Me.txtHoraEntradaSabado.Name = "txtHoraEntradaSabado"
        Me.txtHoraEntradaSabado.Size = New System.Drawing.Size(78, 27)
        Me.txtHoraEntradaSabado.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Silver
        Me.Label17.Location = New System.Drawing.Point(659, 32)
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
        Me.txtHoraEntradaViernes.Location = New System.Drawing.Point(459, 70)
        Me.txtHoraEntradaViernes.MaxLength = 6
        Me.txtHoraEntradaViernes.Name = "txtHoraEntradaViernes"
        Me.txtHoraEntradaViernes.Size = New System.Drawing.Size(78, 27)
        Me.txtHoraEntradaViernes.TabIndex = 1
        '
        'txtHoraEntradaMiercoles
        '
        Me.txtHoraEntradaMiercoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaMiercoles.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaMiercoles.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaMiercoles.Location = New System.Drawing.Point(257, 70)
        Me.txtHoraEntradaMiercoles.MaxLength = 6
        Me.txtHoraEntradaMiercoles.Name = "txtHoraEntradaMiercoles"
        Me.txtHoraEntradaMiercoles.Size = New System.Drawing.Size(78, 27)
        Me.txtHoraEntradaMiercoles.TabIndex = 1
        '
        'txtHoraEntradaJueves
        '
        Me.txtHoraEntradaJueves.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaJueves.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaJueves.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaJueves.Location = New System.Drawing.Point(358, 70)
        Me.txtHoraEntradaJueves.MaxLength = 6
        Me.txtHoraEntradaJueves.Name = "txtHoraEntradaJueves"
        Me.txtHoraEntradaJueves.Size = New System.Drawing.Size(78, 27)
        Me.txtHoraEntradaJueves.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Silver
        Me.Label15.Location = New System.Drawing.Point(456, 31)
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
        Me.txtHoraEntradaMartes.Location = New System.Drawing.Point(156, 70)
        Me.txtHoraEntradaMartes.MaxLength = 6
        Me.txtHoraEntradaMartes.Name = "txtHoraEntradaMartes"
        Me.txtHoraEntradaMartes.Size = New System.Drawing.Size(78, 27)
        Me.txtHoraEntradaMartes.TabIndex = 1
        '
        'txtHoraEntradaLunes
        '
        Me.txtHoraEntradaLunes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaLunes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaLunes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaLunes.Location = New System.Drawing.Point(55, 70)
        Me.txtHoraEntradaLunes.MaxLength = 6
        Me.txtHoraEntradaLunes.Name = "txtHoraEntradaLunes"
        Me.txtHoraEntradaLunes.Size = New System.Drawing.Size(78, 27)
        Me.txtHoraEntradaLunes.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Silver
        Me.Label13.Location = New System.Drawing.Point(244, 31)
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
        Me.Label12.Location = New System.Drawing.Point(147, 31)
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
        Me.Label11.Location = New System.Drawing.Point(61, 31)
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
        Me.Label24.Location = New System.Drawing.Point(6, 76)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 21)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Hora"
        '
        'btnConsul
        '
        Me.btnConsul.Animated = True
        Me.btnConsul.BackColor = System.Drawing.Color.Transparent
        Me.btnConsul.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnConsul.BorderRadius = 15
        Me.btnConsul.BorderThickness = 2
        Me.btnConsul.CheckedState.Parent = Me.btnConsul
        Me.btnConsul.CustomImages.Parent = Me.btnConsul
        Me.btnConsul.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnConsul.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsul.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnConsul.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnConsul.HoverState.Parent = Me.btnConsul
        Me.btnConsul.Location = New System.Drawing.Point(551, 553)
        Me.btnConsul.Name = "btnConsul"
        Me.btnConsul.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnConsul.ShadowDecoration.BorderRadius = 20
        Me.btnConsul.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnConsul.ShadowDecoration.Depth = 15
        Me.btnConsul.ShadowDecoration.Enabled = True
        Me.btnConsul.ShadowDecoration.Parent = Me.btnConsul
        Me.btnConsul.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btnConsul.Size = New System.Drawing.Size(200, 40)
        Me.btnConsul.TabIndex = 55
        Me.btnConsul.Text = "INGRESAR"
        '
        'txtCedula
        '
        Me.txtCedula.Animated = True
        Me.txtCedula.BorderThickness = 2
        Me.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCedula.DefaultText = ""
        Me.txtCedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCedula.DisabledState.Parent = Me.txtCedula
        Me.txtCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCedula.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCedula.FocusedState.Parent = Me.txtCedula
        Me.txtCedula.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCedula.HoverState.Parent = Me.txtCedula
        Me.txtCedula.Location = New System.Drawing.Point(31, 70)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCedula.MaxLength = 8
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCedula.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCedula.PlaceholderText = ""
        Me.txtCedula.SelectedText = ""
        Me.txtCedula.ShadowDecoration.Parent = Me.txtCedula
        Me.txtCedula.Size = New System.Drawing.Size(220, 30)
        Me.txtCedula.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCedula.TabIndex = 56
        '
        'txtSnom
        '
        Me.txtSnom.BorderThickness = 2
        Me.txtSnom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSnom.DefaultText = ""
        Me.txtSnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSnom.DisabledState.Parent = Me.txtSnom
        Me.txtSnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSnom.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtSnom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSnom.FocusedState.Parent = Me.txtSnom
        Me.txtSnom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSnom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSnom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSnom.HoverState.Parent = Me.txtSnom
        Me.txtSnom.Location = New System.Drawing.Point(268, 130)
        Me.txtSnom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSnom.MaxLength = 30
        Me.txtSnom.Name = "txtSnom"
        Me.txtSnom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSnom.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSnom.PlaceholderText = ""
        Me.txtSnom.SelectedText = ""
        Me.txtSnom.ShadowDecoration.Parent = Me.txtSnom
        Me.txtSnom.Size = New System.Drawing.Size(220, 30)
        Me.txtSnom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSnom.TabIndex = 56
        '
        'txtLugarTrabajo
        '
        Me.txtLugarTrabajo.Animated = True
        Me.txtLugarTrabajo.BorderThickness = 2
        Me.txtLugarTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLugarTrabajo.DefaultText = ""
        Me.txtLugarTrabajo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLugarTrabajo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLugarTrabajo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLugarTrabajo.DisabledState.Parent = Me.txtLugarTrabajo
        Me.txtLugarTrabajo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLugarTrabajo.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtLugarTrabajo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtLugarTrabajo.FocusedState.Parent = Me.txtLugarTrabajo
        Me.txtLugarTrabajo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTrabajo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtLugarTrabajo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtLugarTrabajo.HoverState.Parent = Me.txtLugarTrabajo
        Me.txtLugarTrabajo.Location = New System.Drawing.Point(31, 337)
        Me.txtLugarTrabajo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLugarTrabajo.MaxLength = 30
        Me.txtLugarTrabajo.Name = "txtLugarTrabajo"
        Me.txtLugarTrabajo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLugarTrabajo.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtLugarTrabajo.PlaceholderText = ""
        Me.txtLugarTrabajo.SelectedText = ""
        Me.txtLugarTrabajo.ShadowDecoration.Parent = Me.txtLugarTrabajo
        Me.txtLugarTrabajo.Size = New System.Drawing.Size(461, 30)
        Me.txtLugarTrabajo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtLugarTrabajo.TabIndex = 56
        '
        'txtNumMed
        '
        Me.txtNumMed.Animated = True
        Me.txtNumMed.BorderThickness = 2
        Me.txtNumMed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumMed.DefaultText = ""
        Me.txtNumMed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumMed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumMed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumMed.DisabledState.Parent = Me.txtNumMed
        Me.txtNumMed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumMed.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNumMed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNumMed.FocusedState.Parent = Me.txtNumMed
        Me.txtNumMed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumMed.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumMed.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNumMed.HoverState.Parent = Me.txtNumMed
        Me.txtNumMed.Location = New System.Drawing.Point(531, 271)
        Me.txtNumMed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumMed.MaxLength = 4
        Me.txtNumMed.Name = "txtNumMed"
        Me.txtNumMed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumMed.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumMed.PlaceholderText = ""
        Me.txtNumMed.SelectedText = ""
        Me.txtNumMed.ShadowDecoration.Parent = Me.txtNumMed
        Me.txtNumMed.Size = New System.Drawing.Size(220, 30)
        Me.txtNumMed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtNumMed.TabIndex = 56
        '
        'txtPNom
        '
        Me.txtPNom.Animated = True
        Me.txtPNom.BorderThickness = 2
        Me.txtPNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPNom.DefaultText = ""
        Me.txtPNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPNom.DisabledState.Parent = Me.txtPNom
        Me.txtPNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPNom.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtPNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPNom.FocusedState.Parent = Me.txtPNom
        Me.txtPNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPNom.HoverState.Parent = Me.txtPNom
        Me.txtPNom.Location = New System.Drawing.Point(268, 71)
        Me.txtPNom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPNom.MaxLength = 30
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPNom.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPNom.PlaceholderText = ""
        Me.txtPNom.SelectedText = ""
        Me.txtPNom.ShadowDecoration.Parent = Me.txtPNom
        Me.txtPNom.Size = New System.Drawing.Size(220, 30)
        Me.txtPNom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPNom.TabIndex = 56
        '
        'txtSape
        '
        Me.txtSape.Animated = True
        Me.txtSape.BorderThickness = 2
        Me.txtSape.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSape.DefaultText = ""
        Me.txtSape.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSape.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSape.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSape.DisabledState.Parent = Me.txtSape
        Me.txtSape.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSape.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtSape.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSape.FocusedState.Parent = Me.txtSape
        Me.txtSape.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSape.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSape.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtSape.HoverState.Parent = Me.txtSape
        Me.txtSape.Location = New System.Drawing.Point(535, 130)
        Me.txtSape.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSape.MaxLength = 30
        Me.txtSape.Name = "txtSape"
        Me.txtSape.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSape.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSape.PlaceholderText = ""
        Me.txtSape.SelectedText = ""
        Me.txtSape.ShadowDecoration.Parent = Me.txtSape
        Me.txtSape.Size = New System.Drawing.Size(220, 30)
        Me.txtSape.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtSape.TabIndex = 56
        '
        'txtEdad
        '
        Me.txtEdad.Animated = True
        Me.txtEdad.BorderThickness = 2
        Me.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEdad.DefaultText = ""
        Me.txtEdad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEdad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEdad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEdad.DisabledState.Parent = Me.txtEdad
        Me.txtEdad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEdad.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtEdad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtEdad.FocusedState.Parent = Me.txtEdad
        Me.txtEdad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtEdad.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtEdad.HoverState.Parent = Me.txtEdad
        Me.txtEdad.Location = New System.Drawing.Point(272, 202)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEdad.MaxLength = 2
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEdad.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtEdad.PlaceholderText = ""
        Me.txtEdad.SelectedText = ""
        Me.txtEdad.ShadowDecoration.Parent = Me.txtEdad
        Me.txtEdad.Size = New System.Drawing.Size(220, 30)
        Me.txtEdad.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtEdad.TabIndex = 56
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Animated = True
        Me.txtDomicilio.BorderThickness = 2
        Me.txtDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDomicilio.DefaultText = ""
        Me.txtDomicilio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDomicilio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDomicilio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDomicilio.DisabledState.Parent = Me.txtDomicilio
        Me.txtDomicilio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDomicilio.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDomicilio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtDomicilio.FocusedState.Parent = Me.txtDomicilio
        Me.txtDomicilio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtDomicilio.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtDomicilio.HoverState.Parent = Me.txtDomicilio
        Me.txtDomicilio.Location = New System.Drawing.Point(31, 275)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDomicilio.MaxLength = 255
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDomicilio.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtDomicilio.PlaceholderText = ""
        Me.txtDomicilio.SelectedText = ""
        Me.txtDomicilio.ShadowDecoration.Parent = Me.txtDomicilio
        Me.txtDomicilio.Size = New System.Drawing.Size(457, 30)
        Me.txtDomicilio.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtDomicilio.TabIndex = 56
        '
        'txtPApe
        '
        Me.txtPApe.Animated = True
        Me.txtPApe.BorderThickness = 2
        Me.txtPApe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPApe.DefaultText = ""
        Me.txtPApe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPApe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPApe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPApe.DisabledState.Parent = Me.txtPApe
        Me.txtPApe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPApe.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtPApe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPApe.FocusedState.Parent = Me.txtPApe
        Me.txtPApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPApe.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPApe.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPApe.HoverState.Parent = Me.txtPApe
        Me.txtPApe.Location = New System.Drawing.Point(531, 71)
        Me.txtPApe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPApe.MaxLength = 30
        Me.txtPApe.Name = "txtPApe"
        Me.txtPApe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPApe.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPApe.PlaceholderText = ""
        Me.txtPApe.SelectedText = ""
        Me.txtPApe.ShadowDecoration.Parent = Me.txtPApe
        Me.txtPApe.Size = New System.Drawing.Size(220, 30)
        Me.txtPApe.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPApe.TabIndex = 56
        '
        'txtTelefono
        '
        Me.txtTelefono.Animated = True
        Me.txtTelefono.BorderThickness = 2
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.DefaultText = ""
        Me.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefono.DisabledState.Parent = Me.txtTelefono
        Me.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefono.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtTelefono.FocusedState.Parent = Me.txtTelefono
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtTelefono.HoverState.Parent = Me.txtTelefono
        Me.txtTelefono.Location = New System.Drawing.Point(531, 202)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtTelefono.PlaceholderText = ""
        Me.txtTelefono.SelectedText = ""
        Me.txtTelefono.ShadowDecoration.Parent = Me.txtTelefono
        Me.txtTelefono.Size = New System.Drawing.Size(220, 30)
        Me.txtTelefono.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtTelefono.TabIndex = 56
        '
        'cbEsp
        '
        Me.cbEsp.Animated = True
        Me.cbEsp.BackColor = System.Drawing.Color.Transparent
        Me.cbEsp.BorderThickness = 2
        Me.cbEsp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbEsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEsp.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEsp.FocusedColor = System.Drawing.Color.Empty
        Me.cbEsp.FocusedState.Parent = Me.cbEsp
        Me.cbEsp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEsp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbEsp.FormattingEnabled = True
        Me.cbEsp.HoverState.Parent = Me.cbEsp
        Me.cbEsp.ItemHeight = 30
        Me.cbEsp.Items.AddRange(New Object() {"Medicos", "Enfermedades", "Sintomas"})
        Me.cbEsp.ItemsAppearance.Parent = Me.cbEsp
        Me.cbEsp.Location = New System.Drawing.Point(31, 124)
        Me.cbEsp.Name = "cbEsp"
        Me.cbEsp.ShadowDecoration.Parent = Me.cbEsp
        Me.cbEsp.Size = New System.Drawing.Size(220, 36)
        Me.cbEsp.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbEsp.TabIndex = 57
        '
        'cbSexo
        '
        Me.cbSexo.Animated = True
        Me.cbSexo.BackColor = System.Drawing.Color.Transparent
        Me.cbSexo.BorderThickness = 2
        Me.cbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSexo.FocusedColor = System.Drawing.Color.Empty
        Me.cbSexo.FocusedState.Parent = Me.cbSexo
        Me.cbSexo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.HoverState.Parent = Me.cbSexo
        Me.cbSexo.ItemHeight = 30
        Me.cbSexo.Items.AddRange(New Object() {"Hombre", "Mujer", "Otro"})
        Me.cbSexo.ItemsAppearance.Parent = Me.cbSexo
        Me.cbSexo.Location = New System.Drawing.Point(31, 196)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.ShadowDecoration.Parent = Me.cbSexo
        Me.cbSexo.Size = New System.Drawing.Size(220, 36)
        Me.cbSexo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSexo.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(31, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sexo"
        '
        'FrmMedicoGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(775, 681)
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.cbEsp)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNumMed)
        Me.Controls.Add(Me.txtSape)
        Me.Controls.Add(Me.txtPApe)
        Me.Controls.Add(Me.txtLugarTrabajo)
        Me.Controls.Add(Me.txtPNom)
        Me.Controls.Add(Me.txtSnom)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.btnConsul)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSegApellido)
        Me.Controls.Add(Me.txtSegNombre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPriApellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPriNombre)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPriNombre As Label
    Friend WithEvents txtSegNombre As Label
    Friend WithEvents txtPriApellido As Label
    Friend WithEvents txtSegApellido As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label6 As Label
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
    Friend WithEvents btnConsul As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtDomicilio As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEdad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNumMed As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSape As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPApe As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLugarTrabajo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPNom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSnom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCedula As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbEsp As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbSexo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
End Class
