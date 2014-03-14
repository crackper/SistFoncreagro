Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AplicacionTipoCambioBL : Implements IAplicacionTipoCambioBL
    Dim factoryrepository As IAplicacionTipoCambioRepository

    Public Sub New()
        factoryrepository = New AplicacionTipoCambioRepository
    End Sub
    Public Function GetAllFromAPLICACIONTIPOCAMBIO() As System.Collections.Generic.List(Of BussinessEntities.AplicacionTipoCambio) Implements IAplicacionTipoCambioBL.GetAllFromAPLICACIONTIPOCAMBIO
        Return factoryrepository.GetAllFromAPLICACIONTIPOCAMBIO
    End Function
End Class
