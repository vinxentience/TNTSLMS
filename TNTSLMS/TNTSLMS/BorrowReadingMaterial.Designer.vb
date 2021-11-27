<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowReadingMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowReadingMaterial))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ISBN_NO = New System.Windows.Forms.TextBox()
        Me.STUD_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UNAME = New System.Windows.Forms.TextBox()
        Me.STUD_NAME = New System.Windows.Forms.TextBox()
        Me.BorrowNo = New System.Windows.Forms.Label()
        Me.STUD_LEVEL = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.counterborrow = New System.Windows.Forms.TextBox()
        Me.status_show = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PUBLISHED_YEAR = New System.Windows.Forms.TextBox()
        Me.GENRE_TYPE = New System.Windows.Forms.TextBox()
        Me.VOLUME = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AUTHOR = New System.Windows.Forms.TextBox()
        Me.BOOK_NAME = New System.Windows.Forms.TextBox()
        Me.borrowing_dgv = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.borrowing_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(785, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 24)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Auto-fill (Book)"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(624, 49)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(295, 325)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(480, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 24)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Auto-fill (User)"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(317, 50)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(295, 324)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(176, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 25)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Student Info"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(295, 319)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "ISBN"
        '
        'ISBN_NO
        '
        Me.ISBN_NO.BackColor = System.Drawing.Color.White
        Me.ISBN_NO.Enabled = False
        Me.ISBN_NO.Location = New System.Drawing.Point(85, 264)
        Me.ISBN_NO.Name = "ISBN_NO"
        Me.ISBN_NO.Size = New System.Drawing.Size(149, 20)
        Me.ISBN_NO.TabIndex = 20
        '
        'STUD_ID
        '
        Me.STUD_ID.Location = New System.Drawing.Point(85, 200)
        Me.STUD_ID.Name = "STUD_ID"
        Me.STUD_ID.Size = New System.Drawing.Size(149, 20)
        Me.STUD_ID.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(110, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Student ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(364, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Grade Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(369, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(394, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Name"
        '
        'UNAME
        '
        Me.UNAME.Enabled = False
        Me.UNAME.Location = New System.Drawing.Point(435, 181)
        Me.UNAME.Name = "UNAME"
        Me.UNAME.Size = New System.Drawing.Size(119, 20)
        Me.UNAME.TabIndex = 24
        '
        'STUD_NAME
        '
        Me.STUD_NAME.Enabled = False
        Me.STUD_NAME.Location = New System.Drawing.Point(435, 134)
        Me.STUD_NAME.Name = "STUD_NAME"
        Me.STUD_NAME.Size = New System.Drawing.Size(119, 20)
        Me.STUD_NAME.TabIndex = 25
        '
        'BorrowNo
        '
        Me.BorrowNo.AutoSize = True
        Me.BorrowNo.BackColor = System.Drawing.Color.White
        Me.BorrowNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowNo.Location = New System.Drawing.Point(484, 284)
        Me.BorrowNo.Name = "BorrowNo"
        Me.BorrowNo.Size = New System.Drawing.Size(105, 25)
        Me.BorrowNo.TabIndex = 31
        Me.BorrowNo.Text = "[No Value]"
        '
        'STUD_LEVEL
        '
        Me.STUD_LEVEL.Enabled = False
        Me.STUD_LEVEL.Location = New System.Drawing.Point(435, 226)
        Me.STUD_LEVEL.Name = "STUD_LEVEL"
        Me.STUD_LEVEL.Size = New System.Drawing.Size(119, 20)
        Me.STUD_LEVEL.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(363, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 25)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Borrower No."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(786, 225)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 13)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Borrow Counter"
        '
        'counterborrow
        '
        Me.counterborrow.Enabled = False
        Me.counterborrow.Location = New System.Drawing.Point(787, 241)
        Me.counterborrow.Name = "counterborrow"
        Me.counterborrow.Size = New System.Drawing.Size(119, 20)
        Me.counterborrow.TabIndex = 53
        '
        'status_show
        '
        Me.status_show.AutoSize = True
        Me.status_show.BackColor = System.Drawing.Color.White
        Me.status_show.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_show.ForeColor = System.Drawing.Color.Red
        Me.status_show.Location = New System.Drawing.Point(750, 274)
        Me.status_show.Name = "status_show"
        Me.status_show.Size = New System.Drawing.Size(62, 13)
        Me.status_show.TabIndex = 52
        Me.status_show.Text = "[No Data]"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(765, 350)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 51
        Me.Label21.Text = "Borrow"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(756, 298)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 50
        Me.PictureBox7.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(789, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Volume"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(653, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Published"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(789, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Genre"
        '
        'PUBLISHED_YEAR
        '
        Me.PUBLISHED_YEAR.Enabled = False
        Me.PUBLISHED_YEAR.Location = New System.Drawing.Point(654, 241)
        Me.PUBLISHED_YEAR.Name = "PUBLISHED_YEAR"
        Me.PUBLISHED_YEAR.Size = New System.Drawing.Size(119, 20)
        Me.PUBLISHED_YEAR.TabIndex = 40
        '
        'GENRE_TYPE
        '
        Me.GENRE_TYPE.Enabled = False
        Me.GENRE_TYPE.Location = New System.Drawing.Point(787, 197)
        Me.GENRE_TYPE.Name = "GENRE_TYPE"
        Me.GENRE_TYPE.Size = New System.Drawing.Size(119, 20)
        Me.GENRE_TYPE.TabIndex = 41
        '
        'VOLUME
        '
        Me.VOLUME.Enabled = False
        Me.VOLUME.Location = New System.Drawing.Point(787, 146)
        Me.VOLUME.Name = "VOLUME"
        Me.VOLUME.Size = New System.Drawing.Size(119, 20)
        Me.VOLUME.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(653, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Author"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(653, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Book Name"
        '
        'AUTHOR
        '
        Me.AUTHOR.Enabled = False
        Me.AUTHOR.Location = New System.Drawing.Point(654, 197)
        Me.AUTHOR.Name = "AUTHOR"
        Me.AUTHOR.Size = New System.Drawing.Size(119, 20)
        Me.AUTHOR.TabIndex = 42
        '
        'BOOK_NAME
        '
        Me.BOOK_NAME.Enabled = False
        Me.BOOK_NAME.Location = New System.Drawing.Point(657, 146)
        Me.BOOK_NAME.Name = "BOOK_NAME"
        Me.BOOK_NAME.Size = New System.Drawing.Size(119, 20)
        Me.BOOK_NAME.TabIndex = 43
        '
        'borrowing_dgv
        '
        Me.borrowing_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.borrowing_dgv.Location = New System.Drawing.Point(94, 293)
        Me.borrowing_dgv.Name = "borrowing_dgv"
        Me.borrowing_dgv.Size = New System.Drawing.Size(120, 74)
        Me.borrowing_dgv.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(863, 316)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Label15"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(861, 333)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Label16"
        Me.Label16.Visible = False
        '
        'BorrowReadingMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.counterborrow)
        Me.Controls.Add(Me.status_show)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PUBLISHED_YEAR)
        Me.Controls.Add(Me.GENRE_TYPE)
        Me.Controls.Add(Me.VOLUME)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AUTHOR)
        Me.Controls.Add(Me.BOOK_NAME)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UNAME)
        Me.Controls.Add(Me.STUD_NAME)
        Me.Controls.Add(Me.BorrowNo)
        Me.Controls.Add(Me.STUD_LEVEL)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ISBN_NO)
        Me.Controls.Add(Me.STUD_ID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.borrowing_dgv)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Name = "BorrowReadingMaterial"
        Me.Size = New System.Drawing.Size(940, 426)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.borrowing_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ISBN_NO As TextBox
    Friend WithEvents STUD_ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UNAME As TextBox
    Friend WithEvents STUD_NAME As TextBox
    Friend WithEvents BorrowNo As Label
    Friend WithEvents STUD_LEVEL As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents counterborrow As TextBox
    Friend WithEvents status_show As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PUBLISHED_YEAR As TextBox
    Friend WithEvents GENRE_TYPE As TextBox
    Friend WithEvents VOLUME As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AUTHOR As TextBox
    Friend WithEvents BOOK_NAME As TextBox
    Friend WithEvents borrowing_dgv As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
