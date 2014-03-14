Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class CtaBancariaProyectoRepository : Inherits MasterDataAccess : Implements ICtaBancariaProyectoRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of CtaBancariaProyecto)
        Dim lista As New List(Of CtaBancariaProyecto)
        Dim ProyectoRepository As New ProyectoRepository

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _CtaBancariaProyecto As New CtaBancariaProyecto() With
                {
                   .IdCtaBancaria = reader.GetValue(1),
                   .IdProyecto = reader.GetValue(2),
                   .Saldo = reader.GetValue(3),
                   .Estado = reader.GetValue(4)
                }
                If Not (reader.IsDBNull(0)) Then
                    _CtaBancariaProyecto.Descripcion = reader.GetValue(0)
                End If
                _CtaBancariaProyecto.Proyecto = ProyectoRepository.GetFromProyectoByIdProyecto(reader.GetValue(2))
                lista.Add(_CtaBancariaProyecto)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteCTABANCARIAPROYECTO(ByVal IdCtaBancaria As Integer, ByVal IdProyecto As Integer) Implements ICtaBancariaProyectoRepository.DeleteCTABANCARIAPROYECTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCTABANCARIAPROYECTO")
        command.Parameters.AddWithValue("IdCtaBancaria", IdCtaBancaria)
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetAllFromCTABANCARIAPROYECTO() As System.Collections.Generic.List(Of BussinessEntities.CtaBancariaProyecto) Implements ICtaBancariaProyectoRepository.GetAllFromCTABANCARIAPROYECTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCTABANCARIAPROYECTO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCTABANCARIAPROYECTOByIdCtaBancaria(ByVal IdCtaBancaria As Integer) As System.Collections.Generic.List(Of BussinessEntities.CtaBancariaProyecto) Implements ICtaBancariaProyectoRepository.GetCTABANCARIAPROYECTOByIdCtaBancaria
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCTABANCARIAPROYECTOByIdCtaBancaria")
        command.Parameters.AddWithValue("IdCtaBancaria", IdCtaBancaria)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveCTABANCARIAPROYECTO(ByVal _CtaBancariaProyecto As BussinessEntities.CtaBancariaProyecto) Implements ICtaBancariaProyectoRepository.SaveCTABANCARIAPROYECTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCTABANCARIAPROYECTO")
        command.Parameters.AddWithValue("Descripcion", _CtaBancariaProyecto.Descripcion)
        command.Parameters.AddWithValue("IdCtaBancaria", _CtaBancariaProyecto.IdCtaBancaria)
        command.Parameters.AddWithValue("IdProyecto", _CtaBancariaProyecto.IdProyecto)
        MyBase.ExecuteReader(command)
    End Sub
    Public Sub UpdateEstadoCTABANCARIAPROYECTO(ByVal IdCtaBancaria As Integer, ByVal IdProyecto As Integer) Implements ICtaBancariaProyectoRepository.UpdateEstadoCTABANCARIAPROYECTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoCTABANCARIAPROYECTO")
        command.Parameters.AddWithValue("IdCtaBancaria", IdCtaBancaria)
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetCTABANCARIAPROYECTOByIdCtaBancariaAndIdProyecto(ByVal IdCtaBancaria As Integer, ByVal IdProyecto As Integer) As BussinessEntities.CtaBancariaProyecto Implements ICtaBancariaProyectoRepository.GetCTABANCARIAPROYECTOByIdCtaBancariaAndIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCTABANCARIAPROYECTOByIdCtaBancariaAndIdProyecto")
        command.Parameters.AddWithValue("IdCtaBancaria", IdCtaBancaria)
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
    Public Function GetSaldosCuentasBancarias(IdCtaBancaria As Integer, IdProyecto As Integer, Fecha As Date) As BussinessEntities.CtaBancariaProyecto Implements ICtaBancariaProyectoRepository.GetSaldosCuentasBancarias
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSaldosCuentasBancarias")
        command.Parameters.AddWithValue("IdCtaBancaria", IdCtaBancaria)
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        command.Parameters.AddWithValue("Fecha", Fecha)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
End Class
