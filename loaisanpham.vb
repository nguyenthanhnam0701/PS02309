Imports System.Data.SqlClient
Public Class loaisanpham
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=PS02309.mssql.somee.com;packet size=4096;user id=PS02309_SQLLogin_2;pwd=Cmnd251033077;data source=PS02309.mssql.somee.com;persist security info=False;initial catalog=PS02309"
    Public Sub LoadData()
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from LoaiSanPham", ketnoi)

        Try
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub
    Private Sub khachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from LoaiSanPham", ketnoi)

        Try
            ketnoi.Open()
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dr As DataRow = tb.NewRow
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        TextBox1.Text = DataGridView1.Item(0, index).Value
        TextBox2.Text = DataGridView1.Item(1, index).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "update LoaiSanPham SET TenLoai = @TenLoai WHERE MaLoai = @MaLoai"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaLoai", TextBox1.Text)
            com.Parameters.AddWithValue("@TenLoai", TextBox2.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Sửa Thành Công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ketnoi As New SqlConnection(connectstr)
        Dim add As New SqlDataAdapter("insert into LoaiSanPham values ('" & TextBox1.Text & "','" & TextBox2.Text & "')", ketnoi)
        Try
            ketnoi.Open()
            add.Fill(tb)

        Catch ex As Exception
            MessageBox.Show("Đã Thêm")

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = " Delete from LoaiSanPham WHERE MaLoai = @MaLoai"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaLoai", TextBox1.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Đã Xóa")

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

End Class