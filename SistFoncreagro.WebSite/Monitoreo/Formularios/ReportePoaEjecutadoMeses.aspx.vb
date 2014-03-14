Imports SistFoncreagro.Report
Public Class ReportePoaEjecutadoMeses
    Inherits System.Web.UI.Page
    Dim IdProyecto As String
    Dim meses As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdProyecto = Session("IdProyecto")
        If Page.IsPostBack = False Then
            Me.TextBox1.Text = Date.Now.Year
        End If
    End Sub

    Protected Sub CheckBoxList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckBoxList1.SelectedIndexChanged
        For i = 0 To Me.CheckBoxList1.Items.Count - 1

            If (Me.CheckBoxList1.Items(i).Selected) Then

                meses += Me.CheckBoxList1.Items(i).Value + ","
            End If
        Next
        'MsgBox(meses)
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        For i = 0 To Me.CheckBoxList1.Items.Count - 1

            If (Me.CheckBoxList1.Items(i).Selected) Then

                meses += Me.CheckBoxList1.Items(i).Value + ","
            End If
        Next
        Me.ReportViewer1.Report = New RepPoaMeses
        Me.ReportViewer1.Report.ReportParameters(0).Value = Me.TextBox1.Text
        Me.ReportViewer1.Report.ReportParameters(1).Value = IdProyecto
        Me.ReportViewer1.Report.ReportParameters(2).Value = meses
    End Sub
End Class

