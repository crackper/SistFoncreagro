Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class MotivoAusenciaRepository : Inherits MasterDataAccess : Implements IMotivoAusenciaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of MotivoAusencia)
        Dim lista As New List(Of MotivoAusencia)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _MotivoAusencia As New MotivoAusencia() With
                {
                    .codSunat = reader.GetValue(0),
                    .IdMotivoAusencia = reader.GetValue(1),
                    .Motivo = reader.GetValue(2)
                }

                If Not (reader.IsDBNull(3)) Then
                    _MotivoAusencia.NombreArchivoSust = reader.GetValue(3)
                End If
                lista.Add(_MotivoAusencia)
            End While
        End Using
        Return lista
    End Function

    Public Function GetAllFromMOTIVOAUSENCIA() As System.Collections.Generic.List(Of BussinessEntities.MotivoAusencia) Implements IMotivoAusenciaRepository.GetAllFromMOTIVOAUSENCIA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromMOTIVOAUSENCIA")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetMOTIVOAUSENCIAByIdMotivoAusencia(ByVal IdMotivoAusencia As Integer) As BussinessEntities.MotivoAusencia Implements IMotivoAusenciaRepository.GetMOTIVOAUSENCIAByIdMotivoAusencia
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetMOTIVOAUSENCIAByIdMotivoAusencia")
        command.Parameters.AddWithValue("IdMotivoAusencia", IdMotivoAusencia)
        Return (SelectObjectFactory(command).SingleOrDefault)
    End Function

    Public Function GetMotivoAusenciaByIdMotivoAusencia2(ByVal IdMotivoAusencia As Integer) As BussinessEntities.MotivoAusencia Implements IMotivoAusenciaRepository.GetMotivoAusenciaByIdMotivoAusencia2
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetMotivoAusenciaByIdMotivoAusencia2")
        command.Parameters.AddWithValue("IdMotivoAusencia", IdMotivoAusencia)
        Return SelectObjectFactory2(command).SingleOrDefault
    End Function

    Public Function GetMotivoAusenciaByFechasByIdPeriodoLaboral(ByVal FI As Date, ByVal FF As Date, ByVal IdPeriodoLaboral As Integer) As System.Collections.Generic.List(Of BussinessEntities.MotivoAusencia) Implements IMotivoAusenciaRepository.GetMotivoAusenciaByFechasByIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetMotivoAusenciaByFechasByIdPeriodoLaboral")
        command.Parameters.AddWithValue("FI", FI)
        command.Parameters.AddWithValue("FF", FF)
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        Return SelectObjectFactory2(command)
    End Function

    Private Function SelectObjectFactory2(ByVal command As SqlCommand) As List(Of MotivoAusencia)
        Dim lista As New List(Of MotivoAusencia)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New MotivoAusencia
                If Not reader.IsDBNull(reader.GetOrdinal("codSunat")) Then
                    entity.codSunat = reader.GetValue(reader.GetOrdinal("codSunat"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdMotivoAusencia")) Then
                    entity.IdMotivoAusencia = reader.GetValue(reader.GetOrdinal("IdMotivoAusencia"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Motivo")) Then
                    entity.Motivo = reader.GetValue(reader.GetOrdinal("Motivo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("NombreArchivoSust")) Then
                    entity.NombreArchivoSust = reader.GetValue(reader.GetOrdinal("NombreArchivoSust"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Abreviatura")) Then
                    entity.Abreviatura = reader.GetValue(reader.GetOrdinal("Abreviatura"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function


End Class
