Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoTrabajadorBL : Implements ITipoTrabajadorBL
    Dim factoryRepository As ITipoTrabajadorRepository
    Sub New()
        factoryRepository = New TipoTrabajadorRepository
    End Sub

    Public Function GetTipoTrabajadorByIdCategoria(ByVal idCategoria As Integer) As System.Collections.Generic.List(Of BussinessEntities.TipoTrabajador) Implements ITipoTrabajadorBL.GetTipoTrabajadorByIdCategoria
        Return factoryRepository.GetTipoTrabajadorByIdCategoria(idCategoria)
    End Function

    Public Function GetTipoTrabajadorByIdCategoriaYDisponibles(ByVal idCategoria As Integer, ByVal disponible As Boolean) As System.Collections.Generic.List(Of BussinessEntities.TipoTrabajador) Implements ITipoTrabajadorBL.GetTipoTrabajadorByIdCategoriaYDisponibles
        Return factoryRepository.GetTipoTrabajadorByIdCategoriaYDisponibles(idCategoria, disponible)
    End Function

    Public Function GetTipoTrabajadorByDisponible(ByVal Disponible As Boolean) As System.Collections.Generic.List(Of BussinessEntities.TipoTrabajador) Implements ITipoTrabajadorBL.GetTipoTrabajadorByDisponible
        Return factoryRepository.GetTipoTrabajadorByDisponible(Disponible)
    End Function

    Public Function GetTipoTrabajadorByIdTipoTrabajadorIdCategoria(ByVal idTipoTrabajador As Integer, ByVal idCategoria As Integer) As BussinessEntities.TipoTrabajador Implements ITipoTrabajadorBL.GetTipoTrabajadorByIdTipoTrabajadorIdCategoria
        Return factoryRepository.GetTipoTrabajadorByIdTipoTrabajadorIdCategoria(idTipoTrabajador, idCategoria)
    End Function
End Class
