Imports Gigimu.BO

Module Module1

    Sub Main()
        Dim dokterDAL As New Gigimu.DAL.DokterDAL
        Dim dokters = dokterDAL.GetAll()
        For Each i As Dokter In dokters
            Console.WriteLine("{0}-{1}-{2}", i.Nama, i.Spesialis, i.Email)
        Next
    End Sub

End Module
