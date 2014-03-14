Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class RequisitoAdicionalRepository : Inherits MasterDataAccess : Implements IRequisitoAdicionalRepository

    Public Function GetAllFromREQUISITOADICIONAL() As System.Collections.Generic.List(Of BussinessEntities.RequisitoAdicional) Implements IRequisitoAdicionalRepository.GetAllFromREQUISITOADICIONAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromREQUISITOADICIONAL")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetREQUISITOADICIONALByIdPosicion(ByVal IdPosicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.RequisitoAdicional) Implements IRequisitoAdicionalRepository.GetREQUISITOADICIONALByIdPosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetREQUISITOADICIONALByIdPosicion")
        command.Parameters.AddWithValue("IdPosicion", IdPosicion)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetREQUISITOADICIONALByIdRequisitoAndIdPosicion(ByVal IdRequisito As Integer, ByVal IdPosicion As Integer) As BussinessEntities.RequisitoAdicional Implements IRequisitoAdicionalRepository.GetREQUISITOADICIONALByIdRequisitoAndIdPosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetREQUISITOADICIONALByIdRequisitoAndIdPosicion")
        command.Parameters.AddWithValue("IdRequisito", IdRequisito)
        command.Parameters.AddWithValue("IdPosicion", IdPosicion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveREQUISITOADICIONAL(ByVal RequisitoAdicional As BussinessEntities.RequisitoAdicional) As Integer Implements IRequisitoAdicionalRepository.SaveREQUISITOADICIONAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveREQUISITOADICIONAL")
        command.Parameters.AddWithValue("IdRequisitoAdicional", RequisitoAdicional.IdRequisitoAdicional)
        command.Parameters.AddWithValue("IdPosicion", RequisitoAdicional.IdPosicion)
        command.Parameters.AddWithValue("Requisito", RequisitoAdicional.Requisito)
        command.Parameters.AddWithValue("Calificacion", RequisitoAdicional.Calificacion)

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

    Public Sub DeleteREQUISITOADICIONAL(ByVal idRequisito As Integer) Implements IRequisitoAdicionalRepository.DeleteREQUISITOADICIONAL

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of RequisitoAdicional)
        Dim lista As New List(Of RequisitoAdicional)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New RequisitoAdicional
                If Not reader.IsDBNull(reader.GetOrdinal("IdPosicion")) Then
                    entity.IdPosicion = reader.GetValue(reader.GetOrdinal("IdPosicion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdRequisitoAdicional")) Then
                    entity.IdRequisitoAdicional = reader.GetValue(reader.GetOrdinal("IdRequisitoAdicional"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Requisito")) Then
                    entity.Requisito = reader.GetValue(reader.GetOrdinal("Requisito"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Calificacion")) Then
                    entity.Calificacion = reader.GetValue(reader.GetOrdinal("Calificacion"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function
End Class
