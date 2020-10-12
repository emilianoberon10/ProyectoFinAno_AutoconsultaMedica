<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDatosUso
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.charTopEnfermedades = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartTopSintomas = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartChatsMes = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.charTopEnfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartTopSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartChatsMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'charTopEnfermedades
        '
        Me.charTopEnfermedades.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.charTopEnfermedades.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.charTopEnfermedades.BorderlineWidth = 2
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisX.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisX.LineWidth = 2
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisY.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisY2.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea1.BorderColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.Name = "ChartArea1"
        Me.charTopEnfermedades.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Legend1.BorderColor = System.Drawing.Color.Transparent
        Legend1.Enabled = False
        Legend1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.ForeColor = System.Drawing.Color.WhiteSmoke
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.charTopEnfermedades.Legends.Add(Legend1)
        Me.charTopEnfermedades.Location = New System.Drawing.Point(11, 450)
        Me.charTopEnfermedades.Margin = New System.Windows.Forms.Padding(2)
        Me.charTopEnfermedades.Name = "charTopEnfermedades"
        Me.charTopEnfermedades.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Series1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelForeColor = System.Drawing.Color.WhiteSmoke
        Series1.Legend = "Legend1"
        Series1.Name = "TOP ENFERMEDADES"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.charTopEnfermedades.Series.Add(Series1)
        Me.charTopEnfermedades.Size = New System.Drawing.Size(753, 220)
        Me.charTopEnfermedades.TabIndex = 0
        Me.charTopEnfermedades.TabStop = False
        Me.charTopEnfermedades.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.WhiteSmoke
        Title1.Name = "Title1"
        Title1.Text = "TOP ENFERMEDADES MAS DIAGNOSTICADAS"
        Me.charTopEnfermedades.Titles.Add(Title1)
        '
        'chartTopSintomas
        '
        Me.chartTopSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea2.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea2.Name = "ChartArea1"
        Me.chartTopSintomas.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend2.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.ForeColor = System.Drawing.Color.WhiteSmoke
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.chartTopSintomas.Legends.Add(Legend2)
        Me.chartTopSintomas.Location = New System.Drawing.Point(11, 213)
        Me.chartTopSintomas.Margin = New System.Windows.Forms.Padding(2)
        Me.chartTopSintomas.Name = "chartTopSintomas"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.LabelForeColor = System.Drawing.Color.WhiteSmoke
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.chartTopSintomas.Series.Add(Series2)
        Me.chartTopSintomas.Size = New System.Drawing.Size(753, 227)
        Me.chartTopSintomas.TabIndex = 0
        Me.chartTopSintomas.Text = "Chart1"
        Title2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.ForeColor = System.Drawing.Color.WhiteSmoke
        Title2.Name = "Title1"
        Title2.Text = "TOP SINTOMAS SELECCIONADOS"
        Me.chartTopSintomas.Titles.Add(Title2)
        '
        'chartChatsMes
        '
        Me.chartChatsMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea3.AxisX.LineColor = System.Drawing.Color.Cyan
        ChartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea3.AxisY.IsLabelAutoFit = False
        ChartArea3.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea3.AxisY.LineColor = System.Drawing.Color.Cyan
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea3.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea3.Name = "ChartArea1"
        Me.chartChatsMes.ChartAreas.Add(ChartArea3)
        Legend3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend3.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend3.Enabled = False
        Legend3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.ForeColor = System.Drawing.Color.WhiteSmoke
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Me.chartChatsMes.Legends.Add(Legend3)
        Me.chartChatsMes.Location = New System.Drawing.Point(11, 33)
        Me.chartChatsMes.Margin = New System.Windows.Forms.Padding(2)
        Me.chartChatsMes.Name = "chartChatsMes"
        Series3.BorderWidth = 5
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.IsValueShownAsLabel = True
        Series3.IsXValueIndexed = True
        Series3.LabelBorderWidth = 2
        Series3.LabelForeColor = System.Drawing.Color.Cyan
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series3.YValuesPerPoint = 4
        Me.chartChatsMes.Series.Add(Series3)
        Me.chartChatsMes.Size = New System.Drawing.Size(753, 170)
        Me.chartChatsMes.TabIndex = 0
        Me.chartChatsMes.Text = "Chart1"
        Title3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.ForeColor = System.Drawing.Color.WhiteSmoke
        Title3.Name = "Title1"
        Title3.Text = "CHAT POR MES"
        Me.chartChatsMes.Titles.Add(Title3)
        '
        'FrmDatosUso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(775, 683)
        Me.Controls.Add(Me.chartChatsMes)
        Me.Controls.Add(Me.chartTopSintomas)
        Me.Controls.Add(Me.charTopEnfermedades)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDatosUso"
        Me.Text = "FrmDatosUso"
        CType(Me.charTopEnfermedades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartTopSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartChatsMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents charTopEnfermedades As DataVisualization.Charting.Chart
    Friend WithEvents chartTopSintomas As DataVisualization.Charting.Chart
    Friend WithEvents chartChatsMes As DataVisualization.Charting.Chart
End Class
