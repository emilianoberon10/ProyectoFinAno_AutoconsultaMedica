<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecuperarContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecuperarContraseña))
        Me.RecuperarPass_titulo = New System.Windows.Forms.Label()
        Me.Persona_ci = New System.Windows.Forms.Label()
        Me.Persona_correo = New System.Windows.Forms.Label()
        Me.btn_recuperar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCedula = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RecuperarPass_titulo
        '
        Me.RecuperarPass_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecuperarPass_titulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RecuperarPass_titulo.Location = New System.Drawing.Point(0, 5)
        Me.RecuperarPass_titulo.Name = "RecuperarPass_titulo"
        Me.RecuperarPass_titulo.Size = New System.Drawing.Size(592, 40)
        Me.RecuperarPass_titulo.TabIndex = 0
        Me.RecuperarPass_titulo.Text = "Recuperar contraseña"
        Me.RecuperarPass_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Persona_ci
        '
        Me.Persona_ci.AutoSize = True
        Me.Persona_ci.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_ci.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_ci.Location = New System.Drawing.Point(24, 61)
        Me.Persona_ci.Name = "Persona_ci"
        Me.Persona_ci.Size = New System.Drawing.Size(127, 21)
        Me.Persona_ci.TabIndex = 3
        Me.Persona_ci.Text = "Cedula identidad"
        '
        'Persona_correo
        '
        Me.Persona_correo.AutoSize = True
        Me.Persona_correo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Persona_correo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Persona_correo.Location = New System.Drawing.Point(24, 128)
        Me.Persona_correo.Name = "Persona_correo"
        Me.Persona_correo.Size = New System.Drawing.Size(138, 21)
        Me.Persona_correo.TabIndex = 3
        Me.Persona_correo.Text = "Correo electronico"
        '
        'btn_recuperar
        '
        Me.btn_recuperar.Animated = True
        Me.btn_recuperar.BorderColor = System.Drawing.Color.Transparent
        Me.btn_recuperar.BorderRadius = 20
        Me.btn_recuperar.CheckedState.Parent = Me.btn_recuperar
        Me.btn_recuperar.CustomImages.Parent = Me.btn_recuperar
        Me.btn_recuperar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_recuperar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_recuperar.ForeColor = System.Drawing.Color.White
        Me.btn_recuperar.HoverState.Parent = Me.btn_recuperar
        Me.btn_recuperar.Location = New System.Drawing.Point(400, 128)
        Me.btn_recuperar.Name = "btn_recuperar"
        Me.btn_recuperar.ShadowDecoration.Parent = Me.btn_recuperar
        Me.btn_recuperar.Size = New System.Drawing.Size(180, 40)
        Me.btn_recuperar.TabIndex = 7
        Me.btn_recuperar.Text = "RECUPERAR"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Animated = True
        Me.btn_cancelar.BorderColor = System.Drawing.Color.Transparent
        Me.btn_cancelar.BorderRadius = 20
        Me.btn_cancelar.CheckedState.Parent = Me.btn_cancelar
        Me.btn_cancelar.CustomImages.Parent = Me.btn_cancelar
        Me.btn_cancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.HoverState.Parent = Me.btn_cancelar
        Me.btn_cancelar.Location = New System.Drawing.Point(24, 387)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.ShadowDecoration.Parent = Me.btn_cancelar
        Me.btn_cancelar.Size = New System.Drawing.Size(180, 40)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "CANCELAR"
        '
        'txtCorreo
        '
        Me.txtCorreo.Animated = True
        Me.txtCorreo.BorderThickness = 2
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreo.DefaultText = ""
        Me.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.DisabledState.Parent = Me.txtCorreo
        Me.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtCorreo.FocusedState.Parent = Me.txtCorreo
        Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCorreo.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtCorreo.HoverState.Parent = Me.txtCorreo
        Me.txtCorreo.Location = New System.Drawing.Point(24, 156)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCorreo.PlaceholderText = ""
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.ShadowDecoration.Parent = Me.txtCorreo
        Me.txtCorreo.Size = New System.Drawing.Size(351, 30)
        Me.txtCorreo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCorreo.TabIndex = 15
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
        Me.txtCedula.FocusedState.BorderColor = System.Drawing.Color.Cyan
        Me.txtCedula.FocusedState.Parent = Me.txtCedula
        Me.txtCedula.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCedula.HoverState.BorderColor = System.Drawing.Color.Cyan
        Me.txtCedula.HoverState.Parent = Me.txtCedula
        Me.txtCedula.Location = New System.Drawing.Point(24, 87)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCedula.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCedula.PlaceholderText = ""
        Me.txtCedula.SelectedText = ""
        Me.txtCedula.ShadowDecoration.Parent = Me.txtCedula
        Me.txtCedula.Size = New System.Drawing.Size(351, 30)
        Me.txtCedula.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCedula.TabIndex = 16
        '
        'lbMensaje
        '
        Me.lbMensaje.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbMensaje.Location = New System.Drawing.Point(24, 232)
        Me.lbMensaje.Name = "lbMensaje"
        Me.lbMensaje.Padding = New System.Windows.Forms.Padding(10)
        Me.lbMensaje.Size = New System.Drawing.Size(556, 119)
        Me.lbMensaje.TabIndex = 0
        Me.lbMensaje.Visible = False
        '
        'FrmRecuperarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(593, 450)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_recuperar)
        Me.Controls.Add(Me.Persona_correo)
        Me.Controls.Add(Me.Persona_ci)
        Me.Controls.Add(Me.lbMensaje)
        Me.Controls.Add(Me.RecuperarPass_titulo)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmRecuperarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRecuperarContraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecuperarPass_titulo As Label
    Friend WithEvents Persona_ci As Label
    Friend WithEvents Persona_correo As Label
    Friend WithEvents btn_recuperar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCedula As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbMensaje As Label
End Class
