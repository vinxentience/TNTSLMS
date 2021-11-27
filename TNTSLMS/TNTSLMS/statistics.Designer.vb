<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class statistics
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BookRank = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.genderrank = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.statTable_bookcount = New System.Windows.Forms.DataGridView()
        Me.statTable_gender_Male = New System.Windows.Forms.DataGridView()
        Me.statTable_gender_Female = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.book_count = New System.Windows.Forms.DataGridView()
        Me.numberofbooks = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.BookRank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.genderrank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statTable_bookcount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statTable_gender_Male, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statTable_gender_Female, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.book_count, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookRank
        '
        ChartArea7.Name = "ChartArea1"
        Me.BookRank.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        Me.BookRank.Legends.Add(Legend7)
        Me.BookRank.Location = New System.Drawing.Point(29, 102)
        Me.BookRank.Name = "BookRank"
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Most Borrowed Books"
        Me.BookRank.Series.Add(Series7)
        Me.BookRank.Size = New System.Drawing.Size(520, 300)
        Me.BookRank.TabIndex = 0
        Me.BookRank.Text = "Chart1"
        '
        'genderrank
        '
        ChartArea8.Name = "ChartArea1"
        Me.genderrank.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        Me.genderrank.Legends.Add(Legend8)
        Me.genderrank.Location = New System.Drawing.Point(568, 102)
        Me.genderrank.Name = "genderrank"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series8.IsValueShownAsLabel = True
        Series8.Legend = "Legend1"
        Series8.Name = "Series2"
        Me.genderrank.Series.Add(Series8)
        Me.genderrank.Size = New System.Drawing.Size(428, 300)
        Me.genderrank.TabIndex = 1
        Me.genderrank.Text = "Chart2"
        '
        'statTable_bookcount
        '
        Me.statTable_bookcount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.statTable_bookcount.Location = New System.Drawing.Point(395, 192)
        Me.statTable_bookcount.Name = "statTable_bookcount"
        Me.statTable_bookcount.Size = New System.Drawing.Size(138, 81)
        Me.statTable_bookcount.TabIndex = 4
        '
        'statTable_gender_Male
        '
        Me.statTable_gender_Male.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.statTable_gender_Male.Location = New System.Drawing.Point(869, 204)
        Me.statTable_gender_Male.Name = "statTable_gender_Male"
        Me.statTable_gender_Male.Size = New System.Drawing.Size(93, 59)
        Me.statTable_gender_Male.TabIndex = 5
        '
        'statTable_gender_Female
        '
        Me.statTable_gender_Female.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.statTable_gender_Female.Location = New System.Drawing.Point(580, 204)
        Me.statTable_gender_Female.Name = "statTable_gender_Female"
        Me.statTable_gender_Female.Size = New System.Drawing.Size(93, 59)
        Me.statTable_gender_Female.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(387, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 44)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Library Statistics"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1018, 522)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape2.FillColor = System.Drawing.Color.RoyalBlue
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(491, 409)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(506, 88)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape1.FillColor = System.Drawing.Color.RoyalBlue
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(29, 410)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(451, 88)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 444)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Total of Books in the Library:"
        '
        'book_count
        '
        Me.book_count.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.book_count.Location = New System.Drawing.Point(369, 436)
        Me.book_count.Name = "book_count"
        Me.book_count.Size = New System.Drawing.Size(106, 56)
        Me.book_count.TabIndex = 11
        Me.book_count.Visible = False
        '
        'numberofbooks
        '
        Me.numberofbooks.AutoSize = True
        Me.numberofbooks.BackColor = System.Drawing.Color.RoyalBlue
        Me.numberofbooks.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberofbooks.Location = New System.Drawing.Point(260, 442)
        Me.numberofbooks.Name = "numberofbooks"
        Me.numberofbooks.Size = New System.Drawing.Size(110, 25)
        Me.numberofbooks.TabIndex = 13
        Me.numberofbooks.Text = "[No Data]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(327, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Overall Most Borrowed Books in the Library:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(564, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Number of Library Users by Gender:"
        '
        'statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numberofbooks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.genderrank)
        Me.Controls.Add(Me.BookRank)
        Me.Controls.Add(Me.statTable_bookcount)
        Me.Controls.Add(Me.statTable_gender_Female)
        Me.Controls.Add(Me.statTable_gender_Male)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Controls.Add(Me.book_count)
        Me.Name = "statistics"
        Me.Size = New System.Drawing.Size(1018, 522)
        CType(Me.BookRank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.genderrank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statTable_bookcount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statTable_gender_Male, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statTable_gender_Female, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.book_count, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BookRank As DataVisualization.Charting.Chart
    Friend WithEvents genderrank As DataVisualization.Charting.Chart
    Friend WithEvents statTable_bookcount As DataGridView
    Friend WithEvents statTable_gender_Male As DataGridView
    Friend WithEvents statTable_gender_Female As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label2 As Label
    Friend WithEvents book_count As DataGridView
    Friend WithEvents numberofbooks As Label
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
