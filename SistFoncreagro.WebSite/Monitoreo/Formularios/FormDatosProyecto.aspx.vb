Imports System.IO
Imports CrystalDecisions.Shared.Json
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Imports Telerik.Web.UI

Public Class FormDatosProyecto
    Inherits System.Web.UI.Page

    Dim _personalBL As IPersonalBL
    Dim _proyectoBL As IProyectoBL
    Dim _proyecto As ProyectoDto

    Const PROYECTO As String = "proyecto"

    Protected Overrides Sub OnInit(ByVal e As EventArgs)
        MyBase.OnInit(e)
        If Not Page.IsPostBack Then
            _personalBL = New PersonalBL()
            _proyectoBL = New ProyectoBL()
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim accion = Request.QueryString("accion")
        Dim idProyecto = Request.QueryString("id")

        If IsNothing(accion) <> True And IsNothing(idProyecto) <> True Then
            If accion = "update" Then
                _proyecto = _proyectoBL.GetProyectoDtoyIdProyecto(idProyecto)
                BindProyecto(_proyecto)
            End If

        End If

    End Sub

    Private Sub BindProyecto(ByVal proyecto As ProyectoDto)

        hfIdProyecto.Value = proyecto.IdProyecto
        txtArea.Text = proyecto.Codigo
        txtNombreProyecto.Text = proyecto.Nombre
        txtAliasProyecto.Text = proyecto.AliasProy
        radcbPersonal.Entries.Insert(0, New AutoCompleteBoxEntry(proyecto.Responsable, proyecto.IdResponsable))
        cbAlineamiento.Text = IIf(IsDBNull(proyecto.Alineamiento), "[- Seleccione uno -]", proyecto.Alineamiento)
        cbPrograma.Text = IIf(IsDBNull(proyecto.Programa), "[- Seleccione uno -]", proyecto.Programa)
        If proyecto.IniProyProg.HasValue Then rdpInicioProgramado.SelectedDate = proyecto.IniProyProg.Value Else rdpInicioProgramado.Clear()
        If proyecto.FinProyProg.HasValue Then rdpFinProgramado.SelectedDate = proyecto.FinProyProg Else rdpFinProgramado.Clear()
        cbEstado.Text = proyecto.Estado
        txtCodigoAdicional.Text = proyecto.CodigoAdicional

        rgConvenios.DataSource = proyecto.Convenios
        rgConvenios.DataBind()

        Cache.Insert("proyecto", proyecto)
    End Sub

    Protected Sub odsPersonal_ObjectCreating(sender As Object, e As System.Web.UI.WebControls.ObjectDataSourceEventArgs) Handles odsPersonal.ObjectCreating
        e.ObjectInstance = _personalBL
    End Sub
End Class