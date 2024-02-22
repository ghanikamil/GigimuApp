Imports Gigimu.BO
Imports Gigimu.Interface
Imports System.Data.SqlClient


Public Class DokterDAL
    Implements IDokter

    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
        strConn = "Server=.\BSISqlExpress;Database=gigimu;Trusted_Connection=True;"
        conn = New SqlConnection(strConn)
    End Sub

    Public Function GetByName() As List(Of Dokter) Implements IDokter.GetByName
        Throw New NotImplementedException()
    End Function

    Public Function Create(obj As Dokter) As Integer Implements ICrud(Of Dokter).Create
        Throw New NotImplementedException()
    End Function

    Public Function GetAll() As List(Of Dokter) Implements ICrud(Of Dokter).GetAll
        Dim Dokters As New List(Of Dokter)
        Try
            Dim strSql = "dbo.getAllDokter"
            conn = New SqlConnection(strConn)
            cmd = New SqlCommand(strSql, conn)

            conn.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    Dim dkter As New Dokter
                    dkter.DokterID = CInt(dr("DokterID"))
                    dkter.Nama = dr("Nama").ToString()
                    dkter.Spesialis = dr("Spesialis").ToString()
                    dkter.Email = dr("Email").ToString()
                    dkter.Password = dr("Password").ToString()
                    dkter.isSpesialis = CInt(dr("isSpesialis"))
                    Dokters.Add(dkter)
                End While
            End If
            dr.Close()
            Return Dokters
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function GetById(id As Integer) As Dokter Implements ICrud(Of Dokter).GetById
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As Dokter) As Integer Implements ICrud(Of Dokter).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Dokter).Delete
        Throw New NotImplementedException()
    End Function
End Class
