Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AusenciaRepository : Inherits MasterDataAccess : Implements IAusenciaRepository


    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Ausencia)
        Dim lista As New List(Of Ausencia)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Ausencia As New Ausencia() With
                {
                   .Archivo = reader.GetValue(0),
                   .Comentario = reader.GetValue(1),
                   .FechaInicio = reader.GetValue(2),
                   .FechaFin = reader.GetValue(3),
                   .IdAusencia = reader.GetValue(4),
                   .IdMotivoAusencia = reader.GetValue(5),
                   .IdPeriodoLaboral = reader.GetValue(6),
                   .NroArchivo = reader(7),
                .Tiempo = reader.GetValue(8)
                                   }

                lista.Add(_Ausencia)
            End While
        End Using
        Return lista
    End Function

    Private Function SelectObjectFactory2(ByVal command As SqlCommand) As List(Of Ausencia)
        Dim lista As New List(Of Ausencia)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New Ausencia
                If Not reader.IsDBNull(reader.GetOrdinal("Archivo")) Then
                    entity.Archivo = reader.GetValue(reader.GetOrdinal("Archivo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FechaInicio")) Then
                    entity.FechaInicio = reader.GetValue(reader.GetOrdinal("FechaInicio"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FechaFin")) Then
                    entity.FechaFin = reader.GetValue(reader.GetOrdinal("FechaFin"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdAusencia")) Then
                    entity.IdAusencia = reader.GetValue(reader.GetOrdinal("IdAusencia"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoLaboral")) Then
                    entity.IdPeriodoLaboral = reader.GetValue(reader.GetOrdinal("IdPeriodoLaboral"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("NroArchivo")) Then
                    entity.NroArchivo = reader.GetValue(reader.GetOrdinal("NroArchivo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Tiempo")) Then
                    entity.Tiempo = reader.GetValue(reader.GetOrdinal("Tiempo"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdMotivoAusencia")) Then
                    entity.IdMotivoAusencia = reader.GetValue(reader.GetOrdinal("IdMotivoAusencia"))
                    Dim MotivoAusenciaRepository As New MotivoAusenciaRepository
                    entity.MotivoAusenciaEntity = MotivoAusenciaRepository.GetMotivoAusenciaByIdMotivoAusencia2(entity.IdMotivoAusencia)
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function

    Public Sub DeleteAusencia(ByVal IdAusencia As Integer, ByVal IdPeriodoLaboral As Integer) Implements IAusenciaRepository.DeleteAusencia
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteAusencia")
        command.Parameters.AddWithValue("IdAusencia", IdAusencia)
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetAUSENCIAByIdAusenciaAndIdPeriodoLaboral(ByVal IdAusencia As Integer, ByVal IdPeriodoLaboral As Integer) As BussinessEntities.Ausencia Implements IAusenciaRepository.GetAUSENCIAByIdAusenciaAndIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAUSENCIAByIdAusenciaAndIdPeriodoLaboral")
        command.Parameters.AddWithValue("IdAusencia", IdAusencia)
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetAUSENCIAByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Integer) As System.Collections.Generic.List(Of BussinessEntities.Ausencia) Implements IAusenciaRepository.GetAUSENCIAByIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAUSENCIAByIdPeriodoLaboral")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveAUSENCIA(ByVal _Ausencia As BussinessEntities.Ausencia) As Integer Implements IAusenciaRepository.SaveAUSENCIA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAUSENCIA")
        Dim Id As Int32 = 0
        command.Parameters.AddWithValue("Archivo", _Ausencia.Archivo)
        command.Parameters.AddWithValue("Comentario", _Ausencia.Comentario)
        command.Parameters.AddWithValue("FechaFin", _Ausencia.FechaFin)
        command.Parameters.AddWithValue("FechaInicio", _Ausencia.FechaInicio)
        command.Parameters.AddWithValue("IdAusencia", _Ausencia.IdAusencia)
        command.Parameters.AddWithValue("IdMotivoAusencia", _Ausencia.IdMotivoAusencia)
        command.Parameters.AddWithValue("IdPeriodoLaboral", _Ausencia.IdPeriodoLaboral)
        command.Parameters.AddWithValue("NroArchivo", _Ausencia.NroArchivo)
        command.Parameters.AddWithValue("Tiempo", _Ausencia.Tiempo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If

        End Using
        Return Id
    End Function

    Public Sub UpdateArchivoAUSENCIA(ByVal Archivo As String, ByVal IdAusencia As Integer, ByVal IdPeriodoLaboral As Integer) Implements IAusenciaRepository.UpdateArchivoAUSENCIA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateArchivoAUSENCIA")
        command.Parameters.AddWithValue("Archivo", Archivo)
        command.Parameters.AddWithValue("IdAusencia", IdAusencia)
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetAUSENCIAByIdPeriodoLaboralAndRangofechaControlAsistencia(ByVal IdPeriodoLaboral As Integer, ByVal FechaInicioControl As Date, ByVal FechaFinControl As Date) As System.Collections.Generic.List(Of BussinessEntities.Ausencia) Implements IAusenciaRepository.GetAUSENCIAByIdPeriodoLaboralAndRangofechaControlAsistencia
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAUSENCIAByIdPeriodoLaboralAndRangofechaControlAsistencia")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("FechaInicioControl", FechaInicioControl)
        command.Parameters.AddWithValue("FechaFinControl", FechaFinControl)

        Return SelectObjectFactory2(command)
    End Function

    Public Function GetAusenciaByIdPeriodoLaboralByAbreviatura(ByVal IdPeriodoLaboral As Integer, ByVal Abreviatura As String) As Object Implements IAusenciaRepository.GetAusenciaByIdPeriodoLaboralByAbreviatura
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAusenciaByIdPeriodoLaboralByAbreviatura")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("Abreviatura", Abreviatura)

        Return SelectObjectFactory2(command)
    End Function
End Class
