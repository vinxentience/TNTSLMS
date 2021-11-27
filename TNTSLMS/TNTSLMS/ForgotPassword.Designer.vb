<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        Me.Question_Container_1 = New System.Windows.Forms.Label()
        Me.ANSWER_CONTAINER = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.USERNAME_CONTAINER = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PASSWORD_HERE = New System.Windows.Forms.TextBox()
        Me.SHOW_HIDE_PASS = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Question_Container_1
        '
        Me.Question_Container_1.AutoSize = True
        Me.Question_Container_1.BackColor = System.Drawing.Color.Transparent
        Me.Question_Container_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question_Container_1.Location = New System.Drawing.Point(236, 114)
        Me.Question_Container_1.Name = "Question_Container_1"
        Me.Question_Container_1.Size = New System.Drawing.Size(59, 13)
        Me.Question_Container_1.TabIndex = 0
        Me.Question_Container_1.Text = "No Value"
        '
        'ANSWER_CONTAINER
        '
        Me.ANSWER_CONTAINER.Location = New System.Drawing.Point(197, 186)
        Me.ANSWER_CONTAINER.Name = "ANSWER_CONTAINER"
        Me.ANSWER_CONTAINER.Size = New System.Drawing.Size(147, 20)
        Me.ANSWER_CONTAINER.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Answer:"
        '
        'USERNAME_CONTAINER
        '
        Me.USERNAME_CONTAINER.Location = New System.Drawing.Point(197, 52)
        Me.USERNAME_CONTAINER.Name = "USERNAME_CONTAINER"
        Me.USERNAME_CONTAINER.Size = New System.Drawing.Size(147, 20)
        Me.USERNAME_CONTAINER.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Question:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Your Password:"
        '
        'PASSWORD_HERE
        '
        Me.PASSWORD_HERE.Location = New System.Drawing.Point(197, 296)
        Me.PASSWORD_HERE.Name = "PASSWORD_HERE"
        Me.PASSWORD_HERE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PASSWORD_HERE.Size = New System.Drawing.Size(147, 20)
        Me.PASSWORD_HERE.TabIndex = 9
        '
        'SHOW_HIDE_PASS
        '
        Me.SHOW_HIDE_PASS.AutoSize = True
        Me.SHOW_HIDE_PASS.BackColor = System.Drawing.Color.White
        Me.SHOW_HIDE_PASS.Location = New System.Drawing.Point(227, 323)
        Me.SHOW_HIDE_PASS.Name = "SHOW_HIDE_PASS"
        Me.SHOW_HIDE_PASS.Size = New System.Drawing.Size(102, 17)
        Me.SHOW_HIDE_PASS.TabIndex = 10
        Me.SHOW_HIDE_PASS.Text = "Show Password"
        Me.SHOW_HIDE_PASS.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Please Enter your User ID / LRN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(362, 177)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(474, 15)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 38
        Me.PictureBox4.TabStop = False
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(523, 418)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SHOW_HIDE_PASS)
        Me.Controls.Add(Me.PASSWORD_HERE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.USERNAME_CONTAINER)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ANSWER_CONTAINER)
        Me.Controls.Add(Me.Question_Container_1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eLIBHUB"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Question_Container_1 As Label
    Friend WithEvents ANSWER_CONTAINER As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents USERNAME_CONTAINER As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PASSWORD_HERE As TextBox
    Friend WithEvents SHOW_HIDE_PASS As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
