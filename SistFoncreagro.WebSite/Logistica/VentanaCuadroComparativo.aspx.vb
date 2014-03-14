Public Class VentanaCuadroComparativo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'MsgBox(Request.QueryString("IdCot"))
    End Sub

    Protected Sub gvProveedor_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs)
        Dim gvProv As GridView = CType(sender, GridView)
        For i = 0 To gvProv.Rows.Count - 1
            Dim rButon As RadioButton = CType(gvProv.Rows(i).FindControl("rbSeleccionarProveedor"), RadioButton)
            If rButon.Checked = True Then
                gvProv.Rows(i).BackColor = Drawing.Color.LightYellow
            End If
        Next
    End Sub
End Class