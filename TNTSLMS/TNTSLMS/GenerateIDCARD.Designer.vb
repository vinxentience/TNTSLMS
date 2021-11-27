<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenerateIDCARD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateIDCARD))
        Me.PROFILEPIC = New System.Windows.Forms.PictureBox()
        Me.FULLNAME = New System.Windows.Forms.Label()
        Me.USRNM = New System.Windows.Forms.Label()
        Me.STUDENT_LRN = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BRRWRNO = New System.Windows.Forms.Label()
        Me.QRPIC = New System.Windows.Forms.PictureBox()
        Me.SCTN = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GRDLVL = New System.Windows.Forms.Label()
        Me.ADDRSS = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.PROFILEPIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRPIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PROFILEPIC
        '
        Me.PROFILEPIC.Location = New System.Drawing.Point(40, 145)
        Me.PROFILEPIC.Name = "PROFILEPIC"
        Me.PROFILEPIC.Size = New System.Drawing.Size(96, 91)
        Me.PROFILEPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PROFILEPIC.TabIndex = 0
        Me.PROFILEPIC.TabStop = False
        '
        'FULLNAME
        '
        Me.FULLNAME.AutoSize = True
        Me.FULLNAME.BackColor = System.Drawing.Color.Transparent
        Me.FULLNAME.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FULLNAME.Location = New System.Drawing.Point(211, 180)
        Me.FULLNAME.Name = "FULLNAME"
        Me.FULLNAME.Size = New System.Drawing.Size(38, 9)
        Me.FULLNAME.TabIndex = 1
        Me.FULLNAME.Text = "[No Data]"
        '
        'USRNM
        '
        Me.USRNM.AutoSize = True
        Me.USRNM.BackColor = System.Drawing.Color.Transparent
        Me.USRNM.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USRNM.Location = New System.Drawing.Point(57, 248)
        Me.USRNM.Name = "USRNM"
        Me.USRNM.Size = New System.Drawing.Size(38, 9)
        Me.USRNM.TabIndex = 1
        Me.USRNM.Text = "[No Data]"
        '
        'STUDENT_LRN
        '
        Me.STUDENT_LRN.AutoSize = True
        Me.STUDENT_LRN.BackColor = System.Drawing.Color.Transparent
        Me.STUDENT_LRN.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STUDENT_LRN.Location = New System.Drawing.Point(211, 163)
        Me.STUDENT_LRN.Name = "STUDENT_LRN"
        Me.STUDENT_LRN.Size = New System.Drawing.Size(38, 9)
        Me.STUDENT_LRN.TabIndex = 1
        Me.STUDENT_LRN.Text = "[No Data]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 9)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LRN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(160, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 9)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Grade Level:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(304, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 9)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Borrower No"
        '
        'BRRWRNO
        '
        Me.BRRWRNO.AutoSize = True
        Me.BRRWRNO.BackColor = System.Drawing.Color.Transparent
        Me.BRRWRNO.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRRWRNO.Location = New System.Drawing.Point(308, 248)
        Me.BRRWRNO.Name = "BRRWRNO"
        Me.BRRWRNO.Size = New System.Drawing.Size(38, 9)
        Me.BRRWRNO.TabIndex = 1
        Me.BRRWRNO.Text = "[No Data]"
        '
        'QRPIC
        '
        Me.QRPIC.BackColor = System.Drawing.Color.Transparent
        Me.QRPIC.Location = New System.Drawing.Point(286, 145)
        Me.QRPIC.Name = "QRPIC"
        Me.QRPIC.Size = New System.Drawing.Size(90, 90)
        Me.QRPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QRPIC.TabIndex = 0
        Me.QRPIC.TabStop = False
        '
        'SCTN
        '
        Me.SCTN.AutoSize = True
        Me.SCTN.BackColor = System.Drawing.Color.Transparent
        Me.SCTN.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCTN.Location = New System.Drawing.Point(211, 219)
        Me.SCTN.Name = "SCTN"
        Me.SCTN.Size = New System.Drawing.Size(38, 9)
        Me.SCTN.TabIndex = 1
        Me.SCTN.Text = "[No Data]"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(56, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 9)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "User Name"
        '
        'GRDLVL
        '
        Me.GRDLVL.AutoSize = True
        Me.GRDLVL.BackColor = System.Drawing.Color.Transparent
        Me.GRDLVL.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRDLVL.Location = New System.Drawing.Point(211, 199)
        Me.GRDLVL.Name = "GRDLVL"
        Me.GRDLVL.Size = New System.Drawing.Size(38, 9)
        Me.GRDLVL.TabIndex = 1
        Me.GRDLVL.Text = "[No Data]"
        '
        'ADDRSS
        '
        Me.ADDRSS.AutoSize = True
        Me.ADDRSS.BackColor = System.Drawing.Color.Transparent
        Me.ADDRSS.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDRSS.Location = New System.Drawing.Point(211, 234)
        Me.ADDRSS.Name = "ADDRSS"
        Me.ADDRSS.Size = New System.Drawing.Size(38, 9)
        Me.ADDRSS.TabIndex = 1
        Me.ADDRSS.Text = "[No Data]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(170, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 9)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Full Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(178, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 9)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Section:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(175, 234)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 9)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Address:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(389, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(13, 290)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(87, 13)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Print Library Card"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'GenerateIDCARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 314)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.FULLNAME)
        Me.Controls.Add(Me.ADDRSS)
        Me.Controls.Add(Me.SCTN)
        Me.Controls.Add(Me.GRDLVL)
        Me.Controls.Add(Me.STUDENT_LRN)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.USRNM)
        Me.Controls.Add(Me.BRRWRNO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QRPIC)
        Me.Controls.Add(Me.PROFILEPIC)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GenerateIDCARD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenerateIDCARD"
        CType(Me.PROFILEPIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRPIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PROFILEPIC As PictureBox
    Friend WithEvents FULLNAME As Label
    Friend WithEvents USRNM As Label
    Friend WithEvents STUDENT_LRN As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BRRWRNO As Label
    Friend WithEvents QRPIC As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ADDRSS As Label
    Friend WithEvents SCTN As Label
    Friend WithEvents GRDLVL As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
