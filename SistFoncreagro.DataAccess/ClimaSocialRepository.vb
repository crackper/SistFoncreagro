Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ClimaSocialRepository : Inherits MasterDataAccess : Implements IClimaSocialRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ClimaSocial)
        Dim lista As New List(Of ClimaSocial)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _ClimaSocial As New ClimaSocial() With
                {
                  .IdClima = reader.GetValue(0),
                  .Acceso = reader.GetValue(1),
                  .Agresividad = reader.GetValue(2),
                  .Movilizaciones = reader.GetValue(3),
                  .Quejas = reader.GetValue(4),
                  .Cobertura = reader.GetValue(5),
                  .Confrontacion = reader.GetValue(6),
                  .Dimension = reader.GetValue(7),
                  .Autoridades = reader.GetValue(8),
                  .Docentes = reader.GetValue(9),
                  .Rondas = reader.GetValue(10),
                  .ActExterna = reader.GetValue(11),
                  .Promedio = reader.GetValue(12),
                  .Actitud = reader.GetValue(13),
                  .CUBIGEO = reader.GetValue(14),
                  .IdProyecto = reader.GetValue(15),
                  .Fecha = reader.GetValue(16),
                  .Tipo = reader.GetValue(17),
                .IdUsuario = reader.GetValue(22)
                }
                If Not (reader.IsDBNull(18)) Then
                    _ClimaSocial.Razon = reader.GetValue(18)
                End If
                If Not (reader.IsDBNull(19)) Then
                    _ClimaSocial.DescQuejas = reader.GetValue(19)
                End If
                If Not (reader.IsDBNull(20)) Then
                    _ClimaSocial.AccionesTomadas = reader.GetValue(20)
                End If
                If Not (reader.IsDBNull(21)) Then
                    _ClimaSocial.Observaciones = reader.GetValue(21)
                End If
                If Not (reader.IsDBNull(23)) Then
                    _ClimaSocial.Actitud1 = reader.GetValue(23)
                End If
                lista.Add(_ClimaSocial)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteCLIMASOCIAL(ByVal IdClima As Integer) Implements IClimaSocialRepository.DeleteCLIMASOCIAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCLIMASOCIAL")
        command.Parameters.AddWithValue("IdClima", IdClima)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetCLIMASOCIALByIdClima(ByVal IdClima As Integer) As BussinessEntities.ClimaSocial Implements IClimaSocialRepository.GetCLIMASOCIALByIdClima
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCLIMASOCIALByIdClima")
        command.Parameters.AddWithValue("IdClima", IdClima)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetCLIMASOCIALByIdUbigeoandIdProyecto(ByVal Cubigeo As String, ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.ClimaSocial) Implements IClimaSocialRepository.GetCLIMASOCIALByIdUbigeoandIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCLIMASOCIALByIdUbigeoandIdProyecto")
        command.Parameters.AddWithValue("Cubigeo", Cubigeo)
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        Return SelectObjectFactory(command)
    End Function
    Public Function SaveCLIMASOCIAL(ByVal _Clima As BussinessEntities.ClimaSocial) As Integer Implements IClimaSocialRepository.SaveCLIMASOCIAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCLIMASOCIAL")
        command.Parameters.AddWithValue("Acceso", _Clima.Acceso)
        command.Parameters.AddWithValue("AccionesTomadas", _Clima.AccionesTomadas)
        command.Parameters.AddWithValue("ActExterna", _Clima.ActExterna)
        command.Parameters.AddWithValue("Agresividad", _Clima.Agresividad)
        command.Parameters.AddWithValue("Autoridades", _Clima.Autoridades)
        command.Parameters.AddWithValue("Cobertura", _Clima.Cobertura)
        command.Parameters.AddWithValue("Confrontacion", _Clima.Confrontacion)
        command.Parameters.AddWithValue("CUBIGEO", _Clima.CUBIGEO)
        command.Parameters.AddWithValue("DescQuejas", _Clima.DescQuejas)
        command.Parameters.AddWithValue("Dimension", _Clima.Dimension)
        command.Parameters.AddWithValue("Docentes", _Clima.Docentes)
        command.Parameters.AddWithValue("Fecha", _Clima.Fecha)
        command.Parameters.AddWithValue("IdClima", _Clima.IdClima)
        command.Parameters.AddWithValue("IdProyecto", _Clima.IdProyecto)
        command.Parameters.AddWithValue("IdUsuario", _Clima.IdUsuario)
        command.Parameters.AddWithValue("Movilizaciones", _Clima.Movilizaciones)
        command.Parameters.AddWithValue("Observaciones", _Clima.Observaciones)
        command.Parameters.AddWithValue("Quejas", _Clima.Quejas)
        command.Parameters.AddWithValue("Razon", _Clima.Razon)
        command.Parameters.AddWithValue("Rondas", _Clima.Rondas)
        command.Parameters.AddWithValue("Tipo", _Clima.Tipo)
        command.Parameters.AddWithValue("Actitud1", _Clima.Actitud1)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If

            End If
        End Using
        Return i
    End Function
End Class
