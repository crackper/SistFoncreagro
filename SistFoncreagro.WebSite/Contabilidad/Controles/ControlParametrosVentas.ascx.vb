Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlParametrosVentas
    Inherits System.Web.UI.UserControl
    Dim PlanContableBl As New PlanContableBL
    Dim _PlanContable As PlanContable
    Private _dataItem As Object = Nothing
    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        Me.RadComboBox1.Filter = 1

        If TypeOf DataItem Is GridInsertionObject Then

        Else
            Me.DropDownList1.SelectedValue = DataBinder.Eval(DataItem, "IdTipoParametro")
            _PlanContable = PlanContableBL.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlan"))
            Me.RadComboBox1.DataSourceID = "odsPlanContable"
            Me.odsPlanContable.SelectParameters("Texto").DefaultValue = _PlanContable.Nombre
            Me.RadComboBox1.DataBind()
            Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "IdPlan")
             End If
    End Sub
    Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox1.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub
    Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox1.ItemsRequested
        If e.Text.Length > 1 Then
            Me.RadComboBox1.DataSourceID = "odsPlanContable"
            Me.odsPlanContable.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox1.DataBind()
        End If
    End Sub
End Class