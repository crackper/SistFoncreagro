Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoCtaContableRepository : Inherits MasterDataAccess : Implements ITipoCtaContableRepository

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoCtaContable)
        Dim lista As New List(Of TipoCtaContable)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _TipoCtaContable As New TipoCtaContable() With
                {
                   .Descripcion = reader.GetValue(0),
                   .IdTipoCtaCont = reader.GetValue(1)
                }

                lista.Add(_TipoCtaContable)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromTIPOCTACONTABLE() As System.Collections.Generic.List(Of BussinessEntities.TipoCtaContable) Implements ITipoCtaContableRepository.GetAllFromTIPOCTACONTABLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOCTACONTABLE")
        Return SelectObjectFactory(command)
    End Function
End Class
