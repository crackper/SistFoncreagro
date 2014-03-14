Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class BienMuebleBL : Implements IBienMuebleBL
    Dim factoryrepository As IBienMuebleRepository

    Public Sub New()
        factoryrepository = New BienMuebleRepository
    End Sub

    Public Function GetAllFromBIENMUEBLE() As System.Collections.Generic.List(Of BussinessEntities.BIENMUEBLE) Implements IBienMuebleBL.GetAllFromBIENMUEBLE
        Return factoryrepository.GetAllFromBIENMUEBLE
    End Function

    Public Function GetBIENMUEBLEByIdBienMueble(ByVal IdBienMueble As Integer) As BussinessEntities.BIENMUEBLE Implements IBienMuebleBL.GetBIENMUEBLEByIdBienMueble
        Return factoryrepository.GetBIENMUEBLEByIdBienMueble(IdBienMueble)
    End Function

    Public Function SaveBIENMUEBLE(ByVal _BienMueble As BussinessEntities.BIENMUEBLE) As Integer Implements IBienMuebleBL.SaveBIENMUEBLE
        Return factoryrepository.SaveBIENMUEBLE(_BienMueble)
    End Function

    Public Function GetBIENMUEBLEByParameter(ByVal texto As String) As System.Collections.Generic.List(Of BussinessEntities.BIENMUEBLE) Implements IBienMuebleBL.GetBIENMUEBLEByParameter
        Return factoryrepository.GetBIENMUEBLEByParameter(texto)
    End Function

    Public Sub UpdateEstadoBIENMUEBLE(ByVal IdBienMueble As Integer, ByVal Estado As String) Implements IBienMuebleBL.UpdateEstadoBIENMUEBLE
        factoryrepository.UpdateEstadoBIENMUEBLE(IdBienMueble, Estado)
    End Sub
End Class
