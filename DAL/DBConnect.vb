Imports System.Data.SqlClient

Public Class DBConnect
    Dim sqlcnn As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Public Sub New()
        Dim cnnStr As String
        cnnStr = "server=.;database=QLCHUYENBAY;Integrated security = true"
        sqlcnn = New SqlConnection(cnnStr)
    End Sub

    Public Function Execute(ByVal sqlquery As String) As DataTable
        Using da = New SqlDataAdapter(sqlquery, sqlcnn)
            ds = New DataSet()

            da.Fill(ds)
            sqlcnn.Close()
        End Using
        Return ds.Tables(0)
    End Function
    Public Sub ExecuteNonQuery(ByVal sqlquery As String)
        Try
            Dim sqlCM As SqlCommand
            sqlCM = New SqlCommand(sqlquery, sqlcnn)
            sqlcnn.Open()
            sqlCM.ExecuteNonQuery()
            sqlcnn.Close()
        Catch ex As Exception
            Throw ex
        Finally
            sqlcnn.Close()
        End Try

    End Sub
End Class
