Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DocumentoContabilizadoRepository : Inherits MasterDataAccess : Implements IDocumentoContabilizadoRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DocumentoContabilizado)
        Dim lista As New List(Of DocumentoContabilizado)
        Dim MonedaRepository As New MonedaRepository
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _DocumentoContabilizado As New DocumentoContabilizado() With
                {
                    .AfectoIvap = reader.GetValue(0),
                    .Codigo = reader.GetValue(1),
                    .Descripcion = reader.GetValue(7),
                    .Estado = reader.GetValue(8),
                    .IdDocumentoCont = reader.GetValue(9),
                    .IdMoneda = reader.GetValue(10),
                    .IdTipoDocumento = reader.GetValue(11)
                }

                If Not (reader.IsDBNull(2)) Then
                    _DocumentoContabilizado.CtaDebe = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(3)) Then
                    _DocumentoContabilizado.CtaDetraccion = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _DocumentoContabilizado.CtaHaber = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _DocumentoContabilizado.CtaIgv = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(6)) Then
                    _DocumentoContabilizado.CtaRetencion = reader.GetValue(6)
                End If
                If Not (reader.IsDBNull(12)) Then
                    _DocumentoContabilizado.CtaIngresosIvap = reader.GetValue(12)
                End If
                If Not (reader.IsDBNull(13)) Then
                    _DocumentoContabilizado.CtagastosIvap = reader.GetValue(13)
                End If
                _DocumentoContabilizado.Moneda = MonedaRepository.GetMonedaByIdMoneda(reader.GetValue(10))

                lista.Add(_DocumentoContabilizado)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteDOCUMENTOCONTABILIZADO(ByVal IdDocConta As Integer) Implements IDocumentoContabilizadoRepository.DeleteDOCUMENTOCONTABILIZADO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDOCUMENTOCONTABILIZADO")
        command.Parameters.AddWithValue("IdDocConta", IdDocConta)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromDOCUMENTOCONTABILIZADO() As System.Collections.Generic.List(Of BussinessEntities.DocumentoContabilizado) Implements IDocumentoContabilizadoRepository.GetAllFromDOCUMENTOCONTABILIZADO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromDOCUMENTOCONTABILIZADO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetDOCUMENTOCONTABILIZADOByIdDocConta(ByVal IdDocConta As Integer) As BussinessEntities.DocumentoContabilizado Implements IDocumentoContabilizadoRepository.GetDOCUMENTOCONTABILIZADOByIdDocConta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDOCUMENTOCONTABILIZADOByIdDocConta")
        command.Parameters.AddWithValue("IdDocConta", IdDocConta)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub UpdateEstadoDOCUMENTOCONTABILIZADO(ByVal IdDocumentoCont As Integer) Implements IDocumentoContabilizadoRepository.UpdateEstadoDOCUMENTOCONTABILIZADO
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoDOCUMENTOCONTABILIZADO")
        command.Parameters.AddWithValue("IdDocumentoCont", IdDocumentoCont)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function SaveDOCUMENTOCONTABILIZADO(ByVal _Documentocontabilizado As BussinessEntities.DocumentoContabilizado) As Integer Implements IDocumentoContabilizadoRepository.SaveDOCUMENTOCONTABILIZADO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDOCUMENTOCONTABILIZADO")
        Dim id As Int32
        command.Parameters.AddWithValue("AfectoIvap", _Documentocontabilizado.AfectoIvap)
        command.Parameters.AddWithValue("Codigo", _Documentocontabilizado.Codigo)
        command.Parameters.AddWithValue("CtaDebe", _Documentocontabilizado.CtaDebe)
        command.Parameters.AddWithValue("CtaDetraccion", _Documentocontabilizado.CtaDetraccion)
        command.Parameters.AddWithValue("CtaHaber", _Documentocontabilizado.CtaHaber)
        command.Parameters.AddWithValue("CtaIgv", _Documentocontabilizado.CtaIgv)
        command.Parameters.AddWithValue("CtaRetencion", _Documentocontabilizado.CtaRetencion)
        command.Parameters.AddWithValue("Descripcion", _Documentocontabilizado.Descripcion)
        command.Parameters.AddWithValue("IdDocumentoCont", _Documentocontabilizado.IdDocumentoCont)
        command.Parameters.AddWithValue("IdMoneda", _Documentocontabilizado.IdMoneda)
        command.Parameters.AddWithValue("IdTipoDocumento", _Documentocontabilizado.IdTipoDocumento)
        command.Parameters.AddWithValue("CtaIngresosIvap", _Documentocontabilizado.CtaIngresosIvap)
        command.Parameters.AddWithValue("CtagastosIvap", _Documentocontabilizado.CtagastosIvap)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                id = reader.GetValue(0)
            End If

        End Using
        Return id
    End Function
End Class
