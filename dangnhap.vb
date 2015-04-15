Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class dangnhap

    Private Sub dangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim chuoiketnoi As String = "workstation id=PS02309.mssql.somee.com;packet size=4096;user id=PS02309_SQLLogin_2;pwd=Cmnd251033077;data source=PS02309.mssql.somee.com;persist security info=False;initial catalog=PS02309"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhanvien where MaNV='" & TextBox1.Text & "' and TenNV='" & TextBox2.Text & "' ", ketnoi)
        Dim tb As New DataTable

        Try
            ketnoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết Nối Thành Công")
                giaodien.Show()
                Me.Hide()
            Else
                MessageBox.Show("Đăng Nhập Thất Bại")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub GiaoDiênToolStripMenuItem_Click(sender As Object, e As EventArgs)
        giaodien.Show()
    End Sub

    Private Sub HoaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs)
        hoadon.Show()
    End Sub

    Private Sub ChiTiêtHoaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs)
        chitiethoadon.Show()
    End Sub

    Private Sub KhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs)
        khachhang.Show()
    End Sub

    Private Sub SanPhâmToolStripMenuItem_Click(sender As Object, e As EventArgs)
        sanpham.Show()
    End Sub

    Private Sub LoaiSanPhâmToolStripMenuItem_Click(sender As Object, e As EventArgs)
        loaisanpham.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
