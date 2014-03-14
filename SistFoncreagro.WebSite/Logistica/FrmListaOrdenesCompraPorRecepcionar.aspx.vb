Public Class FrmListaOrdenesCompraPorRecepcionar
    Inherits System.Web.UI.Page
    Public Function ObtenerColor(ByVal estado As String) As Drawing.Color
        Dim vista = New Disenio
        Return vista.ObtenerColorOrdenCompra(estado)
    End Function
End Class