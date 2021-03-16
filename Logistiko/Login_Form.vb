Imports MySql.Data.MySqlClient


Public Class Login_Form

    Dim connection As MySqlConnection


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "giorgos" And TextBox2.Text = "fassas" Then

            connection = New MySqlConnection
            connection.ConnectionString = "server='" & Admin.TextBox1.Text & "';userid='" & Admin.TextBox4.Text & "';password='" & Admin.TextBox5.Text & "';database='" & Admin.TextBox3.Text & "'"
            MessageBox.Show("Σωστά στοιχεία!")
        
            Try
                connection.Open()
                Me.Hide()
                Main_Menu.Show()
                connection.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)

            Finally
                connection.Dispose()

            End Try

        Else
            MessageBox.Show("Λάθος στοιχεία! Προσπαθήστε ξανα!")



        End If




    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Me.Hide()
        Admin.Show()


    End Sub
End Class
