Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class ActividadBL : Implements IActividadBL

    Dim factoryrepository As IActividadRepository

    Public Sub New()
        factoryrepository = New ActividadRepository
    End Sub

    Public Function GetAllFromActividad() As System.Collections.Generic.List(Of BussinessEntities.Actividad) Implements IActividadBL.GetAllFromActividad
        Return factoryrepository.GetAllFromActividad
    End Function

    Public Function GetFromActividadById(ByVal _id As Integer) As BussinessEntities.Actividad Implements IActividadBL.GetFromActividadById
        Return factoryrepository.GetFromActividadById(_id)
    End Function

    Public Function DeleteActividad(ByVal _id As Integer) As String Implements IActividadBL.DeleteActividad
        Return factoryrepository.DeleteActividad(_id)
    End Function

    Public Function SaveActividad(ByVal _Actividad As BussinessEntities.Actividad) As Integer Implements IActividadBL.SaveActividad
        Return factoryrepository.SaveActividad(_Actividad)
    End Function

    Public Function GetActividadByIdCompAndIdProyAndIdConv(ByVal _IdComp As Integer, ByVal _IdProy As Integer, ByVal _IdConv As Integer) As System.Collections.Generic.List(Of BussinessEntities.Actividad) Implements IActividadBL.GetActividadByIdCompAndIdProyAndIdConv
        Return factoryrepository.GetActividadByIdCompAndIdProyAndIdConv(_IdComp, _IdProy, _IdConv)
    End Function
End Class
