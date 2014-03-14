Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class PlanContableRepository : Inherits MasterDataAccess : Implements IPlanContableRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of PlanContable)
        Dim lista As New List(Of PlanContable)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _PlanContable As New PlanContable() With
                {
                   .Codigo = reader.GetValue(0),
                .Estado = reader.GetValue(7),
                   .IdPlan = reader.GetValue(11),
                   .Nivel = reader.GetValue(15),
                   .Nombre = reader.GetValue(16)
               }
                If Not (reader.IsDBNull(1)) Then
                    _PlanContable.CtaAbono = reader.GetValue(1)
                End If
                If Not (reader.IsDBNull(2)) Then
                    _PlanContable.CtaCargo = reader.GetValue(2)
                End If

                If Not (reader.IsDBNull(3)) Then
                    _PlanContable.CtaGanancia = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _PlanContable.CtaOpcional = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _PlanContable.CtaPerdida = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(6)) Then
                    _PlanContable.CtaPrincipal = reader.GetValue(6)
                End If

                If Not (reader.IsDBNull(8)) Then
                    _PlanContable.GenerarDestino = reader.GetValue(8)
                End If
                If Not (reader.IsDBNull(9)) Then
                    _PlanContable.IdAplTipoCambio = reader.GetValue(9)
                End If
                If Not (reader.IsDBNull(10)) Then
                    _PlanContable.IdEstFinanciero = reader.GetValue(10)
                End If

                If Not (reader.IsDBNull(12)) Then
                    _PlanContable.IdTipoAjuste = reader.GetValue(12)
                End If
                If Not (reader.IsDBNull(13)) Then
                    _PlanContable.IdTipoCancelacion = reader.GetValue(13)
                End If

                If Not (reader.IsDBNull(14)) Then
                    _PlanContable.IdTipoCtaCont = reader.GetValue(14)
                End If

                If Not (reader.IsDBNull(17)) Then
                    _PlanContable.RequiereCCosto = reader.GetValue(17)
                End If
                If Not (reader.IsDBNull(18)) Then
                    _PlanContable.RequiereCodAux = reader.GetValue(18)
                End If
                If Not (reader.IsDBNull(19)) Then
                    _PlanContable.RequiereRegistro = reader.GetValue(19)
                End If
                If Not (reader.IsDBNull(20)) Then
                    _PlanContable.IdMoneda = reader.GetValue(20)
                End If
                lista.Add(_PlanContable)
            End While
        End Using
        Return lista
    End Function
    Private Function SelectObjectFactory1(ByVal command As SqlCommand) As List(Of PlanContable)
        Dim lista As New List(Of PlanContable)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _PlanContable As New PlanContable() With
                {
                   .Codigo = reader.GetValue(0),
                   .Nombre = reader.GetValue(16),
                   .IdPlan = reader.GetValue(11)
                 }

                lista.Add(_PlanContable)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllPLANCONTABLE() As System.Collections.Generic.List(Of BussinessEntities.PlanContable) Implements IPlanContableRepository.GetAllPLANCONTABLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPLANCONTABLE")
        Return SelectObjectFactory(command)
    End Function

    Public Sub DeletePLANCONTABLE(ByVal IdPlan As Integer) Implements IPlanContableRepository.DeletePLANCONTABLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletePLANCONTABLE")
        command.Parameters.AddWithValue("IdPlan", IdPlan)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetPLANCONTABLEByIdPlan(ByVal IdPlan As Integer) As BussinessEntities.PlanContable Implements IPlanContableRepository.GetPLANCONTABLEByIdPlan
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPLANCONTABLEByIdPlan")
        command.Parameters.AddWithValue("IdPlan", IdPlan)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetPLANCONTABLEByParameter(ByVal Texto As String) As System.Collections.Generic.List(Of BussinessEntities.PlanContable) Implements IPlanContableRepository.GetPLANCONTABLEByParameter
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPLANCONTABLEByParameter")
        command.Parameters.AddWithValue("Texto", Texto)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetPLANCONTABLEByParameterCompras(ByVal Texto As String) As System.Collections.Generic.List(Of BussinessEntities.PlanContable) Implements IPlanContableRepository.GetPLANCONTABLEByParameterCompras
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPLANCONTABLEByParameterCompras")
        command.Parameters.AddWithValue("Texto", Texto)
        Return SelectObjectFactory(command)
    End Function

    Public Function SavePLANCONTABLE(ByVal _PlanContable As BussinessEntities.PlanContable) As Integer Implements IPlanContableRepository.SavePLANCONTABLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePLANCONTABLE")
        Dim id As Int32
        command.Parameters.AddWithValue("Codigo", _PlanContable.Codigo)
        command.Parameters.AddWithValue("CtaAbono", _PlanContable.CtaAbono)
        command.Parameters.AddWithValue("CtaCargo", _PlanContable.CtaCargo)
        command.Parameters.AddWithValue("CtaGanancia", _PlanContable.CtaGanancia)
        command.Parameters.AddWithValue("CtaOpcional", _PlanContable.CtaOpcional)
        command.Parameters.AddWithValue("CtaPerdida", _PlanContable.CtaPerdida)
        command.Parameters.AddWithValue("CtaPrincipal", _PlanContable.CtaPrincipal)
        command.Parameters.AddWithValue("GenerarDestino", _PlanContable.GenerarDestino)
        command.Parameters.AddWithValue("IdAplTipoCambio", _PlanContable.IdAplTipoCambio)
        command.Parameters.AddWithValue("IdEstFinanciero", _PlanContable.IdEstFinanciero)
        command.Parameters.AddWithValue("IdPlan", _PlanContable.IdPlan)
        command.Parameters.AddWithValue("IdTipoAjuste", _PlanContable.IdTipoAjuste)
        command.Parameters.AddWithValue("IdTipoCancelacion", _PlanContable.IdTipoCancelacion)
        command.Parameters.AddWithValue("IdTipoCtaCont", _PlanContable.IdTipoCtaCont)
        command.Parameters.AddWithValue("Nivel", _PlanContable.Nivel)
        command.Parameters.AddWithValue("Nombre", _PlanContable.Nombre)
        command.Parameters.AddWithValue("RequiereCCosto", _PlanContable.RequiereCCosto)
        command.Parameters.AddWithValue("RequiereCodAux", _PlanContable.RequiereCodAux)
        command.Parameters.AddWithValue("RequiereRegistro", _PlanContable.RequiereRegistro)
        command.Parameters.AddWithValue("IdMoneda", _PlanContable.IdMoneda)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                id = reader.GetValue(0)
            End If

        End Using
        Return id
    End Function

    Public Sub UpdateEstadoPLANCONTABLE(ByVal IdPlan As Integer) Implements IPlanContableRepository.UpdateEstadoPLANCONTABLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoPLANCONTABLE")
        command.Parameters.AddWithValue("IdPlan", IdPlan)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function VerifyExistePLANCONTABLE(ByVal Codigo As String) As Integer Implements IPlanContableRepository.VerifyExistePLANCONTABLE
        Dim id As Int32
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyExistePLANCONTABLE")
        command.Parameters.AddWithValue("Codigo", Codigo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                id = reader.GetValue(0)
            End If

        End Using
        Return id
    End Function

    Public Function GetCodigoFromPLANCONTABLE(ByVal IdPlan As Integer) As BussinessEntities.PlanContable Implements IPlanContableRepository.GetCodigoFromPLANCONTABLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPLANCONTABLEByIdPlan")
        command.Parameters.AddWithValue("IdPlan", IdPlan)
        Return SelectObjectFactory1(command).SingleOrDefault
    End Function

    Public Function GetPLANCONTABLEByCodigo(ByVal Codigo As String) As BussinessEntities.PlanContable Implements IPlanContableRepository.GetPLANCONTABLEByCodigo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPLANCONTABLEByCodigo")
        command.Parameters.AddWithValue("Codigo", Codigo)
        Return SelectObjectFactory1(command).SingleOrDefault
    End Function
End Class
