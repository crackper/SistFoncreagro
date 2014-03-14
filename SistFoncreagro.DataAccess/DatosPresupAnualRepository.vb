Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class DatosPresupAnualRepository : Inherits MasterDataAccess : Implements IDatosPresupAnualRepository

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DatosPresupAnual)
        Dim lista As New List(Of DatosPresupAnual)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _DatosPresupAnual As New DatosPresupAnual() With
                    {
                        .IdCCosto = reader.GetValue(reader.GetOrdinal("IdCCosto"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Componente"))) Then
                    _DatosPresupAnual.Componente = reader.GetValue(reader.GetOrdinal("Componente"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Actividad"))) Then
                    _DatosPresupAnual.Actividad = reader.GetValue(reader.GetOrdinal("Actividad"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("ElementoGasto"))) Then
                    _DatosPresupAnual.ElementoGasto = reader.GetValue(reader.GetOrdinal("ElementoGasto"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("PresupAnual"))) Then
                    _DatosPresupAnual.PresupAnual = reader.GetValue(reader.GetOrdinal("PresupAnual"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("miTipo"))) Then
                    _DatosPresupAnual.miTipo = reader.GetValue(reader.GetOrdinal("miTipo"))
                End If
                lista.Add(_DatosPresupAnual)
            End While
        End Using
        Return lista
    End Function

    Public Function GetDatosPresupAnualByParameters(ByVal _IdProyecto As Integer, ByVal _IdEjerPresup As Integer, ByVal _Anio As Integer) As System.Collections.Generic.List(Of BussinessEntities.DatosPresupAnual) Implements IDatosPresupAnualRepository.GetDatosPresupAnualByParameters
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPresupAnualByParameters")
        command.Parameters.AddWithValue("IdProyecto", _IdProyecto)
        command.Parameters.AddWithValue("IdEjerPresup", _IdEjerPresup)
        command.Parameters.AddWithValue("Anio", _Anio)
        Return SelectObjectFactory(command)
    End Function

    Public Sub CrearPresupAnual(ByVal _IdProyecto As Integer, ByVal _IdEjerPresup As Integer) Implements IDatosPresupAnualRepository.CrearPresupAnual
        Dim command As SqlCommand = MyBase.CreateSPCommand("NueEjerPresupAnual")
        command.Parameters.AddWithValue("IdProyecto", _IdProyecto)
        command.Parameters.AddWithValue("IdEjerPresup", _IdEjerPresup)
        MyBase.ExecuteNonQuery(command)
    End Sub

End Class
