Imports SistFoncreagro.DataAccess
Imports SistFoncreagro.BussinessEntities
Public Class AprobarRequerimientoBL : Implements IAprobarRequerimientoBL

    Dim aprobarReqRepository As IAprobarRequerimientoRepository
    Sub New()
        aprobarReqRepository = New AprobarRequerimientoRepository
    End Sub
    Public Function GetAllFromNivelesAprobarRequerimiento() As System.Collections.Generic.List(Of BussinessEntities.AprobarRequerimiento) Implements IAprobarRequerimientoBL.GetAllFromNivelesAprobarRequerimiento
        Return aprobarReqRepository.GetAllFromNivelesAprobarRequerimiento
    End Function

    Public Function DeleteNivelAprobarRequerimiento(ByVal IdAprobarRequerimiento As Integer) As Boolean Implements IAprobarRequerimientoBL.DeleteNivelAprobarRequerimiento
        Return aprobarReqRepository.DeleteNivelAprobarRequerimiento(IdAprobarRequerimiento)
    End Function

    Public Function SaveNivelAprobarRequerimiento(ByVal aprobarReq As BussinessEntities.AprobarRequerimiento) As Integer Implements IAprobarRequerimientoBL.SaveNivelAprobarRequerimiento
        Return aprobarReqRepository.SaveNivelAprobarRequerimiento(aprobarReq)
    End Function

    Public Function UpdateNivelAprobarRequerimiento(ByVal aprobarReq As BussinessEntities.AprobarRequerimiento) As Integer Implements IAprobarRequerimientoBL.UpdateNivelAprobarRequerimiento
        Return aprobarReqRepository.UpdateNivelAprobarRequerimiento(aprobarReq)
    End Function
End Class
