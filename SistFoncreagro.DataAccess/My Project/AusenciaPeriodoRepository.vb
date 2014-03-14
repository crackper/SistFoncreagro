Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AusenciaPeriodoRepository : Inherits MasterDataAccess : Implements IAusenciaPeriodoRepository

    Public Function GetSumAusenciasPeriodoNoPagadas(ByVal IdJornadaLaboral As Integer) As Decimal Implements IAusenciaPeriodoRepository.GetSumAusenciasPeriodoNoPagadas
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSumAusenciasPeriodoNoPagadas")
        command.Parameters.AddWithValue("IdJornadaLaboral", IdJornadaLaboral)
        Return command.ExecuteScalar()

        'Dim i As Int32
        'Using reader As SqlDataReader = MyBase.ExecuteReader(command)
        '    If reader.Read Then
        '        If Not reader.IsDBNull(0) Then
        '            i = reader.GetValue(0)
        '        End If
        '    Else
        '        i = 0 'command.Parameters("idCargo").Value
        '    End If
        'End Using


        'Return i
    End Function
    Public Function GetAusenciasPeriodoByIdJornadaLaboral(ByVal IdJornadaLaboral As Integer) As System.Collections.Generic.List(Of BussinessEntities.AusenciaPeriodo) Implements IAusenciaPeriodoRepository.GetAusenciasPeriodoByIdJornadaLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAusenciasPeriodoByIdJornadaLaboral")
        command.Parameters.AddWithValue("IdJornadaLaboral", IdJornadaLaboral)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAusenciasPeriodoByIdJornadaLaboralByAbreviatura(ByVal IdJornadaLaboral As Integer, ByVal abreviatura As String) As BussinessEntities.AusenciaPeriodo Implements IAusenciaPeriodoRepository.GetAusenciasPeriodoByIdJornadaLaboralByAbreviatura
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAusenciasPeriodoByIdJornadaLaboralByAbreviatura")
        command.Parameters.AddWithValue("IdJornadaLaboral", IdJornadaLaboral)
        command.Parameters.AddWithValue("abreviatura", abreviatura)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveAUSENCIASPERIODO(ByVal IdPeriodoLaboral As Integer, ByVal IdJornadaLaboral As Integer, ByVal IdMotivoAusencia As Integer, ByVal Abreviatura As String, ByVal FI As Date, ByVal FF As Date) As Integer Implements IAusenciaPeriodoRepository.SaveAUSENCIASPERIODO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAUSENCIASPERIODO")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdJornadaLaboral", IdJornadaLaboral)
        command.Parameters.AddWithValue("IdMotivoAusencia", IdMotivoAusencia)
        command.Parameters.AddWithValue("Abreviatura", Abreviatura)
        command.Parameters.AddWithValue("FI", FI)
        command.Parameters.AddWithValue("FF", FF)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AusenciaPeriodo)
        Dim lista As New List(Of AusenciaPeriodo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New AusenciaPeriodo
                If Not reader.IsDBNull(reader.GetOrdinal("IdJornadaLaboral")) Then
                    entity.IdJornadaLaboral = reader.GetValue(reader.GetOrdinal("IdJornadaLaboral"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdMotivoAusencia")) Then
                    entity.IdMotivoAusencia = reader.GetValue(reader.GetOrdinal("IdMotivoAusencia"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("NroDias")) Then
                    entity.NroDias = reader.GetValue(reader.GetOrdinal("NroDias"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function


End Class
