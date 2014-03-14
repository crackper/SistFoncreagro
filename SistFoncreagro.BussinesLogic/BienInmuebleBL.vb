Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class BienInmuebleBL : Implements IBienInmuebleBL
    Dim factoryrepository As IBienInmuebleRepository

    Public Sub New()
        factoryrepository = New BienInmuebleRepository
    End Sub
    Public Function GetBIENINMUEBLEByIdBienInmueble(ByVal IdBienInmueble As Integer) As BussinessEntities.BienInmueble Implements IBienInmuebleBL.GetBIENINMUEBLEByIdBienInmueble
        Return factoryrepository.GetBIENINMUEBLEByIdBienInmueble(IdBienInmueble)
    End Function

    Public Function SaveBIENINMUEBLE(ByVal _BienInmueble As BussinessEntities.BienInmueble) As Integer Implements IBienInmuebleBL.SaveBIENINMUEBLE
        Return factoryrepository.SaveBIENINMUEBLE(_BienInmueble)
    End Function

   Public Sub UpdateEstadoBIENINMUEBLE(ByVal IdBienInmueble As Integer, ByVal Estado As String) Implements IBienInmuebleBL.UpdateEstadoBIENINMUEBLE
        factoryrepository.UpdateEstadoBIENINMUEBLE(IdBienInmueble, Estado)
    End Sub
End Class
