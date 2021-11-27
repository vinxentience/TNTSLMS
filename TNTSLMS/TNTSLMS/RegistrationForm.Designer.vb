<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Me.LRN = New System.Windows.Forms.TextBox()
        Me.FNAME = New System.Windows.Forms.TextBox()
        Me.LNAME = New System.Windows.Forms.TextBox()
        Me.EMAIL = New System.Windows.Forms.TextBox()
        Me.ADDRESS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PASS = New System.Windows.Forms.TextBox()
        Me.UploadImg = New System.Windows.Forms.Button()
        Me.profpiccontainer = New System.Windows.Forms.PictureBox()
        Me.opf = New System.Windows.Forms.OpenFileDialog()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Question_Box = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Answer_Box = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SECTION = New System.Windows.Forms.TextBox()
        Me.CONTACT = New System.Windows.Forms.TextBox()
        Me.GRADELVL = New System.Windows.Forms.ComboBox()
        Me.USER_NAME = New System.Windows.Forms.Label()
        Me.GeneratedNo = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.QR_CONTAINER = New System.Windows.Forms.PictureBox()
        Me.UPLOAD_QR = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.RetypePASS = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.USERLVL_BOX = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MNAME = New System.Windows.Forms.TextBox()
        CType(Me.profpiccontainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QR_CONTAINER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LRN
        '
        Me.LRN.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRN.ForeColor = System.Drawing.Color.White
        Me.LRN.Location = New System.Drawing.Point(641, 268)
        Me.LRN.Multiline = True
        Me.LRN.Name = "LRN"
        Me.LRN.Size = New System.Drawing.Size(259, 33)
        Me.LRN.TabIndex = 13
        '
        'FNAME
        '
        Me.FNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.FNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNAME.ForeColor = System.Drawing.Color.White
        Me.FNAME.Location = New System.Drawing.Point(59, 269)
        Me.FNAME.Multiline = True
        Me.FNAME.Name = "FNAME"
        Me.FNAME.Size = New System.Drawing.Size(146, 36)
        Me.FNAME.TabIndex = 1
        '
        'LNAME
        '
        Me.LNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNAME.ForeColor = System.Drawing.Color.White
        Me.LNAME.Location = New System.Drawing.Point(59, 341)
        Me.LNAME.Multiline = True
        Me.LNAME.Name = "LNAME"
        Me.LNAME.Size = New System.Drawing.Size(290, 36)
        Me.LNAME.TabIndex = 3
        '
        'EMAIL
        '
        Me.EMAIL.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMAIL.ForeColor = System.Drawing.Color.White
        Me.EMAIL.Location = New System.Drawing.Point(59, 404)
        Me.EMAIL.Multiline = True
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.Size = New System.Drawing.Size(290, 37)
        Me.EMAIL.TabIndex = 4
        '
        'ADDRESS
        '
        Me.ADDRESS.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ADDRESS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDRESS.ForeColor = System.Drawing.Color.White
        Me.ADDRESS.Location = New System.Drawing.Point(59, 470)
        Me.ADDRESS.Multiline = True
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.Size = New System.Drawing.Size(290, 33)
        Me.ADDRESS.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(637, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Password*"
        '
        'PASS
        '
        Me.PASS.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PASS.ForeColor = System.Drawing.Color.White
        Me.PASS.Location = New System.Drawing.Point(641, 341)
        Me.PASS.Multiline = True
        Me.PASS.Name = "PASS"
        Me.PASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PASS.Size = New System.Drawing.Size(259, 36)
        Me.PASS.TabIndex = 14
        '
        'UploadImg
        '
        Me.UploadImg.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.UploadImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UploadImg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadImg.Location = New System.Drawing.Point(341, 187)
        Me.UploadImg.Name = "UploadImg"
        Me.UploadImg.Size = New System.Drawing.Size(103, 37)
        Me.UploadImg.TabIndex = 18
        Me.UploadImg.Text = "SELECT IMAGE"
        Me.UploadImg.UseVisualStyleBackColor = False
        '
        'profpiccontainer
        '
        Me.profpiccontainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.profpiccontainer.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.profpiccontainer.Image = CType(resources.GetObject("profpiccontainer.Image"), System.Drawing.Image)
        Me.profpiccontainer.Location = New System.Drawing.Point(291, 23)
        Me.profpiccontainer.Name = "profpiccontainer"
        Me.profpiccontainer.Size = New System.Drawing.Size(198, 158)
        Me.profpiccontainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profpiccontainer.TabIndex = 4
        Me.profpiccontainer.TabStop = False
        Me.profpiccontainer.UseWaitCursor = True
        '
        'opf
        '
        Me.opf.FileName = "opf"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(384, 473)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 22)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(492, 473)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 22)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(380, 446)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 21)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Gender*"
        '
        'DateOfBirth
        '
        Me.DateOfBirth.CustomFormat = "yyyy-MM-dd"
        Me.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateOfBirth.Location = New System.Drawing.Point(384, 533)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(214, 20)
        Me.DateOfBirth.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(380, 502)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Date of Birth*"
        '
        'Question_Box
        '
        Me.Question_Box.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Question_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Question_Box.ForeColor = System.Drawing.Color.White
        Me.Question_Box.FormattingEnabled = True
        Me.Question_Box.Items.AddRange(New Object() {"What favorite food?", "What is your favorite color?", "What is your pet's name?", "What is your blood type?", "What is your favorite country?"})
        Me.Question_Box.Location = New System.Drawing.Point(641, 478)
        Me.Question_Box.Name = "Question_Box"
        Me.Question_Box.Size = New System.Drawing.Size(259, 21)
        Me.Question_Box.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(637, 454)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Question*"
        '
        'Answer_Box
        '
        Me.Answer_Box.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Answer_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer_Box.ForeColor = System.Drawing.Color.White
        Me.Answer_Box.Location = New System.Drawing.Point(641, 532)
        Me.Answer_Box.Multiline = True
        Me.Answer_Box.Name = "Answer_Box"
        Me.Answer_Box.Size = New System.Drawing.Size(259, 33)
        Me.Answer_Box.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(637, 508)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 21)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Answer*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(532, 624)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Reset"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(525, 569)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(414, 623)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Create User"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(417, 569)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'SECTION
        '
        Me.SECTION.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SECTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SECTION.ForeColor = System.Drawing.Color.White
        Me.SECTION.Location = New System.Drawing.Point(384, 335)
        Me.SECTION.Multiline = True
        Me.SECTION.Name = "SECTION"
        Me.SECTION.Size = New System.Drawing.Size(214, 33)
        Me.SECTION.TabIndex = 8
        '
        'CONTACT
        '
        Me.CONTACT.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.CONTACT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTACT.ForeColor = System.Drawing.Color.White
        Me.CONTACT.Location = New System.Drawing.Point(59, 532)
        Me.CONTACT.Multiline = True
        Me.CONTACT.Name = "CONTACT"
        Me.CONTACT.Size = New System.Drawing.Size(290, 33)
        Me.CONTACT.TabIndex = 6
        '
        'GRADELVL
        '
        Me.GRADELVL.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.GRADELVL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GRADELVL.ForeColor = System.Drawing.Color.White
        Me.GRADELVL.FormattingEnabled = True
        Me.GRADELVL.Items.AddRange(New Object() {"Grade 7", "Grade 8", "Grade 9", "Grade 10", "Grade 11", "Grade 12"})
        Me.GRADELVL.Location = New System.Drawing.Point(384, 407)
        Me.GRADELVL.Name = "GRADELVL"
        Me.GRADELVL.Size = New System.Drawing.Size(214, 21)
        Me.GRADELVL.TabIndex = 9
        '
        'USER_NAME
        '
        Me.USER_NAME.AutoSize = True
        Me.USER_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USER_NAME.Location = New System.Drawing.Point(129, 76)
        Me.USER_NAME.Name = "USER_NAME"
        Me.USER_NAME.Size = New System.Drawing.Size(76, 20)
        Me.USER_NAME.TabIndex = 0
        Me.USER_NAME.Text = "[No Data]"
        '
        'GeneratedNo
        '
        Me.GeneratedNo.AutoSize = True
        Me.GeneratedNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratedNo.Location = New System.Drawing.Point(906, 71)
        Me.GeneratedNo.Name = "GeneratedNo"
        Me.GeneratedNo.Size = New System.Drawing.Size(23, 25)
        Me.GeneratedNo.TabIndex = 16
        Me.GeneratedNo.Text = "#"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(380, 310)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 21)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Section*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(797, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 21)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Borrower ID:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(55, 508)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 21)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Contact Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(380, 383)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Grade Level*"
        '
        'QR_CONTAINER
        '
        Me.QR_CONTAINER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QR_CONTAINER.Image = CType(resources.GetObject("QR_CONTAINER.Image"), System.Drawing.Image)
        Me.QR_CONTAINER.Location = New System.Drawing.Point(584, 23)
        Me.QR_CONTAINER.Name = "QR_CONTAINER"
        Me.QR_CONTAINER.Size = New System.Drawing.Size(165, 165)
        Me.QR_CONTAINER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QR_CONTAINER.TabIndex = 14
        Me.QR_CONTAINER.TabStop = False
        '
        'UPLOAD_QR
        '
        Me.UPLOAD_QR.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.UPLOAD_QR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UPLOAD_QR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPLOAD_QR.Location = New System.Drawing.Point(611, 194)
        Me.UPLOAD_QR.Name = "UPLOAD_QR"
        Me.UPLOAD_QR.Size = New System.Drawing.Size(118, 30)
        Me.UPLOAD_QR.TabIndex = 19
        Me.UPLOAD_QR.Text = "SELECT QR CODE"
        Me.UPLOAD_QR.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label21.Location = New System.Drawing.Point(637, 380)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(148, 21)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Retype Password*"
        '
        'RetypePASS
        '
        Me.RetypePASS.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.RetypePASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetypePASS.ForeColor = System.Drawing.Color.White
        Me.RetypePASS.Location = New System.Drawing.Point(641, 404)
        Me.RetypePASS.Multiline = True
        Me.RetypePASS.Name = "RetypePASS"
        Me.RetypePASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RetypePASS.Size = New System.Drawing.Size(259, 37)
        Me.RetypePASS.TabIndex = 15
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(986, 669)
        Me.ShapeContainer1.TabIndex = 17
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.BorderWidth = 3
        Me.RectangleShape1.CornerRadius = 8
        Me.RectangleShape1.Location = New System.Drawing.Point(28, 101)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(932, 549)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(39, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(637, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID / LRN*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(55, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Last Name*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(55, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "E-mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(55, 444)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Address*"
        '
        'USERLVL_BOX
        '
        Me.USERLVL_BOX.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.USERLVL_BOX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.USERLVL_BOX.ForeColor = System.Drawing.Color.White
        Me.USERLVL_BOX.FormattingEnabled = True
        Me.USERLVL_BOX.Items.AddRange(New Object() {"LIBRARY USER", "LIBRARIAN"})
        Me.USERLVL_BOX.Location = New System.Drawing.Point(384, 270)
        Me.USERLVL_BOX.Name = "USERLVL_BOX"
        Me.USERLVL_BOX.Size = New System.Drawing.Size(223, 21)
        Me.USERLVL_BOX.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(380, 245)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 21)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Register As*"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(936, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(212, 244)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 21)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Middle Name"
        '
        'MNAME
        '
        Me.MNAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.MNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNAME.ForeColor = System.Drawing.Color.White
        Me.MNAME.Location = New System.Drawing.Point(216, 270)
        Me.MNAME.Multiline = True
        Me.MNAME.Name = "MNAME"
        Me.MNAME.Size = New System.Drawing.Size(133, 36)
        Me.MNAME.TabIndex = 2
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(986, 669)
        Me.Controls.Add(Me.MNAME)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.USERLVL_BOX)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LRN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.RetypePASS)
        Me.Controls.Add(Me.EMAIL)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.ADDRESS)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PASS)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.DateOfBirth)
        Me.Controls.Add(Me.SECTION)
        Me.Controls.Add(Me.Answer_Box)
        Me.Controls.Add(Me.CONTACT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GRADELVL)
        Me.Controls.Add(Me.Question_Box)
        Me.Controls.Add(Me.USER_NAME)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GeneratedNo)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LNAME)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.FNAME)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.UPLOAD_QR)
        Me.Controls.Add(Me.QR_CONTAINER)
        Me.Controls.Add(Me.profpiccontainer)
        Me.Controls.Add(Me.UploadImg)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrationForm"
        CType(Me.profpiccontainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QR_CONTAINER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LRN As TextBox
    Friend WithEvents FNAME As TextBox
    Friend WithEvents LNAME As TextBox
    Friend WithEvents EMAIL As TextBox
    Friend WithEvents ADDRESS As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PASS As TextBox
    Friend WithEvents UploadImg As Button
    Friend WithEvents profpiccontainer As PictureBox
    Friend WithEvents opf As OpenFileDialog
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents DateOfBirth As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Question_Box As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Answer_Box As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents QR_CONTAINER As PictureBox
    Friend WithEvents UPLOAD_QR As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents USER_NAME As Label
    Friend WithEvents GRADELVL As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CONTACT As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents SECTION As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GeneratedNo As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents RetypePASS As TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents USERLVL_BOX As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents MNAME As TextBox
End Class
