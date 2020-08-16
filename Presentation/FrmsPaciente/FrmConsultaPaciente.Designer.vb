<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaPaciente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnChildCons = New System.Windows.Forms.Panel()
        Me.btnConsul = New System.Windows.Forms.Button()
        Me.cbSintoma5 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma8 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma4 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma7 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma2 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelMensajeDiagnostico = New System.Windows.Forms.Panel()
        Me.dgvDiagnostico = New System.Windows.Forms.DataGridView()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.cbSintoma6 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma9 = New System.Windows.Forms.ComboBox()
        Me.cbSintoma3 = New System.Windows.Forms.ComboBox()
        Me.pnChildCons.SuspendLayout()
        Me.PanelMensajeDiagnostico.SuspendLayout()
        CType(Me.dgvDiagnostico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, -126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(561, 58)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "INGRESE SUS SINTOMAS"
        '
        'pnChildCons
        '
        Me.pnChildCons.Controls.Add(Me.btnConsul)
        Me.pnChildCons.Controls.Add(Me.cbSintoma5)
        Me.pnChildCons.Controls.Add(Me.cbSintoma8)
        Me.pnChildCons.Controls.Add(Me.cbSintoma4)
        Me.pnChildCons.Controls.Add(Me.cbSintoma7)
        Me.pnChildCons.Controls.Add(Me.cbSintoma2)
        Me.pnChildCons.Controls.Add(Me.cbSintoma1)
        Me.pnChildCons.Controls.Add(Me.Label2)
        Me.pnChildCons.Controls.Add(Me.PanelMensajeDiagnostico)
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
        'btnConsul
        '
        Me.btnConsul.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnConsul.FlatAppearance.BorderSize = 0
        Me.btnConsul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsul.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsul.Location = New System.Drawing.Point(12, 394)
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
        Me.cbSintoma5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma5.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma5.FormattingEnabled = True
        Me.cbSintoma5.Location = New System.Drawing.Point(274, 142)
        Me.cbSintoma5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma5.Name = "cbSintoma5"
        Me.cbSintoma5.Size = New System.Drawing.Size(233, 29)
        Me.cbSintoma5.TabIndex = 33
        Me.cbSintoma5.Text = "SINTOMA"
        '
        'cbSintoma8
        '
        Me.cbSintoma8.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma8.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma8.FormattingEnabled = True
        Me.cbSintoma8.Location = New System.Drawing.Point(274, 207)
        Me.cbSintoma8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma8.Name = "cbSintoma8"
        Me.cbSintoma8.Size = New System.Drawing.Size(233, 29)
        Me.cbSintoma8.TabIndex = 33
        Me.cbSintoma8.Text = "SINTOMA"
        '
        'cbSintoma4
        '
        Me.cbSintoma4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma4.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma4.FormattingEnabled = True
        Me.cbSintoma4.Location = New System.Drawing.Point(24, 142)
        Me.cbSintoma4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma4.Name = "cbSintoma4"
        Me.cbSintoma4.Size = New System.Drawing.Size(233, 29)
        Me.cbSintoma4.TabIndex = 32
        Me.cbSintoma4.Text = "SINTOMA"
        '
        'cbSintoma7
        '
        Me.cbSintoma7.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma7.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma7.FormattingEnabled = True
        Me.cbSintoma7.Location = New System.Drawing.Point(24, 207)
        Me.cbSintoma7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma7.Name = "cbSintoma7"
        Me.cbSintoma7.Size = New System.Drawing.Size(233, 29)
        Me.cbSintoma7.TabIndex = 32
        Me.cbSintoma7.Text = "SINTOMA"
        '
        'cbSintoma2
        '
        Me.cbSintoma2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma2.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma2.FormattingEnabled = True
        Me.cbSintoma2.Location = New System.Drawing.Point(274, 82)
        Me.cbSintoma2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma2.Name = "cbSintoma2"
        Me.cbSintoma2.Size = New System.Drawing.Size(233, 29)
        Me.cbSintoma2.TabIndex = 31
        Me.cbSintoma2.Text = "SINTOMA"
        '
        'cbSintoma1
        '
        Me.cbSintoma1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma1.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma1.FormattingEnabled = True
        Me.cbSintoma1.Location = New System.Drawing.Point(24, 82)
        Me.cbSintoma1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma1.Name = "cbSintoma1"
        Me.cbSintoma1.Size = New System.Drawing.Size(233, 29)
        Me.cbSintoma1.TabIndex = 30
        Me.cbSintoma1.Text = "SINTOMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(176, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(553, 55)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Selecciones sus sintoams"
        '
        'PanelMensajeDiagnostico
        '
        Me.PanelMensajeDiagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PanelMensajeDiagnostico.Controls.Add(Me.dgvDiagnostico)
        Me.PanelMensajeDiagnostico.Location = New System.Drawing.Point(11, 451)
        Me.PanelMensajeDiagnostico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelMensajeDiagnostico.Name = "PanelMensajeDiagnostico"
        Me.PanelMensajeDiagnostico.Size = New System.Drawing.Size(757, 225)
        Me.PanelMensajeDiagnostico.TabIndex = 25
        '
        'dgvDiagnostico
        '
        Me.dgvDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiagnostico.Location = New System.Drawing.Point(3, 3)
        Me.dgvDiagnostico.Name = "dgvDiagnostico"
        Me.dgvDiagnostico.RowHeadersWidth = 62
        Me.dgvDiagnostico.Size = New System.Drawing.Size(754, 219)
        Me.dgvDiagnostico.TabIndex = 0
        '
        'btnChat
        '
        Me.btnChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnChat.FlatAppearance.BorderSize = 0
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChat.Location = New System.Drawing.Point(535, 394)
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
        Me.cbSintoma6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma6.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma6.FormattingEnabled = True
        Me.cbSintoma6.Location = New System.Drawing.Point(523, 142)
        Me.cbSintoma6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma6.Name = "cbSintoma6"
        Me.cbSintoma6.Size = New System.Drawing.Size(233, 29)
        Me.cbSintoma6.TabIndex = 27
        Me.cbSintoma6.Text = "SINTOMA"
        '
        'cbSintoma9
        '
        Me.cbSintoma9.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma9.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma9.FormattingEnabled = True
        Me.cbSintoma9.Location = New System.Drawing.Point(523, 207)
        Me.cbSintoma9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma9.Name = "cbSintoma9"
        Me.cbSintoma9.Size = New System.Drawing.Size(233, 29)
        Me.cbSintoma9.TabIndex = 27
        Me.cbSintoma9.Text = "SINTOMA"
        '
        'cbSintoma3
        '
        Me.cbSintoma3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbSintoma3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSintoma3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSintoma3.ForeColor = System.Drawing.Color.Silver
        Me.cbSintoma3.FormattingEnabled = True
        Me.cbSintoma3.Location = New System.Drawing.Point(523, 82)
        Me.cbSintoma3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSintoma3.Name = "cbSintoma3"
        Me.cbSintoma3.Size = New System.Drawing.Size(233, 29)
        Me.cbSintoma3.TabIndex = 22
        Me.cbSintoma3.Text = "SINTOMA"
        '
        'FrmConsultaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
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
        Me.PanelMensajeDiagnostico.ResumeLayout(False)
        CType(Me.dgvDiagnostico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents pnChildCons As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelMensajeDiagnostico As Panel
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
    Friend WithEvents dgvDiagnostico As DataGridView
End Class
