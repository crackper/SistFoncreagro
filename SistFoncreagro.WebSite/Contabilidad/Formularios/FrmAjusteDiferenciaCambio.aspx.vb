Imports SistFoncreagro.BussinesLogic
Public Class FrmAjusteDiferenciaCambio
    Inherits System.Web.UI.Page
    Dim EjercicioBL As New EjercicioBL
    Dim TipoCambioBl As New TipocambioBL
    Dim TransaccionBl As New TransaccionBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim estadoMes As String = ""
        Dim tcCompra As Decimal
        Dim tcVenta As Decimal

        estadoMes = EjercicioBL.GetEstadoMes(Session("Anio"), Session("Mes"))
        tcCompra = TipoCambioBl.GetTIPOCAMBIOByAnioMes(Session("Anio"), Session("Mes")).CompraCierre
        tcVenta = TipoCambioBl.GetTIPOCAMBIOByAnioMes(Session("Anio"), Session("Mes")).VentaCierre

        If estadoMes = "C" Then
            Dim cadena_java As String = _
                          "<script language='javascript'>function f(){radalert('<b>¡Mes Cerrado, Opción Deshabilitada!</b> ', 330, 100,'¡Alerta!'); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            Me.Image4.Visible = False
        Else
            If (tcCompra = 0 Or tcVenta = 0) Then
                Dim cadena_java As String = _
                         "<script language='javascript'>function f(){radalert('<b>¡Debe ingresar el valor del Tipo de Cambio de Cierre!</b> ', 330, 100,'¡Alerta!'); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                Me.Image4.Visible = False
            Else
                Dim radconfirmscript As String = "<script language='javascript'>function f(){radconfirm('¡Se Procesará el Ajuste por Diferencia de Cambio del Mes de Trabajo!', confirmCallBackFn, 330, 100, null, 'Mensaje de Confirmación'); Sys.Application.remove_load(f);}; Sys.Application.add_load(f); ;</script>"
                Page.ClientScript.RegisterStartupScript(Me.[GetType](), "radconfirm", radconfirmscript)

            End If
        End If
    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        Dim codigo As String = ""

        If e.Argument.StartsWith("Generar") Then
            Dim j() As String
            Dim valor As String
            j = Split(e.Argument, "|")

            valor = j(1)
            If valor = "true" Then
                'agregar codigo
                Try
                    TransaccionBl.GenerarAjusteDifCambio(Session("Fecha"), Session("Anio"), Session("Mes"), Session("IdUser"))
                Catch ex As Exception
                    MsgBox(ex)
                End Try

                Dim cadena_java As String = _
                               "<script language='javascript'>function f(){radalert('<b>Se ha Procesado el Ajuste por Diferencia de Cambio</b>', 330, 100,'Mensaje de Información',alertCallBackFn); Sys.Application.remove_load(f);}; Sys.Application.add_load(f);</script>"
                ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
            Else
                Me.Image4.Visible = False
            End If
        End If
    End Sub
End Class