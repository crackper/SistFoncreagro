Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.BussinesLogic
Public Class VentaResposables
    Inherits System.Web.UI.Page
    Dim rolPersonaBl As IRolPersonalBL
    Dim rolPersona As New RolPersonal
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            rcmProyecto.Filter = 1
            rcmbPersonal.Filter = 1
            rcmbProyecto0.Filter = 1
            rcmbPersonal0.Filter = 1
            rcmbPersonaOriginal.Filter = 1
            rcmbPersonaReemplazo.Filter = 1
        End If
    End Sub
    Protected Sub lbAgregarResponsable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbAgregarResponsable.Click
        rolPersonaBl = New RolPersonalBL
        rolPersona.IdRol = ddlRolProceso.SelectedValue
        rolPersona.IdPersonal = rcmbPersonal.SelectedValue
        rolPersona.IdProyecto = rcmProyecto.SelectedValue
        rolPersona.Estado = True
        rolPersonaBl.SaveRolPersonal(rolPersona)
        gvRolPersonal.DataBind()
    End Sub

    Protected Sub gvRolPersonal_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvRolPersonal.RowCommand
        Dim index = e.CommandArgument
        If e.CommandName = "Enable" Then
            rolPersonaBl = New RolPersonalBL
            Dim label As Label = CType(Me.gvRolPersonal.Rows(index).FindControl("lblEstado"), Label)
            rolPersona.IdRolPersonal = gvRolPersonal.DataKeys(index).Item(0).ToString
            rolPersona.Estado = IIf(label.Text = "True", False, True)
            'MsgBox(rolPersona.IdRolPersonal & " - " & rolPersona.Estado)
            rolPersonaBl.SaveRolPersonal(rolPersona)
            gvRolPersonal.DataBind()
        End If
    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        rolPersonaBl = New RolPersonalBL
        Dim idPersProy As Int32
        If rbResponsable.Checked = True Then
            If Not String.IsNullOrEmpty(rcmbPersonal0.SelectedValue) Then
                idPersProy = rcmbPersonal0.SelectedValue
            Else
                idPersProy = 0
            End If
            gvRolPersonal.DataSource = rolPersonaBl.GetFromRolPersonalByIdRol(ddlRolProceso.SelectedValue, idPersProy, False)
            rcmbProyecto0.Text = ""
        Else
            If rbProyecto.Checked = True Then
                If Not String.IsNullOrEmpty(rcmbProyecto0.SelectedValue) Then
                    idPersProy = rcmbProyecto0.SelectedValue
                Else
                    idPersProy = 0
                End If
                gvRolPersonal.DataSource = rolPersonaBl.GetFromRolPersonalByIdRol(ddlRolProceso.SelectedValue, idPersProy, True)
                rcmbPersonal0.Text = ""
            End If
        End If
        gvRolPersonal.DataBind()
    End Sub

    Protected Sub lbCambiarResponsable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbCambiarResponsable.Click
        rolPersonaBl = New RolPersonalBL
        rolPersonaBl.UpdateResponsable(rcmbPersonaOriginal.SelectedValue, rcmbPersonaReemplazo.SelectedValue, ddlRol.SelectedValue, 0)
        lblmensaje.Text = "Se actualizó responsable."
    End Sub
End Class