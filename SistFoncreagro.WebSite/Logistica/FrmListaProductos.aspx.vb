Imports SistFoncreagro.BussinesLogic
Imports Telerik.Web.UI
Public Class FrmListaProductos
    Inherits System.Web.UI.Page
    Dim catalogoBl As New CatalogoBL

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "InitInsert" Then
            Dim cadena_java As String
            ''cadena_java = "<script type='text/javascript'> NuevoColaborador();" & Chr(60) & "/script >"
            ''ScriptManager.RegisterStartupScript(Page, GetType(Page), "Nuevo", cadena_java.ToString, False)

            ' ''Response.Redirect("~\RRHH\Formulario\FrmRegistroPersonal.aspx?IdPersonal=0")
            cadena_java = "<script type='text/javascript'> " & _
                                 " NuevoProducto(); " & _
                                 Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
            e.Canceled = True
        ElseIf e.CommandName = "Anular" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim Idcat As Int32 = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdCatalogo")
            catalogoBl.DeleteCatalogo(Idcat)
            Me.RadGrid2.DataBind()
        End If
    End Sub

    Protected Sub RadGrid2_ItemCreated(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RadGrid2.ItemCreated
        If TypeOf e.Item Is GridDataItem Then
            Dim imageButon As ImageButton = DirectCast(e.Item.FindControl("EditButton"), ImageButton)
            Dim idCatalogo = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("IdCatalogo")
            imageButon.Attributes.Add("onClick", "CargarVentanaCatalogo(" & idCatalogo & ", 'editar'); return false;")
        End If
    End Sub
End Class