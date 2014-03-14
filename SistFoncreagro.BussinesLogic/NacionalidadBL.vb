Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class NacionalidadBL : Implements INacionalidadBL
    Dim factoryRepository As INacionalidadRepository
    Sub New()
        factoryRepository = New NacionalidadRepository
    End Sub
    Public Sub DeleNacionalidad(ByVal idNacionalidad As Integer) Implements INacionalidadBL.DeleNacionalidad
        Me.factoryRepository.DeleNacionalidad(idNacionalidad)
    End Sub

    Public Function GetAllFromNacionalidad() As System.Collections.Generic.List(Of BussinessEntities.Nacionalidad) Implements INacionalidadBL.GetAllFromNacionalidad
        Return Me.factoryRepository.GetAllFromNacionalidad()
    End Function

    Public Function GetNacionalidadByIdNacionalidad(ByVal idNacionalidad As Integer) As BussinessEntities.Nacionalidad Implements INacionalidadBL.GetNacionalidadByIdNacionalidad
        Return Me.factoryRepository.GetNacionalidadByIdNacionalidad(idNacionalidad)
    End Function

    Public Sub SaveNacionalidad(ByVal nacionalidad As BussinessEntities.Nacionalidad) Implements INacionalidadBL.SaveNacionalidad
        Me.factoryRepository.SaveNacionalidad(nacionalidad)
    End Sub
End Class
