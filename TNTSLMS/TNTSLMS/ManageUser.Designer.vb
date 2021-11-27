<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUser))
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LRN_SHOW = New System.Windows.Forms.Label()
        Me.GRDLVL_SHOW = New System.Windows.Forms.Label()
        Me.CONTACT_SHOW = New System.Windows.Forms.Label()
        Me.SECTION_SHOW = New System.Windows.Forms.Label()
        Me.ADDRESS_SHOW = New System.Windows.Forms.Label()
        Me.EMAIL_SHOW = New System.Windows.Forms.Label()
        Me.GENDER_SHOW = New System.Windows.Forms.Label()
        Me.LNAME_SHOW = New System.Windows.Forms.Label()
        Me.FNAME_SHOW = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.profpiccontainer = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.UID_SHOW = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BID_SHOW = New System.Windows.Forms.Label()
        Me.qrcontainer = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.profpiccontainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qrcontainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(434, 25)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(168, 20)
        Me.SearchBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search User:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(537, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 21)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Grade Level:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(497, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 21)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Contact Number:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(273, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 21)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Section:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-dd-MM"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(664, 165)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 29
        '
        'LRN_SHOW
        '
        Me.LRN_SHOW.AutoSize = True
        Me.LRN_SHOW.BackColor = System.Drawing.Color.Transparent
        Me.LRN_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRN_SHOW.Location = New System.Drawing.Point(660, 119)
        Me.LRN_SHOW.Name = "LRN_SHOW"
        Me.LRN_SHOW.Size = New System.Drawing.Size(66, 16)
        Me.LRN_SHOW.TabIndex = 27
        Me.LRN_SHOW.Text = "[No Data]"
        '
        'GRDLVL_SHOW
        '
        Me.GRDLVL_SHOW.AutoSize = True
        Me.GRDLVL_SHOW.BackColor = System.Drawing.Color.Transparent
        Me.GRDLVL_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRDLVL_SHOW.Location = New System.Drawing.Point(660, 211)
        Me.GRDLVL_SHOW.Name = "GRDLVL_SHOW"
        Me.GRDLVL_SHOW.Size = New System.Drawing.Size(66, 16)
        Me.GRDLVL_SHOW.TabIndex = 26
        Me.GRDLVL_SHOW.Text = "[No Data]"
        '
        'CONTACT_SHOW
        '
        Me.CONTACT_SHOW.AutoSize = True
        Me.CONTACT_SHOW.BackColor = System.Drawing.Color.Transparent
        Me.CONTACT_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTACT_SHOW.Location = New System.Drawing.Point(660, 252)
        Me.CONTACT_SHOW.Name = "CONTACT_SHOW"
        Me.CONTACT_SHOW.Size = New System.Drawing.Size(66, 16)
        Me.CONTACT_SHOW.TabIndex = 25
        Me.CONTACT_SHOW.Text = "[No Data]"
        '
        'SECTION_SHOW
        '
        Me.SECTION_SHOW.AutoSize = True
        Me.SECTION_SHOW.BackColor = System.Drawing.Color.Transparent
        Me.SECTION_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SECTION_SHOW.Location = New System.Drawing.Point(347, 246)
        Me.SECTION_SHOW.Name = "SECTION_SHOW"
        Me.SECTION_SHOW.Size = New System.Drawing.Size(66, 16)
        Me.SECTION_SHOW.TabIndex = 24
        Me.SECTION_SHOW.Text = "[No Data]"
        '
        'ADDRESS_SHOW
        '
        Me.ADDRESS_SHOW.AutoSize = True
        Me.ADDRESS_SHOW.BackColor = System.Drawing.Color.Transparent
        Me.ADDRESS_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDRESS_SHOW.Location = New System.Drawing.Point(660, 85)
        Me.ADDRESS_SHOW.Name = "ADDRESS_SHOW"
        Me.ADDRESS_SHOW.Size = New System.Drawing.Size(58, 15)
        Me.ADDRESS_SHOW.TabIndex = 28
        Me.ADDRESS_SHOW.Text = "[No Data]"
        '
        'EMAIL_SHOW
        '
        Me.EMAIL_SHOW.AutoSize = True
        Me.EMAIL_SHOW.BackColor = System.Drawing.Color.Transparent
        Me.EMAIL_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMAIL_SHOW.Location = New System.Drawing.Point(348, 210)
        Me.EMAIL_SHOW.Name = "EMAIL_SHOW"
        Me.EMAIL_SHOW.Size = New System.Drawing.Size(58, 15)
        Me.EMAIL_SHOW.TabIndex = 23
        Me.EMAIL_SHOW.Text = "[No Data]"
        '
        'GENDER_SHOW
        '
        Me.GENDER_SHOW.AutoSize = True
        Me.GENDER_SHOW.BackColor = System.Drawing.Color.Transparent
        Me.GENDER_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GENDER_SHOW.Location = New System.Drawing.Point(348, 165)
        Me.GENDER_SHOW.Name = "GENDER_SHOW"
        Me.GENDER_SHOW.Size = New System.Drawing.Size(66, 16)
        Me.GENDER_SHOW.TabIndex = 22
        Me.GENDER_SHOW.Text = "[No Data]"
        '
        'LNAME_SHOW
        '
        Me.LNAME_SHOW.AutoSize = True
        Me.LNAME_SHOW.BackColor = System.Drawing.Color.Transparent
        Me.LNAME_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNAME_SHOW.Location = New System.Drawing.Point(348, 124)
        Me.LNAME_SHOW.Name = "LNAME_SHOW"
        Me.LNAME_SHOW.Size = New System.Drawing.Size(66, 16)
        Me.LNAME_SHOW.TabIndex = 21
        Me.LNAME_SHOW.Text = "[No Data]"
        '
        'FNAME_SHOW
        '
        Me.FNAME_SHOW.AutoSize = True
        Me.FNAME_SHOW.BackColor = System.Drawing.Color.Transparent
        Me.FNAME_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNAME_SHOW.Location = New System.Drawing.Point(348, 81)
        Me.FNAME_SHOW.Name = "FNAME_SHOW"
        Me.FNAME_SHOW.Size = New System.Drawing.Size(66, 16)
        Me.FNAME_SHOW.TabIndex = 20
        Me.FNAME_SHOW.Text = "[No Data]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(558, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "ADDRESS: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(274, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "EMAIL: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Gender:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(537, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Date of Birth:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(245, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Last Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(545, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "User ID/LRN:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "First Name:"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(594, 398)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(76, 75)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'profpiccontainer
        '
        Me.profpiccontainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.profpiccontainer.Location = New System.Drawing.Point(20, 106)
        Me.profpiccontainer.Name = "profpiccontainer"
        Me.profpiccontainer.Size = New System.Drawing.Size(217, 160)
        Me.profpiccontainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profpiccontainer.TabIndex = 34
        Me.profpiccontainer.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(566, 476)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(166, 20)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Generate Library Card"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(318, 481)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Table Grid View Mode"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(341, 395)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(73, 75)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(547, 278)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 21)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "USERNAME:"
        '
        'UID_SHOW
        '
        Me.UID_SHOW.AutoSize = True
        Me.UID_SHOW.BackColor = System.Drawing.Color.Transparent
        Me.UID_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UID_SHOW.Location = New System.Drawing.Point(660, 287)
        Me.UID_SHOW.Name = "UID_SHOW"
        Me.UID_SHOW.Size = New System.Drawing.Size(66, 16)
        Me.UID_SHOW.TabIndex = 43
        Me.UID_SHOW.Text = "[No Data]"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(216, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 21)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "BORROWER ID:"
        '
        'BID_SHOW
        '
        Me.BID_SHOW.AutoSize = True
        Me.BID_SHOW.BackColor = System.Drawing.Color.Transparent
        Me.BID_SHOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BID_SHOW.Location = New System.Drawing.Point(348, 289)
        Me.BID_SHOW.Name = "BID_SHOW"
        Me.BID_SHOW.Size = New System.Drawing.Size(66, 16)
        Me.BID_SHOW.TabIndex = 45
        Me.BID_SHOW.Text = "[No Data]"
        '
        'qrcontainer
        '
        Me.qrcontainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.qrcontainer.Location = New System.Drawing.Point(853, 116)
        Me.qrcontainer.Name = "qrcontainer"
        Me.qrcontainer.Size = New System.Drawing.Size(150, 150)
        Me.qrcontainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.qrcontainer.TabIndex = 46
        Me.qrcontainer.TabStop = False
        '
        'ManageUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.qrcontainer)
        Me.Controls.Add(Me.BID_SHOW)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.UID_SHOW)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.profpiccontainer)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LRN_SHOW)
        Me.Controls.Add(Me.GRDLVL_SHOW)
        Me.Controls.Add(Me.CONTACT_SHOW)
        Me.Controls.Add(Me.SECTION_SHOW)
        Me.Controls.Add(Me.ADDRESS_SHOW)
        Me.Controls.Add(Me.EMAIL_SHOW)
        Me.Controls.Add(Me.GENDER_SHOW)
        Me.Controls.Add(Me.LNAME_SHOW)
        Me.Controls.Add(Me.FNAME_SHOW)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ManageUser"
        Me.Size = New System.Drawing.Size(1021, 502)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.profpiccontainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qrcontainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LRN_SHOW As Label
    Friend WithEvents GRDLVL_SHOW As Label
    Friend WithEvents CONTACT_SHOW As Label
    Friend WithEvents SECTION_SHOW As Label
    Friend WithEvents ADDRESS_SHOW As Label
    Friend WithEvents EMAIL_SHOW As Label
    Friend WithEvents GENDER_SHOW As Label
    Friend WithEvents LNAME_SHOW As Label
    Friend WithEvents FNAME_SHOW As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents profpiccontainer As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents UID_SHOW As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BID_SHOW As Label
    Friend WithEvents qrcontainer As PictureBox
End Class
