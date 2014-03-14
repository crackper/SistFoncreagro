Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ProyectoAreaRepository : Inherits MasterDataAccess : Implements IProyectoAreaRepository

    Public Function GetProyectoAreaByIdArea(ByVal IdArea As Integer) As System.Collections.Generic.List(Of ProyectoArea) Implements IProyectoAreaRepository.GetProyectoAreaByIdArea
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetProyectoAreaByIdArea")
        command.Parameters.AddWithValue("IdArea", IdArea)
        Return SelectObjectFactory(command, "")
    End Function

    Public Function GetProyectoAreaByIdProyectoVigentes(ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of ProyectoArea) Implements IProyectoAreaRepository.GetProyectoAreaByIdProyectoVigentes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetProyectoAreaByIdProyectoVigentes")
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        Return SelectObjectFactory(command, "Ambos")

    End Function

    Public Function GetProyectoAreaByIdAreaByProyectoVigentes(ByVal IdArea As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProyectoArea) Implements IProyectoAreaRepository.GetProyectoAreaByIdAreaByProyectoVigentes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetProyectoAreaByIdAreaByProyectoVigentes")
        command.Parameters.AddWithValue("IdArea", IdArea)
        Return SelectObjectFactory(command, "Proyecto")
    End Function

    Public Sub DeleteProyectoArea(ByVal IdProyectoArea As Int32) Implements IProyectoAreaRepository.DeleteProyectoArea
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteProyectoArea")
        command.Parameters.AddWithValue("IdProyectoArea", IdProyectoArea)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function SaveProyectoArea(ByVal ProyectoArea As BussinessEntities.ProyectoArea) As Integer Implements IProyectoAreaRepository.SaveProyectoArea
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveProyectoArea")
        command.Parameters.AddWithValue("IdArea", ProyectoArea.IdArea)
        command.Parameters.AddWithValue("IdProyectoArea", ProyectoArea.IdProyectoArea)
        command.Parameters.AddWithValue("IdProyecto", ProyectoArea.IdProyecto)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand, ByVal condicion As String) As List(Of ProyectoArea)
        Dim lista As New List(Of ProyectoArea)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New ProyectoArea
                If Not reader.IsDBNull(reader.GetOrdinal("IdArea")) Then
                    entity.IdArea = reader.GetValue(reader.GetOrdinal("IdArea"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdProyectoArea")) Then
                    entity.IdProyectoArea = reader.GetValue(reader.GetOrdinal("IdProyectoArea"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdProyecto")) Then
                    entity.IdProyecto = reader.GetValue(reader.GetOrdinal("IdProyecto"))
                End If

                If condicion = "Proyecto" Then
                    entity.proyectoEntity.IdProyecto = entity.IdProyecto

                    If Not reader.IsDBNull(reader.GetOrdinal("NombreProyecto")) Then
                        entity.proyectoEntity.Nombre = reader.GetValue(reader.GetOrdinal("NombreProyecto"))
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("CodProyecto")) Then
                        entity.proyectoEntity.Codigo = reader.GetValue(reader.GetOrdinal("CodProyecto"))
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("EstadoProyecto")) Then
                        entity.proyectoEntity.Estado = reader.GetValue(reader.GetOrdinal("EstadoProyecto"))
                    End If

                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function


End Class
