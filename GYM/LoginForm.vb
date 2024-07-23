Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Diagnostics
Imports Microsoft.Data.SqlClient
Imports Windows.Win32.System
Imports System.Configuration


Public Class LoginForm

    Dim connString As String = ConfigurationManager.ConnectionStrings("Connection").ConnectionString

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkshowpass.CheckedChanged

        Dim check As Boolean
        check = checkshowpass.Checked

        Select Case check
            Case True
                TextBoxpassword.UseSystemPasswordChar = False
            Case Else
                TextBoxpassword.UseSystemPasswordChar = True

        End Select

    End Sub

    Private Function CheckUsername(username As String) As Boolean

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

    Private Function CheckIfEmpty() As Boolean

        Dim isEmpty As Boolean = False

        If String.IsNullOrEmpty(TextBoxusername.Text.Trim()) Then

            TextBoxpassword.Focus()
            ErrorProvider2.SetError(TextBoxusername, "Username is required")
            isEmpty = True

        End If

        If String.IsNullOrEmpty(TextBoxpassword.Text.Trim()) Then

            TextBoxpassword.Focus()
            ErrorProvider1.SetError(TextBoxpassword, "Password is required")
            isEmpty = True

        End If


        Return isEmpty

    End Function

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        If CheckIfEmpty() = False Then

            Try
                If CheckUsername(TextBoxusername.Text) Then

                    Dim query As String = "SELECT OwnerID FROM OwnerTable WHERE Username = @Username AND Password = @Password"

                    Using connection As New SqlConnection(connString)
                        Using command As New SqlCommand(query, connection)
                            command.Parameters.AddWithValue("@Username", TextBoxusername.Text)
                            command.Parameters.AddWithValue("@Password", TextBoxpassword.Text)

                            connection.Open()


                            Dim ownerID As Integer = Convert.ToInt32(command.ExecuteScalar())

                            If ownerID > 0 Then
                                MessageBox.Show("Log In Successful!")

                                SessionManager.currentOwnerId = ownerID

                                Dim f3 As DashboardForm = New DashboardForm
                                f3.Show()
                                Me.Hide()

                            Else
                                MessageBox.Show("Invalid Credentials")
                            End If

                            connection.Close()
                        End Using
                    End Using


                Else
                    ErrorProvider2.SetError(TextBoxusername, "Username not registered in the database.")

                End If

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub TextBoxpassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxpassword.TextChanged

        ErrorProvider1.Clear()


    End Sub

    Private Sub TextBoxusername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxusername.TextChanged

        ErrorProvider2.Clear()


    End Sub

    Private Sub linktosignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linktosignup.LinkClicked

        Dim f2 As RegistrationForm = New RegistrationForm()
        f2.Show()
        Me.Hide()

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
