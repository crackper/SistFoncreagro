Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ActitudInteresadoRepository : Inherits MasterDataAccess : Implements IActitudInteresadoRepository

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ActitudInteresado)
        Dim lista As New List(Of ActitudInteresado)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _ActitudInteresado As New ActitudInteresado() With
                {
                    .IdActitud = reader.GetValue(0),
                    .IdInteresado = reader.GetValue(1),
                    .Actitud = reader.GetValue(2),
                    .Poder = reader.GetValue(3),
                    .Dialogo = reader.GetValue(6),
                    .FechaInicio = reader.GetValue(7),
                .IdUsuario = reader.GetValue(8)
                 }
                If Not (reader.IsDBNull(4)) Then
                    _ActitudInteresado.Comentario = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _ActitudInteresado.PlanAccion = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(9)) Then
                    _ActitudInteresado.FechaFin = reader.GetValue(9)
                End If

                lista.Add(_ActitudInteresado)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteACTITUDINTERESADO(ByVal IdActitud As Integer) Implements IActitudInteresadoRepository.DeleteACTITUDINTERESADO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteACTITUDINTERESADO")
        command.Parameters.AddWithValue("IdActitud", IdActitud)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetACTITUDINTERESADOByIdActitud(ByVal IdActitud As Integer) As BussinessEntities.ActitudInteresado Implements IActitudInteresadoRepository.GetACTITUDINTERESADOByIdActitud
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetACTITUDINTERESADOByIdActitud")
        command.Parameters.AddWithValue("IdActitud", IdActitud)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetACTITUDINTERESADOByIdInteresado(ByVal IdInteresado As Integer) As Object Implements IActitudInteresadoRepository.GetACTITUDINTERESADOByIdInteresado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetACTITUDINTERESADOByIdInteresado")
        command.Parameters.AddWithValue("IdInteresado", IdInteresado)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveACTITUDINTERESADO(ByVal _ActitudInteresado As BussinessEntities.ActitudInteresado) Implements IActitudInteresadoRepository.SaveACTITUDINTERESADO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveACTITUDINTERESADO")
        command.Parameters.AddWithValue("Actitud", _ActitudInteresado.Actitud)
        command.Parameters.AddWithValue("Comentario", _ActitudInteresado.Comentario)
        command.Parameters.AddWithValue("Dialogo", _ActitudInteresado.Dialogo)
        command.Parameters.AddWithValue("FechaInicio", _ActitudInteresado.FechaInicio)
        command.Parameters.AddWithValue("IdActitud", _ActitudInteresado.IdActitud)
        command.Parameters.AddWithValue("IdInteresado", _ActitudInteresado.IdInteresado)
        command.Parameters.AddWithValue("IdUsuario", _ActitudInteresado.IdUsuario)
        command.Parameters.AddWithValue("PlanAccion", _ActitudInteresado.PlanAccion)
        command.Parameters.AddWithValue("Poder", _ActitudInteresado.Poder)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetACTITUDINTERESADOByFecha(ByVal IdInteresado As Integer, ByVal FechaInicio As Date) As BussinessEntities.ActitudInteresado Implements IActitudInteresadoRepository.GetACTITUDINTERESADOByFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetACTITUDINTERESADOByFecha")
        command.Parameters.AddWithValue("IdInteresado", IdInteresado)
        command.Parameters.AddWithValue("FechaInicio", FechaInicio)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
End Class
