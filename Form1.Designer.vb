<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formpasien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formpasien))
        Me.txtnorm = New System.Windows.Forms.TextBox()
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
        Me.txtnamapasien = New System.Windows.Forms.TextBox()
        Me.rblaki = New System.Windows.Forms.RadioButton()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.txttempatlahir = New System.Windows.Forms.TextBox()
        Me.dtpLahir = New System.Windows.Forms.DateTimePicker()
        Me.txtumur = New System.Windows.Forms.TextBox()
        Me.cbagama = New System.Windows.Forms.ComboBox()
        Me.cbstatus = New System.Windows.Forms.ComboBox()
        Me.cbpekerjaan = New System.Windows.Forms.ComboBox()
        Me.cbDik = New System.Windows.Forms.ComboBox()
        Me.txttelpon = New System.Windows.Forms.TextBox()
        Me.dgpasien = New System.Windows.Forms.DataGridView()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.btubah = New System.Windows.Forms.Button()
        Me.btcari = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.dgpasien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnorm
        '
        Me.txtnorm.Location = New System.Drawing.Point(134, 89)
        Me.txtnorm.Name = "txtnorm"
        Me.txtnorm.Size = New System.Drawing.Size(186, 20)
        Me.txtnorm.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. Rekam Medis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Pasien"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tempat Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Umur"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Agama"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(394, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(394, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Pekerjaan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(394, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Pendidikan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(394, 238)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "No. Telepon"
        '
        'txtnamapasien
        '
        Me.txtnamapasien.Location = New System.Drawing.Point(134, 128)
        Me.txtnamapasien.Name = "txtnamapasien"
        Me.txtnamapasien.Size = New System.Drawing.Size(186, 20)
        Me.txtnamapasien.TabIndex = 13
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.Location = New System.Drawing.Point(134, 164)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(68, 17)
        Me.rblaki.TabIndex = 14
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "Laki-Laki"
        Me.rblaki.UseVisualStyleBackColor = True
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.Location = New System.Drawing.Point(230, 164)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbperempuan.TabIndex = 15
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'txttempatlahir
        '
        Me.txttempatlahir.Location = New System.Drawing.Point(134, 200)
        Me.txttempatlahir.Name = "txttempatlahir"
        Me.txttempatlahir.Size = New System.Drawing.Size(186, 20)
        Me.txttempatlahir.TabIndex = 16
        '
        'dtpLahir
        '
        Me.dtpLahir.Location = New System.Drawing.Point(134, 236)
        Me.dtpLahir.Name = "dtpLahir"
        Me.dtpLahir.Size = New System.Drawing.Size(186, 20)
        Me.dtpLahir.TabIndex = 17
        '
        'txtumur
        '
        Me.txtumur.Location = New System.Drawing.Point(134, 274)
        Me.txtumur.Name = "txtumur"
        Me.txtumur.Size = New System.Drawing.Size(100, 20)
        Me.txtumur.TabIndex = 18
        '
        'cbagama
        '
        Me.cbagama.FormattingEnabled = True
        Me.cbagama.Location = New System.Drawing.Point(483, 89)
        Me.cbagama.Name = "cbagama"
        Me.cbagama.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbagama.Size = New System.Drawing.Size(121, 21)
        Me.cbagama.TabIndex = 20
        '
        'cbstatus
        '
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Location = New System.Drawing.Point(483, 127)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbstatus.Size = New System.Drawing.Size(121, 21)
        Me.cbstatus.TabIndex = 21
        '
        'cbpekerjaan
        '
        Me.cbpekerjaan.FormattingEnabled = True
        Me.cbpekerjaan.Location = New System.Drawing.Point(483, 160)
        Me.cbpekerjaan.Name = "cbpekerjaan"
        Me.cbpekerjaan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbpekerjaan.Size = New System.Drawing.Size(121, 21)
        Me.cbpekerjaan.TabIndex = 22
        '
        'cbDik
        '
        Me.cbDik.FormattingEnabled = True
        Me.cbDik.Location = New System.Drawing.Point(483, 199)
        Me.cbDik.Name = "cbDik"
        Me.cbDik.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbDik.Size = New System.Drawing.Size(121, 21)
        Me.cbDik.TabIndex = 23
        '
        'txttelpon
        '
        Me.txttelpon.Location = New System.Drawing.Point(483, 235)
        Me.txttelpon.Name = "txttelpon"
        Me.txttelpon.Size = New System.Drawing.Size(121, 20)
        Me.txttelpon.TabIndex = 24
        '
        'dgpasien
        '
        Me.dgpasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpasien.Location = New System.Drawing.Point(12, 390)
        Me.dgpasien.Name = "dgpasien"
        Me.dgpasien.Size = New System.Drawing.Size(388, 150)
        Me.dgpasien.TabIndex = 25
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(421, 390)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(75, 43)
        Me.bttambah.TabIndex = 26
        Me.bttambah.Text = "Tambah"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'btubah
        '
        Me.btubah.Location = New System.Drawing.Point(421, 439)
        Me.btubah.Name = "btubah"
        Me.btubah.Size = New System.Drawing.Size(75, 43)
        Me.btubah.TabIndex = 27
        Me.btubah.Text = "Ubah"
        Me.btubah.UseVisualStyleBackColor = True
        '
        'btcari
        '
        Me.btcari.Location = New System.Drawing.Point(421, 488)
        Me.btcari.Name = "btcari"
        Me.btcari.Size = New System.Drawing.Size(75, 43)
        Me.btcari.TabIndex = 28
        Me.btcari.Text = "Cari"
        Me.btcari.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Location = New System.Drawing.Point(502, 439)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(75, 43)
        Me.btbatal.TabIndex = 29
        Me.btbatal.Text = "Batal"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(502, 390)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 43)
        Me.btsimpan.TabIndex = 30
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(502, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(153, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(464, 25)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "RUMAH SAKIT HASAN SADIKIN BANDUNG"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(286, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 18)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "DATA PASIEN"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(134, 309)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(186, 75)
        Me.txtalamat.TabIndex = 34
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(700, 539)
        Me.ShapeContainer1.TabIndex = 36
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 10
        Me.LineShape1.X2 = 690
        Me.LineShape1.Y1 = 80
        Me.LineShape1.Y2 = 80
        '
        'formpasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 539)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.btcari)
        Me.Controls.Add(Me.btubah)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.dgpasien)
        Me.Controls.Add(Me.txttelpon)
        Me.Controls.Add(Me.cbDik)
        Me.Controls.Add(Me.cbpekerjaan)
        Me.Controls.Add(Me.cbstatus)
        Me.Controls.Add(Me.cbagama)
        Me.Controls.Add(Me.txtumur)
        Me.Controls.Add(Me.dtpLahir)
        Me.Controls.Add(Me.txttempatlahir)
        Me.Controls.Add(Me.rbperempuan)
        Me.Controls.Add(Me.rblaki)
        Me.Controls.Add(Me.txtnamapasien)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnorm)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "formpasien"
        Me.Text = "Form Pasien"
        CType(Me.dgpasien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnorm As System.Windows.Forms.TextBox
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
    Friend WithEvents txtnamapasien As System.Windows.Forms.TextBox
    Friend WithEvents rblaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents txttempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents dtpLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtumur As System.Windows.Forms.TextBox
    Friend WithEvents cbagama As System.Windows.Forms.ComboBox
    Friend WithEvents cbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents cbpekerjaan As System.Windows.Forms.ComboBox
    Friend WithEvents cbDik As System.Windows.Forms.ComboBox
    Friend WithEvents txttelpon As System.Windows.Forms.TextBox
    Friend WithEvents dgpasien As System.Windows.Forms.DataGridView
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents btubah As System.Windows.Forms.Button
    Friend WithEvents btcari As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
