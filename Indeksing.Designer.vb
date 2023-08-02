<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Indeksing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnamapoli = New System.Windows.Forms.TextBox()
        Me.cbPoli = New System.Windows.Forms.ComboBox()
        Me.cbstatus = New System.Windows.Forms.ComboBox()
        Me.txtnamadok = New System.Windows.Forms.TextBox()
        Me.cbDokter = New System.Windows.Forms.ComboBox()
        Me.txtdiagnosa = New System.Windows.Forms.TextBox()
        Me.txtICD = New System.Windows.Forms.TextBox()
        Me.Dtkunjungan = New System.Windows.Forms.DateTimePicker()
        Me.txtjenis = New System.Windows.Forms.TextBox()
        Me.txtumur = New System.Windows.Forms.TextBox()
        Me.txtpasien = New System.Windows.Forms.TextBox()
        Me.txtrm = New System.Windows.Forms.TextBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.dgvindeksing = New System.Windows.Forms.DataGridView()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvindeksing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Antrian"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Rekam Medis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pasien"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Umur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Kunjungan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(436, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kode ICD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(436, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Diagnosa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(436, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Kode Dokter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(436, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Nama Dokter"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(436, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Status Pasien"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(437, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Kode Poli"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(381, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(436, 264)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Nama Poliklinik"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(321, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 24)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Index Penyakit"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(160, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(464, 25)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "RUMAH SAKIT HASAN SADIKIN BANDUNG"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnamapoli)
        Me.GroupBox1.Controls.Add(Me.cbPoli)
        Me.GroupBox1.Controls.Add(Me.cbstatus)
        Me.GroupBox1.Controls.Add(Me.txtnamadok)
        Me.GroupBox1.Controls.Add(Me.cbDokter)
        Me.GroupBox1.Controls.Add(Me.txtdiagnosa)
        Me.GroupBox1.Controls.Add(Me.txtICD)
        Me.GroupBox1.Controls.Add(Me.Dtkunjungan)
        Me.GroupBox1.Controls.Add(Me.txtjenis)
        Me.GroupBox1.Controls.Add(Me.txtumur)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtpasien)
        Me.GroupBox1.Controls.Add(Me.txtrm)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 308)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'txtnamapoli
        '
        Me.txtnamapoli.Location = New System.Drawing.Point(554, 261)
        Me.txtnamapoli.Name = "txtnamapoli"
        Me.txtnamapoli.Size = New System.Drawing.Size(100, 20)
        Me.txtnamapoli.TabIndex = 20
        '
        'cbPoli
        '
        Me.cbPoli.FormattingEnabled = True
        Me.cbPoli.Location = New System.Drawing.Point(554, 225)
        Me.cbPoli.Name = "cbPoli"
        Me.cbPoli.Size = New System.Drawing.Size(121, 21)
        Me.cbPoli.TabIndex = 19
        '
        'cbstatus
        '
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Location = New System.Drawing.Point(554, 186)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(121, 21)
        Me.cbstatus.TabIndex = 18
        '
        'txtnamadok
        '
        Me.txtnamadok.Location = New System.Drawing.Point(554, 146)
        Me.txtnamadok.Name = "txtnamadok"
        Me.txtnamadok.Size = New System.Drawing.Size(100, 20)
        Me.txtnamadok.TabIndex = 17
        '
        'cbDokter
        '
        Me.cbDokter.FormattingEnabled = True
        Me.cbDokter.Location = New System.Drawing.Point(554, 110)
        Me.cbDokter.Name = "cbDokter"
        Me.cbDokter.Size = New System.Drawing.Size(121, 21)
        Me.cbDokter.TabIndex = 16
        '
        'txtdiagnosa
        '
        Me.txtdiagnosa.Location = New System.Drawing.Point(554, 68)
        Me.txtdiagnosa.Name = "txtdiagnosa"
        Me.txtdiagnosa.Size = New System.Drawing.Size(100, 20)
        Me.txtdiagnosa.TabIndex = 15
        '
        'txtICD
        '
        Me.txtICD.Location = New System.Drawing.Point(554, 26)
        Me.txtICD.Name = "txtICD"
        Me.txtICD.Size = New System.Drawing.Size(100, 20)
        Me.txtICD.TabIndex = 14
        '
        'Dtkunjungan
        '
        Me.Dtkunjungan.Location = New System.Drawing.Point(138, 228)
        Me.Dtkunjungan.Name = "Dtkunjungan"
        Me.Dtkunjungan.Size = New System.Drawing.Size(200, 20)
        Me.Dtkunjungan.TabIndex = 11
        '
        'txtjenis
        '
        Me.txtjenis.Location = New System.Drawing.Point(138, 146)
        Me.txtjenis.Name = "txtjenis"
        Me.txtjenis.Size = New System.Drawing.Size(100, 20)
        Me.txtjenis.TabIndex = 10
        '
        'txtumur
        '
        Me.txtumur.Location = New System.Drawing.Point(138, 186)
        Me.txtumur.Name = "txtumur"
        Me.txtumur.Size = New System.Drawing.Size(100, 20)
        Me.txtumur.TabIndex = 9
        '
        'txtpasien
        '
        Me.txtpasien.Location = New System.Drawing.Point(138, 110)
        Me.txtpasien.Name = "txtpasien"
        Me.txtpasien.Size = New System.Drawing.Size(100, 20)
        Me.txtpasien.TabIndex = 8
        '
        'txtrm
        '
        Me.txtrm.Location = New System.Drawing.Point(138, 68)
        Me.txtrm.Name = "txtrm"
        Me.txtrm.Size = New System.Drawing.Size(100, 20)
        Me.txtrm.TabIndex = 7
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(138, 26)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(100, 20)
        Me.txtno.TabIndex = 6
        '
        'dgvindeksing
        '
        Me.dgvindeksing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvindeksing.Location = New System.Drawing.Point(12, 427)
        Me.dgvindeksing.Name = "dgvindeksing"
        Me.dgvindeksing.Size = New System.Drawing.Size(659, 258)
        Me.dgvindeksing.TabIndex = 35
        '
        'Hapus
        '
        Me.Hapus.Location = New System.Drawing.Point(775, 524)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(75, 43)
        Me.Hapus.TabIndex = 41
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(775, 426)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 43)
        Me.btnsimpan.TabIndex = 40
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(775, 475)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 43)
        Me.btnbatal.TabIndex = 39
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(694, 524)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 43)
        Me.btncari.TabIndex = 38
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(694, 475)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 43)
        Me.btnubah.TabIndex = 37
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(694, 426)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 43)
        Me.btntambah.TabIndex = 36
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(735, 573)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 43)
        Me.btnkeluar.TabIndex = 42
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'Indeksing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 699)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.dgvindeksing)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Name = "Indeksing"
        Me.Text = "Indeksing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvindeksing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnamapoli As System.Windows.Forms.TextBox
    Friend WithEvents cbPoli As System.Windows.Forms.ComboBox
    Friend WithEvents cbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtnamadok As System.Windows.Forms.TextBox
    Friend WithEvents cbDokter As System.Windows.Forms.ComboBox
    Friend WithEvents txtdiagnosa As System.Windows.Forms.TextBox
    Friend WithEvents txtICD As System.Windows.Forms.TextBox
    Friend WithEvents Dtkunjungan As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtjenis As System.Windows.Forms.TextBox
    Friend WithEvents txtumur As System.Windows.Forms.TextBox
    Friend WithEvents txtpasien As System.Windows.Forms.TextBox
    Friend WithEvents txtrm As System.Windows.Forms.TextBox
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents dgvindeksing As System.Windows.Forms.DataGridView
    Friend WithEvents Hapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
End Class
