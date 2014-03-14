Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports System.Data.SqlClient
Public Class TipoDocumentoRepository : Inherits MasterDataAccess : Implements ITipoDocumentoRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoDocumento)
        Dim lista As New List(Of TipoDocumento)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _TipoDocumento As New TipoDocumento() With
                {
                    .Codigo = reader.GetValue(0),
                    .Estado = reader.GetValue(1),
                    .IdTipoDocumento = reader.GetValue(2),
                    .Nombre = reader.GetValue(3),
                    .SujetoRetencion = reader.GetValue(4)
                }


                lista.Add(_TipoDocumento)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteTIPODOCUMENTO(ByVal IdTipoDocumento As Integer) Implements ITipoDocumentoRepository.DeleteTIPODOCUMENTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteTIPODOCUMENTO")
        command.Parameters.AddWithValue("IdSubdiario", IdTipoDocumento)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromTIPODOCUMENTO() As System.Collections.Generic.List(Of BussinessEntities.TipoDocumento) Implements ITipoDocumentoRepository.GetAllFromTIPODOCUMENTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPODOCUMENTO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTIPODOCUMENTOByIdTipoDocumento(ByVal IdTipoDocumento As Integer) As BussinessEntities.TipoDocumento Implements ITipoDocumentoRepository.GetTIPODOCUMENTOByIdTipoDocumento
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPODOCUMENTOByIdTipoDocumento")
        command.Parameters.AddWithValue("IdTipoDocumento", IdTipoDocumento)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveTIPODOCUMENTO(ByVal _TipoDocumento As BussinessEntities.TipoDocumento) Implements ITipoDocumentoRepository.SaveTIPODOCUMENTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveTIPODOCUMENTO")
        command.Parameters.AddWithValue("Codigo", _TipoDocumento.Codigo)
        command.Parameters.AddWithValue("IdTipoDocumento", _TipoDocumento.IdTipoDocumento)
        command.Parameters.AddWithValue("Nombre", _TipoDocumento.Nombre)
        command.Parameters.AddWithValue("SujetoRetencion", _TipoDocumento.SujetoRetencion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateEstadoTIPODOCUMENTO(ByVal IdTipoDocumento As Integer) Implements ITipoDocumentoRepository.UpdateEstadoTIPODOCUMENTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoTIPODOCUMENTO")
        command.Parameters.AddWithValue("IdTipoDocumento", IdTipoDocumento)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
