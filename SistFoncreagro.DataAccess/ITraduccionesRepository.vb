Imports SistFoncreagro.BussinessEntities
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Common

Public Interface ITraduccionesRepository
    Function Traducir(ByVal IdTrad As String, Optional ByVal Idioma As String = "esp") As String
    Sub TraducirGrilla(ByVal sender As Object)
End Interface
