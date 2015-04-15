Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class chitiethoadon
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=PS02309.mssql.somee.com;packet size=4096;user id=PS02309_SQLLogin_2;pwd=Cmnd251033077;data source=PS02309.mssql.somee.com;persist security info=False;initial catalog=PS02309"

    Public Sub LoadData()
        Dim ketnoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from ChiTietHoaDon", ketnoi)

        Try
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label5.Click, Label4.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub QuanTriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanTriToolStripMenuItem.Click

    End Sub

    Private Sub GiaoDiênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiaoDiênToolStripMenuItem.Click

    End Sub

    Private Sub HoaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoaĐơnToolStripMenuItem.Click

    End Sub

    Private Sub ChiTiêtHoaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiêtHoaĐơnToolStripMenuItem.Click

    End Sub

    Private Sub KhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhachHangToolStripMenuItem.Click

    End Sub

    Private Sub SanPhâmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanPhâmToolStripMenuItem.Click

    End Sub

    Private Sub LoaiSanPhâmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoaiSanPhâmToolStripMenuItem.Click

    End Sub

    Private Sub chitiethoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        TextBox1.Text = DataGridView1.Item(0, index).Value
        TextBox2.Text = DataGridView1.Item(1, index).Value
        TextBox4.Text = DataGridView1.Item(2, index).Value
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class