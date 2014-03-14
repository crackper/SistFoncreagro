Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class MonedaRepository : Inherits MasterDataAccess : Implements IMonedaRepository

    Public Function GetAllFromMoneda() As System.Collections.Generic.List(Of BussinessEntities.Moneda) Implements IMonedaRepository.GetAllFromMoneda
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromMONEDA")
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveMoneda(ByVal Moneda As BussinessEntities.Moneda) Implements IMonedaRepository.SaveMoneda
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveMoneda")
        command.Parameters.AddWithValue("IdMoneda", Moneda.IdMoneda)
        command.Parameters.AddWithValue("Nombre", Moneda.Nombre)
        command.Parameters.AddWithValue("Siglas", Moneda.Siglas)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Moneda)
        Dim lista As New List(Of Moneda)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Moneda As New Moneda() With
                {
                    .IdMoneda = reader.GetValue(0),
                    .Nombre = reader.GetValue(1),
                .Siglas = reader.GetValue(2)
                }
                lista.Add(_Moneda)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteMoneda(ByVal IdMoneda As Integer) Implements IMonedaRepository.DeleteMoneda
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteMoneda")
        command.Parameters.AddWithValue("IdMoneda", IdMoneda)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetMonedaByIdMoneda(ByVal IdMoneda As Integer) As BussinessEntities.Moneda Implements IMonedaRepository.GetMonedaByIdMoneda
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetMONEDAByIdMoneda")
        command.Parameters.AddWithValue("IdMoneda", IdMoneda)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
End Class
