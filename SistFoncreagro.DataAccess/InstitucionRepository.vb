Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class InstitucionRepository : Inherits MasterDataAccess : Implements IInstitucionRepository

    Public Sub DeleteInstitucion(ByVal _id As Integer) Implements IInstitucionRepository.DeleteInstitucion
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteINSTITUCION")
        command.Parameters.AddWithValue("idInstitucion", _id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function SaveInstitucion(ByVal _Institucion As BussinessEntities.Institucion) As Integer Implements IInstitucionRepository.SaveInstitucion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveINSTITUCION")
        Dim Id As Int32

        command.Parameters.AddWithValue("IdInstitucion", _Institucion.IdInstitucion)
        command.Parameters.AddWithValue("IdConvenio", _Institucion.IdConvenio)
        command.Parameters.AddWithValue("Tipo", _Institucion.Tipo)
        command.Parameters.AddWithValue("IdProveedorCliente", _Institucion.IdProveedorCliente)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Institucion)
        Dim lista As New List(Of Institucion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Institucion As New Institucion() With
                    {
                        .IdInstitucion = reader.GetValue(reader.GetOrdinal("IdInstitucion")),
                        .IdConvenio = reader.GetValue(reader.GetOrdinal("IdConvenio")),
                        .IdProveedorCliente = reader.GetValue(reader.GetOrdinal("IdProveedorCliente")),
                        .Tipo = reader.GetValue(reader.GetOrdinal("Tipo"))
                    }
                Dim _miInstitucion As New ProveedorClienteRepository
                _Institucion._Instituciones = _miInstitucion.GetAllFromProveedorClienteById(_Institucion.IdProveedorCliente)
                lista.Add(_Institucion)
            End While
        End Using
        Return lista
    End Function

    Public Function GetInstitucionByIdconvenio(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.Institucion) Implements IInstitucionRepository.GetInstitucionByIdconvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetINSTITUCIONByIdConvenio")
        command.Parameters.AddWithValue("IdConvenio", _id)
        Return SelectObjectFactory(command)
    End Function
End Class
