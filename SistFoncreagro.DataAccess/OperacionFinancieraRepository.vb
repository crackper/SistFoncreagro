Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class OperacionFinancieraRepository : Inherits MasterDataAccess : Implements IOperacionFinancieraRepository

    Public Function GetAllFromOperacionFinanciera() As System.Collections.Generic.List(Of BussinessEntities.OperacionFinanciera) Implements IOperacionFinancieraRepository.GetAllFromOperacionFinanciera
        'Retorna todos las operaciones financieras de la base de datos
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromOPERACIONFINANCIERA")
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveOperacionFinanciera(ByVal _OperacionFinanciera As BussinessEntities.OperacionFinanciera) Implements IOperacionFinancieraRepository.SaveOperacionFinanciera
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveOperacionFinanciera")
        command.Parameters.AddWithValue("idOperacion", _OperacionFinanciera.IdOpFinanciera)
        command.Parameters.AddWithValue("descripcion", _OperacionFinanciera.Descripcion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of OperacionFinanciera)
        Dim lista As New List(Of OperacionFinanciera)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _OperacionFinanciera As New OperacionFinanciera() With
                {
                    .Descripcion = reader.GetValue(0),
                    .IdOpFinanciera = reader.GetValue(1)
                }
                lista.Add(_OperacionFinanciera)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function

    Public Sub DeleteOperacionFinanciera(ByVal IdOpFinanciera As Integer) Implements IOperacionFinancieraRepository.DeleteOperacionFinanciera
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteOperacionFinanciera")
        command.Parameters.AddWithValue("idOperacion", IdOpFinanciera)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetOPERACIONFINANCIERAByIdOperacion(ByVal IdOpFinanciera As Integer) As BussinessEntities.OperacionFinanciera Implements IOperacionFinancieraRepository.GetOPERACIONFINANCIERAByIdOperacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetOPERACIONFINANCIERAByIdOperacion")
        command.Parameters.AddWithValue("idOpFinanciera", IdOpFinanciera)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
End Class
