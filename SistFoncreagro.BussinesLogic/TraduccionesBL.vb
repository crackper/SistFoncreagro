Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TraduccionesBL : Implements ITraduccionesBL
    Dim factoryrepository As ITraduccionesRepository

    Public Sub New()
        factoryrepository = New TraduccionesRepository
    End Sub
    Public Function Traducir(ByVal IdTrad As String, Optional ByVal Idioma As String = "esp") As String Implements ITraduccionesBL.Traducir
        Return factoryrepository.Traducir(IdTrad)
    End Function

    Public Sub TraducirGrilla(ByVal sender As Object) Implements ITraduccionesBL.TraducirGrilla
        factoryrepository.TraducirGrilla(sender)
    End Sub
End Class
