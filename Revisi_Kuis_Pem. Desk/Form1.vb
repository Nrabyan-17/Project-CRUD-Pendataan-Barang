
Imports MySql.Data.MySqlClient
Public Class Form1

    'Mendeklarasikan variabel connection, command, dan reader untuk mengoperasikan Database'
    Public conn As New MySqlConnection("server=127.0.0.1; userid=root; password=''; database=data_produk")

    'Function untuk membuka koneksi ke Database'
    Private Sub openConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    'Function untuk menutup koneksi Database'
    Private Sub closeConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    'Function untuk membersihkan data-data yang ada di field Text Box'
    Private Sub resetFrom()
        nmProduk.Clear()
        ktProduk.Clear()
        hrgProduk.Clear()
        jmlStok.Clear()
    End Sub

    'Function untuk menampilkan data-data barang pada Grid View'
    Sub tampilData()
        Try
            Call openConnection()

            ''
            Dim query As String = "SELECT * FROM barang"
            Dim cmd As New MySqlCommand(query, conn)

            ''
            Dim rdr As MySqlDataReader = cmd.ExecuteReader()

            ''
            DataGridView1.Rows.Clear()

            ''
            While rdr.Read()
                DataGridView1.Rows.Add(rdr("id"), rdr("nama_barang"), rdr("harga_barang"), rdr("kategori_barang"), rdr("stok"), rdr("nilai_total_stok"), rdr("status"))
            End While

            rdr.Close()

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        Finally
            closeConnection()
        End Try

    End Sub

    'Function untuk menambahkan data'
    Sub tambahData(nama As String, harga As Decimal, kategori As String, stok As Integer, nilai_total_stok As Decimal, statusStok As String)

        'Validasi Input'
        If nama = "" Or kategori = "" Or harga <= 0 Or stok <= 0 Then
            MsgBox("Semua Field Input wajib diisi!")
            Exit Sub
        End If

        Try
            Call openConnection()

            Dim query As String = "INSERT INTO barang (nama_barang, harga_barang, kategori_barang, stok, nilai_total_stok, status) VALUES (@nama_barang, @harga_barang, @kategori_barang, @stok, @nilai_total_stok, @status)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@nama_barang", nama)
            cmd.Parameters.AddWithValue("@kategori_barang", kategori)
            cmd.Parameters.AddWithValue("@harga_barang", harga)
            cmd.Parameters.AddWithValue("@nilai_total_stok", nilai_total_stok)
            cmd.Parameters.AddWithValue("@stok", stok)
            cmd.Parameters.AddWithValue("@status", statusStok)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Barang berhasil ditambahkan")
            Call resetFrom()

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        Finally
            closeConnection()
        End Try
    End Sub

    'Function untuk menghapus Data'
    Sub hapusData(id As Integer)
        Try
            Call openConnection()

            Dim query As String = "DELETE FROM barang WHERE id = @id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data barang berhasil dihapus!")
            Call resetFrom()

        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        Finally
            closeConnection()
        End Try
    End Sub

    'Function dari tombol DELETE'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        Call hapusData(id)
        Call tampilData()
    End Sub

    'Function untuk mengedit Data'
    Sub editData(id As Integer, namaBarang As String, kategoriBarang As String, hargaBarang As Decimal, stok As Integer, nilaiTotalStok As Decimal, status As String)
        Try
            Call openConnection()

            Dim query As String = "UPDATE barang SET nama_barang = @nama_barang, harga_barang = @harga_barang, kategori_barang = @kategori_barang, stok = @stok, nilai_total_stok = @nilai_total_stok, Status = @Status WHERE id = @id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nama_barang", namaBarang)
            cmd.Parameters.AddWithValue("@harga_barang", hargaBarang)
            cmd.Parameters.AddWithValue("@kategori_barang", kategoriBarang)
            cmd.Parameters.AddWithValue("@nilai_total_stok", nilaiTotalStok)
            cmd.Parameters.AddWithValue("@stok", stok)
            cmd.Parameters.AddWithValue("@Status", status)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil di update!")
            Call resetFrom()

        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        Finally
            Call closeConnection()
        End Try
    End Sub

    'Function dari tombol UPDATE'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim id As Integer = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            Dim namabarang As String = nmProduk.Text
            Dim kategoriBarang As String = ktProduk.Text
            Dim hargaBarang As Decimal = Decimal.Parse(hrgProduk.Text)
            Dim stok As Integer = Integer.Parse(jmlStok.Text)
            Dim nilaiTotalStok As Decimal = hargaBarang * stok

            Dim status As String = If(stok >= 5, "Barang tersedia!", "Barang hampir habis!")

            Call editData(id, namabarang, kategoriBarang, hargaBarang, stok, nilaiTotalStok, status)

            Call tampilData()
        Else
            MessageBox.Show("Wajib pilih baris yang ingin anda edit!")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Function dari tombol INSERT'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        'Validasi Input'
        If nmProduk.Text = "" Or ktProduk.Text = "" Or hrgProduk.Text = "" Or jmlStok.Text = "" Then
            MessageBox.Show("Semua Field Input wajib diisi!")
            Exit Sub
        End If

        'Ambil data dari text box'
        Dim namaBarang As String = nmProduk.Text
        Dim kategoriProduk As String = ktProduk.Text
        Dim hargaBarang As Decimal = Decimal.Parse(hrgProduk.Text)
        Dim stokBarang As Integer = Integer.Parse(jmlStok.Text)

        'Perhitungan Total harga'
        Dim totalNilaiStok As Decimal = hargaBarang * stokBarang

        'Membuat variabel statusStok untuk mengetahui apakah barangnya masih tersedia atau hampir habis'
        Dim statusStok As String
        If stokBarang >= 5 Then
            statusStok = "barang tersedia!"
        Else
            statusStok = "barang hampir habis!"
        End If

        'Insert data ke dalam Database'
        tambahData(namaBarang, hargaBarang, kategoriProduk, stokBarang, totalNilaiStok, statusStok)

        'Menampilkan data ke tabel grid'
        tampilData()

    End Sub

End Class