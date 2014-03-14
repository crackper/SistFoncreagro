Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ParametrosRepository : Inherits MasterDataAccess : Implements IParametrosRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Parametros)
        Dim lista As New List(Of Parametros)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Parametros As New Parametros() With
                {
                    .Estado = reader.GetValue(0),
                    .IdParametro = reader.GetValue(3),
                    .Nombre = reader.GetValue(4),
                    .valor = reader.GetValue(5)
                }
                If Not (reader.IsDBNull(1)) Then
                    _Parametros.FechaFin = reader.GetValue(1)
                End If
                If Not (reader.IsDBNull(2)) Then
                    _Parametros.FechaInicio = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(6)) Then
                    _Parametros.MontoLimite = reader.GetValue(6)
                End If
                lista.Add(_Parametros)
            End While
        End Using
        Return lista
    End Function
    Public Function GetPARAMETROSByNombre(ByVal Nombre As String) As BussinessEntities.Parametros Implements IParametrosRepository.GetPARAMETROSByNombre
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPARAMETROSByNombre")
        command.Parameters.AddWithValue("Nombre", Nombre)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetValorUIT(ByVal Fecha As Date) As BussinessEntities.Parametros Implements IParametrosRepository.GetValorUIT
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetValorUIT")
        command.Parameters.AddWithValue("Fecha", Fecha)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetAllfromPARAMETROS() As System.Collections.Generic.List(Of BussinessEntities.Parametros) Implements IParametrosRepository.GetAllfromPARAMETROS
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllfromPARAMETROS")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetPARAMETROSByIdParametro(ByVal IdParametro As Integer) As BussinessEntities.Parametros Implements IParametrosRepository.GetPARAMETROSByIdParametro
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPARAMETROSByIdParametro")
        command.Parameters.AddWithValue("IdParametro", IdParametro)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SavePARAMETROS(ByVal _Parametros As BussinessEntities.Parametros) Implements IParametrosRepository.SavePARAMETROS
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePARAMETROS")
        command.Parameters.AddWithValue("FechaFin", _Parametros.FechaFin)
        command.Parameters.AddWithValue("FechaInicio", _Parametros.FechaInicio)
        command.Parameters.AddWithValue("IdParametro", _Parametros.IdParametro)
        command.Parameters.AddWithValue("MontoLimite", _Parametros.MontoLimite)
        command.Parameters.AddWithValue("Nombre", _Parametros.Nombre)
        command.Parameters.AddWithValue("valor", _Parametros.valor)
        MyBase.ExecuteReader(command)
    End Sub

    Public Sub UpdateEstadoPARAMETROS(ByVal IdParametro As Integer) Implements IParametrosRepository.UpdateEstadoPARAMETROS
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoPARAMETROS")
        command.Parameters.AddWithValue("IdParametro", IdParametro)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetPorcentajeSistemaPenciones(IdSistemaPensiones As Integer, monto As Decimal) As Decimal Implements IParametrosRepository.GetPorcentajeSistemaPenciones
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPorcentajeSistemaPenciones")
        command.Parameters.AddWithValue("IdSistemaPensiones", IdSistemaPensiones)
        command.Parameters.AddWithValue("monto", monto)
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
