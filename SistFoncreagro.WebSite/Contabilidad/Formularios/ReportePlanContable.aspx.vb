Imports SistFoncreagro.Report
Public Class ReportePlanContable
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ReportViewer1.Report = New RepPlanContable
    End Sub

End Class