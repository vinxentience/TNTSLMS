<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LibraryUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibraryUser))
        Me.USER_NAME_PROFILE = New System.Windows.Forms.Label()
        Me.profile_viewer_container = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DayOfTheWeek = New System.Windows.Forms.Label()
        Me.YearNow = New System.Windows.Forms.Label()
        Me.MonthNow = New System.Windows.Forms.Label()
        Me.DateNow = New System.Windows.Forms.Label()
        Me.TimeNow = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.user_id = New System.Windows.Forms.Label()
        CType(Me.profile_viewer_container, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USER_NAME_PROFILE
        '
        Me.USER_NAME_PROFILE.AutoSize = True
        Me.USER_NAME_PROFILE.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.USER_NAME_PROFILE.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Italic)
        Me.USER_NAME_PROFILE.ForeColor = System.Drawing.Color.White
        Me.USER_NAME_PROFILE.Location = New System.Drawing.Point(84, 255)
        Me.USER_NAME_PROFILE.Name = "USER_NAME_PROFILE"
        Me.USER_NAME_PROFILE.Size = New System.Drawing.Size(98, 21)
        Me.USER_NAME_PROFILE.TabIndex = 5
        Me.USER_NAME_PROFILE.Text = "USER NAME"
        '
        'profile_viewer_container
        '
        Me.profile_viewer_container.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.profile_viewer_container.Location = New System.Drawing.Point(31, 64)
        Me.profile_viewer_container.Name = "profile_viewer_container"
        Me.profile_viewer_container.Size = New System.Drawing.Size(226, 178)
        Me.profile_viewer_container.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profile_viewer_container.TabIndex = 4
        Me.profile_viewer_container.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(303, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "eLIBHUB: Library Management System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(299, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(496, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Apokon, Tagum City, Davao Del Norte, Philippines" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(297, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 34)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "TAGUM NATIONAL TRADE SCHOOL"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(232, 313)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 32
        Me.PictureBox10.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(231, 371)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(229, 426)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'Timer1
        '
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.RectangleShape2.Location = New System.Drawing.Point(0, -1)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(1296, 43)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape1, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1299, 689)
        Me.ShapeContainer1.TabIndex = 52
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.RectangleShape3.Location = New System.Drawing.Point(-3, 658)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(1300, 30)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 42)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(280, 592)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button6)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 303)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(281, 355)
        Me.FlowLayoutPanel1.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(278, 53)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Search Book"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(3, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(278, 53)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Account Information"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(3, 121)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(278, 53)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Most Borrowed Books"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(3, 180)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(278, 53)
        Me.Button4.TabIndex = 54
        Me.Button4.Text = "My Borrowed Books"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(3, 239)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(278, 53)
        Me.Button6.TabIndex = 53
        Me.Button6.Text = "Logout"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(547, 663)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(290, 17)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "eLIBHUB: Library Management System © 2019"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(281, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1018, 520)
        Me.Panel1.TabIndex = 55
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1249, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 56
        Me.PictureBox4.TabStop = False
        '
        'DayOfTheWeek
        '
        Me.DayOfTheWeek.AutoSize = True
        Me.DayOfTheWeek.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DayOfTheWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayOfTheWeek.ForeColor = System.Drawing.Color.White
        Me.DayOfTheWeek.Location = New System.Drawing.Point(1057, 100)
        Me.DayOfTheWeek.Name = "DayOfTheWeek"
        Me.DayOfTheWeek.Size = New System.Drawing.Size(57, 16)
        Me.DayOfTheWeek.TabIndex = 62
        Me.DayOfTheWeek.Text = "xxxxxxx"
        '
        'YearNow
        '
        Me.YearNow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YearNow.AutoSize = True
        Me.YearNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.YearNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearNow.ForeColor = System.Drawing.Color.White
        Me.YearNow.Location = New System.Drawing.Point(1254, 107)
        Me.YearNow.Name = "YearNow"
        Me.YearNow.Size = New System.Drawing.Size(39, 15)
        Me.YearNow.TabIndex = 61
        Me.YearNow.Text = "0000"
        '
        'MonthNow
        '
        Me.MonthNow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthNow.AutoSize = True
        Me.MonthNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MonthNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthNow.ForeColor = System.Drawing.Color.SteelBlue
        Me.MonthNow.Location = New System.Drawing.Point(1238, 53)
        Me.MonthNow.Name = "MonthNow"
        Me.MonthNow.Size = New System.Drawing.Size(61, 31)
        Me.MonthNow.TabIndex = 60
        Me.MonthNow.Text = "Jan"
        '
        'DateNow
        '
        Me.DateNow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateNow.AutoSize = True
        Me.DateNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DateNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateNow.ForeColor = System.Drawing.Color.SteelBlue
        Me.DateNow.Location = New System.Drawing.Point(1251, 79)
        Me.DateNow.Name = "DateNow"
        Me.DateNow.Size = New System.Drawing.Size(46, 31)
        Me.DateNow.TabIndex = 59
        Me.DateNow.Text = "00"
        '
        'TimeNow
        '
        Me.TimeNow.AutoSize = True
        Me.TimeNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TimeNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeNow.ForeColor = System.Drawing.Color.White
        Me.TimeNow.Location = New System.Drawing.Point(1054, 64)
        Me.TimeNow.Name = "TimeNow"
        Me.TimeNow.Size = New System.Drawing.Size(178, 31)
        Me.TimeNow.TabIndex = 58
        Me.TimeNow.Text = "12:00:00 AM"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(1040, 49)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(259, 81)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 63
        Me.PictureBox6.TabStop = False
        '
        'user_id
        '
        Me.user_id.AutoSize = True
        Me.user_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.user_id.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Italic)
        Me.user_id.ForeColor = System.Drawing.Color.White
        Me.user_id.Location = New System.Drawing.Point(84, 282)
        Me.user_id.Name = "user_id"
        Me.user_id.Size = New System.Drawing.Size(98, 21)
        Me.user_id.TabIndex = 64
        Me.user_id.Text = "USER NAME"
        Me.user_id.Visible = False
        '
        'LibraryUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1299, 689)
        Me.Controls.Add(Me.user_id)
        Me.Controls.Add(Me.DayOfTheWeek)
        Me.Controls.Add(Me.TimeNow)
        Me.Controls.Add(Me.MonthNow)
        Me.Controls.Add(Me.YearNow)
        Me.Controls.Add(Me.DateNow)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.profile_viewer_container)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.USER_NAME_PROFILE)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LibraryUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eLIBHUB"
        CType(Me.profile_viewer_container, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents USER_NAME_PROFILE As Label
    Friend WithEvents profile_viewer_container As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents DayOfTheWeek As Label
    Friend WithEvents YearNow As Label
    Friend WithEvents MonthNow As Label
    Friend WithEvents DateNow As Label
    Friend WithEvents TimeNow As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents user_id As Label
End Class
