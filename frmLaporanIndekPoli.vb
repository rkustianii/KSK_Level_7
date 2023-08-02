Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmLaporanIndekPoli
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CRV.SelectionFormula = "{indeksing.tanggal_kunjungan} >= date('" & Format(dtAwal.Value, "yyyy/MM/dd") & "') and {indeksing.tanggal_kunjungan} <= date('" & Format(dtAkhir.Value, "yyyy/MM/dd") & "') and {indeksing.nama_poli}='" & cmbPoli.Text & "'"
        cryRpt.Load("..\..\reports\LaporanIndexingpoli.rpt")
        Call setting_laporan()
        cryRpt.VerifyDatabase()
        CRV.ReportSource = cryRpt
        CRV.RefreshReport()
    End Sub
    Private Sub frmLaporanIndekPoli_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Dim str As String
        str = "select * from poliklinik"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                cmbPoli.Items.Add(rd("nama_poli"))
            Loop
        End If
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
