Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ActitudInteresadoBL : Implements IActitudInteresadoBL
    Dim factoryrepository As IActitudInteresadoRepository

    Public Sub New()
        factoryrepository = New ActitudInteresadoRepository
    End Sub

    Public Sub DeleteACTITUDINTERESADO(ByVal IdActitud As Integer) Implements IActitudInteresadoBL.DeleteACTITUDINTERESADO
        factoryrepository.DeleteACTITUDINTERESADO(IdActitud)
    End Sub

    Public Function GetACTITUDINTERESADOByIdActitud(ByVal IdActitud As Integer) As BussinessEntities.ActitudInteresado Implements IActitudInteresadoBL.GetACTITUDINTERESADOByIdActitud
        Return factoryrepository.GetACTITUDINTERESADOByIdActitud(IdActitud)
    End Function

    Public Function GetACTITUDINTERESADOByIdInteresado(ByVal IdInteresado As Integer) As Object Implements IActitudInteresadoBL.GetACTITUDINTERESADOByIdInteresado
        Return factoryrepository.GetACTITUDINTERESADOByIdInteresado(IdInteresado)
    End Function

    Public Sub SaveACTITUDINTERESADO(ByVal _ActitudInteresado As BussinessEntities.ActitudInteresado) Implements IActitudInteresadoBL.SaveACTITUDINTERESADO
        factoryrepository.SaveACTITUDINTERESADO(_ActitudInteresado)
    End Sub

    Public Function GetACTITUDINTERESADOByFecha(ByVal IdInteresado As Integer, ByVal FechaInicio As Date) As BussinessEntities.ActitudInteresado Implements IActitudInteresadoBL.GetACTITUDINTERESADOByFecha
        Return factoryrepository.GetACTITUDINTERESADOByFecha(IdInteresado, FechaInicio)
    End Function
End Class
