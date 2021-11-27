<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageBookReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageBookReturn))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.B_NAME = New System.Windows.Forms.Label()
        Me.D_DATE = New System.Windows.Forms.Label()
        Me.B_DATE = New System.Windows.Forms.Label()
        Me.B_ID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.STUD_ID_SEARCH = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ISBN_ID = New System.Windows.Forms.Label()
        Me.RETURN_PANEL = New System.Windows.Forms.DataGridView()
        Me.BORROW_COUNT = New System.Windows.Forms.Label()
        Me.borrowing_dgv = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RETURN_PANEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.borrowing_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(164, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Return"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(155, 325)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'B_NAME
        '
        Me.B_NAME.AutoSize = True
        Me.B_NAME.BackColor = System.Drawing.Color.White
        Me.B_NAME.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_NAME.Location = New System.Drawing.Point(136, 272)
        Me.B_NAME.Name = "B_NAME"
        Me.B_NAME.Size = New System.Drawing.Size(68, 17)
        Me.B_NAME.TabIndex = 17
        Me.B_NAME.Text = "[No Data]"
        '
        'D_DATE
        '
        Me.D_DATE.AutoSize = True
        Me.D_DATE.BackColor = System.Drawing.Color.White
        Me.D_DATE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_DATE.Location = New System.Drawing.Point(136, 237)
        Me.D_DATE.Name = "D_DATE"
        Me.D_DATE.Size = New System.Drawing.Size(68, 17)
        Me.D_DATE.TabIndex = 18
        Me.D_DATE.Text = "[No Data]"
        '
        'B_DATE
        '
        Me.B_DATE.AutoSize = True
        Me.B_DATE.BackColor = System.Drawing.Color.White
        Me.B_DATE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_DATE.Location = New System.Drawing.Point(136, 200)
        Me.B_DATE.Name = "B_DATE"
        Me.B_DATE.Size = New System.Drawing.Size(68, 17)
        Me.B_DATE.TabIndex = 19
        Me.B_DATE.Text = "[No Data]"
        '
        'B_ID
        '
        Me.B_ID.AutoSize = True
        Me.B_ID.BackColor = System.Drawing.Color.White
        Me.B_ID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_ID.Location = New System.Drawing.Point(136, 166)
        Me.B_ID.Name = "B_ID"
        Me.B_ID.Size = New System.Drawing.Size(68, 17)
        Me.B_ID.TabIndex = 20
        Me.B_ID.Text = "[No Data]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(87, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ISBN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Book Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Due Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Borrow Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Borrower ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "User ID / Student ID"
        '
        'STUD_ID_SEARCH
        '
        Me.STUD_ID_SEARCH.Location = New System.Drawing.Point(75, 100)
        Me.STUD_ID_SEARCH.Name = "STUD_ID_SEARCH"
        Me.STUD_ID_SEARCH.Size = New System.Drawing.Size(200, 20)
        Me.STUD_ID_SEARCH.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(25, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(293, 389)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'ISBN_ID
        '
        Me.ISBN_ID.AutoSize = True
        Me.ISBN_ID.BackColor = System.Drawing.Color.White
        Me.ISBN_ID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBN_ID.Location = New System.Drawing.Point(136, 140)
        Me.ISBN_ID.Name = "ISBN_ID"
        Me.ISBN_ID.Size = New System.Drawing.Size(68, 17)
        Me.ISBN_ID.TabIndex = 24
        Me.ISBN_ID.Text = "[No Data]"
        '
        'RETURN_PANEL
        '
        Me.RETURN_PANEL.AllowUserToAddRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RETURN_PANEL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.RETURN_PANEL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RETURN_PANEL.DefaultCellStyle = DataGridViewCellStyle4
        Me.RETURN_PANEL.Location = New System.Drawing.Point(342, 0)
        Me.RETURN_PANEL.Name = "RETURN_PANEL"
        Me.RETURN_PANEL.Size = New System.Drawing.Size(595, 423)
        Me.RETURN_PANEL.TabIndex = 25
        '
        'BORROW_COUNT
        '
        Me.BORROW_COUNT.AutoSize = True
        Me.BORROW_COUNT.Location = New System.Drawing.Point(259, 360)
        Me.BORROW_COUNT.Name = "BORROW_COUNT"
        Me.BORROW_COUNT.Size = New System.Drawing.Size(39, 13)
        Me.BORROW_COUNT.TabIndex = 26
        Me.BORROW_COUNT.Text = "Label7"
        '
        'borrowing_dgv
        '
        Me.borrowing_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.borrowing_dgv.Location = New System.Drawing.Point(75, 337)
        Me.borrowing_dgv.Name = "borrowing_dgv"
        Me.borrowing_dgv.Size = New System.Drawing.Size(58, 36)
        Me.borrowing_dgv.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(187, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 21)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Return Book"
        '
        'ManageBookReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BORROW_COUNT)
        Me.Controls.Add(Me.RETURN_PANEL)
        Me.Controls.Add(Me.ISBN_ID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.B_NAME)
        Me.Controls.Add(Me.D_DATE)
        Me.Controls.Add(Me.B_DATE)
        Me.Controls.Add(Me.B_ID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.STUD_ID_SEARCH)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.borrowing_dgv)
        Me.Name = "ManageBookReturn"
        Me.Size = New System.Drawing.Size(940, 426)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RETURN_PANEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.borrowing_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents B_NAME As Label
    Friend WithEvents D_DATE As Label
    Friend WithEvents B_DATE As Label
    Friend WithEvents B_ID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents STUD_ID_SEARCH As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ISBN_ID As Label
    Friend WithEvents RETURN_PANEL As DataGridView
    Friend WithEvents BORROW_COUNT As Label
    Friend WithEvents borrowing_dgv As DataGridView
    Friend WithEvents Label7 As Label
End Class
