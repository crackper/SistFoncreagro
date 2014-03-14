Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports System.IO
Imports Telerik.Web.UI
Imports AjaxControlToolkit

Public Class FrmRequerimientoEditarGenerarOc
    Inherits System.Web.UI.Page
    Dim cotiz As New Cotizacion
    Dim cotizacionBl As New CotizacionBL
    Dim _requerimientoBL As IRequerimientoBL
    Dim _detalleRequerimientoBL As IDetalleRequerimientoBL
    Dim _rutaBl As IRutaRequerimientoBL
    Dim _ruta As RutaRequerimiento
    Dim _proyectoBl As IProyectoBL
    Dim _proyecto As New Proyecto
    Dim reqLicSo As IReqLicSoulBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim idRequerimiento As Integer
            idRequerimiento = CInt(Request.QueryString("IdReq"))
            txtIdRequerimiento.Text = Request.QueryString("IdReq")
            _requerimientoBL = New RequerimientoBL
            Dim requerimiento = _requerimientoBL.GetAllFromRequerimientoByIdReq(idRequerimiento)
            cargarRequerimiento(requerimiento)
        End If
    End Sub

    Public Sub cargarRequerimiento(ByVal requerimiento As Requerimiento)
        _proyectoBl = New ProyectoBL
        _proyecto = _proyectoBl.GetFromProyectoByIdProyecto(requerimiento.IdProyectoArea)
        lblNroRequerimiento.Text = requerimiento.Numero
        lblRequeridoPor.Text = requerimiento.NombreRequiere
        lblFechaRequerimiento.Text = Convert.ToString(requerimiento.FechaRequerimiento)
        lblEstadoRequerimiento.Text = requerimiento.Estado
        lblTipoRequerimiento.Text = requerimiento.Tipo
        lblAreaProyecto.Text = _proyecto.AreaProyecto
        lblMoneda.Text = requerimiento.AbreviacionMoneda
        txtObservacion.Text = requerimiento.Observacion
        lblSustento.Text = requerimiento.Sustento
        txtIdProyecto.Text = requerimiento.IdProyectoArea
        lbAdjunto.Text = "Adjunto(s)-" + CStr(requerimiento.NroAdjuntos)
        lblFecha.Text = DateTime.Now()
        If requerimiento.Tipo = "SERVICIO" Then
            txtTipoCatalogoRequerimiento.Text = "1"
            If requerimiento.Periodo = True Then
                lblPeridoInicio.Text = "Inicio: " & DateValue(requerimiento.FechaInicioServicio) & " Fin: " & DateValue(requerimiento.FechaFinServicio)
            End If
            If requerimiento.Ruta = True Then
                _rutaBl = New RutaRequerimientoBL
                _ruta = _rutaBl.GetRutaRequerimientoByIdRuta(requerimiento.IdRutaOrigen)
                lblOrigen.Text = "Origen: " & _ruta.Nombre
                _ruta = _rutaBl.GetRutaRequerimientoByIdRuta(requerimiento.IdRutaDestino)
                lblDestino.Text = "Destino: " & _ruta.Nombre
            End If
        End If
        EliminarFila(9, CInt(txtTipoCatalogoRequerimiento.Text))
        If (requerimiento.Estado = "Aprobado") Then
            lbAnularOc.Visible = True
            panelAnular.Visible = True
        End If
        If Request.QueryString("accion") = 0 Then
            lbAnularOc.Visible = False
            lbActualizarDetalle.Visible = False
            lbPDescripcion.Visible = False
            lbRechazarRequerimiento.Visible = False
            lblVerOc.Visible = True
            panelAnular.Visible = False
            panelRechazar.Visible = False
            pnlProductos.Visible = False
            gvDetalleRequerimiento.Columns(0).Visible = False
        End If
        If requerimiento.ActivarCentroCosto = False Then
            gvDetalleRequerimiento.Columns(8).Visible = False
        Else
            gvDetalleRequerimiento.Columns(9).Visible = False
        End If
        lbReporteCotizacion.Attributes.Add("onClick", "CargarBandejaReporte(" & requerimiento.IdRequerimiento & "); return false;")
        lbAdjunto.Attributes.Add("onClick", "CargarAdjunto(" & requerimiento.IdRequerimiento & "); return false;")
    End Sub

    Protected Sub EliminarFila(ByVal parametro As Int32, ByVal tipo As Int32)
        Dim codigo As String
        codigo = "<script type='text/javascript'> eliminarFila('" & parametro & "', '" & tipo & "'); " & Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "eliminarFilaRC", codigo.ToString, False)

    End Sub
    Protected Sub CargarDatosReq(ByVal idRequerimiento As String, ByVal estado As String)
        Dim cj As String
        cj = "<script type='text/javascript'> cargarDatos('" & idRequerimiento & "','" & estado & "'); " & Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "cargarDatosRC", cj.ToString, False)
    End Sub

    Protected Sub gvDetalleRequerimiento_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles gvDetalleRequerimiento.DataBound
        Dim i As Integer
        For i = 0 To gvDetalleRequerimiento.Rows.Count - 1
            Dim idDetalle As String = gvDetalleRequerimiento.DataKeys(i).Item(0).ToString
            Dim idProyecto As String = txtIdProyecto.Text
            Dim producto As String = gvDetalleRequerimiento.DataKeys(i).Item(1).ToString & " - " & gvDetalleRequerimiento.DataKeys(i).Item(2).ToString
            Dim lbCentroCosto As LinkButton = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("lbCentroCosto"), LinkButton)
            Dim linkButonAnular As LinkButton = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("lbAnularItem"), LinkButton)
            lbCentroCosto.Attributes.Add("onClick", "CargarVentana(" & idDetalle & "," & idProyecto & ",'" & producto & "'); return false;")
            linkButonAnular.Attributes.Add("onClick", "AnularItem(" & idDetalle & ",'" & producto & "'); return false;")
        Next
    End Sub

    Function estadoCb(ByVal estado As Int32) As Boolean
        Dim visible As Boolean
        If estado = 0 Then
            visible = True
        Else
            visible = False
        End If
        Return visible
    End Function

    Function estadoLabel(ByVal estado As Int32) As Boolean
        Dim visible As Boolean
        If estado > 0 Then
            visible = True
        Else
            visible = False
        End If
        Return visible
    End Function

    Function estadoTextLabel(ByVal estado As Int32) As String
        Dim texto As String = ""
        If estado = 1 Then
            texto = "Cot."
        ElseIf estado = 2 Then
            texto = "O/C"
        ElseIf estado = 3 Then
            texto = "Anulado"
        End If
        Return texto
    End Function

    Protected Sub ibGuardar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibGuardar.Click
        Dim listaDetalleReqCotizacion As New List(Of DetalleReqCotizacion)
        Dim valor As Boolean = False
        cotiz.IdComprador = Session("IdUser")
        cotiz.IdTipoCotizacion = ddlTipo.SelectedValue
        cotiz.IdRequerimiento = Request.QueryString("IdReq")
        cotiz.IdMoneda = ddlMoneda.SelectedValue
        cotiz.Nombre = txtNombre.Text
        For i = 0 To gvDetalleRequerimiento.Rows.Count - 1
            Dim detalleReqCoti As New DetalleReqCotizacion
            Dim txtIdDetalleRequerimiento As TextBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("txtIdDetReq"), TextBox)
            Dim txtIdCatalogo As TextBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("txtIdCatalogo"), TextBox)
            Dim cbCarga As CheckBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("cbEstado"), CheckBox)
            If cbCarga.Checked = True Then
                valor = True
                detalleReqCoti.IdDetalleRequerimiento = CInt(txtIdDetalleRequerimiento.Text)
                detalleReqCoti.IdCatalogo = CInt(txtIdCatalogo.Text)
                listaDetalleReqCotizacion.Add(detalleReqCoti)
            End If
        Next
        If valor = True Then
            cotiz.detalleReqCoti = listaDetalleReqCotizacion
            cotizacionBl.SaveCotizacion(cotiz)
            Response.Redirect("FrmListaCotizacionPendiente.aspx")
        Else
            Response.Redirect("FrmRequerimientoEditarGenerarOc.aspx?IdReq=" + txtIdRequerimiento.Text)
        End If
    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        If e.Argument.StartsWith("AnularItem") Then
            _detalleRequerimientoBL = New DetalleRequerimientoBL
            Dim j() As String
            j = Split(e.Argument, "|")
            _detalleRequerimientoBL.AnularItemDetalle(CInt(j(1)), j(2))
            Response.Redirect("FrmRequerimientoEditarGenerarOc.aspx?IdReq=" + txtIdRequerimiento.Text + "&accion=1")
        End If
    End Sub

    Protected Sub lbAnularRequerimientoR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAnularRequerimientoR.Click
        _requerimientoBL = New RequerimientoBL
        _requerimientoBL.AnularRequerimiento(CInt(txtIdRequerimiento.Text), Session("IdUser"), txtMotivoAnula.Text, 3)
        Me.Response.Redirect("FrmListaRequerimientosAprobados.aspx")
    End Sub

    Protected Sub lbActualizarDetalle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbActualizarDetalle.Click
        Dim listaDetalle As New List(Of DetalleRequerimiento)
        Dim i As Integer
        For i = 0 To gvDetalleRequerimiento.Rows.Count - 1
            Dim detalleRequerimiento As New DetalleRequerimiento
            Dim afecto As Boolean
            Dim txtIdDetalleRequerimiento As TextBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("txtIdDetReq"), TextBox)
            Dim txtObservacionDetalle As TextBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("txtDetalleObservacion"), TextBox)
            Dim cbAfectoIgv As CheckBox = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("cbAfectoIgv"), CheckBox)
            If cbAfectoIgv.Checked = True Then
                afecto = True
            Else
                afecto = False
            End If
            detalleRequerimiento.IdDetalleRequerimiento = CInt(txtIdDetalleRequerimiento.Text)
            detalleRequerimiento.observacion = txtObservacionDetalle.Text
            detalleRequerimiento.AfectoIgv = afecto
            listaDetalle.Add(detalleRequerimiento)
        Next
        Dim _requerimientoBL = New RequerimientoBL
        _requerimientoBL.UpdateDetalleRequerimiento(listaDetalle)
    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton2.Click
        Dim tipo As String
        Dim reqLicSoEntity As New ReqLicSoul
        reqLicSo = New ReqLicSoulBL
        If rbLicitacion.Checked = True Then
            tipo = "L"
        Else
            tipo = "S"
        End If
        reqLicSoEntity.IdRequerimiento = CInt(txtIdRequerimiento.Text)
        reqLicSoEntity.Tipo = tipo
        reqLicSoEntity.IdPersonalReq = Session("IdUser")
        reqLicSoEntity.IdPersonalNuevo = ddlPersonaNuevo.SelectedValue
        reqLicSo.SaveReqLicSoul(reqLicSoEntity)
        Response.Redirect("FrmListaRequerimientosAprobados.aspx")
    End Sub

    Protected Sub gvDetalleRequerimiento_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvDetalleRequerimiento.RowDataBound
        If e.Row.DataItemIndex >= 0 Then
            If e.Row.Cells(10).Text = 1 Or e.Row.Cells(10).Text = 2 Then
                e.Row.BackColor = Drawing.Color.Gainsboro
                lbRechazarRequerimiento.Visible = False
                panelRechazar.Visible = False
            Else
                If e.Row.Cells(10).Text = 3 Then
                    e.Row.BackColor = Drawing.Color.Gainsboro
                End If
            End If
        End If
    End Sub

    Protected Sub lbAceptarRechazo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAceptarRechazo.Click
        Dim historicoReqBl = New HistoricoRequerimientoBL
        Dim historicoReq = New HistoricoRequerimiento
        If Not Session("IdUser") Is Nothing Then
            historicoReq.IdRequerimiento = CInt(Request.QueryString("IdReq"))
            historicoReq.IdPersonal = Session("IdUser")
            historicoReq.Motivo = txtMotivo.Text
            historicoReq.Tipo = True
            historicoReqBl.RechazarRequerimiento(historicoReq)
            Me.Response.Redirect("FrmListaRequerimientosAprobados.aspx")
        End If
    End Sub

    Protected Sub lblVerOc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblVerOc.Click
        Response.Redirect("FrmListaOrdenesCompraLicitacion.aspx?id=" & Request.QueryString("IdReq"))
    End Sub
End Class
