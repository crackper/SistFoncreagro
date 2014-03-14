Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class SustentoBL : Implements ISustentoBL
    Dim factoryrepository As ISustentoRepository
    Public Sub New()
        factoryrepository = New SustentoRepository
    End Sub

    Public Sub DeleteSUSTENTO(ByVal IdSustento As Integer) Implements ISustentoBL.DeleteSUSTENTO
        factoryrepository.DeleteSUSTENTO(IdSustento)
    End Sub

    Public Function GetSUSTENTOByIdControl(ByVal IdControl As Integer) As System.Collections.Generic.List(Of BussinessEntities.Sustento) Implements ISustentoBL.GetSUSTENTOByIdControl
        Return factoryrepository.GetSUSTENTOByIdControl(IdControl)
    End Function

    Public Function GetSUSTENTOByIdSustento(ByVal IdSUstento As Integer) As BussinessEntities.Sustento Implements ISustentoBL.GetSUSTENTOByIdSustento
        Return factoryrepository.GetSUSTENTOByIdSustento(IdSUstento)
    End Function

    Public Sub SaveSUSTENTO(ByVal _Sustento As BussinessEntities.Sustento) Implements ISustentoBL.SaveSUSTENTO
        factoryrepository.SaveSUSTENTO(_Sustento)
    End Sub

    Public Function GetSUSTENTOByIdDetalleEje(ByVal IdDetalleEje As Integer) As System.Collections.Generic.List(Of BussinessEntities.Sustento) Implements ISustentoBL.GetSUSTENTOByIdDetalleEje
        Return factoryrepository.GetSUSTENTOByIdDetalleEje(IdDetalleEje)
    End Function
End Class
