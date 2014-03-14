Imports SistFoncreagro.Report
Public Class ReporteTabuladoMesDetalle
    Inherits System.Web.UI.Page
    Dim idProyecto As String
    Dim FechaInicio As String
    Dim FechaFin As String
    Dim CuentaInicio As String
    Dim CuentaFin As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        idProyecto = Request.QueryString("idProyecto")
        FechaInicio = Request.QueryString("FechaInicio")
        FechaFin = Request.QueryString("FechaFin")
        CuentaInicio = Request.QueryString("CuentaInicio")
        CuentaFin = Request.QueryString("CuentaFin")
        Me.ReportViewer1.Report = New RepTabuladoMesDetalle
        Me.ReportViewer1.Report.ReportParameters(0).Value = FechaInicio
        Me.ReportViewer1.Report.ReportParameters(1).Value = FechaFin
        Me.ReportViewer1.Report.ReportParameters(2).Value = idProyecto
        Me.ReportViewer1.Report.ReportParameters(3).Value = CuentaInicio
        Me.ReportViewer1.Report.ReportParameters(4).Value = CuentaFin
        Me.ReportViewer1.ZoomPercent = 150
    End Sub

End Class