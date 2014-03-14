Imports SistFoncreagro.Report
Public Class ReporteTareasCaserioResumen
    Inherits System.Web.UI.Page

    Dim IdProyecto As String
    Dim FechaInicio As String
    Dim FechaFin As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdProyecto = Session("IdProyecto")
        FechaInicio = Request.QueryString("FechaInicio")
        FechaFin = Request.QueryString("FechaFin")
        Me.ReportViewer1.Report = New RepEstadoCompromisos
        Me.ReportViewer1.Report.ReportParameters(0).Value = IdProyecto
        Me.ReportViewer1.Report.ReportParameters(1).Value = FechaInicio
        Me.ReportViewer1.Report.ReportParameters(2).Value = FechaFin
    End Sub

End Class