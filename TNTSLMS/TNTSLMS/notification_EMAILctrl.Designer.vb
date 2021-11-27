<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notification_EMAILctrl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notification_EMAILctrl))
        Me.FULLNAME = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.USER_ID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sent_Subject = New System.Windows.Forms.TextBox()
        Me.Sent_To = New System.Windows.Forms.TextBox()
        Me.Sent_From = New System.Windows.Forms.TextBox()
        Me.enableEdit = New System.Windows.Forms.CheckBox()
        Me.Sent_Message = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FULLNAME
        '
        Me.FULLNAME.AutoSize = True
        Me.FULLNAME.BackColor = System.Drawing.Color.Transparent
        Me.FULLNAME.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FULLNAME.Location = New System.Drawing.Point(132, 128)
        Me.FULLNAME.Name = "FULLNAME"
        Me.FULLNAME.Size = New System.Drawing.Size(102, 22)
        Me.FULLNAME.TabIndex = 52
        Me.FULLNAME.Text = "[No Data]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(67, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 22)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "LRN:"
        '
        'USER_ID
        '
        Me.USER_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USER_ID.Location = New System.Drawing.Point(136, 83)
        Me.USER_ID.Name = "USER_ID"
        Me.USER_ID.Size = New System.Drawing.Size(284, 29)
        Me.USER_ID.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(739, 457)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Send Mail"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(743, 403)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(448, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 22)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Message:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 22)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 22)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Subject:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 22)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "From:"
        '
        'Sent_Subject
        '
        Me.Sent_Subject.Enabled = False
        Me.Sent_Subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sent_Subject.Location = New System.Drawing.Point(136, 338)
        Me.Sent_Subject.Name = "Sent_Subject"
        Me.Sent_Subject.Size = New System.Drawing.Size(284, 29)
        Me.Sent_Subject.TabIndex = 43
        '
        'Sent_To
        '
        Me.Sent_To.Enabled = False
        Me.Sent_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sent_To.Location = New System.Drawing.Point(136, 251)
        Me.Sent_To.Name = "Sent_To"
        Me.Sent_To.Size = New System.Drawing.Size(284, 29)
        Me.Sent_To.TabIndex = 42
        '
        'Sent_From
        '
        Me.Sent_From.Enabled = False
        Me.Sent_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sent_From.Location = New System.Drawing.Point(136, 176)
        Me.Sent_From.Name = "Sent_From"
        Me.Sent_From.Size = New System.Drawing.Size(284, 29)
        Me.Sent_From.TabIndex = 41
        Me.Sent_From.Text = "tntslibrarynotification@gmail.com"
        '
        'enableEdit
        '
        Me.enableEdit.AutoSize = True
        Me.enableEdit.Location = New System.Drawing.Point(549, 113)
        Me.enableEdit.Name = "enableEdit"
        Me.enableEdit.Size = New System.Drawing.Size(94, 17)
        Me.enableEdit.TabIndex = 53
        Me.enableEdit.Text = "Enable Editing"
        Me.enableEdit.UseVisualStyleBackColor = True
        '
        'Sent_Message
        '
        Me.Sent_Message.Enabled = False
        Me.Sent_Message.Location = New System.Drawing.Point(549, 140)
        Me.Sent_Message.Multiline = True
        Me.Sent_Message.Name = "Sent_Message"
        Me.Sent_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Sent_Message.Size = New System.Drawing.Size(444, 227)
        Me.Sent_Message.TabIndex = 54
        '
        'notification_EMAILctrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Sent_Message)
        Me.Controls.Add(Me.enableEdit)
        Me.Controls.Add(Me.FULLNAME)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.USER_ID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Sent_Subject)
        Me.Controls.Add(Me.Sent_To)
        Me.Controls.Add(Me.Sent_From)
        Me.Name = "notification_EMAILctrl"
        Me.Size = New System.Drawing.Size(1012, 522)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FULLNAME As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents USER_ID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Sent_Subject As TextBox
    Friend WithEvents Sent_To As TextBox
    Friend WithEvents Sent_From As TextBox
    Friend WithEvents enableEdit As CheckBox
    Friend WithEvents Sent_Message As TextBox
End Class
