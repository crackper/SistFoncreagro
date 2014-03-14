Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class EstadoBienMuebleBL : Implements IEstadoBienMuebleBL
    Dim factoryrepository As IEstadoBienMuebleRepository

    Public Sub New()
        factoryrepository = New EstadoBienMuebleRepository
    End Sub

    Public Sub DeleteESTADOBIENMUEBLE(ByVal IdEstado As Integer) Implements IEstadoBienMuebleBL.DeleteESTADOBIENMUEBLE
        factoryrepository.DeleteESTADOBIENMUEBLE(IdEstado)
    End Sub

    Public Function GetESTADOBIENMUEBLEByIdBienMueble(ByVal IdBienMueble As Integer) As System.Collections.Generic.List(Of BussinessEntities.EstadoBienMueble) Implements IEstadoBienMuebleBL.GetESTADOBIENMUEBLEByIdBienMueble
        Return factoryrepository.GetESTADOBIENMUEBLEByIdBienMueble(IdBienMueble)
    End Function

    Public Function GetESTADOBIENMUEBLEByIdEstado(ByVal IdEstado As Integer) As BussinessEntities.EstadoBienMueble Implements IEstadoBienMuebleBL.GetESTADOBIENMUEBLEByIdEstado
        Return factoryrepository.GetESTADOBIENMUEBLEByIdEstado(IdEstado)
    End Function

    Public Sub SaveESTADOBIENMUEBLE(ByVal _EstadoBienMueble As BussinessEntities.EstadoBienMueble) Implements IEstadoBienMuebleBL.SaveESTADOBIENMUEBLE
        factoryrepository.SaveESTADOBIENMUEBLE(_EstadoBienMueble)
    End Sub
End Class
