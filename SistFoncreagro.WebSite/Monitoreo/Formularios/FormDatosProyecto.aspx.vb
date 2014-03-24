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
        'If Not Page.IsPostBack Then
        _personalBL = New PersonalBL()
        _proyectoBL = New ProyectoBL()
        'End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim accion = Request.QueryString("accion")
        Dim idProyecto = Request.QueryString("id")

        If Not Page.IsPostBack Then
            If IsNothing(accion) <> True And IsNothing(idProyecto) <> True Then
                If accion = "update" Then
                    _proyecto = _proyectoBL.GetProyectoDtoyIdProyecto(idProyecto)
                    BindProyecto(_proyecto)
                End If

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

    Protected Sub rgConvenios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgConvenios.SelectedIndexChanged
        Dim idConvProy = rgConvenios.SelectedValue

        Dim proyecto As ProyectoDto = Cache.Get("proyecto")

        Dim convenio = (From p In proyecto.Convenios
                       Where p.IdConvProy.Equals(idConvProy)
                       Select p).SingleOrDefault()

        _proyectoBL.LoadComponentes(convenio)

        Cache.Insert("proyecto", proyecto)

        rgComponentes.DataSource = convenio.Componentes
        rgComponentes.DataBind()

        rgActividades.DataSource = Nothing
        rgActividades.DataBind()

        rgCCostos.DataSource = Nothing
        rgCCostos.DataBind()


    End Sub

    Protected Sub rgComponentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgComponentes.SelectedIndexChanged
        Dim IdProycomp = rgComponentes.SelectedValue
        Dim idConvProy = rgConvenios.SelectedValue

        Dim proyecto As ProyectoDto = Cache.Get("proyecto")

        Dim convenio = (From p In proyecto.Convenios
                       Where p.IdConvProy.Equals(idConvProy)
                       Select p).SingleOrDefault()


        Dim componente = (From c In convenio.Componentes
                         Where c.IdProyComp.Equals(IdProycomp)
                         Select c).SingleOrDefault()

        _proyectoBL.LoadActividades(componente)

        Cache.Insert("proyecto", proyecto)

        rgActividades.DataSource = componente.Actividades
        rgActividades.DataBind()

        rgCCostos.DataSource = Nothing
        rgCCostos.DataBind()

    End Sub

    Protected Sub rgActividades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgActividades.SelectedIndexChanged
        Dim IdProycomp = rgComponentes.SelectedValue
        Dim idConvProy = rgConvenios.SelectedValue
        Dim IdProyAct = rgActividades.SelectedValue

        Dim proyecto As ProyectoDto = Cache.Get("proyecto")

        Dim convenio = (From p In proyecto.Convenios
                       Where p.IdConvProy.Equals(idConvProy)
                       Select p).SingleOrDefault()


        Dim componente = (From c In convenio.Componentes
                         Where c.IdProyComp.Equals(IdProycomp)
                         Select c).SingleOrDefault()

        Dim actividad = (From act In componente.Actividades
                        Where act.IdProyAct.Equals(IdProyAct)
                        Select act).SingleOrDefault()

        If Not actividad Is Nothing Then

            _proyectoBL.LoadCCostos(actividad)

            btnShowAddCCosto.Visible = IIf(actividad.CCostos.Count > 0, True, False)
            pnlAddCCostos.Visible = btnShowAddCCosto.Visible

            ''''''''' Bideo Cajas '''''''''''
            rtxtDescActividad.Text = actividad.Actividad

        End If

        

        Cache.Insert("proyecto", proyecto)

        rgCCostos.DataSource = actividad.CCostos
        rgCCostos.DataBind()

        

    End Sub
End Class