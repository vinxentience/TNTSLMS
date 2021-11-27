<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QR_GENERATOR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QR_GENERATOR))
        Me.QR_CONTAINER = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.USER_NAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.QR_CONTAINER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QR_CONTAINER
        '
        Me.QR_CONTAINER.BackColor = System.Drawing.Color.White
        Me.QR_CONTAINER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QR_CONTAINER.Location = New System.Drawing.Point(105, 197)
        Me.QR_CONTAINER.Name = "QR_CONTAINER"
        Me.QR_CONTAINER.Size = New System.Drawing.Size(193, 161)
        Me.QR_CONTAINER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QR_CONTAINER.TabIndex = 0
        Me.QR_CONTAINER.TabStop = False
        Me.ToolTip1.SetToolTip(Me.QR_CONTAINER, "This QR will be useful when you forgot your username")
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "QR_CODE_[FAMILYNAME]_[FIRSTNAME]"
        Me.SaveFileDialog1.Filter = "Save your QR CODE|*.jpg;*.png;*.gif"
        Me.SaveFileDialog1.InitialDirectory = "C:\TNTS LIBRARY SYSTEM\QR_CODE"
        '
        'USER_NAME
        '
        Me.USER_NAME.BackColor = System.Drawing.Color.White
        Me.USER_NAME.Location = New System.Drawing.Point(155, 98)
        Me.USER_NAME.Name = "USER_NAME"
        Me.USER_NAME.Size = New System.Drawing.Size(120, 20)
        Me.USER_NAME.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.USER_NAME, "Username must be 8 characters higher. Make sure to remember your username, this y" &
        "our permanent identification as a library user.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(78, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "USERNAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(201, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "USER NAME AND QR"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "eLIBHUB"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(13, 384)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(97, 85)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(176, 364)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'QR_GENERATOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(394, 481)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.USER_NAME)
        Me.Controls.Add(Me.QR_CONTAINER)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QR_GENERATOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eLIBHUB"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.QR_CONTAINER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QR_CONTAINER As PictureBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents USER_NAME As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
