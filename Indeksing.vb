Imports System.Data.OleDb
Public Class Indeksing
    Sub Kosongkan()
        txtno.Text = ""
        txtrm.Text = ""
        txtpasien.Text = ""
        txtjenis.Text = ""
        txtumur.Text = ""
        Dtkunjungan.Text = Now
        txtICD.Text = ""
        txtdiagnosa.Text = ""
        cbDokter.Text = ""
        txtnamadok.Text = ""
        cbstatus.Text = ""
        cbPoli.Text = ""
        txtnamapoli.Text = ""
        txtnamadok.Text = ""
    End Sub
    Sub Tampil()
        da = New OleDbDataAdapter("Select * from indeksing", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "indeksing")
        dgvindeksing.DataSource = (ds.Tables("indeksing"))
        dgvindeksing.ReadOnly = True
    End Sub
    Sub Dokter()
        cmd = New OleDbCommand("select * from Dokter", conn)
        rd = cmd.ExecuteReader()
        Do While rd.Read
            cbDokter.Items.Add(rd.GetString(0))
        Loop
    End Sub
    Sub Poli()
        cmd = New OleDbCommand("select * from Poliklinik", conn)
        rd = cmd.ExecuteReader()
        Do While rd.Read
            cbPoli.Items.Add(rd.GetString(0))
        Loop
    End Sub
    Private Sub Indeksing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Tampil()
        Kosongkan()
        Dokter()
        Poli()
    End Sub
    Private Sub txtrm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrm.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtrm.Text = "" Then
                MsgBox("Silahkan Isi Nomor Rekam Medis Terlebih Dahulu")
                Exit Sub
            Else
                cmd = New OleDbCommand("Select * from Pasien where No_RM='" & txtrm.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    txtrm.Text = rd.Item("no_rm")
                    txtpasien.Text = rd.Item("nama_Pasien")
                    txtjenis.Text = rd.Item("Jenis_Kelamin")
                    txtumur.Text = rd.Item("umur")
                Else
                    MsgBox("Data Tidak Ditemkan, Pastikan Kembali Nomor Rekam Medis")
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub txtICD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtICD.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtICD.Text = "" Then
                MsgBox("Silahkan Isi Kode ICD Terlebih Dahulu")
                Exit Sub
            Else
                cmd = New OleDbCommand("Select * from Diagnosa where Kode_ICD='" & txtICD.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    txtICD.Text = rd.Item("Kode_ICD")
                    txtdiagnosa.Text = rd.Item("nama_Penyakit")
                Else
                    MsgBox("Data Tidak Ditemukan, Pastikan Kembali Nomor Rekam Medis")
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtno.Text = "" Or txtrm.Text = "" Or txtpasien.Text = "" Or txtjenis.Text = "" Or txtumur.Text = "" Or Dtkunjungan.Text = "" Or txtICD.Text = "" Or txtdiagnosa.Text = "" Or cbDokter.Text = "" Or cbPoli.Text = "" Or cbstatus.Text = "" Or txtnamadok.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan Lengkapi !!")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from indeksing where no_entri='" &
           txtno.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqlTambah As String = "insert into indeksing (no_entri,no_rm,nama_pasien,jenis_kelamin,umur,tanggal_kunjungan,diagnosa,kode_ICD,kode_dokter,nama_dokter,status_pasien,kode_poli,nama_poli) values ('" & txtno.Text & "','" & txtrm.Text & "','" & txtpasien.Text & "','" & txtjenis.Text & "','" & txtumur.Text & "','" & Dtkunjungan.Text & "','" & txtdiagnosa.Text & "','" & txtICD.Text & "','" & cbDokter.Text & "','" & txtnamadok.Text & "','" & cbstatus.Text & "','" & cbPoli.Text & "','" & txtnamapoli.Text & "')"
                cmd = New OleDbCommand(sqlTambah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Tersimpan")
                Kosongkan()
                Tampil()
            Else
                MsgBox("Data Sudah Ada")
            End If
        End If
    End Sub
    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        If txtno.Text = "" Then
            MsgBox("Isi No Entri Terlebih Dahulu")
            Exit Sub
        Else
            Dim X, Y, Z As String
            cmd = New OleDbCommand("Select * from indeksing where no_entri='" & txtno.Text & "'", conn)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                While rd.Read
                    txtno.Text = rd.Item(0).ToString()
                    txtrm.Text = rd.Item(1).ToString()
                    txtpasien.Text = rd.Item(2).ToString()
                    txtjenis.Text = rd.Item(3).ToString()
                    txtumur.Text = rd.Item(4).ToString()
                    Dtkunjungan.Text = rd.Item(5).ToString()
                    txtdiagnosa.Text = rd.Item(6).ToString()
                    txtICD.Text = rd.Item(7).ToString()
                    X = rd.Item(8).ToString()
                    Y = rd.Item(10).ToString()
                    Z = rd.Item(11).ToString()
                    txtnamapoli.Text = rd.Item(12).ToString()
                    txtnamadok.Text = rd.Item(9).ToString()
                End While
                cbDokter.Text = X
                cbstatus.Text = Y
                cbPoli.Text = Z
            Else
                MsgBox("Data Tidak Ditemukan")
                Kosongkan()
                Tampil()
            End If
        End If
    End Sub
    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        If txtno.Text = "" Then
            MsgBox("Data Belum Lengkap, Silahkan Lengkapi")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from indeksing where no_entri='" & txtno.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim sqlEdit As String = "Update indeksing set no_entri='" & txtno.Text & "',nama_pasien='" & txtpasien.Text & "',jenis_kelamin='" & txtjenis.Text & "',umur='" & txtumur.Text & "',tanggal_kunjungan='" & Dtkunjungan.Text & "',diagnosa='" & txtdiagnosa.Text & "',kode_ICD='" & txtICD.Text & "',kode_dokter='" & cbDokter.Text & "',status_pasien='" & cbstatus.Text & "',kode_poli='" & cbPoli.Text & "',nama_dokter='" & txtnamadok.Text & "' where no_entri = '" & txtno.Text & "'"
                cmd = New OleDbCommand(sqlEdit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Telah Diubah")
                Kosongkan()
                Tampil()
            Else
                MsgBox("Data Tidak ada, pastikan kembali data yang akan diubah")
            End If
        End If
    End Sub
    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Kosongkan()
    End Sub
    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Kosongkan()
    End Sub
    'Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hapus.Click
    '    Me.Close()
    'End Sub
    Private Sub Hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hapus.Click
        If txtno.Text = "" Then
            MsgBox("Isi no entri Terlebih Dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from indeksing where no_entri='" & txtno.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If MsgBox("Apakah Akan Dihapus ?", vbYesNo, "Konfirmasi") = vbYes Then
                    Dim SqlHapus As String = "Delete from indeksing where no_entri='" & txtno.Text & "'"
                    cmd = New OleDbCommand(SqlHapus, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Telah Terhapus")
                    Kosongkan()
                    Tampil()
                Else
                    Kosongkan()
                    Exit Sub
                End If
            Else
                MsgBox("Data Tidak Ditemukan")
            End If
        End If
    End Sub
    Private Sub cbDokter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDokter.SelectedIndexChanged
        cbstatus.MaxLength = 20
        If cbDokter.Text = "" Then
            MsgBox("Silahkan pilih terlebih dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select *from dokter where kode_dokter='" & cbDokter.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                cbDokter.Text = rd.Item("kode_dokter").ToString()
                txtnamadok.Text = rd.Item("nama_dokter").ToString()
            Else
                MsgBox("Data Tidak Ditemukan, Pastikan Kembali kode dokter anda")
                Exit Sub
            End If
        End If
    End Sub
    Private Sub cbPoli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPoli.SelectedIndexChanged
        cbPoli.MaxLength = 20
        If cbPoli.Text = "" Then
            MsgBox("Silahkan pilih terlebih dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select *from poliklinik where kode_poli='" & cbPoli.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                cbPoli.Text = rd.Item("kode_poli").ToString()
                txtnamapoli.Text = rd.Item("nama_poli").ToString()
            Else
                MsgBox("Data Tidak Ditemukan, Pastikan Kembali kode poli anda")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub
End Class
