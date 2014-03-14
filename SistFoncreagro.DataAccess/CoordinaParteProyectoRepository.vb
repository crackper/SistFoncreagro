Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class CoordinaParteProyectoRepository : Inherits MasterDataAccess : Implements ICoordinaProyectoRepository

    Public Function GetCoordinaParteProyectoByIdArea(ByVal IdArea As Integer) As System.Collections.Generic.List(Of CoordinaParteProyecto) Implements ICoordinaProyectoRepository.GetCoordinaParteProyectoByIdArea
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCoordinaParteProyectoByIdArea")
        command.Parameters.AddWithValue("IdArea", IdArea)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCoordinaParteProyectoByIdProyectoVigentes(ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of CoordinaParteProyecto) Implements ICoordinaProyectoRepository.GetCoordinaParteProyectoByIdProyectoVigentes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCoordinaParteProyectoByIdProyectoVigentes")
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        Return SelectObjectFactory(command)
    End Function

    Public Sub DeleteCoordinaParteProyecto(ByVal IdCoordinaProyecto As Integer) Implements ICoordinaProyectoRepository.DeleteCoordinaParteProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCoordinaParteProyecto")
        command.Parameters.AddWithValue("IdCoordinaProyecto", IdCoordinaProyecto)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function SaveCoordinaParteProyecto(ByVal coordinaParteProyecto As BussinessEntities.CoordinaParteProyecto) As Integer Implements ICoordinaProyectoRepository.SaveCoordinaParteProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCoordinaParteProyecto")
        command.Parameters.AddWithValue("IdArea", coordinaParteProyecto.IdArea)
        command.Parameters.AddWithValue("IdCoordinaProyecto", coordinaParteProyecto.IdCoordinaProyecto)
        command.Parameters.AddWithValue("IdProyecto", coordinaParteProyecto.IdProyecto)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of CoordinaParteProyecto)
        Dim lista As New List(Of CoordinaParteProyecto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New CoordinaParteProyecto
                If Not reader.IsDBNull(reader.GetOrdinal(".IdArea")) Then
                    entity.IdArea = reader.GetValue(reader.GetOrdinal(".IdArea"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdCoordinaProyecto")) Then
                    entity.IdCoordinaProyecto = reader.GetValue(reader.GetOrdinal("IdCoordinaProyecto"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdProyecto")) Then
                    entity.IdProyecto = reader.GetValue(reader.GetOrdinal("IdProyecto"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function
End Class
