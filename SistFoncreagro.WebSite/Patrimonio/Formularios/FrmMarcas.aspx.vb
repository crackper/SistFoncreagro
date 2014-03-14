Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmMarcas
    Inherits System.Web.UI.Page

    Dim marcaBl As New MarcaBL
    Dim marca As Marca
    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        marca = New Marca
        marca.Descripcion = CType(userControl.FindControl("txtDescripcion"), TextBox).Text
        marcaBl.SaveMarca(marca)
    End Sub
    Protected Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        marca = New Marca
        marca.IdMarca = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdMarca")
        marca.Descripcion = CType(userControl.FindControl("txtDescripcion"), TextBox).Text
        marcaBl.SaveMarca(marca)
    End Sub
    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim IdMarca As Int32 = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdMarca")
            marcaBl.DeleteMarca(IdMarca)
            Me.RadGrid2.DataBind()
        End If
    End Sub
End Class