Imports System.Data.OleDb
Public Class Diagnosa
    Sub tampilDiagnosa()
        da = New OleDbDataAdapter("Select * from diagnosa", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "diagnosa")
        dgvdiagnosa.DataSource = (ds.Tables("diagnosa"))
        dgvdiagnosa.ReadOnly = True
    End Sub
    Sub kosongkan()
        txtkode.Text = ""
        txtpenyakit.Text = ""
        txtkode.Focus()
    End Sub

    Private Sub Diagnosa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        tampilDiagnosa()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkode.Text = "" Or txtpenyakit.Text = "" Then
            MsgBox("Data Belum Lengkap, Silahkan Lengkapi")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from diagnosa where kode_ICD='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqlTambah As String = "insert into diagnosa (kode_ICD,nama_penyakit) values ('" & txtkode.Text & "','" & txtpenyakit.Text & "')"
                cmd = New OleDbCommand(sqlTambah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Tersimpan")
                kosongkan()
                tampilDiagnosa()
            Else
                MsgBox("Data Sudah Ada")
            End If
        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        If txtkode.Text = "" Then
            MsgBox("Isi Kode Diagnosa Terlebih Dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from diagnosa where kode_ICD='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtkode.Text = rd.Item("kode_ICD")
                txtpenyakit.Text = rd.Item("nama_penyakit")
            Else
                MsgBox("Data Tidak Ditemukan")
                kosongkan()
                tampilDiagnosa()
            End If
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtkode.Text = "" Or txtpenyakit.Text = "" Then
            MsgBox("Data Belum Lengkap, Silahkan Lengkapi")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from diagnosa where kode_ICD='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim sqlEdit As String = "Update diagnosa set kode_ICD='" & txtkode.Text & "',nama_penyakit='" & txtpenyakit.Text & "' where kode_ICD= '" & txtkode.Text & "'"
                cmd = New OleDbCommand(sqlEdit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Telah Diubah")
                kosongkan()
                tampilDiagnosa()
            Else
                MsgBox("Data Tidak ada, pastikan kembali data yang akan diubah")
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtkode.Text = "" Then
            MsgBox("Isi Kode Diagnosa Terlebih Dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from diagnosa where kode_ICD='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If MsgBox("Apakah Akan Dihapus ?", vbYesNo, "Konfirmasi") = vbYes Then
                    Dim SqlHapus As String = "Delete from diagnosa where kode_ICD='" & txtkode.Text & "'"
                    cmd = New OleDbCommand(SqlHapus, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Telah Terhapus")
                    kosongkan()
                    tampilDiagnosa()
                Else
                    kosongkan()
                    Exit Sub
                End If
            Else
                MsgBox("Data Tidak Ditemukan")
            End If
        End If
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        kosongkan()
    End Sub

    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Me.Close()
    End Sub

    Private Sub btnbaru_Click(sender As Object, e As EventArgs) Handles btnbaru.Click
        kosongkan()
    End Sub
End Class