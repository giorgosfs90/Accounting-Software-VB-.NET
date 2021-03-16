Imports MySql.Data.MySqlClient

Public Class Kataxwrisi_kinisis

    Dim connection As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Kataxwrisi_esodou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Main_Menu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        connection = New MySqlConnection
        connection.ConnectionString = "server='" & Admin.TextBox1.Text & "';userid='" & Admin.TextBox4.Text & "';password='" & Admin.TextBox5.Text & "';database='" & Admin.TextBox3.Text & "'"
        Dim reader As MySqlDataReader

        Try
            connection.Open()
            Dim query As String
            Dim query2 As String

            If RadioButton1.Checked Then
                query = "insert into logistiko.kiniseis(id_pelati,onoma_pelati,imerominia, arithmos, perigrafi, poso , katharo_poso, fpa) values ( '" & TextBox4.Text & "','" & TextBox3.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "','" & TextBox7.Text & "', '" & TextBox8.Text & "')"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("Η καταχώρηση πραγματοποιήθηκε με επιτυχία!")

            ElseIf RadioButton2.Checked Then
                query2 = "insert into logistiko.kiniseis(id_promithefti,onoma_promithefti,imerominia, arithmos, perigrafi, poso , katharo_poso, fpa) values ( '" & TextBox4.Text & "','" & TextBox3.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "','" & TextBox7.Text & "', '" & TextBox8.Text & "')"
                command = New MySqlCommand(query2, connection)
                reader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("Η καταχώρηση πραγματοποιήθηκε με επιτυχία!")

            ElseIf RadioButton3.Checked Then
                query2 = "insert into logistiko.kiniseis(id_pelati,onoma_pelati,imerominia, arithmos, perigrafi, poso, katharo_poso,fpa) values ( '" & TextBox4.Text & "','" & TextBox3.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox5.Text & "', '-" & TextBox6.Text & "','0','0')"
                command = New MySqlCommand(query2, connection)
                reader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("Η καταχώρηση πραγματοποιήθηκε με επιτυχία!")

            ElseIf RadioButton4.Checked Then
                query2 = "insert into logistiko.kiniseis(id_promithefti,onoma_promithefti,imerominia, arithmos, perigrafi, poso,katharo_poso,fpa ) values ( '" & TextBox4.Text & "','" & TextBox3.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox5.Text & "', '-" & TextBox6.Text & "','0','0')"
                command = New MySqlCommand(query2, connection)
                reader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("Η καταχώρηση πραγματοποιήθηκε με επιτυχία!")
            Else

                MessageBox.Show("Παρακαλώ ειλέξτε τον τύπο της κίνησης")

            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            connection.Dispose()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False




        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        connection = New MySqlConnection
        connection.ConnectionString ="server='" & Admin.TextBox1.Text & "';userid='" & Admin.TextBox4.Text & "';password='" & Admin.TextBox5.Text & "';database='" & Admin.TextBox3.Text & "'"
        Dim data As New MySqlDataAdapter
        Dim data_table As New DataTable
        Dim binding_source As New BindingSource

        If RadioButton1.Checked Then

            Try
                connection.Open()
                Dim query As String
                query = "select id as 'ΚΩΔΙΚΟΣ', epwnumia as ' ΕΠΩΝΥΜΙΑ' from logistiko.pelates where epwnumia like '%" & TextBox3.Text & "%' "
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
                query2 = "select id as 'ΚΩΔΙΚΟΣ',  epwnumia as ' ΕΠΩΝΥΜΙΑ' from logistiko.promitheftes where epwnumia like '%" & TextBox3.Text & "%' "
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


        If RadioButton3.Checked Then

            Try
                connection.Open()
                Dim query2 As String
                query2 = "select id as 'ΚΩΔΙΚΟΣ',  epwnumia as ' ΕΠΩΝΥΜΙΑ' from logistiko.pelates where epwnumia like '%" & TextBox3.Text & "%' "
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

        If RadioButton4.Checked Then

            Try
                connection.Open()
                Dim query2 As String
                query2 = "select id as 'ΚΩΔΙΚΟΣ',  epwnumia as ' ΕΠΩΝΥΜΙΑ' from logistiko.promitheftes where epwnumia like '%" & TextBox3.Text & "%' "
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

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            TextBox4.Text = row.Cells("ΚΩΔΙΚΟΣ").Value.ToString()
            TextBox3.Text = row.Cells("ΕΠΩΝΥΜΙΑ").Value.ToString()



        End If


    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox7.Enabled = False
            TextBox8.Enabled = False


        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            TextBox7.Enabled = False
            TextBox8.Enabled = False


        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class