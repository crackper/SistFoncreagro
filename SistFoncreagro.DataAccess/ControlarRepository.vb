Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ControlarRepository : Inherits MasterDataAccess : Implements IControlarRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Controlar)
        Dim lista As New List(Of Controlar)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Controlar As New Controlar() With
                {
                  .IdControl = reader.GetValue(0),
                  .IdDetalleEje = reader.GetValue(1),
                 .Cantidad = reader.GetValue(6),
                .ExisteCompromiso = reader.GetValue(7)
                }
                If Not (reader.IsDBNull(2)) Then
                    _Controlar.IdDetalleCom = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(3)) Then
                    _Controlar.IdSubActividad = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _Controlar.IdTarea = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _Controlar.IdTaller = reader.GetValue(5)
                End If
               
                lista.Add(_Controlar)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteCONTROLAR(ByVal IdControl As Integer) Implements IControlarRepository.DeleteCONTROLAR
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCONTROLAR")
        command.Parameters.AddWithValue("IdControl", IdControl)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetCONTROLARByIdControl(ByVal IdControl As Integer) As BussinessEntities.Controlar Implements IControlarRepository.GetCONTROLARByIdControl
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONTROLARByIdControl")
        command.Parameters.AddWithValue("IdControl", IdControl)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetCONTROLARByIdDetalleEje(ByVal IdDetalleEje As Object) As System.Collections.Generic.List(Of BussinessEntities.Controlar) Implements IControlarRepository.GetCONTROLARByIdDetalleEje
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONTROLARByIdDetalleEje")
        command.Parameters.AddWithValue("IdDetalleEje", IdDetalleEje)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveCONTROLAR(ByVal _Controlar As BussinessEntities.Controlar) Implements IControlarRepository.SaveCONTROLAR
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCONTROLAR")
        command.Parameters.AddWithValue("Cantidad", _Controlar.Cantidad)
        command.Parameters.AddWithValue("Cantidad", _Controlar.Cantidad)
        command.Parameters.AddWithValue("ExisteCompromiso", _Controlar.ExisteCompromiso)
        command.Parameters.AddWithValue("IdControl", _Controlar.IdControl)
        command.Parameters.AddWithValue("IdDetalleCom", _Controlar.IdDetalleCom)
        command.Parameters.AddWithValue("IdDetalleEje", _Controlar.IdDetalleEje)
        command.Parameters.AddWithValue("IdSubActividad", _Controlar.IdSubActividad)
        command.Parameters.AddWithValue("IdTaller", _Controlar.IdTaller)
        command.Parameters.AddWithValue("IdTarea", _Controlar.IdTarea)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
