Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoPlanillaTipoTrabajadorRepository : Inherits MasterDataAccess : Implements ITipoPlanillaTipoTrabajadorRepository


    Public Sub DeleteTIPOPLANILLATIPOTRABAJADOR(ByVal IdTipoPlanilla As Integer, ByVal IdTipoTrabajador As Integer, ByVal IdCategoria As Integer) Implements ITipoPlanillaTipoTrabajadorRepository.DeleteTIPOPLANILLATIPOTRABAJADOR
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteTIPOPLANILLATIPOTRABAJADOR")
        command.Parameters.AddWithValue("IdTipoPlanilla", IdTipoPlanilla)
        command.Parameters.AddWithValue("IdTipoTrabajador", IdTipoTrabajador)
        command.Parameters.AddWithValue("IdCategoria", IdCategoria)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromTIPOPLANILLATIPOTRABAJADOR() As System.Collections.Generic.List(Of BussinessEntities.TipoPlanillaTipoTrabajador) Implements ITipoPlanillaTipoTrabajadorRepository.GetAllFromTIPOPLANILLATIPOTRABAJADOR
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOPLANILLATIPOTRABAJADOR")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTIPOPLANILLATIPOTRABAJADORByIdTipoPlanilla(ByVal IdTipoPlanilla As Integer) As System.Collections.Generic.List(Of BussinessEntities.TipoPlanillaTipoTrabajador) Implements ITipoPlanillaTipoTrabajadorRepository.GetTIPOPLANILLATIPOTRABAJADORByIdTipoPlanilla
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOPLANILLATIPOTRABAJADORByIdTipoPlanilla")
        command.Parameters.AddWithValue("IdTipoPlanilla", IdTipoPlanilla)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveTIPOPLANILLATIPOTRABAJADOR(ByVal tipoPlanillaTipoTrabajador As BussinessEntities.TipoPlanillaTipoTrabajador) Implements ITipoPlanillaTipoTrabajadorRepository.SaveTIPOPLANILLATIPOTRABAJADOR
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveTIPOPLANILLATIPOTRABAJADOR")
        command.Parameters.AddWithValue("IdTipoPlanillaTrabajador", tipoPlanillaTipoTrabajador.IdTipoPlanillaTrabajador)
        command.Parameters.AddWithValue("IdTipoPlanilla", tipoPlanillaTipoTrabajador.IdTipoPlanilla)
        command.Parameters.AddWithValue("IdTipoTrabajador", tipoPlanillaTipoTrabajador.IdTipoTrabajador)
        command.Parameters.AddWithValue("IdCategoria", tipoPlanillaTipoTrabajador.IdCategoria)

        MyBase.ExecuteNonQuery(command)
    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoPlanillaTipoTrabajador)
        Dim lista As New List(Of TipoPlanillaTipoTrabajador)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New TipoPlanillaTipoTrabajador
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoPlanillaTrabajador")) Then
                    entity.IdTipoPlanillaTrabajador = reader.GetValue(reader.GetOrdinal("IdTipoPlanillaTrabajador"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoPlanilla")) Then
                    entity.IdTipoPlanilla = reader.GetValue(reader.GetOrdinal("IdTipoPlanilla"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoTrabajador")) Then
                    entity.IdTipoTrabajador = reader.GetValue(reader.GetOrdinal("IdTipoTrabajador"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdCategoria")) Then
                    entity.IdCategoria = reader.GetValue(reader.GetOrdinal("IdCategoria"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

End Class
