Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AreaRepository : Inherits MasterDataAccess : Implements IAreaRepository

    Public Sub DeleteArea(ByVal idArea As Integer) Implements IAreaRepository.DeleteArea
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteAREA")
        command.Parameters.AddWithValue("IdArea", idArea)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromArea(ByVal argArea As BussinessEntities.ArgumentosArea) As System.Collections.Generic.List(Of BussinessEntities.Area) Implements IAreaRepository.GetAllFromArea
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromArea")
        Return SelectObjectFactory(command, argArea)
    End Function

    Public Function GetAreaByNombre(ByVal Nombre As String, ByVal argArea As BussinessEntities.ArgumentosArea) As BussinessEntities.Area Implements IAreaRepository.GetAreaByNombre
    End Function

    Public Function SaveArea(ByVal area As BussinessEntities.Area) As Integer Implements IAreaRepository.SaveArea
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAREA")
        command.Parameters.AddWithValue("IdArea", area.IdArea)
        command.Parameters.AddWithValue("CodArea", area.CodArea)
        command.Parameters.AddWithValue("Nombre", area.Nombre)
        command.Parameters.AddWithValue("TipoArea", area.TipoArea)
        command.Parameters.AddWithValue("Dependencia", area.Dependencia)
        command.Parameters.AddWithValue("IdDeclarante", area.IdDeclarante)
        command.Parameters.AddWithValue("Nivel", area.Nivel)
        command.Parameters.AddWithValue("Administracion", area.Administracion)
        command.Parameters.AddWithValue("ControlaProyectos", area.ControlaProyectos)
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

    Public Function GetAREAByIdArea(ByVal idArea As Integer, ByVal argArea As BussinessEntities.ArgumentosArea) As BussinessEntities.Area Implements IAreaRepository.GetAREAByIdArea
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAREAByIdArea")
        command.Parameters.AddWithValue("IdArea", idArea)
        Return SelectObjectFactory(command, argArea).SingleOrDefault
    End Function

    Public Function GetAreaByIdProyecto(ByVal IdProyecto As Integer, ByVal argArea As BussinessEntities.ArgumentosArea) As System.Collections.Generic.List(Of BussinessEntities.Area) Implements IAreaRepository.GetAreaByIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAreaByIdProyecto")
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        Return SelectObjectFactory(command, argArea)
    End Function

    Public Function GetAreaByIdPadre(ByVal IdPadre As Integer, ByVal argArea As BussinessEntities.ArgumentosArea) As System.Collections.Generic.List(Of BussinessEntities.Area) Implements IAreaRepository.GetAreaByIdPadre
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAREAByDependencia")
        command.Parameters.AddWithValue("Dependencia", IdPadre)
        Return SelectObjectFactory(command, argArea)
    End Function

    Public Function GetTipoAreaDeSubArea(ByVal IdPadre As Integer) As String Implements IAreaRepository.GetTipoAreaDeSubArea
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTipoAreaDeSubArea")
        command.Parameters.AddWithValue("Dependencia", IdPadre)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Return reader.GetString(0)
            Else
                Return ""
            End If
        End Using
        Return MyBase.ExecuteReader(command).GetSqlString(0)
    End Function

    Public Function GetAreaSuperior(ByVal argArea As ArgumentosArea) As BussinessEntities.Area Implements IAreaRepository.GetAreaSuperior
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAreaSuperior")
        Return SelectObjectFactory(command, argArea).SingleOrDefault
    End Function

    Public Function GetAreaByTipoArea(ByVal TipoArea As String, ByVal argArea As BussinessEntities.ArgumentosArea) As System.Collections.Generic.List(Of BussinessEntities.Area) Implements IAreaRepository.GetAreaByTipoArea
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand, ByVal ArgArea As ArgumentosArea) As List(Of Area)
        Dim lista As New List(Of Area)
        Dim lista2 As New List(Of Area)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New Area
                If Not reader.IsDBNull(reader.GetOrdinal("IdArea")) Then
                    entity.IdArea = reader.GetValue(reader.GetOrdinal("IdArea"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("CodArea")) Then
                    entity.CodArea = reader.GetValue(reader.GetOrdinal("CodArea"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Nombre")) Then
                    entity.Nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("TipoArea")) Then
                    entity.TipoArea = reader.GetValue(reader.GetOrdinal("TipoArea"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Dependencia")) Then
                    entity.Dependencia = reader.GetValue(reader.GetOrdinal("Dependencia"))
                    'Else
                    '    entity.Dependencia = 0
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdDeclarante")) Then
                    entity.IdDeclarante = reader.GetValue(reader.GetOrdinal("IdDeclarante"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Nivel")) Then
                    entity.Nivel = reader.GetValue(reader.GetOrdinal("Nivel"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("Administracion")) Then
                    entity.Administracion = reader.GetValue(reader.GetOrdinal("Administracion"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("ControlaProyectos")) Then
                    entity.ControlaProyectos = reader.GetValue(reader.GetOrdinal("ControlaProyectos"))
                End If

                If ArgArea.DevolverJefatura = True Then
                    'Obtenemos el cargo que representa la jefatura del área
                    Dim posicionRepository As New PosicionRepository
                    Dim jefatura As New Posicion
                    Dim argAreaJefatura As ArgumentosArea
                    argAreaJefatura = Nothing
                    Dim argPosicion As New ArgumentosPosicion(argAreaJefatura, 0, 0, 0, 0, 0, 0)
                    jefatura = posicionRepository.GetJefaturaByIdArea(entity.IdArea, argPosicion)

                    If Not jefatura Is Nothing Then
                        entity.Jefatura = jefatura
                    End If
                End If

                If ArgArea.DevolverProyectos = True Then
                    'Obtenemos los proyectos que coordina o dirige el área
                    Dim proyectoRepository As New ProyectoRepository
                    Dim listaProyectos As New List(Of Proyecto)
                    'listaProyectos = proyectoRepository.GetPROYECTOByIdArea(entity.IdArea)
                    entity.ListaProyectos = listaProyectos
                End If

                If ArgArea.DevolverPosiciones = True Then
                    'Falta la lista de Posiciones de esta Área.
                End If


                lista.Add(entity)
            End While
        End Using

        'Devolviendo Area Superior
        For Each area As Area In lista
            If Not IsDBNull(area.Dependencia) Then
                If ArgArea.DevolverAreaSuperior > 0 Then
                    Dim argCadena As String = CStr(ArgArea.DevolverAreaSuperior)

                    Dim ArgCadenaArray(5) As String

                    For i As Integer = 0 To 4
                        'i = i + 1
                        ArgCadenaArray(i) = Mid(argCadena, i + 1, 1)
                    Next

                    'argumentos = CStr(ArgArea.DevolverAreaSuperior)
                    Select Case (ArgCadenaArray(0))
                        Case 1
                            Dim ArgAreaSup As New ArgumentosArea(CInt(ArgCadenaArray(1)), CInt(ArgCadenaArray(2)), 0, CInt(ArgCadenaArray(3)), 0)
                            If area.Dependencia.HasValue Then
                                area.AreaSuperior = GetAREAByIdArea(area.Dependencia, ArgAreaSup)
                            End If
                        Case 2
                            Dim ArgAreaSup As New ArgumentosArea(ArgCadenaArray(1), ArgCadenaArray(2), ArgArea.DevolverAreaSuperior, ArgCadenaArray(3), 0)
                            area.AreaSuperior = GetAREAByIdArea(area.Dependencia, ArgAreaSup)
                        Case 3
                            If area.TipoArea = "subarea" Then
                                Dim ArgAreaSup As New ArgumentosArea(ArgCadenaArray(1), ArgCadenaArray(2), ArgArea.DevolverAreaSuperior, ArgCadenaArray(3), 0)
                                area.AreaSuperior = GetAREAByIdArea(area.Dependencia, ArgAreaSup)
                            End If
                    End Select
                End If
                'Falta la lista de areas que dependen de esta área 

                If ArgArea.DevolverSubAreas > 0 Then
                    Dim listaSubAreas As New List(Of Area)
                    Dim argSubArea As New ArgumentosArea(1, 0, 0, 0, 1)
                    area.ListaSubareas = GetAreaByIdPadre(area.IdArea, ArgArea)
                End If
            End If
            lista2.Add(area)
        Next

        'El indice depende de la columna con la que este en el SP
        Return lista2
        '
    End Function

    ''Public Function GetAreaByIdPadreRecursivo(ByVal area As Area, ByVal argArea As BussinessEntities.ArgumentosArea) As Area
    ''    Dim listaSubAreas As New List(Of Area)
    ''    listaSubAreas = GetAreaByIdPadre(area.IdArea, argArea)
    ''    area.ListaSubareas = listaSubAreas
    ''    For Each areaHijo As Area In listaSubAreas
    ''        GetAreaByIdPadreRecursivo(area, argArea)
    ''    Next
    ''    Return area
    ''End Function


End Class
