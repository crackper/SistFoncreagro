﻿Imports SistFoncreagro.Report
Public Class ReporteDetracciones
    Inherits System.Web.UI.Page

    Dim fechaInicio As String
    Dim fechaFin As String
    Dim idMoneda As String
    Dim idProyecto As String
    Dim idProveedor As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fechaInicio = Me.Request.QueryString("fechaInicio")
        fechaFin = Me.Request.QueryString("fechaFin")
        idMoneda = Me.Request.QueryString("idMoneda")
        idProyecto = Me.Request.QueryString("idProyecto")
        idProveedor = Me.Request.QueryString("idProveedor")

        Me.ReportViewer1.Report = New RepDetracciones
        Me.ReportViewer1.Report.ReportParameters(0).Value = fechaInicio
        Me.ReportViewer1.Report.ReportParameters(1).Value = fechaFin
        Me.ReportViewer1.Report.ReportParameters(2).Value = idProveedor
        Me.ReportViewer1.Report.ReportParameters(3).Value = idProyecto
        Me.ReportViewer1.Report.ReportParameters(4).Value = idMoneda
    End Sub

End Class