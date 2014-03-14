Imports SistFoncreagro.BussinesLogic
Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim EjercicioBL As New EjercicioBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim estadoMes As String = ""
        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
        If estadoMes = "C" Then
            Dim radalertscript As String = "<script language='javascript'>function f(){radalert('<b>¡Mes Cerrado, opción Deshabilitada!</b> ', 330, 100,'¡Alerta!'); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
            Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radalert", radalertscript)
        Else
            Response.Redirect("BuscarComprobante.aspx")
        End If
    End Sub

End Class