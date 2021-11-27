<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LRN_CONTAINER = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FNAME = New System.Windows.Forms.TextBox()
        Me.LNAME = New System.Windows.Forms.TextBox()
        Me.EMAIL_UPDATE = New System.Windows.Forms.TextBox()
        Me.UPDATE_USER = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LRN:"
        '
        'LRN_CONTAINER
        '
        Me.LRN_CONTAINER.AutoSize = True
        Me.LRN_CONTAINER.Location = New System.Drawing.Point(60, 31)
        Me.LRN_CONTAINER.Name = "LRN_CONTAINER"
        Me.LRN_CONTAINER.Size = New System.Drawing.Size(53, 13)
        Me.LRN_CONTAINER.TabIndex = 1
        Me.LRN_CONTAINER.Text = "[No Data]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Gender:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "EMAIL:"
        '
        'FNAME
        '
        Me.FNAME.Location = New System.Drawing.Point(88, 81)
        Me.FNAME.Name = "FNAME"
        Me.FNAME.Size = New System.Drawing.Size(100, 20)
        Me.FNAME.TabIndex = 2
        '
        'LNAME
        '
        Me.LNAME.Location = New System.Drawing.Point(88, 113)
        Me.LNAME.Name = "LNAME"
        Me.LNAME.Size = New System.Drawing.Size(100, 20)
        Me.LNAME.TabIndex = 2
        '
        'EMAIL_UPDATE
        '
        Me.EMAIL_UPDATE.Location = New System.Drawing.Point(88, 193)
        Me.EMAIL_UPDATE.Name = "EMAIL_UPDATE"
        Me.EMAIL_UPDATE.Size = New System.Drawing.Size(100, 20)
        Me.EMAIL_UPDATE.TabIndex = 2
        '
        'UPDATE_USER
        '
        Me.UPDATE_USER.Location = New System.Drawing.Point(97, 280)
        Me.UPDATE_USER.Name = "UPDATE_USER"
        Me.UPDATE_USER.Size = New System.Drawing.Size(75, 23)
        Me.UPDATE_USER.TabIndex = 3
        Me.UPDATE_USER.Text = "Update"
        Me.UPDATE_USER.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(88, 144)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "MALE"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(88, 167)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "FEMALE"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Date of Birth:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 220)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'DateOfBirth
        '
        Me.DateOfBirth.CustomFormat = "yyyy-MM-dd"
        Me.DateOfBirth.Location = New System.Drawing.Point(87, 246)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(101, 20)
        Me.DateOfBirth.TabIndex = 5
        '
        'UpdateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 327)
        Me.Controls.Add(Me.DateOfBirth)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.UPDATE_USER)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.EMAIL_UPDATE)
        Me.Controls.Add(Me.LNAME)
        Me.Controls.Add(Me.FNAME)
        Me.Controls.Add(Me.LRN_CONTAINER)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateUser"
        Me.Text = "UpdateUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LRN_CONTAINER As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FNAME As TextBox
    Friend WithEvents LNAME As TextBox
    Friend WithEvents EMAIL_UPDATE As TextBox
    Friend WithEvents UPDATE_USER As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateOfBirth As DateTimePicker
End Class
