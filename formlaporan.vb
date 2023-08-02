'Imports System.Data.OleDb
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
'Public Class formlaporan
'    Private Sub formlaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Call koneksi()
'    End Sub
'    Private Sub txtkodeicd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkodeicd.KeyPress
'        If e.KeyChar = Chr(13) Then
'            If txtkodeicd.Text = "" Then
'                MsgBox("Silahkan Isi Kode ICD terlebih Dahulu")
'                Exit Sub
'            Else
'                cmd = New OleDbCommand("Select * from Diagnosa where Kode_ICD='" & txtkodeicd.Text & "'", conn)
'                rd = cmd.ExecuteReader
'                rd.Read()
'                If Not rd.HasRows Then
'                    MsgBox("Data Tidak Ditemukan, pastikan kembali Kode ICD")
'                    Exit Sub
'                Else
'                    txtkodeicd.Text = rd.Item("Kode_ICD")
'                    txtnamapenyakit.Text = rd.Item("Nama_Penyakit")
'                End If
'            End If
'        End If
'    End Sub
'    Private Sub bttampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampilkan.Click
'        If txtnamapenyakit.Text = "" Then
'            MsgBox("Pastikan Kembali Kode ICD dan Nama Penyakit")
'            Exit Sub
'        End If
'        If dtpTo.Value >= Now Or dtpFrom.Value >= Now Or dtpFrom.Value >= dtpTo.Value Then
'            MsgBox("Pastikan Kembali Tanggal Pencarian")
'            Exit Sub
'        End If
'        cmd = New OleDbCommand("Select kode_ICD from indeksing where kode_ICD='" & txtkodeicd.Text & "' and [Tanggal_Kunjungan] >= #" & Format(dtpFrom.Value, "dd/MM/yyyy") & "# and [Tanggal_Kunjungan] <= #" & Format(dtpTo.Value, "dd/MM/yyyy") & "#", conn)
'        rd = cmd.ExecuteReader
'        rd.Read()
'        If Not rd.HasRows Then
'            MsgBox("Data Tidak Ditemukan")
'            Exit Sub
'        Else
'            Dim Kuring As New LaporanIndexing
'            Dim a As CrystalDecisions.CrystalReports.Engine.Table
'            Dim b As CrystalDecisions.Shared.TableLogOnInfo
'            Dim x As String = txtkodeicd.Text
'            Kuring.Load(Application.StartupPath & "\LaporanIndexing.rpt")
'            Kuring.SetParameterValue("kode_icd", x)
'            Tamper.CRV.SelectionFormula = "{indeksing.Tanggal_Kunjungan} >= #" & CDate(Format(dtpFrom.Value, "yyyy/MM/dd")) & "# and {indeksing.Tanggal_Kunjungan} <= #" & CDate(Format(dtpTo.Value, "yyyy/MM/dd")) & "#"
'            For Each a In Kuring.Database.Tables
'                b = a.LogOnInfo
'                With b.ConnectionInfo
'                    .ServerName = Application.StartupPath & "\dbindekspenyakit.mdb"
'                    .UserID = ""
'                    .Password = ""
'                    .DatabaseName = ""
'                End With
'                a.ApplyLogOnInfo(b)
'            Next a
'            Tamper.CRV.ReportSource = Kuring
'            Tamper.Show()
'        End If
'    End Sub
'    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
'        Main.Show()
'        Me.Close()
'    End Sub
'End Class