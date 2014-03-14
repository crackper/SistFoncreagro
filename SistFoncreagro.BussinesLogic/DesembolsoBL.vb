Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class DesembolsoBL : Implements IDesembolsoBL

    Dim factoryrepository As IDesembolsoRepository

    Public Sub New()
        factoryrepository = New DesembolsoRepository
    End Sub

    Public Function GetAllFromDesembolsos() As System.Collections.Generic.List(Of BussinessEntities.Desembolso) Implements IDesembolsoBL.GetAllFromDesembolsos
        Return factoryrepository.GetAllFromDesembolsos
    End Function

    Public Function SaveDesembolso(ByVal _Desembolso As BussinessEntities.Desembolso) As Integer Implements IDesembolsoBL.SaveDesembolso
        Return factoryrepository.SaveDesembolso(_Desembolso)
    End Function

    Public Sub DeleteDesembolso(ByVal _id As Integer) Implements IDesembolsoBL.DeleteDesembolso
        factoryrepository.DeleteDesembolso(_id)
    End Sub

    Public Function GetFromDesembolsoByIdConvenio(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.Desembolso) Implements IDesembolsoBL.GetFromDesembolsoByIdConvenio
        Return factoryrepository.GetFromDesembolsoByIdConvenio(_id)
    End Function

    Public Function GetFromDesembolsoByIdDesembolso(ByVal id As Integer) As BussinessEntities.Desembolso Implements IDesembolsoBL.GetFromDesembolsoByIdDesembolso
        Return factoryrepository.GetFromDesembolsoByIdDesembolso(id)
    End Function
End Class
