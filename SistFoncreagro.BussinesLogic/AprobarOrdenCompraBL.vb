Imports SistFoncreagro.DataAccess
Imports SistFoncreagro.BussinessEntities
Public Class AprobarOrdenCompraBL : Implements IAprobarOrdenCompraBL
    Dim aprobarOrden As IAprobarOrdenCompraRepository
    Sub New()
        aprobarOrden = New AprobarOrdenCompraBL
    End Sub
    Public Function DeleteNivelAprobarOrdenCompra(ByVal IdAprobarOc As Integer) As Boolean Implements IAprobarOrdenCompraBL.DeleteNivelAprobarOrdenCompra
        Return aprobarOrden.DeleteNivelAprobarOrdenCompra(IdAprobarOc)
    End Function

    Public Function GetAllFromNivelesAprobarOrdenCompra() As System.Collections.Generic.List(Of BussinessEntities.AprobarOrdenCompra) Implements IAprobarOrdenCompraBL.GetAllFromNivelesAprobarOrdenCompra
        Return aprobarOrden.GetAllFromNivelesAprobarOrdenCompra()
    End Function

    Public Function SaveNivelAprobarOrdenCompra(ByVal aprobarOc As BussinessEntities.AprobarOrdenCompra) As Integer Implements IAprobarOrdenCompraBL.SaveNivelAprobarOrdenCompra
        Return aprobarOrden.SaveNivelAprobarOrdenCompra(aprobarOc)
    End Function

    Public Function UpdateNivelAprobarOrdenCompra(ByVal aprobarOc As BussinessEntities.AprobarOrdenCompra) As Integer Implements IAprobarOrdenCompraBL.UpdateNivelAprobarOrdenCompra
        Return aprobarOrden.UpdateNivelAprobarOrdenCompra(aprobarOc)
    End Function
End Class
