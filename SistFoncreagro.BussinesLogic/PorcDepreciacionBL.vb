Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class PorcDepreciacionBL : Implements IPorcDepreciacionBL
    Dim factoryrepository As IPorcDepreciacionRepository

    Public Sub New()
        factoryrepository = New PorcDepreciacionRepository
    End Sub

    Public Sub DeletePORCDEPRECIACION(ByVal IdPorcDepreciacion As Integer) Implements IPorcDepreciacionBL.DeletePORCDEPRECIACION
        factoryrepository.DeletePORCDEPRECIACION(IdPorcDepreciacion)
    End Sub

    Public Function GetPORCDEPRECIACIONByIdPorcDepreciacion(ByVal IdPorcDepreciacion As Integer) As BussinessEntities.PorcDepreciacion Implements IPorcDepreciacionBL.GetPORCDEPRECIACIONByIdPorcDepreciacion
        Return factoryrepository.GetPORCDEPRECIACIONByIdPorcDepreciacion(IdPorcDepreciacion)
    End Function

    Public Sub SavePORCDEPRECIACION(ByVal _PorcDepreciacion As BussinessEntities.PorcDepreciacion) Implements IPorcDepreciacionBL.SavePORCDEPRECIACION
        factoryrepository.SavePORCDEPRECIACION(_PorcDepreciacion)
    End Sub

    Public Function GetAllFromPorcDepreciacion() As System.Collections.Generic.List(Of BussinessEntities.PorcDepreciacion) Implements IPorcDepreciacionBL.GetAllFromPorcDepreciacion
        Return factoryrepository.GetAllFromPorcDepreciacion()
    End Function
End Class
