Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ReqLicSoulBL : Implements IReqLicSoulBL
    Dim factoryrepository As IReqLicSoulRepository

    Public Sub New()
        factoryrepository = New ReqLicSoulRepository
    End Sub

    Public Sub SaveReqLicSoul(ByVal reqLicS As BussinessEntities.ReqLicSoul) Implements IReqLicSoulBL.SaveReqLicSoul
        factoryrepository.SaveReqLicSoul(reqLicS)
    End Sub
End Class
