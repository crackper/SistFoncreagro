Imports SistFoncreagro.BussinessEntities
Public Interface ITipoPlanillaTipoTrabajadorBL
    Sub DeleteTIPOPLANILLATIPOTRABAJADOR(ByVal IdTipoPlanilla As Int32, ByVal IdTipoTrabajador As Int32, ByVal IdCategoria As Int32)
    Sub SaveTIPOPLANILLATIPOTRABAJADOR(ByVal tipoPlanillaTipoTrabajador As TipoPlanillaTipoTrabajador)
    Function GetAllFromTIPOPLANILLATIPOTRABAJADOR() As List(Of TipoPlanillaTipoTrabajador)
    Function GetTIPOPLANILLATIPOTRABAJADORByIdTipoPlanilla(ByVal IdTipoPlanilla As Int32) As List(Of TipoPlanillaTipoTrabajador)

    Sub SaveAndDeleteListaTipoTrabajador(ByVal listaCrear As List(Of TipoPlanillaTipoTrabajador), ByVal listaEliminar As List(Of TipoPlanillaTipoTrabajador))

End Interface
