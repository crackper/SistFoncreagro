Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class ListaEncuesta
    Inherits System.Web.UI.Page
    Dim EncuestaBl As New EncuestaBL
    Dim _Encuesta As New Encuesta
    Dim DetalleEncuestaBl As New DetalleEncuestaBL
    Dim _DetalleEncuesta As New DetalleEncuesta
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)

        If "Detalle".Equals(e.Item.OwnerTableView.Name) Then
            _DetalleEncuesta.IdCaracteristica = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
            _DetalleEncuesta.IdEncuesta = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("IdEncuesta").ToString
            DetalleEncuestaBl.SaveDETALLEENCUESTA(_DetalleEncuesta)
        Else
            _Encuesta.Descripcion = CType(e.Item.FindControl("TextBox1"), TextBox).Text
            _Encuesta.FechaInicio = CType(e.Item.FindControl("txtDate"), TextBox).Text
            _Encuesta.FechaFin = CType(e.Item.FindControl("txtDate2"), TextBox).Text
            EncuestaBl.SaveENCUESTA(_Encuesta)
        End If
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)

        If "Detalle".Equals(e.Item.OwnerTableView.Name) Then
            Dim Id As String = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDetalle")
            _DetalleEncuesta.IdCaracteristica = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
            _DetalleEncuesta.IdEncuesta = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("IdEncuesta").ToString
            _DetalleEncuesta.IdDetalle = Id
            DetalleEncuestaBl.SaveDETALLEENCUESTA(_DetalleEncuesta)
        Else
            Dim Id As String = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdEncuesta")
            _Encuesta.Descripcion = CType(e.Item.FindControl("TextBox1"), TextBox).Text
            _Encuesta.FechaInicio = CType(e.Item.FindControl("txtDate"), TextBox).Text
            _Encuesta.FechaFin = CType(e.Item.FindControl("txtDate2"), TextBox).Text
            _Encuesta.IdEncuesta = Id
            EncuestaBl.SaveENCUESTA(_Encuesta)
        End If
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        If "Detalle".Equals(e.Item.OwnerTableView.Name) Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim Id As String = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDetalle")
            DetalleEncuestaBl.DeleteDETALLEENCUESTA(Id)
        Else
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim Id As String = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdEncuesta")
            EncuestaBl.DeleteENCUESTA(Id)
        End If
    End Sub
End Class