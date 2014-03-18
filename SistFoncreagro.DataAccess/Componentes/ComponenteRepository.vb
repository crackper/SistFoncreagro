Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Partial Public Class ComponenteRepository : Inherits MasterDataAccess : Implements IComponenteRepository

    Public Function GetAllFromComponente() As System.Collections.Generic.List(Of BussinessEntities.Componente) Implements IComponenteRepository.GetAllFromComponente
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCOMPONENTE")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromComponenteById(ByVal _id As Integer) As BussinessEntities.Componente Implements IComponenteRepository.GetFromComponenteById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCOMPONENTEByIdComponente")
        command.Parameters.AddWithValue("idComponente", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Componente)
        Dim lista As New List(Of Componente)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Componente As New Componente() With
                    {
                        .IdComponente = reader.GetValue(0)
                    }
                If Not (reader.IsDBNull(1)) Then
                    _Componente.Nombre = reader.GetValue(1)
                End If
                If Not (reader.IsDBNull(2)) Then
                    _Componente.Descripcion = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(3)) Then
                    _Componente.Codigo = reader.GetValue(3)
                End If
                lista.Add(_Componente)
            End While
        End Using
        Return lista
    End Function

    Public Function SaveComponente(ByVal _Componente As BussinessEntities.Componente) As Integer Implements IComponenteRepository.SaveComponente
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCOMPONENTE")
        Dim Id As Int32

        command.Parameters.AddWithValue("IdComponente", _Componente.IdComponente)
        command.Parameters.AddWithValue("Nombre", _Componente.Nombre)
        command.Parameters.AddWithValue("Descripcion", _Componente.Descripcion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Function DeleteComponente(ByVal _id As Integer) As String Implements IComponenteRepository.DeleteComponente
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCOMPONENTE")
        command.Parameters.AddWithValue("idComponente", _id)

        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function

    Public Function GetFromComponenteByIdProyAndIdConv(ByVal _IdProy As Integer, ByVal _IdConv As Integer) As System.Collections.Generic.List(Of BussinessEntities.Componente) Implements IComponenteRepository.GetFromComponenteByIdProyAndIdConv
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCOMPONENTEByIdProyAndIdConv")
        command.Parameters.AddWithValue("idProyecto", _IdProy)
        command.Parameters.AddWithValue("idConvenio", _IdConv)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromComponenteByIdConveProy(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.Componente) Implements IComponenteRepository.GetFromComponenteByIdConveProy
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCOMPONENTEByIdConveProy")
        command.Parameters.AddWithValue("idConvProy", _id)
        Return SelectObjectFactory(command)
    End Function
End Class
