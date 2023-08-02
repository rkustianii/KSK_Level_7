
Imports System.Data.OleDb
Public Class formpasien
    Sub kosongkan()
        txtnorm.Clear()
        txtnamapasien.Clear()
        txttempatlahir.Clear()
        dtpLahir.Text = Now
        rblaki.Checked = False
        rbperempuan.Checked = False
        txtumur.Clear()
        txtalamat.Clear()
        cbagama.Text = ""
        cbstatus.Text = ""
        cbDik.Text = ""
        cbpekerjaan.Text = ""
        txttelpon.Clear()
        txtnorm.Focus()
    End Sub
    Sub nomorotomatis()
 cmd = New OleDbCommand("select *from pasien where no_rm in (select max(no_rm) from pasien) order by no_rm desc", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            txtnorm.Text = Format(Now, "yyMM") + "01"
        Else
            If Microsoft.VisualBasic.Left(rd.GetString(0), 4) <> Format(Now, "yyMM") Then
                txtnorm.Text = Format(Now, "yyMM") + "01"
            Else
                txtnorm.Text = rd.GetString(0) + 1
            End If
        End If
    End Sub
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from pasien", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pasien")
        dgpasien.DataSource = (ds.Tables("pasien"))
        dgpasien.ReadOnly = True
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Tampilkan()
    End Sub
    Private Sub bttambah_Click(sender As Object, e As EventArgs)
        kosongkan()
        nomorotomatis()
    End Sub

    Private Sub dtpLahir_ValueChanged(sender As Object, e As EventArgs) Handles dtpLahir.ValueChanged
        txtumur.Text = Format(Now, "yyyy") - Val(Format(dtpLahir.Value, "yyyy"))
    End Sub

    Private Sub btbatal_Click(sender As Object, e As EventArgs) Handles btbatal.Click
        kosongkan()
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If txtnorm.Text = "" Or txtnamapasien.Text = "" Or txttempatlahir.Text = "" Or txtumur.Text = "" Or txtalamat.Text = "" Or cbagama.Text = "" Or cbstatus.Text = "" Or cbpekerjaan.Text = "" Or cbDik.Text = "" Or txttelpon.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan Lengkapi !!")
            Exit Sub
        Else
            Dim a As String
            If rblaki.Checked = True Then a = rblaki.Text
            If rbperempuan.Checked = True Then a = rbperempuan.Text
            cmd = New OleDbCommand("Select * from pasien where no_rm='" & txtnorm.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("Data Pasien Sudah Ada")
            Else
                Dim sqlTambah As String = "insert into pasien (no_rm,nama_pasien,jenis_kelamin,tempat_lahir,tanggal_lahir,umur,alamat,agama,status,pekerjaan,pendidikan,no_telpon) values ('" & txtnorm.Text & "','" & txtnamapasien.Text & "','" & a & "','" & txttempatlahir.Text & "','" & dtpLahir.Text & "','" & txtumur.Text & "','" & txtalamat.Text & "','" & cbagama.Text & "','" & cbstatus.Text & "','" & cbpekerjaan.Text & "','" & cbDik.Text & "','" & txttelpon.Text & "')"
                cmd = New OleDbCommand(sqlTambah, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Tersimpan")
                kosongkan()
                Tampilkan()
            End If
        End If
    End Sub

    Private Sub btcari_Click(sender As Object, e As EventArgs) Handles btcari.Click
        If txtnorm.Text = "" Then
            MsgBox("Silahkan Isi No Rekam Medis Terlebih Dahulu")
            Exit Sub
        Else
            Dim a As String
 cmd = New OleDbCommand("Select * from Pasien where no_rm='" & txtnorm.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Data Tidak Ditemukan")
                Exit Sub
            Else
                txtnorm.Text = rd.Item("no_rm")
                txtnamapasien.Text = rd.Item("nama_pasien")
                a = rd.Item("jenis_kelamin")
                txttempatlahir.Text = rd.Item("tempat_lahir")
                dtpLahir.Text = rd.Item("tanggal_lahir")
                txtumur.Text = rd.Item("umur")
                txtalamat.Text = rd.Item("alamat")
                cbagama.Text = rd.Item("agama")
                cbstatus.Text = rd.Item("status")
                cbpekerjaan.Text = rd.Item("pekerjaan")
                cbDik.Text = rd.Item("pendidikan")
                txttelpon.Text = rd.Item("no_telpon")
                If a = "Laki-laki" Then rblaki.Checked = True
                If a = "Perempuan" Then rbperempuan.Checked = True
            End If
        End If
    End Sub

    Private Sub btubah_Click(sender As Object, e As EventArgs) Handles btubah.Click
        If txtnorm.Text = "" Or txttempatlahir.Text = "" Or txtumur.Text = "" Or txtalamat.Text = "" Or cbpekerjaan.Text = "" Or cbagama.Text = "" Or cbstatus.Text = "" Or cbDik.Text = "" Then
            MsgBox("Data Belum Lengkap, silahkan Lengkapi !!")
            Exit Sub
        Else
            Dim a As String
            If rblaki.Checked = True Then a = rblaki.Text
            If rbperempuan.Checked = True Then a = rbperempuan.Text
            cmd = New OleDbCommand("Select * from pasien where no_rm='" & txtnorm.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim sqlEdit As String = "Update Pasien set no_rm='" & txtnorm.Text & "',nama_pasien= '" & txtnamapasien.Text & "',jenis_Kelamin= '" & a & "',tempat_Lahir='" & txttempatlahir.Text & "',tanggal_lahir='" & dtpLahir.Text & "',umur='" & txtumur.Text & "',alamat='" & txtalamat.Text & "',agama='" & cbagama.Text & "',status='" & cbstatus.Text & "',pekerjaan='" & cbpekerjaan.Text & "',pendidikan='" & cbDik.Text & "',no_telpon='" & txttelpon.Text & "' where no_rm='" & txtnorm.Text & "'"
                cmd = New OleDbCommand(sqlEdit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Telah Diubah")
                kosongkan()
                Tampilkan()
            End If
        End If
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Main.show()
    '    Me.Close()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

