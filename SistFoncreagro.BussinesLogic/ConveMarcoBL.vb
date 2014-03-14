Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class ConveMarcoBL : Implements IConveMarcoBL

    Dim factoryrepository As IConveMarcoRepository

    Public Sub New()
        factoryrepository = New ConveMarcoRepository
    End Sub

    Public Sub DeleteConveMarco(ByVal _id As Integer) Implements IConveMarcoBL.DeleteConveMarco
        factoryrepository.DeleteConveMarco(_id)
    End Sub

    Public Function GetAllFromConveMarco() As System.Collections.Generic.List(Of BussinessEntities.ConveMarco) Implements IConveMarcoBL.GetAllFromConveMarco
        Return factoryrepository.GetAllFromConveMarco
    End Function

    Public Function GetFromConveMarcoByIdConveMarco(ByVal _id As Integer) As BussinessEntities.ConveMarco Implements IConveMarcoBL.GetFromConveMarcoByIdConveMarco
        Return factoryrepository.GetFromConveMarcoByIdConveMarco(_id)
    End Function

    Public Function SaveConveMarco(ByVal _ConveMarco As BussinessEntities.ConveMarco) As Integer Implements IConveMarcoBL.SaveConveMarco
        Return factoryrepository.SaveConveMarco(_ConveMarco)
    End Function

    Public Function GetFromConveMarcoByParameter(ByVal _Texto As String) As System.Collections.Generic.List(Of BussinessEntities.ConveMarco) Implements IConveMarcoBL.GetFromConveMarcoByParameter
        Return factoryrepository.GetFromConveMarcoByParameter(_Texto)
    End Function
End Class
