Public Class FrmBandejaSistemaPensiones
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "InitInsert" Then
            Me.Response.Redirect("FrmSistemaPensiones.aspx")
        End If
    End Sub
End Class