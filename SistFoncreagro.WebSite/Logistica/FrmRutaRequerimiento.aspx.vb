Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities

Public Class FrmRutaRequerimiento
    Inherits System.Web.UI.Page
    Dim rutaReq As RutaRequerimiento
    Dim rutaReqBl As New RutaRequerimientoBL
    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim idRutaReq As Int32 = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdRutaRequerimiento")
            rutaReqBl.DeleteRutaRequerimiento(idRutaReq)
            Me.RadGrid2.DataBind()
        End If
    End Sub

    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        rutaReq = New RutaRequerimiento
        rutaReq.Nombre = CType(userControl.FindControl("txtNombre"), TextBox).Text
        rutaReq.Descripcion = CType(userControl.FindControl("txtDescripcion"), TextBox).Text
        rutaReqBl.SaveRutaRequerimiento(rutaReq)
    End Sub

    Private Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        rutaReq = New RutaRequerimiento
        rutaReq.IdRutaRequerimiento = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdRutaRequerimiento")
        rutaReq.Nombre = CType(userControl.FindControl("txtNombre"), TextBox).Text
        rutaReq.Descripcion = CType(userControl.FindControl("txtDescripcion"), TextBox).Text
        rutaReqBl.SaveRutaRequerimiento(rutaReq)
    End Sub
End Class