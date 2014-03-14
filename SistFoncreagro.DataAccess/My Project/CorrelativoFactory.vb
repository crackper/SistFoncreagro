Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class CorrelativoFactory : Inherits MasterDataAccess : Implements ICorrelativoFactory

    Public Function GetCorrelativoByDocumentoByAnio(ByVal Documento As String, ByVal Anio As String) As BussinessEntities.Correlativo Implements ICorrelativoFactory.GetCorrelativoByDocumentoByAnio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCorrelativoByDocumentoByAnio")
        command.Parameters.AddWithValue("Documento", Documento)
        command.Parameters.AddWithValue("Anio", Anio)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub UpdateCorrelativoNroCorrelativo(ByVal IdCorrelativo As Integer, ByVal NroCorrelativo As Integer) Implements ICorrelativoFactory.UpdateCorrelativoNroCorrelativo
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateCorrelativoNroCorrelativo")
        command.Parameters.AddWithValue("IdCorrelativo", IdCorrelativo)
        command.Parameters.AddWithValue("NroCorrelativo", NroCorrelativo)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function SaveCorrelativo(ByVal Correlativo As BussinessEntities.Correlativo) As Integer Implements ICorrelativoFactory.SaveCorrelativo
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCorrelativo")
        command.Parameters.AddWithValue("IdCorrelativo", Correlativo.IdCorrelativo)
        command.Parameters.AddWithValue("Documento", Correlativo.Documento)
        command.Parameters.AddWithValue("NroCorrelativo", Correlativo.NroCorrelativo)
        command.Parameters.AddWithValue("Prefijo", Correlativo.Prefijo)
        command.Parameters.AddWithValue("Posfijo", Correlativo.Posfijo)
        command.Parameters.AddWithValue("Anio", Correlativo.Anio)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Correlativo)
        Dim lista As New List(Of Correlativo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New Correlativo
                If Not reader.IsDBNull(reader.GetOrdinal("IdCorrelativo")) Then
                    entity.IdCorrelativo = reader.GetValue(reader.GetOrdinal("IdCorrelativo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Documento")) Then
                    entity.Documento = reader.GetValue(reader.GetOrdinal("Documento"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("NroCorrelativo")) Then
                    entity.NroCorrelativo = reader.GetValue(reader.GetOrdinal("NroCorrelativo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Prefijo")) Then
                    entity.Prefijo = reader.GetValue(reader.GetOrdinal("Prefijo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Posfijo")) Then
                    entity.Posfijo = reader.GetValue(reader.GetOrdinal("Posfijo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Anio")) Then
                    entity.Anio = reader.GetValue(reader.GetOrdinal("Anio"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function



End Class
