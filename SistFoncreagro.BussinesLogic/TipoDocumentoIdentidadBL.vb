Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoDocumentoIdentidadBL : Implements ITipoDocumentoIdentidadBL
    Dim factoryrepository As ITipodocumentoIdentidad
    Public Sub New()
        factoryrepository = New TipoDocumentoIdentidadRepository
    End Sub
    Public Function GetAllFromTipoDocumentoIdentidad() As System.Collections.Generic.List(Of BussinessEntities.TipoDocumentoIdentidad) Implements ITipoDocumentoIdentidadBL.GetAllFromTipoDocumentoIdentidad
        Return Me.factoryrepository.GetAllFromTipoDocumentoIdentidad
    End Function
    Public Function GetTipoDocumentoIdentidadByIdNacionalidad(ByVal idNacionalidad As Integer) As System.Collections.Generic.List(Of BussinessEntities.TipoDocumentoIdentidad) Implements ITipoDocumentoIdentidadBL.GetTipoDocumentoIdentidadByIdNacionalidad
        Return Me.factoryrepository.GetTipoDocumentoIdentidadByIdNacionalidad(idNacionalidad)
    End Function
    Public Function GetTipoDocumentoIdentidadByTipoPersona(ByVal tipoPersona As String) As System.Collections.Generic.List(Of BussinessEntities.TipoDocumentoIdentidad) Implements ITipoDocumentoIdentidadBL.GetTipoDocumentoIdentidadByTipoPersona
        Return Me.factoryrepository.GetTipoDocumentoIdentidadByTipoPersona(tipoPersona)
    End Function
End Class
