Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities

Public Class FrmTipoInmueble
    Inherits System.Web.UI.Page
    Dim _Tipo As New TipoInmueble
    Dim TipoBL As New TipoInmuebleBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
       
        If CType(userControl.FindControl("RadComboBox6"), RadComboBox).SelectedValue.Length > 0 Then
            _Tipo.IdPlanActivo = CType(userControl.FindControl("RadComboBox6"), RadComboBox).SelectedValue
        Else
            _Tipo.IdPlanActivo.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("RadComboBox7"), RadComboBox).SelectedValue.Length > 0 Then
            _Tipo.IdPlanDepreciacion = CType(userControl.FindControl("RadComboBox7"), RadComboBox).SelectedValue
        Else
            _Tipo.IdPlanDepreciacion.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue.Length > 0 Then
            _Tipo.IdPlanGasto = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        Else
            _Tipo.IdPlanGasto.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue <> 0 Then
            _Tipo.IdPorcDepreciacion = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        Else
            _Tipo.IdPorcDepreciacion.Equals(DBNull.Value)
        End If

        _Tipo.Tipo = CType(userControl.FindControl("TextBox1"), TextBox).Text

        TipoBL.SaveTIPOINMUEBLE(_Tipo)

    End Sub

    Protected Sub RadGrid2_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.DeleteCommand
        Dim IdTipo As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdTipo").ToString
        Try
             TipoBL.DeleteTIPOINMUEBLE(IdTipo)
        Catch ex As Exception
            Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡No se puede eliminar el registro porque está siendo utilizado!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
            Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
            e.Canceled = True
        End Try
    End Sub

    Protected Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
       
        If CType(userControl.FindControl("RadComboBox6"), RadComboBox).SelectedValue.Length > 0 Then
            _Tipo.IdPlanActivo = CType(userControl.FindControl("RadComboBox6"), RadComboBox).SelectedValue
        Else
            _Tipo.IdPlanActivo.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("RadComboBox7"), RadComboBox).SelectedValue.Length > 0 Then
            _Tipo.IdPlanDepreciacion = CType(userControl.FindControl("RadComboBox7"), RadComboBox).SelectedValue
        Else
            _Tipo.IdPlanDepreciacion.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue.Length > 0 Then
            _Tipo.IdPlanGasto = CType(userControl.FindControl("RadComboBox8"), RadComboBox).SelectedValue
        Else
            _Tipo.IdPlanGasto.Equals(DBNull.Value)
        End If
        If CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue <> 0 Then
            _Tipo.IdPorcDepreciacion = CType(userControl.FindControl("DropDownList1"), DropDownList).SelectedValue
        Else
            _Tipo.IdPorcDepreciacion.Equals(DBNull.Value)
        End If
        _Tipo.Tipo = CType(userControl.FindControl("TextBox1"), TextBox).Text
        _Tipo.IdTipo = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdTipo")
        TipoBL.SaveTIPOINMUEBLE(_Tipo)

    End Sub
End Class