﻿Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common.Configuration
Imports SistFoncreagro.BussinessEntities
Imports System.Data

Partial Public Class ProyectoRepository : Inherits MasterDataAccess : Implements IProyectoRepository

    Dim _convenioFactory As IConvenioRepository

    Public Function GetProyectoDtoyIdProyecto(idProyecto As Integer) As BussinessEntities.ProyectoDto Implements IProyectoRepository.GetProyectoDtoyIdProyecto
        _convenioFactory = New ConvenioRepository()

        Dim query = db.ExecuteSprocAccessor(Of ProyectoDto)("GetProyectoDtoyIdProyecto", idProyecto)

        Dim _proyecto = query.SingleOrDefault()

        _proyecto.Convenios = _convenioFactory.GetConveniosByIdProyecto(_proyecto.IdProyecto)

        Return _proyecto
       
    End Function
End Class
