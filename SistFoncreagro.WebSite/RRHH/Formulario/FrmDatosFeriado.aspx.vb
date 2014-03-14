Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Imports Telerik.Web.UI

Public Class FrmDatosFeriado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack = True Then
            HFIdFeriado.Value = Request.QueryString("IdFeriado")
            If HFIdFeriado.Value = "0" Then
                Limpiar_campos()
            Else
                Llenar_Datos()
            End If
        End If
    End Sub

    Private Sub Limpiar_Campos()
        RDFecha.Clear()
    End Sub

    Private Sub Limpiar_Campos_Recuperacion()
        RdFechaInicio.Clear()
        RTInicio.Clear()
        RTFin.Clear()
        TxtNDias.Text = ""
        CbTurno.ClearSelection()
    End Sub

    Private Sub Llenar_Datos()
        Dim miId As Int32
        miId = Integer.Parse(HFIdFeriado.Value)
        Dim _Feriado As New Feriado
        Dim _FeriadoBL As New FeriadoBL
        _Feriado = _FeriadoBL.GetFeriadoById(miId)
        RDFecha.SelectedDate = DateValue(_Feriado.Fecha)
        CbOrigen.Text = _Feriado.Origen
        If _Feriado.Recuperable = True Then CbRec.Text = "SI" Else CbRec.Text = "NO"
        If CbRec.Text = "SI" Then
            Panel1.Visible = True
            RGRecuperacion.DataBind()
            If RGRecuperacion.Items.Count = 0 Then
                Panel2.Visible = True
                Panel1.Visible = False
                BtnRec.Visible = False
            Else
                Panel2.Visible = False
                Panel1.Visible = True
            End If
        Else
            Panel1.Visible = False
            Panel2.Visible = False
        End If
        
    End Sub

    Protected Sub BtnGrabar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnGrabar.Click
        Call Grabar_Feriado()
    End Sub

    Protected Sub BtnGenerar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGenerar.Click
        If HFIdFeriado.Value = "0" Then Call Grabar_Feriado()
        Dim nDias, IdTurno, IdFeriado As Int32
        Dim FeIni As Date
        Dim HIni, HFin As String
        nDias = Integer.Parse(TxtNDias.Text)
        HIni = Format(RTInicio.SelectedDate, "HH:mm")
        HFin = Format(RTFin.SelectedDate, "HH:mm")
        IdTurno = Integer.Parse(CbTurno.SelectedValue)
        IdFeriado = Integer.Parse(HFIdFeriado.Value)
        FeIni = DateValue(RdFechaInicio.SelectedDate)

        Dim _recupBL As New CronogramaRecuperacionBL
        _recupBL.CrearCronogramaRecuperacion(nDias, FeIni, HIni, HFin, IdTurno, IdFeriado)
        RGRecuperacion.DataBind()
        Panel1.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub Grabar_Feriado()
        Dim _Feriado As New Feriado
        Dim _FeriadoBL As New FeriadoBL
        If HFIdFeriado.Value <> "0" Then _Feriado.IdFeriado = Integer.Parse(HFIdFeriado.Value)
        _Feriado.Fecha = DateValue(RDFecha.SelectedDate)
        _Feriado.Origen = UCase(CbOrigen.Text)
        If CbRec.Text = "SI" Then _Feriado.Recuperable = True Else _Feriado.Recuperable = False
        HFIdFeriado.Value = _FeriadoBL.SaveFeriado(_Feriado)
    End Sub

    Protected Sub CbRec_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CbRec.SelectedIndexChanged
        If CbRec.Text = "SI" Then Panel1.Visible = True Else Panel1.Visible = False
    End Sub

    Protected Sub BtnRec_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRec.Click
        If RGRecuperacion.Items.Count = 0 Then
            Panel2.Visible = True
            Panel1.Visible = False
        Else
            Panel2.Visible = False
            Panel1.Visible = True
        End If
    End Sub

    Protected Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCancelar.Click
        Response.Redirect("~\RRHH\Formulario\FrmFeriado.aspx")
    End Sub
End Class