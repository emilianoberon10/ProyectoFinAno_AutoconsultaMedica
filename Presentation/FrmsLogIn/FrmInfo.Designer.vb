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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.llbRecuperarPass = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.llbCrearUsuario = New System.Windows.Forms.LinkLabel()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recuerde que la cedula NO debe contener puntos ni guiones"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(405, 71)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "En caso de no haber cambiado su contraseña, esta sera su cedula. " & Global.Microsoft.VisualBasic.ChrW(10) & "Si la modifico " &
    "puede dar click en el siguiente enlace para restablecerla"
        '
        'llbRecuperarPass
        '
        Me.llbRecuperarPass.AutoSize = True
        Me.llbRecuperarPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbRecuperarPass.ForeColor = System.Drawing.Color.Silver
        Me.llbRecuperarPass.LinkColor = System.Drawing.Color.Silver
        Me.llbRecuperarPass.Location = New System.Drawing.Point(12, 116)
        Me.llbRecuperarPass.Name = "llbRecuperarPass"
        Me.llbRecuperarPass.Size = New System.Drawing.Size(157, 21)
        Me.llbRecuperarPass.TabIndex = 1
        Me.llbRecuperarPass.TabStop = True
        Me.llbRecuperarPass.Text = "recuperar contraseña"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(12, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "En caso de no tener una cuenta de click aquí"
        '
        'llbCrearUsuario
        '
        Me.llbCrearUsuario.AutoSize = True
        Me.llbCrearUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbCrearUsuario.ForeColor = System.Drawing.Color.Silver
        Me.llbCrearUsuario.LinkColor = System.Drawing.Color.Silver
        Me.llbCrearUsuario.Location = New System.Drawing.Point(293, 150)
        Me.llbCrearUsuario.Name = "llbCrearUsuario"
        Me.llbCrearUsuario.Size = New System.Drawing.Size(58, 21)
        Me.llbCrearUsuario.TabIndex = 1
        Me.llbCrearUsuario.TabStop = True
        Me.llbCrearUsuario.Text = "CREAR"
        '
        'btnCerrar
        '
        Me.btnCerrar.Animated = True
        Me.btnCerrar.BorderColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BorderRadius = 20
        Me.btnCerrar.CheckedState.Parent = Me.btnCerrar
        Me.btnCerrar.CustomImages.Parent = Me.btnCerrar
        Me.btnCerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.HoverState.Parent = Me.btnCerrar
        Me.btnCerrar.Location = New System.Drawing.Point(113, 234)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.ShadowDecoration.Parent = Me.btnCerrar
        Me.btnCerrar.Size = New System.Drawing.Size(200, 40)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "CERRAR"
        '
        'FrmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(426, 281)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.llbCrearUsuario)
        Me.Controls.Add(Me.llbRecuperarPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents llbRecuperarPass As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents llbCrearUsuario As LinkLabel
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2Button
End Class
