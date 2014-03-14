Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class VentanaAsistentes
    Inherits System.Web.UI.Page
    Dim asistenteCoti As AsistenteCotizacion
    Dim asistenteCotiBl As New AsistenteCotizacionBL

    Protected Sub rbPersonalFoncreagro_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbPersonalFoncreagro.CheckedChanged
        If rbPersonalFoncreagro.Checked = True Then
            txtNombreExterno.Enabled = False
            txtCargo.Enabled = False
            txtNombreExterno.Text = ""
            txtCargo.Text = ""
            rcmbPersonal.Enabled = True
            lbAgregar.ValidationGroup = Nothing
        End If
    End Sub

    Protected Sub rbPersonalExterno_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbPersonalExterno.CheckedChanged
        If rbPersonalExterno.Checked = True Then
            txtNombreExterno.Enabled = True
            txtCargo.Enabled = True
            rcmbPersonal.Enabled = False
            lbAgregar.ValidationGroup = "validar"
        End If
    End Sub

    Protected Sub lbAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAgregar.Click
        asistenteCoti = New AsistenteCotizacion
        asistenteCoti.IdCotizacion = CInt(Request.QueryString("IdCotizacion"))
        asistenteCoti.Tipo = IIf(rbPersonalFoncreagro.Checked = True, True, False)
        asistenteCoti.IdPersonal = rcmbPersonal.SelectedValue
        asistenteCoti.Nombre = txtNombreExterno.Text
        asistenteCoti.Cargo = txtCargo.Text
        asistenteCotiBl.SaveAsistenteCotizacion(asistenteCoti)
        gvAsistenteCotizacion.DataBind()
    End Sub

    Protected Sub gvAsistenteCotizacion_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvAsistenteCotizacion.RowCommand
        Dim index = e.CommandArgument
        If e.CommandName = "Eliminar" Then
            Dim txtIdAsistCotizacion As TextBox = CType(gvAsistenteCotizacion.Rows(index).FindControl("txtIdAsistenteCotizacion"), TextBox)
            asistenteCotiBl.DeleteAsistenteCotizacion(CInt(txtIdAsistCotizacion.Text))
            gvAsistenteCotizacion.DataBind()
        End If
    End Sub
End Class