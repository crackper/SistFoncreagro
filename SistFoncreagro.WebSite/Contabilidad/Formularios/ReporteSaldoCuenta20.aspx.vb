Imports SistFoncreagro.Report
Public Class ReporteSaldoCuenta20
    Inherits System.Web.UI.Page
   Dim FechaFin As String
    Dim IdProyecto As String
    Dim Proyecto As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FechaFin = Request.QueryString("FechaFin")
        IdProyecto = Request.QueryString("IdProyecto")
        Proyecto = Request.QueryString("Proyecto")

        Me.ReportViewer1.Report = New RepSaldoCuenta20
        Me.ReportViewer1.Report.ReportParameters(0).Value = FechaFin
        Me.ReportViewer1.Report.ReportParameters(1).Value = IdProyecto
        Me.ReportViewer1.Report.ReportParameters(2).Value = Proyecto
    End Sub

End Class