Public Class FrmListaRequerimientosPorAprobar
    Inherits System.Web.UI.Page

    Public Function ObtenerColor(ByVal estado As String) As Drawing.Color
        Dim vista = New Disenio
        Return vista.ObtenerColorRequerimiento(estado)
    End Function

End Class