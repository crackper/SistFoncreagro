Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AsistenteBL : Implements IAsistenteBL
    Dim factoryrepository As IAsistenteRepository

    Public Sub New()
        factoryrepository = New AsistenteRepository
    End Sub

    Public Sub DeleteASISTENTE(ByVal IdAsistente As Integer) Implements IAsistenteBL.DeleteASISTENTE
        factoryrepository.DeleteASISTENTE(IdAsistente)
    End Sub

    Public Function GetASISTENTEByIdAsistente(ByVal IdAsistente As Integer) As BussinessEntities.Asistente Implements IAsistenteBL.GetASISTENTEByIdAsistente
        Return factoryrepository.GetASISTENTEByIdAsistente(IdAsistente)
    End Function

    Public Function GetASISTENTEByIdControl(ByVal IdControl As Integer) As System.Collections.Generic.List(Of BussinessEntities.Asistente) Implements IAsistenteBL.GetASISTENTEByIdControl
        Return factoryrepository.GetASISTENTEByIdControl(IdControl)
    End Function

    Public Sub SaveASISTENTE(ByVal _Asistente As BussinessEntities.Asistente) Implements IAsistenteBL.SaveASISTENTE
        factoryrepository.SaveASISTENTE(_Asistente)
    End Sub
End Class
