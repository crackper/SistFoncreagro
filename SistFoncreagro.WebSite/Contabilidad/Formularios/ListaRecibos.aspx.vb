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
Public Class ListaRecibos
    Inherits System.Web.UI.Page
    Dim TraduccionesBL As New TraduccionesBL
    Dim RecibosBL As New ReciboBL
    Dim _Recibo As New Recibo
    Dim EjercicioBL As New EjercicioBL
    Dim estadoMes As String = ""
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
        If estadoMes = "C" Then
            Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
        End If
    End Sub

    Protected Sub RadGrid1_Init(ByVal sender As Object, ByVal e As EventArgs) Handles RadGrid1.Init
        TraduccionesBL.TraducirGrilla(sender)
       
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        _Recibo.Beneficiario = CType(userControl.FindControl("RadComboBox4"), RadComboBox).SelectedValue
        _Recibo.Fecha = CType(userControl.FindControl("txtDate"), TextBox).Text
        _Recibo.Glosa = CType(userControl.FindControl("RadTextBox4"), RadTextBox).Text
        _Recibo.IdProyecto = CType(userControl.FindControl("RadComboBox3"), RadComboBox).SelectedValue
        _Recibo.Monto = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        _Recibo.FechaVencimiento = _Recibo.Fecha.AddDays(7)
        _Recibo.IdCCosto = CType(userControl.FindControl("RadComboBox5"), RadComboBox).SelectedValue
        _Recibo.Usuario = 1

        RecibosBL.SaveRECIBO(_Recibo)
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Recibo.IdRecibo = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdRecibo")
        _Recibo.Beneficiario = CType(userControl.FindControl("RadComboBox4"), RadComboBox).SelectedValue
        _Recibo.Fecha = CType(userControl.FindControl("txtDate"), TextBox).Text
        _Recibo.Glosa = CType(userControl.FindControl("RadTextBox4"), RadTextBox).Text
        _Recibo.IdProyecto = CType(userControl.FindControl("RadComboBox3"), RadComboBox).SelectedValue
        _Recibo.Monto = CType(userControl.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        _Recibo.FechaVencimiento = _Recibo.Fecha.AddDays(7)
        _Recibo.IdCCosto = CType(userControl.FindControl("RadComboBox5"), RadComboBox).SelectedValue
        _Recibo.Usuario = 1

        RecibosBL.SaveRECIBO(_Recibo)
    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim id As Int32

        id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdRecibo")
        RecibosBL.DeleteRECIBO(id)
    End Sub
    Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid1.ItemDataBound
        Dim estadoMes As String = ""
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))

        If estadoMes = "C" Then
            For i = 0 To Me.RadGrid1.Items.Count - 1
                Me.RadGrid1.Items.Item(i)("editar").Enabled = False
                Me.RadGrid1.Items.Item(i)("eliminar").Enabled = False
                Me.RadGrid1.Items.Item(i)("anular").Enabled = False
                Me.RadGrid1.Items.Item(i)("editar").BackColor = Drawing.Color.Gray
                Me.RadGrid1.Items.Item(i)("eliminar").BackColor = Drawing.Color.Gray
                Me.RadGrid1.Items.Item(i)("anular").BackColor = Drawing.Color.Gray

            Next
        Else
            For i = 0 To Me.RadGrid1.Items.Count - 1
                If Me.RadGrid1.Items.Item(i)("Estado").Text = "Vencido" Then
                    Me.RadGrid1.Items.Item(i)("Estado").ForeColor = Drawing.Color.Red
                Else
                    Me.RadGrid1.Items.Item(i)("Estado").ForeColor = Drawing.Color.Blue
                End If

            Next

        End If
    End Sub
    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim id As Int32

            id = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdRecibo")
            RecibosBL.UpdateEstadoRECIBO(id, "A")
        End If
        Me.RadGrid1.DataBind()
    End Sub
End Class