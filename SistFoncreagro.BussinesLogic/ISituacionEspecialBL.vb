﻿Imports SistFoncreagro.BussinessEntities
Public Interface ISituacionEspecialBL
    Function GetAllSituacionEspecial() As List(Of SituacionEspecial)
    Function GetSituacionEspecialByIdSituacionespecial(ByVal idSituacionEspecial As Int32) As SituacionEspecial

End Interface
