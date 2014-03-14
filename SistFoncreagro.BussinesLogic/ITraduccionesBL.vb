Public Interface ITraduccionesBL
    Function Traducir(ByVal IdTrad As String, Optional ByVal Idioma As String = "esp") As String
    Sub TraducirGrilla(ByVal sender As Object)
End Interface
