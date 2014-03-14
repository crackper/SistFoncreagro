Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ReqLicSoulRepository : Inherits MasterDataAccess : Implements IReqLicSoulRepository
    Public Sub SaveReqLicSoul(ByVal reqLicS As BussinessEntities.ReqLicSoul) Implements IReqLicSoulRepository.SaveReqLicSoul
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveReqLicSoul")
        command.Parameters.AddWithValue("IdRequerimiento", reqLicS.IdRequerimiento)
        command.Parameters.AddWithValue("Tipo", reqLicS.Tipo)
        command.Parameters.AddWithValue("IdPersonalReq", reqLicS.IdPersonalReq)
        command.Parameters.AddWithValue("IdPersonalNuevo", reqLicS.IdPersonalNuevo)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
