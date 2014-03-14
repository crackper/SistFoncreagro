Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class RendicionBL : Implements IRendicionBL
    Dim factoryrepository As IRendicionRepository

    Public Sub New()
        factoryrepository = New RendicionRepository
    End Sub
    Public Sub DeleteRENDICION(ByVal IdRendicion As Integer) Implements IRendicionBL.DeleteRENDICION
        factoryrepository.DeleteRENDICION(IdRendicion)
    End Sub

    Public Function GetAllFromRENDICION() As System.Collections.Generic.List(Of BussinessEntities.Rendicion) Implements IRendicionBL.GetAllFromRENDICION
        Return factoryrepository.GetAllFromRENDICION
    End Function

    Public Function GetRENDICIONByIdRendicion(ByVal IdRendicion As Integer) As BussinessEntities.Rendicion Implements IRendicionBL.GetRENDICIONByIdRendicion
        Return factoryrepository.GetRENDICIONByIdRendicion(IdRendicion)
    End Function

    Public Function SaveRENDICION(ByVal _Rendicion As BussinessEntities.Rendicion) As Integer Implements IRendicionBL.SaveRENDICION
        Return factoryrepository.SaveRENDICION(_Rendicion)
    End Function

    Public Sub UpdateEstadoRENDICION(ByVal IdRendicion As Integer, ByVal Estado As String) Implements IRendicionBL.UpdateEstadoRENDICION
        factoryrepository.UpdateEstadoRENDICION(IdRendicion, Estado)
    End Sub

    Public Function GetRENDICIONByEstado(ByVal Estado As String, ByVal mes As Int32) As System.Collections.Generic.List(Of BussinessEntities.Rendicion) Implements IRendicionBL.GetRENDICIONByEstado
        Return factoryrepository.GetRENDICIONByEstado(Estado, mes)
    End Function

    Public Sub UpdateObservacionRENDICION(ByVal IdRendicion As Integer, ByVal Observacion As String) Implements IRendicionBL.UpdateObservacionRENDICION
        factoryrepository.UpdateObservacionRENDICION(IdRendicion, Observacion)
    End Sub
    Public Function GetTotalRendicion(ByVal IdRendicion As Integer) As Decimal Implements IRendicionBL.GetTotalRendicion
        Return factoryrepository.GetTotalRendicion(IdRendicion)
    End Function

    Public Function GetRENDICIONPendientes(ByVal mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.Rendicion) Implements IRendicionBL.GetRENDICIONPendientes
        Return factoryrepository.GetRENDICIONPendientes(mes)
    End Function
End Class
