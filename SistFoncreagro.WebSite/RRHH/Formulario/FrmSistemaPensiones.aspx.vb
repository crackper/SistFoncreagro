Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class FrmSistemaPensiones
    Inherits System.Web.UI.Page
    Dim aportePorPeridoBL As New AportesPorPeriodoBL

    Dim tipoSistema As New TipoSpBL
    Dim sistemaPensiones As New SistemaDePensionesBL
    Dim perido As New PeriodoDeclaracionBL

    Dim aporteBL As New AportesBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim edicion As String = Request.QueryString("Resultado")
            If edicion = "a" Then
                rcmbTipoSistemaPension.DataSource = tipoSistema.GetAllFromTipoSp
                rcmbTipoSistemaPension.DataTextField = "Tipo"
                rcmbTipoSistemaPension.DataValueField = "IdTipoSP"
                rcmbTipoSistemaPension.DataBind()
                rcmbTipoSistemaPension.SelectedValue = CInt(Request.QueryString("IdTipoSp"))

                rcmbSistemaPensiones.DataSource = sistemaPensiones.GetAllFromSistemaPensionesByTipoSp(rcmbTipoSistemaPension.SelectedValue)
                rcmbSistemaPensiones.DataTextField = "Descripcion"
                rcmbSistemaPensiones.DataValueField = "IdSistemaPensiones"
                rcmbSistemaPensiones.DataBind()
                rcmbSistemaPensiones.SelectedValue = CInt(Request.QueryString("IdSistemaPensiones"))

                rcmbPeridoDos.DataSource = perido.GetAllFromPeriodoDeclaracion
                rcmbPeridoDos.DataTextField = "NombreGeneral"
                rcmbPeridoDos.DataValueField = "IdPeridoDeclaracion"
                rcmbPeridoDos.DataBind()
                rcmbPeridoDos.SelectedValue = CInt(Request.QueryString("IdPeriodo"))

                rcmbTipoSistemaPension.Enabled = False
                rcmbSistemaPensiones.Enabled = False
                rcmbPeridoDos.Enabled = False
                cbPeridoAnterior.Enabled = False
                cbPeridoAnterior.Enabled = False

                'Obtener la lista de registros en el cual se agregados
                gvAportesSp.DataSource = aporteBL.GetAllFromAporteGuardado(CInt(Request.QueryString("IdSistemaPensiones")), CInt(Request.QueryString("IdPeriodo")))
                gvAportesSp.DataBind()

                gvAportesSpAnterior.DataSource = aporteBL.GetAllFromAporteAnterior(CInt(Request.QueryString("IdSistemaPensiones")), CInt(Request.QueryString("IdPeriodo")))
                gvAportesSpAnterior.DataBind()
            Else
                rcmbTipoSistemaPension.DataSource = tipoSistema.GetAllFromTipoSp
                rcmbTipoSistemaPension.DataTextField = "Tipo"
                rcmbTipoSistemaPension.DataValueField = "IdTipoSP"
                rcmbTipoSistemaPension.DataBind()

                rcmbSistemaPensiones.DataSource = sistemaPensiones.GetAllFromSistemaPensionesByTipoSp(rcmbTipoSistemaPension.SelectedValue)
                rcmbSistemaPensiones.DataTextField = "Descripcion"
                rcmbSistemaPensiones.DataValueField = "IdSistemaPensiones"
                rcmbSistemaPensiones.DataBind()

                rcmbPeridoDos.DataSource = perido.GetAllFromPeriodoDeclaracion
                rcmbPeridoDos.DataTextField = "NombreGeneral"
                rcmbPeridoDos.DataValueField = "IdPeridoDeclaracion"
                rcmbPeridoDos.DataBind()

                gvAportesSp.DataSource = aporteBL.GetAllFromAportesSp
                gvAportesSp.DataBind()

                'gvAportesSpAnterior.DataSource = aporteBL.GetAllFromAporteAnterior(rcmbSistemaPensiones.SelectedValue, rcmbPeridoDos.SelectedValue)
                'gvAportesSpAnterior.DataBind()
            End If

            'RadComboBox1.DataSource = sistemaPensiones.GetAllFromSistemaPensionesByTipoSp(1)
            'RadComboBox1.DataTextField = "Descripcion"
            'RadComboBox1.DataValueField = "IdSistemaPensiones"
            'RadComboBox1.DataBind()

        End If
    End Sub

    Protected Sub ibGuardar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibGuardar.Click
        Dim listaDetalle As New List(Of AportesPorPeriodo)
        Dim IdPeriodoDeclaracion As Int32 = rcmbPeridoDos.SelectedValue
        Dim IdSistemaPensioneas As Int32 = rcmbSistemaPensiones.SelectedValue

        Dim i As Integer
        For i = 0 To gvAportesSp.Rows.Count - 1
            Dim detalleAportesPerido As New AportesPorPeriodo
            Dim txtIdAporteSp As TextBox = CType(Me.gvAportesSp.Rows(i).FindControl("txtIdAporteSp"), TextBox)
            Dim txtPorcentaje As TextBox = CType(Me.gvAportesSp.Rows(i).FindControl("txtPorcentaje"), TextBox)

            detalleAportesPerido.IdPeridoDeclaracion = rcmbPeridoDos.SelectedValue
            detalleAportesPerido.IdSistemaPensiones = rcmbSistemaPensiones.SelectedValue
            detalleAportesPerido.IdAporteSp = CInt(txtIdAporteSp.Text)
            detalleAportesPerido.Porcentaje = CDec(txtPorcentaje.Text)

            listaDetalle.Add(detalleAportesPerido)
        Next

        Try
            Dim edicion As String = Request.QueryString("Resultado")
            If edicion = "a" Then
                aportePorPeridoBL.UpdateListaAportes1(listaDetalle)
            Else
                aportePorPeridoBL.SaveListaAportes1(listaDetalle)
            End If
            Response.Redirect("FrmBandejaSistemaPensiones.aspx")
        Catch ex As Exception
            lblMensajeError.Visible = True
            lblMensajeError.Text = "Ya se registró datos en este periodo."
        End Try
    End Sub

    Protected Sub rcmbTipoSistemaPension_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles rcmbTipoSistemaPension.SelectedIndexChanged
        rcmbSistemaPensiones.DataSource = sistemaPensiones.GetAllFromSistemaPensionesByTipoSp(rcmbTipoSistemaPension.SelectedValue)
        rcmbSistemaPensiones.DataTextField = "Descripcion"
        rcmbSistemaPensiones.DataValueField = "IdSistemaPensiones"
        rcmbSistemaPensiones.DataBind()
        gvAportesSpAnterior.DataBind()
        rcmbPeridoDos.Text = ""
        rcmbPeridoDos.ClearSelection()
        rcmbPeridoDos.DataBind()
        lblPeridoAnterior.Visible = False
    End Sub

    Protected Sub rcmbSistemaPensiones_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles rcmbSistemaPensiones.SelectedIndexChanged
        gvAportesSpAnterior.DataBind()
        rcmbPeridoDos.Text = ""
        rcmbPeridoDos.ClearSelection()
        rcmbPeridoDos.DataBind()
        lblPeridoAnterior.Visible = False
    End Sub

    Protected Sub rcmbPeridoDos_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles rcmbPeridoDos.SelectedIndexChanged
        If e.Text.Length > 4 Then
            gvAportesSpAnterior.DataSource = aporteBL.GetAllFromAporteAnterior(rcmbSistemaPensiones.SelectedValue, rcmbPeridoDos.SelectedValue)
            gvAportesSpAnterior.DataBind()
            If gvAportesSpAnterior.Rows.Count > 0 Then
                lblPeridoAnterior.Visible = True
            Else
                lblPeridoAnterior.Visible = False
            End If
            lblMensajeError.Visible = False
        Else
            gvAportesSpAnterior.DataBind()
            lblPeridoAnterior.Visible = False
        End If
    End Sub
End Class