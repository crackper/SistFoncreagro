Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlTipoInmueble
    Inherits System.Web.UI.UserControl
    Dim _PlanContable1 As PlanContable
    Dim PlanContableBL As New PlanContableBL
    Private _dataItem As Object = Nothing
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        If TypeOf DataItem Is GridInsertionObject Then

        Else
            Me.TextBox1.Text = DataBinder.Eval(DataItem, "Tipo")

            If Not DataBinder.Eval(DataItem, "IdPlanActivo").Equals(DBNull.Value) Then
                _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlanActivo"))
                Me.RadComboBox6.DataSourceID = "odsPlanContable1"
                Me.odsPlanContable1.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                Me.RadComboBox6.DataBind()
                Me.RadComboBox6.SelectedValue = DataBinder.Eval(DataItem, "IdPlanActivo")
            End If


            If Not DataBinder.Eval(DataItem, "IdPlanDepreciacion").Equals(DBNull.Value) Then
                _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlanDepreciacion"))
                Me.RadComboBox7.DataSourceID = "odsPlanContable2"
                Me.odsPlanContable2.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                Me.RadComboBox7.DataBind()
                Me.RadComboBox7.SelectedValue = DataBinder.Eval(DataItem, "IdPlanDepreciacion")
            End If

            If Not DataBinder.Eval(DataItem, "IdPlanGasto").Equals(DBNull.Value) Then
                _PlanContable1 = PlanContableBL.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlanGasto"))
                Me.RadComboBox8.DataSourceID = "odsPlanContable3"
                Me.odsPlanContable3.SelectParameters("Texto").DefaultValue = _PlanContable1.Nombre
                Me.RadComboBox8.DataBind()
                Me.RadComboBox8.SelectedValue = DataBinder.Eval(DataItem, "IdPlanGasto")
            End If

            If Not DataBinder.Eval(DataItem, "IdPorcDepreciacion").Equals(DBNull.Value) Then
                Me.DropDownList1.SelectedValue = DataBinder.Eval(DataItem, "IdPorcDepreciacion")
            End If
        End If
    End Sub
    Protected Sub RadComboBox6_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox6.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox6_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox6.ItemsRequested
        If e.Text.Length > 1 Then
            Me.RadComboBox6.DataSourceID = "odsPlanContable1"
            Me.odsPlanContable1.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox6.DataBind()
        End If
    End Sub

    Protected Sub RadComboBox7_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox7.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub RadComboBox7_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox7.ItemsRequested
        If e.Text.Length > 1 Then
            Me.RadComboBox7.DataSourceID = "odsPlanContable2"
            Me.odsPlanContable2.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox7.DataBind()
        End If
    End Sub

    Protected Sub RadComboBox8_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox8.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub
    Protected Sub RadComboBox8_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox8.ItemsRequested
        If e.Text.Length > 1 Then
            Me.RadComboBox8.DataSourceID = "odsPlanContable3"
            Me.odsPlanContable3.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox8.DataBind()
        End If
    End Sub
End Class