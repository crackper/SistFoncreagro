Imports Telerik.Web.UI

Public Class FrmFeriado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RadGrid1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid1.SelectedIndexChanged
        HFIdFeriado.Value = RadGrid1.SelectedValue
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        e.Canceled = True
        If e.CommandName = "InitInsert" Then
            If HFIdFeriado.Value = "" Then HFIdFeriado.Value = "0"
            Response.Redirect("~\RRHH\Formulario\FrmDatosFeriado.aspx?IdFeriado=" + HFIdFeriado.Value)
        ElseIf e.CommandName = "Select" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            HFIdFeriado.Value = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdFeriado")
            Response.Redirect("~\RRHH\Formulario\FrmDatosFeriado.aspx?IdFeriado=" + HFIdFeriado.Value)
        End If
    End Sub
End Class