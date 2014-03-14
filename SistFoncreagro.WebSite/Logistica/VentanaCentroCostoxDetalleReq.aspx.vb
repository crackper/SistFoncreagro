Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities

Public Class VentanaCentroCostoxDetalleReq
    Inherits System.Web.UI.Page

    Dim centroCostoDetalleRequerimientoBl As ICCostoDetalleRequerimientoBL
    Protected Sub lbAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAgregar.Click
        'MsgBox(Request.QueryString("IdDetalle"))
        'MsgBox(Request.QueryString("IdProyecto"))

        Dim _cCostoDetalleRequerimiento As New CCostoxDetalleRequerimiento
        Dim _cCostoDetalleRequerimientoBL As New CCostoDetalleRequerimientoBL

        _cCostoDetalleRequerimiento.IdDetalleRequerimiento = CInt(Request.QueryString("IdDetalle"))
        _cCostoDetalleRequerimiento.IdCentroCosto = rcbCentroCosto.SelectedValue

        _cCostoDetalleRequerimientoBL.SaveCCostoDetalleRequerimiento(_cCostoDetalleRequerimiento)
        gvCentroCosto.DataBind()
    End Sub

    Protected Sub gvCentroCosto_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvCentroCosto.RowCommand
        centroCostoDetalleRequerimientoBl = New CCostoDetalleRequerimientoBL
        Dim index = e.CommandArgument
        If e.CommandName = "Eliminar" Then
            If gvCentroCosto.Rows.Count > 1 Then
                Dim txtIdDetalleRequerimiento As TextBox = CType(gvCentroCosto.Rows(index).FindControl("txtIdCcostoDetalle"), TextBox)

                centroCostoDetalleRequerimientoBl.DeleteCCostoDetalleRequerimiento(CInt(txtIdDetalleRequerimiento.Text))
                gvCentroCosto.DataBind()
            End If
            
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        TextBox1.Text = Request.QueryString("Producto")
        If (Request.QueryString("Estado") = "0") Then
            rcbCentroCosto.Enabled = False
            lbAgregar.Visible = False
            gvCentroCosto.Columns(1).Visible = False
        End If
        'If CInt(Request.QueryString("Anular")) = 0 Then
        '    rcbCentroCosto.Enabled = False
        '    lbAgregar.Enabled = False
        '    gvCentroCosto.Enabled = False
        'End If
    End Sub

End Class