Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class PosicionCCostoRepository : Inherits MasterDataAccess : Implements IPosicionCCostosRepository

    Public Function GetPosicionesCCostosValidasByFechaByIdCCostos(ByVal Fecha As DateTime, ByVal IdCCosto As Int32) As System.Collections.Generic.List(Of BussinessEntities.PosicionCentroCosto) Implements IPosicionCCostosRepository.GetPosicionesCCostosValidasByFechaByIdCCostos
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPosicionesCCostosValidasByFechaByIdCCostos")
        command.Parameters.AddWithValue("Fecha", Fecha)
        command.Parameters.AddWithValue("IdCCosto", IdCCosto)
        Return SelectObjectFactory(command)
    End Function

    Public Function SavePosicionCCosto(ByVal posicionCCostos As BussinessEntities.PosicionCentroCosto) As Int32 Implements IPosicionCCostosRepository.SavePosicionCCosto
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePosicionCCosto")

        command.Parameters.AddWithValue("IdGrupoOcupacional", posicionCCostos.IdPosicionCCostos)
        command.Parameters.AddWithValue("IdContrato", posicionCCostos.IdCCosto)
        command.Parameters.AddWithValue("IdPeriodoLaboral", posicionCCostos.IdPosicion)
        command.Parameters.AddWithValue("IdTipoContrato", posicionCCostos.FechaAsignacion)
        command.Parameters.AddWithValue("NroContrato", posicionCCostos.MontoFijo)
        command.Parameters.AddWithValue("Archivo", posicionCCostos.Porcentaje)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of PosicionCentroCosto)
        Dim lista As New List(Of PosicionCentroCosto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New PosicionCentroCosto
                If Not reader.IsDBNull(reader("IdPosicion")) Then
                    entity.IdPosicion = Convert.ToInt32(reader("IdPosicion"))
                End If
                If Not reader.IsDBNull(reader("IdCCosto")) Then
                    entity.IdCCosto = Convert.ToInt32(reader("IdCCosto"))
                End If
                If Not reader.IsDBNull(reader("FechaAsignacion")) Then
                    entity.FechaAsignacion = Convert.ToDateTime(reader("FechaAsignacion"))
                End If
                If Not reader.IsDBNull(reader("Porcentaje")) Then
                    entity.Porcentaje = Convert.ToDecimal(reader("Porcentaje"))
                End If
                If Not reader.IsDBNull(reader("MontoFijo")) Then
                    entity.MontoFijo = Convert.ToDecimal(reader("MontoFijo"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function
End Class
