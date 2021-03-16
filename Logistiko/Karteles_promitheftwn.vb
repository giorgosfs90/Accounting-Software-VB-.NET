Imports MySql.Data.MySqlClient
Public Class Karteles_promitheftwn
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim command2 As MySqlCommand

    Dim connection2 As MySqlConnection
    Dim reader As MySqlDataReader


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New MySqlConnection
        connection2 = New MySqlConnection

        connection.ConnectionString = "server='" & Admin.TextBox1.Text & "';userid='" & Admin.TextBox4.Text & "';password='" & Admin.TextBox5.Text & "';database='" & Admin.TextBox3.Text & "'"
        connection2.ConnectionString = "server='" & Admin.TextBox1.Text & "';userid='" & Admin.TextBox4.Text & "';password='" & Admin.TextBox5.Text & "';database='" & Admin.TextBox3.Text & "'"

        Dim data As New MySqlDataAdapter
        Dim data_table As New DataTable
        Dim binding_source As New BindingSource


        Try
            connection.Open()
            connection2.Open()

            Dim query As String
            Dim query2 As String


            query = "select imerominia AS 'ΗΜΕΡΟΜΗΝΙΑ', arithmos as 'ΑΡ.ΠΑΡ', perigrafi as 'ΠΕΡΙΓΡΑΦΗ',poso as 'ΠΟΣΟ',katharo_poso as 'ΚΑΘ.ΠΟΣΟ',fpa as 'ΦΠΑ' from logistiko.kiniseis where str_to_date(imerominia ,'%d/%m/%Y') between  str_to_date('" & TextBox2.Text & "','%d/%m/%Y') and str_to_date('" & TextBox3.Text & "','%d/%m/%Y') and onoma_promithefti like '%" & TextBox1.Text & "%'  "
            query2 = "select sum(poso) as asa from kiniseis where str_to_date(imerominia ,'%d/%m/%Y') between  str_to_date('" & TextBox2.Text & "','%d/%m/%Y') and str_to_date('" & TextBox3.Text & "','%d/%m/%Y') and onoma_promithefti like '%" & TextBox1.Text & "%'"

            command = New MySqlCommand(query, connection)
            command2 = New MySqlCommand(query2, connection2)
            data.SelectCommand = command
            data.Fill(data_table)
            binding_source.DataSource = data_table
            DataGridView2.DataSource = binding_source
            data.Update(data_table)

            reader = command2.ExecuteReader

            Dim result As Double

            If reader.Read() Then


                result = reader.GetDouble(0)
                TextBox6.Text = result

            End If



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        Promitheftes_pelates.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        connection = New MySqlConnection
        connection.ConnectionString = "server='" & Admin.TextBox1.Text & "';userid='" & Admin.TextBox4.Text & "';password='" & Admin.TextBox5.Text & "';database='" & Admin.TextBox3.Text & "'"
        Dim data As New MySqlDataAdapter
        Dim data_table As New DataTable
        Dim binding_source As New BindingSource


        Try
            connection.Open()
            Dim query As String
            query = "select id as 'ΚΩΔΙΚΟΣ', epwnumia as ' ΕΠΩΝΥΜΙΑ' from logistiko.promitheftes where epwnumia like '%" & TextBox1.Text & "%' "
            command = New MySqlCommand(query, connection)
            data.SelectCommand = command
            data.Fill(data_table)
            binding_source.DataSource = data_table
            DataGridView1.DataSource = binding_source
            data.Update(data_table)
            connection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("ΕΠΩΝΥΜΙΑ").Value.ToString()


        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Promitheftes_pelates.Show()

    End Sub
End Class