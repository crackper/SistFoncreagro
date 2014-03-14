Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class ComponenteBL : Implements IComponenteBL

    Dim factoryrepository As IComponenteRepository

    Public Sub New()
        factoryrepository = New ComponenteRepository
    End Sub

    Public Function GetAllFromComponente() As System.Collections.Generic.List(Of BussinessEntities.Componente) Implements IComponenteBL.GetAllFromComponente
        Return factoryrepository.GetAllFromComponente
    End Function

    Public Function GetFromComponenteById(ByVal _id As Integer) As BussinessEntities.Componente Implements IComponenteBL.GetFromComponenteById
        Return factoryrepository.GetFromComponenteById(_id)
    End Function

    Public Function SaveComponente(ByVal _Componente As BussinessEntities.Componente) As Integer Implements IComponenteBL.SaveComponente
        Return factoryrepository.SaveComponente(_Componente)
    End Function

    Public Function DeleteComponente(ByVal _id As Integer) As String Implements IComponenteBL.DeleteComponente
        Return factoryrepository.DeleteComponente(_id)
    End Function

    Public Function GetFromComponenteByIdProyAndIdConv(ByVal _IdProy As Integer, ByVal _IdConv As Integer) As System.Collections.Generic.List(Of BussinessEntities.Componente) Implements IComponenteBL.GetFromComponenteByIdProyAndIdConv
        Return factoryrepository.GetFromComponenteByIdProyAndIdConv(_IdProy, _IdConv)
    End Function

    Public Function GetFromComponenteByIdConveProy(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.Componente) Implements IComponenteBL.GetFromComponenteByIdConveProy
        Return factoryrepository.GetFromComponenteByIdConveProy(_id)
    End Function
End Class
