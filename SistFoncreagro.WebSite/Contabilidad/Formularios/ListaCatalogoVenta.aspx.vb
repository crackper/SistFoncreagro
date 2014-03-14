Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports Telerik.Web.UI
Imports System.Web.Services
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Collections
Imports System.Configuration
Imports System
Imports System.Web.UI
Public Class ListaCatalogoVenta
    Inherits System.Web.UI.Page
    Dim _CatalogoVenta As New CatalogoVenta
    Dim CatalogoVentaBL As New CatalogoVentaBL
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
    End Sub
    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub
    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)

        _CatalogoVenta.IdClasificacion = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        If CType(userControl.FindControl("CheckBox2"), CheckBox).Checked Then
            _CatalogoVenta.AfectoDetraccion = "S"
        Else
            _CatalogoVenta.AfectoDetraccion = "N"
        End If
        If CType(userControl.FindControl("CheckBox1"), CheckBox).Checked Then
            _CatalogoVenta.AfectoIGV = "S"
        Else
            _CatalogoVenta.AfectoIGV = "N"
        End If
        _CatalogoVenta.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _CatalogoVenta.IdTipoVenta = CType(userControl.FindControl("DropDownList2"), DropDownList).SelectedValue
        _CatalogoVenta.IdUnidadMedida = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        _CatalogoVenta.PrecioReferencia = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        CatalogoVentaBL.SaveCATALOGOVENTA(_CatalogoVenta)
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _CatalogoVenta.IdCatVenta = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdCatVenta")
        _CatalogoVenta.IdClasificacion = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
        If CType(userControl.FindControl("CheckBox2"), CheckBox).Checked Then
            _CatalogoVenta.AfectoDetraccion = "S"
        Else
            _CatalogoVenta.AfectoDetraccion = "N"
        End If
        If CType(userControl.FindControl("CheckBox1"), CheckBox).Checked Then
            _CatalogoVenta.AfectoIGV = "S"
        Else
            _CatalogoVenta.AfectoIGV = "N"
        End If
        _CatalogoVenta.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _CatalogoVenta.IdTipoVenta = CType(userControl.FindControl("DropDownList2"), DropDownList).SelectedValue
        _CatalogoVenta.IdUnidadMedida = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        _CatalogoVenta.PrecioReferencia = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        CatalogoVentaBL.SaveCATALOGOVENTA(_CatalogoVenta)
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        ElseIf e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim IdCatalogo = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdCatVenta")
            CatalogoVentaBL.UpdateEstadoCATALOGOVENTA(IdCatalogo)
            Me.RadGrid1.Rebind()
        End If
    End Sub

    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        If estadoMes = "C" Then
            For i = 0 To Me.RadGrid1.Items.Count - 1
                Me.RadGrid1.Items.Item(i)("Editar").Text = ""
                Me.RadGrid1.Items.Item(i)("Anular").Text = ""
            Next
        Else
            For i = 0 To Me.RadGrid1.Items.Count - 1
                If Me.RadGrid1.Items.Item(i)("Estado").Text = "I" Then
                    Me.RadGrid1.Items.Item(i)("Editar").Enabled = False
                    Me.RadGrid1.Items.Item(i)("Anular").Enabled = False
                    e.Item.OwnerTableView.Items.Item(i).BackColor = Drawing.Color.Silver
                End If
            Next
        End If
    End Sub
End Class