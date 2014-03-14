Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ClasificacionRepository : Inherits MasterDataAccess : Implements IClasificacionRepository
    Dim plan As IPlanContableRepository
    Sub New()
        plan = New PlanContableRepository
    End Sub
    Public Function GetAllFromClasificacion() As System.Collections.Generic.List(Of BussinessEntities.Clasificacion) Implements IClasificacionRepository.GetAllFromClasificacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCLASIFICACION")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromClasificacionById(ByVal _id As Integer) As BussinessEntities.Clasificacion Implements IClasificacionRepository.GetFromClasificacionById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCLASIFICACIONByIdClasificacion")
        command.Parameters.AddWithValue("idClasificacion", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveClasificacion(ByVal _Clasificacion As BussinessEntities.Clasificacion) Implements IClasificacionRepository.SaveClasificacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveClasificacion")

        command.Parameters.AddWithValue("IdClasificacion", _Clasificacion.IdClasificacion)
        command.Parameters.AddWithValue("Descripcion", _Clasificacion.Descripcion)
        command.Parameters.AddWithValue("Tipo", _Clasificacion.Tipo)
        command.Parameters.AddWithValue("IdPlan", _Clasificacion.IdPlan)
        command.Parameters.AddWithValue("Codigo", _Clasificacion.Codigo)
        command.Parameters.AddWithValue("IdPlanActivoFijo", _Clasificacion.IdPlanActivoFijo)
        command.Parameters.AddWithValue("IdPlanDepreciacion", _Clasificacion.IdPlanDepreciacion)
        command.Parameters.AddWithValue("IdPlanDepreciacion1", _Clasificacion.IdPlanDepreciacion1)
        command.Parameters.AddWithValue("IdPlanDonacion", _Clasificacion.IdPlanDonacion)
        command.Parameters.AddWithValue("IdPorcDepreciacion", _Clasificacion.IdPorcDepreciacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Clasificacion)
        Dim lista As New List(Of Clasificacion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Clasificacion As New Clasificacion()
                With _Clasificacion
                    .IdClasificacion = reader.GetInt32(0)
                    .Descripcion = reader.GetString(1)
                    .Tipo = reader.GetInt32(2)
                    .Codigo = reader.GetValue(9)
                End With
                If Not reader.IsDBNull(3) Then
                    _Clasificacion.IdPlan = reader.GetInt32(3)
                    _Clasificacion.Plan = plan.GetPLANCONTABLEByIdPlan(reader.GetInt32(3))
                End If
                If Not reader.IsDBNull(4) Then
                    _Clasificacion.IdPlanDonacion = reader.GetInt32(4)
                End If
                If Not reader.IsDBNull(5) Then
                    _Clasificacion.IdPlanActivoFijo = reader.GetInt32(5)
                End If
                If Not reader.IsDBNull(6) Then
                    _Clasificacion.IdPorcDepreciacion = reader.GetInt32(6)
                End If
                If Not reader.IsDBNull(7) Then
                    _Clasificacion.IdPlanDepreciacion = reader.GetInt32(7)
                End If
                If Not reader.IsDBNull(8) Then
                    _Clasificacion.IdPlanDepreciacion1 = reader.GetInt32(8)
                End If
                lista.Add(_Clasificacion)
            End While
        End Using
        Return lista
    End Function

    Public Function GetFromClasificacionByTipo(ByVal _Tipo As Integer) As System.Collections.Generic.List(Of BussinessEntities.Clasificacion) Implements IClasificacionRepository.GetFromClasificacionByTipo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCLASIFICACIONByTipo")
        command.Parameters.AddWithValue("tipo", _Tipo)
        Return SelectObjectFactory(command)
    End Function

    Public Sub DeleteClasificacion(ByVal _id As Integer) Implements IClasificacionRepository.DeleteClasificacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteClasificacionGeneral")
        command.Parameters.AddWithValue("IdClasificacion", _id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetCLASIFICACIONByIdCatalogo(ByVal IdCatalogo As Integer) As BussinessEntities.Clasificacion Implements IClasificacionRepository.GetCLASIFICACIONByIdCatalogo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCLASIFICACIONByIdCatalogo")
        command.Parameters.AddWithValue("IdCatalogo", IdCatalogo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
End Class
