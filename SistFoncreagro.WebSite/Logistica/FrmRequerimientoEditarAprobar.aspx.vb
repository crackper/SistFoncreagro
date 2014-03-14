Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI

Public Class FrmRequerimientoEditarAprobar
    Inherits System.Web.UI.Page
    Dim _requerimientoBL As IRequerimientoBL
    Dim _detalleRequerimientoBL As IDetalleRequerimientoBL
    Dim catalogoBl As ICatalogoBL
    Dim mensajeDisenio As New Disenio
    Dim _rutaBl As IRutaRequerimientoBL
    Dim _ruta As RutaRequerimiento
    Dim _proyectoBl As IProyectoBL
    Dim _proyecto As New Proyecto
    Dim lblCCosto As String
    Dim ccost As New CCosto
    Dim icCosto As ICCostoBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim idRequerimiento As Integer
            idRequerimiento = CInt(Request.QueryString("IdReq"))
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
        If requerimiento.Estado <> "En Espera" And requerimiento.Estado <> "Anulado" And requerimiento.Estado <> "Aprobado" Then
            lbAprobarRequerimiento.Visible = True
            lbRechazarRequerimiento.Visible = True
            lbAnularReq.Visible = True
            panelRechazar.Visible = True
            panelAnular.Visible = True
        End If
        If requerimiento.ActivarCentroCosto = False Then
            gvDetalleRequerimiento.Columns(10).Visible = False
        Else
            gvDetalleRequerimiento.Columns(11).Visible = False
        End If
        EliminarFila(9, CInt(txtTipoCatalogoRequerimiento.Text))
        lbHistorico.Attributes.Add("onClick", "CargarHistorico(" & requerimiento.IdRequerimiento & "); return false;")
        lbAdjunto.Attributes.Add("onClick", "CargarAdjunto(" & requerimiento.IdRequerimiento & "," & 0 & "); return false;")
    End Sub

    Protected Sub EliminarFila(ByVal parametro As Int32, ByVal tipo As Int32)
        Dim codigo As String
        codigo = "<script type='text/javascript'> eliminarFila('" & parametro & "', '" & tipo & "'); " & Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "eliminarFilaRC", codigo.ToString, False)

    End Sub

    Protected Sub lbAprobarRequerimiento_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAprobarRequerimiento.Click
        Dim idRequerimiento As Integer
        idRequerimiento = CInt(Request.QueryString("IdReq"))
        _requerimientoBL = New RequerimientoBL
        _requerimientoBL.AprobarRequerimiento(idRequerimiento, Session("IdUser"))
        Me.Response.Redirect("FrmListaRequerimientosPorAprobar.aspx")
    End Sub

    Protected Sub gvDetalleRequerimiento_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles gvDetalleRequerimiento.DataBound
        Dim i As Integer
        For i = 0 To gvDetalleRequerimiento.Rows.Count - 1
            Dim idDetalle As String = gvDetalleRequerimiento.DataKeys(i).Item(0).ToString
            Dim idProyecto As String = txtIdProyecto.Text
            Dim producto As String = gvDetalleRequerimiento.DataKeys(i).Item(1).ToString & " - " & gvDetalleRequerimiento.DataKeys(i).Item(2).ToString
            Dim lbCentroCosto As LinkButton = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("lbCentroCosto"), LinkButton)
            lbCentroCosto.Attributes.Add("onClick", "CargarVentana(" & idDetalle & "," & idProyecto & ",'" & producto & "'); return false;")
        Next
    End Sub

    Protected Sub lbAceptarRechazo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAceptarRechazo.Click
        Dim historicoReqBl = New HistoricoRequerimientoBL
        Dim historicoReq = New HistoricoRequerimiento
        If Not Session("IdUser") Is Nothing Then
            historicoReq.IdRequerimiento = CInt(Request.QueryString("IdReq"))
            historicoReq.IdPersonal = Session("IdUser")
            historicoReq.Motivo = txtMotivo.Text
            historicoReq.Tipo = False
            historicoReqBl.RechazarRequerimiento(historicoReq)
            Me.Response.Redirect("FrmListaRequerimientosPorAprobar.aspx")
        End If
    End Sub

    Protected Sub lbAnularRequerimientoR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAnularRequerimientoR.Click
        Dim idRequerimiento As Integer
        idRequerimiento = CInt(Request.QueryString("IdReq"))
        _requerimientoBL = New RequerimientoBL
        _requerimientoBL.AnularRequerimiento(idRequerimiento, Session("IdUser"), txtMotivoAnula.Text, 2)
        'Validar la direccion, depende de la persona que anule el requerimiento
        Me.Response.Redirect("FrmListaRequerimientosPorAprobar.aspx")
    End Sub
End Class