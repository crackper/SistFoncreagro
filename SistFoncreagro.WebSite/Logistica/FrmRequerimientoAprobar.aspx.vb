Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI

Public Class FrmRequerimientoAprobar
    Inherits System.Web.UI.Page

    Dim _requerimientoBL As IRequerimientoBL
    Dim _detalleRequerimientoBL As IDetalleRequerimientoBL
    Dim catalogoBl As ICatalogoBL
    Dim proveedor As New ProveedorCliente
    Dim mensajeDisenio As New Disenio
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            Dim idRequerimiento As Integer
            idRequerimiento = CInt(Request.QueryString("IdReq"))
            _requerimientoBL = New RequerimientoBL

            Dim requerimiento = _requerimientoBL.GetAllFromRequerimientoByIdReq(idRequerimiento)
            'cargarRequerimiento(requerimiento)
            Dim parametroSession As String = Request.QueryString("accion")

        End If
    End Sub

    'Public Sub cargarRequerimiento(ByVal requerimiento As Requerimiento)
    '    lblNroRequerimiento.Text = requerimiento.Numero
    '    lblRequeridoPor.Text = requerimiento.NombreRequiere
    '    lblFechaRequerimiento.Text = Convert.ToString(requerimiento.FechaRequerimiento)
    '    lblEstadoRequerimiento.Text = requerimiento.Estado
    '    lblTipoRequerimiento.Text = requerimiento.Tipo
    '    lblAreaProyecto.Text = requerimiento.proyecto.AreaProyecto
    '    lblMoneda.Text = requerimiento.moneda.Nombre
    '    txtObservacion.Text = requerimiento.Observacion
    '    lblSustento.Text = requerimiento.Sustento
    '    txtIdProyecto.Text = requerimiento.IdProyectoArea
    '    If requerimiento.Tipo = "SERVICIO" Then
    '        txtTipoCatalogoRequerimiento.Text = "1"
    '        If requerimiento.Periodo = True Then
    '            lblPeridoInicio.Text = "Inicio: " & DateValue(requerimiento.FechaInicioServicio) & " Fin: " & DateValue(requerimiento.FechaFinServicio)
    '        End If
    '        If requerimiento.Ruta = True Then
    '            lblOrigen.Text = "Origen: " & requerimiento.rutaRequerimientoOrigen.Nombre
    '            lblDestino.Text = "Destino: " & requerimiento.rutaRequerimientoDestino.Nombre
    '        End If
    '    End If

    '    If requerimiento.Estado = "Por Aprobar Ja" Then
    '        lblJefeArea.Visible = True
    '        lblNombreJefeAreaProyecto.Visible = True
    '        lblNombreJefeAreaProyecto.Text = requerimiento.NomreJefeArea
    '        Inhabilitar()
    '        EliminarFila(1, CInt(txtTipoCatalogoRequerimiento.Text))
    '    ElseIf requerimiento.Estado = "Por Aprobar Adm" Then
    '        lblJefeArea.Visible = True
    '        lblNombreJefeAreaProyecto.Visible = True
    '        lblNombreJefeAreaProyecto.Text = requerimiento.NomreJefeArea
    '        lblAdministracion.Visible = True
    '        lblNombreResponsableAdministracion.Visible = True
    '        lblNombreResponsableAdministracion.Text = requerimiento.NombreAdministracion
    '        Inhabilitar()
    '        EliminarFila(9, CInt(txtTipoCatalogoRequerimiento.Text))
    '    ElseIf requerimiento.Estado = "Aprobado" Or requerimiento.Estado = "O/C" Then
    '        lblJefeArea.Visible = True
    '        lblNombreJefeAreaProyecto.Visible = True
    '        lblNombreJefeAreaProyecto.Text = requerimiento.NomreJefeArea
    '        lblAdministracion.Visible = True
    '        lblNombreResponsableAdministracion.Visible = True
    '        lblNombreResponsableAdministracion.Text = requerimiento.NombreAdministracion
    '        Inhabilitar()
    '        EliminarFila(9, CInt(txtTipoCatalogoRequerimiento.Text))
    '    End If

    '    If requerimiento.ActivarCentroCosto = False Then
    '        gvDetalleRequerimiento.Columns(12).Visible = False
    '    Else
    '        gvDetalleRequerimiento.Columns(13).Visible = False
    '    End If
    'End Sub

    'Sub Inhabilitar()
    '    gvDetalleRequerimiento.Columns(1).Visible = False
    '    gvDetalleRequerimiento.Columns(11).Visible = False
    '    Dim accion As String = Request.QueryString("accion")
    '    If accion = "porAprobar" Then
    '        lbAprobarRequerimiento.Visible = True
    '        lbAnularRequerimiento.Visible = True
    '    End If
    'End Sub

    'Protected Sub EliminarFila(ByVal parametro As Int32, ByVal tipo As Int32)
    '    Dim codigo As String
    '    codigo = "<script type='text/javascript'> eliminarFila('" & parametro & "', '" & tipo & "'); " & Chr(60) & "/script>"
    '    ScriptManager.RegisterStartupScript(Page, GetType(Page), "eliminarFilaRC", codigo.ToString, False)

    'End Sub

    'Protected Sub lbAnularRequerimiento_Click1(ByVal sender As Object, ByVal e As EventArgs) Handles lbAnularRequerimiento.Click
    '    Dim idRequerimiento As Integer
    '    idRequerimiento = CInt(Request.QueryString("IdReq"))
    '    _requerimientoBL = New RequerimientoBL
    '    _requerimientoBL.AnularRequerimiento(idRequerimiento)
    '    'Validar la direccion, depende de la persona que anule el requerimiento
    '    Me.Response.Redirect("FrmListaRequerimientosPorAprobar.aspx")
    'End Sub

    'Protected Sub lbAprobarRequerimiento_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAprobarRequerimiento.Click
    '    Dim idRequerimiento As Integer
    '    idRequerimiento = CInt(Request.QueryString("IdReq"))
    '    _requerimientoBL = New RequerimientoBL
    '    _requerimientoBL.SolictarAprobacion(idRequerimiento)
    '    Me.Response.Redirect("FrmListaRequerimientosPorAprobar.aspx")
    'End Sub

    'Protected Sub gvDetalleRequerimiento_DataBound(ByVal sender As Object, ByVal e As EventArgs) Handles gvDetalleRequerimiento.DataBound
    '    Dim i As Integer
    '    For i = 0 To gvDetalleRequerimiento.Rows.Count - 1
    '        Dim idDetalle As String = gvDetalleRequerimiento.DataKeys(i).Item(0).ToString
    '        Dim idProyecto As String = txtIdProyecto.Text
    '        Dim producto As String = gvDetalleRequerimiento.DataKeys(i).Item(1).ToString & " - " & gvDetalleRequerimiento.DataKeys(i).Item(2).ToString
    '        'Dim textBoxFinal As New TextBox
    '        'textBoxFinal.Text = gvDetalleRequerimiento.DataKeys(i).Item(1).ToString

    '        Dim lbCentroCosto As LinkButton = CType(Me.gvDetalleRequerimiento.Rows(i).FindControl("lbCentroCosto"), LinkButton)
    '        lbCentroCosto.Attributes.Add("onClick", "CargarVentana(" & idDetalle & "," & idProyecto & ",'" & producto & "'); return false;")
    '        'lbCentroCosto.Attributes.Add("onClick", "CargarVentana(" & idDetalle & "," & idProyecto & "," & producto & "); return false;")
    '    Next
    'End Sub
End Class