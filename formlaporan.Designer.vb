<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formlaporan
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkodeicd = New System.Windows.Forms.TextBox()
        Me.txtnamapenyakit = New System.Windows.Forms.TextBox()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.bttampilkan = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(174, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(235, 18)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "LAPORAN INDEKS PENYAKIT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(62, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(464, 25)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "RUMAH SAKIT HASAN SADIKIN BANDUNG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Kode ICD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Nama Penyakit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Dari Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Sampai Tanggal"
        '
        'txtkodeicd
        '
        Me.txtkodeicd.Location = New System.Drawing.Point(154, 99)
        Me.txtkodeicd.Name = "txtkodeicd"
        Me.txtkodeicd.Size = New System.Drawing.Size(100, 20)
        Me.txtkodeicd.TabIndex = 42
        '
        'txtnamapenyakit
        '
        Me.txtnamapenyakit.Location = New System.Drawing.Point(154, 140)
        Me.txtnamapenyakit.Multiline = True
        Me.txtnamapenyakit.Name = "txtnamapenyakit"
        Me.txtnamapenyakit.Size = New System.Drawing.Size(329, 72)
        Me.txtnamapenyakit.TabIndex = 43
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(154, 229)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(200, 20)
        Me.dtpFrom.TabIndex = 44
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(154, 267)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(200, 20)
        Me.dtpTo.TabIndex = 45
        '
        'bttampilkan
        '
        Me.bttampilkan.Location = New System.Drawing.Point(123, 322)
        Me.bttampilkan.Name = "bttampilkan"
        Me.bttampilkan.Size = New System.Drawing.Size(106, 32)
        Me.bttampilkan.TabIndex = 46
        Me.bttampilkan.Text = "Tampilkan"
        Me.bttampilkan.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Location = New System.Drawing.Point(274, 322)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(106, 32)
        Me.btbatal.TabIndex = 47
        Me.btbatal.Text = "Batal"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'formlaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 405)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.bttampilkan)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.txtnamapenyakit)
        Me.Controls.Add(Me.txtkodeicd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Name = "formlaporan"
        Me.Text = "formlaporan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtkodeicd As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapenyakit As System.Windows.Forms.TextBox
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents bttampilkan As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
End Class
