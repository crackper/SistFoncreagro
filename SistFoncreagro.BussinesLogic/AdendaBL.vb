Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class AdendaBL : Implements IAdendaBL

    Dim factoryrepository As IAdendaRepository

    Public Sub New()
        factoryrepository = New AdendaRepository
    End Sub

    Public Function GetAllFromAdenda() As System.Collections.Generic.List(Of BussinessEntities.Adenda) Implements IAdendaBL.GetAllFromAdenda
        Return factoryrepository.GetAllFromAdenda
    End Function

    Public Function SaveAdenda(ByVal _Adenda As BussinessEntities.Adenda) As Integer Implements IAdendaBL.SaveAdenda
        Return factoryrepository.SaveAdenda(_Adenda)
    End Function

    Public Function GetFromAdendaByIdConvenio(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.Adenda) Implements IAdendaBL.GetFromAdendaByIdConvenio
        Return factoryrepository.GetFromAdendaByIdConvenio(_id)
    End Function

    Public Function GetFromAdendaByIdAdenda(ByVal _id As Integer) As BussinessEntities.Adenda Implements IAdendaBL.GetFromAdendaByIdAdenda
        Return factoryrepository.GetFromAdendaByIdAdenda(_id)
    End Function

    Public Sub DeleteAdenda(ByVal _id As Integer) Implements IAdendaBL.DeleteAdenda
        factoryrepository.DeleteAdenda(_id)
    End Sub
End Class
