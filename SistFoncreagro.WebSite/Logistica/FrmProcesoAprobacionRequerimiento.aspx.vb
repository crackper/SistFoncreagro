Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class FrmProcesoAprobacionRequerimiento
    Inherits System.Web.UI.Page
    Dim aprobarReqBl As New AprobarRequerimientoBL
    Dim aprobarReq As AprobarRequerimiento

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    'Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.SelectedIndexChanged
    '    'Dim gvProv As GridView = CType(sender, GridView)
    '    'For i = 0 To gvProv.Rows.Count - 1
    '    '    Dim rButon As RadioButton = CType(gvProv.Rows(i).FindControl("rbSeleccionarProveedor"), RadioButton)
    '    '    rButon.Checked = False
    '    '    gvProv.Rows(i).BackColor = Nothing
    '    'Next
    '    'gvProv.SelectedRow.BackColor = Drawing.Color.Gainsboro
    '    'Dim rButonSelec As RadioButton = CType(gvProv.SelectedRow.FindControl("rbSeleccionarProveedor"), RadioButton)
    '    'rButonSelec.Checked = True

    '    For i = 0 To GridView1.Rows.Count - 1
    '        GridView1.Rows(i).BackColor = Nothing
    '    Next
    '    rcbRoles.Text = Nothing
    '    GridView1.SelectedRow.BackColor = Drawing.Color.Gainsboro
    '    Dim cbGrilla As CheckBox = CType(GridView1.SelectedRow.FindControl("cbAreaProyectoDetalle"), CheckBox)
    '    Dim lblOrden As Label = CType(GridView1.SelectedRow.FindControl("lblOrden"), Label)
    '    Dim IdRol As TextBox = CType(GridView1.SelectedRow.FindControl("txtIdRol"), TextBox)
    '    rcbRoles.SelectedValue = CInt(IdRol.Text)
    '    cbAreaProyecto.Checked = (IIf(cbGrilla.Checked = True, True, False))
    '    txtOrden.Text = lblOrden.Text
    '    lbActualizar.Visible = True
    '    lbAgregar.Visible = False
    '    lbCancelar.Visible = True
    '    RequiredFieldValidator1.Enabled = False
    '    RequiredFieldValidator2.Enabled = False
    '    ValidationSummary1.Enabled = False
    'End Sub

    'Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
    '    Dim index = e.CommandArgument
    '    If e.CommandName = "DeleteItem" Then
    '        Dim txtIdAprobarRequerimiento As TextBox = CType(GridView1.Rows(index).FindControl("txtIdAprobarRequerimiento"), TextBox)
    '        aprobarReqBl.DeleteNivelAprobarRequerimiento(CInt(txtIdAprobarRequerimiento.Text))
    '        GridView1.DataBind()
    '    End If
    'End Sub

    'Protected Sub lbCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbCancelar.Click
    '    For i = 0 To GridView1.Rows.Count - 1
    '        GridView1.Rows(i).BackColor = Nothing
    '    Next
    '    rcbRoles.Text = ""
    '    rcbRoles.Text = Nothing
    '    txtOrden.Text = ""
    '    cbAreaProyecto.Checked = False
    '    rcbRoles.SelectedValue = Nothing

    '    lbActualizar.Visible = False
    '    lbAgregar.Visible = True


    '    lbCancelar.Visible = False
    'End Sub

    'Protected Sub lbAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAgregar.Click
    '    RequiredFieldValidator1.Enabled = True
    '    RequiredFieldValidator2.Enabled = True
    '    ValidationSummary1.Enabled = True
    'End Sub

    Protected Sub RadGrid2_InsertCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.InsertCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        aprobarReq = New AprobarRequerimiento

        aprobarReq.IdRol = CType(userControl.FindControl("rcbRoles"), RadComboBox).SelectedValue
        aprobarReq.Orden = CType(userControl.FindControl("txtOrden"), TextBox).Text
        aprobarReq.AreaProyecto = CType(userControl.FindControl("cbAreaProyecto"), CheckBox).Checked

        For i = 0 To RadGrid2.Items.Count - 1
            If CInt(TextBox1.Text) = 0 Then
                If CInt(CType(userControl.FindControl("txtOrden"), TextBox).Text) = CInt(CType(RadGrid2.Items(i).FindControl("txtOrdenGrilla"), TextBox).Text) Then
                    TextBox1.Text = 1
                End If
            End If
        Next

        If CInt(TextBox1.Text) = 1 Then
            lblMensaje.Text = "El Orden asignado no está permitido."
            lblMensaje.Visible = True
        Else
            Dim resultado As Int32 = aprobarReqBl.SaveNivelAprobarRequerimiento(aprobarReq)
            If resultado = 1 Then
                lblMensaje.Visible = True
                lblMensaje.Text = "Verificar roles, no se pueden registrar dos roles seguidos."
            Else
                If resultado = 0 Then
                    lblMensaje.Text = "No se puede agregar un nivel de aprobación debido a que hay requerimientos de compra pendientes de aprobación."
                    lblMensaje.Visible = True
                Else
                    lblMensaje.Visible = False
                End If
            End If
        End If
        TextBox1.Text = "0"
    End Sub

    Protected Sub RadGrid2_UpdateCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.UpdateCommand
        Dim userControl As UserControl = CType(e.Item.FindControl(GridEditFormItem.EditFormUserControlID), UserControl)
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
        aprobarReq = New AprobarRequerimiento
        aprobarReq.IdAprobarRequerimiento = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdAprobarRequerimiento")
        aprobarReq.IdRol = CType(userControl.FindControl("rcbRoles"), RadComboBox).SelectedValue
        aprobarReq.Orden = CType(userControl.FindControl("txtOrden"), TextBox).Text
        aprobarReq.AreaProyecto = CType(userControl.FindControl("cbAreaProyecto"), CheckBox).Checked
        'For i = 0 To RadGrid2.Items.Count - 1
        '    If CInt(TextBox1.Text) = 0 Then
        '        If CInt(CType(userControl.FindControl("txtOrden"), TextBox).Text) = CInt(CType(RadGrid2.Items(i).FindControl("txtOrdenGrilla"), TextBox).Text) Then
        'TextBox1.Text = 0
        '        End If
        '    End If
        'Next

        'If CInt(TextBox1.Text) = 1 Then
        '    lblMensaje.Text = "El Orden asignado no está permitido."
        '    lblMensaje.Visible = True
        'Else
        Dim resultado As Int32 = aprobarReqBl.UpdateNivelAprobarRequerimiento(aprobarReq)
        If resultado = 3 Then
            lblMensaje.Visible = True
            lblMensaje.Text = "No se pueden registrar dos roles seguidos o verificar el orden ingresado"
        Else
            If resultado = 0 Then
                lblMensaje.Text = "No se puede agregar un nivel de aprobación debido a que hay requerimientos de compra pendientes de aprobación."
                lblMensaje.Visible = True
            Else
                lblMensaje.Visible = False
            End If
        End If
        'End If
        TextBox1.Text = "0"
    End Sub

    Protected Sub RadGrid2_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid2.ItemCommand
        If e.CommandName = "EliminarRegistro" Then
            Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)
            Dim IdAprobarRequerimiento As Int32 = editedItem.OwnerTableView.DataKeyValues(editedItem.ItemIndex)("IdAprobarRequerimiento")
            If aprobarReqBl.DeleteNivelAprobarRequerimiento(IdAprobarRequerimiento) = True Then
                lblMensaje.Text = "Nivel de Aprobación Eliminado."
                lblMensaje.Visible = True
                Me.RadGrid2.DataBind()
                lblMensaje.Visible = False
            Else
                lblMensaje.Text = "No se puede eliminar el nivel de aprobación debido a que hay requerimientos de compra pendientes de aprobación."
                lblMensaje.Visible = True
            End If
        End If
    End Sub
End Class