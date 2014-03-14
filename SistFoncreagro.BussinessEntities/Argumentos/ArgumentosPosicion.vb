Public Class ArgumentosPosicion
    Public Property DevolverArea As ArgumentosArea
    Public Property DevolverJefatura As Boolean
    Public Property DevolverGradoSalarial As Boolean
    Public Property DevolverListaFunciones As Boolean
    Public Property DevolverListaFormacionReq As Boolean
    Public Property DevolverListaHabilidades As Boolean
    Public Property DevolverListaRequesitosAdic As Boolean
    Sub New(ByVal _devolverArea As ArgumentosArea, ByVal _devolverJefatura As Boolean, ByVal _devolverGradoSalarial As Boolean, ByVal _devolverListaFunciones As Boolean, ByVal _devolverListaFormacionReq As Boolean, ByVal _devolverListaHabilidades As Boolean, ByVal _devolverListaRequesitosAdic As Boolean)
        DevolverArea = _devolverArea
        DevolverJefatura = _devolverJefatura
        DevolverGradoSalarial = _devolverGradoSalarial
        DevolverListaFunciones = _devolverListaFunciones
        DevolverListaFormacionReq = _devolverListaFormacionReq
        DevolverListaHabilidades = _devolverListaHabilidades
        DevolverListaRequesitosAdic = _devolverListaRequesitosAdic
    End Sub
End Class
