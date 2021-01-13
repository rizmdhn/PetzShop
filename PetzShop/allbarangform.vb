Imports MySql.Data.MySqlClient
Public Class allbarangform
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
            Query = "select * from inventaris_barang"
            Command = New MySqlCommand(Query, connector)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView2.DataSource = bSource
            SDA.Update(dbDataset)
            connector.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connector.Dispose()
        End Try
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        connector.ConnectionString = "host=127.0.0.1; user=root; database=petzshop"
        Dim cb As New MySqlCommandBuilder(SDA)
        Using connector
            connector.Open()
            SDA.Update(dbDataset)
        End Using
        databind()

    End Sub


    Private Sub allbarangform_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        databind()
    End Sub

    Private Sub Searchbox_TextChanged(sender As Object, e As EventArgs) Handles Searchbox.TextChanged
        DataGridView2.DataSource = bSource
        If byName.Checked = True Then
            dbDataset.DefaultView.RowFilter = "nama_barang Like '%" & Searchbox.Text & "%'"
        ElseIf byID.Checked = True Then
            dbDataset.DefaultView.RowFilter = "Convert(id, System.String) LIKE '%" & Searchbox.Text & "%'"
        End If
    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        connector.ConnectionString = "host=127.0.0.1; user=root; database=petzshop"
        Dim cb As New MySqlCommandBuilder(SDA)
        Using connector
            connector.Open()
            SDA.Update(dbDataset)
        End Using
        databind()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick


    End Sub
End Class