Imports MySql.Data.MySqlClient

Public Class Eisagwgi_sinalasomenou

    Dim connection As MySqlConnection
    Dim command As MySqlCommand


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Promitheftes_pelates.Show()

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
                query = "insert into logistiko.pelates(epwnumia,drastiriotita,dieuthinsi,email,tilefwno,doy,afm) values ( '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "','" & TextBox7.Text & "')"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("Ο πελάτης καταχωρήθηκε με επιτυχία!")

            ElseIf RadioButton2.Checked Then
                query2 = "insert into logistiko.promitheftes(epwnumia,drastiriotita,dieuthinsi,email,tilefwno,doy,afm) values ( '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "','" & TextBox7.Text & "')"
                command = New MySqlCommand(query2, connection)
                reader = command.ExecuteReader
                connection.Close()
                MessageBox.Show("Ο προμηθευτής καταχωρήθηκε με επιτυχία!")

            Else
                MessageBox.Show("Παρακαλώ ειλέξτε τον τύπο του συναλλασόμενου (Πελάτης/Προμηθευτής)")

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


        End Try

    End Sub

    Private Sub Eisagwgi_sinalasomenou_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub


    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)
        
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class