Imports MySql.Data.MySqlClient
Imports System.Text
Public Class Form2
    Dim Command As MySqlCommand
    Dim connector = New MySqlConnection
    Dim SDA As New MySqlDataAdapter
    Dim dbDataset As New DataTable
    Dim bSource As New BindingSource
    Dim id As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connector.ConnectionString = "host=127.0.0.1; user=root; database=petzshop"
        Dim Query As String
        Dim Query1 As String
        Query = "select transaksi_id from tbl_transaksi ORDER BY transaksi_id DESC LIMIT 1"
        Dim Command = New MySqlCommand(Query, connector)
            connector.Open()
                Dim Reader As MySqlDataReader
                Reader = Command.ExecuteReader()
        Try
            While Reader.Read()
                id = Reader.GetString(0)
                TextBoxID.Text = (id + 1).ToString
                TextBoxTgl.Text = Date.Today
                SDA.Dispose()
                Command.Dispose()

            End While
            connector.close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Query1 = "select nama_barang, Harga from inventaris_barang"
        connector.open()
        Command = New MySqlCommand(Query1, connector)
        SDA.SelectCommand = Command
            SDA.Fill(dbDataset)
            Command.Dispose()
        ComboBoxBarang.DataSource = dbDataset
        ComboBoxBarang.ValueMember = "Harga"
        ComboBoxBarang.DisplayMember = "nama_barang"
        ComboBoxBarang.AutoCompleteMode = AutoCompleteMode.Append
        ComboBoxBarang.DropDownStyle = ComboBoxStyle.DropDown
        ComboBoxBarang.AutoCompleteSource = AutoCompleteSource.ListItems
        SDA.Update(dbDataset)
        connector.Close()
        connector.Dispose()

    End Sub

    Private Sub btnaddbarang_Click(sender As Object, e As EventArgs) Handles btnaddbarang.Click
        If IsNumeric(TextBoxQTY.Text) Then
            'do nothing 
            Dim item As String
            Dim Jumlah As String
            TextBoxJumlah.Text = "Rp. " + Calculate(ComboBoxBarang.SelectedValue, TextBoxQTY.Text).ToString
            item = ComboBoxBarang.Text + ",  " + ComboBoxBarang.SelectedValue.ToString + " "
            tambahitem(ListBox1, item, TextBoxQTY.Text)
            TextBoxBayar.Enabled = True
        Else
            'display error message
            MessageBox.Show("Numbers Only", "Error")
            'clear textbox 
            TextBoxQTY.Text = "0"
        End If

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBayar.TextChanged
        Dim txtBox As TextBox = DirectCast(sender, TextBox)
        If String.IsNullOrEmpty(txtBox.Text) Then
            txtBox.Text = CStr(0)
        Else
            TextBoxKembali.Text = (Integer.Parse(TextBoxBayar.Text) - Total).ToString
            ButtonSimpan.Enabled = True
        End If



    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Dim builder As New StringBuilder()
        For Each item In ListBox1.Items
            'Do stuff
            builder.Append(item.ToString).Append(". ")
        Next
        Dim jumlah As String = Total
        Dim query As String = String.Empty
        query &= "insert into tbl_transaksi (barang, jumlah) "
        query &= "values (@colbarang, @coljumlah)"

        Using conn As New MySqlConnection("host=127.0.0.1; user=root; database=petzshop")
            Using comm As New MySqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@colbarang", builder.ToString)
                    .Parameters.AddWithValue("@coljumlah", jumlah)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Me.Controls.Clear() 'removes all the controls on the form
                    InitializeComponent() 'load all the controls again
                    Form2_Load(e, e)
                    MessageBox.Show("data berhasil disimpan!", "message")
                    Me.Refresh()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "error message")
                End Try
            End Using
        End Using
        MessageBox.Show(builder.ToString)
    End Sub

    Public Function indexing(ByRef list As ListBox, ByVal item As String, ByRef quantity As Integer) As Integer
        Dim num As Integer = 0
        For i As Integer = 0 To list.Items.Count - 1
            Dim isi() As String = list.Items(i).ToString.Split("X")
            Debug.Print(isi(0) + ", " + isi(1) + ", " + item)
            If (isi(0).Equals(item)) Then
                quantity = Integer.Parse(isi(1).Trim)
                num = i
                Return num
            Else
            End If
        Next
        Return -1
    End Function

    Public Function tambahitem(ByRef list As ListBox, item As String, jumlah As Integer)
        Dim quantity As Integer
        Dim index As Integer = indexing(list, item, quantity)
        Debug.Print(index)
        If (index > -1) Then
            jumlah = quantity + jumlah
            list.Items(index) = ComboBoxBarang.Text + ",  " + ComboBoxBarang.SelectedValue.ToString + " X " + jumlah.ToString
        Else
            list.Items.Add(ComboBoxBarang.Text + ",  " + ComboBoxBarang.SelectedValue.ToString + " X " + jumlah.ToString)
        End If
    End Function

End Class