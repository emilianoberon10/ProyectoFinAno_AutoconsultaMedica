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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatosUso))
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
        ChartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea4.AxisX.IsLabelAutoFit = False
        ChartArea4.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea4.AxisX.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea4.AxisX.LineWidth = 2
        ChartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea4.AxisX2.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea4.AxisY.IsLabelAutoFit = False
        ChartArea4.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea4.AxisY.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea4.AxisY.TitleForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea4.AxisY2.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea4.BorderColor = System.Drawing.Color.WhiteSmoke
        ChartArea4.Name = "ChartArea1"
        Me.charTopEnfermedades.ChartAreas.Add(ChartArea4)
        Legend4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Legend4.BorderColor = System.Drawing.Color.Transparent
        Legend4.Enabled = False
        Legend4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend4.ForeColor = System.Drawing.Color.WhiteSmoke
        Legend4.IsTextAutoFit = False
        Legend4.Name = "Legend1"
        Me.charTopEnfermedades.Legends.Add(Legend4)
        Me.charTopEnfermedades.Location = New System.Drawing.Point(25, 450)
        Me.charTopEnfermedades.Margin = New System.Windows.Forms.Padding(2)
        Me.charTopEnfermedades.Name = "charTopEnfermedades"
        Me.charTopEnfermedades.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series4.Color = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(191, Byte), Integer))
        Series4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.IsValueShownAsLabel = True
        Series4.LabelForeColor = System.Drawing.Color.WhiteSmoke
        Series4.Legend = "Legend1"
        Series4.Name = "TOP ENFERMEDADES"
        Series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.charTopEnfermedades.Series.Add(Series4)
        Me.charTopEnfermedades.Size = New System.Drawing.Size(753, 220)
        Me.charTopEnfermedades.TabIndex = 0
        Me.charTopEnfermedades.TabStop = False
        Me.charTopEnfermedades.Text = "Chart1"
        Title4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.ForeColor = System.Drawing.Color.WhiteSmoke
        Title4.Name = "Title1"
        Title4.Text = "TOP ENFERMEDADES MAS DIAGNOSTICADAS"
        Me.charTopEnfermedades.Titles.Add(Title4)
        '
        'chartTopSintomas
        '
        Me.chartTopSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea5.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea5.Name = "ChartArea1"
        Me.chartTopSintomas.ChartAreas.Add(ChartArea5)
        Legend5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend5.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend5.ForeColor = System.Drawing.Color.WhiteSmoke
        Legend5.IsTextAutoFit = False
        Legend5.Name = "Legend1"
        Me.chartTopSintomas.Legends.Add(Legend5)
        Me.chartTopSintomas.Location = New System.Drawing.Point(25, 213)
        Me.chartTopSintomas.Margin = New System.Windows.Forms.Padding(2)
        Me.chartTopSintomas.Name = "chartTopSintomas"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series5.IsValueShownAsLabel = True
        Series5.LabelForeColor = System.Drawing.Color.WhiteSmoke
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Series5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.chartTopSintomas.Series.Add(Series5)
        Me.chartTopSintomas.Size = New System.Drawing.Size(753, 227)
        Me.chartTopSintomas.TabIndex = 0
        Me.chartTopSintomas.Text = "Chart1"
        Title5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title5.ForeColor = System.Drawing.Color.WhiteSmoke
        Title5.Name = "Title1"
        Title5.Text = "TOP SINTOMAS SELECCIONADOS"
        Me.chartTopSintomas.Titles.Add(Title5)
        '
        'chartChatsMes
        '
        Me.chartChatsMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea6.AxisX.IsLabelAutoFit = False
        ChartArea6.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea6.AxisX.LineColor = System.Drawing.Color.Cyan
        ChartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea6.AxisX.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea6.AxisY.IsLabelAutoFit = False
        ChartArea6.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea6.AxisY.LineColor = System.Drawing.Color.Cyan
        ChartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea6.AxisY.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea6.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea6.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea6.Name = "ChartArea1"
        Me.chartChatsMes.ChartAreas.Add(ChartArea6)
        Legend6.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend6.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend6.Enabled = False
        Legend6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend6.ForeColor = System.Drawing.Color.WhiteSmoke
        Legend6.IsTextAutoFit = False
        Legend6.Name = "Legend1"
        Me.chartChatsMes.Legends.Add(Legend6)
        Me.chartChatsMes.Location = New System.Drawing.Point(25, 33)
        Me.chartChatsMes.Margin = New System.Windows.Forms.Padding(2)
        Me.chartChatsMes.Name = "chartChatsMes"
        Series6.BorderWidth = 5
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series6.IsValueShownAsLabel = True
        Series6.IsXValueIndexed = True
        Series6.LabelBorderWidth = 2
        Series6.LabelForeColor = System.Drawing.Color.Cyan
        Series6.Legend = "Legend1"
        Series6.Name = "Series1"
        Series6.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series6.YValuesPerPoint = 4
        Me.chartChatsMes.Series.Add(Series6)
        Me.chartChatsMes.Size = New System.Drawing.Size(753, 170)
        Me.chartChatsMes.TabIndex = 0
        Me.chartChatsMes.Text = "Chart1"
        Title6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title6.ForeColor = System.Drawing.Color.WhiteSmoke
        Title6.Name = "Title1"
        Title6.Text = "CHAT POR MES"
        Me.chartChatsMes.Titles.Add(Title6)
        '
        'FrmDatosUso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 683)
        Me.Controls.Add(Me.chartChatsMes)
        Me.Controls.Add(Me.chartTopSintomas)
        Me.Controls.Add(Me.charTopEnfermedades)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
