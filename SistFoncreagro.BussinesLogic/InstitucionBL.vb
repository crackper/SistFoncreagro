Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class InstitucionBL : Implements IInstitucionBL


    Dim factoryrepository As IInstitucionRepository

    Public Sub New()
        factoryrepository = New InstitucionRepository
    End Sub

    Public Sub DeleteInstitucion(ByVal _id As Integer) Implements IInstitucionBL.DeleteInstitucion
        factoryrepository.DeleteInstitucion(_id)
    End Sub

    Public Function SaveInstitucion(ByVal _Institucion As BussinessEntities.Institucion) As Integer Implements IInstitucionBL.SaveInstitucion
        Return factoryrepository.SaveInstitucion(_Institucion)
    End Function

    Public Function GetInstitucionByIdConvenio(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.Institucion) Implements IInstitucionBL.GetInstitucionByIdConvenio
        Return factoryrepository.GetInstitucionByIdconvenio(_id)
    End Function
End Class
