Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI
Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class ValidarExisteEncuesta
    Inherits System.Web.UI.Page
    Dim EncuestaLLenaBl As New EncuestaLlenaBL
    Dim _EncuestaLlena As New EncuestaLlena
    Dim EncuestaLlena As EncuestaLlena
    Dim RespuestaBl As New RespuestaBL
    Dim _Respuesta As New Respuesta
    Dim valor As Int32
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        valor = EncuestaLLenaBl.VerifyExisteENCUESTALLENAByIdPersonal(Session("IdUser"))
        If valor > 0 Then
            EncuestaLlena = EncuestaLLenaBl.GetENCUESTALLENAByIdEncuesta(valor)
            If EncuestaLlena.Estado = "I" Then
                Response.Redirect("FrmEncuesta.aspx?IdEncuestallena=" + valor.ToString)
            Else
                Dim cadena_java As String = _
                       "<script language='javascript'>function f(){radalert('<b>¡La Encuesta ya fue Enviada, Gracias por su Apoyo!</b>', 330, 100,'Mensaje de Información',alertCallBackFn); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)

            End If
        Else
            _EncuestaLlena.Candidato.Equals(DBNull.Value)
            _EncuestaLlena.Fecha = Date.Now
            _EncuestaLlena.IdPersonal = Session("IdUser")
            _EncuestaLlena.IdProyecto.Equals(DBNull.Value)
            valor = EncuestaLLenaBl.SaveENCUESTALLENA(_EncuestaLlena)
            RespuestaBl.SaveRESPUESTA(valor)
            Response.Redirect("FrmEncuesta.aspx?IdEncuestallena=" + valor.ToString)
        End If
    End Sub

End Class