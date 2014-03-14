Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DocumentoRendidoRepository : Inherits MasterDataAccess : Implements IDocumentoRendidoRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DocumentoRendido)
        Dim lista As New List(Of DocumentoRendido)
        Dim ProveedorClienteRepository As New ProveedorClienteRepository
        Dim CCostoRepository As New CCostoRepository
        Dim DocumentoContabilizadoRepository As New DocumentoContabilizadoRepository
        Dim TipoGastoRepository As New TipoGastoRepository

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _DocumentoRendido As New DocumentoRendido() With
                {
                .FechaDocumento = reader.GetValue(0),
                .Glosa = reader.GetValue(1),
                .IdCCosto = reader.GetValue(2),
                .IdDocRendido = reader.GetValue(3),
                .IdDocumentoCont = reader.GetValue(4),
                .IdProveedorCliente = reader.GetValue(5),
                .IdReciboRendicion = reader.GetValue(6),
                .Monto = reader.GetValue(7),
                .NroDocumento = reader.GetValue(8),
                .Serie = reader.GetValue(9),
                .TipoCambio = reader.GetValue(10),
                .IdTipoGasto = reader.GetValue(11)
                }
                If Not (reader.IsDBNull(12)) Then
                    _DocumentoRendido.FechaPago = reader.GetValue(12)
                End If
                If Not (reader.IsDBNull(13)) Then
                    _DocumentoRendido.FechaVencimiento = reader.GetValue(13)
                End If
                _DocumentoRendido.ProveedorCliente = ProveedorClienteRepository.GetAllFromProveedorClienteById(reader.GetValue(5))
                _DocumentoRendido.CCosto = CCostoRepository.GetCCOSTOByIdCCosto(reader.GetValue(2))
                _DocumentoRendido.DocumentoContabilizado = DocumentoContabilizadoRepository.GetDOCUMENTOCONTABILIZADOByIdDocConta(reader.GetValue(4))
                _DocumentoRendido.TipoGasto = TipoGastoRepository.GetTIPOGASTOByIdTipoGasto(reader.GetValue(11))
                lista.Add(_DocumentoRendido)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteDOCUMENTORENDIDO(ByVal IdDocRendido As Integer) Implements IDocumentoRendidoRepository.DeleteDOCUMENTORENDIDO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDOCUMENTORENDIDO")
        command.Parameters.AddWithValue("IdDocRendido", IdDocRendido)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromDOCUMENTORENDIDO() As System.Collections.Generic.List(Of BussinessEntities.DocumentoRendido) Implements IDocumentoRendidoRepository.GetAllFromDOCUMENTORENDIDO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromDOCUMENTORENDIDO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetDOCUMENTORENDIDOByIdDocRendido(ByVal IdDocRendido As Object) As BussinessEntities.DocumentoRendido Implements IDocumentoRendidoRepository.GetDOCUMENTORENDIDOByIdDocRendido
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDOCUMENTORENDIDOByIdDocRendido")
        command.Parameters.AddWithValue("IdDocRendido", IdDocRendido)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetDOCUMENTORENDIDOByIdReciboRendicion(ByVal IdReciboRendicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.DocumentoRendido) Implements IDocumentoRendidoRepository.GetDOCUMENTORENDIDOByIdReciboRendicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDOCUMENTORENDIDOByIdReciboRendicion")
        command.Parameters.AddWithValue("IdReciboRendicion", IdReciboRendicion)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveDOCUMENTORENDIDO(ByVal _DocumentoRendido As BussinessEntities.DocumentoRendido) Implements IDocumentoRendidoRepository.SaveDOCUMENTORENDIDO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDOCUMENTORENDIDO")
        command.Parameters.AddWithValue("FechaDocumento", _DocumentoRendido.FechaDocumento)
        command.Parameters.AddWithValue("Glosa", _DocumentoRendido.Glosa)
        command.Parameters.AddWithValue("IdCCosto", _DocumentoRendido.IdCCosto)
        command.Parameters.AddWithValue("IdDocRendido", _DocumentoRendido.IdDocRendido)
        command.Parameters.AddWithValue("IdDocumentoCont", _DocumentoRendido.IdDocumentoCont)
        command.Parameters.AddWithValue("IdProveedorCliente", _DocumentoRendido.IdProveedorCliente)
        command.Parameters.AddWithValue("IdReciboRendicion", _DocumentoRendido.IdReciboRendicion)
        command.Parameters.AddWithValue("Monto", _DocumentoRendido.Monto)
        command.Parameters.AddWithValue("NroDocumento", _DocumentoRendido.NroDocumento)
        command.Parameters.AddWithValue("Serie", _DocumentoRendido.Serie)
        command.Parameters.AddWithValue("TipoCambio", _DocumentoRendido.TipoCambio)
        command.Parameters.AddWithValue("IdTipoGasto", _DocumentoRendido.IdTipoGasto)
        command.Parameters.AddWithValue("FechaPago", _DocumentoRendido.FechaPago)
        command.Parameters.AddWithValue("FechaVencimiento", _DocumentoRendido.FechaVencimiento)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetDOCUMENTORENDIDOByIdRendicion(ByVal IdRendicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.DocumentoRendido) Implements IDocumentoRendidoRepository.GetDOCUMENTORENDIDOByIdRendicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDOCUMENTORENDIDOByIdRendicion")
        command.Parameters.AddWithValue("IdRendicion", IdRendicion)
        Return SelectObjectFactory(command)
    End Function
End Class
