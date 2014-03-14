Imports SistFoncreagro.Report
Public Class ReporteListaretencionesCuarta
    Inherits System.Web.UI.Page
    Dim FechaInicio As String
    Dim FechaFin As String
    Dim idProveedorCliente As String
    Dim idMoneda As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FechaInicio = Request.QueryString("FechaInicio")
        FechaFin = Request.QueryString("FechaFin")
        idProveedorCliente = Request.QueryString("idProveedorCliente")
        idMoneda = Request.QueryString("idMoneda")
        Me.ReportViewer1.Report = New RepListaRetencionesCuarta
        Me.ReportViewer1.Report.ReportParameters(0).Value = FechaInicio
        Me.ReportViewer1.Report.ReportParameters(1).Value = FechaFin
        Me.ReportViewer1.Report.ReportParameters(2).Value = idProveedorCliente
        Me.ReportViewer1.Report.ReportParameters(3).Value = idMoneda
    End Sub

End Class