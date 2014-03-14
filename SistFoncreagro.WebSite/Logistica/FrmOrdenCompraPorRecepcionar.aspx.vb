Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities

Public Class FrmOrdenCompraPorRecepcionar
    Inherits System.Web.UI.Page
    Dim disenio As New Disenio
    Dim ordenCompraBL As IOrdenCompraBL
    Dim _proyectoBl As IProyectoBL
    Dim _proyecto As New Proyecto
    Dim _rutaBl As IRutaRequerimientoBL
    Dim _ruta As RutaRequerimiento
    Dim _tipoPag As ITipoPagoBL
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
        subTotal = ordenCompra.SubTotal
        igvOc = ordenCompra.Igv
        total = ordenCompra.Total
        lblNumeroOc.Text = ordenCompra.NumeroOrden
        lblTipoOc.Text = ordenCompra.Tipo
        lblEstadoOrdenCompra.Text = ordenCompra.Estado
        lblNumeroRequerimiento.Text = ordenCompra.requerimiento.Numero
        lblRequeridoPor.Text = ordenCompra.requerimiento.NombreRequiere
        lblMoneda.Text = ordenCompra.moneda.Nombre
        lblAreaProyecto.Text = _proyecto.Nombre
        lblTipoPago.Text = tipoPag.Descripcion
        lblProveedorTexto.Text = ordenCompra.nombreProveedor
        lblAnticipo.Text = ordenCompra.Anticipo
        txtObservacion.Text = ordenCompra.Observacion
        txtIgv.Text = ordenCompra.Igv

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
            EliminarFila(1)
        End If
        gvDetalleOrdenCompra.DataSource = ordenCompra.detalleOrdenCompra
        gvDetalleOrdenCompra.DataBind()
        Cache.Insert("ordenCompra", ordenCompra)

        If ordenCompra.Estado = "Recepcionado" Then
            PanelRecepcion.Visible = False
        ElseIf ordenCompra.Estado = "Enviado" Then
            lbRecepcionarOrdenCompra.Attributes.Add("onClick", "recepcionarOrdenCompra(0); return false;")
        ElseIf ordenCompra.Estado = "Recepcion Parc" Then
            gvDetalleOrdenCompra.Columns(7).Visible = True
            Dim labelSubtotal As Label = Me.gvDetalleOrdenCompra.FooterRow.FindControl("lblSubtotal1")
            Dim labelIgv As Label = Me.gvDetalleOrdenCompra.FooterRow.FindControl("lblIgv1")
            Dim labelTotal As Label = Me.gvDetalleOrdenCompra.FooterRow.FindControl("lblTotal1")
            labelSubtotal.Visible = False
            labelIgv.Visible = False
            labelTotal.Visible = False
            lbRecepcionarOrdenCompra.Attributes.Add("onClick", "recepcionarOrdenCompra(1); return false;")
        End If
        If Request.QueryString("ac") = "0" Then
            PanelRecepcion.Visible = False
            gvDetalleOrdenCompra.Columns(0).Visible = False
        End If
    End Sub

    Protected Sub EliminarFila(ByVal parametro As Int32)
        Dim codigo As String
        codigo = "<script type='text/javascript'> eliminarFila('" & parametro & "'); " & Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "eliminarFilaRC", codigo.ToString, False)
    End Sub
    Public Function RecepcionParcial() As Boolean
        If lblEstadoOrdenCompra.Text = "Recepcion Parc" Or lblEstadoOrdenCompra.Text = "Recepcionado" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function DesHabilitar(ByVal valor As String) As Boolean
        If CDec(valor) = 0.0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function subTotalMostrar() As Decimal
        Return subTotal
    End Function
    Public Function igvMostrar() As Decimal
        Return igvOc
    End Function
    Public Function totalMostrar() As Decimal
        Return total
    End Function

    Protected Sub gvDetalleOrdenCompra_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles gvDetalleOrdenCompra.DataBound
        If lblEstadoOrdenCompra.Text = "Recepcion Parc" Then
            Dim i As Integer
            For i = 0 To gvDetalleOrdenCompra.Rows.Count - 1
                Dim txtCantidadSolicitadad As TextBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("txtCantidadSolicitada"), TextBox)
                Dim txtCantidadRecepcionada As TextBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("txtCantidadComprada"), TextBox)
                Dim txtCantidadPendiente As TextBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("txtCantidadPendiente"), TextBox)
                txtCantidadPendiente.Attributes.Add("Onblur", "ValidarDatosParcial('" & txtCantidadSolicitadad.ClientID & "', '" & txtCantidadRecepcionada.ClientID & "', '" & txtCantidadPendiente.ClientID & "'); return false;")
            Next
        Else
            Dim i As Integer
            For i = 0 To gvDetalleOrdenCompra.Rows.Count - 1
                Dim txtCantidadSolicitadad As TextBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("txtCantidadSolicitada"), TextBox)
                Dim txtCantidadRecepcionada As TextBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("txtCantidadComprada"), TextBox)
                txtCantidadRecepcionada.Attributes.Add("Onblur", "ValidarDatos('" & txtCantidadSolicitadad.ClientID & "', '" & txtCantidadRecepcionada.ClientID & "'); return false;")
            Next
        End If
    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument = "RecepcionCompleta" Then
            If lblEstadoOrdenCompra.Text = "Recepcion Parc" Then
                cargarDatosGrilla(True, "txtCantidadPendiente")
            Else
                cargarDatosGrilla(True, "txtCantidadComprada")
            End If
            If Request.QueryString("tip") = 1 Then
                Response.Redirect("FrmListaOrdenesCompraPorRecepcionar.aspx")
            Else
                Response.Redirect("FrmListaOrdenesCompraPorRecepcionarInternas.aspx")
            End If
        ElseIf e.Argument = "RecepcionParcial" Then
            If lblEstadoOrdenCompra.Text = "Enviado" Then
                cargarDatosGrilla(False, "txtCantidadComprada")
            Else
                cargarDatosGrilla(False, "txtCantidadPendiente")
            End If
            If Request.QueryString("tip") = 1 Then
                Response.Redirect("FrmListaOrdenesCompraPorRecepcionar.aspx")
            Else
                Response.Redirect("FrmListaOrdenesCompraPorRecepcionarInternas.aspx")
            End If
        End If
    End Sub

    Sub cargarDatosGrilla(ByVal tipoRecepcion As Boolean, ByVal cajaTexto As String)
        Dim i As Integer
        Dim _ordenCompra As OrdenCompra = Cache.Get("ordenCompra")
        _ordenCompra.detalleOrdenCompra.Clear()
        ordenCompraBL = New OrdenCompraBL
        _ordenCompra.IdOrdenCompra = CInt(Request.QueryString("IdOrdenCompra"))
        _ordenCompra.IdPersonaRecepciona = 2
        _ordenCompra.DocumentoReferencial = txtDocumentoRecepcion.Text
        For i = 0 To gvDetalleOrdenCompra.Rows.Count - 1
            Dim detalleOrdenCompra As New DetalleOrdenCompra
            Dim txtIdDetalleOrdenCompra As TextBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl("txtIdDetalleOrden"), TextBox)
            Dim txtCantidadRecepcionada As TextBox = CType(Me.gvDetalleOrdenCompra.Rows(i).FindControl(cajaTexto), TextBox)
            detalleOrdenCompra.IdDetalleOrdenCompra = CInt(txtIdDetalleOrdenCompra.Text)
            detalleOrdenCompra.CantidadComprada = CDec(txtCantidadRecepcionada.Text)
            _ordenCompra.detalleOrdenCompra.Add(detalleOrdenCompra)
        Next
        ordenCompraBL.SaveRecepcionOrdenCompra(_ordenCompra, tipoRecepcion)
    End Sub
End Class