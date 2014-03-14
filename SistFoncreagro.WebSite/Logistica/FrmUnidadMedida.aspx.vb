Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities

Public Class FrmUnidadMedida
    Inherits System.Web.UI.Page
    Dim unidadMedidaBl As New UnidadMedidaBL
    Dim unidadMedida As UnidadMedida

    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        unidadMedida = New UnidadMedida
        unidadMedida.Descripcion = CType(userControl.FindControl("txtDescripcion"), TextBox).Text
        unidadMedida.Abreviacion = CType(userControl.FindControl("txtAbreviacion"), TextBox).Text
        unidadMedidaBl.SaveUnidadMedida(unidadMedida)
    End Sub

    Private Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        unidadMedida = New UnidadMedida
        unidadMedida.IdUnidadMedida = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdUnidadMedida")
        unidadMedida.Descripcion = CType(userControl.FindControl("txtDescripcion"), TextBox).Text
        unidadMedida.Abreviacion = CType(userControl.FindControl("txtAbreviacion"), TextBox).Text
        unidadMedidaBl.SaveUnidadMedida(unidadMedida)
    End Sub

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim IdUnidad As Int32 = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdUnidadMedida")
            unidadMedidaBl.DeleteUnidadMedida(IdUnidad)
            Me.RadGrid2.DataBind()
        End If
    End Sub
End Class