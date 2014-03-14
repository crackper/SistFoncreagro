Imports SistFoncreagro.Report
Public Class ReporteSaldosCuentaBancaria
    Inherits System.Web.UI.Page
    Dim IdPlan As String
    Dim Fecha As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdPlan = Request.QueryString("idPlan")
        Fecha = Request.QueryString("Fecha")
        Me.ReportViewer1.Report = New RepSaldosCuentaBancaria
        Me.ReportViewer1.Report.ReportParameters(0).Value = IdPlan
        Me.ReportViewer1.Report.ReportParameters(1).Value = Fecha
    End Sub

End Class