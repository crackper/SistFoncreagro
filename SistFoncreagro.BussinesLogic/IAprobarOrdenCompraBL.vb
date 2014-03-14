Imports SistFoncreagro.BussinessEntities
Public Interface IAprobarOrdenCompraBL
    Function SaveNivelAprobarOrdenCompra(ByVal aprobarOc As AprobarOrdenCompra) As Int32
    Function UpdateNivelAprobarOrdenCompra(ByVal aprobarOc As AprobarOrdenCompra) As Int32
    Function DeleteNivelAprobarOrdenCompra(ByVal IdAprobarOc As Int32) As Boolean
    Function GetAllFromNivelesAprobarOrdenCompra() As List(Of AprobarOrdenCompra)
End Interface
