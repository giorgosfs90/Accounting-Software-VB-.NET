Imports MySql.Data.MySqlClient
Public Class Epeksergasia_sinalasomenou
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim command2 As MySqlCommand


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer

        If RadioButton1.Checked Then
            With DataGridView1


                If e.RowIndex >= 0 Then

                    i = .CurrentRow.Index

                    TextBox1.Text = .Rows(i).Cells("epwnumia").Value.ToString
                    TextBox2.Text = .Rows(i).Cells("drastiriotita").Value.ToString
                    TextBox3.Text = .Rows(i).Cells("dieuthinsi").Value.ToString
                    TextBox4.Text = .Rows(i).Cells("email").Value.ToString
                    TextBox5.Text = .Rows(i).Cells("tilefwno").Value.ToString
                    TextBox6.Text = .Rows(i).Cells("doy").Value.ToString
                    TextBox7.Text = .Rows(i).Cells("afm").Value.ToString
                    TextBox8.Text = .Rows(i).Cells("id").Value.ToString



                End If
            End With

        ElseIf RadioButton2.Checked Then

            With DataGridView1


                If e.RowIndex >= 0 Then

                    i = .CurrentRow.Index

                    TextBox1.Text = .Rows(i).Cells("epwnumia").Value.ToString
                    TextBox2.Text = .Rows(i).Cells("drastiriotita").Value.ToString
                    TextBox3.Text = .Rows(i).Cells("dieuthinsi").Value.ToString
                    TextBox4.Text = .Rows(i).Cells("email").Value.ToString
                    TextBox5.Text = .Rows(i).Cells("tilefwno").Value.ToString
                    TextBox6.Text = .Rows(i).Cells("doy").Value.ToString
                    TextBox7.Text = .Rows(i).Cells("afm").Value.ToString
                    TextBox7.Text = .Rows(i).Cells("id").Value.ToString



                End If
            End With

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        connection = New MySqlConnection
        connection.ConnectionString = "server='" & Admin.TextBox1.Text & "';userid='" & Admin.TextBox4.Text & "';password='" & Admin.TextBox5.Text & "';database='" & Admin.TextBox3.Text & "'"
        Dim data As New MySqlDataAdapter
        Dim data_table As New DataTable
        Dim binding_source As New BindingSource

        If RadioButton1.Checked Then

            Try
                connection.Open()
                Dim query As String
                query = "select id, epwnumia,drastiriotita,dieuthinsi,email,tilefwno,doy,afm from logistiko.pelates where epwnumia like '%" & TextBox1.Text & "%'  "
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
                query2 = "select id, epwnumia,drastiriotita,dieuthinsi,email,tilefwno,doy,afm from logistiko.promitheftes where epwnumia like '%" & TextBox1.Text & "%'  "

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Promitheftes_pelates.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

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
                query = "update pelates set epwnumia='" & TextBox1.Text & "',drastiriotita= '" & TextBox2.Text & "',dieuthinsi='" & TextBox3.Text & "',email='" & TextBox4.Text & "',tilefwno='" & TextBox5.Text & "',doy='" & TextBox6.Text & "',afm='" & TextBox7.Text & "' where id='" & TextBox8.Text & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("Ο πελάτης καταχωρήθηκε με επιτυχία!")

            ElseIf RadioButton2.Checked Then
                query2 = "update promitheftes set epwnumia='" & TextBox1.Text & "',drastiriotita= '" & TextBox2.Text & "',dieuthinsi='" & TextBox3.Text & "',email='" & TextBox4.Text & "',tilefwno='" & TextBox5.Text & "',doy='" & TextBox6.Text & "',afm='" & TextBox7.Text & "' where id='" & TextBox8.Text & "'"

                command = New MySqlCommand(query2, connection)
                reader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("Ο προμηθευτής καταχωρήθηκε με επιτυχία!")



            End If


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)


        End Try

    End Sub

    Private Sub Epeksergasia_sinalasomenou_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class