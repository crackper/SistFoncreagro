Public Class FrmListaRequerimientos
    Inherits System.Web.UI.Page

    Public Function ObtenerColor(ByVal estado As String) As Drawing.Color
        Dim vista = New Disenio
        Return vista.ObtenerColorRequerimiento(estado)
    End Function

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class