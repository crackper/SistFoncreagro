Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class RecibosRendicionBL : Implements IRecibosRendicionBL
    Dim factoryrepository As IRecibosRendicionRepository

    Public Sub New()
        factoryrepository = New RecibosRendicionRepository
    End Sub

    Public Sub DeleteRECIBOSRENDICION(ByVal IdReciboRendicion As Integer) Implements IRecibosRendicionBL.DeleteRECIBOSRENDICION
        factoryrepository.DeleteRECIBOSRENDICION(IdReciboRendicion)
    End Sub

    Public Function GetAllFromRECIBOSRENDICION() As System.Collections.Generic.List(Of BussinessEntities.RecibosRendicion) Implements IRecibosRendicionBL.GetAllFromRECIBOSRENDICION
        Return factoryrepository.GetAllFromRECIBOSRENDICION()
    End Function

    Public Function GetRECIBOSRENDICIONByIdReciboRendicion(ByVal IdReciboRendicion As Integer) As BussinessEntities.RecibosRendicion Implements IRecibosRendicionBL.GetRECIBOSRENDICIONByIdReciboRendicion
        Return factoryrepository.GetRECIBOSRENDICIONByIdReciboRendicion(IdReciboRendicion)
    End Function

    Public Function GetRECIBOSRENDICIONByIdRendicion(ByVal IdRendicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.RecibosRendicion) Implements IRecibosRendicionBL.GetRECIBOSRENDICIONByIdRendicion
        Return factoryrepository.GetRECIBOSRENDICIONByIdRendicion(IdRendicion)
    End Function

    Public Sub SaveRECIBOSRENDICION(ByVal _Recibosrendicion As BussinessEntities.RecibosRendicion) Implements IRecibosRendicionBL.SaveRECIBOSRENDICION
        factoryrepository.SaveRECIBOSRENDICION(_Recibosrendicion)
    End Sub

End Class
