Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing

Public Class frmSearch

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim dtAC As DataTable


    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'fillcmbItemName()
        Try
            display_user()
        Catch ex As Exception

        End Try
    End Sub
  

    Private Sub srch()
        lvList.Items.Clear()
        Dim SqlString As String = "SELECT * FROM tbEnroll where (Firstname LIKE '%" & txtsearch.Text & "%')"
        'Function for searching by candidate ID number
        Using conn As New SqlConnection("Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True")
            Using cmd As New SqlCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim li As New ListViewItem
                            li.Text = reader("StudentID").ToString
                            li.SubItems.Add(reader("Firstname").ToString)

                            lvList.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub

    Private Sub display_user()
        'Display registered students in listview  for update

        Dim con As New SqlConnection("Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True")
        con.Open()
        Dim Dt As New DataTable("tbEnroll")
        Dim rs As SqlDataAdapter

        rs = New SqlDataAdapter("Select * from tbEnroll", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvList.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            'If IsDBNull(lv.SubItems.Add(Dt.Rows(indx).Item("Picture"))) Then
            lv.Text = Dt.Rows(indx).Item("StudentID")
            'lv.SubItems.Add(Dt.Rows(indx).Item("StudentID"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Firstname"))
           
            lvList.Items.Add(lv)
            'End If
        Next
        'Dt.Dispose()
        rs.Dispose()
        con.Close()

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        srch()

    End Sub

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        Me.Close()
    End Sub

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub
End Class