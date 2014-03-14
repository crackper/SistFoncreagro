Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Imports System.Data.SqlClient
Imports System.Data
Public Class PersonalRepository : Inherits MasterDataAccess : Implements IPersonalRepository

    Public Sub DeletePersonal(ByVal id As String) Implements IPersonalRepository.DeletePersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletePERSONAL")
        command.Parameters.AddWithValue("idPersonal", id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromPersonal() As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetAllFromPersonal
        'Retorna todos las operaciones financieras de la base de datos
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPERSONAL")
        Return SelectObjectFactory(command)

    End Function

    Public Function GetPersonalByIdPersonal(ByVal idPersonal As Integer) As BussinessEntities.Personal Implements IPersonalRepository.GetPersonalByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERSONALByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", idPersonal)
        Return SelectObjectFactory(command).SingleOrDefault
        '
    End Function

    Public Function GetPersonalByIdPersonal(ByVal idPersonal As Integer, ByVal argPersonal As ArgumentosPersonal) As BussinessEntities.Personal Implements IPersonalRepository.GetPersonalByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERSONALByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", idPersonal)
        Return SelectObjectFactory(command, argPersonal).SingleOrDefault
        '
    End Function
    ' no se usa
    Public Function GetFiltrarPERSONALPorParametro(ByVal apeMat As String, ByVal apePat As String, ByVal nomb As String, ByVal di As String) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetFiltrarPERSONALPorParametro
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFiltrarPERSONALPorParametro")
        command.Parameters.AddWithValue("apeMat", apeMat)
        command.Parameters.AddWithValue("apePat", apePat)
        command.Parameters.AddWithValue("Nomb", nomb)
        command.Parameters.AddWithValue("DI", di)
        Return SelectObjectFactory(command)
    End Function


    Public Function GetPERSONALActualmenteLaborandoByIdCategoria(ByVal IdCategoria As Integer) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetPERSONALActualmenteLaborandoByIdCategoria
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERSONALActualmenteLaborandoByIdCategoria")
        command.Parameters.AddWithValue("IdCategoria", IdCategoria)
        Return SelectObjectFactory2(command, "ConVinculo")
    End Function

    Public Function GetPERSONALALiquidadoPorRangoFecha(ByVal IdCategoria As Integer) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetPERSONALALiquidadoPorRangoFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERSONALALiquidadoPorRangoFecha")
        command.Parameters.AddWithValue("IdCategoria", IdCategoria)
        Return SelectObjectFactory2(command, "Liquidado")
    End Function

    ''modificar
    'Public Function GetPERSONALALiquidadoPorRangoFecha(ByVal IdCategoria As Integer, ByVal fechaIni As Date, ByVal fechaFin As Date) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetPERSONALALiquidadoPorRangoFecha
    '    Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERSONALALiquidadoPorRangoFecha")
    '    command.Parameters.AddWithValue("fechaIni", fechaIni)
    '    command.Parameters.AddWithValue("fechaFin", fechaFin)
    '    Return SelectObjectFactory(command)
    'End Function
    'Modificar: Para obtener practicantes (activos y de baja) Trabajadores(activos o de baja) cuarta cateoria.
    Public Function GetPERSONALByIdCategoria(ByVal idCategoria As Integer) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetPERSONALByIdCategoria
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERSONALByIdCategoria")
        command.Parameters.AddWithValue("IdCategoria", idCategoria)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetPERSONALSinVinculoLaboral() As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetPERSONALSinVinculoLaboral
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERSONALSinVinculoLaboral")
        Return SelectObjectFactory2(command, "SinVinculo")
    End Function

    Public Function GetPERSONALSinVinculoYConVinculoApartirDeUnaFecha(ByVal fechaIni As Date) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetPERSONALSinVinculoYConVinculoApartirDeUnaFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERSONALSinVinculoYConVinculoApartirDeUnaFecha")
        command.Parameters.AddWithValue("fechaIni", fechaIni)
        Return SelectObjectFactory(command)
    End Function

    Public Sub UpdateNIvelEducativo(ByVal IdNivelEducativo As Integer, ByVal IdPersonal As Integer) Implements IPersonalRepository.UpdateNIvelEducativo
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateNIvelEducativo")
        command.Parameters.AddWithValue("IdNivelEducativo", IdNivelEducativo)
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        MyBase.ExecuteNonQuery(command)
    End Sub

    'DEBERÍA SER EN UN DETERMINADO PROYECTO
    Public Function GetPersonalByFechaByIdRol(ByVal Fecha As Date, ByVal IdRol As Integer) As Object Implements IPersonalRepository.GetPersonalByFechaByIdRol
        Dim rolAsignadoRepository As New RolAsignadoRepository
        Dim condicionesContratoRepository As New CondicionesContratoRepository
        Dim periodoLaboralRepository As New PeriodoLaboralRepository
        Dim listaPersonal As New List(Of Personal)
        Dim listaRolAsignado As New List(Of RolAsignado)

        listaRolAsignado = rolAsignadoRepository.GetRolAsignadoValidoByFechaByIdRol(Fecha, IdRol)
        For Each rolAsignado As RolAsignado In listaRolAsignado
            Dim condicion As New CondicionesContrato
            condicion = condicionesContratoRepository.GetCondicionesContratoByIdCondicionIdContratoByIdPeriodoLaboral(rolAsignado.IdCondicion, rolAsignado.IdContrato, rolAsignado.IdPeriodoLaboral, Nothing)
            If Not condicion Is Nothing Then
                Dim periodoLaboral As New PeriodoLaboral
                Dim personal As New Personal
                periodoLaboral = periodoLaboralRepository.GetPERIODOLABORALByIdPeriodoLaboral(condicion.IdPeriodoLaboral, Nothing)
                If Not periodoLaboral Is Nothing Then
                    personal = GetPersonalByIdPersonal(periodoLaboral.IdPersonal)
                    If Not personal Is Nothing Then
                        listaPersonal.Add(personal)
                    End If
                End If
            End If
        Next

        Return listaPersonal
    End Function


    Public Function GetPersonalByFechaByIdProyecto(ByVal Fecha As DateTime, ByVal idProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetPersonalByFechaByIdProyecto
        Dim cCostosRepository As New CCostoRepository
        Dim posicionCCostosRepository As New PosicionCCostoRepository
        Dim condicionesContratoRepository As New CondicionesContratoRepository
        Dim periodoLaboralRepository As New PeriodoLaboralRepository
        Dim listaPersonal As New List(Of Personal)
        Dim listaCCostos As New List(Of CCosto)
        listaCCostos = cCostosRepository.GetCCOSTOByIdProyecto(idProyecto)
        For Each cCostos As CCosto In listaCCostos
            Dim listaPosicionesCCostos As New List(Of PosicionCentroCosto)
            For Each posicionCCosto As PosicionCentroCosto In listaPosicionesCCostos
                listaPersonal.AddRange(GetPersonalByFechaIdPosicion(Fecha, posicionCCosto.IdPosicion))
            Next
        Next
        Return listaPersonal
    End Function

    Public Function GetPersonalByFechaIdPosicion(ByVal Fecha As Date, ByVal IdPosicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetPersonalByFechaIdPosicion
        Dim condicionesContratoRepository As New CondicionesContratoRepository
        Dim periodoLaboralRepository As New PeriodoLaboralRepository
        Dim listaPersonal As New List(Of Personal)

        Dim listaCondiciones As New List(Of CondicionesContrato)
        listaCondiciones = condicionesContratoRepository.GetCondicionesContratoValidasByFechaByIdPosicion(Fecha, IdPosicion)

        For Each condicion As CondicionesContrato In listaCondiciones
            Dim periodoLaboral As New PeriodoLaboral
            Dim personal As New Personal
            periodoLaboral = periodoLaboralRepository.GetPERIODOLABORALByIdPeriodoLaboral(condicion.IdPeriodoLaboral, Nothing)
            If Not periodoLaboral Is Nothing Then
                personal = GetPersonalByIdPersonal(periodoLaboral.IdPersonal)
                If Not personal Is Nothing Then
                    listaPersonal.Add(personal)
                End If
            End If
        Next
        Return listaPersonal
    End Function

    'Public Function GetPersonalPorProyecto(ByVal idProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetPersonalPorProyecto
    '    Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERSONALByIdProyecto")
    '    command.Parameters.AddWithValue("IdProyecto", idProyecto)
    '    Return SelectObjectFactory(command)
    'End Function

    Public Sub UpdateCVPERSONAL(ByVal IdPersonal As Integer, ByVal ArchivoCV As String) Implements IPersonalRepository.UpdateCVPERSONAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateCVPERSONAL")

        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        command.Parameters.AddWithValue("ArchivoCV", ArchivoCV)

        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateFotoPERSONAL(ByVal IdPersonal As Integer, ByVal ArchivoFoto As String) Implements IPersonalRepository.UpdateFotoPERSONAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateFotoPERSONAL")

        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        command.Parameters.AddWithValue("ArchivoFoto", ArchivoFoto)

        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateArchivoCertificadoTipoSangre(ByVal CertificadoTipoSangre As String, ByVal IdPersonal As Integer) Implements IPersonalRepository.UpdateArchivoCertificadoTipoSangre
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateArchivoCertificadoTipoSangre")

        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        command.Parameters.AddWithValue("CertificadoTipoSangre", CertificadoTipoSangre)

        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function SavePersonal(ByVal Personal As BussinessEntities.Personal) As Integer Implements IPersonalRepository.SavePersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePERSONAL")

        command.Parameters.AddWithValue("ApeMaterno", Personal.ApeMaterno)
        command.Parameters.AddWithValue("ApePaterno", Personal.ApePaterno)
        command.Parameters.AddWithValue("Celular", Personal.Celular)
        command.Parameters.AddWithValue("ContactoEmergencia", Personal.ContactoEmergencia)
        command.Parameters.AddWithValue("Direccion", Personal.Direccion)
        'command.Parameters.AddWithValue("Discapacidad", Personal.Discapacidad)
        command.Parameters.AddWithValue("Email", Personal.Email)
        command.Parameters.AddWithValue("EstadoCivil", Personal.EstadoCivil)
        command.Parameters.AddWithValue("FechaNacimiento", Personal.FechaNacimiento)
        command.Parameters.AddWithValue("IdNacionalidad", Personal.IdNacionalidad)
        command.Parameters.AddWithValue("IdNivelEducativo", Personal.IdNivelEducativo)
        command.Parameters.AddWithValue("IdPersonal", Personal.IdPersonal)
        command.Parameters.AddWithValue("IdTipoDI", Personal.IdTipoDI)
        command.Parameters.AddWithValue("LicenciaConducir", Personal.LicenciaConducir)
        command.Parameters.AddWithValue("LugarNacimiento", Personal.LugarNacimiento)
        'command.Parameters.AddWithValue("Nacionalidad", Personal.Nacionalidad)
        command.Parameters.AddWithValue("Nombres", Personal.Nombres)
        command.Parameters.AddWithValue("NroDI", Personal.NroDI)
        command.Parameters.AddWithValue("Sexo", Personal.Sexo)
        command.Parameters.AddWithValue("Telefono", Personal.Telefono)
        command.Parameters.AddWithValue("TelefonoContacto", Personal.TelefonoContacto)
        command.Parameters.AddWithValue("TipoSangre", Personal.TipoSangre)
        command.Parameters.AddWithValue("Fotocheck", Personal.Fotocheck)
        'command.Parameters.AddWithValue("CertificadoTipoSangre", Personal.CertificadoTipoSangre)


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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Personal)
        Dim lista As New List(Of Personal)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim personal As New Personal
                BasicoEntity(personal, reader)
                Dim periodoLaboral As New PeriodoLaboral
                Dim contrato As New ContratoConvenio
                Dim condiciones As New CondicionesContrato
                Dim posicion As New Posicion
                Dim area As New Area

                posicion.Area = area
                condiciones.Posicion = posicion
                contrato.condicionesActualesDeContrato = condiciones
                periodoLaboral.contratoActual = contrato
                personal.periodoLaboralActualEntity = periodoLaboral
                lista.Add(personal)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

    Private Function SelectObjectFactory2(ByVal command As SqlCommand, ByVal arg As String) As List(Of Personal)
        Dim lista As New List(Of Personal)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim personal As New Personal
                If Not reader.IsDBNull(reader.GetOrdinal("IdPersonal")) Then
                    personal.IdPersonal = reader.GetValue(reader.GetOrdinal("IdPersonal"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("ApePaterno")) Then
                    personal.ApePaterno = reader.GetValue(reader.GetOrdinal("ApePaterno"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("ApeMaterno")) Then
                    personal.ApeMaterno = reader.GetValue(reader.GetOrdinal("ApeMaterno"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Nombres")) Then
                    personal.Nombres = reader.GetValue(reader.GetOrdinal("Nombres"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FechaNacimiento")) Then
                    personal.FechaNacimiento = reader.GetValue(reader.GetOrdinal("FechaNacimiento"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoDI")) Then
                    personal.IdTipoDI = reader.GetValue(reader.GetOrdinal("IdTipoDI"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("NroDI")) Then
                    personal.NroDI = reader.GetValue(reader.GetOrdinal("NroDI"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("TipoSangre")) Then
                    personal.TipoSangre = reader.GetValue(reader.GetOrdinal("TipoSangre"))
                End If

                ''''''
                personal.periodoLaboralActualEntity = New PeriodoLaboral
                personal.periodoLaboralActualEntity.contratoActual = New ContratoConvenio
                personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato = New CondicionesContrato
                personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion = New Posicion
                personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion.Area = New Area

                If arg = "ConVinculo" Then
                    If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoLaboral")) Then
                        personal.periodoLaboralActualEntity.IdPeriodoLaboral = reader.GetValue(reader.GetOrdinal("IdPeriodoLaboral"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("IdContrato")) Then
                        personal.periodoLaboralActualEntity.contratoActual.IdContrato = reader.GetValue(reader.GetOrdinal("IdContrato"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("NroContrato")) Then
                        personal.periodoLaboralActualEntity.contratoActual.NroContrato = reader.GetValue(reader.GetOrdinal("NroContrato"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("IdPosicion")) Then
                        personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion.IdPosicion = reader.GetValue(reader.GetOrdinal("IdPosicion"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("IdCargo")) Then
                        personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion.IdCargo = reader.GetValue(reader.GetOrdinal("IdCargo"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("NomCargo")) Then
                        personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion.NomCargo = reader.GetValue(reader.GetOrdinal("NomCargo"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("IdArea")) Then
                        personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion.Area.IdArea = reader.GetValue(reader.GetOrdinal("IdArea"))
                    End If
                    If Not reader.IsDBNull(reader.GetOrdinal("NombreArea")) Then
                        personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion.Area.Nombre = reader.GetValue(reader.GetOrdinal("NombreArea"))
                    End If
                Else
                    If arg = "Liquidado" Then
                        If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoLaboral")) Then
                            personal.periodoLaboralActualEntity.IdPeriodoLaboral = reader.GetValue(reader.GetOrdinal("IdPeriodoLaboral"))
                        End If

                        If Not reader.IsDBNull(reader.GetOrdinal("FechaCese")) Then
                            personal.periodoLaboralActualEntity.FechaCese = reader.GetValue(reader.GetOrdinal("FechaCese"))
                        End If

                        If Not reader.IsDBNull(reader.GetOrdinal("IdContrato")) Then
                            personal.periodoLaboralActualEntity.contratoActual.IdContrato = reader.GetValue(reader.GetOrdinal("IdContrato"))
                        End If
                        If Not reader.IsDBNull(reader.GetOrdinal("NroContrato")) Then
                            personal.periodoLaboralActualEntity.contratoActual.NroContrato = reader.GetValue(reader.GetOrdinal("NroContrato"))
                        End If
                        If Not reader.IsDBNull(reader.GetOrdinal("IdPosicion")) Then
                            personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion.IdPosicion = reader.GetValue(reader.GetOrdinal("IdPosicion"))
                        End If
                        If Not reader.IsDBNull(reader.GetOrdinal("IdCargo")) Then
                            personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion.IdCargo = reader.GetValue(reader.GetOrdinal("IdCargo"))
                        End If
                        If Not reader.IsDBNull(reader.GetOrdinal("NomCargo")) Then
                            personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion.NomCargo = reader.GetValue(reader.GetOrdinal("NomCargo"))
                        End If
                        If Not reader.IsDBNull(reader.GetOrdinal("IdArea")) Then
                            personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion.Area.IdArea = reader.GetValue(reader.GetOrdinal("IdArea"))
                        End If
                        If Not reader.IsDBNull(reader.GetOrdinal("NombreArea")) Then
                            personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Posicion.Area.Nombre = reader.GetValue(reader.GetOrdinal("NombreArea"))
                        End If

                        'Dim periodoLaboral As New PeriodoLaboral
                        'Dim contrato As New ContratoConvenio
                        'Dim condiciones As New CondicionesContrato
                        'Dim posicion As New Posicion
                        'Dim area As New Area

                        'posicion.Area = area
                        'condiciones.Posicion = posicion
                        'contrato.condicionesActualesDeContrato = condiciones
                        'periodoLaboral.contratoActual = contrato
                        'personal.periodoLaboralActualEntity = periodoLaboral
                        'lista.Add(personal)
                    ElseIf arg = "SinVinculo" Then

                    End If
                End If
                lista.Add(personal)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand, ByVal argPersonal As ArgumentosPersonal) As List(Of Personal)
        Dim lista As New List(Of Personal)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim personal As New Personal
                Dim argPeriodoLaboral As ArgumentosPeriodolaboral
                BasicoEntity(personal, reader)

                If Not argPersonal Is Nothing Then

                    If argPersonal.DevolverArea Then
                        Dim argArea As New ArgumentosArea(0, 0, 0, 0, 0)
                        Dim argPosicion As New ArgumentosPosicion(argArea, 0, 0, 0, 0, 0, 0)
                        Dim argCondicionesContrato As New ArgumentosCondicionesContrato(0, 0, argPosicion)
                        Dim argContrato As New ArgumentosContrato(argCondicionesContrato, 0, 0)
                        argPeriodoLaboral = New ArgumentosPeriodolaboral(Nothing, argContrato, 0, 0, 0, 0, 0)
                    Else
                        If Not argPersonal.DevolverPosicionActual Is Nothing Then
                            Dim argPosicion As New ArgumentosPosicion(Nothing, 0, 0, 0, 0, 0, 0)
                            Dim argCondicionesContrato As New ArgumentosCondicionesContrato(0, 0, argPosicion)
                            Dim argContrato As New ArgumentosContrato(argCondicionesContrato, 0, 0)
                            argPeriodoLaboral = New ArgumentosPeriodolaboral(Nothing, argContrato, 0, 0, 0, 0, 0)
                        Else
                            If argPersonal.DevolverCondicionesContratoActual Then
                                Dim argCondicionesContrato As New ArgumentosCondicionesContrato(0, 0, Nothing)
                                Dim argContrato As New ArgumentosContrato(argCondicionesContrato, 0, 0)
                                argPeriodoLaboral = New ArgumentosPeriodolaboral(Nothing, argContrato, 0, 0, 0, 0, 0)
                            Else
                                If argPersonal.DevolverContratoActual Then
                                    Dim argContrato As New ArgumentosContrato(Nothing, 0, 0)
                                    argPeriodoLaboral = New ArgumentosPeriodolaboral(Nothing, argContrato, 0, 0, 0, 0, 0)
                                Else
                                    argPeriodoLaboral = New ArgumentosPeriodolaboral(Nothing, Nothing, 0, 0, 0, 0, 0)
                                End If
                            End If
                        End If
                    End If
                    Dim periodoLaboralRepository As New PeriodoLaboralRepository

                    personal.periodoLaboralActualEntity = periodoLaboralRepository.GetPERIODOLABORALAUltimoByIdPersonal(personal.IdPersonal, argPeriodoLaboral)

                End If

                lista.Add(personal)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

    Public Sub BasicoEntity(ByVal personal As Personal, ByVal reader As SqlDataReader)
        If Not reader.IsDBNull(reader.GetOrdinal("IdPersonal")) Then
            personal.IdPersonal = reader.GetValue(reader.GetOrdinal("IdPersonal"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("ApePaterno")) Then
            personal.ApePaterno = reader.GetValue(reader.GetOrdinal("ApePaterno"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("ApeMaterno")) Then
            personal.ApeMaterno = reader.GetValue(reader.GetOrdinal("ApeMaterno"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("Nombres")) Then
            personal.Nombres = reader.GetValue(reader.GetOrdinal("Nombres"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("Direccion")) Then
            personal.Direccion = reader.GetValue(reader.GetOrdinal("Direccion"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("Telefono")) Then
            personal.Telefono = reader.GetValue(reader.GetOrdinal("Telefono"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("Celular")) Then
            personal.Celular = reader.GetValue(reader.GetOrdinal("Celular"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("Email")) Then
            personal.Email = reader.GetValue(reader.GetOrdinal("Email"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("FechaNacimiento")) Then
            personal.FechaNacimiento = reader.GetValue(reader.GetOrdinal("FechaNacimiento"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("LugarNacimiento")) Then
            personal.LugarNacimiento = reader.GetValue(reader.GetOrdinal("LugarNacimiento"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("IdNacionalidad")) Then
            personal.IdNacionalidad = reader.GetValue(reader.GetOrdinal("IdNacionalidad"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("Nacionalidad")) Then
            personal.Nacionalidad = reader.GetValue(reader.GetOrdinal("Nacionalidad"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("IdTipoDI")) Then
            personal.IdTipoDI = reader.GetValue(reader.GetOrdinal("IdTipoDI"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("NroDI")) Then
            personal.NroDI = reader.GetValue(reader.GetOrdinal("NroDI"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("Sexo")) Then
            personal.Sexo = reader.GetValue(reader.GetOrdinal("Sexo"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("EstadoCivil")) Then
            personal.EstadoCivil = reader.GetValue(reader.GetOrdinal("EstadoCivil"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("TipoSangre")) Then
            personal.TipoSangre = reader.GetValue(reader.GetOrdinal("TipoSangre"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("LicenciaConducir")) Then
            personal.LicenciaConducir = reader.GetValue(reader.GetOrdinal("LicenciaConducir"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("ContactoEmergencia")) Then
            personal.ContactoEmergencia = reader.GetValue(reader.GetOrdinal("ContactoEmergencia"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("TelefonoContacto")) Then
            personal.TelefonoContacto = reader.GetValue(reader.GetOrdinal("TelefonoContacto"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("Discapacidad")) Then
            personal.Discapacidad = reader.GetValue(reader.GetOrdinal("Discapacidad"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("IdNivelEducativo")) Then
            personal.IdNivelEducativo = reader.GetValue(reader.GetOrdinal("IdNivelEducativo"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("ArchivoFoto")) Then
            personal.ArchivoFoto = reader.GetValue(reader.GetOrdinal("ArchivoFoto"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("ArchivoCV")) Then
            personal.ArchivoCV = reader.GetValue(reader.GetOrdinal("ArchivoCV"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("CertificadoTipoSangre")) Then
            personal.CertificadoTipoSangre = reader.GetValue(reader.GetOrdinal("CertificadoTipoSangre"))
        End If
        If Not reader.IsDBNull(reader.GetOrdinal("Fotocheck")) Then
            personal.Fotocheck = reader.GetValue(reader.GetOrdinal("Fotocheck"))
        End If

    End Sub
    Public Function GetPERSONALinControlAsistencia(ByVal Fecha As Date) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalRepository.GetPERSONALinControlAsistencia
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPERSONALinControlAsistencia")
        command.Parameters.AddWithValue("Fecha", Fecha)
        Dim argPersonal As New ArgumentosPersonal(1, 0, 0, Nothing, Nothing, 0, 0, 0, 0, 0, 0, 0, 0)
        Return SelectObjectFactory(command, argPersonal)
    End Function

    Public Function GetCertificadoTipoSangrePERSONALByIdPersonal(ByVal IdPersonal As Integer) As String Implements IPersonalRepository.GetCertificadoTipoSangrePERSONALByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCertificadoTipoSangrePERSONALByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)

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

    Public Function GetAsignacionFamiliarByIdPersonal(ByVal Idpersonal As Integer) As Decimal Implements IPersonalRepository.GetAsignacionFamiliarByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAsignacionFamiliarByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", Idpersonal)

        Dim asignacion As Decimal = 0
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    asignacion = reader.GetValue(0)
                End If
            End If
        End Using

        Return asignacion
    End Function
End Class
