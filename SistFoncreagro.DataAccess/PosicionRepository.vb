Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class PosicionRepository : Inherits MasterDataAccess : Implements IPosicionRepository

    Public Sub DeletePosicion(ByVal idPosicion As Int32) Implements IPosicionRepository.DeletePosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletePOSICION")
        command.Parameters.AddWithValue("idPosicion", idPosicion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromPosicion(ByVal argPosicion As BussinessEntities.ArgumentosPosicion) As System.Collections.Generic.List(Of BussinessEntities.Posicion) Implements IPosicionRepository.GetAllFromPosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPosicion")
        Return SelectObjectFactory(command, argPosicion)
    End Function

    Public Function GetPosicionByIdPosicion(ByVal IdPosicion As Integer, ByVal argPosicion As BussinessEntities.ArgumentosPosicion) As BussinessEntities.Posicion Implements IPosicionRepository.GetPosicionByIdPosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPOSICIONByIdPosicion")
        command.Parameters.AddWithValue("IdPosicion", IdPosicion)
        Return SelectObjectFactory(command, argPosicion).SingleOrDefault
    End Function

    Public Function GetPosicionByIdArea(ByVal IdArea As Integer, ByVal argPosicion As BussinessEntities.ArgumentosPosicion) As System.Collections.Generic.List(Of BussinessEntities.Posicion) Implements IPosicionRepository.GetPosicionByIdArea
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPOSICIONByIdArea")
        command.Parameters.AddWithValue("IdArea", IdArea)
        Return SelectObjectFactory(command, argPosicion)
    End Function

    Public Function SavePosicion(ByVal posicion As BussinessEntities.Posicion) As Integer Implements IPosicionRepository.SavePosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePOSICION")
        command.Parameters.AddWithValue("IdPosicion", posicion.IdPosicion)
        command.Parameters.AddWithValue("IdCargo", posicion.IdCargo)
        command.Parameters.AddWithValue("IdArea", posicion.IdArea)
        command.Parameters.AddWithValue("JefeInmediato", posicion.jefeInmediato.IdPosicion)
        command.Parameters.AddWithValue("JefeArea", posicion.EsJefeArea)

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

    Public Function GetJefaturaByIdArea(ByVal idArea As Integer, ByVal argPosicion As BussinessEntities.ArgumentosPosicion) As BussinessEntities.Posicion Implements IPosicionRepository.GetJefaturaByIdArea
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetJefaturaByIdArea")
        command.Parameters.AddWithValue("IdArea", idArea)
        Return SelectObjectFactory(command, argPosicion).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand, ByVal argPosicion As ArgumentosPosicion) As List(Of Posicion)
        Dim lista As New List(Of Posicion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New Posicion
                If Not reader.IsDBNull(reader.GetOrdinal("Archivo")) Then
                    entity.Archivo = reader.GetValue(reader.GetOrdinal("Archivo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Confianza")) Then
                    entity.Confianza = reader.GetValue(reader.GetOrdinal("Confianza"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Experiencia")) Then
                    entity.Experiencia = reader.GetValue(reader.GetOrdinal("Experiencia"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FechaCreacion")) Then
                    entity.FechaCreacion = reader.GetValue(reader.GetOrdinal("FechaCreacion"))
                End If
                'If Not reader.IsDBNull(reader.GetOrdinal("IdGradoSalarial")) Then
                '    entity.GradoSalarial = reader.GetValue(reader.GetOrdinal("IdGradoSalarial"))
                'End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdPosicion")) Then
                    entity.IdPosicion = reader.GetValue(reader.GetOrdinal("IdPosicion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("JefeArea")) Then
                    entity.EsJefeArea = reader.GetValue(reader.GetOrdinal("JefeArea"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("jefeInmediato")) Then
                    entity.Dependencia = reader.GetValue(reader.GetOrdinal("jefeInmediato"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdCargo")) Then
                    entity.IdCargo = reader.GetValue(reader.GetOrdinal("IdCargo"))
                End If

                'If Not reader.IsDBNull(reader.GetOrdinal("IdArea")) Then
                '    entity.IdArea = reader.GetValue(reader.GetOrdinal("IdArea"))
                'End If

                'Obtenemos los datos del cargo
                If entity.IdCargo.HasValue Then

                    Dim cargoRepository As New CargoRepository
                    Dim cargo As New Cargo

                    cargo = cargoRepository.GetCargoByIdCargo(entity.IdCargo)
                    If Not cargo Is Nothing Then
                        entity.IdCargo = cargo.IdCargo
                        entity.NomCargo = cargo.NomCargo
                        entity.DescCargo = cargo.DescCargo
                    End If
                End If

                'Obtenemos el area a la que pertenece la Posición.
                If Not argPosicion.DevolverArea Is Nothing Then
                    If Not reader.IsDBNull(reader.GetOrdinal("IdArea")) Then

                        Dim areaRepository As New AreaRepository
                        Dim area As New Area
                        Dim argArea As ArgumentosArea '(0, 0, 0, 0, 0)
                        argArea = argPosicion.DevolverArea
                        area = areaRepository.GetAREAByIdArea(reader.GetValue(reader.GetOrdinal("IdArea")), argArea)

                        If Not area Is Nothing Then
                            entity.Area = area
                        End If
                    End If

                End If

                'Obtenemos las listas para esta posición.
                If argPosicion.DevolverListaFormacionReq = True Then
                    Dim formacionRequeridaRepository As New FormacionRequeridaRepository
                    entity.ListaFormacionRequerida = formacionRequeridaRepository.GetAllFromFORMACIONREQUERIDA
                End If

                If argPosicion.DevolverListaFunciones = True Then
                    Dim funcionesRepository As New FuncionesRepository
                    entity.ListaFunciones = funcionesRepository.GetAllFromFUNCIONES
                End If

                If argPosicion.DevolverListaHabilidades = True Then
                    Dim habilidadesRepository As New HabilidadesRepository
                    entity.ListaHabilidades = habilidadesRepository.GetAllFromHABILIDADES
                End If

                If argPosicion.DevolverListaRequesitosAdic = True Then
                    Dim reqAdicionalesRepository As New RequisitoAdicionalRepository
                    entity.ListaRequesitosAdicionales = reqAdicionalesRepository.GetAllFromREQUISITOADICIONAL
                End If

                lista.Add(entity)
            End While
        End Using

        For Each entity As Posicion In lista
            'Obtenemos la posición de la que depende ésta posición.
            If argPosicion.DevolverJefatura = True Then
                If entity.Dependencia.HasValue Then
                    'Dim jefeInmediato As New Posicion
                    Dim argArea As New ArgumentosArea(0, 0, 10000, 0, 0)
                    Dim argPosicionJefe As New ArgumentosPosicion(argArea, 0, 0, 0, 0, 0, 0)
                    If entity.Dependencia.HasValue Then
                        entity.jefeInmediato = GetPosicionByIdPosicion(entity.Dependencia, argPosicionJefe)
                    End If
                Else
                    'Preguntar si el área de esta posición tiene dependencia, entonces obtener al jefe de area de 
                    'esa area y colocarlo como jefe inmediato
                    If Not entity.Area Is Nothing Then
                        If entity.Area.Dependencia.HasValue Then
                            Dim argArea As New ArgumentosArea(0, 0, 10000, 0, 0)
                            Dim argPosicionJefe2 As New ArgumentosPosicion(argArea, 0, 0, 0, 0, 0, 0)
                            entity.jefeInmediato = GetJefaturaByIdArea(entity.Area.Dependencia, argPosicionJefe2)
                        End If
                    End If
                End If
            End If
        Next

        Return lista
        '
    End Function

    Protected Function GetPosicionesPorAreaRecursiva(ByVal area As Area, ByVal primera As Boolean) As List(Of Posicion)
        'El área debe tener jefatura y todas sus subareas
        Dim listaPosiciones As New List(Of Posicion)
        Dim listaPosiciones2 As New List(Of Posicion)
        Dim argArea As ArgumentosArea
        argArea = Nothing
        Dim argPosicion As New ArgumentosPosicion(argArea, 0, 0, 0, 0, 0, 0)

        listaPosiciones = GetPosicionByIdArea(area.IdArea, argPosicion)

        For Each posicion In listaPosiciones
            Dim posicion2 As New Posicion
            posicion2.IdPosicion = posicion.IdPosicion
            'posicion2.GradoSalarial = posicion 'GradoSalarial no se ha pedido en los argumentos, ver luego si se incluye
            posicion2.Archivo = posicion.Archivo
            posicion2.Confianza = posicion.Confianza
            posicion2.IdCargo = posicion.IdCargo
            posicion2.NomCargo = posicion.NomCargo
            posicion2.DescCargo = posicion.DescCargo
            posicion2.EsJefeArea = posicion.EsJefeArea
            posicion2.Experiencia = posicion.Experiencia
            posicion2.FechaCreacion = posicion.FechaCreacion
            posicion2.jefeInmediato = posicion.jefeInmediato 'JefeInmediato no se ha pedido en los argumentos, ver luego si se incluye
            posicion2.Area = area
            If primera = False And posicion.Dependencia.HasValue = False Then
                posicion2.Dependencia = area.Jefatura.IdPosicion
            Else
                posicion2.Dependencia = posicion.Dependencia
            End If

            listaPosiciones2.Add(posicion2)

        Next

        If area.ListaSubareas.Count > 0 Then
            Dim listaSubAreas As New List(Of Area)

            For Each subArea In listaSubAreas
                GetPosicionesPorAreaRecursiva(subArea, False)
            Next
        End If

        Return listaPosiciones2
    End Function

    Public Function GetListaPosicionesDeUnaAreaySubAreasByIdArea(ByVal IdArea As Int32) As System.Collections.Generic.IList(Of BussinessEntities.Posicion) Implements IPosicionRepository.GetListaPosicionesDeUnaAreaySubAreasByIdArea
        ' obtenemos el area con el ID y sus jefes de area.
        Dim area As New Area
        Dim areaRepository As New AreaRepository
        Dim argArea As New ArgumentosArea(1, 0, 0, 1, 1)
        area = areaRepository.GetAREAByIdArea(IdArea, argArea)
        Return GetPosicionesPorAreaRecursiva(area, True)
    End Function

    'falta completar
    Public Function GetPosicionesByIdCCostoAndFecha(ByVal IdCCosto As Integer, ByVal fecha As Date) As System.Collections.Generic.List(Of BussinessEntities.Posicion) Implements IPosicionRepository.GetPosicionesByIdCCostoAndFecha
        Dim listaPosiciones As New List(Of Posicion)
        Dim posicionCCostoRepository As New PosicionCCostoRepository
        'Return posicionCCostoRepository.GetPosicionesCCostosValidasByFechaByIdCCostos(fecha, IdCCosto)
        Return listaPosiciones
    End Function

    'Falta completar
    Public Function GetPosicionesByIdProyectoAndFecha(ByVal IdProyecto As Integer, ByVal fecha As Date) As System.Collections.Generic.List(Of BussinessEntities.Posicion) Implements IPosicionRepository.GetPosicionesByIdProyectoAndFecha
        Dim listaCCosto As New List(Of CCosto)
        Dim listaPosiciones As New List(Of Posicion)
        Dim cCostoRepository As New CCostoRepository

        Dim posicionCCostoRepository As New PosicionCCostoRepository

        listaCCosto = cCostoRepository.GetCCOSTOByIdProyecto(IdProyecto)
        For Each cCosto As CCosto In listaCCosto
            Dim listaPosicionesCCosto As New List(Of PosicionCentroCosto)
            listaPosicionesCCosto = posicionCCostoRepository.GetPosicionesCCostosValidasByFechaByIdCCostos(fecha, cCosto.IdCCosto)
        Next

        Return listaPosiciones
    End Function

End Class
