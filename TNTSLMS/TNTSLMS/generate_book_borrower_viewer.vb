Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports

Public Class generate_book_borrower_viewer
    Private Sub generate_book_list_viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptDoc As ReportDocument
        rptDoc = New generate_bookborrower
        rptDoc.RecordSelectionFormula = "{borrower1.date_borrowed} In Date ('" & generate_book_borrower.DateTimePicker_From.Text & "') To Date ('" & generate_book_borrower.DateTimePicker_To.Text & "')"
        Me.CrystalReportViewer1.ReportSource = rptDoc
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class