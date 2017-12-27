
Imports System.Data
Imports System.Data.SqlClient
Public Class frmstructvb


    Private Sub frmstructvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_user()
    End Sub
    Private Sub display_user()
        'Display registered students in listview  for update

        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
        con.Open()
        Dim Dt As New DataTable("tbstruct")
        Dim rs As SqlDataAdapter

        rs = New SqlDataAdapter("Select Year,Batch,Fees from tbstruct", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvUser.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            'If IsDBNull(lv.SubItems.Add(Dt.Rows(indx).Item("Picture"))) Then
            lv.Text = Dt.Rows(indx).Item("Year")
            'lv.SubItems.Add(Dt.Rows(indx).Item("StudentID"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Batch"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Fees"))
            lvUser.Items.Add(lv)
            'End If
        Next

    End Sub

    Private Sub srch()
        lvUser.Items.Clear()
        Dim SqlString As String = "SELECT Year,Batch,Fees FROM tbstruct where (Batch LIKE '%" & TextBox1.Text & "%')"
        'Function for searching by candidate ID number

        Using conn As New SqlConnection
            conn.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
            Using cmd As New SqlCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim li As New ListViewItem
                            li.Text = reader("Year").ToString
                            li.SubItems.Add(reader("Batch").ToString)
                            li.SubItems.Add(reader("Fees").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub
    'End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        srch()
    End Sub
End Class