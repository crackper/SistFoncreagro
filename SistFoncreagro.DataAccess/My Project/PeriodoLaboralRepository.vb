Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class PeriodoLaboralRepository : Inherits MasterDataAccess : Implements IPeriodoLaboralRepository

    Public Sub DeletePeriodoLaboral(ByVal IdperiodoLaboral As Int32) Implements IPeriodoLaboralRepository.DeletePeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletePeriodoLaboral")
        command.Parameters.AddWithValue("idPeriodoLaboral", IdperiodoLaboral)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateTelefonosPeriodoLaboral(ByVal IdPeriodoLaboral As Integer, ByVal EmailCoorporativo As String, ByVal TelefCoorp As String) Implements IPeriodoLaboralRepository.UpdateTelefonosPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateTelefonosPeriodoLaboral")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("EmailCoorporativo", EmailCoorporativo)
        command.Parameters.AddWithValue("TelefCoorp", TelefCoorp)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromPERIODOLABORAL(ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralRepository.GetAllFromPERIODOLABORAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllContratoConveniosActuales")
        Return SelectObjectFactory(command, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALActualActivoByIdPersonal(ByVal IdPersonal As Integer, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As BussinessEntities.PeriodoLaboral Implements IPeriodoLaboralRepository.GetPERIODOLABORALActualActivoByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERIODOLABORALActualActivoByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Return SelectObjectFactory(command, argPeriodoLaboral).SingleOrDefault
    End Function

    Public Function GetPERIODOLABORALAValidosByFecha(ByVal Fecha As Date, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralRepository.GetPERIODOLABORALAValidosByFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERIODOLABORALAValidosByFecha")
        command.Parameters.AddWithValue("Fecha", Fecha)
        Return SelectObjectFactory(command, argPeriodoLaboral)
    End Function
    '...
    Public Function GetPERIODOLABORALAValidosByFechaAndByIdPersonal(ByVal Fecha As Date, ByVal IdPersonal As Integer, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As BussinessEntities.PeriodoLaboral Implements IPeriodoLaboralRepository.GetPERIODOLABORALAValidosByFechaAndByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERIODOLABORALActualActivoByIdPersonal")
        command.Parameters.AddWithValue("Fecha", Fecha)
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Return SelectObjectFactory(command, argPeriodoLaboral).SingleOrDefault
    End Function
    '...

    Public Function GetPERIODOLABORALAUltimoByIdPersonal(ByVal IdPersonal As Integer, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As BussinessEntities.PeriodoLaboral Implements IPeriodoLaboralRepository.GetPERIODOLABORALAUltimoByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERIODOLABORALAUltimoByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Return SelectObjectFactory(command, argPeriodoLaboral).SingleOrDefault
    End Function

    Public Function GetPERIODOLABORALByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Integer, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As BussinessEntities.PeriodoLaboral Implements IPeriodoLaboralRepository.GetPERIODOLABORALByIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERIODOLABORALByIdPeriodoLaboral")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        Return SelectObjectFactory(command, argPeriodoLaboral).SingleOrDefault
    End Function

    Public Function GetPERIODOLABORALByIdPersonal(ByVal IdPersonal As Integer, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralRepository.GetPERIODOLABORALByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERIODOLABORALByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Return SelectObjectFactory(command, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALDeBajaPorLiquidar(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralRepository.GetPERIODOLABORALDeBajaPorLiquidar
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERIODOLABORALByIdPersonal")
        command.Parameters.AddWithValue("Fecha1", Fecha1)
        command.Parameters.AddWithValue("Fecha2", Fecha2)
        Return SelectObjectFactory(command, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALLiquidadosPendientesDePago(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralRepository.GetPERIODOLABORALLiquidadosPendientesDePago
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERIODOLABORALLiquidadosPendientesDePago")
        command.Parameters.AddWithValue("Fecha1", Fecha1)
        command.Parameters.AddWithValue("Fecha2", Fecha2)
        Return SelectObjectFactory(command, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALLiquidadosPorRangoFecha(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralRepository.GetPERIODOLABORALLiquidadosPorRangoFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERIODOLABORALLiquidadosPorRangoFecha")
        command.Parameters.AddWithValue("Fecha1", Fecha1)
        command.Parameters.AddWithValue("Fecha2", Fecha2)
        Return SelectObjectFactory(command, argPeriodoLaboral)
    End Function

    Public Function GetUltimaFechcaFinPERIODOLABORALByIdPersonal(ByVal idPersonal As Integer) As String Implements IPeriodoLaboralRepository.GetUltimaFechcaFinPERIODOLABORALByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetUltimaFechcaFinPERIODOLABORALByIdPersonal")
        command.Parameters.AddWithValue("idPersonal", idPersonal)
        Dim fecha As String = "0"
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    fecha = CStr(DateValue(reader.GetValue(0)))
                Else
                    fecha = "-1"
                End If
            End If
        End Using
        Return fecha
    End Function

    Public Function SavePERIODOLABORAL(ByVal periodoLaboral As BussinessEntities.PeriodoLaboral) As Integer Implements IPeriodoLaboralRepository.SavePERIODOLABORAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePERIODOLABORAL")

        command.Parameters.AddWithValue("IdPeriodoLaboral", periodoLaboral.IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdPersonal", periodoLaboral.IdPersonal)
        command.Parameters.AddWithValue("IdCategoria", periodoLaboral.IdCategoria)
        command.Parameters.AddWithValue("IdTipoTrabajador", periodoLaboral.IdTipoTrabajador)
        command.Parameters.AddWithValue("FechaInicio", periodoLaboral.FechaInicio)
        command.Parameters.AddWithValue("FechaCese", periodoLaboral.FechaCese)
        command.Parameters.AddWithValue("IdDeclarante", periodoLaboral.IdDeclarante)
        command.Parameters.AddWithValue("NroFotocheck", periodoLaboral.NroFotocheck)
        command.Parameters.AddWithValue("EmailCoorporativo", periodoLaboral.EmailCoorporativo)
        command.Parameters.AddWithValue("Estado", periodoLaboral.Estado)
        command.Parameters.AddWithValue("IdMotivoFinDePeriodo", periodoLaboral.IdMotivoFinDePeriodo)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand, ByVal argPeriodoLaboral As ArgumentosPeriodolaboral) As List(Of PeriodoLaboral)
        Dim lista As New List(Of PeriodoLaboral)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New PeriodoLaboral

                If Not reader.IsDBNull(reader.GetOrdinal("IdperiodoLaboral")) Then
                    entity.IdPeriodoLaboral = reader.GetValue(reader.GetOrdinal("IdperiodoLaboral"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdPersonal")) Then
                    entity.IdPersonal = reader.GetValue(reader.GetOrdinal("IdPersonal"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdCategoria")) Then
                    entity.IdCategoria = reader.GetValue(reader.GetOrdinal("IdCategoria"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoTrabajador")) Then
                    entity.IdTipoTrabajador = reader.GetValue(reader.GetOrdinal("IdTipoTrabajador"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("FechaInicio")) Then
                    entity.FechaInicio = reader.GetValue(reader.GetOrdinal("FechaInicio"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("FechaCese")) Then
                    entity.FechaCese = reader.GetValue(reader.GetOrdinal("FechaCese"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdDeclarante")) Then
                    entity.IdDeclarante = reader.GetValue(reader.GetOrdinal("IdDeclarante"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("NroFotocheck")) Then
                    entity.NroFotocheck = reader.GetValue(reader.GetOrdinal("NroFotocheck"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("EmailCoorporativo")) Then
                    entity.EmailCoorporativo = reader.GetValue(reader.GetOrdinal("EmailCoorporativo"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("Estado")) Then
                    entity.Estado = reader.GetValue(reader.GetOrdinal("Estado"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdMotivoFinDePeriodo")) Then
                    entity.IdMotivoFinDePeriodo = reader.GetValue(reader.GetOrdinal("IdMotivoFinDePeriodo"))
                End If


                If Not argPeriodoLaboral Is Nothing Then
                    If argPeriodoLaboral.DevolverCategoria Then
                        'Dim tipotrabajadorRepository As New TipoTrabajadorRepository
                        'entity.tipoTrabajador = tipotrabajadorRepository.GetTipoTrabajadorByIdTipoTrabajadorIdCategoria(entity.IdTipoTrabajador, entity.IdCategoria)
                    End If

                    If Not argPeriodoLaboral.DevolverContratoActual Is Nothing Then
                        Dim contratoRepository As New ContratoConvenioRepository
                        entity.contratoActual = contratoRepository.GetContratoConvenioActualByIdPeriodoLaboral(entity.IdPeriodoLaboral, argPeriodoLaboral.DevolverContratoActual)
                    End If

                    If argPeriodoLaboral.DevolverListaContratosConvenios Then
                        ' devolver lista de contratos
                    End If

                    If argPeriodoLaboral.DevolverListaTelefono Then
                        'devolver lista de teléfonos
                    End If

                    If argPeriodoLaboral.DevolverMotivoFinDePeriodo Then
                        'devolver motivo de fin de periodo laboral.
                    End If

                    If Not argPeriodoLaboral.DevolverPersonal Is Nothing Then
                        ' devolver personal
                    End If

                    If argPeriodoLaboral.DevolverTipoTrabajador Then
                        Dim tipoTrabajadorRepository As New TipoTrabajadorRepository
                        entity.tipoTrabajador = tipoTrabajadorRepository.GetTipoTrabajadorByIdTipoTrabajadorIdCategoria(entity.IdTipoTrabajador, entity.IdCategoria)
                    End If
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function

End Class
