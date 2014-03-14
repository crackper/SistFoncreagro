Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class LimitesRCRepository : Inherits MasterDataAccess : Implements ILimiteRCRepository

    Public Sub DeleteLIMITESRC(ByVal IdLimitesRC As Integer) Implements ILimiteRCRepository.DeleteLIMITESRC
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteLIMITESRC")
        command.Parameters.AddWithValue("IdLimitesRC", IdLimitesRC)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetLimiteRCByIdDetalleConcepto(ByVal IdDetalleConcepto As Integer) As System.Collections.Generic.List(Of BussinessEntities.LimitesRC) Implements ILimiteRCRepository.GetLimiteRCByIdDetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetLimiteRCByIdDetalleConcepto")
        command.Parameters.AddWithValue("IdDetalleConcepto", IdDetalleConcepto)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveLimeteRC(ByVal limiteRC As BussinessEntities.LimitesRC) As Integer Implements ILimiteRCRepository.SaveLimeteRC
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveLimeteRC")
        command.Parameters.AddWithValue("IdLimitesRC", limiteRC.IdLimitesRC)
        command.Parameters.AddWithValue("IdDetalleConcepto", limiteRC.IdDetalleConcepto)
        command.Parameters.AddWithValue("FactorLimiteInf", limiteRC.FactorLimiteInf)
        command.Parameters.AddWithValue("FactorLimiteSup", limiteRC.FactorLimiteSup)
        command.Parameters.AddWithValue("LimiteInferior", limiteRC.LimiteInferior)
        command.Parameters.AddWithValue("LimiteSuperior", limiteRC.LimiteSuperior)
        command.Parameters.AddWithValue("Intervalo", limiteRC.Intervalo)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of LimitesRC)
        Dim lista As New List(Of LimitesRC)
        Dim parametroLaboralRepository As New ParametroLaboralRepository
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New LimitesRC
                If Not reader.IsDBNull(reader.GetOrdinal("IdDetalleConcepto")) Then
                    entity.IdDetalleConcepto = reader.GetValue(reader.GetOrdinal("IdDetalleConcepto"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdLimitesRC")) Then
                    entity.IdLimitesRC = reader.GetValue(reader.GetOrdinal("IdLimitesRC"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FactorLimiteSup")) Then
                    entity.FactorLimiteSup = reader.GetValue(reader.GetOrdinal("FactorLimiteSup"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FactorLimiteInf")) Then
                    entity.FactorLimiteInf = reader.GetValue(reader.GetOrdinal("FactorLimiteInf"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("LimiteSuperior")) Then
                    entity.LimiteSuperior = reader.GetValue(reader.GetOrdinal("LimiteSuperior"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("LimiteInferior")) Then
                    entity.LimiteInferior = reader.GetValue(reader.GetOrdinal("LimiteInferior"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Intervalo")) Then
                    entity.Intervalo = reader.GetValue(reader.GetOrdinal("Intervalo"))
                End If

                If Not entity.LimiteInferior Is Nothing Then
                    entity.DescripcionLimiteInf = parametroLaboralRepository.GetParametrosLaboralesByIdParametroLab(entity.LimiteInferior).Descripcion
                End If

                If Not entity.LimiteSuperior Is Nothing Then
                    entity.DescripcionLimiteSup = parametroLaboralRepository.GetParametrosLaboralesByIdParametroLab(entity.LimiteSuperior).Descripcion
                End If
                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function
End Class
