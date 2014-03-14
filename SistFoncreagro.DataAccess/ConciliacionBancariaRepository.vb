Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ConciliacionBancariaRepository : Inherits MasterDataAccess : Implements IConciliacionBancariaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ConciliacionBancaria)
        Dim lista As New List(Of ConciliacionBancaria)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _ConciliacionBancaria As New ConciliacionBancaria() With
                {
                  .IdConciliacion = reader.GetValue(0),
                  .IdCtaBancaria = reader.GetValue(1),
                  .Fecha = reader.GetValue(2),
                  .SaldoBancario = reader.GetValue(3),
                  .IdUsuario = reader.GetValue(4),
                  .Mes = reader.GetValue(5),
                  .Anio = reader.GetValue(6),
                  .Estado = reader.GetValue(7),
                  .Adjunto = reader.GetValue(8)
                }
                lista.Add(_ConciliacionBancaria)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteCONCILIACIONBANCARIA(ByVal IdConciliacion As Integer) Implements IConciliacionBancariaRepository.DeleteCONCILIACIONBANCARIA
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCONCILIACIONBANCARIA")
        command.Parameters.AddWithValue("IdConciliacion", IdConciliacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetCONCILIACIONBANCARIAByAnioAndIdCtaBancaria(ByVal Anio As Integer, ByVal IdCtaBancaria As Integer) As System.Collections.Generic.List(Of BussinessEntities.ConciliacionBancaria) Implements IConciliacionBancariaRepository.GetCONCILIACIONBANCARIAByAnioAndIdCtaBancaria
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONCILIACIONBANCARIAByAnioAndIdCtaBancaria")
        command.Parameters.AddWithValue("anio", Anio)
        command.Parameters.AddWithValue("IdCtaBancaria", IdCtaBancaria)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCONCILIACIONBANCARIAByIdConciliacion(ByVal IdConciliacion As Integer) As BussinessEntities.ConciliacionBancaria Implements IConciliacionBancariaRepository.GetCONCILIACIONBANCARIAByIdConciliacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONCILIACIONBANCARIAByIdConciliacion")
        command.Parameters.AddWithValue("IdConciliacion", IdConciliacion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveCONCILIACIONBANCARIA(ByVal _ConciliacionBancaria As BussinessEntities.ConciliacionBancaria) As Integer Implements IConciliacionBancariaRepository.SaveCONCILIACIONBANCARIA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCONCILIACIONBANCARIA")
        command.Parameters.AddWithValue("Anio", _ConciliacionBancaria.Anio)
        command.Parameters.AddWithValue("Fecha", _ConciliacionBancaria.Fecha)
        command.Parameters.AddWithValue("IdConciliacion", _ConciliacionBancaria.IdConciliacion)
        command.Parameters.AddWithValue("IdCtaBancaria", _ConciliacionBancaria.IdCtaBancaria)
        command.Parameters.AddWithValue("IdUsuario", _ConciliacionBancaria.IdUsuario)
        command.Parameters.AddWithValue("SaldoBancario", _ConciliacionBancaria.SaldoBancario)
        command.Parameters.AddWithValue("Adjunto", _ConciliacionBancaria.Adjunto)
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

    Public Sub UpdateEstadoCONCILIACIONBANCARIA(ByVal IdConciliacion As Integer) Implements IConciliacionBancariaRepository.UpdateEstadoCONCILIACIONBANCARIA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoCONCILIACIONBANCARIA")
        command.Parameters.AddWithValue("IdConciliacion", IdConciliacion)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
