Imports SistFoncreagro.BussinesLogic
Public Class FrmPersonal
    Inherits System.Web.UI.Page
    Dim personalBL As New PersonalBL
    Dim filtro As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.txtFechaIni.SelectedDate = DateAdd(DateInterval.Day, -30, Today.Date)
        'Me.txtFechaFin.SelectedDate = Today.Date 
        filtro = Session("filtro")

        If Not Page.IsPostBack Then
            If Not String.IsNullOrEmpty(filtro) Then
                Me.RCBFiltro.SelectedValue = filtro
                ColocarValoresEnLosTextbox(Me.RCBFiltro)
            End If
        End If
    End Sub

    Protected Sub RadGrid1_NeedDataSource(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGrid1.NeedDataSource

    End Sub

    Protected Sub RadGrid1_ItemCommand(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles RadGrid1.ItemCommand
        If e.CommandName = Telerik.Web.UI.RadGrid.ExportToExcelCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToWordCommandName OrElse e.CommandName = Telerik.Web.UI.RadGrid.ExportToPdfCommandName Then
            ConfigureExport()
        End If
        If e.CommandName = "InitInsert" Then
            Dim cadena_java As String
            ''cadena_java = "<script type='text/javascript'> NuevoColaborador();" & Chr(60) & "/script >"
            ''ScriptManager.RegisterStartupScript(Page, GetType(Page), "Nuevo", cadena_java.ToString, False)

            ' ''Response.Redirect("~\RRHH\Formulario\FrmRegistroPersonal.aspx?IdPersonal=0")
            cadena_java = "<script type='text/javascript'> " & _
                                 " NuevoColaborador(); " & _
                                 Chr(60) & "/script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
            e.Canceled = True
        End If
    End Sub

    Public Sub ConfigureExport()
        RadGrid1.ExportSettings.ExportOnlyData = True
        RadGrid1.ExportSettings.IgnorePaging = True
        RadGrid1.ExportSettings.OpenInNewWindow = True
    End Sub

    Protected Sub RCBFiltro_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RCBFiltro.SelectedIndexChanged
        ColocarValoresEnLosTextbox(sender)
    End Sub


    Protected Sub RCBFiltro_Load(ByVal sender As Object, ByVal e As EventArgs) Handles RCBFiltro.Load
        ColocarValoresEnLosTextbox(sender)
    End Sub

    Sub ColocarValoresEnLosTextbox(ByVal sender As Object)
        Dim lista As Telerik.Web.UI.RadComboBox = CType(sender, Telerik.Web.UI.RadComboBox)

        Select Case lista.SelectedValue
            Case 1 'Colaboradores activos
                Me.txtIdCategoria.Text = 1
                Me.Panel1.Visible = False
                Me.RadGrid1.Columns(13).Visible = False
                Session("filtro") = 1
            Case 2 'Colabordores liquidados
                Me.txtIdCategoria.Text = 1
                Me.RadGrid1.Columns(13).Visible = True
                Session("filtro") = 2
                'Me.Panel1.Visible = True
            Case 3 'Sin vinculo laboral
                Me.txtIdCategoria.Text = 0
                Me.Panel1.Visible = False
                Session("filtro") = 3
            Case 4 'Practicantes
                Me.txtIdCategoria.Text = 4
                Me.Panel1.Visible = False
                Session("filtro") = 4
                'Case 10 'todos 
                '    Me.txtIdCategoria.Text = 0
                '    Me.Panel1.Visible = False
            Case Else
                Me.txtIdCategoria.Text = 0
                Me.Panel1.Visible = False
                Session("filtro") = 0
        End Select
    End Sub


    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btn As New ImageButton
        btn = CType(sender, ImageButton)
        Session("IdPersonal") = btn.CommandArgument

        Dim cadena_java As String

        cadena_java = "<script type='text/javascript'> " & _
                             " NuevoColaborador(); " & _
                             Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Editar", cadena_java.ToString, False)

        'Response.Redirect("~\RRHH\Formulario\FrmRegistroPersonal.aspx?IdPersonal=" & btn.CommandArgument)
    End Sub
    Protected Sub imgBtnEliminar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btn As New ImageButton
        btn = CType(sender, ImageButton)
        personalBL.DeletePersonal(btn.CommandArgument)
        Response.Redirect("FrmPersonal.aspx")
    End Sub
    Protected Sub AjaxManager_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles AjaxManager.AjaxRequest
        'Dim url As String
        'Dim cadena_java As String
        If e.Argument.StartsWith("cerrarpagina") Then
            Session.Remove("IdPersonal")
            Response.Redirect("FrmPersonal.aspx")
        End If
    End Sub

    Protected Sub btnAsignarHorario_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btn As New ImageButton
        Dim ids() As String
        btn = CType(sender, ImageButton)

        ids = Split(btn.CommandArgument, "/")

        Session("IdPeriodoLaboral") = ids(0)
        Session("nombre") = ids(1)
        Session("area") = ids(2)
        Session("posicion") = ids(3)

        Dim cadena_java As String

        cadena_java = "<script type='text/javascript'> " & _
                             "AsignarHorario(); " & _
                             Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Horario", cadena_java.ToString, False)

        'Response.Redirect("~\RRHH\Formulario\FrmRegistroPersonal.aspx?IdPersonal=" & btn.CommandArgument)
    End Sub

    Protected Sub btnCentroCosto_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btn As New ImageButton
        Dim ids() As String
        btn = CType(sender, ImageButton)

        ids = Split(btn.CommandArgument, "/")

        Session("IdPeriodoLaboral") = ids(0)
        Session("nombre") = ids(1)
        Session("area") = ids(2)
        Session("posicion") = ids(3)

        Dim cadena_java As String

        cadena_java = "<script type='text/javascript'> " & _
                             "AsignarCC(); " & _
                             Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "CC", cadena_java.ToString, False)

        'Response.Redirect("~\RRHH\Formulario\FrmRegistroPersonal.aspx?IdPersonal=" & btn.CommandArgument)
    End Sub

    Protected Sub btnAusencias_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btn As New ImageButton
        Dim ids() As String
        btn = CType(sender, ImageButton)

        ids = Split(btn.CommandArgument, "/")

        Session("IdPeriodoLaboral") = ids(0)
        Session("nombre") = ids(1)
        Session("area") = ids(2)
        Session("posicion") = ids(3)


        Dim cadena_java As String

        cadena_java = "<script type='text/javascript'> " & _
                             "RegistrarAusencia(); " & _
                             Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Ausencia", cadena_java.ToString, False)
    End Sub
End Class