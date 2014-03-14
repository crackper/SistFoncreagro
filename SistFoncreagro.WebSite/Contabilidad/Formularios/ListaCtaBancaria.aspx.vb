Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class ListaCtaBancaria
    Inherits System.Web.UI.Page
    Dim CuentaProyectoBl As New CtaBancariaProyectoBL
    Dim _CtaBancariaProyecto As New CtaBancariaProyecto
    Dim CuentaBancariaBL As New CuentaBancariaBL
    Dim _CuentaBancaria As New CuentaBancaria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        If "CuentaProyecto".Equals(e.Item.OwnerTableView.Name) Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim IdCtaBancaria As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdCtaBancaria").ToString
            Dim IdProyecto As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdProyecto").ToString
            CuentaProyectoBl.UpdateEstadoCTABANCARIAPROYECTO(IdCtaBancaria, IdProyecto)
        End If
    End Sub
    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)

        If "CuentaProyecto".Equals(e.Item.OwnerTableView.Name) Then
            _CtaBancariaProyecto.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
            _CtaBancariaProyecto.IdCtaBancaria = parentItem.OwnerTableView.DataKeyValues(parentItem.ItemIndex)("IdCtaBancaria").ToString
            _CtaBancariaProyecto.IdProyecto = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
            CuentaProyectoBl.SaveCTABANCARIAPROYECTO(_CtaBancariaProyecto)
        Else
            _CuentaBancaria.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
            _CuentaBancaria.IdBanco = CType(userControl.FindControl("DropDownList2"), DropDownList).SelectedValue
            _CuentaBancaria.IdMoneda = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
            _CuentaBancaria.IdPlan = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
            _CuentaBancaria.IdTipoCtaBancaria = CType(userControl.FindControl("DropDownList3"), DropDownList).SelectedValue
            _CuentaBancaria.NroCta = CType(userControl.FindControl("TextBox2"), TextBox).Text
            _CuentaBancaria.IdSubdiario = CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue
            CuentaBancariaBL.SaveCUENTABANCARIA(_CuentaBancaria)
        End If
    End Sub
    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim parentItem As GridDataItem = DirectCast(e.Item.OwnerTableView.ParentItem, GridDataItem)

        If "CuentaProyecto".Equals(e.Item.OwnerTableView.Name) Then
            _CtaBancariaProyecto.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
            _CtaBancariaProyecto.IdCtaBancaria = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdCtaBancaria")
            _CtaBancariaProyecto.IdProyecto = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdProyecto")
            CuentaProyectoBl.SaveCTABANCARIAPROYECTO(_CtaBancariaProyecto)
        Else
            _CuentaBancaria.Descripcion = CType(userControl.FindControl("TextBox1"), TextBox).Text
            _CuentaBancaria.IdBanco = CType(userControl.FindControl("DropDownList2"), DropDownList).SelectedValue
            _CuentaBancaria.IdMoneda = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
            _CuentaBancaria.IdPlan = CType(userControl.FindControl("RadComboBox1"), RadComboBox).SelectedValue
            _CuentaBancaria.IdTipoCtaBancaria = CType(userControl.FindControl("DropDownList3"), DropDownList).SelectedValue
            _CuentaBancaria.NroCta = CType(userControl.FindControl("TextBox2"), TextBox).Text
            _CuentaBancaria.IdCtaBancaria = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdCtaBancaria")
            _CuentaBancaria.IdSubdiario = CType(userControl.FindControl("RadComboBox2"), RadComboBox).SelectedValue
            CuentaBancariaBL.SaveCUENTABANCARIA(_CuentaBancaria)
        End If
    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim id As Int32
            id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdCtaBancaria")

            If Not "CuentaProyecto".Equals(e.Item.OwnerTableView.Name) Then
                CuentaBancariaBL.UpdateEstadoCUENTABANCARIA(id)
                Me.RadGrid1.DataBind()
            End If
        End If
    End Sub
End Class