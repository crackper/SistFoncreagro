Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Imports System.Data.SqlClient
Imports System.Data
Public Class ContratoConvenioRepository : Inherits MasterDataAccess : Implements IContratoConvenioRepository


    Public Sub DeleteContratoConvenio(ByVal idContrato As Integer, ByVal idPeriodoLaboral As Integer) Implements IContratoConvenioRepository.DeleteContratoConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteContratoConvenio")
        command.Parameters.AddWithValue("idContrato", idContrato)
        command.Parameters.AddWithValue("idPeriodoLaboral", idPeriodoLaboral)
        MyBase.ExecuteNonQuery(command)
    End Sub
    ' Eliminar este procedimiento
    Public Function GetAllContratoConvenioActuales(ByVal argContrato As BussinessEntities.ArgumentosContrato) As System.Collections.Generic.List(Of BussinessEntities.ContratoConvenio) Implements IContratoConvenioRepository.GetAllContratoConvenioActuales
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllContratoConveniosActuales")
        Return SelectObjectFactory(command, argContrato)
    End Function
    '....... 

    Public Function GetAllFromContratoConvenio(ByVal argContrato As BussinessEntities.ArgumentosContrato) As System.Collections.Generic.List(Of BussinessEntities.ContratoConvenio) Implements IContratoConvenioRepository.GetAllFromContratoConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromContratoConvenio")
        Return SelectObjectFactory(command, argContrato)
    End Function

    Public Function GetContratoConvenioActualByIdPeriodoLaboral(ByVal idPeriodoLaboral As Integer, ByVal argContrato As BussinessEntities.ArgumentosContrato) As BussinessEntities.ContratoConvenio Implements IContratoConvenioRepository.GetContratoConvenioActualByIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetContratosConveniosActualByIdPeriodoLaboral")
        command.Parameters.AddWithValue("IdPeriodoLaboral", idPeriodoLaboral)
        Return SelectObjectFactory(command, argContrato).SingleOrDefault
    End Function

    Public Function GetContratosConveniosUltimoByIdPeriodoLaboral(ByVal idPeriodoLaboral As Integer, ByVal argContrato As BussinessEntities.ArgumentosContrato) As BussinessEntities.ContratoConvenio Implements IContratoConvenioRepository.GetContratosConveniosUltimoByIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetContratosConveniosUltimoByIdPeriodoLaboral")
        command.Parameters.AddWithValue("IdPeriodoLaboral", idPeriodoLaboral)
        Return SelectObjectFactory(command, argContrato).SingleOrDefault
    End Function
    ' ....
    Public Function GetContratosConveniosActivoByFechaAndIdPeriodoLaboral(ByVal Fecha As Date, ByVal IdPeriodoLaboral As Integer, ByVal argContrato As BussinessEntities.ArgumentosContrato) As BussinessEntities.ContratoConvenio Implements IContratoConvenioRepository.GetContratosConveniosActivoByFechaAndIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetContratosConveniosActivoByFechaAndIdPeriodoLaboral")
        command.Parameters.AddWithValue("Fecha", Fecha)
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        Return SelectObjectFactory(command, argContrato).SingleOrDefault
    End Function
    ' ...

    Public Function GetContratoConvenioIdPeriodoLaboralAndIdContrato(ByVal idPeriodoLaboral As Integer, ByVal idContrato As Integer, ByVal argContrato As BussinessEntities.ArgumentosContrato) As BussinessEntities.ContratoConvenio Implements IContratoConvenioRepository.GetContratoConvenioIdPeriodoLaboralAndIdContrato
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetContratosConveniosActualByIdPeriodoLaboral")
        command.Parameters.AddWithValue("IdPeriodoLaboral", idPeriodoLaboral)
        command.Parameters.AddWithValue("IdContrato", idContrato)
        Return SelectObjectFactory(command, argContrato).SingleOrDefault
    End Function

    Public Function GetContratoConveniosIdPeriodoLaboral(ByVal idPeriodoLaboral As Integer, ByVal argContrato As BussinessEntities.ArgumentosContrato) As System.Collections.Generic.List(Of BussinessEntities.ContratoConvenio) Implements IContratoConvenioRepository.GetContratoConveniosIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetContratoConveniosIdPeriodoLaboral")
        command.Parameters.AddWithValue("IdPeriodoLaboral", idPeriodoLaboral)
        Return SelectObjectFactory(command, argContrato)
    End Function

    Public Function GetUltimaFechaContratoByIdPeriodoLaboral(ByVal fecha As String) As Object Implements IContratoConvenioRepository.GetUltimaFechaContratoByIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetUltimaFechaContratoByIdPeriodoLaboral")
        command.Parameters.AddWithValue("fecha", fecha)
        Dim fecha1 As String = "0"
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    fecha1 = CStr(DateValue(reader.GetValue(0)))
                Else
                    fecha1 = "-1"
                End If
            End If
        End Using
        Return fecha1
    End Function

    Public Function GetArchivoContratosConveniosByIdPeriodoLaboralByIdContrato(ByVal IdPeriodoLaboral As Integer, ByVal IdContrato As Integer) As String Implements IContratoConvenioRepository.GetArchivoContratosConveniosByIdPeriodoLaboralByIdContrato
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetArchivoContratosConveniosByIdPeriodoLaboralByIdContrato")
        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdContrato", IdContrato)

        Dim archivo As String = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    archivo = reader.GetValue(0)
                End If
            End If
        End Using

        Return archivo

    End Function

    Public Function SaveContratosConvenios(ByVal contratoConvenio As BussinessEntities.ContratoConvenio) As Integer Implements IContratoConvenioRepository.SaveContratosConvenios
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveContratosConvenios")

        command.Parameters.AddWithValue("IdContrato", contratoConvenio.IdContrato)
        command.Parameters.AddWithValue("IdPeriodoLaboral", contratoConvenio.IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdTipoContrato", contratoConvenio.IdTipoContrato)
        command.Parameters.AddWithValue("IdGrupoOcupacional", contratoConvenio.IdGrupoOcupacional)
        command.Parameters.AddWithValue("NroContrato", contratoConvenio.NroContrato)
        command.Parameters.AddWithValue("Archivo", contratoConvenio.Archivo)
        command.Parameters.AddWithValue("IdHorario", contratoConvenio.IdHorario)
        command.Parameters.AddWithValue("Estado", contratoConvenio.Estado)
        command.Parameters.AddWithValue("FechaFirma", contratoConvenio.FechaFirma)
        command.Parameters.AddWithValue("FechaInicio", contratoConvenio.FechaInicio)
        command.Parameters.AddWithValue("FechaTermino", contratoConvenio.FechaTermino)
        command.Parameters.AddWithValue("IdCentro", contratoConvenio.IdCentro)
        command.Parameters.AddWithValue("Renovacion", contratoConvenio.Renovacion)

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

    Public Sub UpdateContratoInEstadoByIdCotratoByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Integer, ByVal Estado As String) Implements IContratoConvenioRepository.UpdateContratoInEstadoByIdCotratoByIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateContratoInEstadoByIdCotratoByIdPeriodoLaboral")

        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("Estado", Estado)

        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateArchivoContratos(ByVal IdPeriodoLaboral As Integer, ByVal IdContrato As Integer, ByVal Archivo As String) Implements IContratoConvenioRepository.UpdateArchivoContratos
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateArchivoContratos")

        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdContrato", IdContrato)
        command.Parameters.AddWithValue("Archivo", Archivo)

        MyBase.ExecuteNonQuery(command)

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand, ByVal argContrato As ArgumentosContrato) As List(Of ContratoConvenio)
        Dim lista As New List(Of ContratoConvenio)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New ContratoConvenio

                If Not reader.IsDBNull(reader.GetOrdinal("IdContrato")) Then
                    entity.IdContrato = reader.GetValue(reader.GetOrdinal("IdContrato"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoLaboral")) Then
                    entity.IdPeriodoLaboral = reader.GetValue(reader.GetOrdinal("IdPeriodoLaboral"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoContrato")) Then
                    entity.IdTipoContrato = reader.GetValue(reader.GetOrdinal("IdTipoContrato"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdGrupoOcupacional")) Then
                    entity.IdGrupoOcupacional = reader.GetValue(reader.GetOrdinal("IdGrupoOcupacional"))

                    Dim grupoOcupacionalRepository As New GrupoOcupacionalRepository
                    entity.grupoOcupacionalEntity = grupoOcupacionalRepository.GetGrupoOcupacionalByIdGrupoOcupacional(entity.IdGrupoOcupacional)
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("NroContrato")) Then
                    entity.NroContrato = reader.GetValue(reader.GetOrdinal("NroContrato"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("Archivo")) Then
                    entity.Archivo = reader.GetValue(reader.GetOrdinal("Archivo"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdHorario")) Then
                    entity.IdHorario = reader.GetValue(reader.GetOrdinal("IdHorario"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("Estado")) Then
                    entity.Estado = reader.GetValue(reader.GetOrdinal("Estado"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("FechaFirma")) Then
                    entity.FechaFirma = reader.GetValue(reader.GetOrdinal("FechaFirma"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("FechaInicio")) Then
                    entity.FechaInicio = reader.GetValue(reader.GetOrdinal("FechaInicio"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("FechaTermino")) Then
                    entity.FechaTermino = reader.GetValue(reader.GetOrdinal("FechaTermino"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdCentro")) Then
                    entity.IdCentro = reader.GetValue(reader.GetOrdinal("IdCentro"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("Renovacion")) Then
                    entity.Renovacion = reader.GetValue(reader.GetOrdinal("Renovacion"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("Archivo")) Then
                    entity.Archivo = reader.GetValue(reader.GetOrdinal("Archivo"))
                End If

                If Not argContrato Is Nothing Then
                    If Not argContrato.DevolverCondicionesContratoActual Is Nothing Then
                        Dim contratoCondicionesRepository As New CondicionesContratoRepository
                        entity.condicionesActualesDeContrato = contratoCondicionesRepository.GetCondicionesContratoActualByIdContratoByIdPeriodo(entity.IdContrato, entity.IdPeriodoLaboral, argContrato.DevolverCondicionesContratoActual)
                    End If
                    If argContrato.DevolverHorarioActual Then
                        'devolver horario
                    End If
                    If argContrato.DevolverPeriodoLaboral Then
                        'devolver periodo laboral
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
