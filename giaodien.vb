Public Class giaodien

   
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        khachhang.Show()
    End Sub

    Private Sub giaodien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sanpham.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        loaisanpham.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        hoadon.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        chitiethoadon.Show()
    End Sub
End Class