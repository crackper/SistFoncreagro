Imports SistFoncreagro.Report
Public Class Voucher
    Inherits System.Web.UI.Page
    Dim Tipo As String
    Dim Flag As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tipo = Me.Request.QueryString("Tipo")

        Select Case Tipo
            Case "C"
                Me.ReportViewer1.Report = New VoucherCompras
            Case "V"
                Me.ReportViewer1.Report = New VoucherVentas
            Case "H"
                Me.ReportViewer1.Report = New VoucherHonorarios
            Case "I"
                Me.ReportViewer1.Report = New VoucherIngresos
            Case "E"
                Me.ReportViewer1.Report = New VoucherEgresos
            Case "D"
                Me.ReportViewer1.Report = New VoucherDiario
        End Select

        Me.ReportViewer1.Report.ReportParameters(0).Value = Session("IdTransaccion")
    End Sub

End Class