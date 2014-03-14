Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class ControlManttoClasificacion
    Inherits System.Web.UI.UserControl
    Dim TransaccionBL As New TransaccionBL
    Dim _transaccion As Transaccion
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
    Private Sub Page_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataBinding
        If TypeOf DataItem Is GridInsertionObject Then
            txtDescripcion.Text = ""
            ImageButton3.Visible = False
        Else
            ImageButton2.Visible = False
            txtDescripcion.Text = DataBinder.Eval(DataItem, "Descripcion").ToString

            If Not (DataBinder.Eval(DataItem, "IdPlan")).Equals(DBNull.Value) Then
                _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlan"))
                Me.odsPlanContable.SelectParameters("Texto").DefaultValue = _PlanContable.Nombre
                Me.rcbPlan.DataBind()
                Me.rcbPlan.SelectedValue = DataBinder.Eval(DataItem, "IdPlan")
            End If

            If Not IsNothing(DataBinder.Eval(DataItem, "Codigo")) Then
                txtCodigo.Text = DataBinder.Eval(DataItem, "Codigo").ToString
            End If
            
            If DataBinder.Eval(DataItem, "IdPlanActivoFijo") > 0 Then
                _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlanActivoFijo"))
                Me.odsPlanContable1.SelectParameters("Texto").DefaultValue = _PlanContable.Nombre
                Me.rcbPlanActivoFijo.DataBind()
                Me.rcbPlanActivoFijo.SelectedValue = DataBinder.Eval(DataItem, "IdPlanActivoFijo")
            End If
            If DataBinder.Eval(DataItem, "IdPorcDepreciacion") > 0 Then
                Me.rcbPorcentaje.SelectedValue = DataBinder.Eval(DataItem, "IdPorcDepreciacion")
            End If
            If DataBinder.Eval(DataItem, "IdPlanDepreciacion") > 0 Then
                _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlanDepreciacion"))
                Me.odsPlanContable2.SelectParameters("Texto").DefaultValue = _PlanContable.Nombre
                Me.rcbPlanDepreciacion.DataBind()
                Me.rcbPlanDepreciacion.SelectedValue = DataBinder.Eval(DataItem, "IdPlanDepreciacion")
            End If
            If DataBinder.Eval(DataItem, "IdPlanDepreciacion1") > 0 Then
                _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlanDepreciacion1"))
                Me.odsPlanContable3.SelectParameters("Texto").DefaultValue = _PlanContable.Nombre
                Me.rcbDepreciacionGasto.DataBind()
                Me.rcbDepreciacionGasto.SelectedValue = DataBinder.Eval(DataItem, "IdPlanDepreciacion1")
            End If
            If DataBinder.Eval(DataItem, "IdPlanDonacion") > 0 Then
                _PlanContable = PlanContableBl.GetPLANCONTABLEByIdPlan(DataBinder.Eval(DataItem, "IdPlanDonacion"))
                Me.odsPlanContable4.SelectParameters("Texto").DefaultValue = _PlanContable.Nombre
                Me.rcbPlanDonacion.DataBind()
                Me.rcbPlanDonacion.SelectedValue = DataBinder.Eval(DataItem, "IdPlanDonacion")
            End If

            End If
    End Sub
    'Protected Sub RadComboBox1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcbPlan.ItemDataBound
    '    e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
    '    e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    'End Sub
    'Protected Sub RadComboBox1_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles rcbPlan.ItemsRequested
    '    If e.Text.Length > 3 Then
    '        Me.rcbPlan.DataSourceID = "odsPlanContable"
    '        Me.odsPorcentaje.SelectParameters("Texto").DefaultValue = e.Text.ToString
    '        Me.rcbPlan.DataBind()
    '    End If
    'End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub rcbPlan_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcbPlan.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

   
    Protected Sub rcbPlan_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles rcbPlan.ItemsRequested
        If e.Text.Length > 1 Then
            Me.rcbPlan.DataSourceID = "odsPlanContable"
            Me.odsPlanContable.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.rcbPlan.DataBind()
        End If

    End Sub

    Protected Sub rcbPlanDepreciacion_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcbPlanDepreciacion.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub rcbPlanDepreciacion_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles rcbPlanDepreciacion.ItemsRequested
      If e.Text.Length > 1 Then
            Me.rcbPlanDepreciacion.DataSourceID = "odsPlanContable2"
            Me.odsPlanContable2.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.rcbPlanDepreciacion.DataBind()
        End If
    End Sub

    Protected Sub rcbPlanActivoFijo_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcbPlanActivoFijo.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub rcbPlanActivoFijo_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles rcbPlanActivoFijo.ItemsRequested
        If e.Text.Length > 1 Then
            Me.rcbPlanActivoFijo.DataSourceID = "odsPlanContable1"
            Me.odsPlanContable1.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.rcbPlanActivoFijo.DataBind()
        End If
    End Sub

    Protected Sub rcbPlanDonacion_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcbPlanDonacion.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub rcbPlanDonacion_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles rcbPlanDonacion.ItemsRequested
        If e.Text.Length > 1 Then
            Me.rcbPlanDonacion.DataSourceID = "odsPlanContable4"
            Me.odsPlanContable4.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.rcbPlanDonacion.DataBind()
        End If
       
    End Sub

    Protected Sub rcbDepreciacionGasto_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemEventArgs) Handles rcbDepreciacionGasto.ItemDataBound
        e.Item.Text = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).Cuenta.ToString()
        e.Item.Value = (DirectCast(e.Item.DataItem, SistFoncreagro.BussinessEntities.PlanContable)).IdPlan.ToString()
    End Sub

    Protected Sub rcbDepreciacionGasto_ItemsRequested(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs) Handles rcbDepreciacionGasto.ItemsRequested
        If e.Text.Length > 1 Then
            Me.rcbDepreciacionGasto.DataSourceID = "odsPlanContable3"
            Me.odsPlanContable3.SelectParameters("Texto").DefaultValue = e.Text.ToString
            Me.rcbDepreciacionGasto.DataBind()
        End If
       
    End Sub
End Class