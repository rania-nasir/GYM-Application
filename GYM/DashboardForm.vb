Imports System.Configuration
Imports Microsoft.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class DashboardForm
    Private Sub addmemberbox_Click(sender As Object, e As EventArgs) Handles addmemberbox.Click

        Dim f4 As AddMemberForm = New AddMemberForm()
        f4.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim OwnerID As Integer = SessionManager.currentOwnerId

        'Dim username As String
        'Dim email As String
        Dim firstname As String = "User"
        'Dim Lasttname As String
        Dim gymname As String = ""

        Dim connString As String = ConfigurationManager.ConnectionStrings("Connection").ConnectionString

        Using connection As New SqlConnection(connString)

            Dim query As String = "SELECT * FROM OwnerTable WHERE OwnerId = @OwnerId"



            Using command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@OwnerId", OwnerID)

                connection.Open()

                Dim data As SqlDataReader = command.ExecuteReader()

                If data.Read() Then

                    'username = data("Username").ToString()
                    'email = data("Email").ToString()
                    firstname = data("FirstName").ToString()
                    'Lasttname = data("LastName").ToString()
                    gymname = data("GymName").ToString()

                End If
                data.Close()

            End Using

        End Using


        labeldashboard.Text = $"Welcome, {firstname}"

    End Sub

    Private Sub showmemberbox_Click(sender As Object, e As EventArgs) Handles showmemberbox.Click
        Dim f5 As MembersRecordForm = New MembersRecordForm
        f5.Show()
        Me.Hide()
    End Sub

    Private Sub deletememberbox_Click(sender As Object, e As EventArgs) Handles deletememberbox.Click
        Dim f6 As DeleteRecordForm = New DeleteRecordForm()
        f6.Show()
        Me.Hide()
    End Sub

    Private Sub feeoverduebox_Click(sender As Object, e As EventArgs) Handles feeoverduebox.Click
        Dim f7 As FeeoverdueForm = New FeeoverdueForm()
        f7.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SessionManager.currentOwnerId = Nothing
        Dim loggedout As LoginForm = New LoginForm
        loggedout.Show()
        Me.Hide()
    End Sub
End Class