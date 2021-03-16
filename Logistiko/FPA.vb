Imports MySql.Data.MySqlClient

Public Class FPA

    Dim connection As MySqlConnection
    Dim command As MySqlCommand





    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Main_Menu.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=root;database=logistiko"
        Dim reader As MySqlDataReader




        Try
            connection.Open()
            Dim query As String
            Dim query2 As String

            ' query = "select sum(esoda.katharo_poso) from esoda  where imerominia >= '%" & TextBox1.Text & "%' and imerominia <= '%" & TextBox1.Text & "%'"
            'query2 = "select sum(eksoda.katharo_poso) from eksoda  where imerominia >= '%" & TextBox1.Text & "%' and imerominia <= '%" & TextBox1.Text & "%'"

            query = "select sum(esoda.katharo_poso) from esoda  where imerominia like '%1990%'"
            query2 = "select sum(eksoda.katharo_poso) from eksoda  where imerominia like '%1996%'"

            command = New MySqlCommand(query, connection)


            reader = command.ExecuteReader




            Dim result As String

            
            If reader.Read() Then
                If reader.IsDBNull(0) Then
                    result = ""

                Else
                    result = reader.GetString(0)

                    TextBox4.Text = result


                End If
            End If





        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class