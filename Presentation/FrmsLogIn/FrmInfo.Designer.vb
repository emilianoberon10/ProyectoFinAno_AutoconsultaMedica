<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfo))
        Me.lbInfo_rocordatorio1 = New System.Windows.Forms.Label()
        Me.lbInfo_recordatorio2 = New System.Windows.Forms.Label()
        Me.llbForgotPassEs = New System.Windows.Forms.LinkLabel()
        Me.lbInfo_recordatorio3 = New System.Windows.Forms.Label()
        Me.llbCrearUsuario = New System.Windows.Forms.LinkLabel()
        Me.btn_cerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lbInfo_rocordatorio1
        '
        Me.lbInfo_rocordatorio1.AutoSize = True
        Me.lbInfo_rocordatorio1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInfo_rocordatorio1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbInfo_rocordatorio1.Location = New System.Drawing.Point(8, 9)
        Me.lbInfo_rocordatorio1.Name = "lbInfo_rocordatorio1"
        Me.lbInfo_rocordatorio1.Size = New System.Drawing.Size(429, 21)
        Me.lbInfo_rocordatorio1.TabIndex = 0
        Me.lbInfo_rocordatorio1.Text = "Recuerde que la cedula NO debe contener puntos ni guiones"
        '
        'lbInfo_recordatorio2
        '
        Me.lbInfo_recordatorio2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInfo_recordatorio2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbInfo_recordatorio2.Location = New System.Drawing.Point(8, 45)
        Me.lbInfo_recordatorio2.Name = "lbInfo_recordatorio2"
        Me.lbInfo_recordatorio2.Size = New System.Drawing.Size(405, 71)
        Me.lbInfo_recordatorio2.TabIndex = 0
        Me.lbInfo_recordatorio2.Text = "En caso de no haber cambiado su contraseña, esta sera su cedula. " & Global.Microsoft.VisualBasic.ChrW(10) & "Si la modifico " &
    "puede dar click en el siguiente enlace para restablecerla"
        '
        'llbForgotPassEs
        '
        Me.llbForgotPassEs.AutoSize = True
        Me.llbForgotPassEs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbForgotPassEs.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.llbForgotPassEs.LinkColor = System.Drawing.Color.Silver
        Me.llbForgotPassEs.Location = New System.Drawing.Point(8, 116)
        Me.llbForgotPassEs.Name = "llbForgotPassEs"
        Me.llbForgotPassEs.Size = New System.Drawing.Size(157, 21)
        Me.llbForgotPassEs.TabIndex = 1
        Me.llbForgotPassEs.TabStop = True
        Me.llbForgotPassEs.Text = "recuperar contraseña"
        '
        'lbInfo_recordatorio3
        '
        Me.lbInfo_recordatorio3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInfo_recordatorio3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbInfo_recordatorio3.Location = New System.Drawing.Point(8, 150)
        Me.lbInfo_recordatorio3.Name = "lbInfo_recordatorio3"
        Me.lbInfo_recordatorio3.Size = New System.Drawing.Size(303, 21)
        Me.lbInfo_recordatorio3.TabIndex = 0
        Me.lbInfo_recordatorio3.Text = "En caso de no tener una cuenta de click aquí"
        '
        'llbCrearUsuario
        '
        Me.llbCrearUsuario.AutoSize = True
        Me.llbCrearUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbCrearUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.llbCrearUsuario.LinkColor = System.Drawing.Color.Silver
        Me.llbCrearUsuario.Location = New System.Drawing.Point(289, 150)
        Me.llbCrearUsuario.Name = "llbCrearUsuario"
        Me.llbCrearUsuario.Size = New System.Drawing.Size(58, 21)
        Me.llbCrearUsuario.TabIndex = 1
        Me.llbCrearUsuario.TabStop = True
        Me.llbCrearUsuario.Text = "CREAR"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Animated = True
        Me.btn_cerrar.BorderColor = System.Drawing.Color.Transparent
        Me.btn_cerrar.BorderRadius = 20
        Me.btn_cerrar.CheckedState.Parent = Me.btn_cerrar
        Me.btn_cerrar.CustomImages.Parent = Me.btn_cerrar
        Me.btn_cerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.HoverState.Parent = Me.btn_cerrar
        Me.btn_cerrar.Location = New System.Drawing.Point(122, 234)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.ShadowDecoration.Parent = Me.btn_cerrar
        Me.btn_cerrar.Size = New System.Drawing.Size(200, 40)
        Me.btn_cerrar.TabIndex = 5
        Me.btn_cerrar.Text = "CERRAR"
        '
        'FrmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(445, 281)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.llbCrearUsuario)
        Me.Controls.Add(Me.llbForgotPassEs)
        Me.Controls.Add(Me.lbInfo_recordatorio3)
        Me.Controls.Add(Me.lbInfo_recordatorio2)
        Me.Controls.Add(Me.lbInfo_rocordatorio1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbInfo_rocordatorio1 As Label
    Friend WithEvents lbInfo_recordatorio2 As Label
    Friend WithEvents llbForgotPassEs As LinkLabel
    Friend WithEvents lbInfo_recordatorio3 As Label
    Friend WithEvents llbCrearUsuario As LinkLabel
    Friend WithEvents btn_cerrar As Guna.UI2.WinForms.Guna2Button
End Class
