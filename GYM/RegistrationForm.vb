Imports System.Text.RegularExpressions
Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class RegistrationForm

    Dim connString As String = ConfigurationManager.ConnectionStrings("Connection").ConnectionString

    Dim f1 As LoginForm = New LoginForm()

    Private Function IsValidEmailFormat(email As String) As Boolean

        Dim regex As New Regex("^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
        Return regex.IsMatch(email) AndAlso Not String.IsNullOrEmpty(email)
    End Function

    Private Function IsValidPasswordFormat(Pass As String) As Boolean

        Dim regex As New Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*\W)(?!.* ).{8,16}$")
        Return regex.IsMatch(Pass) AndAlso Not String.IsNullOrEmpty(Pass)
    End Function

    Private Function IsMatchedPassword(name As String) As Boolean

        Dim pass As String = TextBoxpass.Text
        Dim cpass As String = TextBoxcpass.Text

        If (cpass = pass) Then
            'MessageBox.Show(True)
            Return True
        End If
        'MessageBox.Show(False)
        Return False
    End Function

    Private Function CheckIfUsernameExists(username As String) As Boolean

        Dim query As String = "SELECT COUNT(*) FROM OwnerTable WHERE Username = @Username"

        Using connection As New SqlConnection(connString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                connection.Open()

                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                Return count > 0
            End Using
        End Using
    End Function

    Private Function CheckIfEmailExists(email As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM OwnerTable WHERE Email = @Email"

        Using connection As New SqlConnection(connString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", email)
                connection.Open()

                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                Return count > 0
            End Using
        End Using
    End Function

    Private Sub linktologin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linktologin.LinkClicked
        f1.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxpass_TextChanged(sender As Object, e As EventArgs) Handles TextBoxpass.TextChanged

        ErrorProvider1.Clear()

        Dim pass As String = TextBoxpass.Text

        If IsValidPasswordFormat(pass) Then


        Else
            ErrorProvider1.SetError(TextBoxpass, "Password must be 8 characters long containing atleast one uppercase, lowercase, special character and number")

        End If
    End Sub

    Private Sub TextBoxcpass_TextChanged(sender As Object, e As EventArgs) Handles TextBoxcpass.TextChanged
        Dim cpass As String = TextBoxcpass.Text

        'ErrorProvider2.Clear()
        If IsMatchedPassword(cpass) Then

            ErrorProvider2.Clear()

        Else
            ErrorProvider2.SetError(TextBoxcpass, "Confirm Password must be equal to Password")

        End If


    End Sub

    Private Sub Textboxfirstname_TextChanged(sender As Object, e As EventArgs) Handles TextBoxfirstname.TextChanged
        ErrorProvider5.Clear()
    End Sub
    Private Sub Textboxlastname_TextChanged(sender As Object, e As EventArgs) Handles TextBoxlastname.TextChanged
        ErrorProvider6.Clear()
    End Sub

    Private Sub TexBoxusernameSignup_TextChanged(sender As Object, e As EventArgs) Handles TexBoxusernameSignup.TextChanged
        ErrorProvider3.Clear()

    End Sub

    Private Sub TextBoxemail_TextChanged(sender As Object, e As EventArgs) Handles TextBoxemail.TextChanged
        ErrorProvider4.Clear()

        Dim email As String = TextBoxemail.Text

        If IsValidEmailFormat(email) Then


        Else
            ErrorProvider4.SetError(TextBoxemail, "Invalid Email Format")

        End If
    End Sub
    Private Sub TextBoxgymname_TextChanged(sender As Object, e As EventArgs) Handles TextBoxgymname.TextChanged
        ErrorProvider7.Clear()
    End Sub



    Private Function CheckIfEmpty() As Boolean

        Dim isEmpty As Boolean = False

        If String.IsNullOrEmpty(TextBoxfirstname.Text.Trim()) Then

            TextBoxfirstname.Focus()
            ErrorProvider5.SetError(TextBoxfirstname, "Please fill the First Name!")
            isEmpty = True

        End If

        If String.IsNullOrEmpty(TextBoxlastname.Text.Trim()) Then

            TextBoxlastname.Focus()
            ErrorProvider6.SetError(TextBoxlastname, "Please fill the Last Name!")
            isEmpty = True

        End If

        If String.IsNullOrEmpty(TexBoxusernameSignup.Text.Trim()) Then

            TexBoxusernameSignup.Focus()
            ErrorProvider3.SetError(TexBoxusernameSignup, "Please fill the Username!")
            isEmpty = True

        End If

        If String.IsNullOrEmpty(TextBoxemail.Text.Trim()) Then

            TextBoxemail.Focus()
            ErrorProvider4.SetError(TextBoxemail, "Please fill the Email!")
            isEmpty = True

        End If

        If String.IsNullOrEmpty(TextBoxpass.Text.Trim()) Then

            TextBoxpass.Focus()
            ErrorProvider1.SetError(TextBoxpass, "Password is required")
            isEmpty = True
        End If

        If String.IsNullOrEmpty(TextBoxcpass.Text.Trim()) Then

            TextBoxcpass.Focus()
            ErrorProvider2.SetError(TextBoxcpass, "Confirm Password is required")
            isEmpty = True

        End If

        If String.IsNullOrEmpty(TextBoxgymname.Text.Trim()) Then

            TextBoxgymname.Focus()
            ErrorProvider7.SetError(TextBoxgymname, "GYM Name is required")
            isEmpty = True

        End If

        Return isEmpty

    End Function


    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click

        If CheckIfEmpty() = False Then

            Try

                Dim query As String = "INSERT INTO OwnerTable (FirstName, LastName, Username, Email, Password, ConfirmPassword, GymName) VALUES (@FirstName, @LastName, @Username, @Email, @Password, @ConfirmPassword, @GymName)"

                If Not CheckIfUsernameExists(TexBoxusernameSignup.Text) Then

                    If Not CheckIfEmailExists(TextBoxemail.Text) Then


                        Using connection As New SqlConnection(connString)
                            Using command As New SqlCommand(query, connection)

                                command.Parameters.AddWithValue("@FirstName", TextBoxfirstname.Text)
                                command.Parameters.AddWithValue("@LastName", TextBoxlastname.Text)
                                command.Parameters.AddWithValue("@Username", TexBoxusernameSignup.Text)
                                command.Parameters.AddWithValue("@Email", TextBoxemail.Text)
                                command.Parameters.AddWithValue("@Password", TextBoxpass.Text)
                                command.Parameters.AddWithValue("@ConfirmPassword", TextBoxcpass.Text)
                                command.Parameters.AddWithValue("@GymName", TextBoxgymname.Text)


                                connection.Open()
                                command.ExecuteNonQuery()

                            End Using
                        End Using

                        MessageBox.Show("Registration Successful!")
                        f1.Show()
                        Me.Hide()

                    Else
                        ErrorProvider3.SetError(TextBoxemail, "Email already registered in the database.")

                    End If


                Else
                    ErrorProvider3.SetError(TexBoxusernameSignup, "Username already registered in the database.")

                End If


            Catch ex As Exception
                Throw New Exception("Error inserting data into database: " & ex.Message)
            End Try


        End If

    End Sub
End Class