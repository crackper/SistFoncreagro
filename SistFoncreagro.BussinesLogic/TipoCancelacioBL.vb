Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoCancelacioBL : Implements ITipoCancelacionBL
    Dim factoryrepository As ITipoCancelacionRepository

    Public Sub New()
        factoryrepository = New TipoCancelacionRepository
    End Sub
    Public Function GetAllFromTIPOCANCELACION() As System.Collections.Generic.List(Of BussinessEntities.TipoCancelacion) Implements ITipoCancelacionBL.GetAllFromTIPOCANCELACION
        Return factoryrepository.GetAllFromTIPOCANCELACION
    End Function
End Class
