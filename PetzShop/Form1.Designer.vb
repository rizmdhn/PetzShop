<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInventaris = New System.Windows.Forms.Button()
        Me.Transaksi = New System.Windows.Forms.Button()
        Me.btnKasir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnInventaris)
        Me.Panel1.Controls.Add(Me.Transaksi)
        Me.Panel1.Controls.Add(Me.btnKasir)
        Me.Panel1.Location = New System.Drawing.Point(54, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 102)
        Me.Panel1.TabIndex = 3
        '
        'btnInventaris
        '
        Me.btnInventaris.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventaris.Location = New System.Drawing.Point(33, 18)
        Me.btnInventaris.Name = "btnInventaris"
        Me.btnInventaris.Size = New System.Drawing.Size(66, 61)
        Me.btnInventaris.TabIndex = 5
        Me.btnInventaris.Text = "Inventaris"
        Me.btnInventaris.UseVisualStyleBackColor = True
        '
        'Transaksi
        '
        Me.Transaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transaksi.Location = New System.Drawing.Point(237, 18)
        Me.Transaksi.Name = "Transaksi"
        Me.Transaksi.Size = New System.Drawing.Size(66, 61)
        Me.Transaksi.TabIndex = 4
        Me.Transaksi.Text = "Transaksi"
        Me.Transaksi.UseVisualStyleBackColor = True
        '
        'btnKasir
        '
        Me.btnKasir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKasir.Location = New System.Drawing.Point(138, 18)
        Me.btnKasir.Name = "btnKasir"
        Me.btnKasir.Size = New System.Drawing.Size(66, 61)
        Me.btnKasir.TabIndex = 3
        Me.btnKasir.Text = "Kasir"
        Me.btnKasir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 196)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnKasir As Button
    Friend WithEvents btnInventaris As Button
    Friend WithEvents Transaksi As Button
End Class
