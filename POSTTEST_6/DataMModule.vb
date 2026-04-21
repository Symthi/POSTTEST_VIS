Imports MySqlConnector

Module DataModule
    Public Function GetAllKlub() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeKlub, namaKlub, kota, tahunBerdiri FROM tbklub ORDER BY kodeKlub ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data klub: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchKlub(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeKlub, namaKlub, kota, tahunBerdiri FROM tbklub WHERE kodeKlub LIKE @kw OR namaKlub LIKE @kw OR kota LIKE @kw ORDER BY kodeKlub ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data klub: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeKlubSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbklub WHERE kodeKlub = @kode"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa kode klub: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanKlub(kode As String, nama As String, kota As String, tahun As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO tbklub (kodeKlub, namaKlub, kota, tahunBerdiri) VALUES (@kode, @nama, @kota, @tahun)"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kota", kota)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan klub: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahKlub(kode As String, nama As String, kota As String, tahun As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tbklub SET namaKlub=@nama, kota=@kota, tahunBerdiri=@tahun WHERE kodeKlub=@kode"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kota", kota)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah klub: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusKlub(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbklub WHERE kodeKlub=@kode"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus klub: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllPemain() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT p.kodePemain, p.namaPemain, p.posisi, p.tinggi, p.berat, k.namaKlub, p.kodeKlub FROM tbpemain p JOIN tbklub k ON p.kodeKlub = k.kodeKlub ORDER BY p.kodePemain ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data pemain: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPemain(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT p.kodePemain, p.namaPemain, p.posisi, p.tinggi, p.berat, k.namaKlub, p.kodeKlub FROM tbpemain p JOIN tbklub k ON p.kodeKlub = k.kodeKlub WHERE p.kodePemain LIKE @kw OR p.namaPemain LIKE @kw OR p.posisi LIKE @kw OR k.namaKlub LIKE @kw ORDER BY p.kodePemain ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data pemain: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodePemainSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbpemain WHERE kodePemain = @kode"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa kode pemain: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanPemain(kode As String, nama As String, posisi As String, tinggi As Integer, berat As Integer, kodeKlub As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbpemain (kodePemain, namaPemain, posisi, tinggi, berat, kodeKlub) VALUES (@kode, @nama, @posisi, @tinggi, @berat, @kodeKlub)"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@posisi", posisi)
                    cmd.Parameters.AddWithValue("@tinggi", tinggi)
                    cmd.Parameters.AddWithValue("@berat", berat)
                    cmd.Parameters.AddWithValue("@kodeKlub", kodeKlub)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan pemain: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPemain(kode As String, nama As String, posisi As String, tinggi As Integer, berat As Integer, kodeKlub As String) As Boolean
        Try
            Dim query As String = "UPDATE tbpemain SET namaPemain=@nama, posisi=@posisi, tinggi=@tinggi, berat=@berat, kodeKlub=@kodeKlub WHERE kodePemain=@kode"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@posisi", posisi)
                    cmd.Parameters.AddWithValue("@tinggi", tinggi)
                    cmd.Parameters.AddWithValue("@berat", berat)
                    cmd.Parameters.AddWithValue("@kodeKlub", kodeKlub)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah pemain: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPemain(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpemain WHERE kodePemain=@kode"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus pemain: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function GetAllPelatih() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT p.kodePelatih, p.namaPelatih, p.posisi, p.pengalaman, k.namaKlub, p.kodeKlub " &
                                  "FROM tbpelatih p JOIN tbklub k ON p.kodeKlub = k.kodeKlub ORDER BY p.kodePelatih ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data pelatih: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPelatih(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT p.kodePelatih, p.namaPelatih, p.posisi, p.pengalaman, k.namaKlub, p.kodeKlub " &
                                  "FROM tbpelatih p JOIN tbklub k ON p.kodeKlub = k.kodeKlub " &
                                  "WHERE p.kodePelatih LIKE @kw OR p.namaPelatih LIKE @kw OR p.posisi LIKE @kw OR k.namaKlub LIKE @kw " &
                                  "ORDER BY p.kodePelatih ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data pelatih: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodePelatihSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbpelatih WHERE kodePelatih = @kode"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa kode pelatih: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanPelatih(kode As String, nama As String, posisi As String, pengalaman As Integer, kodeKlub As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbpelatih (kodePelatih, namaPelatih, posisi, pengalaman, kodeKlub) VALUES (@kode, @nama, @posisi, @pengalaman, @kodeKlub)"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@posisi", posisi)
                    cmd.Parameters.AddWithValue("@pengalaman", pengalaman)
                    cmd.Parameters.AddWithValue("@kodeKlub", kodeKlub)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan pelatih: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPelatih(kode As String, nama As String, posisi As String, pengalaman As Integer, kodeKlub As String) As Boolean
        Try
            Dim query As String = "UPDATE tbpelatih SET namaPelatih=@nama, posisi=@posisi, pengalaman=@pengalaman, kodeKlub=@kodeKlub WHERE kodePelatih=@kode"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@posisi", posisi)
                    cmd.Parameters.AddWithValue("@pengalaman", pengalaman)
                    cmd.Parameters.AddWithValue("@kodeKlub", kodeKlub)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah pelatih: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPelatih(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpelatih WHERE kodePelatih=@kode"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus pelatih: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module