Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI
Public Class FrmRequerimientoNuevo
    Inherits System.Web.UI.Page
    Dim requerimientoBL As IRequerimientoBL
    Dim centroCosto As ICCostoBL
    Protected Sub ibGuardar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibGuardar.Click
        requerimientoBL = New RequerimientoBL
        Dim requerimiento As New Requerimiento
        requerimiento.IdProyectoArea = rcmProyecto.SelectedValue
        requerimiento.IdCentroCosto = rcbCentroCosto.SelectedValue
        requerimiento.IdMoneda = ddlMoneda.SelectedValue
        requerimiento.Tipo = ddlTipoRequerimiento.SelectedValue
        requerimiento.IdRequeridoPor = Session("IdUser")
        requerimiento.Observacion = txtObservacion.Text
        requerimiento.Sustento = txtSustento.Text

        If cbPeriodo.Checked = True Then
            requerimiento.Periodo = True
            requerimiento.FechaInicioServicio = rdpPeriodoInicio.SelectedDate
            requerimiento.FechaFinServicio = rdpPeriodoFin.SelectedDate
        Else
            requerimiento.Periodo = False
            requerimiento.FechaInicioServicio = "01/01/2001"
            requerimiento.FechaFinServicio = "01/01/2001"
        End If

        If cbRuta.Checked = True Then
            requerimiento.Ruta = True
            requerimiento.IdRutaOrigen = rcbOrigen.SelectedValue
            requerimiento.IdRutaDestino = rcbDestino.SelectedValue
        Else
            requerimiento.Ruta = False
        End If

        Dim IdRequerimiento As Int32
        IdRequerimiento = requerimientoBL.SaveRequerimiento(requerimiento)
        Me.Response.Redirect("FrmRequerimientoEditar.aspx?IdReq=" & IdRequerimiento)

    End Sub

    Protected Sub ddlTipoRequerimiento_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlTipoRequerimiento.SelectedIndexChanged
        If ddlTipoRequerimiento.SelectedValue = "SERVICIO" Then
            EnableCbPeridoCbRuta(ddlTipoRequerimiento.SelectedValue, True)
        Else
            EnableCbPeridoCbRuta(ddlTipoRequerimiento.SelectedValue, False)
            EnableRcmRuta(False)
            EnableRdtpPeriodo(False)
        End If

    End Sub

    Protected Sub cbPeriodo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbPeriodo.CheckedChanged
        If cbPeriodo.Checked = True Then
            EnableRdtpPeriodo(True)
        Else
            EnableRdtpPeriodo(False)
        End If
    End Sub

    Protected Sub cbRuta_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbRuta.CheckedChanged
        If cbRuta.Checked = True Then
            EnableRcmRuta(True)
        Else
            EnableRcmRuta(False)
        End If
    End Sub

    Sub EnableRcmRuta(ByVal valor As Boolean)
        rcbOrigen.Enabled = valor
        rcbDestino.Enabled = valor
    End Sub

    Sub EnableRdtpPeriodo(ByVal valor As Boolean)
        rdpPeriodoInicio.Enabled = valor
        rdpPeriodoFin.Enabled = valor
    End Sub

    Sub EnableCbPeridoCbRuta(ByVal parametro As String, ByVal valor As Boolean)
        cbPeriodo.Enabled = valor
        cbRuta.Enabled = valor
        If parametro <> "SERVICIO" Then
            cbPeriodo.Checked = valor
            cbRuta.Checked = valor
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        rcmProyecto.Filter = 1
        rcbCentroCosto.Filter = 1
    End Sub
End Class