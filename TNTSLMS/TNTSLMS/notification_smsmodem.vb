Imports System.Management
Imports System.Threading
Public Class notification_smsmodem
    Dim rcvdata As String = ""
    Private Sub notification_smsmodem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ports() As String
        ports = Split(ModemsConnected(), "***")
        For i As Integer = 0 To ports.Length - 2
            ComboBox1.Items.Add(ports(i))

        Next
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

End Class