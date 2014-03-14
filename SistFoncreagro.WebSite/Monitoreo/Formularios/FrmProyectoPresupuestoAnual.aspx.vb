Imports System
Imports System.Data
Imports System.Collections
Imports System.Web.UI
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic

Public Class FrmProyectoPresupuestoAnual
    Inherits System.Web.UI.Page

    Public Function ValidarNumero(ByVal Valor As System.Nullable(Of Decimal)) As Decimal
        Dim MisFunciones As New Funciones
        Dim miNumero As Decimal = MisFunciones.ValorNumero(Valor)
        Return miNumero
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim miId As String
            miId = Request.QueryString("IdProyecto")
            HIdProyecto.Value = miId

            Dim _EjerPresup As New EjerPresup
            Dim _EjerPresupBL As New EjerPresupBL
            _EjerPresup = _EjerPresupBL.GetEjerPresupByEstado("PROCESO")

            Dim _AnioActualBL As New DatosActualBL

            HFAnioActual.Value = _AnioActualBL.GetAnioActual

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
                Dim Cad As String
                Cad = Llenar_Anios()
                If Cad <> "" Then RWMensaje.RadAlert(Cad, 200, 100, "Error", "")
                RGDatos.DataBind()
            End If
        End If
    End Sub

    Private Function Llenar_Anios() As String
        Llenar_Anios = ""
        Dim cad As String
        Dim idProy As Int32
        idProy = Integer.Parse(Request.QueryString("IdProyecto"))
        Dim _Proyecto As New Proyecto
        Dim _ProyectoBL As New ProyectoBL
        _Proyecto = _ProyectoBL.GetFromProyectoByIdProyecto(idProy)
        LblProyecto.Text = _Proyecto.Nombre
        Dim AnioIni, AnioFin, cont As Int32
        cad = ""
        If Len(_Proyecto.IniProyProg) <> 0 Then AnioIni = Year(DateValue(_Proyecto.IniProyProg)) Else cad = "El proyecto no tiene fecha inicial. COMPLETE" : Exit Function
        If Len(_Proyecto.FinProyProg) <> 0 Then AnioFin = Year(DateValue(_Proyecto.FinProyProg)) Else cad = "El proyecto no tiene fecha final. COMPLETE" : Exit Function

        Dim AnioActual As Int32
        AnioActual = Integer.Parse(TxtAnio.Text)
        cont = AnioIni
        CbAnio.Text = AnioActual + 1
        If AnioIni < AnioActual Then
            cont = AnioActual
            CbAnio.Text = AnioActual
        End If

        While cont <= AnioFin
            CbAnio.Items.Add(cont.ToString)
            cont = cont + 1
        End While
        Return cad
    End Function

    Private Sub CbAnio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbAnio.TextChanged
        RGDatos.DataBind()
    End Sub

    Private Sub RGDatos_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RGDatos.ItemCommand
        If e.CommandName = "Grabar" Then
            Dim mIdCCosto, f, mIdEjerPresup As Int32
            Dim _DetEjerPresup As DetEjerPresup
            Dim editeditem As GridEditableItem = CType(e.Item, GridEditableItem)
            mIdCCosto = editeditem.OwnerTableView.DataKeyValues(editeditem.ItemIndex)("IdCCosto")
            mIdEjerPresup = Integer.Parse(HFIdEjerPresup.Value)
            f = editeditem.ItemIndex

            _DetEjerPresup = New DetEjerPresup

            _DetEjerPresup.IdCCosto = mIdCCosto
            _DetEjerPresup.IdEjerPresup = mIdEjerPresup
            _DetEjerPresup.Anio = Integer.Parse(CbAnio.Text)
            _DetEjerPresup.Mes = 13
            Dim valor As Decimal
            If CType(RGDatos.Items(f).FindControl("LblPresup"), Label).Visible = True Then
                valor = Decimal.Parse(CType(RGDatos.Items(f).FindControl("LblPresup"), Label).Text)
            ElseIf CType(RGDatos.Items(f).FindControl("TxtPresup"), RadNumericTextBox).Visible = True Then
                valor = Decimal.Parse(CType(RGDatos.Items(f).FindControl("TxtPresup"), RadNumericTextBox).Text)
            End If
            If (f Mod 2) = 0 Then
                _DetEjerPresup.ProgramadoPresup = valor
                _DetEjerPresup.ProgramadoFisico.Equals(DBNull.Value)
            Else
                _DetEjerPresup.ProgramadoFisico = valor
                _DetEjerPresup.ProgramadoPresup.Equals(DBNull.Value)
            End If
            Dim _DetEjerPresupBL As New DetEjerPresupBL
            _DetEjerPresupBL.SaveDetEjerPresup(_DetEjerPresup)
            RGDatos.DataBind()
        End If
    End Sub

    Protected Sub RGDatos_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles RGDatos.ItemDataBound
        Dim _AnioActual, _Anio, f, i As Int32
        _Anio = Integer.Parse(CbAnio.Text)
        _AnioActual = Integer.Parse(HFAnioActual.Value)
        f = RGDatos.Items.Count
        Dim sw As Boolean
        sw = True
        If _Anio <= _AnioActual Then
            For i = 0 To f - 1
                CType(RGDatos.Items(i).FindControl("LblPresup"), Label).Visible = True
                CType(RGDatos.Items(i).FindControl("TxtPresup"), RadNumericTextBox).Visible = False
            Next
            sw = False
        Else
            For i = 0 To f - 1
                CType(RGDatos.Items(i).FindControl("LblPresup"), Label).Visible = False
                CType(RGDatos.Items(i).FindControl("TxtPresup"), RadNumericTextBox).Visible = True
            Next
        End If
        RGDatos.Columns(5).Visible = sw
    End Sub

    Private Sub FrmProyectoPresupuestoAnual_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
        If RGDatos.Items.Count = 0 Then
            BtnNuevo.Visible = True
        Else
            BtnNuevo.Visible = False
        End If
    End Sub

    Protected Sub BtnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNuevo.Click
        Dim _DatosPresupAnual As New DatosPresupAnualBL
        Dim _IdProy, _IdEjerPresup As Int32
        _IdEjerPresup = Integer.Parse(HFIdEjerPresup.Value)
        _IdProy = Integer.Parse(Request.QueryString("IdProyecto"))
        _DatosPresupAnual.CrearPresupAnual(_IdProy, _IdEjerPresup)
        RGDatos.DataBind()
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        If HIdProyecto.Value = "" Then RWMensajes.RadAlert("No hay un proyecto seleccionado", 230, 100, "Error", "") : Exit Sub
        Select Case e.Item.Value
            Case "Datos"
                Response.Redirect("~\Monitoreo\Formularios\FrmDatosProyecto.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Convenio"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoConvenio.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Componentes"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoComponentes.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Actividades"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoActividad.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "CCostos"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoCCosto.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Ambito"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoAmbito.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "Informes"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoInformes.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "ForFin"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoPresupuesto.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "ForAnual"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoPresupuestoAnual.aspx?IdProyecto=" + HIdProyecto.Value)

            Case "AvanFis"
                Response.Redirect("~\Monitoreo\Formularios\FrmProyectoAvanceFisico.aspx?IdProyecto=" + HIdProyecto.Value)
        End Select
    End Sub
End Class