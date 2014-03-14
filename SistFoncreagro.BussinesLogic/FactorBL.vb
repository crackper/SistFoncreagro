Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class FactorBL : Implements IFactorBL

    Dim factoryrepository As IFactorRepository

    Public Sub New()
        factoryrepository = New FactorRepository
    End Sub
    Public Sub DeleteFactor(ByVal IdFactor As Integer) Implements IFactorBL.DeleteFactor
        factoryrepository.DeleteFactor(IdFactor)
    End Sub

    Public Function GetFactorByIdDetalleConcepto(ByVal IdDetalleConcepto As Integer) As System.Collections.Generic.List(Of BussinessEntities.Factor) Implements IFactorBL.GetFactorByIdDetalleConcepto
        Return factoryrepository.GetFactorByIdDetalleConcepto(IdDetalleConcepto)
    End Function

    Public Function GetFactorVigente(ByVal IdDetalleConcepto As Integer) As BussinessEntities.Factor Implements IFactorBL.GetFactorVigente
        Return factoryrepository.GetFactorVigente(IdDetalleConcepto)
    End Function

    Public Function GetFactorByMaxFecha(ByVal IdDetalleConcepto As Integer) As BussinessEntities.Factor Implements IFactorBL.GetFactorByMaxFecha
        Return factoryrepository.GetFactorByMaxFecha(IdDetalleConcepto)
    End Function

    Public Function SaveFACTOR(ByVal factor As BussinessEntities.Factor) As Integer Implements IFactorBL.SaveFACTOR
        Return factoryrepository.SaveFACTOR(factor)
    End Function

    Public Function SaveFactorUpdateVigente(ByVal factor As BussinessEntities.Factor) As Integer Implements IFactorBL.SaveFactorUpdateVigente
        Dim factorVigente As New Factor
        Dim idFactor As Int32
        factorVigente = GetFactorVigente(factor.IdDetalleConcepto)

        If Not factorVigente Is Nothing Then
            If factorVigente.InicioVigencia < factor.InicioVigencia Then
                factorVigente.vigente = False
                factor.vigente = True
                SaveFACTOR(factorVigente)
            Else
                factor.vigente = False
            End If
            SaveFACTOR(factor)

            If factor.IdFactor = factorVigente.IdFactor Then
                factorVigente = Nothing
                factorVigente = GetFactorByMaxFecha(factor.IdDetalleConcepto)
                If Not factorVigente Is Nothing Then
                    factorVigente.vigente = True
                    idFactor = SaveFACTOR(factorVigente)
                End If
            End If
        Else
            factor.vigente = False
            SaveFACTOR(factor)
            'Seleccionamos al factor con la maxima fecha
            factorVigente = GetFactorByMaxFecha(factor.IdDetalleConcepto)
            If Not factorVigente Is Nothing Then
                factorVigente.vigente = True
                idFactor = SaveFACTOR(factorVigente)
            End If
        End If
        Return idFactor
    End Function
End Class
