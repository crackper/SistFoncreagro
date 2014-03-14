Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class DatosPresupRepository : Inherits MasterDataAccess : Implements IDatosPresupRepository

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DatosPresup)
        Dim lista As New List(Of DatosPresup)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _DatosPresup As New DatosPresup() With
                    {
                        .IdCCosto = reader.GetValue(reader.GetOrdinal("IdCCosto"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Componente"))) Then
                    _DatosPresup.Componente = reader.GetValue(reader.GetOrdinal("Componente"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Actividad"))) Then
                    _DatosPresup.Actividad = reader.GetValue(reader.GetOrdinal("Actividad"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("ElementoGasto"))) Then
                    _DatosPresup.ElementoGasto = reader.GetValue(reader.GetOrdinal("ElementoGasto"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Unidad"))) Then
                    _DatosPresup.Unidad = reader.GetValue(reader.GetOrdinal("Unidad"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Anio"))) Then
                    _DatosPresup.Anio = reader.GetValue(reader.GetOrdinal("Anio"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("TipoPres"))) Then
                    _DatosPresup.TipoPres = reader.GetValue(reader.GetOrdinal("TipoPres"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Ene"))) Then
                    _DatosPresup.Ene = reader.GetValue(reader.GetOrdinal("Ene"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Feb"))) Then
                    _DatosPresup.Feb = reader.GetValue(reader.GetOrdinal("Feb"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Mar"))) Then
                    _DatosPresup.Mar = reader.GetValue(reader.GetOrdinal("Mar"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Abr"))) Then
                    _DatosPresup.Abr = reader.GetValue(reader.GetOrdinal("Abr"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("May"))) Then
                    _DatosPresup.Mayo = reader.GetValue(reader.GetOrdinal("May"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Jun"))) Then
                    _DatosPresup.Jun = reader.GetValue(reader.GetOrdinal("Jun"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Jul"))) Then
                    _DatosPresup.Jul = reader.GetValue(reader.GetOrdinal("Jul"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Ago"))) Then
                    _DatosPresup.Ago = reader.GetValue(reader.GetOrdinal("Ago"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Sep"))) Then
                    _DatosPresup.Sep = reader.GetValue(reader.GetOrdinal("Sep"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Oct"))) Then
                    _DatosPresup.Oct = reader.GetValue(reader.GetOrdinal("Oct"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Nov"))) Then
                    _DatosPresup.Nov = reader.GetValue(reader.GetOrdinal("Nov"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Dic"))) Then
                    _DatosPresup.Dic = reader.GetValue(reader.GetOrdinal("Dic"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Total"))) Then
                    _DatosPresup.Total = reader.GetValue(reader.GetOrdinal("Total"))
                End If
                lista.Add(_DatosPresup)
            End While
        End Using
        Return lista
    End Function

    Public Function GetDatosPresupByParameters(ByVal _IdProyecto As Integer, ByVal _IdEjerPresup As Integer, ByVal _Anio As Integer) As System.Collections.Generic.List(Of BussinessEntities.DatosPresup) Implements IDatosPresupRepository.GetDatosPresupByParameters
        Dim command As SqlCommand = MyBase.CreateSPCommand("DatosPresupuesto")
        command.Parameters.AddWithValue("IdProyecto", _IdProyecto)
        command.Parameters.AddWithValue("IdEjerPresup", _IdEjerPresup)
        command.Parameters.AddWithValue("Anio", _Anio)
        Return SelectObjectFactory(command)
    End Function

    Public Sub CrearPresup(ByVal _IdProyecto As Integer, ByVal _IdEjerPresup As Integer) Implements IDatosPresupRepository.CrearPresup
        Dim command As SqlCommand = MyBase.CreateSPCommand("NueEjerPresup")
        command.Parameters.AddWithValue("IdProyecto", _IdProyecto)
        command.Parameters.AddWithValue("IdEjerPresup", _IdEjerPresup)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
