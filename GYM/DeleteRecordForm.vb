Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class DeleteRecordForm
    Dim connString As String = ConfigurationManager.ConnectionStrings("Connection").ConnectionString

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DeleteMemberData.EnableHeadersVisualStyles = False
        DeleteMemberData.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue
        DeleteMemberData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        Dim query As String = "SELECT MemberId, FirstName, LastName, Email, Phone, gender, FeeStatus from MemberTable WHERE OwnerId = @OwnerId"

        Using connection As New SqlConnection(connString)
            Using command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@OwnerId", SessionManager.currentOwnerId)
                connection.Open()

                Dim datatable As New DataTable()

                Dim data As New SqlDataAdapter(command)
                data.Fill(datatable)


                connection.Close()

                DeleteMemberData.DataSource = datatable


            End Using
        End Using

        DeleteMemberData.AllowUserToAddRows = False

        Dim buttonCol As New DataGridViewButtonColumn()
        DeleteMemberData.Columns.Insert(7, buttonCol)
        buttonCol.HeaderText = "Delete Record"
        buttonCol.Width = 100
        buttonCol.Text = "Delete"
        buttonCol.UseColumnTextForButtonValue = True

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim back As New DashboardForm
        back.Show()
        Me.Hide()
    End Sub

    'Private Sub RefreshData()
    '    If e.ColumnIndex = 7 AndAlso e.RowIndex >= 0 Then
    '        Dim row = DeleteMemberData.Rows(e.RowIndex)
    '        DeleteMemberData.DataSource = Nothing
    '    Dim memberId = Convert.ToInt32(row.Cells("MemberId").Value)
    '    Dim query = "DELETE FROM MemberTable WHERE MemberId = @MemberId"

    '    Using connect As New SqlConnection(connString)
    '        Using cmd = New SqlCommand(query, connect)

    '            cmd.Parameters.AddWithValue("@MemberId", memberId)
    '            connect.Open()
    '            cmd.ExecuteNonQuery()
    '        End Using
    '    End Using

    '    End If

    'End Sub

    Private Sub DeleteMemberData_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DeleteMemberData.CellContentClick
        If e.ColumnIndex = 7 AndAlso e.RowIndex >= 0 Then

            Dim row = DeleteMemberData.Rows(e.RowIndex)

            Dim result = MessageBox.Show("Do you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                Dim memberId = Convert.ToInt32(row.Cells("MemberId").Value)


                Dim query = "DELETE FROM MemberTable WHERE MemberId = @MemberId"

                Using connection As New SqlConnection(connString)
                    Using command As New SqlCommand(query, connection)

                        command.Parameters.AddWithValue("@MemberId", memberId)

                        Try

                            connection.Open()
                            command.ExecuteNonQuery()

                            MessageBox.Show("Row deleted successfully")

                        Catch ex As Exception
                            MessageBox.Show($"Error deleting row: {ex.Message}")
                        Finally
                            connection.Close()
                            'RefreshData()
                        End Try

                    End Using
                End Using
            End If
        End If
    End Sub
End Class