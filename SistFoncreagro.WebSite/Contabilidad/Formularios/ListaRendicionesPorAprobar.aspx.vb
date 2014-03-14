Imports System.Collections.Generic
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Public Class ListaRendicionesPorAprobar
    Inherits System.Web.UI.Page
    Dim EjercicioBL As New EjercicioBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RadGrid1_EditCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.EditCommand
        Dim id As String
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        e.Canceled = True
        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdRendicion")
        Response.Redirect("~\Contabilidad\Formularios\FrmAprobarRendicion.aspx?IdRendicion=" + id.ToString)

    End Sub

   
End Class