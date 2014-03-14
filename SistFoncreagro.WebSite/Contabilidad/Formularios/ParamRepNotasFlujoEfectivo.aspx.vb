﻿Public Class ParamRepNotasFlujoEfectivo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Page.IsPostBack = False Then
            Me.RadDatePicker1.SelectedDate = Date.Parse(Session("Fecha"))
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim cadena_java As String

        cadena_java = "<script type='text/javascript'> " & _
                                      " window.open('ReporteNotasFlujoEfectivo.aspx?FechaFin=" + Me.RadDatePicker1.SelectedDate.ToString + "' ); " & _
                                      Chr(60) & "/script>"
        ScriptManager.RegisterStartupScript(Page, GetType(Page), "Cerrar", cadena_java.ToString, False)
    End Sub
End Class