Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class SistemaDePensionesBL : Implements ISistemaDePensionesBL

    Dim factoryRepository As ISistemaDePensionesRepository
    Sub New()
        factoryRepository = New SistemaDePensionesRepository
    End Sub
    Public Function GetAllFromSistemaPensiones() As System.Collections.Generic.List(Of BussinessEntities.SistemaDePensiones) Implements ISistemaDePensionesBL.GetAllFromSistemaPensiones
        Return factoryRepository.GetAllFromSistemaPensiones()
    End Function
    Public Sub SaveSistemaPensiones(ByVal sistemaPension As BussinessEntities.SistemaDePensiones) Implements ISistemaDePensionesBL.SaveSistemaPensiones
        factoryRepository.SaveSistemaPensiones(sistemaPension)
    End Sub
    Public Function GetAllFromSistemaPensionesByTipoSp(ByVal idTipoSp As Integer) As System.Collections.Generic.List(Of BussinessEntities.SistemaDePensiones) Implements ISistemaDePensionesBL.GetAllFromSistemaPensionesByTipoSp
        Return factoryRepository.GetAllFromSistemaPensionesByTipoSp(idTipoSp)
    End Function

    Public Function GetSistemaDePensionesByIdSistemaPensiones(ByVal IdSistemaPensiones As Integer) As Object Implements ISistemaDePensionesBL.GetSistemaDePensionesByIdSistemaPensiones
        Return factoryRepository.GetSistemaDePensionesByIdSistemaPensiones(IdSistemaPensiones)
    End Function
End Class
