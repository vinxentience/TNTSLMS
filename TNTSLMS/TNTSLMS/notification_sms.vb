Imports System.Web
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Resources

Public Class notification_sms

    Public Function sendSMS()
        Dim apikey = txtAPI.Text
        Dim message = txtMessage.Text
        Dim numbers = txtPhone.Text
        Dim strPost As String
        Dim sender = txtSender.Text
        Dim url As String = "https://api.txtlocal.com/send/?"


        strPost = url + "apikey=" + apikey _
        + "&numbers=" + numbers _
        + "&message=" + WebUtility.UrlEncode(message) _
        + "&sender=" + sender

        Dim request As WebRequest = WebRequest.Create(strPost)
        request.Method = "POST"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(strPost)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

        Dim response As WebResponse = request.GetResponse()
        dataStream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        'Console.WriteLine(responseFromServer)
        'Console.ReadLine()
        MsgBox("Message Successfully Sent")
        reader.Close()
        dataStream.Close()
        response.Close()

        If responseFromServer.Length > 0 Then
            Return responseFromServer
        Else
            Return CType(response, HttpWebResponse).StatusDescription
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sendSMS()
    End Sub

    Private Sub notification_sms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class