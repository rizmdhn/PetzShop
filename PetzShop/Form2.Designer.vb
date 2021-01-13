<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TextBoxJumlah = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxTgl = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelTglTransaksi = New System.Windows.Forms.Label()
        Me.LabelBayar = New System.Windows.Forms.Label()
        Me.TextBoxBayar = New System.Windows.Forms.TextBox()
        Me.TextBoxKembali = New System.Windows.Forms.TextBox()
        Me.LabelDiskon = New System.Windows.Forms.Label()
        Me.labelJumlah = New System.Windows.Forms.Label()
        Me.GroupBoxDataTransaksi = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnaddbarang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxQTY = New System.Windows.Forms.TextBox()
        Me.ComboBoxBarang = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.GroupBoxDataTransaksi.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxJumlah
        '
        Me.TextBoxJumlah.BackColor = System.Drawing.Color.Blue
        Me.TextBoxJumlah.Enabled = False
        Me.TextBoxJumlah.Font = New System.Drawing.Font("Castellar", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJumlah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBoxJumlah.Location = New System.Drawing.Point(14, 40)
        Me.TextBoxJumlah.Name = "TextBoxJumlah"
        Me.TextBoxJumlah.Size = New System.Drawing.Size(333, 42)
        Me.TextBoxJumlah.TabIndex = 0
        Me.TextBoxJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxID
        '
        Me.TextBoxID.Enabled = False
        Me.TextBoxID.Font = New System.Drawing.Font("Castellar", 9.75!)
        Me.TextBoxID.Location = New System.Drawing.Point(6, 40)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(188, 23)
        Me.TextBoxID.TabIndex = 1
        '
        'TextBoxTgl
        '
        Me.TextBoxTgl.Enabled = False
        Me.TextBoxTgl.Font = New System.Drawing.Font("Castellar", 9.75!)
        Me.TextBoxTgl.Location = New System.Drawing.Point(6, 90)
        Me.TextBoxTgl.Name = "TextBoxTgl"
        Me.TextBoxTgl.Size = New System.Drawing.Size(188, 23)
        Me.TextBoxTgl.TabIndex = 2
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(6, 21)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(24, 16)
        Me.LabelID.TabIndex = 3
        Me.LabelID.Text = "ID"
        '
        'LabelTglTransaksi
        '
        Me.LabelTglTransaksi.AutoSize = True
        Me.LabelTglTransaksi.Font = New System.Drawing.Font("Castellar", 9.75!)
        Me.LabelTglTransaksi.Location = New System.Drawing.Point(3, 71)
        Me.LabelTglTransaksi.Name = "LabelTglTransaksi"
        Me.LabelTglTransaksi.Size = New System.Drawing.Size(167, 16)
        Me.LabelTglTransaksi.TabIndex = 4
        Me.LabelTglTransaksi.Text = "Tanggal Transaksi"
        '
        'LabelBayar
        '
        Me.LabelBayar.AutoSize = True
        Me.LabelBayar.Font = New System.Drawing.Font("Castellar", 12.0!)
        Me.LabelBayar.Location = New System.Drawing.Point(194, 89)
        Me.LabelBayar.Name = "LabelBayar"
        Me.LabelBayar.Size = New System.Drawing.Size(153, 19)
        Me.LabelBayar.TabIndex = 5
        Me.LabelBayar.Text = "Jumlah Bayar"
        '
        'TextBoxBayar
        '
        Me.TextBoxBayar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBoxBayar.Enabled = False
        Me.TextBoxBayar.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBayar.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBoxBayar.Location = New System.Drawing.Point(72, 112)
        Me.TextBoxBayar.Name = "TextBoxBayar"
        Me.TextBoxBayar.Size = New System.Drawing.Size(275, 30)
        Me.TextBoxBayar.TabIndex = 6
        Me.TextBoxBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxKembali
        '
        Me.TextBoxKembali.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxKembali.Enabled = False
        Me.TextBoxKembali.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKembali.ForeColor = System.Drawing.Color.Red
        Me.TextBoxKembali.Location = New System.Drawing.Point(148, 167)
        Me.TextBoxKembali.Name = "TextBoxKembali"
        Me.TextBoxKembali.Size = New System.Drawing.Size(199, 30)
        Me.TextBoxKembali.TabIndex = 7
        Me.TextBoxKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelDiskon
        '
        Me.LabelDiskon.AutoSize = True
        Me.LabelDiskon.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDiskon.Location = New System.Drawing.Point(259, 145)
        Me.LabelDiskon.Name = "LabelDiskon"
        Me.LabelDiskon.Size = New System.Drawing.Size(88, 19)
        Me.LabelDiskon.TabIndex = 8
        Me.LabelDiskon.Text = "Kembali"
        '
        'labelJumlah
        '
        Me.labelJumlah.AutoSize = True
        Me.labelJumlah.Font = New System.Drawing.Font("Castellar", 12.0!)
        Me.labelJumlah.Location = New System.Drawing.Point(144, 18)
        Me.labelJumlah.Name = "labelJumlah"
        Me.labelJumlah.Size = New System.Drawing.Size(85, 19)
        Me.labelJumlah.TabIndex = 9
        Me.labelJumlah.Text = "Jumlah"
        '
        'GroupBoxDataTransaksi
        '
        Me.GroupBoxDataTransaksi.Controls.Add(Me.TextBoxID)
        Me.GroupBoxDataTransaksi.Controls.Add(Me.TextBoxTgl)
        Me.GroupBoxDataTransaksi.Controls.Add(Me.LabelID)
        Me.GroupBoxDataTransaksi.Controls.Add(Me.LabelTglTransaksi)
        Me.GroupBoxDataTransaksi.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxDataTransaksi.Name = "GroupBoxDataTransaksi"
        Me.GroupBoxDataTransaksi.Size = New System.Drawing.Size(200, 124)
        Me.GroupBoxDataTransaksi.TabIndex = 12
        Me.GroupBoxDataTransaksi.TabStop = False
        Me.GroupBoxDataTransaksi.Text = "Data Transaksi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxJumlah)
        Me.GroupBox1.Controls.Add(Me.LabelBayar)
        Me.GroupBox1.Controls.Add(Me.TextBoxBayar)
        Me.GroupBox1.Controls.Add(Me.TextBoxKembali)
        Me.GroupBox1.Controls.Add(Me.labelJumlah)
        Me.GroupBox1.Controls.Add(Me.LabelDiskon)
        Me.GroupBox1.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 211)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembayaran"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnaddbarang)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBoxQTY)
        Me.GroupBox2.Controls.Add(Me.ComboBoxBarang)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 81)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Barang"
        '
        'btnaddbarang
        '
        Me.btnaddbarang.Location = New System.Drawing.Point(109, 49)
        Me.btnaddbarang.Name = "btnaddbarang"
        Me.btnaddbarang.Size = New System.Drawing.Size(75, 23)
        Me.btnaddbarang.TabIndex = 3
        Me.btnaddbarang.Text = "Tambah"
        Me.btnaddbarang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "QTY"
        '
        'TextBoxQTY
        '
        Me.TextBoxQTY.Location = New System.Drawing.Point(9, 49)
        Me.TextBoxQTY.Name = "TextBoxQTY"
        Me.TextBoxQTY.Size = New System.Drawing.Size(33, 20)
        Me.TextBoxQTY.TabIndex = 1
        '
        'ComboBoxBarang
        '
        Me.ComboBoxBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBarang.FormattingEnabled = True
        Me.ComboBoxBarang.Location = New System.Drawing.Point(9, 19)
        Me.ComboBoxBarang.Name = "ComboBoxBarang"
        Me.ComboBoxBarang.Size = New System.Drawing.Size(185, 24)
        Me.ComboBoxBarang.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(21, 241)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(373, 95)
        Me.ListBox1.TabIndex = 15
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Enabled = False
        Me.ButtonSimpan.Location = New System.Drawing.Point(451, 259)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 49)
        Me.ButtonSimpan.TabIndex = 16
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 368)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxDataTransaksi)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBoxDataTransaksi.ResumeLayout(False)
        Me.GroupBoxDataTransaksi.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxJumlah As TextBox
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxTgl As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelTglTransaksi As Label
    Friend WithEvents LabelBayar As Label
    Friend WithEvents TextBoxBayar As TextBox
    Friend WithEvents TextBoxKembali As TextBox
    Friend WithEvents LabelDiskon As Label
    Friend WithEvents labelJumlah As Label
    Friend WithEvents GroupBoxDataTransaksi As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnaddbarang As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxQTY As TextBox
    Friend WithEvents ComboBoxBarang As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ButtonSimpan As Button
End Class
