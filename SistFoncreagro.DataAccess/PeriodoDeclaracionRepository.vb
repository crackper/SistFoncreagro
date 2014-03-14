Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class PeriodoDeclaracionRepository : Inherits MasterDataAccess : Implements IPeriodoDeclaracionRepository

    Public Function GetAllFromPeriodoDeclaracion() As System.Collections.Generic.List(Of BussinessEntities.PeriodoDeclaracion) Implements IPeriodoDeclaracionRepository.GetAllFromPeriodoDeclaracion
        Dim command As SqlCommand =
       MyBase.CreateSPCommand("GetAllFromPeriodoDeclaracion")

        Return SelectObjectFactory(command)
    End Function

    Public Function GetPeriodoDeclaracionByIdPeriodoDeclaracion(ByVal idPeriodoDeclaracion As Integer) As BussinessEntities.PeriodoDeclaracion Implements IPeriodoDeclaracionRepository.GetPeriodoDeclaracionByIdPeriodoDeclaracion
        Dim command As SqlCommand =
      MyBase.CreateSPCommand("GetPeriodoDeclaracionByIdPeriodoDeclaracion")
        command.Parameters.AddWithValue("IdPeriodoDeclaracion", idPeriodoDeclaracion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SavePeriodoDeclaracion(ByVal periodoDeclaracion As BussinessEntities.PeriodoDeclaracion) As Integer Implements IPeriodoDeclaracionRepository.SavePeriodoDeclaracion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePeriodoDeclaracion")
        command.Parameters.AddWithValue("IdPeriodoDeclaracion", periodoDeclaracion.IdPeriodoDeclaracion)
        command.Parameters.AddWithValue("CodPeriodo", periodoDeclaracion.CodPeriodo)
        command.Parameters.AddWithValue("Mes", periodoDeclaracion.Mes)
        command.Parameters.AddWithValue("Anio", periodoDeclaracion.Anio)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of PeriodoDeclaracion)
        Dim lista As New List(Of PeriodoDeclaracion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New PeriodoDeclaracion
                If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoDeclaracion")) Then
                    entity.IdPeriodoDeclaracion = reader.GetValue(reader.GetOrdinal("IdPeriodoDeclaracion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("CodPeriodo")) Then
                    entity.CodPeriodo = reader.GetValue(reader.GetOrdinal("CodPeriodo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Anio")) Then
                    entity.Anio = reader.GetValue(reader.GetOrdinal("Anio"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Mes")) Then
                    entity.Mes = reader.GetValue(reader.GetOrdinal("Mes"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

End Class
