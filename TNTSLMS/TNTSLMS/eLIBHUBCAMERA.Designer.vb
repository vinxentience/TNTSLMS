<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class eLIBHUBCAMERA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eLIBHUBCAMERA))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CapturedCam = New System.Windows.Forms.PictureBox()
        Me.LiveCam = New System.Windows.Forms.PictureBox()
        Me.START = New System.Windows.Forms.Button()
        Me.CAPTURE = New System.Windows.Forms.Button()
        Me.SAVE = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CapturedCam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiveCam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CapturedCam, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LiveCam, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 62)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(741, 262)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'CapturedCam
        '
        Me.CapturedCam.Location = New System.Drawing.Point(373, 3)
        Me.CapturedCam.Name = "CapturedCam"
        Me.CapturedCam.Size = New System.Drawing.Size(365, 256)
        Me.CapturedCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CapturedCam.TabIndex = 0
        Me.CapturedCam.TabStop = False
        '
        'LiveCam
        '
        Me.LiveCam.Location = New System.Drawing.Point(3, 3)
        Me.LiveCam.Name = "LiveCam"
        Me.LiveCam.Size = New System.Drawing.Size(364, 256)
        Me.LiveCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LiveCam.TabIndex = 1
        Me.LiveCam.TabStop = False
        '
        'START
        '
        Me.START.Location = New System.Drawing.Point(211, 339)
        Me.START.Name = "START"
        Me.START.Size = New System.Drawing.Size(75, 23)
        Me.START.TabIndex = 1
        Me.START.Text = "Start"
        Me.START.UseVisualStyleBackColor = True
        '
        'CAPTURE
        '
        Me.CAPTURE.Location = New System.Drawing.Point(393, 339)
        Me.CAPTURE.Name = "CAPTURE"
        Me.CAPTURE.Size = New System.Drawing.Size(75, 23)
        Me.CAPTURE.TabIndex = 1
        Me.CAPTURE.Text = "Capture"
        Me.CAPTURE.UseVisualStyleBackColor = True
        '
        'SAVE
        '
        Me.SAVE.Location = New System.Drawing.Point(567, 339)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(75, 23)
        Me.SAVE.TabIndex = 1
        Me.SAVE.Text = "Save"
        Me.SAVE.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "PROFILEPIC_[YOURFAMILYNAME]_[SURNAME]"
        Me.SaveFileDialog1.Filter = "Save your profile picture |*.jpg;*.png;*.gif"
        Me.SaveFileDialog1.InitialDirectory = "C:\TNTS LIBRARY SYSTEM\PROFILE_PICTURES"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(757, 379)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(29, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Next"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(748, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 33)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Set your Profile Picture"
        '
        'eLIBHUBCAMERA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(808, 413)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.SAVE)
        Me.Controls.Add(Me.CAPTURE)
        Me.Controls.Add(Me.START)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "eLIBHUBCAMERA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eLIBHUBCAMERA"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.CapturedCam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiveCam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents START As Button
    Friend WithEvents CAPTURE As Button
    Friend WithEvents SAVE As Button
    Friend WithEvents CapturedCam As PictureBox
    Friend WithEvents LiveCam As PictureBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
End Class
