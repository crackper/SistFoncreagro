Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class SemovientesBL : Implements ISemovientesBL
    Dim factoryrepository As ISemovientesRepository

    Public Sub New()
        factoryrepository = New SemovientesRepository
    End Sub

    Public Sub DeleteSEMOVIENTES(ByVal IdSemoviente As Integer) Implements ISemovientesBL.DeleteSEMOVIENTES
        factoryrepository.DeleteSEMOVIENTES(IdSemoviente)
    End Sub

    Public Function GetAllFromSEMOVIENTES() As System.Collections.Generic.List(Of BussinessEntities.Semovientes) Implements ISemovientesBL.GetAllFromSEMOVIENTES
        Return factoryrepository.GetAllFromSEMOVIENTES
    End Function

    Public Function GetSEMOVIENTESById(ByVal IdSemoviente As Integer) As BussinessEntities.Semovientes Implements ISemovientesBL.GetSEMOVIENTESById
        Return factoryrepository.GetSEMOVIENTESById(IdSemoviente)
    End Function
    Public Function SaveSEMOVIENTES(ByVal _Semovientes As BussinessEntities.Semovientes) As Integer Implements ISemovientesBL.SaveSEMOVIENTES
        Return factoryrepository.SaveSEMOVIENTES(_Semovientes)
    End Function
End Class
