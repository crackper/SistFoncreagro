Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class CondicionesContratoRepository : Inherits MasterDataAccess : Implements ICondicionesContratoRepository

    Public Sub DeleteCondicionContrato(ByVal idCondicion As Integer, ByVal idContrato As Integer, ByVal idPeriodoLaboral As Integer) Implements ICondicionesContratoRepository.DeleteCondicionContrato
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCondicionContrato")
        command.Parameters.AddWithValue("IdCondicion", idCondicion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromCondicionesContrato(ByVal argCondContrato As BussinessEntities.ArgumentosCondicionesContrato) As System.Collections.Generic.List(Of BussinessEntities.CondicionesContrato) Implements ICondicionesContratoRepository.GetAllFromCondicionesContrato
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCARGO")
        Return SelectObjectFactory(command, argCondContrato)
    End Function

    Public Function GetAllCondicionesContratoActual(ByVal argCondContrato As BussinessEntities.ArgumentosCondicionesContrato) As System.Collections.Generic.List(Of BussinessEntities.CondicionesContrato) Implements ICondicionesContratoRepository.GetAllCondicionesContratoActual
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllCondicionesContratoActual")
        Return SelectObjectFactory(command, argCondContrato)
    End Function
    '...
    Public Function GetCondicionesContratoValidasByFechaByIdContratoByIdPeriodo(ByVal Fecha As Date, ByVal IdContrato As Integer, ByVal IdPeriodoLaboral As Integer, ByVal argCondContrato As ArgumentosCondicionesContrato) As BussinessEntities.CondicionesContrato Implements ICondicionesContratoRepository.GetCondicionesContratoValidasByFechaByIdContratoByIdPeriodo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCondicionesContratoActualByIdContratoByIdPeriodo")
        command.Parameters.AddWithValue("IdContrato", IdContrato)
        command.Parameters.AddWithValue("IdperiodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("Fecha", Fecha)
        Return SelectObjectFactory(command, argCondContrato).SingleOrDefault
    End Function
    '...
    Public Function GetCondicionesContratoActualByIdContratoByIdPeriodo(ByVal idContratoConvenio As Integer, ByVal idPeriodoLaboral As Integer, ByVal argCondContrato As BussinessEntities.ArgumentosCondicionesContrato) As BussinessEntities.CondicionesContrato Implements ICondicionesContratoRepository.GetCondicionesContratoActualByIdContratoByIdPeriodo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCondicionesContratoActualByIdContratoByIdPeriodo")
        command.Parameters.AddWithValue("IdContrato", idContratoConvenio)
        command.Parameters.AddWithValue("IdperiodoLaboral", idPeriodoLaboral)
        Return SelectObjectFactory(command, argCondContrato).SingleOrDefault
    End Function

    Public Function GetCondicionesContratoByIdCondicionIdContratoByIdPeriodoLaboral(ByVal idCondicion As Integer, ByVal idContrato As Integer, ByVal idPeriodoLaboral As Integer, ByVal argCondContrato As BussinessEntities.ArgumentosCondicionesContrato) As BussinessEntities.CondicionesContrato Implements ICondicionesContratoRepository.GetCondicionesContratoByIdCondicionIdContratoByIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCondicionesContratoByIdCondicionIdContratoByIdPeriodoLaboral")
        command.Parameters.AddWithValue("IdCondicion", idCondicion)
        command.Parameters.AddWithValue("IdContrato", idContrato)
        command.Parameters.AddWithValue("IdperiodoLaboral", idPeriodoLaboral)
        Return SelectObjectFactory(command, argCondContrato).SingleOrDefault
    End Function

    Public Function GetCondicionesContratoByIdContratoByIdPeriodoLaboral(ByVal idContratoConvenio As Integer, ByVal idPeriodoLaboral As Integer, ByVal argCondContrato As BussinessEntities.ArgumentosCondicionesContrato) As System.Collections.Generic.List(Of BussinessEntities.CondicionesContrato) Implements ICondicionesContratoRepository.GetCondicionesContratoByIdContratoByIdPeriodoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCondicionesContratoByIdContratoByIdPeriodoLaboral")
        command.Parameters.AddWithValue("IdContrato", idContratoConvenio)
        command.Parameters.AddWithValue("IdperiodoLaboral", idPeriodoLaboral)
        Return SelectObjectFactory(command, argCondContrato)
    End Function

    Public Sub UpdateArchivoAdenda(ByVal IdPeriodoLaboral As Integer, ByVal IdContrato As Integer, ByVal Idcondicion As Integer, ByVal Archivo As String) Implements ICondicionesContratoRepository.UpdateArchivoAdenda
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateArchivoAdenda")

        command.Parameters.AddWithValue("IdPeriodoLaboral", IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdContrato", IdContrato)
        command.Parameters.AddWithValue("IdCondicion", Idcondicion)
        command.Parameters.AddWithValue("Archivo", Archivo)

        MyBase.ExecuteNonQuery(command)

    End Sub

    Public Function SaveCondicionesContrato(ByVal condicionContrato As BussinessEntities.CondicionesContrato) As Integer Implements ICondicionesContratoRepository.SaveCondicionesContrato
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCondicionesContrato")

        command.Parameters.AddWithValue("AmpliacionContrato", condicionContrato.AmpliacionContrato)
        command.Parameters.AddWithValue("cambioCargo", condicionContrato.cambioCargo)
        command.Parameters.AddWithValue("cambioSueldo", condicionContrato.cambioSueldo)
        command.Parameters.AddWithValue("CondicionDelCambio", condicionContrato.CondicionDelCambio)
        command.Parameters.AddWithValue("FechaAmpliacionContrato", condicionContrato.FechaAmpliacionContrato)
        command.Parameters.AddWithValue("FechaCambio", condicionContrato.FechaCambio)
        command.Parameters.AddWithValue("IdCondicion", condicionContrato.IdCondicion)
        command.Parameters.AddWithValue("IdContrato", condicionContrato.IdContrato)
        command.Parameters.AddWithValue("IdPeriodoLaboral", condicionContrato.IdPeriodoLaboral)
        command.Parameters.AddWithValue("IdPosicion", condicionContrato.IdPosicion)
        command.Parameters.AddWithValue("IdSituacionEspecial", condicionContrato.IdSituacionEspecial)
        command.Parameters.AddWithValue("NroAdemda", condicionContrato.NroAdemda)
        command.Parameters.AddWithValue("Sueldo", condicionContrato.Sueldo)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand, ByVal argCondContrato As ArgumentosCondicionesContrato) As List(Of CondicionesContrato)
        Dim lista As New List(Of CondicionesContrato)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New CondicionesContrato

                If Not reader.IsDBNull(reader.GetOrdinal("IdCondicion")) Then
                    entity.IdCondicion = reader.GetValue(reader.GetOrdinal("IdCondicion"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdContrato")) Then
                    entity.IdContrato = reader.GetValue(reader.GetOrdinal("IdContrato"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoLaboral")) Then
                    entity.IdPeriodoLaboral = reader.GetValue(reader.GetOrdinal("IdPeriodoLaboral"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdPosicion")) Then
                    entity.IdPosicion = reader.GetValue(reader.GetOrdinal("IdPosicion"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdSituacionEspecial")) Then
                    entity.IdSituacionEspecial = reader.GetValue(reader.GetOrdinal("IdSituacionEspecial"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("FechaCambio")) Then
                    entity.FechaCambio = reader.GetValue(reader.GetOrdinal("FechaCambio"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("Sueldo")) Then
                    entity.Sueldo = reader.GetValue(reader.GetOrdinal("Sueldo"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("FechaAmpliacionContrato")) Then
                    entity.FechaAmpliacionContrato = reader.GetValue(reader.GetOrdinal("FechaAmpliacionContrato"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("cambioSueldo")) Then
                    entity.cambioSueldo = reader.GetValue(reader.GetOrdinal("cambioSueldo"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("cambioCargo")) Then
                    entity.cambioCargo = reader.GetValue(reader.GetOrdinal("cambioCargo"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("AmpliacionContrato")) Then
                    entity.AmpliacionContrato = reader.GetValue(reader.GetOrdinal("AmpliacionContrato"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("CondicionDelCambio")) Then
                    entity.CondicionDelCambio = reader.GetValue(reader.GetOrdinal("CondicionDelCambio"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("NroAdemda")) Then
                    entity.NroAdemda = reader.GetValue(reader.GetOrdinal("NroAdemda"))
                End If

                If entity.IdPosicion.HasValue Then
                    If Not argCondContrato.DevolverPosicion Is Nothing Then
                        Dim posicionRepository As New PosicionRepository
                        entity.Posicion = posicionRepository.GetPosicionByIdPosicion(entity.IdPosicion, argCondContrato.DevolverPosicion)
                    End If
                End If

                If argCondContrato.DevolverContrato Then
                    'Aqui obtener el contrato
                End If

                If argCondContrato.DevolverPeriodoLaboral Then
                    'Aqui obtener el periodo laboral
                End If

                lista.Add(entity)
            End While
        End Using

        Return lista

    End Function


    Public Function GetCondicionesContratoValidasByFechaByIdPosicion(ByVal Fecha As DateTime, ByVal IdPosicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.CondicionesContrato) Implements ICondicionesContratoRepository.GetCondicionesContratoValidasByFechaByIdPosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCondicionesContratoValidasByFechaByIdPosicion")
        command.Parameters.AddWithValue("Fecha", Fecha)
        command.Parameters.AddWithValue("IdPosicion", IdPosicion)
        Return SelectObjectFactory(command, Nothing)
    End Function


End Class
