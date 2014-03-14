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
Public Class ListaClasificacionCatalogo
    Inherits System.Web.UI.Page
    Dim _ClasificacionCatalogo As New ClasificacionCatalogoVentas
    Dim ClasificacionCatalogoBL As New ClasificacionCatalogoVentasBL
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

        _ClasificacionCatalogo.Clasificacion = CType(userControl.FindControl("TextBox1"), TextBox).Text
        If CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue <> "N" Then
            _ClasificacionCatalogo.IdEspecieAnimal = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        Else
            _ClasificacionCatalogo.IdEspecieAnimal.Equals(DBNull.Value)
        End If

        ClasificacionCatalogoBL.SaveCLASIFICACIONCATALOGOVENTAS(_ClasificacionCatalogo)
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _ClasificacionCatalogo.IdClasificacion = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdClasificacion")
        _ClasificacionCatalogo.Clasificacion = CType(userControl.FindControl("TextBox1"), TextBox).Text
        If CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue <> "N" Then
            _ClasificacionCatalogo.IdEspecieAnimal = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        Else
            _ClasificacionCatalogo.IdEspecieAnimal.Equals(DBNull.Value)
        End If

        ClasificacionCatalogoBL.SaveCLASIFICACIONCATALOGOVENTAS(_ClasificacionCatalogo)
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        ElseIf e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim IdClasificacion = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdClasificacion")
            ClasificacionCatalogoBL.UpdateEstadoCLASIFICACIONCATALOGOVENTAS(IdClasificacion)
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