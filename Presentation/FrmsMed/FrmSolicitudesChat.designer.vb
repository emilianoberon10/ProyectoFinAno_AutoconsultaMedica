<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSolicitudesChat
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dgvSolicitudes = New System.Windows.Forms.DataGridView()
        Me.MSoli_aclaracion = New System.Windows.Forms.Label()
        Me.MSoli_titulo = New System.Windows.Forms.Label()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSolicitudes.ColumnHeadersHeight = 30
        Me.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSolicitudes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSolicitudes.EnableHeadersVisualStyles = False
        Me.dgvSolicitudes.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvSolicitudes.Location = New System.Drawing.Point(236, 173)
        Me.dgvSolicitudes.Name = "dgvSolicitudes"
        Me.dgvSolicitudes.ReadOnly = True
        Me.dgvSolicitudes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSolicitudes.RowHeadersVisible = False
        Me.dgvSolicitudes.Size = New System.Drawing.Size(325, 356)
        Me.dgvSolicitudes.TabIndex = 40
        Me.dgvSolicitudes.TabStop = False
        '
        'MSoli_aclaracion
        '
        Me.MSoli_aclaracion.AutoSize = True
        Me.MSoli_aclaracion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSoli_aclaracion.ForeColor = System.Drawing.Color.Silver
        Me.MSoli_aclaracion.Location = New System.Drawing.Point(299, 153)
        Me.MSoli_aclaracion.Name = "MSoli_aclaracion"
        Me.MSoli_aclaracion.Size = New System.Drawing.Size(199, 17)
        Me.MSoli_aclaracion.TabIndex = 39
        Me.MSoli_aclaracion.Text = "De doble click para iniciar un chat"
        '
        'MSoli_titulo
        '
        Me.MSoli_titulo.AutoSize = True
        Me.MSoli_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSoli_titulo.ForeColor = System.Drawing.Color.Silver
        Me.MSoli_titulo.Location = New System.Drawing.Point(269, 25)
        Me.MSoli_titulo.Name = "MSoli_titulo"
        Me.MSoli_titulo.Size = New System.Drawing.Size(264, 40)
        Me.MSoli_titulo.TabIndex = 38
        Me.MSoli_titulo.Text = "Solicitudes de chat"
        '
        'FrmSolicitudesChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 683)
        Me.Controls.Add(Me.dgvSolicitudes)
        Me.Controls.Add(Me.MSoli_aclaracion)
        Me.Controls.Add(Me.MSoli_titulo)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSolicitudesChat"
        Me.Text = "FrmSolicitudesChat"
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dgvSolicitudes As DataGridView
    Friend WithEvents MSoli_aclaracion As Label
    Friend WithEvents MSoli_titulo As Label
End Class
