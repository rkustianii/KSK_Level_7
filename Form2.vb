Imports System.Data.OleDb
Public Class Dokter
    Sub Kosongkan()
        txtkode.Text = ""
        txtnama.Text = ""
        dttgl.Value = Now
        txtalamat.Text = ""
        txtspesialis.Text = ""
        cmbstatus.Text = ""
        txttlp.Text = ""
        txtkode.Focus()
    End Sub
    Sub TampilDokter()
        da = New OleDbDataAdapter("Select * from dokter", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "dokter")
        dgvDokter.DataSource = (ds.Tables("dokter"))
        dgvDokter.ReadOnly = True
    End Sub

    Private Sub Dokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        TampilDokter()
        Kosongkan()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkode.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or txtspesialis.Text = "" Or txttlp.Text = "" Or cmbstatus.Text = "" Then
            MsgBox("Data Belum Lengkap, Silahkan Lengkapi")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from dokter where kode_dokter='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqlTambah As String = "insert into dokter (kode_dokter,nama_dokter,tanggal_lahir,alamat,spesialis,status,no_telpon) values ('" & txtkode.Text & "','" & txtnama.Text & "','" & dttgl.Text & "','" & txtalamat.Text & "','" & txtspesialis.Text & "','" & cmbstatus.Text & "','" & txttlp.Text & "')"
                cmd = New OleDbCommand(sqlTambah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Tersimpan")
                Kosongkan()
                TampilDokter()
            Else
                MsgBox("Data Sudah Ada")
            End If
        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        If txtkode.Text = "" Then
            MsgBox("Isi Kode Dokte Terlebih Dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from dokter where kode_dokter='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtkode.Text = rd.Item("kode_dokter")
                txtnama.Text = rd.Item("nama_dokter")
                dttgl.Text = rd.Item("tanggal_lahir")
                txtalamat.Text = rd.Item("alamat")
                txtspesialis.Text = rd.Item("spesialis")
                cmbstatus.Text = rd.Item("status")
                txttlp.Text = rd.Item("no_telpon")
            Else
                MsgBox("Data Tidak Ditemukan")
                Kosongkan()
                TampilDokter()
            End If
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtkode.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or txtspesialis.Text = "" Or txttlp.Text = "" Or cmbstatus.Text = "" Then
            MsgBox("Data Belum Lengkap, Silahkan Lengkapi")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from Dokter where kode_Dokter='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim sqlEdit As String = "Update Dokter set kode_dokter='" & txtkode.Text & "',nama_dokter='" & txtnama.Text & "',tanggal_lahir='" & dttgl.Text & "',alamat='" & txtalamat.Text & "',spesialis='" & txtspesialis.Text & "',status='" & cmbstatus.Text & "',no_telpon='" & txttlp.Text & "' where kode_dokter='" & txtkode.Text & "'"
                cmd = New OleDbCommand(sqlEdit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Telah Diubah")
                Kosongkan()
                TampilDokter()
            Else
                MsgBox("Data Tidak ada, pastikan kembali data yang akan diubah")
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtkode.Text = "" Then
            MsgBox("Isi Kode Dokter Terlebih Dahulu")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from Dokter where kode_dokter='" & txtkode.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If MsgBox("Apakah Akan Dihapus ?", vbYesNo, "Konfirmasi") = vbYes Then
                    Dim SqlHapus As String = "Delete from dokter where kode_dokter='" & txtkode.Text & "'"
                    cmd = New OleDbCommand(SqlHapus, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Telah Terhapus")
                    Kosongkan()
                    TampilDokter()
                Else
                    Kosongkan()
                    Exit Sub
                End If
            Else
                MsgBox("Data Tidak Ditemukan")
            End If
        End If
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Kosongkan()
    End Sub
    
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Kosongkan()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        'Main.Show()
        Me.Close()
    End Sub
End Class