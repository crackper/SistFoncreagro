Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class LimiteRCBL : Implements ILimiteRCBL

    Dim factoryrepository As ILimiteRCRepository

    Public Sub New()
        factoryrepository = New LimitesRCRepository
    End Sub

    Public Sub DeleteLIMITESRC(ByVal IdLimitesRC As Integer) Implements ILimiteRCBL.DeleteLIMITESRC
        factoryrepository.DeleteLIMITESRC(IdLimitesRC)
    End Sub

    Public Function GetLimiteRCByIdDetalleConcepto(ByVal IdDetalleConcepto As Integer) As System.Collections.Generic.List(Of BussinessEntities.LimitesRC) Implements ILimiteRCBL.GetLimiteRCByIdDetalleConcepto
        Return factoryrepository.GetLimiteRCByIdDetalleConcepto(IdDetalleConcepto)
    End Function

    Public Function SaveLimeteRC(ByVal limiteRC As BussinessEntities.LimitesRC) As Integer Implements ILimiteRCBL.SaveLimeteRC
        Return factoryrepository.SaveLimeteRC(limiteRC)
    End Function
End Class
