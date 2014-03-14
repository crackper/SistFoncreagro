Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AdjuntoSemovientesBL : Implements IAdjuntoSemovientesBL
    Dim factoryrepository As IAdjuntoSemovientesRepository

    Public Sub New()
        factoryrepository = New AdjuntoSemovientesRepository
    End Sub

    Public Sub DeleteADJUNTOSEMOVIENTES(ByVal IdAdjuntoSemoviente As Integer) Implements IAdjuntoSemovientesBL.DeleteADJUNTOSEMOVIENTES
        factoryrepository.DeleteADJUNTOSEMOVIENTES(IdAdjuntoSemoviente)
    End Sub

    Public Function GetADJUNTOSEMOVIENTESByIdAdjuntoSemoviente(ByVal IdAdjuntoSemoviente As Integer) As BussinessEntities.AdjuntoSemovientes Implements IAdjuntoSemovientesBL.GetADJUNTOSEMOVIENTESByIdAdjuntoSemoviente
        Return factoryrepository.GetADJUNTOSEMOVIENTESByIdAdjuntoSemoviente(IdAdjuntoSemoviente)
    End Function

    Public Function GetADJUNTOSEMOVIENTESByIdSemoviente(ByVal IdSemoviente As Integer) As System.Collections.Generic.List(Of BussinessEntities.AdjuntoSemovientes) Implements IAdjuntoSemovientesBL.GetADJUNTOSEMOVIENTESByIdSemoviente
        Return factoryrepository.GetADJUNTOSEMOVIENTESByIdSemoviente(IdSemoviente)
    End Function

    Public Sub SaveADJUNTOSEMOVIENTES(ByVal _AdjuntoSemoviente As BussinessEntities.AdjuntoSemovientes) Implements IAdjuntoSemovientesBL.SaveADJUNTOSEMOVIENTES
        factoryrepository.SaveADJUNTOSEMOVIENTES(_AdjuntoSemoviente)
    End Sub
End Class
