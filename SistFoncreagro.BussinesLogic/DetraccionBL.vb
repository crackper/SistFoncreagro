Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class DetraccionBL : Implements IDetraccionBL
    Dim factoryrepository As IDetraccionRepository

    Public Sub New()
        factoryrepository = New DetraccionRepository
    End Sub

    Public Function GetAllFromDetraccion() As System.Collections.Generic.List(Of BussinessEntities.Detraccion) Implements IDetraccionBL.GetAllFromDetraccion
        Return factoryrepository.GetAllFromDetraccion
    End Function

    Public Sub SaveDetraccion(ByVal _Detraccion As BussinessEntities.Detraccion) Implements IDetraccionBL.SaveDetraccion
        factoryrepository.SaveDetraccion(_Detraccion)
    End Sub

    Public Function GetDETRACCIONByIdDetraccion(ByVal IdDetraccion As Integer) As BussinessEntities.Detraccion Implements IDetraccionBL.GetDETRACCIONByIdDetraccion
        Return factoryrepository.GetDETRACCIONByIdDetraccion(IdDetraccion)
    End Function

    Public Sub UpdateEstadoDETRACCION(ByVal idDetraccion As Integer) Implements IDetraccionBL.UpdateEstadoDETRACCION
        factoryrepository.UpdateEstadoDETRACCION(idDetraccion)
    End Sub
End Class
