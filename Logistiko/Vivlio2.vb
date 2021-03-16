Imports MySql.Data.MySqlClient

Public Class Vivlio2
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim command2 As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Vivlio.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Vivlio2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New MySqlConnection
        connection.ConnectionString ="server='" & Admin.TextBox1.Text & "';userid='" & Admin.TextBox4.Text & "';password='" & Admin.TextBox5.Text & "';database='" & Admin.TextBox3.Text & "'"
        Dim data As New MySqlDataAdapter
        Dim data_table As New DataTable
        Dim binding_source As New BindingSource

        Dim data2 As New MySqlDataAdapter
        Dim data_table2 As New DataTable
        Dim binding_source2 As New BindingSource

        Try
            connection.Open()
            Dim query As String
            Dim query2 As String

            query = "select imerominia AS 'ΗΜΕΡΟΜΗΝΙΑ', arithmos as 'ΑΡ.ΠΑΡ',onoma_pelati as 'ΠΕΛΑΤΗΣ', perigrafi as 'ΠΕΡΙΓΡΑΦΗ',poso as 'ΠΟΣΟ',katharo_poso as 'ΚΑΘ.ΠΟΣΟ',fpa as 'ΦΠΑ' from logistiko.kiniseis where str_to_date(imerominia ,'%d/%m/%Y') between  str_to_date('" & Vivlio.TextBox1.Text & "','%d/%m/%Y') and str_to_date('" & Vivlio.TextBox2.Text & "','%d/%m/%Y') and katharo_poso != '0' and id_pelati is not null"
            query2 = "select imerominia AS 'ΗΜΕΡΟΜΗΝΙΑ', arithmos as 'ΑΡ.ΠΑΡ', onoma_promithefti as 'ΠΡΟΜΗΘΕΥΤΗΣ', perigrafi as 'ΠΕΡΙΓΡΑΦΗ',poso as 'ΠΟΣΟ',katharo_poso as 'ΚΑΘ.ΠΟΣΟ',fpa as 'ΦΠΑ' from logistiko.kiniseis where str_to_date(imerominia ,'%d/%m/%Y') between  str_to_date('" & Vivlio.TextBox1.Text & "','%d/%m/%Y') and str_to_date('" & Vivlio.TextBox2.Text & "','%d/%m/%Y') and katharo_poso != '0' and id_promithefti is not null"

            Command = New MySqlCommand(query, connection)
            data.SelectCommand = command
            data.Fill(data_table)
            binding_source.DataSource = data_table
            DataGridView1.DataSource = binding_source
            data.Update(data_table)

            command2 = New MySqlCommand(query2, connection)
            data2.SelectCommand = command2
            data2.Fill(data_table2)
            binding_source2.DataSource = data_table2
            DataGridView2.DataSource = binding_source2
            data2.Update(data_table2)
            connection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class