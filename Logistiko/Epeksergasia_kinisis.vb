Imports MySql.Data.MySqlClient

Public Class Epeksergasia_kinisis

    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim command2 As MySqlCommand


    Private Sub updater()
        connection = New MySqlConnection
        connection.ConnectionString = "server='" & Admin.TextBox1.Text & "';userid='" & Admin.TextBox4.Text & "';password='" & Admin.TextBox5.Text & "';database='" & Admin.TextBox3.Text & "'"

        Dim data As New MySqlDataAdapter
        Dim data_table As New DataTable
        Dim binding_source As New BindingSource

        If RadioButton1.Checked Then

            Try
                connection.Open()
                Dim query As String
                query = "select id_kinisis as 'Α/Α',onoma_pelati as 'ΟΝΟΜΑ', imerominia AS 'ΗΜΕΡΟΜΗΝΙΑ', arithmos as 'ΑΡ.ΠΑΡ', perigrafi as 'ΠΕΡΙΓΡΑΦΗ',poso as 'ΠΟΣΟ' ,katharo_poso as 'ΚΑΘ.ΠΟΣΟ',fpa as 'ΦΠΑ' from logistiko.kiniseis where imerominia like '%" & TextBox1.Text & "%' and onoma_promithefti is null "
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

        End If

        If RadioButton2.Checked Then

            Try
                connection.Open()
                Dim query2 As String
                query2 = "select id_kinisis as 'Α/Α',onoma_promithefti as 'ΟΝΟΜΑ', imerominia AS 'ΗΜΕΡΟΜΗΝΙΑ', arithmos as 'ΑΡ.ΠΑΡ', perigrafi as 'ΠΕΡΙΓΡΑΦΗ',poso as 'ΠΟΣΟ' ,katharo_poso as 'ΚΑΘ.ΠΟΣΟ',fpa as 'ΦΠΑ' from logistiko.kiniseis where imerominia like '%" & TextBox1.Text & "%' and onoma_pelati is null "

                command = New MySqlCommand(query2, connection)
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

        End If

    End Sub

    Private Sub Epeksergasia_kinisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        updater()

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If RadioButton1.Checked Then

            If e.RowIndex >= 0 Then

                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)
                TextBox2.Text = row.Cells("Α/Α").Value.ToString
                TextBox6.Text = row.Cells("ΟΝΟΜΑ").Value.ToString
                TextBox3.Text = row.Cells("ΗΜΕΡΟΜΗΝΙΑ").Value.ToString
                TextBox4.Text = row.Cells("ΑΡ.ΠΑΡ").Value.ToString
                TextBox5.Text = row.Cells("ΠΕΡΙΓΡΑΦΗ").Value.ToString
                TextBox9.Text = row.Cells("ΠΟΣΟ").Value.ToString
                TextBox7.Text = row.Cells("ΚΑΘ.ΠΟΣΟ").Value.ToString
                TextBox8.Text = row.Cells("ΦΠΑ").Value.ToString

            End If

        ElseIf RadioButton2.Checked Then

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)
                TextBox2.Text = row.Cells("Α/Α").Value.ToString
                TextBox6.Text = row.Cells("ΟΝΟΜΑ").Value.ToString
                TextBox3.Text = row.Cells("ΗΜΕΡΟΜΗΝΙΑ").Value.ToString
                TextBox4.Text = row.Cells("ΑΡ.ΠΑΡ").Value.ToString
                TextBox5.Text = row.Cells("ΠΕΡΙΓΡΑΦΗ").Value.ToString
                TextBox9.Text = row.Cells("ΠΟΣΟ").Value.ToString
                TextBox7.Text = row.Cells("ΚΑΘ.ΠΟΣΟ").Value.ToString
                TextBox8.Text = row.Cells("ΦΠΑ").Value.ToString

            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
        Main_Menu.Show()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        connection = New MySqlConnection
        connection.ConnectionString = "server='" & Admin.TextBox1.Text & "';userid='" & Admin.TextBox4.Text & "';password='" & Admin.TextBox5.Text & "';database='" & Admin.TextBox3.Text & "'"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim query As String
            query = "UPDATE kiniseis set imerominia='" & TextBox3.Text & "', arithmos='" & TextBox4.Text & "', perigrafi='" & TextBox5.Text & "',poso='" & TextBox9.Text & "', katharo_poso='" & TextBox7.Text & "', fpa='" & TextBox8.Text & "' where id_kinisis='" & TextBox2.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            connection.Close()
            MessageBox.Show("Η ενημέρωση πραγματοποιήθηκε με επιτυχία!")
            connection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try

        

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        connection = New MySqlConnection
        connection.ConnectionString = "server='" & Admin.TextBox1.Text & "';userid='" & Admin.TextBox4.Text & "';password='" & Admin.TextBox5.Text & "';database='" & Admin.TextBox3.Text & "'"
        Dim reader As MySqlDataReader


        Try
            connection.Open()
            Dim query As String

            query = "DELETE from kiniseis  where id_kinisis='" & TextBox2.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            connection.Close()
            MessageBox.Show("Η διαγραφή πραγματοποιήθηκε με επιτυχία!")

            connection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()

        End Try




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
       
        updater()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class