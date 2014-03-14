Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TelefonoAsignadoRepository : Inherits MasterDataAccess : Implements ITelefonoAsignadoRepository

    Public Function GetAllFromTelefonoAsignado() As System.Collections.Generic.List(Of BussinessEntities.TelefonoAsignado) Implements ITelefonoAsignadoRepository.GetAllFromTelefonoAsignado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTelefonoAsignado")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTelefonoAsignadoByIdAsignacionTelefono(ByVal IdAsignacionTelefono As Integer) As BussinessEntities.TelefonoAsignado Implements ITelefonoAsignadoRepository.GetTelefonoAsignadoByIdAsignacionTelefono
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTelefonoAsignadoByIdAsignacionTelefono")
        command.Parameters.AddWithValue("IdAsignacionTelefono", IdAsignacionTelefono)

        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetTelefonoAsignadoByIdPeriodoLaboralByEstado(ByVal IdPeriodoLaboral As Integer, ByVal estado As Boolean) As System.Collections.Generic.List(Of BussinessEntities.TelefonoAsignado) Implements ITelefonoAsignadoRepository.GetTelefonoAsignadoByIdPeriodoLaboralByEstado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTelefonoAsignadoByIdPeriodoLaboralByEstado")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("estado", estado)
        Return SelectObjectFactory(command)
    End Function

    Public Sub DeleteTelefonoAsignado(ByVal IdAsignacionTelefono As Integer) Implements ITelefonoAsignadoRepository.DeleteTelefonoAsignado

    End Sub

    Public Function SaveTelefonoAsignado(ByVal telefonoAsignado As BussinessEntities.TelefonoAsignado) As Integer Implements ITelefonoAsignadoRepository.SaveTelefonoAsignado
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveTelefonoAsignado")
        command.Parameters.AddWithValue("Estado", telefonoAsignado.Estado)
        command.Parameters.AddWithValue("FechaAsignacion", telefonoAsignado.FechaAsignacion)
        command.Parameters.AddWithValue("IdAsignacionTelefono", telefonoAsignado.IdAsignacionTelefono)
        command.Parameters.AddWithValue("IdPeriodoLaboral", telefonoAsignado.IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdTelefCoorporativo", telefonoAsignado.IdTelefCoorporativo)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TelefonoAsignado)
        Dim lista As New List(Of TelefonoAsignado)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New TelefonoAsignado
                If Not reader.IsDBNull(reader.GetOrdinal("Estado")) Then
                    entity.Estado = reader.GetValue(reader.GetOrdinal("Estado"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("FechaAsignacion")) Then
                    entity.FechaAsignacion = reader.GetValue(reader.GetOrdinal("FechaAsignacion"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdAsignacionTelefono")) Then
                    entity.IdAsignacionTelefono = reader.GetValue(reader.GetOrdinal("IdAsignacionTelefono"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdTelefCoorporativo")) Then
                    entity.IdTelefCoorporativo = reader.GetValue(reader.GetOrdinal("IdTelefCoorporativo"))
                    Dim telefonoCoorporativoRepository As New TelefonoCoorporativoRepository
                    entity.TelefonoCoorporativoEntity = telefonoCoorporativoRepository.GetTelefonoCoorporativoByIdTelefCoorporativo(entity.IdTelefCoorporativo)
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoLaboral")) Then
                    entity.IdPeriodoLaboral = reader.GetValue(reader.GetOrdinal("IdPeriodoLaboral"))
                End If


                lista.Add(entity)
            End While
        End Using
        Return lista
    End Function

End Class
