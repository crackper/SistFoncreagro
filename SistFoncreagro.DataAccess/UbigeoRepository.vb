Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class UbigeoRepository : Inherits MasterDataAccess : Implements IUbigeoRepository
    Public Function GetAllFromUbigeo() As System.Collections.Generic.List(Of BussinessEntities.Ubigeo) Implements IUbigeoRepository.GetAllFromUbigeo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromUBIGEO")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Ubigeo)
        Dim lista As New List(Of Ubigeo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Ubigeo As New Ubigeo() With
                    {
                        .CUBIGEO = reader.GetValue(reader.GetOrdinal("CUBIGEO"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("CDD"))) Then
                    _Ubigeo.CDD = reader.GetValue(reader.GetOrdinal("CDD"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("CPV"))) Then
                    _Ubigeo.CPV = reader.GetValue(reader.GetOrdinal("CPV"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("CDS"))) Then
                    _Ubigeo.CDS = reader.GetValue(reader.GetOrdinal("CDS"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("CCP"))) Then
                    _Ubigeo.CCP = reader.GetValue(reader.GetOrdinal("CCP"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("CCA"))) Then
                    _Ubigeo.CCA = reader.GetValue(reader.GetOrdinal("CCA"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Nombre"))) Then
                    _Ubigeo.Nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FK"))) Then
                    _Ubigeo.FK = reader.GetValue(reader.GetOrdinal("FK"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Nivel"))) Then
                    _Ubigeo.Nivel = reader.GetValue(reader.GetOrdinal("Nivel"))
                End If

                lista.Add(_Ubigeo)
            End While
        End Using
        Return lista
    End Function

    Public Sub SaveUbigeo(ByVal _Ubigeo As BussinessEntities.Ubigeo) Implements IUbigeoRepository.SaveUbigeo
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveUBIGEO")

        command.Parameters.AddWithValue("IdUbigeo", _Ubigeo.CUBIGEO)
        command.Parameters.AddWithValue("CDD ", _Ubigeo.CDD)
        command.Parameters.AddWithValue("CPV ", _Ubigeo.CPV)
        command.Parameters.AddWithValue("CDS ", _Ubigeo.CDS)
        command.Parameters.AddWithValue("CCP ", _Ubigeo.CCP)
        command.Parameters.AddWithValue("CCA", _Ubigeo.CCA)
        command.Parameters.AddWithValue("Nombre", _Ubigeo.Nombre)
        command.Parameters.AddWithValue("Descripcion", _Ubigeo.Nivel)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function DeleteUbigeo(ByVal _id As String) As String Implements IUbigeoRepository.DeleteUbigeo
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteUBIGEO")
        command.Parameters.AddWithValue("CUbigeo", _id)

        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function

    Public Function GetUbigeoByIdUbigeo(ByVal _IdUbigeo As String) As BussinessEntities.Ubigeo Implements IUbigeoRepository.GetUbigeoByIdUbigeo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetUBIGEOByIdUbigeo")
        command.Parameters.AddWithValue("CUbigeo", _IdUbigeo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetUBIGEOByParameter(ByVal texto As String) As System.Collections.Generic.List(Of BussinessEntities.Ubigeo) Implements IUbigeoRepository.GetUBIGEOByParameter
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetUBIGEOByParameter")
        command.Parameters.AddWithValue("texto", texto)
        Return SelectObjectFactory(command)
    End Function
End Class
