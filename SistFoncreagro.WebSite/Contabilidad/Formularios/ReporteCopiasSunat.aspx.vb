Imports SistFoncreagro.Report
Public Class ReporteCopiasSunat
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ReportViewer1.Report = New RepCopiasSunat
       
    End Sub

End Class