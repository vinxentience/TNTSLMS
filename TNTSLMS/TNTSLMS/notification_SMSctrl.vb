Imports System.Management
Imports System.Threading
Imports MySql.Data.MySqlClient
Public Class notification_SMSctrl
    Dim rcvdata As String = ""
    Dim command As MySqlCommand
    Private Sub notification_SMSctrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ports() As String
        ports = Split(ModemsConnected(), "***")
        For i As Integer = 0 To ports.Length - 2
            ComboBox1.Items.Add(ports(i))

        Next
        txtmsg.Text = "Good Day! " + "'" & FULLNAME.Text & "'" + " The book you borrowed is already on due date. Kindly return the reading material. Thank you"
    End Sub
    Public Function ModemsConnected() As String
        Dim modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher(
                "root\CIMV2",
                "SELECT * FROM Win32_POTSModem")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Status") = "OK" Then
                    modems = modems & (queryObj("AttachedTo") & " - " & queryObj("Description") & "***")
                End If
            Next
        Catch err As ManagementException
            MsgBox("error")
            Return ""
        End Try
        Return modems
    End Function

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Label1.Text = Trim(Mid(ComboBox1.Text, 1, 5))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            With SerialPort1
                .PortName = Label1.Text
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCr
                .ReadTimeout = 1000
                .Open()
            End With

            If SerialPort1.IsOpen Then
                Label2.Text = "Connected"
            Else
                Label2.Text = "Error"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            With SerialPort1
                .Write("at" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("at+cmgf=1" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("at+cmgs=" & Chr(34) & txtnumber.Text & Chr(34) & vbCrLf)
                .Write(txtmsg.Text & Chr(26))
                Threading.Thread.Sleep(1000)
                MsgBox(rcvdata.ToString)
            End With
            If rcvdata.ToString.Contains(">") Then
                MsgBox("Message Sent")
            Else
                MsgBox("Error!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub serialport1_datareceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim datain As String = ""
        Dim numbytes As Integer = SerialPort1.BytesToRead
        For i As Integer = 1 To numbytes
            datain &= Chr(SerialPort1.ReadChar)
        Next
        test(datain)
    End Sub

    Private Sub test(ByVal indata As String)
        rcvdata &= indata

    End Sub

    Private Sub USER_ID_TextChanged(sender As Object, e As EventArgs) Handles USER_ID.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM tntslibrarymanagementsystem.user_info"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read()
                Dim LRN_ID_READER = Reader.GetString("LRN")
                Dim EMAIL_READER = Reader.GetString("email")
                Dim FNAME_READER = Reader.GetString("fname")
                Dim LNAME_READER = Reader.GetString("lname")
                Dim CONTACT_READER = Reader.GetString("CONTACT_NUMBER")
                If USER_ID.Text = LRN_ID_READER Then
                    txtnumber.Text = CONTACT_READER
                    FULLNAME.Text = FNAME_READER + " " + LNAME_READER
                    txtmsg.Enabled = False
                    enableEdit.CheckState = CheckState.Unchecked

                    txtmsg.Text = "Good Day! " + "'" & FULLNAME.Text & "'" + " The book you borrowed is already on due date. Kindly return the reading material. Thank you"
                End If


            End While
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub enableEdit_CheckedChanged(sender As Object, e As EventArgs) Handles enableEdit.CheckedChanged
        If enableEdit.CheckState = CheckState.Checked Then
            txtmsg.Enabled = True
            txtmsg.Text = "Good Day! " + "'" & FULLNAME.Text & "'" + " The book you borrowed is already on due date. Kindly return the reading material. Thank you"
        Else
            txtmsg.Enabled = False
            txtmsg.Text = "Good Day! " + "'" & FULLNAME.Text & "'" + " The book you borrowed is already on due date. Kindly return the reading material. Thank you"
        End If
    End Sub
End Class
