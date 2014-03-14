Imports SistFoncreagro.DataAccess
Public Class CuentaEnlaceBL : Implements ICuentaEnlaceBL
    Dim factoryrepository As ICuentaEnlaceRepository

    Public Sub New()
        factoryrepository = New CuentaEnlaceRepository
    End Sub
    Public Function GetAllFromCUENTAENLACE() As System.Collections.Generic.List(Of BussinessEntities.CuentaEnlace) Implements ICuentaEnlaceBL.GetAllFromCUENTAENLACE
        Return factoryrepository.GetAllFromCUENTAENLACE
    End Function
    Public Function GetCUENTAENLACEByParameter(ByVal Texto As String, ByVal Tipo As String) As System.Collections.Generic.List(Of BussinessEntities.CuentaEnlace) Implements ICuentaEnlaceBL.GetCUENTAENLACEByParameter
        Return factoryrepository.GetCUENTAENLACEByParameter(Texto, Tipo)
    End Function
    Public Function GetCUENTAENLACEByIdCtaEnlace(ByVal IdCtaEnlace As Integer) As BussinessEntities.CuentaEnlace Implements ICuentaEnlaceBL.GetCUENTAENLACEByIdCtaEnlace
        Return factoryrepository.GetCUENTAENLACEByIdCtaEnlace(IdCtaEnlace)
    End Function

    Public Function SaveCUENTAENLACE(ByVal _CuentaEnlace As BussinessEntities.CuentaEnlace) As Integer Implements ICuentaEnlaceBL.SaveCUENTAENLACE
        Return factoryrepository.SaveCUENTAENLACE(_CuentaEnlace)
    End Function

    Public Sub UpdateEstadoCUENTAENLACE(ByVal IdCtaEnlace As Integer) Implements ICuentaEnlaceBL.UpdateEstadoCUENTAENLACE
        factoryrepository.UpdateEstadoCUENTAENLACE(IdCtaEnlace)
    End Sub

    Public Function GetCtaCobrarByCtaPagarAndDestino(ByVal CtaPagar As Integer, ByVal Destino As String, ByVal Tipo As String) As Integer Implements ICuentaEnlaceBL.GetCtaCobrarByCtaPagarAndDestino
        Return factoryrepository.GetCtaCobrarByCtaPagarAndDestino(CtaPagar, Destino, Tipo)
    End Function

    Public Function GetCUENTAENLACEByCtaOperacion(ByVal CtaOperacion As Integer, ByVal Destino As String, ByVal Tipo As String) As System.Collections.Generic.IList(Of BussinessEntities.CuentaEnlace) Implements ICuentaEnlaceBL.GetCUENTAENLACEByCtaOperacion
        Return factoryrepository.GetCUENTAENLACEByCtaOperacion(CtaOperacion, Destino, Tipo)
    End Function

    Public Function GetCUENTAENLACEByCtaOperacionAndCtaPagar(ByVal CtaOperacion As Integer, ByVal Destino As String, ByVal CtaPagar As Integer, ByVal Tipo As String) As BussinessEntities.CuentaEnlace Implements ICuentaEnlaceBL.GetCUENTAENLACEByCtaOperacionAndCtaPagar
        Return factoryrepository.GetCUENTAENLACEByCtaOperacionAndCtaPagar(CtaOperacion, Destino, CtaPagar, Tipo)
    End Function

    Public Function GetCUENTAENLACEByCtaPagar(ByVal CtaPagar As Integer, ByVal Tipo As String) As BussinessEntities.CuentaEnlace Implements ICuentaEnlaceBL.GetCUENTAENLACEByCtaPagar
        Return factoryrepository.GetCUENTAENLACEByCtaPagar(CtaPagar, Tipo)
    End Function

    Public Function GetCtaPagarByCtaCobrarAndDestino(ByVal CtaCobrar As Integer, ByVal Destino As String, ByVal Tipo As String) As Integer Implements ICuentaEnlaceBL.GetCtaPagarByCtaCobrarAndDestino
        Return factoryrepository.GetCtaPagarByCtaCobrarAndDestino(CtaCobrar, Destino, Tipo)
    End Function

    Public Function GetCUENTAENLACEByCtaOperacionAndCtaCobrar(ByVal CtaOperacion As Integer, ByVal Destino As String, ByVal CtaCobrar As Integer, ByVal Tipo As String) As BussinessEntities.CuentaEnlace Implements ICuentaEnlaceBL.GetCUENTAENLACEByCtaOperacionAndCtaCobrar
        Return factoryrepository.GetCUENTAENLACEByCtaOperacionAndCtaCobrar(CtaOperacion, Destino, CtaCobrar, Tipo)
    End Function

    Public Function GetOrigenCtaEnlace(ByVal CtaPagar As Integer, ByVal Destino As String) As String Implements ICuentaEnlaceBL.GetOrigenCtaEnlace
        Return factoryrepository.GetOrigenCtaEnlace(CtaPagar, Destino)
    End Function

    Public Function GetOrigenCtaEnlace1(ByVal CtaCobrar As Integer, ByVal Destino As String) As String Implements ICuentaEnlaceBL.GetOrigenCtaEnlace1
        Return factoryrepository.GetOrigenCtaEnlace1(CtaCobrar, Destino)
    End Function

    Public Function GetCtaOperacionByCtaCobrarAndDestino(ByVal CtaCobrar As Integer, ByVal Destino As String, ByVal Tipo As String) As String Implements ICuentaEnlaceBL.GetCtaOperacionByCtaCobrarAndDestino
        Return factoryrepository.GetCtaOperacionByCtaCobrarAndDestino(CtaCobrar, Destino, Tipo)
    End Function

    Public Function GetCtaOperacionByCtaPagarAndDestino(ByVal CtaPagar As Integer, ByVal Destino As String, ByVal Tipo As String) As String Implements ICuentaEnlaceBL.GetCtaOperacionByCtaPagarAndDestino
        Return factoryrepository.GetCtaOperacionByCtaPagarAndDestino(CtaPagar, Destino, Tipo)
    End Function

    Public Function VerifyExisteCUENTAENLACE(ByVal Origen As String, ByVal Destino As String, ByVal CtaOperacion As Integer, ByVal CtaPagar As Integer, ByVal CtaCobrar As Integer, ByVal Tipo As String) As Integer Implements ICuentaEnlaceBL.VerifyExisteCUENTAENLACE
        Return factoryrepository.VerifyExisteCUENTAENLACE(Origen, Destino, CtaOperacion, CtaPagar, CtaCobrar, Tipo)
    End Function
End Class
