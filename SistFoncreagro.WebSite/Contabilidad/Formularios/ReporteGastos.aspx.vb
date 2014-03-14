Imports SistFoncreagro.Report
Public Class ReporteGastos
    Inherits System.Web.UI.Page
    Dim FechaInicio As String
    Dim FechaFin As String
    Dim IdProyecto As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FechaInicio = Me.Request.QueryString("FechaInicio")
        FechaFin = Me.Request.QueryString("FechaFin")
        IdProyecto = Me.Request.QueryString("IdProyecto")

        Me.ReportViewer1.Report = New RepGastos
        Me.ReportViewer1.Report.ReportParameters(0).Value = FechaInicio
        Me.ReportViewer1.Report.ReportParameters(1).Value = FechaFin
        Me.ReportViewer1.Report.ReportParameters(2).Value = IdProyecto
    End Sub

End Class