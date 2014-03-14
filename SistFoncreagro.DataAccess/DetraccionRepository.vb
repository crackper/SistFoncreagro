Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class DetraccionRepository : Inherits MasterDataAccess : Implements IDetraccionRepository

    Public Function GetAllFromDetraccion() As System.Collections.Generic.List(Of BussinessEntities.Detraccion) Implements IDetraccionRepository.GetAllFromDetraccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromDETRACCION")
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveDetraccion(ByVal detraccion As BussinessEntities.Detraccion) Implements IDetraccionRepository.SaveDetraccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDETRACCION")
        command.Parameters.AddWithValue("ctaAbono", detraccion.CtaAbono)
        command.Parameters.AddWithValue("ctaCargo", detraccion.CtaCargo)
        command.Parameters.AddWithValue("ElementoAfecto ", detraccion.ElementoAfecto)
        command.Parameters.AddWithValue("idDetraccion", detraccion.IdDetraccion)
        command.Parameters.AddWithValue("porcentaje", detraccion.Porcentaje)
        command.Parameters.AddWithValue("codigo", detraccion.Codigo)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Detraccion)
        Dim lista As New List(Of Detraccion)
        Dim PlanContableRepository As New PlanContableRepository
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)


            While reader.Read
                Dim _Detraccion As New Detraccion() With
                {
                    .CtaAbono = reader.GetValue(0),
                    .ElementoAfecto = reader.GetValue(2),
                    .Estado = reader.GetValue(3),
                    .IdDetraccion = reader.GetValue(4),
                    .Porcentaje = reader.GetValue(5),
                    .Codigo = reader.GetValue(6)
                }
                If Not (reader.IsDBNull(1)) Then
                    _Detraccion.CtaCargo = reader.GetValue(1)
                End If
                _Detraccion.PlanContableAbono = PlanContableRepository.GetCodigoFromPLANCONTABLE(reader.GetValue(0))
                lista.Add(_Detraccion)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function

    Public Function GetDetraccionByIdDetraccion(ByVal IdDetraccion As Integer) As BussinessEntities.Detraccion Implements IDetraccionRepository.GetDETRACCIONByIdDetraccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDETRACCIONByIdDetraccion")
        command.Parameters.AddWithValue("IdDetraccion", IdDetraccion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub UpdateEstadoDETRACCION(ByVal idDetraccion As Integer) Implements IDetraccionRepository.UpdateEstadoDETRACCION
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoDETRACCION")
        command.Parameters.AddWithValue("IdDetraccion", idDetraccion)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
