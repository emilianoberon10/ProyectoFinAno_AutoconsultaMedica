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
        Me.Persona_ci = New System.Windows.Forms.Label()
        Me.Persona_especialidad = New System.Windows.Forms.Label()
        Me.Persona_pNom = New System.Windows.Forms.Label()
        Me.Persona_sNom = New System.Windows.Forms.Label()
        Me.Persona_pApe = New System.Windows.Forms.Label()
        Me.Persona_sApe = New System.Windows.Forms.Label()
        Me.Persona_lugarTrabajo = New System.Windows.Forms.Label()
        Me.ingreMed = New System.Windows.Forms.Label()
        Me.Persona_tel = New System.Windows.Forms.Label()
        Me.Persona_domicilio = New System.Windows.Forms.Label()
        Me.Persona_edad = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Persona_numMed = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkDom = New System.Windows.Forms.CheckBox()
        Me.chkJuev = New System.Windows.Forms.CheckBox()
        Me.chkSab = New System.Windows.Forms.CheckBox()
        Me.chkMier = New System.Windows.Forms.CheckBox()
        Me.chkMar = New System.Windows.Forms.CheckBox()
        Me.chkVier = New System.Windows.Forms.CheckBox()
        Me.chkLun = New System.Windows.Forms.CheckBox()
        Me.Jue = New System.Windows.Forms.Label()
        Me.txtHoraEntradaDomingo = New System.Windows.Forms.TextBox()
        Me.Sab = New System.Windows.Forms.Label()
        Me.txtHoraEntradaSabado = New System.Windows.Forms.TextBox()
        Me.Dom = New System.Windows.Forms.Label()
        Me.txtHoraEntradaViernes = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaMiercoles = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaJueves = New System.Windows.Forms.TextBox()
        Me.Vie = New System.Windows.Forms.Label()
        Me.txtHoraEntradaMartes = New System.Windows.Forms.TextBox()
        Me.txtHoraEntradaLunes = New System.Windows.Forms.TextBox()
        Me.Mie = New System.Windows.Forms.Label()
        Me.Mar = New System.Windows.Forms.Label()
        Me.Lun = New System.Windows.Forms.Label()
        Me.horaEjemplo = New System.Windows.Forms.Label()
        Me.Mhora = New System.Windows.Forms.Label()
        Me.btn_ingresar = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Persona_sexo = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Persona_ci
        '
        Me.Persona_ci.AutoSize = True
        Me.Persona_ci.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_ci.ForeColor = System.Drawing.Color.Silver
        Me.Persona_ci.Location = New System.Drawing.Point(31, 44)
        Me.Persona_ci.Name = "Persona_ci"
        Me.Persona_ci.Size = New System.Drawing.Size(58, 21)
        Me.Persona_ci.TabIndex = 0
        Me.Persona_ci.Text = "Cedula"
        '
        'Persona_especialidad
        '
        Me.Persona_especialidad.AutoSize = True
        Me.Persona_especialidad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_especialidad.ForeColor = System.Drawing.Color.Silver
        Me.Persona_especialidad.Location = New System.Drawing.Point(31, 111)
        Me.Persona_especialidad.Name = "Persona_especialidad"
        Me.Persona_especialidad.Size = New System.Drawing.Size(95, 21)
        Me.Persona_especialidad.TabIndex = 0
        Me.Persona_especialidad.Text = "Especialidad"
        '
        'Persona_pNom
        '
        Me.Persona_pNom.AutoSize = True
        Me.Persona_pNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_pNom.ForeColor = System.Drawing.Color.Silver
        Me.Persona_pNom.Location = New System.Drawing.Point(268, 44)
        Me.Persona_pNom.Name = "Persona_pNom"
        Me.Persona_pNom.Size = New System.Drawing.Size(119, 21)
        Me.Persona_pNom.TabIndex = 0
        Me.Persona_pNom.Text = "Primer Nombre"
        '
        'Persona_sNom
        '
        Me.Persona_sNom.AutoSize = True
        Me.Persona_sNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_sNom.ForeColor = System.Drawing.Color.Silver
        Me.Persona_sNom.Location = New System.Drawing.Point(268, 111)
        Me.Persona_sNom.Name = "Persona_sNom"
        Me.Persona_sNom.Size = New System.Drawing.Size(134, 21)
        Me.Persona_sNom.TabIndex = 0
        Me.Persona_sNom.Text = "Segundo Nombre"
        '
        'Persona_pApe
        '
        Me.Persona_pApe.AutoSize = True
        Me.Persona_pApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_pApe.ForeColor = System.Drawing.Color.Silver
        Me.Persona_pApe.Location = New System.Drawing.Point(531, 45)
        Me.Persona_pApe.Name = "Persona_pApe"
        Me.Persona_pApe.Size = New System.Drawing.Size(118, 21)
        Me.Persona_pApe.TabIndex = 0
        Me.Persona_pApe.Text = "Primer Apellido"
        '
        'Persona_sApe
        '
        Me.Persona_sApe.AutoSize = True
        Me.Persona_sApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_sApe.ForeColor = System.Drawing.Color.Silver
        Me.Persona_sApe.Location = New System.Drawing.Point(531, 111)
        Me.Persona_sApe.Name = "Persona_sApe"
        Me.Persona_sApe.Size = New System.Drawing.Size(133, 21)
        Me.Persona_sApe.TabIndex = 0
        Me.Persona_sApe.Text = "Segundo Apellido"
        '
        'Persona_lugarTrabajo
        '
        Me.Persona_lugarTrabajo.AutoSize = True
        Me.Persona_lugarTrabajo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_lugarTrabajo.ForeColor = System.Drawing.Color.Silver
        Me.Persona_lugarTrabajo.Location = New System.Drawing.Point(31, 322)
        Me.Persona_lugarTrabajo.Name = "Persona_lugarTrabajo"
        Me.Persona_lugarTrabajo.Size = New System.Drawing.Size(126, 21)
        Me.Persona_lugarTrabajo.TabIndex = 0
        Me.Persona_lugarTrabajo.Text = "Lugar de Trabajo"
        '
        'ingreMed
        '
        Me.ingreMed.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreMed.ForeColor = System.Drawing.Color.Silver
        Me.ingreMed.Location = New System.Drawing.Point(1, 6)
        Me.ingreMed.Name = "ingreMed"
        Me.ingreMed.Size = New System.Drawing.Size(775, 36)
        Me.ingreMed.TabIndex = 3
        Me.ingreMed.Text = "INGRESAR MEDICO"
        Me.ingreMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Persona_tel
        '
        Me.Persona_tel.AutoSize = True
        Me.Persona_tel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_tel.ForeColor = System.Drawing.Color.Silver
        Me.Persona_tel.Location = New System.Drawing.Point(530, 179)
        Me.Persona_tel.Name = "Persona_tel"
        Me.Persona_tel.Size = New System.Drawing.Size(68, 21)
        Me.Persona_tel.TabIndex = 0
        Me.Persona_tel.Text = "Telefono"
        '
        'Persona_domicilio
        '
        Me.Persona_domicilio.AutoSize = True
        Me.Persona_domicilio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_domicilio.ForeColor = System.Drawing.Color.Silver
        Me.Persona_domicilio.Location = New System.Drawing.Point(31, 256)
        Me.Persona_domicilio.Name = "Persona_domicilio"
        Me.Persona_domicilio.Size = New System.Drawing.Size(76, 21)
        Me.Persona_domicilio.TabIndex = 0
        Me.Persona_domicilio.Text = "Domicilio"
        '
        'Persona_edad
        '
        Me.Persona_edad.AutoSize = True
        Me.Persona_edad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_edad.ForeColor = System.Drawing.Color.Silver
        Me.Persona_edad.Location = New System.Drawing.Point(272, 183)
        Me.Persona_edad.Name = "Persona_edad"
        Me.Persona_edad.Size = New System.Drawing.Size(44, 21)
        Me.Persona_edad.TabIndex = 0
        Me.Persona_edad.Text = "Edad"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Persona_numMed
        '
        Me.Persona_numMed.AutoSize = True
        Me.Persona_numMed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_numMed.ForeColor = System.Drawing.Color.Silver
        Me.Persona_numMed.Location = New System.Drawing.Point(531, 253)
        Me.Persona_numMed.Name = "Persona_numMed"
        Me.Persona_numMed.Size = New System.Drawing.Size(123, 21)
        Me.Persona_numMed.TabIndex = 0
        Me.Persona_numMed.Text = "Numero Medico"
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
        Me.Panel1.Controls.Add(Me.Jue)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaDomingo)
        Me.Panel1.Controls.Add(Me.Sab)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaSabado)
        Me.Panel1.Controls.Add(Me.Dom)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaViernes)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaMiercoles)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaJueves)
        Me.Panel1.Controls.Add(Me.Vie)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaMartes)
        Me.Panel1.Controls.Add(Me.txtHoraEntradaLunes)
        Me.Panel1.Controls.Add(Me.Mie)
        Me.Panel1.Controls.Add(Me.Mar)
        Me.Panel1.Controls.Add(Me.Lun)
        Me.Panel1.Controls.Add(Me.horaEjemplo)
        Me.Panel1.Controls.Add(Me.Mhora)
        Me.Panel1.Location = New System.Drawing.Point(12, 392)
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
        Me.chkJuev.Location = New System.Drawing.Point(389, 55)
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
        Me.chkMier.Location = New System.Drawing.Point(289, 55)
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
        Me.chkMar.Location = New System.Drawing.Point(189, 55)
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
        Me.chkLun.Location = New System.Drawing.Point(90, 55)
        Me.chkLun.Name = "chkLun"
        Me.chkLun.Size = New System.Drawing.Size(15, 14)
        Me.chkLun.TabIndex = 4
        Me.chkLun.UseVisualStyleBackColor = False
        '
        'Jue
        '
        Me.Jue.AutoSize = True
        Me.Jue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jue.ForeColor = System.Drawing.Color.Silver
        Me.Jue.Location = New System.Drawing.Point(366, 31)
        Me.Jue.Name = "Jue"
        Me.Jue.Size = New System.Drawing.Size(56, 21)
        Me.Jue.TabIndex = 0
        Me.Jue.Text = "Jueves"
        '
        'txtHoraEntradaDomingo
        '
        Me.txtHoraEntradaDomingo.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaDomingo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaDomingo.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaDomingo.Location = New System.Drawing.Point(661, 70)
        Me.txtHoraEntradaDomingo.MaxLength = 12
        Me.txtHoraEntradaDomingo.Name = "txtHoraEntradaDomingo"
        Me.txtHoraEntradaDomingo.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaDomingo.TabIndex = 1
        '
        'Sab
        '
        Me.Sab.AutoSize = True
        Me.Sab.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sab.ForeColor = System.Drawing.Color.Silver
        Me.Sab.Location = New System.Drawing.Point(565, 31)
        Me.Sab.Name = "Sab"
        Me.Sab.Size = New System.Drawing.Size(62, 21)
        Me.Sab.TabIndex = 0
        Me.Sab.Text = "Sabado"
        '
        'txtHoraEntradaSabado
        '
        Me.txtHoraEntradaSabado.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaSabado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaSabado.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaSabado.Location = New System.Drawing.Point(560, 70)
        Me.txtHoraEntradaSabado.MaxLength = 12
        Me.txtHoraEntradaSabado.Name = "txtHoraEntradaSabado"
        Me.txtHoraEntradaSabado.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaSabado.TabIndex = 1
        '
        'Dom
        '
        Me.Dom.AutoSize = True
        Me.Dom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dom.ForeColor = System.Drawing.Color.Silver
        Me.Dom.Location = New System.Drawing.Point(661, 31)
        Me.Dom.Name = "Dom"
        Me.Dom.Size = New System.Drawing.Size(75, 21)
        Me.Dom.TabIndex = 0
        Me.Dom.Text = "Domingo"
        '
        'txtHoraEntradaViernes
        '
        Me.txtHoraEntradaViernes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaViernes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaViernes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaViernes.Location = New System.Drawing.Point(459, 70)
        Me.txtHoraEntradaViernes.MaxLength = 12
        Me.txtHoraEntradaViernes.Name = "txtHoraEntradaViernes"
        Me.txtHoraEntradaViernes.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaViernes.TabIndex = 1
        '
        'txtHoraEntradaMiercoles
        '
        Me.txtHoraEntradaMiercoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaMiercoles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaMiercoles.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaMiercoles.Location = New System.Drawing.Point(257, 70)
        Me.txtHoraEntradaMiercoles.MaxLength = 12
        Me.txtHoraEntradaMiercoles.Name = "txtHoraEntradaMiercoles"
        Me.txtHoraEntradaMiercoles.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaMiercoles.TabIndex = 1
        '
        'txtHoraEntradaJueves
        '
        Me.txtHoraEntradaJueves.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaJueves.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaJueves.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaJueves.Location = New System.Drawing.Point(358, 70)
        Me.txtHoraEntradaJueves.MaxLength = 12
        Me.txtHoraEntradaJueves.Name = "txtHoraEntradaJueves"
        Me.txtHoraEntradaJueves.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaJueves.TabIndex = 1
        '
        'Vie
        '
        Me.Vie.AutoSize = True
        Me.Vie.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vie.ForeColor = System.Drawing.Color.Silver
        Me.Vie.Location = New System.Drawing.Point(466, 31)
        Me.Vie.Name = "Vie"
        Me.Vie.Size = New System.Drawing.Size(62, 21)
        Me.Vie.TabIndex = 0
        Me.Vie.Text = "Viernes"
        '
        'txtHoraEntradaMartes
        '
        Me.txtHoraEntradaMartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaMartes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaMartes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaMartes.Location = New System.Drawing.Point(156, 70)
        Me.txtHoraEntradaMartes.MaxLength = 12
        Me.txtHoraEntradaMartes.Name = "txtHoraEntradaMartes"
        Me.txtHoraEntradaMartes.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaMartes.TabIndex = 1
        '
        'txtHoraEntradaLunes
        '
        Me.txtHoraEntradaLunes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtHoraEntradaLunes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraEntradaLunes.ForeColor = System.Drawing.Color.Silver
        Me.txtHoraEntradaLunes.Location = New System.Drawing.Point(55, 70)
        Me.txtHoraEntradaLunes.MaxLength = 12
        Me.txtHoraEntradaLunes.Name = "txtHoraEntradaLunes"
        Me.txtHoraEntradaLunes.Size = New System.Drawing.Size(78, 29)
        Me.txtHoraEntradaLunes.TabIndex = 1
        '
        'Mie
        '
        Me.Mie.AutoSize = True
        Me.Mie.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mie.ForeColor = System.Drawing.Color.Silver
        Me.Mie.Location = New System.Drawing.Point(256, 31)
        Me.Mie.Name = "Mie"
        Me.Mie.Size = New System.Drawing.Size(77, 21)
        Me.Mie.TabIndex = 0
        Me.Mie.Text = "Miercoles"
        '
        'Mar
        '
        Me.Mar.AutoSize = True
        Me.Mar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mar.ForeColor = System.Drawing.Color.Silver
        Me.Mar.Location = New System.Drawing.Point(171, 32)
        Me.Mar.Name = "Mar"
        Me.Mar.Size = New System.Drawing.Size(58, 21)
        Me.Mar.TabIndex = 0
        Me.Mar.Text = "Martes"
        '
        'Lun
        '
        Me.Lun.AutoSize = True
        Me.Lun.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lun.ForeColor = System.Drawing.Color.Silver
        Me.Lun.Location = New System.Drawing.Point(71, 31)
        Me.Lun.Name = "Lun"
        Me.Lun.Size = New System.Drawing.Size(51, 21)
        Me.Lun.TabIndex = 0
        Me.Lun.Text = "Lunes"
        '
        'horaEjemplo
        '
        Me.horaEjemplo.AutoSize = True
        Me.horaEjemplo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaEjemplo.ForeColor = System.Drawing.Color.Silver
        Me.horaEjemplo.Location = New System.Drawing.Point(7, 118)
        Me.horaEjemplo.Name = "horaEjemplo"
        Me.horaEjemplo.Size = New System.Drawing.Size(135, 17)
        Me.horaEjemplo.TabIndex = 0
        Me.horaEjemplo.Text = "Ejemplo: 09:00 a 19:30"
        '
        'Mhora
        '
        Me.Mhora.AutoSize = True
        Me.Mhora.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mhora.ForeColor = System.Drawing.Color.Silver
        Me.Mhora.Location = New System.Drawing.Point(6, 76)
        Me.Mhora.Name = "Mhora"
        Me.Mhora.Size = New System.Drawing.Size(44, 21)
        Me.Mhora.TabIndex = 0
        Me.Mhora.Text = "Hora"
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Animated = True
        Me.btn_ingresar.BackColor = System.Drawing.Color.Transparent
        Me.btn_ingresar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_ingresar.BorderRadius = 15
        Me.btn_ingresar.BorderThickness = 2
        Me.btn_ingresar.CheckedState.Parent = Me.btn_ingresar
        Me.btn_ingresar.CustomImages.Parent = Me.btn_ingresar
        Me.btn_ingresar.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_ingresar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingresar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_ingresar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_ingresar.HoverState.Parent = Me.btn_ingresar
        Me.btn_ingresar.Location = New System.Drawing.Point(563, 563)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.PressedColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_ingresar.ShadowDecoration.BorderRadius = 20
        Me.btn_ingresar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btn_ingresar.ShadowDecoration.Depth = 15
        Me.btn_ingresar.ShadowDecoration.Enabled = True
        Me.btn_ingresar.ShadowDecoration.Parent = Me.btn_ingresar
        Me.btn_ingresar.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(4)
        Me.btn_ingresar.Size = New System.Drawing.Size(200, 40)
        Me.btn_ingresar.TabIndex = 55
        Me.btn_ingresar.Text = "INGRESAR"
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
        Me.txtSnom.Location = New System.Drawing.Point(268, 137)
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
        Me.txtLugarTrabajo.Location = New System.Drawing.Point(31, 344)
        Me.txtLugarTrabajo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLugarTrabajo.MaxLength = 255
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
        Me.txtNumMed.Location = New System.Drawing.Point(531, 278)
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
        Me.txtSape.Location = New System.Drawing.Point(535, 137)
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
        Me.txtEdad.Location = New System.Drawing.Point(272, 209)
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
        Me.txtDomicilio.Location = New System.Drawing.Point(31, 282)
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
        Me.txtTelefono.Location = New System.Drawing.Point(531, 209)
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
        Me.cbEsp.Location = New System.Drawing.Point(31, 131)
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
        Me.cbSexo.Location = New System.Drawing.Point(31, 203)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.ShadowDecoration.Parent = Me.cbSexo
        Me.cbSexo.Size = New System.Drawing.Size(220, 36)
        Me.cbSexo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbSexo.TabIndex = 57
        '
        'Persona_sexo
        '
        Me.Persona_sexo.AutoSize = True
        Me.Persona_sexo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_sexo.ForeColor = System.Drawing.Color.Silver
        Me.Persona_sexo.Location = New System.Drawing.Point(31, 179)
        Me.Persona_sexo.Name = "Persona_sexo"
        Me.Persona_sexo.Size = New System.Drawing.Size(43, 21)
        Me.Persona_sexo.TabIndex = 0
        Me.Persona_sexo.Text = "Sexo"
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
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ingreMed)
        Me.Controls.Add(Me.Persona_domicilio)
        Me.Controls.Add(Me.Persona_numMed)
        Me.Controls.Add(Me.Persona_edad)
        Me.Controls.Add(Me.Persona_tel)
        Me.Controls.Add(Me.Persona_sApe)
        Me.Controls.Add(Me.Persona_sNom)
        Me.Controls.Add(Me.Persona_sexo)
        Me.Controls.Add(Me.Persona_lugarTrabajo)
        Me.Controls.Add(Me.Persona_pApe)
        Me.Controls.Add(Me.Persona_especialidad)
        Me.Controls.Add(Me.Persona_pNom)
        Me.Controls.Add(Me.Persona_ci)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMedicoGerente"
        Me.Text = "FrmMedico"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Persona_ci As Label
    Friend WithEvents Persona_especialidad As Label
    Friend WithEvents Persona_pNom As Label
    Friend WithEvents Persona_sNom As Label
    Friend WithEvents Persona_pApe As Label
    Friend WithEvents Persona_sApe As Label
    Friend WithEvents Persona_lugarTrabajo As Label
    Friend WithEvents ingreMed As Label
    Friend WithEvents Persona_tel As Label
    Friend WithEvents Persona_domicilio As Label
    Friend WithEvents Persona_edad As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Persona_numMed As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkDom As CheckBox
    Friend WithEvents chkJuev As CheckBox
    Friend WithEvents chkSab As CheckBox
    Friend WithEvents chkMier As CheckBox
    Friend WithEvents chkMar As CheckBox
    Friend WithEvents chkVier As CheckBox
    Friend WithEvents chkLun As CheckBox
    Friend WithEvents Jue As Label
    Friend WithEvents txtHoraEntradaDomingo As TextBox
    Friend WithEvents Sab As Label
    Friend WithEvents txtHoraEntradaSabado As TextBox
    Friend WithEvents Dom As Label
    Friend WithEvents txtHoraEntradaViernes As TextBox
    Friend WithEvents txtHoraEntradaMiercoles As TextBox
    Friend WithEvents txtHoraEntradaJueves As TextBox
    Friend WithEvents Vie As Label
    Friend WithEvents txtHoraEntradaMartes As TextBox
    Friend WithEvents txtHoraEntradaLunes As TextBox
    Friend WithEvents Mie As Label
    Friend WithEvents Mar As Label
    Friend WithEvents Lun As Label
    Friend WithEvents horaEjemplo As Label
    Friend WithEvents Mhora As Label
    Friend WithEvents btn_ingresar As Guna.UI2.WinForms.Guna2Button
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
    Friend WithEvents Persona_sexo As Label
End Class
