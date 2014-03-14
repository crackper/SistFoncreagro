Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class MonedaBL : Implements IMonedaBL
    Dim factoryrepository As IMonedaRepository

    Public Sub New()
        factoryrepository = New MonedaRepository
    End Sub

    Public Function GetAllFromMoneda() As System.Collections.Generic.List(Of BussinessEntities.Moneda) Implements IMonedaBL.GetAllFromMoneda
        Return factoryrepository.GetAllFromMoneda()
    End Function
    Public Sub SaveMoneda(ByVal _Moneda As BussinessEntities.Moneda) Implements IMonedaBL.SaveMoneda
        factoryrepository.SaveMoneda(_Moneda)
    End Sub

    Public Sub DeleteMoneda(ByVal IdMoneda As Integer) Implements IMonedaBL.DeleteMoneda
        factoryrepository.DeleteMoneda(IdMoneda)
    End Sub

    Public Function GetMonedaByIdMoneda(ByVal IdMoneda As Integer) As BussinessEntities.Moneda Implements IMonedaBL.GetMonedaByIdMoneda
        Return factoryrepository.GetMonedaByIdMoneda(IdMoneda)
    End Function
End Class
