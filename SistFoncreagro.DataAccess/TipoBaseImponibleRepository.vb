Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoBaseImponibleRepository : Inherits MasterDataAccess : Implements ITipoBaseImponibleRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoBaseImponible)
        Dim lista As New List(Of TipoBaseImponible)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _TipoBaseImponible As New TipoBaseImponible() With
                {
                    .Descripcion = reader.GetValue(0),
                    .IdTipoBaseImp = reader.GetValue(1)
                }


                lista.Add(_TipoBaseImponible)
            End While
        End Using
        Return lista
    End Function

    Public Function GetAllFromTIPOBASEIMPONIBLE() As System.Collections.Generic.List(Of BussinessEntities.TipoBaseImponible) Implements ITipoBaseImponibleRepository.GetAllFromTIPOBASEIMPONIBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOBASEIMPONIBLE")
        Return SelectObjectFactory(command)
    End Function
End Class
