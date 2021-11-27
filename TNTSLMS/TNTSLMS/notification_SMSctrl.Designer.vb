<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notification_SMSctrl
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtmsg = New System.Windows.Forms.TextBox()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FULLNAME = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.USER_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.enableEdit = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(387, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(83, 76)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(268, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'SerialPort1
        '
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(731, 326)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Send"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtmsg
        '
        Me.txtmsg.Enabled = False
        Me.txtmsg.Location = New System.Drawing.Point(541, 113)
        Me.txtmsg.Multiline = True
        Me.txtmsg.Name = "txtmsg"
        Me.txtmsg.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtmsg.Size = New System.Drawing.Size(444, 199)
        Me.txtmsg.TabIndex = 12
        '
        'txtnumber
        '
        Me.txtnumber.Enabled = False
        Me.txtnumber.Location = New System.Drawing.Point(84, 308)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(284, 20)
        Me.txtnumber.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(312, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'FULLNAME
        '
        Me.FULLNAME.AutoSize = True
        Me.FULLNAME.BackColor = System.Drawing.Color.Transparent
        Me.FULLNAME.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.FULLNAME.ForeColor = System.Drawing.Color.Black
        Me.FULLNAME.Location = New System.Drawing.Point(80, 222)
        Me.FULLNAME.Name = "FULLNAME"
        Me.FULLNAME.Size = New System.Drawing.Size(102, 22)
        Me.FULLNAME.TabIndex = 55
        Me.FULLNAME.Text = "[No Data]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(26, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 22)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "LRN:"
        '
        'USER_ID
        '
        Me.USER_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USER_ID.Location = New System.Drawing.Point(83, 178)
        Me.USER_ID.Name = "USER_ID"
        Me.USER_ID.Size = New System.Drawing.Size(284, 29)
        Me.USER_ID.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(439, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 22)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Message:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(80, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(80, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 22)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Contact No."
        '
        'enableEdit
        '
        Me.enableEdit.AutoSize = True
        Me.enableEdit.Location = New System.Drawing.Point(541, 90)
        Me.enableEdit.Name = "enableEdit"
        Me.enableEdit.Size = New System.Drawing.Size(94, 17)
        Me.enableEdit.TabIndex = 58
        Me.enableEdit.Text = "Enable Editing"
        Me.enableEdit.UseVisualStyleBackColor = True
        '
        'notification_SMSctrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.enableEdit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FULLNAME)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.USER_ID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtmsg)
        Me.Controls.Add(Me.txtnumber)
        Me.Controls.Add(Me.Label2)
        Me.Name = "notification_SMSctrl"
        Me.Size = New System.Drawing.Size(1012, 522)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button2 As Button
    Friend WithEvents txtmsg As TextBox
    Friend WithEvents txtnumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FULLNAME As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents USER_ID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents enableEdit As CheckBox
End Class
