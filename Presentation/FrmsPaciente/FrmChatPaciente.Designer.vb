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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelChat = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnEnviarMensaje = New System.Windows.Forms.Button()
        Me.btnSalirChat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(586, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(192, 699)
        Me.Panel1.TabIndex = 0
        '
        'panelChat
        '
        Me.panelChat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelChat.Location = New System.Drawing.Point(3, 55)
        Me.panelChat.Name = "panelChat"
        Me.panelChat.Size = New System.Drawing.Size(577, 570)
        Me.panelChat.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 631)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(460, 31)
        Me.TextBox1.TabIndex = 1
        '
        'btnEnviarMensaje
        '
        Me.btnEnviarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarMensaje.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarMensaje.Location = New System.Drawing.Point(460, 631)
        Me.btnEnviarMensaje.Name = "btnEnviarMensaje"
        Me.btnEnviarMensaje.Size = New System.Drawing.Size(120, 31)
        Me.btnEnviarMensaje.TabIndex = 2
        Me.btnEnviarMensaje.Text = "Enviar"
        Me.btnEnviarMensaje.UseVisualStyleBackColor = True
        '
        'btnSalirChat
        '
        Me.btnSalirChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnSalirChat.FlatAppearance.BorderSize = 0
        Me.btnSalirChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSalirChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirChat.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirChat.Location = New System.Drawing.Point(528, 12)
        Me.btnSalirChat.Name = "btnSalirChat"
        Me.btnSalirChat.Size = New System.Drawing.Size(52, 37)
        Me.btnSalirChat.TabIndex = 2
        Me.btnSalirChat.Text = "SALIR"
        Me.btnSalirChat.UseVisualStyleBackColor = False
        '
        'FrmChatPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 699)
        Me.Controls.Add(Me.btnSalirChat)
        Me.Controls.Add(Me.btnEnviarMensaje)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.panelChat)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmChatPaciente"
        Me.Text = "FrmChat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelChat As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnEnviarMensaje As Button
    Friend WithEvents btnSalirChat As Button
End Class
