<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.U_NAME = New System.Windows.Forms.TextBox()
        Me.PASS = New System.Windows.Forms.TextBox()
        Me.LoginBTN = New System.Windows.Forms.Button()
        Me.RegistrationLink = New System.Windows.Forms.LinkLabel()
        Me.F_Pass = New System.Windows.Forms.LinkLabel()
        Me.SHOW_HIDE_PASSWORD = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'U_NAME
        '
        Me.U_NAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.U_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.U_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_NAME.ForeColor = System.Drawing.Color.DarkGray
        Me.U_NAME.Location = New System.Drawing.Point(529, 239)
        Me.U_NAME.Multiline = True
        Me.U_NAME.Name = "U_NAME"
        Me.U_NAME.Size = New System.Drawing.Size(199, 34)
        Me.U_NAME.TabIndex = 1
        Me.U_NAME.Text = "USERNAME"
        Me.ToolTip1.SetToolTip(Me.U_NAME, "Note: Make sure your username is right and just, because it is CASE SENSITIVE. ")
        '
        'PASS
        '
        Me.PASS.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PASS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.PASS.ForeColor = System.Drawing.Color.DimGray
        Me.PASS.Location = New System.Drawing.Point(529, 309)
        Me.PASS.Multiline = True
        Me.PASS.Name = "PASS"
        Me.PASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PASS.Size = New System.Drawing.Size(199, 32)
        Me.PASS.TabIndex = 2
        Me.PASS.Text = "PASSWORD"
        Me.ToolTip1.SetToolTip(Me.PASS, "Please enter your password")
        '
        'LoginBTN
        '
        Me.LoginBTN.BackColor = System.Drawing.Color.DarkCyan
        Me.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LoginBTN.Location = New System.Drawing.Point(573, 404)
        Me.LoginBTN.Name = "LoginBTN"
        Me.LoginBTN.Size = New System.Drawing.Size(100, 27)
        Me.LoginBTN.TabIndex = 4
        Me.LoginBTN.Text = "Login"
        Me.LoginBTN.UseVisualStyleBackColor = False
        '
        'RegistrationLink
        '
        Me.RegistrationLink.AutoSize = True
        Me.RegistrationLink.BackColor = System.Drawing.Color.DarkCyan
        Me.RegistrationLink.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrationLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.RegistrationLink.LinkColor = System.Drawing.Color.White
        Me.RegistrationLink.Location = New System.Drawing.Point(115, 360)
        Me.RegistrationLink.Name = "RegistrationLink"
        Me.RegistrationLink.Size = New System.Drawing.Size(163, 19)
        Me.RegistrationLink.TabIndex = 5
        Me.RegistrationLink.TabStop = True
        Me.RegistrationLink.Text = "Create an account"
        '
        'F_Pass
        '
        Me.F_Pass.AutoSize = True
        Me.F_Pass.Location = New System.Drawing.Point(685, 441)
        Me.F_Pass.Name = "F_Pass"
        Me.F_Pass.Size = New System.Drawing.Size(92, 13)
        Me.F_Pass.TabIndex = 6
        Me.F_Pass.TabStop = True
        Me.F_Pass.Text = "Forgot Password?"
        '
        'SHOW_HIDE_PASSWORD
        '
        Me.SHOW_HIDE_PASSWORD.AutoSize = True
        Me.SHOW_HIDE_PASSWORD.Location = New System.Drawing.Point(571, 365)
        Me.SHOW_HIDE_PASSWORD.Name = "SHOW_HIDE_PASSWORD"
        Me.SHOW_HIDE_PASSWORD.Size = New System.Drawing.Size(102, 17)
        Me.SHOW_HIDE_PASSWORD.TabIndex = 3
        Me.SHOW_HIDE_PASSWORD.Text = "Show Password"
        Me.SHOW_HIDE_PASSWORD.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(496, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(810, 481)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RectangleShape2.CornerRadius = 10
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape2.Location = New System.Drawing.Point(459, 226)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(284, 57)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RectangleShape1.Location = New System.Drawing.Point(462, 294)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(283, 57)
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(464, 441)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(92, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Scan QR to Login"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "eLIBHUB"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RegistrationLink)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 481)
        Me.Panel1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(346, 60)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = """Connecting people with the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "world of ideas and information."""
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 61)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "eLIBHUB"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 34)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Welcome Back!"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(401, 481)
        Me.ShapeContainer2.TabIndex = 6
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.DarkCyan
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.White
        Me.RectangleShape3.CornerRadius = 20
        Me.RectangleShape3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape3.Location = New System.Drawing.Point(90, 347)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(207, 48)
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(760, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(476, 235)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(479, 302)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(39, 41)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(573, 461)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(108, 13)
        Me.LinkLabel2.TabIndex = 15
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "About the developers"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(810, 481)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.SHOW_HIDE_PASSWORD)
        Me.Controls.Add(Me.F_Pass)
        Me.Controls.Add(Me.LoginBTN)
        Me.Controls.Add(Me.PASS)
        Me.Controls.Add(Me.U_NAME)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log-in"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents U_NAME As TextBox
    Friend WithEvents PASS As TextBox
    Friend WithEvents LoginBTN As Button
    Friend WithEvents RegistrationLink As LinkLabel
    Friend WithEvents F_Pass As LinkLabel
    Friend WithEvents SHOW_HIDE_PASSWORD As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
