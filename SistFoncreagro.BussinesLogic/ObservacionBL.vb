Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class ObservacionBL : Implements IObservacionBL

    Dim factoryrepository As IObservacionRepository

    Public Sub New()
        factoryrepository = New ObservacionRepository
    End Sub

    Public Sub DeleteObservacion(ByVal _id As Integer) Implements IObservacionBL.DeleteObservacion
        factoryrepository.DeleteObservacion(_id)
    End Sub

    Public Function GetObservacionById(ByVal _id As Integer) As BussinessEntities.Observacion Implements IObservacionBL.GetObservacionById
        Return GetObservacionById(_id)
    End Function

    Public Sub InsertObservacion(ByVal _Observacion As BussinessEntities.Observacion) Implements IObservacionBL.InsertObservacion
        factoryrepository.InsertObservacion(_Observacion)
    End Sub

    Public Sub UpdateObservacion(ByVal _IdObservacion As Integer, ByVal _Obser As String) Implements IObservacionBL.UpdateObservacion
        factoryrepository.UpdateObservacion(_IdObservacion, _Obser)
    End Sub

    Public Function GetObservacionByIdAndTabla(ByVal _id As Integer, ByVal _Tabla As String) As System.Collections.Generic.List(Of BussinessEntities.Observacion) Implements IObservacionBL.GetObservacionByIdAndTabla
        Return factoryrepository.GetObservacionByIdAndTabla(_id, _Tabla)
    End Function
End Class
