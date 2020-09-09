<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmChatPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChatPaciente))
        Me.panelChat = New System.Windows.Forms.Panel()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.btnEnviarMensaje = New System.Windows.Forms.Button()
        Me.btnSalirChat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'panelChat
        '
        Me.panelChat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelChat.Location = New System.Drawing.Point(3, 55)
        Me.panelChat.Name = "panelChat"
        Me.panelChat.Size = New System.Drawing.Size(577, 570)
        Me.panelChat.TabIndex = 1
        '
        'txtMensaje
        '
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(3, 631)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(460, 30)
        Me.txtMensaje.TabIndex = 1
        '
        'btnEnviarMensaje
        '
        Me.btnEnviarMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnEnviarMensaje.FlatAppearance.BorderSize = 0
        Me.btnEnviarMensaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnEnviarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarMensaje.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarMensaje.Location = New System.Drawing.Point(460, 631)
        Me.btnEnviarMensaje.Name = "btnEnviarMensaje"
        Me.btnEnviarMensaje.Size = New System.Drawing.Size(120, 30)
        Me.btnEnviarMensaje.TabIndex = 2
        Me.btnEnviarMensaje.Text = "Enviar"
        Me.btnEnviarMensaje.UseVisualStyleBackColor = False
        '
        'btnSalirChat
        '
        Me.btnSalirChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnSalirChat.FlatAppearance.BorderSize = 0
        Me.btnSalirChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSalirChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirChat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirChat.Location = New System.Drawing.Point(12, 12)
        Me.btnSalirChat.Name = "btnSalirChat"
        Me.btnSalirChat.Size = New System.Drawing.Size(120, 30)
        Me.btnSalirChat.TabIndex = 3
        Me.btnSalirChat.Text = "SALIR"
        Me.btnSalirChat.UseVisualStyleBackColor = False
        '
        'FrmChatPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(589, 674)
        Me.Controls.Add(Me.btnSalirChat)
        Me.Controls.Add(Me.btnEnviarMensaje)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.panelChat)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmChatPaciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelChat As Panel
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents btnEnviarMensaje As Button
    Friend WithEvents btnSalirChat As Button
End Class
