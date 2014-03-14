Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class Dialog4
    Inherits System.Web.UI.Page

    Dim IdDetalleEje As String
    Dim Control As New Control
    Dim ControlBL As New ControlBL
    Dim Fecha As Date
    Dim DetalleEje As New DetalleEjecucion
    Dim DetalleEjeBL As New DetalleEjecucionBL
    Dim Estado As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdDetalleEje = Request.QueryString("IdDetalleEje")
    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(sender As Object, e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest

        If e.Argument.StartsWith("Validar") Then
            DetalleEje = DetalleEjeBL.GetDETALLEEJECUCIONByIdDetalleEje(IdDetalleEje)
            Estado = DetalleEje.Estado

            If Estado = "EJECUTADO" Then
                Fecha = DetalleEje.Fecha
                If Fecha > Date.Parse(Me.cityName.Text) Then
                    Dim cadena_java As String = _
                                              "<script type='text/javascript'> " & _
                                              " alert('¡La fecha de reprogramacion debe ser posterior a la fecha que estaba programada la actividad!'); " & _
                                              Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                Else
                    Dim cadena_java As String = _
                                            "<script type='text/javascript'> " & _
                                            " returnToParent1(); " & _
                                            Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                End If
            ElseIf Estado = "PROGRAMADO" Then
                If Now.Date > Date.Parse(Me.cityName.Text) Then
                    Dim cadena_java As String = _
                                              "<script type='text/javascript'> " & _
                                              " alert('¡La fecha de reprogramacion debe ser posterior a la fecha actual!'); " & _
                                              Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                Else
                    Dim cadena_java As String = _
                                            "<script type='text/javascript'> " & _
                                            " returnToParent1(); " & _
                                            Chr(60) & "/script>"
                    ScriptManager.RegisterStartupScript(Page, GetType(Page), "AlertaX", cadena_java.ToString, False)
                End If
            End If

        End If
    End Sub

End Class