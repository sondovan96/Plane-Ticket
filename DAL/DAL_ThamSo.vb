Imports DTO
Public Class DAL_ThamSo
    Dim db As DBConnect
    Public Sub New()
        db = New DBConnect()
    End Sub
    Public Function selectAll() As DataTable
        Dim sql As String
        sql = "Select * from THAMSO"
        Return db.Execute(sql)
    End Function

    Public Function HienThi() As DataTable
        Dim sql As String
        sql = "SELECT THOIGIANBAYTOITHIEU[Thời gian bay tối thiểu], SOSANBAYTGTOIDA[Số sân bay TG tối đa],THOIGIANDUNGTOITHIEU[Thời gian dừng tối thiểu],THOIGIANDUNGTOIDA[Thời gian dừng tối đa],TGCHAMNHATDATVE[Thời gian chậm nhất đặt vé],TGCHAMNHATHUYDATVE[Thời gian chậm nhất đặt vé],SOSANBAYTOIDA FROM THAMSO"
        Return db.Execute(sql)
    End Function
    Public Function AddThamSo(ByVal ts As DTO_ThamSo) As Boolean
        Try
            Dim sql As String
            sql = String.Format("INSERT INTO THAMSO(THOIGIANBAYTOITHIEU, SOSANBAYTGTOIDA,THOIGIANDUNGTOITHIEU,THOIGIANDUNGTOIDA,TGCHAMNHATDATVE,TGCHAMNHATHUYDATVE,SOSANBAYTOIDA) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}',{6})", ts.TGBayToiThieu1, ts.SanBayTGToiDa1, ts.TGDungToiThieu1, ts.TGDungToiDa1, ts.TGChamNhatDatVe1, ts.TGChamNhatHuyVe1, ts.SanBayToiDa1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Update(ByVal ts As DTO_ThamSo) As Boolean
        Try
            Dim sql As String
            sql = String.Format("UPDATE THAMSO SET THOIGIANBAYTOITHIEU='{0}', SOSANBAYTGTOIDA='{1}', THOIGIANDUNGTOITHIEU='{2}', THOIGIANDUNGTOIDA='{3}', TGCHAMNHATDATVE='{4}', TGCHAMNHATHUYDATVE='{5}',SOSANBAYTOIDA ='{6}' ", ts.TGBayToiThieu1, ts.SanBayTGToiDa1, ts.TGDungToiThieu1, ts.TGDungToiDa1, ts.TGChamNhatDatVe1, ts.TGChamNhatHuyVe1, ts.SanBayToiDa1)
            db.ExecuteNonQuery(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
