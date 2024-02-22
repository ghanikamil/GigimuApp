Imports Gigimu.BO

Public Interface IDokter
    Inherits ICrud(Of Dokter)

    Function GetByName() As List(Of Dokter)

End Interface