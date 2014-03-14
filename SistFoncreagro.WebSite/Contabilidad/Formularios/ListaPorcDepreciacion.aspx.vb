Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities

Public Class ListaPorcDepreciacion
    Inherits System.Web.UI.Page
    Dim _Porcentaje As New PorcDepreciacion
    Dim PorcentajeBL As New PorcDepreciacionBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim IdPorcentaje As String = (CType(e.Item, GridDataItem)).OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdPorcDepreciacion").ToString
        Try
            PorcentajeBL.DeletePORCDEPRECIACION(IdPorcentaje)
        Catch ex As Exception
            Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡No se puede eliminar el registro porque está siendo utilizado!</b> ', 330, 210); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", radalertscript.ToString, False)
            e.Canceled = True
        End Try
    End Sub

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        _Porcentaje.Tipo = CType(e.Item.FindControl("TextBox2"), TextBox).Text
        _Porcentaje.Valor = CType(e.Item.FindControl("RadNumericTextBox2"), RadNumericTextBox).Text

        PorcentajeBL.SavePORCDEPRECIACION(_Porcentaje)
    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        _Porcentaje.Tipo = CType(e.Item.FindControl("TextBox1"), TextBox).Text
        _Porcentaje.Valor = CType(e.Item.FindControl("RadNumericTextBox1"), RadNumericTextBox).Text
        _Porcentaje.IdPorcDepreciacion = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdPorcDepreciacion")

        PorcentajeBL.SavePORCDEPRECIACION(_Porcentaje)
    End Sub
End Class