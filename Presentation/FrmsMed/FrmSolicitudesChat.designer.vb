<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSolicitudesChat
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelSolicitudes = New System.Windows.Forms.Panel()
        Me.dgvSolicitudes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.panelSolicitudes.SuspendLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSolicitudes
        '
        Me.panelSolicitudes.Controls.Add(Me.DataRepeater1)
        Me.panelSolicitudes.Controls.Add(Me.dgvSolicitudes)
        Me.panelSolicitudes.Controls.Add(Me.Label2)
        Me.panelSolicitudes.Controls.Add(Me.Button2)
        Me.panelSolicitudes.Controls.Add(Me.Label1)
        Me.panelSolicitudes.Location = New System.Drawing.Point(23, 2)
        Me.panelSolicitudes.Name = "panelSolicitudes"
        Me.panelSolicitudes.Size = New System.Drawing.Size(756, 681)
        Me.panelSolicitudes.TabIndex = 0
        '
        'dgvSolicitudes
        '
        Me.dgvSolicitudes.AllowUserToAddRows = False
        Me.dgvSolicitudes.AllowUserToDeleteRows = False
        Me.dgvSolicitudes.AllowUserToOrderColumns = True
        Me.dgvSolicitudes.AllowUserToResizeColumns = False
        Me.dgvSolicitudes.AllowUserToResizeRows = False
        Me.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSolicitudes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSolicitudes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.dgvSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSolicitudes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSolicitudes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSolicitudes.ColumnHeadersHeight = 30
        Me.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSolicitudes.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSolicitudes.EnableHeadersVisualStyles = False
        Me.dgvSolicitudes.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvSolicitudes.Location = New System.Drawing.Point(207, 154)
        Me.dgvSolicitudes.Name = "dgvSolicitudes"
        Me.dgvSolicitudes.ReadOnly = True
        Me.dgvSolicitudes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudes.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSolicitudes.RowHeadersVisible = False
        Me.dgvSolicitudes.Size = New System.Drawing.Size(325, 356)
        Me.dgvSolicitudes.TabIndex = 37
        Me.dgvSolicitudes.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(266, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "De doble click para iniciar un chat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(280, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Solicitudes de chat"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'DataRepeater1
        '
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Label5)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Label4)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Label3)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Button1)
        Me.DataRepeater1.ItemTemplate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataRepeater1.ItemTemplate.ForeColor = System.Drawing.Color.Silver
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(607, 72)
        Me.DataRepeater1.Location = New System.Drawing.Point(21, 528)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(615, 150)
        Me.DataRepeater1.TabIndex = 38
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(514, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Label3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Label3"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(557, 479)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Button1"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmSolicitudesChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 683)
        Me.Controls.Add(Me.panelSolicitudes)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSolicitudesChat"
        Me.Text = "FrmSolicitudesChat"
        Me.panelSolicitudes.ResumeLayout(False)
        Me.panelSolicitudes.PerformLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSolicitudes As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dgvSolicitudes As DataGridView
    Friend WithEvents DataRepeater1 As PowerPacks.DataRepeater
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
