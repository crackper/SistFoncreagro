Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class DatosActualBL : Implements IDatosActualBL

    Dim factoryrepository As IDatosActualRepository

    Public Sub New()
        factoryrepository = New DatosActualRepository
    End Sub

    Public Function GetAnioActual() As Integer Implements IDatosActualBL.GetAnioActual
        Return factoryrepository.GetAnioActual
    End Function

    Public Function GetMesActual(ByVal _Mes As Integer) As String Implements IDatosActualBL.GetMesActual
        Return factoryrepository.GetMesActual(_Mes)
    End Function
End Class
