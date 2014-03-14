Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class FormacionRequeridaBL : Implements IFormacionRequeridaBL
    Dim factoryrepository As IFormacionRequeridaRepository

    Public Sub New()
        factoryrepository = New FormacionRequeridaRepository
    End Sub

    Public Sub DeleteREQUISITOADICIONAL(ByVal IdFormacion As Integer, ByVal IdPosicion As Integer) Implements IFormacionRequeridaBL.DeleteREQUISITOADICIONAL
        factoryrepository.DeleteREQUISITOADICIONAL(IdFormacion, IdPosicion)
    End Sub

    Public Function GetAllFromFORMACIONREQUERIDA() As System.Collections.Generic.List(Of BussinessEntities.FormacionRequerida) Implements IFormacionRequeridaBL.GetAllFromFORMACIONREQUERIDA
        Return factoryrepository.GetAllFromFORMACIONREQUERIDA()
    End Function

    Public Function GetFORMACIONREQUERIDAByIdFormacionAndIdPosicion(ByVal IdFormacion As Integer, ByVal IdPosicion As Integer) As BussinessEntities.FormacionRequerida Implements IFormacionRequeridaBL.GetFORMACIONREQUERIDAByIdFormacionAndIdPosicion
        Return factoryrepository.GetFORMACIONREQUERIDAByIdFormacionAndIdPosicion(IdFormacion, IdPosicion)
    End Function

    Public Function GetFORMACIONREQUERIDAByIdPosicion(ByVal IdPosicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.FormacionRequerida) Implements IFormacionRequeridaBL.GetFORMACIONREQUERIDAByIdPosicion
        Return factoryrepository.GetFORMACIONREQUERIDAByIdPosicion(IdPosicion)
    End Function

    Public Function SaveFORMACIONREQUERIDA(ByVal formacionRequerida As BussinessEntities.FormacionRequerida) As Integer Implements IFormacionRequeridaBL.SaveFORMACIONREQUERIDA
        Return factoryrepository.SaveFORMACIONREQUERIDA(formacionRequerida)
    End Function
End Class
