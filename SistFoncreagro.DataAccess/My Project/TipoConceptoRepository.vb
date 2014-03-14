Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoConceptoRepository : Inherits MasterDataAccess : Implements ITipoConceptoRepository

    Public Function GetAllFromTIPOCONCEPTO() As System.Collections.Generic.List(Of BussinessEntities.TipoConcepto) Implements ITipoConceptoRepository.GetAllFromTIPOCONCEPTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOCONCEPTO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTIPOCONCEPTOByIdTipoConcepto(ByVal IdTipoConcepto As Int32) As BussinessEntities.TipoConcepto Implements ITipoConceptoRepository.GetTIPOCONCEPTOByIdTipoConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOCONCEPTOByIdTipoConcepto")
        command.Parameters.AddWithValue("IdTipoConcepto", IdTipoConcepto)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoConcepto)
        Dim lista As New List(Of TipoConcepto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New TipoConcepto
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoConcepto")) Then
                    entity.IdTipoConcepto = reader.GetValue(reader.GetOrdinal("IdTipoConcepto"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Tipo")) Then
                    entity.Tipo = reader.GetValue(reader.GetOrdinal("Tipo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Cod")) Then
                    entity.Cod = reader.GetValue(reader.GetOrdinal("Cod"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function
End Class
