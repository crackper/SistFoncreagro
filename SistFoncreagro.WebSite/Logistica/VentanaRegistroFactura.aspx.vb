Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class VentanaRegistroFactura
    Inherits System.Web.UI.Page
    Dim Iocfact As IOcxFacturaBL
    Dim ocFact As OcxFactura
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            lblOrden.Text = Request.QueryString("nro")
            lblArea.Text = Request.QueryString("are")
            lblMonto.Text = Request.QueryString("Moned") & Request.QueryString("Mont")
            Session("id") = Request.QueryString("idoc")
            Session("NroOrden") = lblOrden.Text
            Session("ar") = lblArea.Text
            Session("fact") = Request.QueryString("fac")
            Session("Monto") = Request.QueryString("Mont")
            Session("Moneda") = Request.QueryString("Moned")
            If Request.QueryString("fac") = "True" Then
                btnGuardar.Visible = False
                gvDetalle.Columns(0).Visible = False
            End If
        End If
    End Sub

    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardar.Click
        Iocfact = New OcxFacturaBL
        ocFact = New OcxFactura
        ocFact.IdOrdenCompra = Request.QueryString("idoc")
        ocFact.Serie = txtSerie.Text
        ocFact.Numero = txtNumero.Text
        ocFact.Monto = CDec(txtMonto.Text)
        ocFact.Fecha = rdpFecha.SelectedDate
        ocFact.IdTipoDocumento = rcbTipoDocumento.SelectedValue
        ocFact.FechaRecepcion = rdpFechaRecepcion.SelectedDate
        Iocfact.SaveOcxFactura(ocFact)
        gvDetalle.DataBind()
    End Sub

    Protected Sub gvDetalle_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvDetalle.RowCommand
        Iocfact = New OcxFacturaBL
        Dim index = e.CommandArgument
        If e.CommandName = "Eliminar" Then
            Dim txtIdDet As TextBox = CType(gvDetalle.Rows(index).FindControl("txtIdDet"), TextBox)
            Try
                Iocfact.DeletaOcxFactura(CInt(txtIdDet.Text))
                gvDetalle.DataBind()
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class