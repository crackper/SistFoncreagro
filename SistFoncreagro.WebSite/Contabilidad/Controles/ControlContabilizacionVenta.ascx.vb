Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlContabilizacionVenta
    Inherits System.Web.UI.UserControl

    Private _dataItem As Object = Nothing
    Dim PlanContableBl As New PlanContableBL
    Dim _PlanContable As PlanContable
    Dim proyectoBL As New ProyectoBL

    Public Property DataItem() As Object
        Get
            Return Me._dataItem
        End Get
        Set(ByVal value As Object)
            Me._dataItem = value
        End Set
    End Property

    Protected Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        Me.RadComboBox1.Filter = 1
        Me.RadComboBox2.Filter = 1
        Me.RadComboBox3.Filter = 1
        Me.RadComboBox4.Filter = 1

        If TypeOf DataItem Is GridInsertionObject Then
            Me.RadComboBox1.Enabled = True
            Me.RadComboBox2.Enabled = True
        Else
            Me.RadComboBox1.Enabled = False
            Me.RadComboBox2.Enabled = False
            Me.RadComboBox1.SelectedValue = DataBinder.Eval(DataItem, "IdClasificacion")
            If Not IsNothing(DataBinder.Eval(DataItem, "IdProyecto")) Then
                Me.RadComboBox2.SelectedValue = DataBinder.Eval(DataItem, "IdProyecto")
            End If
            If Not (DataBinder.Eval(DataItem, "IdPlanVentaInterna")).Equals(DBNull.Value) Then
                _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlanVentaInterna"))
                Me.odsPlanContable.SelectParameters("Texto").DefaultValue = _PlanContable.Nombre
                Me.RadComboBox3.DataBind()
                Me.RadComboBox3.SelectedValue = DataBinder.Eval(DataItem, "IdPlanVentaInterna")
            End If
         
            If Not (DataBinder.Eval(DataItem, "IdPlanVentaExterna")).Equals(DBNull.Value) Then
                _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlanVentaExterna"))
                Me.odsPlanContable1.SelectParameters("Texto").DefaultValue = _PlanContable.Nombre
                Me.RadComboBox4.DataBind()
                Me.RadComboBox4.SelectedValue = DataBinder.Eval(DataItem, "IdPlanVentaExterna")
            End If
          

        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
       
    End Sub

   Protected Sub RadComboBox3_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox3.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()

    End Sub

    Protected Sub RadComboBox3_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox3.ItemsRequested
        If e.Text.Length > 1 Then

            Me.odsPlanContable.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox3.DataBind()
        End If
    End Sub

    Protected Sub RadComboBox4_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles RadComboBox4.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()

    End Sub

    Protected Sub RadComboBox4_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles RadComboBox4.ItemsRequested
        If e.Text.Length > 1 Then

            Me.odsPlanContable1.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.RadComboBox4.DataBind()
        End If
    End Sub
End Class
