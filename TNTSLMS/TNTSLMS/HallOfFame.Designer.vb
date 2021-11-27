<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HallOfFame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HallOfFame))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.book2nd = New System.Windows.Forms.Label()
        Me.book1st = New System.Windows.Forms.Label()
        Me.book3rd = New System.Windows.Forms.Label()
        Me.book2nd_no = New System.Windows.Forms.Label()
        Me.book1st_no = New System.Windows.Forms.Label()
        Me.book3rd_no = New System.Windows.Forms.Label()
        Me.INVISIBLE_TABLE = New System.Windows.Forms.DataGridView()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVISIBLE_TABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(46, 201)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(46, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(173, 167)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(46, 374)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(173, 167)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'book2nd
        '
        Me.book2nd.AutoSize = True
        Me.book2nd.BackColor = System.Drawing.Color.Transparent
        Me.book2nd.Font = New System.Drawing.Font("Franklin Gothic Demi", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book2nd.Location = New System.Drawing.Point(234, 222)
        Me.book2nd.Name = "book2nd"
        Me.book2nd.Size = New System.Drawing.Size(111, 37)
        Me.book2nd.TabIndex = 3
        Me.book2nd.Text = "Label1"
        '
        'book1st
        '
        Me.book1st.AutoSize = True
        Me.book1st.BackColor = System.Drawing.Color.Transparent
        Me.book1st.Font = New System.Drawing.Font("Franklin Gothic Demi", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book1st.Location = New System.Drawing.Point(234, 43)
        Me.book1st.Name = "book1st"
        Me.book1st.Size = New System.Drawing.Size(111, 37)
        Me.book1st.TabIndex = 4
        Me.book1st.Text = "Label2"
        '
        'book3rd
        '
        Me.book3rd.AutoSize = True
        Me.book3rd.BackColor = System.Drawing.Color.Transparent
        Me.book3rd.Font = New System.Drawing.Font("Franklin Gothic Demi", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book3rd.Location = New System.Drawing.Point(234, 384)
        Me.book3rd.Name = "book3rd"
        Me.book3rd.Size = New System.Drawing.Size(111, 37)
        Me.book3rd.TabIndex = 5
        Me.book3rd.Text = "Label3"
        '
        'book2nd_no
        '
        Me.book2nd_no.AutoSize = True
        Me.book2nd_no.BackColor = System.Drawing.Color.Transparent
        Me.book2nd_no.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book2nd_no.Location = New System.Drawing.Point(237, 272)
        Me.book2nd_no.Name = "book2nd_no"
        Me.book2nd_no.Size = New System.Drawing.Size(56, 21)
        Me.book2nd_no.TabIndex = 6
        Me.book2nd_no.Text = "Label4"
        '
        'book1st_no
        '
        Me.book1st_no.AutoSize = True
        Me.book1st_no.BackColor = System.Drawing.Color.Transparent
        Me.book1st_no.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book1st_no.Location = New System.Drawing.Point(237, 95)
        Me.book1st_no.Name = "book1st_no"
        Me.book1st_no.Size = New System.Drawing.Size(56, 21)
        Me.book1st_no.TabIndex = 7
        Me.book1st_no.Text = "Label5"
        '
        'book3rd_no
        '
        Me.book3rd_no.AutoSize = True
        Me.book3rd_no.BackColor = System.Drawing.Color.Transparent
        Me.book3rd_no.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.book3rd_no.Location = New System.Drawing.Point(237, 436)
        Me.book3rd_no.Name = "book3rd_no"
        Me.book3rd_no.Size = New System.Drawing.Size(56, 21)
        Me.book3rd_no.TabIndex = 8
        Me.book3rd_no.Text = "Label6"
        '
        'INVISIBLE_TABLE
        '
        Me.INVISIBLE_TABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.INVISIBLE_TABLE.Location = New System.Drawing.Point(813, 514)
        Me.INVISIBLE_TABLE.Name = "INVISIBLE_TABLE"
        Me.INVISIBLE_TABLE.Size = New System.Drawing.Size(37, 38)
        Me.INVISIBLE_TABLE.TabIndex = 9
        Me.INVISIBLE_TABLE.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(813, 28)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 150
        '
        'HallOfFame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(877, 577)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.INVISIBLE_TABLE)
        Me.Controls.Add(Me.book3rd_no)
        Me.Controls.Add(Me.book1st_no)
        Me.Controls.Add(Me.book2nd_no)
        Me.Controls.Add(Me.book3rd)
        Me.Controls.Add(Me.book1st)
        Me.Controls.Add(Me.book2nd)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HallOfFame"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HallOfFame"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVISIBLE_TABLE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents book2nd As Label
    Friend WithEvents book1st As Label
    Friend WithEvents book3rd As Label
    Friend WithEvents book2nd_no As Label
    Friend WithEvents book1st_no As Label
    Friend WithEvents book3rd_no As Label
    Friend WithEvents INVISIBLE_TABLE As DataGridView
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
