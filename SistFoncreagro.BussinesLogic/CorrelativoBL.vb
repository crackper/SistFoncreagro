Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class CorrelativoBL : Implements ICorrelativoBL
    Dim factoryrepository As ICorrelativoFactory

    Public Sub New()
        factoryrepository = New CorrelativoFactory
    End Sub

    Public Function GetCorrelativoByDocumentoByAnio(ByVal Documento As String, ByVal Anio As String) As BussinessEntities.Correlativo Implements ICorrelativoBL.GetCorrelativoByDocumentoByAnio
        Return factoryrepository.GetCorrelativoByDocumentoByAnio(Documento, Anio)
    End Function

    Public Function SaveCorrelativo(ByVal Correlativo As BussinessEntities.Correlativo) As Integer Implements ICorrelativoBL.SaveCorrelativo
        Return factoryrepository.SaveCorrelativo(Correlativo)
    End Function

    Public Sub UpdateCorrelativoNroCorrelativo(ByVal IdCorrelativo As Integer, ByVal NroCorrelativo As Integer) Implements ICorrelativoBL.UpdateCorrelativoNroCorrelativo
        factoryrepository.UpdateCorrelativoNroCorrelativo(IdCorrelativo, NroCorrelativo)
    End Sub
End Class
