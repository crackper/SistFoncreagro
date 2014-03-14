Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Imports Telerik.Web.UI
Public Class FrmCargo
    Inherits System.Web.UI.Page
    Dim cargoBl As New CargoBL
    'Dim cargo As Cargo

    Protected Sub RadGrid1_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim cargo As New Cargo
        Dim coleccion As New Collection

        cargo = PasarDatosDelControlAlObject(userControl)

        Try
            coleccion = cargoBl.InsertCargoNomCargo(cargo)

            If Convert.ToString(coleccion.Item("condicion")) = "E" Then
                Dim label As Label = CType(UserControl.FindControl("lblMensaje"), Label)
                label.Visible = True
                label.Text = coleccion("mensaje")
                e.Canceled = True

            End If
        Catch ex As Exception

        End Try


    End Sub

    Protected Sub RadGrid1_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim cargo As New Cargo
        'cargo = PasarDatosDelControlAlObject(userControl)
        'ProveedorCliente.IdProveedorCliente = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdProveedorCliente")
        Try
            cargoBl.SaveCargo(PasarDatosDelControlAlObject(userControl))
        Catch ex As Exception

        End Try
    End Sub

    Function PasarDatosDelControlAlObject(ByVal userControl As UserControl) As Cargo
        Dim cargo As New Cargo

        cargo.IdCargo = Convert.ToInt32(CType(userControl.FindControl("txtIdCargo"), TextBox).Text)
        cargo.NomCargo = CType(userControl.FindControl("txtNomCargo"), TextBox).Text
        cargo.DescCargo = CType(userControl.FindControl("txtDescCargo"), TextBox).Text

        Return cargo

    End Function

    Protected Sub RadGrid1_DeleteCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.DeleteCommand
        Dim editedItem As GridEditableItem

        editedItem = CType(e.Item, GridEditableItem)

        Try
            cargoBl.DeleteCargo(editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdCargo"))
        Catch ex As Exception

            Dim script As String = String.Format("alert('{0}');", "Este cargo está creado como Posición en alguna Área. No lo puede eliminar sin antes eliminar la posición")

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "alertaerror", script, True)

        End Try

    End Sub
End Class