﻿Imports SistFoncreagro.BussinessEntities
Public Interface IHistoricoRequerimientoBL
    Sub RechazarRequerimiento(ByVal historicoReq As HistoricoRequerimiento)
    Function GetAllFromHistoricoByIdRequerimiento(ByVal idRequerimiento As Int32) As List(Of HistoricoRequerimiento)
End Interface