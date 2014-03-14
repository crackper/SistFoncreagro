Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class RolAsignadoRepository : Inherits MasterDataAccess : Implements IRolAsignadoRepository

    Public Sub DeleteROLASIGNADO(ByVal IdRolAsignado As Integer, ByVal Idcondicion As Integer, ByVal IdContrato As Integer, ByVal IdPeriodo As Integer) Implements IRolAsignadoRepository.DeleteROLASIGNADO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteROLASIGNADO")
        command.Parameters.AddWithValue("IdRolAsignado", IdRolAsignado)
        command.Parameters.AddWithValue("Idcondicion", Idcondicion)
        command.Parameters.AddWithValue("IdContrato", IdContrato)
        command.Parameters.AddWithValue("IdPeriodo", IdPeriodo)

        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetRolAsignadoByActivoByIdCondicionByContratoByIdPeriodo(ByVal Activo As Boolean, ByVal IdCondicion As Integer, ByVal IdContrato As Integer, ByVal IdPeriodo As Integer) As System.Collections.Generic.List(Of BussinessEntities.RolAsignado) Implements IRolAsignadoRepository.GetRolAsignadoByActivoByIdCondicionByContratoByIdPeriodo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRolAsignadoByActivoByIdCondicionByContratoByIdPeriodo")
        command.Parameters.AddWithValue("Activo", Activo)
        command.Parameters.AddWithValue("IdCondicion", IdCondicion)
        command.Parameters.AddWithValue("IdContrato", IdContrato)
        command.Parameters.AddWithValue("IdPeriodo", IdPeriodo)

        Return SelectObjectFactory(command)
    End Function

    Public Function GetRolAsignadoValidoByFechaByIdCondicionByContratoByIdPeriodo(ByVal Fecha As Date, ByVal IdCondicion As Integer, ByVal IdContrato As Integer, ByVal IdPeriodo As Integer) As System.Collections.Generic.List(Of BussinessEntities.RolAsignado) Implements IRolAsignadoRepository.GetRolAsignadoValidoByFechaByIdCondicionByContratoByIdPeriodo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRolAsignadoValidoByFechaByIdCondicionByContratoByIdPeriodo")
        command.Parameters.AddWithValue("Fecha", Fecha)
        command.Parameters.AddWithValue("IdCondicion", IdCondicion)
        command.Parameters.AddWithValue("IdContrato", IdContrato)
        command.Parameters.AddWithValue("IdPeriodo", IdPeriodo)

        Return SelectObjectFactory(command)
    End Function

    Public Function GetRolAsignadoValidoByFechaByIdRol(ByVal Fecha As Date, ByVal IdRol As Integer) As System.Collections.Generic.List(Of BussinessEntities.RolAsignado) Implements IRolAsignadoRepository.GetRolAsignadoValidoByFechaByIdRol
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRolAsignadoValidoByFechaByIdRol")
        command.Parameters.AddWithValue("Fecha", Fecha)
        command.Parameters.AddWithValue("IdRol", IdRol)

        Return SelectObjectFactory(command)
    End Function

    Public Function SaveRolAsignado(ByVal rolAsignado As RolAsignado) As Integer Implements IRolAsignadoRepository.SaveRolAsignado
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveRolAsignado")
        command.Parameters.AddWithValue("IdRolAsignado", rolAsignado.IdRolAsignado)
        command.Parameters.AddWithValue("IdRol", rolAsignado.IdRol)
        command.Parameters.AddWithValue("IdCondicion", rolAsignado.IdCondicion)
        command.Parameters.AddWithValue("IdContrato", rolAsignado.IdContrato)
        command.Parameters.AddWithValue("IdPeriodoLaboral", rolAsignado.IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdProyecto", rolAsignado.IdProyecto)
        command.Parameters.AddWithValue("FechaAsignacion", rolAsignado.FechaAsignacion)
        command.Parameters.AddWithValue("FechaTermino", rolAsignado.FechaTermino)
        command.Parameters.AddWithValue("Activo", rolAsignado.Activo)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of RolAsignado)
        Dim lista As New List(Of RolAsignado)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New RolAsignado
                If Not reader.IsDBNull(reader.GetOrdinal("IdRolAsignado")) Then
                    entity.IdRolAsignado = reader.GetValue(reader.GetOrdinal("IdRolAsignado"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdRol")) Then
                    entity.IdRol = reader.GetValue(reader.GetOrdinal("IdRol"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdCondicion")) Then
                    entity.IdCondicion = reader.GetValue(reader.GetOrdinal("IdCondicion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdContrato")) Then
                    entity.IdContrato = reader.GetValue(reader.GetOrdinal("IdContrato"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoLaboral")) Then
                    entity.IdPeriodoLaboral = reader.GetValue(reader.GetOrdinal("IdPeriodoLaboral"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdProyecto")) Then
                    entity.IdProyecto = reader.GetValue(reader.GetOrdinal("IdProyecto"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FechaAsignacion")) Then
                    entity.FechaAsignacion = reader.GetValue(reader.GetOrdinal("FechaAsignacion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FechaTermino")) Then
                    entity.FechaTermino = reader.GetValue(reader.GetOrdinal("FechaTermino"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Activo")) Then
                    entity.Activo = reader.GetValue(reader.GetOrdinal("Activo"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

End Class
