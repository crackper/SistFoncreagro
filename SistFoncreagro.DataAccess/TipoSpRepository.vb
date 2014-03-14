Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class TipoSpRepository : Inherits MasterDataAccess : Implements ITipoSpRepository

    Public Function GetAllFromTipoSp() As System.Collections.Generic.List(Of BussinessEntities.TipoSp) Implements ITipoSpRepository.GetAllFromTipoSp
        Dim command As SqlCommand =
               MyBase.CreateSPCommand("GetAllFromTipoSp")
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveTipoSp(ByVal tipoSp As BussinessEntities.TipoSp) Implements ITipoSpRepository.SaveTipoSp

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoSp)
        Dim listaTipoSp As New List(Of TipoSp)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim tipoSp As New TipoSp
                With tipoSp
                    .IdTipoSP = reader.GetInt32(0)
                    .Tipo = reader.GetString(1)
                End With
                If Not reader.IsDBNull(2) Then
                    tipoSp.IdLegislacion = reader.GetInt32(2)
                End If
                listaTipoSp.Add(tipoSp)
            End While
        End Using
        Return listaTipoSp
    End Function
End Class
