Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DocumentoRendidoBL : Implements IDocumentoRendidoBL
    Dim factoryrepository As IDocumentoRendidoRepository

    Public Sub New()
        factoryrepository = New DocumentoRendidoRepository
    End Sub

    Public Sub DeleteDOCUMENTORENDIDO(ByVal IdDocRendido As Integer) Implements IDocumentoRendidoBL.DeleteDOCUMENTORENDIDO
        factoryrepository.DeleteDOCUMENTORENDIDO(IdDocRendido)
    End Sub

    Public Function GetAllFromDOCUMENTORENDIDO() As System.Collections.Generic.List(Of BussinessEntities.DocumentoRendido) Implements IDocumentoRendidoBL.GetAllFromDOCUMENTORENDIDO
        Return factoryrepository.GetAllFromDOCUMENTORENDIDO
    End Function

    Public Function GetDOCUMENTORENDIDOByIdDocRendido(ByVal IdDocRendido As Object) As BussinessEntities.DocumentoRendido Implements IDocumentoRendidoBL.GetDOCUMENTORENDIDOByIdDocRendido
        Return factoryrepository.GetDOCUMENTORENDIDOByIdDocRendido(IdDocRendido)
    End Function

    Public Function GetDOCUMENTORENDIDOByIdReciboRendicion(ByVal IdReciboRendicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.DocumentoRendido) Implements IDocumentoRendidoBL.GetDOCUMENTORENDIDOByIdReciboRendicion
        Return factoryrepository.GetDOCUMENTORENDIDOByIdReciboRendicion(IdReciboRendicion)
    End Function

    Public Sub SaveDOCUMENTORENDIDO(ByVal _DocumentoRendido As BussinessEntities.DocumentoRendido) Implements IDocumentoRendidoBL.SaveDOCUMENTORENDIDO
        factoryrepository.SaveDOCUMENTORENDIDO(_DocumentoRendido)
    End Sub

    Public Function GetDOCUMENTORENDIDOByIdRendicion(ByVal IdRendicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.DocumentoRendido) Implements IDocumentoRendidoBL.GetDOCUMENTORENDIDOByIdRendicion
        Return factoryrepository.GetDOCUMENTORENDIDOByIdRendicion(IdRendicion)
    End Function
End Class
