<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notification_email
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notification_email))
        Me.Sent_Message = New System.Windows.Forms.RichTextBox()
        Me.Sent_From = New System.Windows.Forms.TextBox()
        Me.Sent_To = New System.Windows.Forms.TextBox()
        Me.Sent_Subject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.USER_ID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FULLNAME = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sent_Message
        '
        Me.Sent_Message.Enabled = False
        Me.Sent_Message.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sent_Message.Location = New System.Drawing.Point(587, 220)
        Me.Sent_Message.Name = "Sent_Message"
        Me.Sent_Message.Size = New System.Drawing.Size(491, 264)
        Me.Sent_Message.TabIndex = 0
        Me.Sent_Message.Text = ""
        '
        'Sent_From
        '
        Me.Sent_From.Enabled = False
        Me.Sent_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sent_From.Location = New System.Drawing.Point(137, 289)
        Me.Sent_From.Name = "Sent_From"
        Me.Sent_From.Size = New System.Drawing.Size(284, 29)
        Me.Sent_From.TabIndex = 1
        Me.Sent_From.Text = "tntslibrarynotification@gmail.com"
        '
        'Sent_To
        '
        Me.Sent_To.Enabled = False
        Me.Sent_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sent_To.Location = New System.Drawing.Point(137, 372)
        Me.Sent_To.Name = "Sent_To"
        Me.Sent_To.Size = New System.Drawing.Size(284, 29)
        Me.Sent_To.TabIndex = 2
        '
        'Sent_Subject
        '
        Me.Sent_Subject.Enabled = False
        Me.Sent_Subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sent_Subject.Location = New System.Drawing.Point(137, 455)
        Me.Sent_Subject.Name = "Sent_Subject"
        Me.Sent_Subject.Size = New System.Drawing.Size(284, 29)
        Me.Sent_Subject.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 454)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Subject:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(467, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Message:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(177, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "eLIBHUB: Library Management System"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(173, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(496, 23)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Apokon, Tagum City, Davao Del Norte, Philippines" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(171, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(420, 34)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "TAGUM NATIONAL TRADE SCHOOL"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-23, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(810, 490)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(810, 544)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Send Mail"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 556)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(97, 85)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 36
        Me.PictureBox4.TabStop = False
        '
        'USER_ID
        '
        Me.USER_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USER_ID.Location = New System.Drawing.Point(135, 199)
        Me.USER_ID.Name = "USER_ID"
        Me.USER_ID.Size = New System.Drawing.Size(284, 29)
        Me.USER_ID.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(65, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 29)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "LRN:"
        '
        'FULLNAME
        '
        Me.FULLNAME.AutoSize = True
        Me.FULLNAME.BackColor = System.Drawing.Color.Transparent
        Me.FULLNAME.Location = New System.Drawing.Point(132, 241)
        Me.FULLNAME.Name = "FULLNAME"
        Me.FULLNAME.Size = New System.Drawing.Size(53, 13)
        Me.FULLNAME.TabIndex = 39
        Me.FULLNAME.Text = "[No Data]"
        '
        'notification_email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1299, 641)
        Me.Controls.Add(Me.FULLNAME)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.USER_ID)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Sent_Subject)
        Me.Controls.Add(Me.Sent_To)
        Me.Controls.Add(Me.Sent_From)
        Me.Controls.Add(Me.Sent_Message)
        Me.Name = "notification_email"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eLIBHUB"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sent_Message As RichTextBox
    Friend WithEvents Sent_From As TextBox
    Friend WithEvents Sent_To As TextBox
    Friend WithEvents Sent_Subject As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents USER_ID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents FULLNAME As Label
End Class
