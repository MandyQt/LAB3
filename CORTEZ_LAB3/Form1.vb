Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim connStr As String = "Server=localhost;Port=3306;Database=db_cortez;Uid=root;Pwd=;"
    Dim conn As New MySqlConnection(connStr)



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim enteredUsername As String = TxtUsername.Text.Trim()
        Dim enteredPassword As String = TxtPassword.Text

        If String.IsNullOrEmpty(enteredUsername) OrElse String.IsNullOrEmpty(enteredPassword) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT user_id, password_hash, role_id FROM Users WHERE username = @username"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", enteredUsername)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim storedHash As String = reader("password_hash").ToString()
                            Dim userId As Integer = Convert.ToInt32(reader("user_id"))
                            Dim roleId As Integer = Convert.ToInt32(reader("role_id"))

                            If storedHash = enteredPassword Then
                                reader.Close()
                                RedirectToRoleForm(userId, roleId)
                            Else
                                MessageBox.Show("Invalid username or password.")
                            End If
                        Else
                            MessageBox.Show("Invalid username or password.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub RedirectToRoleForm(userId As Integer, roleId As Integer)
        Select Case roleId
            Case 1 ' Admin
                Dim adminForm As New AdminForm(userId)
                adminForm.Show()
            Case 2 ' Teacher
                Dim teacherForm As New TeacherForm(userId)
                teacherForm.Show()
            Case 3 ' Student
                Dim studentForm As New StudentForm(userId)
                studentForm.Show()
        End Select
        Me.Hide()
    End Sub
    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub
End Class
