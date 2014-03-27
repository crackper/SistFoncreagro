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

            ''''''''' Bideo Cajas '''''''''''
            rtxtDescActividad.Text = actividad.Actividad
            hfIdProyAct.Value = actividad.IdProyAct
            hfIdProycomp.Value = actividad.IdProycomp

        End If

        

        Cache.Insert("proyecto", proyecto)

        btnShowAddCCosto.Visible = True
        rgCCostos.DataSource = actividad.CCostos
        rgCCostos.DataBind()

        

    End Sub

    Protected Sub btnAddCCosto_Click(sender As Object, e As EventArgs) Handles btnAddCCosto.Click

        If radcbElementoGasto.Entries.Count = 0 Then rwmMessages.RadAlert("Seleccione un Elemento de Gasto", 400, 150, "Error", "") : Exit Sub
        If rntxtPorcentaje.Text = "" Then rwmMessages.RadAlert("Ingrese el Porcentaje de Participacion", 400, 150, "Error", "") : Exit Sub

        Dim ccosto = New CCostoDto()
        Dim msg = New StringBuilder()
        Dim idProycomp = rgComponentes.SelectedValue
        Dim idConvProy = rgConvenios.SelectedValue
        Dim idProyAct = rgActividades.SelectedValue

        ccosto.IdCCosto = 0
        ccosto.NomElemGasto = radcbElementoGasto.Entries(0).Text
        ccosto.IdElemGasto = radcbElementoGasto.Entries(0).Value
        ccosto.Porcentaje = rntxtPorcentaje.Text
        ccosto.IdProyAct = hfIdProyAct.Value
        ccosto.Unidad = rtxtUnidad.Text

        Dim proyecto As ProyectoDto = Cache.Get("proyecto")

        Dim convenio = (From p In proyecto.Convenios
                       Where p.IdConvProy.Equals(idConvProy)
                       Select p).SingleOrDefault()


        Dim componente = (From c In convenio.Componentes
                         Where c.IdProyComp.Equals(idProycomp)
                         Select c).SingleOrDefault()

        Dim actividad = (From act In componente.Actividades
                        Where act.IdProyAct.Equals(idProyAct)
                        Select act).SingleOrDefault()

        Dim existe = actividad.CCostos.Where(Function(c) c.IdElemGasto.Equals(ccosto.IdElemGasto) And c.IdProyAct.Equals(ccosto.IdProyAct))

        If existe.Any() Then
            rwmMessages.RadAlert("El Elemento de Gasto ya esta asociado a esta Actividad", 450, 150, "Mensaje", "rbShowAddCCosto_OnClientClicked()")
        Else

            Dim pdisponible = 100 - actividad.CCostos.Sum(Function(c) c.Porcentaje)

            If ccosto.Porcentaje <= pdisponible Then
                actividad.CCostos.Add(ccosto)
                Cache.Insert("proyecto", proyecto)

                radcbElementoGasto.Entries.Clear()
                rtxtUnidad.Text = String.Empty
                rntxtPorcentaje.Text = String.Empty
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "123", "CloseAddCCosto();", True)
            Else
                rwmMessages.RadAlert("El Porcentaje ingresado excede el % disponible", 450, 120, "Mensaje", "rbShowAddCCosto_OnClientClicked()")
            End If

        End If

        rgCCostos.DataSource = actividad.CCostos
        rgCCostos.DataBind()
    End Sub

    Protected Sub rgCCostos_ItemCommand(sender As Object, e As Telerik.Web.UI.GridCommandEventArgs) Handles rgCCostos.ItemCommand
        If e.CommandName = "editar" Then

            rtxtUnidad.Text = e.CommandArgument.ToString()
            rapShowAddCCosto.ResponseScripts.Add("rbShowAddCCosto_OnClientClicked();")
        End If
    End Sub
End Class