Imports SistFoncreagro.Report
Public Class ReporteEstadoIngresosGastos
    Inherits System.Web.UI.Page
    Dim FechaFin As String
    Dim IdProyecto As String
    Dim Tipo As String
   Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FechaFin = Request.QueryString("FechaFin")
        IdProyecto = Request.QueryString("IdProyecto")
        Tipo = Request.QueryString("Tipo")
        Me.ReportViewer1.Report = New RepEstadoIngresosGastos
        Me.ReportViewer1.Report.ReportParameters(0).Value = FechaFin
        Me.ReportViewer1.Report.ReportParameters(1).Value = IdProyecto
        Me.ReportViewer1.Report.ReportParameters(2).Value = Tipo
    End Sub

End Class