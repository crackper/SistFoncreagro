Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI
Public Class FrmOrdenCompraEditar
    Inherits System.Web.UI.Page
    Dim ordenCompraBL As IOrdenCompraBL
    Dim _proyectoBl As IProyectoBL
    Dim _proyecto As New Proyecto
    Dim _rutaBl As IRutaRequerimientoBL
    Dim _ruta As RutaRequerimiento
    Dim montoSubTotal As Decimal
    Dim montoIgv As Decimal
    Dim montoTotalFinal As Decimal
    Dim validar As Int32
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim IdOrdenCompra As Integer = CInt(Request.QueryString("IdOrdenCompra"))
            ordenCompraBL = New OrdenCompraBL
            Dim ordenCompra = ordenCompraBL.GetOrdenCompraByIdOrdenCompra(IdOrdenCompra, True)
            cargaOrdenCompra(ordenCompra)
        End If
    End Sub

    Public Sub cargaOrdenCompra(ByVal ordenCompra As OrdenCompra)
        Dim estado As Int32 = 3
        validar = 0
        _proyectoBl = New ProyectoBL
        _proyecto = _proyectoBl.GetFromProyectoByIdProyecto(ordenCompra.requerimiento.IdProyectoArea)
        lblNumeroOc.Text = ordenCompra.NumeroOrden
        lblTipoOc.Text = ordenCompra.Tipo
        lblEstadoOrdenCompra.Text = ordenCompra.Estado
        lblNumeroRequerimiento.Text = ordenCompra.requerimiento.Numero
        lblRequeridoPor.Text = ordenCompra.requerimiento.NombreRequiere
        txtIdProyecto.Text = ordenCompra.requerimiento.IdProyectoArea
        ddlTipoPago.SelectedValue = ordenCompra.IdTipoPago
        ddlMoneda.SelectedValue = ordenCompra.IdMoneda
        ddlTipoDocumento.SelectedValue = ordenCompra.IdTipoDocumento
        lblProveedorTexto.Text = ordenCompra.NombreProveedorCompleato
        lblAreaProyecto.Text = _proyecto.Nombre
        txtAnticipo.Text = ordenCompra.Anticipo
        txtObservacion.Text = ordenCompra.Observacion
        ddlDestino.SelectedValue = ordenCompra.Destino
        txtIgv.Text = ordenCompra.IgvPor / 100
        txtIdCotizacion.Text = ordenCompra.IdCotizacion
        txtIdProveedor.Text = ordenCompra.IdProveedor
        lblSustento.Text = ordenCompra.requerimiento.Sustento
        If ordenCompra.Tipo = "SERVICIO" Then
            txtValidarOrden.Text = "0"
            If ordenCompra.requerimiento.Periodo = True Then
                lblPeriodo.Text = "Desde   " & Format(ordenCompra.requerimiento.FechaInicioServicio, "short date") & "   hasta   " & Convert.ToString(Format(ordenCompra.requerimiento.FechaFinServicio, "short date"))
            End If
            If ordenCompra.requerimiento.Ruta = True Then
                Dim origen, destino As String
                _rutaBl = New RutaRequerimientoBL
                _ruta = _rutaBl.GetRutaRequerimientoByIdRuta(ordenCompra.requerimiento.IdRutaOrigen)
                origen = _ruta.Nombre
                _ruta = _rutaBl.GetRutaRequerimientoByIdRuta(ordenCompra.requerimiento.IdRutaDestino)
                destino = _ruta.Nombre
                lblOrigen.Text = "De " & origen & " hasta " & destino
            End If
        Else
            txtValidarOrden.Text = "1"
        End If
        If GridView1.Rows.Count = 1 Then
            If ordenCompra.Estado <> "Rechazado" Then
                lbAnularOc.Visible = False
                panelAnular.Visible = False
                lbSolicitarAprobacion.Visible = False
            End If
        Else
            If GridView1.Rows.Count > 1 Then
                validar = 1
                ddlTipoDocumento.Enabled = False
                ddlMoneda.Enabled = False
                ddlTipoPago.Enabled = False
                txtAnticipo.Enabled = False
                ddlDestino.Enabled = False
                If ordenCompra.Estado <> "Rechazado" Then
                    lbAnularOc.Visible = False
                    panelAnular.Visible = False
                    lbSolicitarAprobacion.Visible = False
                End If
                If (ordenCompra.Estado = "Aprobado" Or ordenCompra.Estado = "Enviado" Or ordenCompra.Estado = "Recepcionado") Then
                    lbSolicitarAprobacion.Visible = False
                    txtObservacion.Enabled = False
                    btnActualizarCabecera.Visible = False
                    If Request.QueryString("accion") = "porAprobar" Then
                        lbAnularOc.Visible = True
                        panelAnular.Visible = True
                    End If
                    estado = 1
                End If
            End If
        End If
        gvDetalleOrdenCompra.DataSource = ordenCompra.detalleOrdenCompra
        gvDetalleOrdenCompra.DataBind()
        Cache.Insert("ordenCompra", ordenCompra)
        EliminarFila(0, CInt(txtValidarOrden.Text))
        If ordenCompra.ActivarCentroCosto = False Then
            gvDetalleOrdenCompra.Columns(8).Visible = False
        Else
            gvDetalleOrdenCompra.Columns(9).Visible = False
        End If
        lbHistorico.Attributes.Add("onClick", "CargarHistorico(" & ordenCompra.IdOrdenCompra & "); return false;")
        lbAdjuntarArchivo.Attributes.Add("onClick", "CargarVentanaCotizacion(" & ordenCompra.IdCotizacion & "," & estado & "); return false;")
        lbCuadroComparativo.Attributes.Add("onClick", "CargarCuadro(" & ordenCompra.IdCotizacion & "); return false;")
    End Sub
    Protected Sub EliminarFila(ByVal parametro As Int32, ByVal tipoOc As Int32)
        Dim codigo As String
        codigo = "<script type='text/javascript'> eliminarFila('" & parametro & "', '" & tipoOc & "'); " & Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "eliminarFilaRC", codigo.ToString, False)
    End Sub
    Protected Sub btnActualizarCabecera_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnActualizarCabecera.Click
        Dim _ordenCompra As OrdenCompra = Cache.Get("ordenCompra")
        _ordenCompra.IdOrdenCompra = CInt(Request.QueryString("IdOrdenCompra"))
        _ordenCompra.IdCotizacion = CInt(txtIdCotizacion.Text)
        _ordenCompra.IdMoneda = ddlMoneda.SelectedValue
        _ordenCompra.IdTipoPago = ddlTipoPago.SelectedValue
        _ordenCompra.IdTipoDocumento = ddlTipoDocumento.SelectedValue
        _ordenCompra.Anticipo = CDec(txtAnticipo.Text)
        _ordenCompra.Destino = ddlDestino.SelectedValue
        _ordenCompra.Observacion = txtObservacion.Text
        _ordenCompra.detalleOrdenCompra.Clear()
        For i = 0 To gvDetalleOrdenCompra.Rows.Count - 1
            Dim detalleOrden As New DetalleOrdenCompra
            Dim txtIdDetalleRequerimiento As TextBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("txtIdDetalleRequerimiento"), TextBox)
            Dim txtIdDetalleOrdenCompra As TextBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("txtIdDetalleOrden"), TextBox)
            Dim txtPrecioCompra As TextBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("txtPrecioDetalle"), TextBox)
            Dim cbAfectoIgv As CheckBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("cbAfectoIgv"), CheckBox)
            Dim rcbCentroCostoDetalle As RadComboBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("rcbCentroCostoDetalle"), RadComboBox)
            detalleOrden.IdCatalogo = CInt(txtIdCotizacion.Text)
            detalleOrden.IdDetalleRequerimiento = CInt(txtIdDetalleRequerimiento.Text)
            detalleOrden.IdUnidad = CInt(txtIdProveedor.Text)
            detalleOrden.IdDetalleOrdenCompra = CInt(txtIdDetalleOrdenCompra.Text)
            detalleOrden.PrecioCompra = CDec(txtPrecioCompra.Text)
            detalleOrden.AfectoIgv = IIf(cbAfectoIgv.Checked = True, True, False)
            detalleOrden.IdCentroCosto = rcbCentroCostoDetalle.SelectedValue
            _ordenCompra.detalleOrdenCompra.Add(detalleOrden)
        Next
        ordenCompraBL = New OrdenCompraBL
        ordenCompraBL.UpdateOrdenCompra(_ordenCompra)
        gvDetalleOrdenCompra.DataSource = ordenCompraBL.GetAllFromDetalleOrdenCompraByIdOrdenCompra(CInt(Request.QueryString("IdOrdenCompra")))
        gvDetalleOrdenCompra.DataBind()
        'EliminarFila(3, CInt(txtValidarOrden.Text))
        ScriptManager.RegisterStartupScript(Me.Page, GetType(Page), "AlertaX", "<script language='javascript'>alert('Orden de Compra Actualizada.');</script>".ToString, False)
    End Sub

    Protected Sub lbSolicitarAprobacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbSolicitarAprobacion.Click
        Dim _ordenCompraBl As New OrdenCompraBL
        _ordenCompraBl.SolicitarAprobacion(CInt(Request.QueryString("IdOrdenCompra")), ddlTipoPago.SelectedValue, CDec(txtAnticipo.Text))
        Me.Response.Redirect("FrmListaOrdenesCompra.aspx")
    End Sub

    Protected Sub gvDetalleOrdenCompra_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles gvDetalleOrdenCompra.DataBound
        Dim i As Integer
        For i = 0 To gvDetalleOrdenCompra.Rows.Count - 1
            Dim idDetalle As String = gvDetalleOrdenCompra.DataKeys(i).Item(0).ToString
            Dim idProyecto As String = txtIdProyecto.Text
            Dim producto As String = gvDetalleOrdenCompra.DataKeys(i).Item(1).ToString & " - " & gvDetalleOrdenCompra.DataKeys(i).Item(2).ToString
            Dim rcbCentroCostoDet As RadComboBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("rcbCentroCostoDetalle"), RadComboBox)
            rcbCentroCostoDet.Filter = 1
            Dim lbCentroCosto As LinkButton = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("lbCentroCosto"), LinkButton)
            lbCentroCosto.Attributes.Add("onClick", "CargarVentana(" & idDetalle & "," & idProyecto & ",'" & producto & "'); return false;")
        Next
    End Sub

    Protected Sub lbAnularRequerimientoR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAnularRequerimientoR.Click
        ordenCompraBL = New OrdenCompraBL
        If rdbAnularDefinitivamente.Checked = True Then
            ordenCompraBL.AnularOrdenCompra(CInt(Request.QueryString("IdOrdenCompra")), Session("IdUser"), txtMotivoAnula.Text, 2)
        Else
            If rdbGenerarOtraOc.Checked = True Then
                ordenCompraBL.AnularOrdenCompra(CInt(Request.QueryString("IdOrdenCompra")), Session("IdUser"), txtMotivoAnula.Text, 3)
            End If
        End If
        If Request.QueryString("accion") = "porAprobar" Then
            Response.Redirect("FrmListaOrdenesCompraEnviar.aspx")
        Else
            Response.Redirect("FrmListaOrdenesCompra.aspx")
        End If
    End Sub
    Public Function GetMonto(ByVal subTotal As Decimal, ByVal PrecIgv As Boolean) As Decimal
        'actualizart aqui el igv o renta 4ta categoria 18% y 10% - CDec(txtIgv.Text)
        If ddlTipoDocumento.SelectedValue = 4 Or ddlTipoDocumento.SelectedValue = 31 Then
            montoSubTotal += subTotal
            montoIgv = 0
            montoTotalFinal = montoSubTotal
        Else
            If ddlTipoDocumento.SelectedValue = 2 Then
                If PrecIgv = True Then
                    montoSubTotal += subTotal / (1 + 0.18)
                    montoIgv += subTotal / (1 + 0.18) * 0.18
                    montoTotalFinal += subTotal
                Else
                    montoSubTotal += subTotal
                    montoIgv += 0
                    montoTotalFinal += subTotal
                End If
            Else
                montoSubTotal += subTotal
                montoIgv += subTotal * 0.1
                montoTotalFinal = montoSubTotal - montoIgv

            End If
        End If
        Return subTotal
    End Function
    Public Function GetSubTotal() As Decimal
        Return montoSubTotal
    End Function
    Public Function GetIgv() As Decimal
        Return montoIgv
    End Function
    Public Function GetTotal() As Decimal
        Return montoTotalFinal
    End Function
    Public Function validarEnabled() As Boolean
        If validar = 1 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class