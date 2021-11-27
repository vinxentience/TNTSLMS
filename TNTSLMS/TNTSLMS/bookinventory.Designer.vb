<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookinventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookinventory))
        Me.Book_Condition = New System.Windows.Forms.ComboBox()
        Me.ISBN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_NAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AUTHOR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GENRE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VOLUME = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Y_PUBLISHED = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.condition = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Book_Condition
        '
        Me.Book_Condition.FormattingEnabled = True
        Me.Book_Condition.Items.AddRange(New Object() {"New Book", "Used Book In Good Condition", "Used Book In Fair Condition", "Used Book In Poor Condition"})
        Me.Book_Condition.Location = New System.Drawing.Point(372, 201)
        Me.Book_Condition.Name = "Book_Condition"
        Me.Book_Condition.Size = New System.Drawing.Size(114, 21)
        Me.Book_Condition.TabIndex = 6
        '
        'ISBN
        '
        Me.ISBN.Location = New System.Drawing.Point(167, 113)
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(246, 20)
        Me.ISBN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "International Standard Book Number (ISBN)"
        '
        'B_NAME
        '
        Me.B_NAME.Location = New System.Drawing.Point(135, 163)
        Me.B_NAME.Name = "B_NAME"
        Me.B_NAME.Size = New System.Drawing.Size(100, 20)
        Me.B_NAME.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Name"
        '
        'AUTHOR
        '
        Me.AUTHOR.Location = New System.Drawing.Point(135, 201)
        Me.AUTHOR.Name = "AUTHOR"
        Me.AUTHOR.Size = New System.Drawing.Size(100, 20)
        Me.AUTHOR.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Author"
        '
        'GENRE
        '
        Me.GENRE.Location = New System.Drawing.Point(369, 243)
        Me.GENRE.Name = "GENRE"
        Me.GENRE.Size = New System.Drawing.Size(114, 20)
        Me.GENRE.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(306, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Genre"
        '
        'VOLUME
        '
        Me.VOLUME.Location = New System.Drawing.Point(135, 244)
        Me.VOLUME.Name = "VOLUME"
        Me.VOLUME.Size = New System.Drawing.Size(100, 20)
        Me.VOLUME.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Volume"
        '
        'Y_PUBLISHED
        '
        Me.Y_PUBLISHED.Location = New System.Drawing.Point(371, 163)
        Me.Y_PUBLISHED.Name = "Y_PUBLISHED"
        Me.Y_PUBLISHED.Size = New System.Drawing.Size(115, 20)
        Me.Y_PUBLISHED.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(241, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Year Published"
        '
        'condition
        '
        Me.condition.AutoSize = True
        Me.condition.BackColor = System.Drawing.Color.Transparent
        Me.condition.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.condition.Location = New System.Drawing.Point(278, 198)
        Me.condition.Name = "condition"
        Me.condition.Size = New System.Drawing.Size(87, 21)
        Me.condition.TabIndex = 4
        Me.condition.Text = "Condition"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(292, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Add Reading Material"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(264, 340)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(269, 381)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Add"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(495, 52)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(236, 285)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(96, 20)
        Me.Quantity.TabIndex = 13
        Me.Quantity.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(162, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Quantity:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 21)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "+"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(288, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 21)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "-"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bookinventory
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(545, 410)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.condition)
        Me.Controls.Add(Me.Book_Condition)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Y_PUBLISHED)
        Me.Controls.Add(Me.VOLUME)
        Me.Controls.Add(Me.GENRE)
        Me.Controls.Add(Me.AUTHOR)
        Me.Controls.Add(Me.B_NAME)
        Me.Controls.Add(Me.ISBN)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bookinventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eLIBHUB"
        Me.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ISBN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents B_NAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AUTHOR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GENRE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents VOLUME As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Y_PUBLISHED As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents condition As Label
    Friend WithEvents Book_Condition As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Quantity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
