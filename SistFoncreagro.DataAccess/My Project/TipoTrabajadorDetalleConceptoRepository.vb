Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoTrabajadorDetalleConceptoRepository : Inherits MasterDataAccess : Implements ITipoTrabajadorDetalleConceptoRepository

    Public Function GetTipoTrabajadorDetalleConceptoByDisponible(ByVal Disponible As Boolean) As System.Collections.Generic.List(Of BussinessEntities.TipoTrabajadorDetalleConcepto) Implements ITipoTrabajadorDetalleConceptoRepository.GetTipoTrabajadorDetalleConceptoByDisponible
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTipoTrabajadorDetalleConceptoByDisponible")
        command.Parameters.AddWithValue("Disponible", Disponible)
        Return SelectObjectFactory(command)
    End Function

    Public Sub DeleteTipoTrabajadorDetalleConcepto(ByVal IdTipoTDetConcepto As Integer) Implements ITipoTrabajadorDetalleConceptoRepository.DeleteTipoTrabajadorDetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteTipoTrabajadorDetalleConcepto")
        command.Parameters.AddWithValue("IdTipoTDetConcepto", IdTipoTDetConcepto)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetTipoTrabajadorDetalleConceptoByIds(ByVal IdTipoTrabajador As Integer, ByVal IdCategoria As Integer, ByVal IdDetalleConcepto As Integer) As BussinessEntities.TipoTrabajadorDetalleConcepto Implements ITipoTrabajadorDetalleConceptoRepository.GetTipoTrabajadorDetalleConceptoByIds
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTipoTrabajadorDetalleConceptoByIds")
        command.Parameters.AddWithValue("IdTipoTrabajador", IdTipoTrabajador)
        command.Parameters.AddWithValue("IdCategoria", IdCategoria)
        command.Parameters.AddWithValue("IdDetalleConcepto", IdDetalleConcepto)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveTipoTrabajadorDetalleConcepto(ByVal TipoTrabajadorDetalleConcepto As BussinessEntities.TipoTrabajadorDetalleConcepto) As Integer Implements ITipoTrabajadorDetalleConceptoRepository.SaveTipoTrabajadorDetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveTipoTrabajadorDetalleConcepto")
        command.Parameters.AddWithValue("IdTipoTDetConcepto", TipoTrabajadorDetalleConcepto.IdTipoTDetConcepto)
        command.Parameters.AddWithValue("IdTipoTrabajador", TipoTrabajadorDetalleConcepto.IdTipoTrabajador)
        command.Parameters.AddWithValue("IdCategoria", TipoTrabajadorDetalleConcepto.IdCategoria)
        command.Parameters.AddWithValue("IdDetalleConcepto", TipoTrabajadorDetalleConcepto.IdDetalleConcepto)

        'command.Parameters("idCargo").Direction = ParameterDirection.Output

        'MyBase.ExecuteNonQuery(command)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If
            Else
                i = 0 'command.Parameters("idCargo").Value
            End If
        End Using

        Return i
        'command.ExecuteReader(CommandBehavior.SingleRow).Item(0)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoTrabajadorDetalleConcepto)
        Dim lista As New List(Of TipoTrabajadorDetalleConcepto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New TipoTrabajadorDetalleConcepto
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoTDetConcepto")) Then
                    entity.IdTipoTDetConcepto = reader.GetValue(reader.GetOrdinal("IdTipoTDetConcepto"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdDetalleConcepto")) Then
                    entity.IdDetalleConcepto = reader.GetValue(reader.GetOrdinal("IdDetalleConcepto"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdCategoria")) Then
                    entity.IdCategoria = reader.GetValue(reader.GetOrdinal("IdCategoria"))
                    Dim categoriaRrhhRepository As New CategoriaRrhhRepository
                    entity.categoriaRrhhEntity = categoriaRrhhRepository.GetCategoriaRrhhByIdCategoria(entity.IdCategoria)
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoTrabajador")) Then
                    entity.IdTipoTrabajador = reader.GetValue(reader.GetOrdinal("IdTipoTrabajador"))
                    Dim tipoTrabajadorRepository As New TipoTrabajadorRepository
                    entity.tipoTrabajadorEntity = tipoTrabajadorRepository.GetTipoTrabajadorByIdTipoTrabajadorIdCategoria(entity.IdTipoTrabajador, entity.IdCategoria)
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

End Class
