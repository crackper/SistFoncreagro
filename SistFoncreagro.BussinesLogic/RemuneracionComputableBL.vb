Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class RemuneracionComputableBL : Implements IRemuneracionComputableBL

    Dim factoryrepository As IRemuneracionComputableRepository

    Public Sub New()
        factoryrepository = New RemuneracionComputableRepository
    End Sub
    Public Sub DeleteREMUNERACIONCOMPUTABLE(ByVal IdRemComputable As Integer) Implements IRemuneracionComputableBL.DeleteREMUNERACIONCOMPUTABLE
        factoryrepository.DeleteREMUNERACIONCOMPUTABLE(IdRemComputable)
    End Sub

    Public Function GetRemuneracionComputableIdDetalleConcepto(ByVal IdDetalleConcepto As Integer) As System.Collections.Generic.List(Of BussinessEntities.REMUNERACIONCOMPUTABLE) Implements IRemuneracionComputableBL.GetRemuneracionComputableIdDetalleConcepto
        Return factoryrepository.GetRemuneracionComputableIdDetalleConcepto(IdDetalleConcepto)
    End Function

    Public Function SaveREMUNERACIONCOMPUTABLE(ByVal remuneracionComputable As BussinessEntities.REMUNERACIONCOMPUTABLE) As Integer Implements IRemuneracionComputableBL.SaveREMUNERACIONCOMPUTABLE
        Return factoryrepository.SaveREMUNERACIONCOMPUTABLE(remuneracionComputable)
    End Function


End Class
