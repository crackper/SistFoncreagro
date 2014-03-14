Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class VinculoFamiliarRepository : Inherits MasterDataAccess : Implements IVinculoFamiliarRepository

    Public Function GetAllFromVINCULOFAMILIAR() As System.Collections.Generic.List(Of BussinessEntities.VinculoFamiliar) Implements IVinculoFamiliarRepository.GetAllFromVINCULOFAMILIAR
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromVINCULOFAMILIAR")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of VinculoFamiliar)
        Dim lista As New List(Of VinculoFamiliar)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New VinculoFamiliar
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdVinculo")) Then
                    entity.IdVinculo = reader.GetValue(reader.GetOrdinal("IdVinculo"))
                End If
                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

End Class
