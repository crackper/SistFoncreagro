﻿Imports SistFoncreagro.Report
Public Class ReporteCompromisos
    Inherits System.Web.UI.Page
    Dim IdProyecto As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdProyecto = Request.QueryString("IdProyecto")
        Me.ReportViewer1.Report = New RepCompromisosCaserios
        Me.ReportViewer1.Report.ReportParameters(0).Value = IdProyecto
    End Sub

End Class