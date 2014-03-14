Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class HabilidadesBL : Implements IHabilidadesBL
    Dim factoryrepository As IHabilidadesRepository

    Public Sub New()
        factoryrepository = New HabilidadesRepository
    End Sub
    Public Sub DeleteHabilidades(ByVal idHabilidad As Integer) Implements IHabilidadesBL.DeleteHabilidades
        factoryrepository.DeleteHabilidades(idHabilidad)
    End Sub

    Public Function GetAllFromHABILIDADES() As System.Collections.Generic.List(Of BussinessEntities.Habilidades) Implements IHabilidadesBL.GetAllFromHABILIDADES
        Return factoryrepository.GetAllFromHABILIDADES()
    End Function

    Public Function GetHABILIDAESByIdHabilidadAndIdPosicion(ByVal IdHabilidad As Integer, ByVal IdPosicion As Integer) As BussinessEntities.Habilidades Implements IHabilidadesBL.GetHABILIDAESByIdHabilidadAndIdPosicion
        Return factoryrepository.GetHABILIDAESByIdHabilidadAndIdPosicion(IdHabilidad, IdPosicion)
    End Function

    Public Function GetHABILIDAESByIdPosicion(ByVal IdPosicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.Habilidades) Implements IHabilidadesBL.GetHABILIDAESByIdPosicion
        Return factoryrepository.GetHABILIDAESByIdPosicion(IdPosicion)
    End Function

    Public Function SaveHABILIDADES(ByVal habilidades As BussinessEntities.Habilidades) As Integer Implements IHabilidadesBL.SaveHABILIDADES
        Return factoryrepository.SaveHABILIDADES(habilidades)
    End Function
End Class
