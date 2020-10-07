<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBienvenida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBienvenida))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.app_titulo = New System.Windows.Forms.Label()
        Me.Bienvenido = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(732, 310)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 801
        Me.LineShape1.Y1 = 52
        Me.LineShape1.Y2 = 52
        '
        'app_titulo
        '
        Me.app_titulo.AutoSize = True
        Me.app_titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.app_titulo.ForeColor = System.Drawing.Color.Silver
        Me.app_titulo.Location = New System.Drawing.Point(55, 6)
        Me.app_titulo.Name = "app_titulo"
        Me.app_titulo.Size = New System.Drawing.Size(521, 40)
        Me.app_titulo.TabIndex = 1
        Me.app_titulo.Text = "SISTEMA DE AUTOCONSULTA MEDICA"
        '
        'Bienvenido
        '
        Me.Bienvenido.AutoSize = True
        Me.Bienvenido.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bienvenido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Bienvenido.Location = New System.Drawing.Point(164, 69)
        Me.Bienvenido.Name = "Bienvenido"
        Me.Bienvenido.Size = New System.Drawing.Size(136, 30)
        Me.Bienvenido.TabIndex = 1
        Me.Bienvenido.Text = "BIENVENIDO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentation.My.Resources.Resources._1533845191
        Me.PictureBox1.Location = New System.Drawing.Point(461, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.Color.Silver
        Me.lbNombre.Location = New System.Drawing.Point(194, 99)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(77, 25)
        Me.lbNombre.TabIndex = 4
        Me.lbNombre.Text = "Usuario"
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'Timer2
        '
        Me.Timer2.Interval = 30
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.Silver
        Me.CircularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(157, 127)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CircularProgressBar1.OuterMargin = -25
        Me.CircularProgressBar1.OuterWidth = 26
        Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.CircularProgressBar1.ProgressWidth = 25
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.CircularProgressBar1.Size = New System.Drawing.Size(150, 150)
        Me.CircularProgressBar1.StartAngle = 270
        Me.CircularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar1.SubscriptText = ""
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar1.SuperscriptText = "%"
        Me.CircularProgressBar1.TabIndex = 5
        Me.CircularProgressBar1.Text = "0"
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar1.Value = 68
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Presentation.My.Resources.Resources.isotipoProyectowhite
        Me.PictureBox2.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'FrmBienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(732, 310)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CircularProgressBar1)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Bienvenido)
        Me.Controls.Add(Me.app_titulo)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBienvenida"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenida"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents app_titulo As Label
    Friend WithEvents Bienvenido As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents PictureBox2 As PictureBox
End Class
