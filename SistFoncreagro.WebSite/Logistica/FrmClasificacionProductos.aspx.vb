Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmClasificacionProductos
    Inherits System.Web.UI.Page
    Dim clasificacionBl As New ClasificacionBL
    Dim clasificacion As Clasificacion
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If CInt(Request.QueryString("IdClasificacion")) = 1 Then
                txtTipo.Text = "1"
                lblTitulo.Text = "Clasificación de Servicios"
            End If
        End If
    End Sub
    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        clasificacion = New Clasificacion
        clasificacionBl.SaveClasificacion(ObtenerClasificacion(clasificacion, e))
    End Sub
    Protected Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        clasificacion = New Clasificacion
        clasificacion.IdClasificacion = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdClasificacion")
        clasificacionBl.SaveClasificacion(ObtenerClasificacion(clasificacion, e))
    End Sub
    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim IdClasificacion As Int32 = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdClasificacion")
            clasificacionBl.DeleteClasificacion(IdClasificacion)
            Me.RadGrid2.DataBind()
        End If
    End Sub
    Public Function ObtenerClasificacion(ByVal mClasificaion As Clasificacion, ByVal e As Telerik.Web.UI.GridCommandEventArgs)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        mClasificaion.Descripcion = CType(userControl.FindControl("txtDescripcion"), TextBox).Text
        mClasificaion.Tipo = CInt(txtTipo.Text)
        mClasificaion.IdPlan = CType(userControl.FindControl("rcbPlan"), RadComboBox).SelectedValue
        Dim rcmb As RadComboBox
        rcmb = CType(userControl.FindControl("rcbPlanDonacion"), RadComboBox)
        If rcmb.SelectedValue.Length > 0 Then
            mClasificaion.IdPlanDonacion = rcmb.SelectedValue
        End If
        rcmb = CType(userControl.FindControl("rcbPlanActivoFijo"), RadComboBox)
        If rcmb.SelectedValue.Length > 0 Then
            mClasificaion.IdPlanActivoFijo = rcmb.SelectedValue
        End If
        rcmb = CType(userControl.FindControl("rcbPorcentaje"), RadComboBox)
        If rcmb.SelectedValue.Length > 0 Then
            mClasificaion.IdPorcDepreciacion = rcmb.SelectedValue
        End If
        rcmb = CType(userControl.FindControl("rcbPlanDepreciacion"), RadComboBox)
        If rcmb.SelectedValue.Length > 0 Then
            mClasificaion.IdPlanDepreciacion = rcmb.SelectedValue
        End If
        rcmb = CType(userControl.FindControl("rcbDepreciacionGasto"), RadComboBox)
        If rcmb.SelectedValue.Length > 0 Then
            mClasificaion.IdPlanDepreciacion1 = rcmb.SelectedValue
        End If
        mClasificaion.Codigo = CType(userControl.FindControl("txtCodigo"), TextBox).Text
        Return mClasificaion
    End Function

End Class