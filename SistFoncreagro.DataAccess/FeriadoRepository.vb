Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class FeriadoRepository : Inherits MasterDataAccess : Implements IFeriadoRepository

    Public Function GetFeriadoByFecha(ByVal Fecha As Date) As BussinessEntities.Feriado Implements IFeriadoRepository.GetFeriadoByFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFeriadoByFecha")
        command.Parameters.AddWithValue("Fecha", Fecha)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Feriado)
        Dim lista As New List(Of Feriado)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New Feriado
                If Not reader.IsDBNull(reader.GetOrdinal("Fecha")) Then
                    entity.Fecha = reader.GetValue(reader.GetOrdinal("Fecha"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdFeriado")) Then
                    entity.IdFeriado = reader.GetValue(reader.GetOrdinal("IdFeriado"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Origen")) Then
                    entity.Origen = reader.GetValue(reader.GetOrdinal("Origen"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Recuperable")) Then
                    entity.Recuperable = reader.GetValue(reader.GetOrdinal("Recuperable"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

    Public Sub DeleteFeriado(ByVal _id As Integer) Implements IFeriadoRepository.DeleteFeriado
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteFERIADO")
        command.Parameters.AddWithValue("idFeriado", _id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromFeriado() As System.Collections.Generic.List(Of BussinessEntities.Feriado) Implements IFeriadoRepository.GetAllFromFeriado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromFERIADO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFeriadoById(ByVal _Id As Integer) As BussinessEntities.Feriado Implements IFeriadoRepository.GetFeriadoById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFERIADOById")
        command.Parameters.AddWithValue("idFeriado", _Id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveFeriado(ByVal _Feriado As BussinessEntities.Feriado) As Integer Implements IFeriadoRepository.SaveFeriado
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveFERIADO")
        Dim Id As Int32

        command.Parameters.AddWithValue("IdFeriado", _Feriado.IdFeriado)
        command.Parameters.AddWithValue("Fecha", _Feriado.Fecha)
        command.Parameters.AddWithValue("Origen", _Feriado.Origen)
        command.Parameters.AddWithValue("Recuperable", _Feriado.Recuperable)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function
End Class
