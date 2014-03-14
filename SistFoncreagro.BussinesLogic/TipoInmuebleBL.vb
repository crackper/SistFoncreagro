Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoInmuebleBL : Implements ITipoInmuebleBL
    Dim factoryrepository As ITipoInmuebleRepository

    Public Sub New()
        factoryrepository = New TipoInmuebleRepository
    End Sub
    Public Sub DeleteTIPOINMUEBLE(ByVal IdTipo As Integer) Implements ITipoInmuebleBL.DeleteTIPOINMUEBLE
        factoryrepository.DeleteTIPOINMUEBLE(IdTipo)
    End Sub

    Public Function GetAllFromTIPOINMUEBLE() As System.Collections.Generic.List(Of BussinessEntities.TipoInmueble) Implements ITipoInmuebleBL.GetAllFromTIPOINMUEBLE
        Return factoryrepository.GetAllFromTIPOINMUEBLE()
    End Function

    Public Function GetTIPOINMUEBLEByIdTipo(ByVal IdTipo As Integer) As BussinessEntities.TipoInmueble Implements ITipoInmuebleBL.GetTIPOINMUEBLEByIdTipo
        Return factoryrepository.GetTIPOINMUEBLEByIdTipo(IdTipo)
    End Function

    Public Sub SaveTIPOINMUEBLE(ByVal _TipoInmueble As BussinessEntities.TipoInmueble) Implements ITipoInmuebleBL.SaveTIPOINMUEBLE
        factoryrepository.SaveTIPOINMUEBLE(_TipoInmueble)
    End Sub
End Class
