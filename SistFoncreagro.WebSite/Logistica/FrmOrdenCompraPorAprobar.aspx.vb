Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI

Public Class FrmOrdenCompraPorAprobar
    Inherits System.Web.UI.Page
    Dim ordenCompraBL As IOrdenCompraBL
    Dim _proyectoBl As IProyectoBL
    Dim _proyecto As New Proyecto
    Dim _rutaBl As IRutaRequerimientoBL
    Dim _ruta As RutaRequerimiento
    Dim _tipoPag As ITipoPagoBL
    Dim historicoOrdenBl As IHistoricoOrdenBL
    Dim tipoPag As New TipoPago
    Dim subTotal As Decimal
    Dim igvOc As Decimal
    Dim total As Decimal

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim IdOrdenCompra As Integer = CInt(Request.QueryString("IdOrdenCompra"))
            ordenCompraBL = New OrdenCompraBL
            Dim ordenCompra = ordenCompraBL.GetOrdenCompraByIdOrdenCompra(IdOrdenCompra, True)
            cargaOrdenCompra(ordenCompra)
        End If
    End Sub

    Public Sub cargaOrdenCompra(ByVal ordenCompra As OrdenCompra)
        _proyectoBl = New ProyectoBL
        _proyecto = _proyectoBl.GetFromProyectoByIdProyecto(ordenCompra.requerimiento.IdProyectoArea)
        _tipoPag = New TipoPagoBL
        tipoPag = _tipoPag.GetAllFromTipoPagoByIdTipo(ordenCompra.IdTipoPago)
        If ordenCompra.IdTipoDocumento <> 3 Then
            subTotal = ordenCompra.SubTotal
            igvOc = ordenCompra.Igv
            total = ordenCompra.Total
        Else
            subTotal = ordenCompra.Total
            igvOc = ordenCompra.Igv
            total = ordenCompra.SubTotal
        End If
        lblNumeroOc.Text = ordenCompra.NumeroOrden
        lblTipoOc.Text = ordenCompra.Tipo
        lblEstadoOrdenCompra.Text = ordenCompra.Estado
        lblNumeroRequerimiento.Text = ordenCompra.requerimiento.Numero
        lblRequeridoPor.Text = ordenCompra.requerimiento.NombreRequiere
        txtIdProyecto.Text = ordenCompra.requerimiento.IdProyectoArea
        lblMoneda.Text = ordenCompra.moneda.Nombre
        ddlTipoDocumento.SelectedValue = ordenCompra.IdTipoDocumento
        lblProveedorTexto.Text = ordenCompra.NombreProveedorCompleato
        lblTipoPago.Text = tipoPag.Descripcion
        lblAreaProyecto.Text = _proyecto.Nombre
        lblAnticipo.Text = ordenCompra.Anticipo
        lblObservaciones.Text = ordenCompra.Observacion
        lblDestino.Text = ordenCompra.Destino
        txtIgv.Text = ordenCompra.Igv
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
        gvDetalleOrdenCompra.DataSource = ordenCompra.detalleOrdenCompra
        gvDetalleOrdenCompra.DataBind()
        Cache.Insert("ordenCompra", ordenCompra)
        EliminarFila(0, CInt(txtValidarOrden.Text))
        If ordenCompra.ActivarCentroCosto = False Then
            gvDetalleOrdenCompra.Columns(8).Visible = False
        Else
            gvDetalleOrdenCompra.Columns(9).Visible = False
        End If
        If ordenCompra.Estado <> "En Espera" Or ordenCompra.Estado <> "Enviado" Or ordenCompra.Estado <> "Recepcionado" Then
            lbAnularOc.Visible = True
            panelAnular.Visible = True
            lbRechazarOc.Visible = True
            panelRechazar.Visible = True
        End If
        lbAdjuntarArchivo.Attributes.Add("onClick", "CargarVentanaCotizacion(" & ordenCompra.IdCotizacion & "," & 1 & "); return false;")
        lbCuadroComparativo.Attributes.Add("onClick", "CargarCuadro(" & ordenCompra.IdCotizacion & "," & ordenCompra.IdOrdenCompra & "); return false;")
    End Sub

    Protected Sub EliminarFila(ByVal parametro As Int32, ByVal tipoOc As Int32)
        Dim codigo As String
        codigo = "<script type='text/javascript'> eliminarFila('" & parametro & "', '" & tipoOc & "'); " & Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "eliminarFilaRC", codigo.ToString, False)
    End Sub

    Protected Sub lbAprobarOc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAprobarOc.Click
        Dim _ordenCompraBl As New OrdenCompraBL
        _ordenCompraBl.AprobarOrdenCompra(CInt(Request.QueryString("IdOrdenCompra")), Session("IdUser"))
        Me.Response.Redirect("FrmListaOrdenesCompraPorAprobar.aspx")
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
        Dim _ordenCompraBl As New OrdenCompraBL
        _ordenCompraBl.AnularOrdenCompra(CInt(Request.QueryString("IdOrdenCompra")), Session("IdUser"), txtMotivoAnula.Text, 1)
        Me.Response.Redirect("FrmListaOrdenesCompraPorAprobar.aspx")
    End Sub

    Protected Sub lbRechazarOrden_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbRechazarOrden.Click
        Dim historicoOrdenBl = New HistoricoOrdenBL
        Dim historicoOrden = New HistoricoOrden
        If Not Session("IdUser") Is Nothing Then
            historicoOrden.IdOrden = CInt(Request.QueryString("IdOrdenCompra"))
            historicoOrden.IdPersonal = Session("IdUser")
            historicoOrden.Motivo = txtMotivoRechazo.Text
            historicoOrdenBl.RechazarOrden(historicoOrden)
            Me.Response.Redirect("FrmListaOrdenesCompraPorAprobar.aspx")
        End If
    End Sub
    Public Function subTotalMostrar() As Decimal
        Return subTotal
    End Function
    Public Function igvMostrar() As Decimal
        Return igvOc
    End Function
    Public Function totalMostrar() As Decimal
        Return total
    End Function
End Class