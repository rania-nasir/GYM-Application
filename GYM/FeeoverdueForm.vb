Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class FeeoverdueForm
    Dim connString As String = ConfigurationManager.ConnectionStrings("Connection").ConnectionString

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UnpaidData.EnableHeadersVisualStyles = False
        UnpaidData.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue
        UnpaidData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        Dim query As String = "SELECT MemberId, FirstName, LastName, Email, Phone, gender, FeeStatus from MemberTable WHERE OwnerId = @OwnerId AND FeeStatus = 'Unpaid'"

        Using connection As New SqlConnection(connString)
            Using command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@OwnerId", SessionManager.currentOwnerId)
                connection.Open()

                Dim datatable As New DataTable()

                Dim data As New SqlDataAdapter(command)
                data.Fill(datatable)


                connection.Close()

                UnpaidData.DataSource = datatable


            End Using
        End Using

        UnpaidData.AllowUserToAddRows = False
    End Sub

    Private Sub btnback_Click_1(sender As Object, e As EventArgs) Handles btnback.Click
        Dim back As New DashboardForm
        back.Show()
        Me.Hide()
    End Sub


End Class