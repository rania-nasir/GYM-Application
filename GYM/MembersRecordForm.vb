Imports System.Configuration
Imports Microsoft.Data.SqlClient

Public Class MembersRecordForm
    Dim connString As String = ConfigurationManager.ConnectionStrings("Connection").ConnectionString
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MemberData.EnableHeadersVisualStyles = False
        MemberData.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue
        MemberData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White



        Dim query As String = "SELECT MemberId, FirstName, LastName, Email, Phone, gender, FeeStatus from MemberTable Where OwnerId = @OwnerId"

        Using connection As New SqlConnection(connString)
            Using command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@OwnerId", SessionManager.currentOwnerId)
                connection.Open()

                Dim datatable As New DataTable()

                Dim data As New SqlDataAdapter(command)
                data.Fill(datatable)


                connection.Close()

                MemberData.DataSource = datatable


            End Using
        End Using

        MemberData.AllowUserToAddRows = False

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click



    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        Dim query As String = "SELECT * FROM MemberTable WHERE OwnerId = @OwnerId AND FirstName LIKE @name + '%'"
        Dim data As New SqlDataAdapter(query, connString)

        data.SelectCommand.Parameters.AddWithValue("@name", searchbox.Text.Trim())
        data.SelectCommand.Parameters.AddWithValue("@OwnerId", SessionManager.currentOwnerId)
        Dim dt As New DataTable()
        data.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MemberData.DataSource = dt
        Else
            MessageBox.Show("No Record Found")
            MemberData.DataSource = Nothing
        End If
    End Sub

    Private Sub MemberData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MemberData.CellContentClick

        MemberData.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim back As New DashboardForm
        back.Show()
        Me.Hide()
    End Sub
End Class