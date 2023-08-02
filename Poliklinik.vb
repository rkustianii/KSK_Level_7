
Imports System.Data.OleDb
Public Class Poliklinik
    Sub tampilpoliklinik()
        da = New OleDbDataAdapter("Select * from Poliklinik", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "poliklinik")
        dgvpoliklinik.DataSource = (ds.Tables("Poliklinik"))
        dgvpoliklinik.ReadOnly = True
    End Sub
    Sub kosongkan()
        txtkode.Text = ""
        txtpoli.Text = ""
        txtkode.Focus()
    End Sub
    Private Sub Diagnosa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        tampilpoliklinik()
    End Sub
    Private Sub btnsimpsn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpsn.Click
        If txtkode.Text = "" Or txtpoli.Text = "" Then
            MsgBox("Data Belum Lengkap, Silahkan Lengkapi")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from Poliklinik where kode_poli='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqlTambah As String = "insert into Poliklinik (kode_poli,Nama_poli) values ('" & txtkode.Text & "','" & txtpoli.Text & "')"
                cmd = New OleDbCommand(sqlTambah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Tersimpan")
                kosongkan()
                tampilpoliklinik()
            Else
                MsgBox("Data Sudah Ada")
            End If
        End If
    End Sub
    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        If txtkode.Text = "" Then
            MsgBox("Isi Kode poli Terlebih Dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from Poliklinik where kode_poli='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtkode.Text = rd.Item("kode_poli")
                txtpoli.Text = rd.Item("Nama_poli")
            Else
                MsgBox("Data Tidak Ditemukan")
                kosongkan()
                tampilpoliklinik()
            End If
        End If
    End Sub
    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        If txtkode.Text = "" Or txtpoli.Text = "" Then
            MsgBox("Data Belum Lengkap, Silahkan Lengkapi")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from poliklinik where kode_poli='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim sqlEdit As String = "Update poliklinik set kode_poli='" &
               txtkode.Text & "',nama_poli='" & txtpoli.Text & "' where kode_poli= '" & txtkode.Text & "'"
                cmd = New OleDbCommand(sqlEdit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Telah Diubah")
                kosongkan()
                tampilpoliklinik()
            Else
                MsgBox("Data Tidak ada, pastikan kembali data yang akan diubah")
            End If
        End If
    End Sub
    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If txtkode.Text = "" Then
            MsgBox("Isi Kode poli Terlebih Dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from poliklinik where kode_poli='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If MsgBox("Apakah Akan Dihapus ?", vbYesNo, "Konfirmasi") = vbYes Then
                    Dim SqlHapus As String = "Delete from poliklinik where kode_poli='" & txtkode.Text & "'"
                    cmd = New OleDbCommand(SqlHapus, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Telah Terhapus")
                    kosongkan()
                    tampilpoliklinik()
                Else
                    kosongkan()
                    Exit Sub
                End If
            Else
                MsgBox("Data Tidak Ditemukan")
            End If
        End If
    End Sub
    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        kosongkan()
    End Sub
    Private Sub btntutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntutup.Click
        'Main.Show()
        Me.Close()
    End Sub
    Private Sub btnbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaru.Click
        kosongkan()
    End Sub
End Class
