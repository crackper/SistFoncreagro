Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DistribucionCCostosPersonalRepository : Inherits MasterDataAccess : Implements IDistribucionCCostosPersonalRepository

    Public Function GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio(ByVal IdPeriodoLaboral As Integer, ByVal Anio As Integer, ByVal Mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCostosPersonal) Implements IDistribucionCCostosPersonalRepository.GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("Mes", Mes)
        Return SelectObjectFactory(command, 1)
    End Function
    'ok
    Public Function GetDistribucionCCostosPersonalByIdDistribucionCCP(ByVal IdDistribucionCCP As Integer) As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCostosPersonal) Implements IDistribucionCCostosPersonalRepository.GetDistribucionCCostosPersonalByIdDistribucionCCP
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDistribucionCCostosPersonalByIdDistribucionCCP")
        command.Parameters.AddWithValue("IdDistribucionCCP", IdDistribucionCCP)
        Return SelectObjectFactory(command, 1)
    End Function

    Public Function GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio2(ByVal IdPeriodoLaboral As Integer, ByVal anio As String, ByVal mes As String) As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCostosPersonal) Implements IDistribucionCCostosPersonalRepository.GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio2
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio2")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("Anio", anio)
        command.Parameters.AddWithValue("Mes", mes)
        Return SelectObjectFactory(command, 0)
    End Function

    Public Function GetIdDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio(ByVal IdPeriodoLaboral As Integer, ByVal anio As String, ByVal mes As String) As System.Collections.Generic.List(Of BussinessEntities.DistribucionCCostosPersonal) Implements IDistribucionCCostosPersonalRepository.GetIdDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetIdDistribucionCCostosPersonalByIdPeriodoLaboralByMesByAnio")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("Anio", anio)
        command.Parameters.AddWithValue("Mes", mes)
        Return SelectObjectFactory(command, 0)
    End Function

    Public Sub SaveDistribucionCCostosPersonalByCCostosIdDistribucionCCP(ByVal DistribucionCCostospersonal As BussinessEntities.DistribucionCCostosPersonal) Implements IDistribucionCCostosPersonalRepository.SaveDistribucionCCostosPersonalByCCostosIdDistribucionCCP
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDistribucionCCostosPersonalByCCostosIdDistribucionCCP")
        command.Parameters.AddWithValue("IdDistribucionCCP", DistribucionCCostospersonal.IdDistribucionCCP)
        command.Parameters.AddWithValue("IdCCosto", DistribucionCCostospersonal.IdCCosto)
        command.Parameters.AddWithValue("CondicionMonto", DistribucionCCostospersonal.CondicionMonto)
        command.Parameters.AddWithValue("Valor", DistribucionCCostospersonal.Valor)

        MyBase.ExecuteNonQuery(command)

    End Sub

    Public Sub DeleteDISTRIBUCIONCCOSTOSPERSONAL(ByVal IdDistribucionCCP As Integer, ByVal IdCCosto As Integer) Implements IDistribucionCCostosPersonalRepository.DeleteDISTRIBUCIONCCOSTOSPERSONAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDISTRIBUCIONCCOSTOSPERSONAL")
        command.Parameters.AddWithValue("IdDistribucionCCP", IdDistribucionCCP)
        command.Parameters.AddWithValue("IdCCosto", IdCCosto)

        MyBase.ExecuteNonQuery(command)
    End Sub

    'Public Function SaveDistribucionCCostosPersonalByMesAnioByCCostosIdPeriodoLaboral(ByVal DistribucionCCostospersonal As BussinessEntities.DistribucionCCostosPersonal) As Integer Implements IDistribucionCCostosPersonalRepository.SaveDistribucionCCostosPersonalByMesAnioByCCostosIdPeriodoLaboral
    '    Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDistribucionCCostosPersonalByMesAnioByCCostosIdPeriodoLaboral")
    '    command.Parameters.AddWithValue("IdDistribucionCC", DistribucionCCostospersonal.IdDistribucionCC)
    '    command.Parameters.AddWithValue("IdCCosto", DistribucionCCostospersonal.IdCCosto)
    '    command.Parameters.AddWithValue("IdPeriodoLaboral", DistribucionCCostospersonal.IdPeriodoLaboral)
    '    command.Parameters.AddWithValue("AnioIni", DistribucionCCostospersonal.AnioIni)
    '    command.Parameters.AddWithValue("MesIni", DistribucionCCostospersonal.MesIni)
    '    command.Parameters.AddWithValue("CondicionMonto", DistribucionCCostospersonal.CondicionMonto)
    '    command.Parameters.AddWithValue("Valor", DistribucionCCostospersonal.Valor)

    '    'command.Parameters("idCargo").Direction = ParameterDirection.Output

    '    'MyBase.ExecuteNonQuery(command)
    '    Dim i As Int32
    '    Using reader As SqlDataReader = MyBase.ExecuteReader(command)
    '        If reader.Read Then
    '            If Not reader.IsDBNull(0) Then
    '                i = reader.GetValue(0)
    '            End If
    '        Else
    '            i = 0 'command.Parameters("idCargo").Value
    '        End If
    '    End Using


    '    Return i
    '    'command.ExecuteReader(CommandBehavior.SingleRow).Item(0)
    'End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand, ByVal arg As Int32) As List(Of DistribucionCCostosPersonal)
        Dim lista As New List(Of DistribucionCCostosPersonal)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New DistribucionCCostosPersonal

                If Not reader.IsDBNull(reader.GetOrdinal("IdDistribucionCCP")) Then
                    entity.IdDistribucionCCP = reader.GetValue(reader.GetOrdinal("IdDistribucionCCP"))
                End If

                If arg = 1 Then
                    If Not reader.IsDBNull(reader.GetOrdinal("AnioFin")) Then
                        entity.AnioFin = reader.GetValue(reader.GetOrdinal("AnioFin"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("AnioIni")) Then
                        entity.AnioIni = reader.GetValue(reader.GetOrdinal("AnioIni"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("CondicionMonto")) Then
                        entity.CondicionMonto = reader.GetValue(reader.GetOrdinal("CondicionMonto"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("IdCCosto")) Then
                        entity.IdCCosto = reader.GetValue(reader.GetOrdinal("IdCCosto"))
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoLaboral")) Then
                        entity.IdPeriodoLaboral = reader.GetValue(reader.GetOrdinal("IdPeriodoLaboral"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("MesFin")) Then
                        entity.MesFin = reader.GetValue(reader.GetOrdinal("MesFin"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("MesIni")) Then
                        entity.MesIni = reader.GetValue(reader.GetOrdinal("MesIni"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("Valor")) Then
                        entity.Valor = reader.GetValue(reader.GetOrdinal("Valor"))
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("IdCCosto")) Then
                        entity.CCostoEntity = New CCosto
                        entity.CCostoEntity.IdCCosto = reader.GetValue(reader.GetOrdinal("IdCCosto"))

                        If Not reader.IsDBNull(reader.GetOrdinal("codCC")) Then
                            entity.CCostoEntity.Codigo = reader.GetValue(reader.GetOrdinal("codCC"))
                        End If
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("IdElemGasto")) Then
                        entity.ElementoGastoEntity = New ElementoGasto
                        entity.ElementoGastoEntity.IdElemGasto = reader.GetValue(reader.GetOrdinal("IdElemGasto"))

                        If Not reader.IsDBNull(reader.GetOrdinal("nomElementoGasto")) Then
                            entity.ElementoGastoEntity.NomElemGasto = reader.GetValue(reader.GetOrdinal("nomElementoGasto"))
                        End If

                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("IdClasificacion")) Then
                        entity.TipoGastoEntity = New Clasificacion
                        entity.TipoGastoEntity.IdClasificacion = reader.GetValue(reader.GetOrdinal("IdClasificacion"))

                        If Not reader.IsDBNull(reader.GetOrdinal("TipoGasto")) Then
                            entity.TipoGastoEntity.Descripcion = reader.GetValue(reader.GetOrdinal("TipoGasto"))
                        End If
                    End If

                    If Not reader.IsDBNull(reader.GetOrdinal("IdProyecto")) Then
                        entity.ProyectoEntity = New Proyecto
                        entity.ProyectoEntity.IdProyecto = reader.GetValue(reader.GetOrdinal("IdProyecto"))

                        If Not reader.IsDBNull(reader.GetOrdinal("NombreProyecto")) Then
                            entity.ProyectoEntity.Nombre = reader.GetValue(reader.GetOrdinal("NombreProyecto"))
                        End If

                        If Not reader.IsDBNull(reader.GetOrdinal("CodProyecto")) Then
                            entity.ProyectoEntity.Codigo = reader.GetValue(reader.GetOrdinal("CodProyecto"))
                        End If
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
