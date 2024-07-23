Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Text.RegularExpressions

Public Class AddMemberForm

    Dim connString As String = ConfigurationManager.ConnectionStrings("Connection").ConnectionString

    Private Function IsValidEmailFormat(email As String) As Boolean

        Dim regex As New Regex("^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
        Return regex.IsMatch(email) AndAlso Not String.IsNullOrEmpty(email)
    End Function

    Private Function IsValidPhoneFormat(phone As String) As Boolean

        Dim regex As New Regex("^[0-9]{11}$")
        Return regex.IsMatch(phone) AndAlso Not String.IsNullOrEmpty(phone)
    End Function

    Private Function CheckIfEmpty() As Boolean

        Dim isEmpty As Boolean = False

        If String.IsNullOrEmpty(emailbox.Text.Trim()) Then

            emailbox.Focus()
            ErrorProvider1.SetError(emailbox, "Email is required")
            isEmpty = True

        End If

        If String.IsNullOrEmpty(phonebox.Text.Trim()) Then

            phonebox.Focus()
            ErrorProvider2.SetError(phonebox, "Phone is required")
            isEmpty = True

        End If

        If String.IsNullOrEmpty(fnamebox.Text.Trim()) Then

            fnamebox.Focus()
            ErrorProvider3.SetError(fnamebox, "First Name is required")
            isEmpty = True

        End If

        If String.IsNullOrEmpty(lnamebox.Text.Trim()) Then

            lnamebox.Focus()
            ErrorProvider4.SetError(lnamebox, "lname is required")
            isEmpty = True

        End If

        If rbtnmale.Checked Or rbtnfemale.Checked Then

        Else
            lblgender.Focus()
            ErrorProvider6.SetError(lblgender, "Gender is required")
            isEmpty = True
        End If


        If feestatusbox.SelectedItem Is Nothing Then
            feestatusbox.Focus()
            ErrorProvider5.SetError(feestatusbox, "Fee Status is required")
            isEmpty = True
        End If

        Return isEmpty

    End Function

    Private Sub emailbox_TextChanged(sender As Object, e As EventArgs) Handles emailbox.TextChanged
        ErrorProvider1.Clear()

        Dim email As String = emailbox.Text

        If IsValidEmailFormat(email) Then


        Else
            ErrorProvider1.SetError(emailbox, "Invalid Email Format")

        End If
    End Sub

    Private Sub phonebox_TextChanged(sender As Object, e As EventArgs) Handles phonebox.TextChanged
        ErrorProvider2.Clear()

        Dim phone As String = phonebox.Text

        If IsValidEmailFormat(phone) Then


        Else
            ErrorProvider2.SetError(phonebox, "Invalid Phone Format")

        End If
    End Sub

    Private Sub fnamebox_TextChanged(sender As Object, e As EventArgs) Handles fnamebox.TextChanged
        ErrorProvider3.Clear()
    End Sub

    Private Sub lnamebox_TextChanged(sender As Object, e As EventArgs) Handles lnamebox.TextChanged
        ErrorProvider4.Clear()
    End Sub

    Private Sub feestatusbox_SelectedIndexCHanged(sender As Object, e As EventArgs) Handles feestatusbox.SelectedIndexChanged
        ErrorProvider5.Clear()
    End Sub

    Private Sub rbtnmale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnmale.CheckedChanged
        ErrorProvider6.Clear()
    End Sub

    Private Sub rbtnfemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnfemale.CheckedChanged
        ErrorProvider6.Clear()
    End Sub



    Private Sub btnaddmember_Click(sender As Object, e As EventArgs) Handles btnaddmember.Click


        If CheckIfEmpty() = False Then



            Dim firstname As String = fnamebox.Text
            Dim lastname As String = lnamebox.Text
            Dim email As String = emailbox.Text
            Dim phone As String = phonebox.Text


            Dim gender As String = ""
            Dim FeeStatus As String


            If (rbtnmale.Checked = True) Then
                gender = "Male"
            ElseIf (rbtnfemale.Checked = True) Then
                gender = "Female"
            End If

            FeeStatus = feestatusbox.SelectedItem.ToString()

            Try

                Dim query As String = "INSERT INTO MemberTable (FirstName, LastName, Email, Phone, gender, FeeStatus, OwnerId) VALUES (@FirstName, @LastName, @Email, @Phone, @gender, @FeeStatus, @OwnerId)"

                Using connection As New SqlConnection(connString)
                    Using command As New SqlCommand(query, connection)

                        command.Parameters.AddWithValue("@OwnerId", SessionManager.currentOwnerId)
                        command.Parameters.AddWithValue("@FirstName", firstname)
                        command.Parameters.AddWithValue("@LastName", lastname)
                        command.Parameters.AddWithValue("@Email", email)
                        command.Parameters.AddWithValue("@Phone", phone.ToString())
                        command.Parameters.AddWithValue("@gender", gender)
                        command.Parameters.AddWithValue("@FeeStatus", FeeStatus)

                        connection.Open()
                        command.ExecuteNonQuery()

                    End Using
                End Using

                MessageBox.Show("New Member Added Successful!")

                Dim f3 As DashboardForm = New DashboardForm()
                f3.Show()
                Me.Hide()
            Catch ex As Exception
                Throw New Exception("Error inserting new member into database: " & ex.Message)
            End Try


        End If

    End Sub

    Private Sub btnback_Click_1(sender As Object, e As EventArgs) Handles btnback.Click
        Dim back As New DashboardForm
        back.Show()
        Me.Hide()
    End Sub

End Class