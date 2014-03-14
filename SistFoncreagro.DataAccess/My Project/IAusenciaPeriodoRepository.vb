Imports SistFoncreagro.BussinessEntities
Public Interface IAusenciaPeriodoRepository
    Function SaveAUSENCIASPERIODO(ByVal IdPeriodoLaboral As Int32, ByVal IdJornadaLaboral As Int32, ByVal IdMotivoAusencia As Int32, ByVal Abreviatura As String, ByVal FI As Date, ByVal FF As Date) As Int32
    Function GetAusenciasPeriodoByIdJornadaLaboral(ByVal IdJornadaLaboral As Int32) As List(Of AusenciaPeriodo)
    Function GetAusenciasPeriodoByIdJornadaLaboralByAbreviatura(ByVal IdJornadaLaboral As Int32, ByVal abreviatura As String) As AusenciaPeriodo
    Function GetSumAusenciasPeriodoNoPagadas(ByVal IdJornadaLaboral As Int32) As Decimal
End Interface

