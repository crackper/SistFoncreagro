Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class FrmActivarPresupuesto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            Dim _EjerPresup As New EjerPresup
            Dim _EjerPresupBl As New EjerPresupBL
            _EjerPresup = _EjerPresupBl.GetEjerPresupByEstado("PROCESO")
            If _EjerPresup Is Nothing Then
                LblPresup.Visible = True
                Panel2.Visible = False
                RGDatos.Visible = False
            Else
                LblPresup.Visible = False
                Panel2.Visible = True
                RGDatos.Visible = True
                TxtAnio.Text = _EjerPresup.Anio
                HFIdEjerPresup.Value = _EjerPresup.IdEjerPresup
                TxtEjerPresup.Text = _EjerPresup.Codigo
                TxtMesIni.Text = _EjerPresup.MesIni
                RGDatos.DataBind()
                If RGDatos.Items.Count = 0 Then
                    BtnGenerar.Visible = True
                Else
                    BtnGenerar.Visible = False
                End If
            End If
        End If
    End Sub

    Protected Sub BtnGenerar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnGenerar.Click
        Dim _ActPresupBL As New ActivarPresupuestoBL
        Dim _IdEjerPresup As Int32
        _IdEjerPresup = Integer.Parse(HFIdEjerPresup.Value)
        _ActPresupBL.NueActivarPresup(_IdEjerPresup)
        RGDatos.DataBind()
    End Sub

    Protected Sub BtnGrabar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnGrabar.Click
        Dim f, i As Int32
        Dim _ActivarPresupuesto As ActivarPresupuesto
        Dim _LsActivarPresupuesto As New List(Of ActivarPresupuesto)
        f = RGDatos.Items.Count - 1
        For i = 0 To f
            _ActivarPresupuesto = New ActivarPresupuesto
            _ActivarPresupuesto.IdActPresup = RGDatos.Items(i).OwnerTableView.DataKeyValues(i)("IdActPresup")
            _ActivarPresupuesto.Activar = CType(RGDatos.Items(i).FindControl("ChActivar"), CheckBox).Checked
            _LsActivarPresupuesto.Add(_ActivarPresupuesto)
        Next
        Dim _ActivarPresupBL As New ActivarPresupuestoBL
        _ActivarPresupBL.UpdateActivarPresup1(_LsActivarPresupuesto)
    End Sub
End Class