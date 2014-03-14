Imports SistFoncreagro.Report
Public Class VentanaReporteCompras
    Inherits System.Web.UI.Page
    Dim tipo As Int32
    Dim fechaIni As String
    Dim fechaFin As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tipo = Request.QueryString("fec")
        fechaIni = Me.Request.QueryString("fechaIni")
        fechaFin = Me.Request.QueryString("fechaFin")
        Me.ReportViewer1.Report = New ReporteCompras1
        Me.ReportViewer1.Report.ReportParameters(0).Value = Request.QueryString("proyecto")
        Me.ReportViewer1.Report.ReportParameters(1).Value = Request.QueryString("proveedor")
        Me.ReportViewer1.Report.ReportParameters(2).Value = Request.QueryString("producto")
        Me.ReportViewer1.Report.ReportParameters(3).Value = tipo
        If tipo = 1 Then
            Me.ReportViewer1.Report.ReportParameters(4).Value = CDate(fechaIni)
            Me.ReportViewer1.Report.ReportParameters(5).Value = CDate(fechaFin)
        End If
        Me.ReportViewer1.ZoomPercent = 100
    End Sub
End Class