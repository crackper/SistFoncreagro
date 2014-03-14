Imports SistFoncreagro.BussinesLogic
Imports System.Collections.Generic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI
Public Class ListaDetraccion
    Inherits System.Web.UI.Page
    Dim DetraccionBL As New DetraccionBL
    Dim _Detraccion As New Detraccion
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            ID = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDetraccion")
            DetraccionBL.UpdateEstadoDETRACCION(ID)
            Me.RadGrid1.DataBind()
        ElseIf e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        _Detraccion.CtaAbono = CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue
        If CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue.Length > 0 Then
            _Detraccion.CtaCargo = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        End If
        _Detraccion.ElementoAfecto = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Detraccion.Porcentaje = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        _Detraccion.Codigo = CType(userControl.FindControl("TextBox2"), TextBox).Text
        DetraccionBL.SaveDetraccion(_Detraccion)

    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Detraccion.CtaAbono = CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue
        If CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue.Length > 0 Then
            _Detraccion.CtaCargo = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        End If
        _Detraccion.ElementoAfecto = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Detraccion.Porcentaje = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        _Detraccion.IdDetraccion = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdDetraccion")
        DetraccionBL.SaveDetraccion(_Detraccion)
    End Sub
End Class