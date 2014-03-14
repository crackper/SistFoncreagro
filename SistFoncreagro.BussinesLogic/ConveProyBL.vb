Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class ConveProyBL : Implements IConveProyBL
    Dim factoryrepository As IConveProyRepository

    Public Sub New()
        factoryrepository = New ConveProyRepository
    End Sub

    Public Function GetAllFromConveProy() As System.Collections.Generic.List(Of BussinessEntities.ConveProy) Implements IConveProyBL.GetAllFromConveProy
        Return factoryrepository.GetAllFromConveProy
    End Function

    Public Function GetFromConveProyByIdConvenio(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.ConveProy) Implements IConveProyBL.GetFromConveProyByIdConvenio
        Return factoryrepository.GetFromConveProyByIdConvenio(_id)
    End Function

    Public Function GetFromConveProyByIdProyecto(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.ConveProy) Implements IConveProyBL.GetFromConveProyByIdProyecto
        Return factoryrepository.GetFromConveProyByIdProyecto(_id)
    End Function

    Public Function SaveConveProy(ByVal _ConveProy As BussinessEntities.ConveProy) As Integer Implements IConveProyBL.SaveConveProy
        Return factoryrepository.SaveConveProy(_ConveProy)
    End Function

    Public Function GetFromConveProyByIdProyAndIdconv(ByVal _idProy As Integer, ByVal _idConv As Integer) As BussinessEntities.ConveProy Implements IConveProyBL.GetFromConveProyByIdProyAndIdconv
        Return factoryrepository.GetFromConveProyByIdProyAndIdconv(_idProy, _idConv)
    End Function

    Public Function GetFromConveProyById(ByVal _id As Integer) As BussinessEntities.ConveProy Implements IConveProyBL.GetFromConveProyById
        Return factoryrepository.GetFromConveProyById(_id)
    End Function

    Public Function DeleteConveProy(ByVal _id As Integer) As String Implements IConveProyBL.DeleteConveProy
        Return factoryrepository.DeleteConveProy(_id)
    End Function
End Class
