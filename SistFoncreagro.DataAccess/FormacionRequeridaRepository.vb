Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class FormacionRequeridaRepository : Inherits MasterDataAccess : Implements IFormacionRequeridaRepository

    Public Function GetAllFromFORMACIONREQUERIDA() As System.Collections.Generic.List(Of BussinessEntities.FormacionRequerida) Implements IFormacionRequeridaRepository.GetAllFromFORMACIONREQUERIDA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromFORMACIONREQUERIDA")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFORMACIONREQUERIDAByIdFormacionAndIdPosicion(ByVal IdFormacion As Integer, ByVal IdPosicion As Integer) As BussinessEntities.FormacionRequerida Implements IFormacionRequeridaRepository.GetFORMACIONREQUERIDAByIdFormacionAndIdPosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFORMACIONREQUERIDAByIdFormacionAndIdPosicion")
        command.Parameters.AddWithValue("IdFormacion", IdFormacion)
        command.Parameters.AddWithValue("IdPosicion", IdPosicion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetFORMACIONREQUERIDAByIdPosicion(ByVal IdPosicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.FormacionRequerida) Implements IFormacionRequeridaRepository.GetFORMACIONREQUERIDAByIdPosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFORMACIONREQUERIDAByIdPosicion")
        command.Parameters.AddWithValue("IdPosicion", IdPosicion)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveFORMACIONREQUERIDA(ByVal formacionRequerida As BussinessEntities.FormacionRequerida) As Integer Implements IFormacionRequeridaRepository.SaveFORMACIONREQUERIDA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveHABILIDADES")
        command.Parameters.AddWithValue("IdFormacion", formacionRequerida.IdFormacion)
        command.Parameters.AddWithValue("IdPosicion", formacionRequerida.IdPosicion)
        command.Parameters.AddWithValue("Requisito", formacionRequerida.Descripcion)
        command.Parameters.AddWithValue("Condicional", formacionRequerida.Condicional)

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

    Public Sub DeleteREQUISITOADICIONAL(ByVal IdFormacion As Integer, ByVal IdPosicion As Integer) Implements IFormacionRequeridaRepository.DeleteREQUISITOADICIONAL

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of FormacionRequerida)
        Dim lista As New List(Of FormacionRequerida)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New FormacionRequerida
                If Not reader.IsDBNull(reader.GetOrdinal("IdPosicion")) Then
                    entity.IdPosicion = reader.GetValue(reader.GetOrdinal("IdPosicion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdFormacion")) Then
                    entity.IdFormacion = reader.GetValue(reader.GetOrdinal("IdFormacion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("condicional")) Then
                    entity.Condicional = reader.GetValue(reader.GetOrdinal("condicional"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function

End Class
