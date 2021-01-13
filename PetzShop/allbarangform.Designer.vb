<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allbarangform
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Searchbox = New System.Windows.Forms.TextBox()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.byName = New System.Windows.Forms.RadioButton()
        Me.byID = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(26, 81)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(357, 186)
        Me.DataGridView2.TabIndex = 0
        '
        'Searchbox
        '
        Me.Searchbox.Location = New System.Drawing.Point(15, 18)
        Me.Searchbox.Name = "Searchbox"
        Me.Searchbox.Size = New System.Drawing.Size(129, 20)
        Me.Searchbox.TabIndex = 1
        '
        'Update_btn
        '
        Me.Update_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Update_btn.Location = New System.Drawing.Point(26, 273)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(75, 23)
        Me.Update_btn.TabIndex = 2
        Me.Update_btn.Text = "Update"
        Me.Update_btn.UseVisualStyleBackColor = False
        '
        'byName
        '
        Me.byName.AutoSize = True
        Me.byName.Location = New System.Drawing.Point(150, 19)
        Me.byName.Name = "byName"
        Me.byName.Size = New System.Drawing.Size(104, 17)
        Me.byName.TabIndex = 4
        Me.byName.TabStop = True
        Me.byName.Text = "Search by Name"
        Me.byName.UseVisualStyleBackColor = True
        '
        'byID
        '
        Me.byID.AutoSize = True
        Me.byID.Location = New System.Drawing.Point(260, 19)
        Me.byID.Name = "byID"
        Me.byID.Size = New System.Drawing.Size(87, 17)
        Me.byID.TabIndex = 5
        Me.byID.TabStop = True
        Me.byID.Text = "Search by ID"
        Me.byID.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.byName)
        Me.GroupBox1.Controls.Add(Me.byID)
        Me.GroupBox1.Controls.Add(Me.Searchbox)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 46)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Bar"
        '
        'allbarangform
        '
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(405, 308)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Update_btn)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "allbarangform"
        Me.Text = "Inventaris"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Savebtn As Button
    Friend WithEvents Updatebtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Searchbox As TextBox
    Friend WithEvents Update_btn As Button
    Friend WithEvents byName As RadioButton
    Friend WithEvents byID As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
