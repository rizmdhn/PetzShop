Imports MySql.Data.MySqlClient
Imports System.Text
Public Class Form3
    Dim Command As MySqlCommand
    Dim connector = New MySqlConnection
    Dim SDA As New MySqlDataAdapter
    Dim dbDataset As New DataTable
    Dim bSource As New BindingSource


    Function databind()
        dbDataset.Clear()
        connector.ConnectionString = "host=127.0.0.1; user=root; database=petzshop"
        Try
            connector.Open()
            Dim Query As String
            Query = "select * from tbl_transaksi"
            Command = New MySqlCommand(Query, connector)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)
            connector.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connector.Dispose()
        End Try
    End Function
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        Dim builder As New StringBuilder()
        i = DataGridView1.CurrentRow.Index
        Dim a() As String = DataGridView1.Item(2, i).Value.ToString.Split(".")
        For Each item In a
            ListBox1.Items.Add(item)
            builder.Append(item.ToString).Append(" ")
        Next
        TextBox1.Text = DataGridView1.Item(3, i).Value
        Debug.WriteLine(builder.ToString)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        databind()
        DataGridView1.AllowUserToAddRows = False
    End Sub
End Class