Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoPlanillaRepository : Inherits MasterDataAccess : Implements ITipoPlanillaRepository

    Public Sub DeleteTIPOPLANILLA(ByVal IdTipoPlanilla As Integer) Implements ITipoPlanillaRepository.DeleteTIPOPLANILLA
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteTIPOPLANILLA")
        command.Parameters.AddWithValue("IdTipoPlanilla", IdTipoPlanilla)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromTIPOPLANILLA() As System.Collections.Generic.List(Of BussinessEntities.TipoPlanilla) Implements ITipoPlanillaRepository.GetAllFromTIPOPLANILLA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOPLANILLA")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTIPOPLANILLAByIdTipoPlanilla(ByVal IdTipoPlanilla As Integer) As BussinessEntities.TipoPlanilla Implements ITipoPlanillaRepository.GetTIPOPLANILLAByIdTipoPlanilla
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOPLANILLAByIdTipoPlanilla")
        command.Parameters.AddWithValue("IdTipoPlanilla", IdTipoPlanilla)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveTIPOPLANILLA(ByVal tipoPlanilla As BussinessEntities.TipoPlanilla) As Integer Implements ITipoPlanillaRepository.SaveTIPOPLANILLA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveTIPOPLANILLA")
        command.Parameters.AddWithValue("IdTipoPlanilla", tipoPlanilla.IdTipoPlanilla)
        command.Parameters.AddWithValue("NombrePlanilla", tipoPlanilla.NombrePlanilla)
        command.Parameters.AddWithValue("Tipo", tipoPlanilla.tipo)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoPlanilla)
        Dim lista As New List(Of TipoPlanilla)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New TipoPlanilla
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoPlanilla")) Then
                    entity.IdTipoPlanilla = reader.GetValue(reader.GetOrdinal("IdTipoPlanilla"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("NombrePlanilla")) Then
                    entity.NombrePlanilla = reader.GetValue(reader.GetOrdinal("NombrePlanilla"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Tipo")) Then
                    entity.Tipo = reader.GetValue(reader.GetOrdinal("Tipo"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function


End Class
