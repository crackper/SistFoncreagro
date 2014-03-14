Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AreaBL : Implements IAreaBL

    Dim factoryrepository As IAreaRepository

    Public Sub New()
        factoryrepository = New AreaRepository
    End Sub

    Public Sub DeleteArea(ByVal idArea As Integer) Implements IAreaBL.DeleteArea
        factoryrepository.DeleteArea(idArea)
    End Sub

    Public Function GetAllFromArea(ByVal argArea As BussinessEntities.ArgumentosArea) As System.Collections.Generic.List(Of BussinessEntities.Area) Implements IAreaBL.GetAllFromArea
        Return factoryrepository.GetAllFromArea(argArea)
    End Function

    Public Function GetAllFromArea2() As System.Collections.Generic.List(Of BussinessEntities.Area) Implements IAreaBL.GetAllFromArea2
        Dim argArea2 As New BussinessEntities.ArgumentosArea(0, 0, 0, 0, 0)
        Return factoryrepository.GetAllFromArea(argArea2)
    End Function

    Public Function GetAREAByIdArea(ByVal idArea As Integer, ByVal argArea As BussinessEntities.ArgumentosArea) As Object Implements IAreaBL.GetAREAByIdArea
        Return factoryrepository.GetAREAByIdArea(idArea, argArea)
    End Function

    Public Function GetAreaByIdProyecto(ByVal IdProyecto As Integer, ByVal argArea As BussinessEntities.ArgumentosArea) As Object Implements IAreaBL.GetAreaByIdProyecto
        Return factoryrepository.GetAreaByIdProyecto(IdProyecto, argArea)
    End Function

    Public Function GetAreaByNombre(ByVal Nombre As String, ByVal argArea As BussinessEntities.ArgumentosArea) As BussinessEntities.Area Implements IAreaBL.GetAreaByNombre
        Return factoryrepository.GetAreaByNombre(Nombre, argArea)
    End Function

    Public Function GetAreaByTipoArea(ByVal TipoArea As String, ByVal argArea As BussinessEntities.ArgumentosArea) As Object Implements IAreaBL.GetAreaByTipoArea
        Return factoryrepository.GetAreaByTipoArea(TipoArea, argArea)
    End Function

    Public Function GetAreaByIdPadre(ByVal IdPadre As Integer, ByVal argArea As BussinessEntities.ArgumentosArea) As System.Collections.Generic.List(Of BussinessEntities.Area) Implements IAreaBL.GetAreaByIdPadre
        Return factoryrepository.GetAreaByIdPadre(IdPadre, argArea)
    End Function

    Public Function GetTipoAreaDeSubArea(ByVal IdPadre As Integer) As String Implements IAreaBL.GetTipoAreaDeSubArea
        Return factoryrepository.GetTipoAreaDeSubArea(IdPadre)
    End Function

    Public Function SaveArea(ByVal area As BussinessEntities.Area) As Integer Implements IAreaBL.SaveArea
        Return factoryrepository.SaveArea(area)
    End Function

    Public Function GetAreaSuperior(ByVal argArea As BussinessEntities.ArgumentosArea) As BussinessEntities.Area Implements IAreaBL.GetAreaSuperior
        Return factoryrepository.GetAreaSuperior(argArea)
    End Function

    Public Function AgregarProyectoAArea(ByVal IdProyecto As Integer, ByVal area As Area) As Integer Implements IAreaBL.AgregarProyectoAArea
        Dim areaEnCadenaHastaAreaGeneral As New Area
        Dim argArea As New ArgumentosArea(0, 0, 30000, 0, 0) '30000: 3 devuelve el area superior hasta el área genela 0000 sin jefe de area, ni proyectos ni posiciones
        areaEnCadenaHastaAreaGeneral = GetAREAByIdArea(area.IdArea, argArea)
        Return AgregarProyectoEnCadenaHastaAreaGeneral(IdProyecto, areaEnCadenaHastaAreaGeneral)
    End Function

    Function AgregarProyectoEnCadenaHastaAreaGeneral(ByVal IdProyecto As Integer, ByVal area As Area) As Integer
        If area.TipoArea = "subarea" Or area.TipoArea = "general" Then

            Dim ProyectoAreaRepository As New ProyectoAreaRepository
            Dim ProyectoArea As New ProyectoArea

            ProyectoArea.IdProyectoArea = 0
            ProyectoArea.IdArea = area.IdArea
            ProyectoArea.IdProyecto = IdProyecto

            If area.ControlaProyectos = False Then
                area.ControlaProyectos = True
                SaveArea(area)
            End If

            Return ProyectoAreaRepository.SaveProyectoArea(ProyectoArea)
            'Obtener areaSuperior y agregarle proyecto.
            If Not area.AreaSuperior Is Nothing And area.TipoArea = "subarea" Then
                AgregarProyectoAArea(IdProyecto, area.AreaSuperior)
            End If

        End If
        Return 0
    End Function

    Public Function DeleteAreaAndSubAreas(ByVal IdArea As Int32) As Integer Implements IAreaBL.DeleteAreaAndSubAreas
        'Primero obtenemos el área con todos sus hijos e hijos de sus hijos
        Dim areaEliminar As New Area
        Dim argAreaEliminar As New ArgumentosArea(0, 0, 0, 0, 1)
        areaEliminar = factoryrepository.GetAREAByIdArea(IdArea, argAreaEliminar)
        Return DeleteAreaRecursiva(areaEliminar)
    End Function

    Protected Function DeleteAreaRecursiva(ByVal area As BussinessEntities.Area) As Integer
        If area.ListaSubareas.Count > 0 Then
            For Each areaHijo In area.ListaSubareas
                DeleteAreaRecursiva(areaHijo)
            Next
            Return 0
        Else
            factoryrepository.DeleteArea(area.IdArea)
            Return 1
        End If
    End Function


End Class
