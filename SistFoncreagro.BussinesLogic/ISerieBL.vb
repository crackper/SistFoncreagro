﻿Imports SistFoncreagro.BussinessEntities
Public Interface ISerieBL
    Sub UpdateEstadoSERIE(ByVal IdSerie As Int32)
    Sub SaveSERIE(ByVal _Serie As Serie)
    Function GetAllFromSERIE() As List(Of Serie)
End Interface