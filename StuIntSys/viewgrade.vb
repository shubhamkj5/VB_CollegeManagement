
Imports System.Data
Imports System.Data.SqlClient
Public Class viewgrade


    Private Sub viewgrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_user()
    End Sub
    Private Sub display_user()
        'Display registered students in listview  for update

        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
        con.Open()
        Dim Dt As New DataTable("tbgrades")
        Dim rs As SqlDataAdapter

        rs = New SqlDataAdapter("Select * from tbgrades", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvUser.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            'If IsDBNull(lv.SubItems.Add(Dt.Rows(indx).Item("Picture"))) Then
            lv.Text = Dt.Rows(indx).Item("ID")
            lv.SubItems.Add(Dt.Rows(indx).Item("StudentID"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Firstname"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Lastname"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Sem"))
            lv.SubItems.Add(Dt.Rows(indx).Item("ClassT"))
            lv.SubItems.Add(Dt.Rows(indx).Item("VacDate"))
            lv.SubItems.Add(Dt.Rows(indx).Item("NTB"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Promo"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Subject"))
            lv.SubItems.Add(Dt.Rows(indx).Item("ClassW"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Exams"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Total"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Grade"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Remarks"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Att1"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Att2"))
            lv.SubItems.Add(Dt.Rows(indx).Item("ClassTrem"))
            lv.SubItems.Add(Dt.Rows(indx).Item("HeadRem"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Headname"))
            'lv.SubItems.Add(Dt.Rows(indx).Item("Yr"))
            'lv.SubItems.Add(Image.FromFile(Application.StartupPath & "\noimage.png"))
            lvUser.Items.Add(lv)
            'End If
        Next

    End Sub

    Private Sub srch()
        lvUser.Items.Clear()
        Dim SqlString As String = "SELECT * FROM tbgrades where (Firstname LIKE '%" & txtfname.Text & "%')"
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
                            li.Text = reader("ID").ToString
                            li.SubItems.Add(reader("StudentID").ToString)
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Sem").ToString)
                            li.SubItems.Add(reader("ClassT").ToString)
                            li.SubItems.Add(reader("VacDate").ToString)
                            li.SubItems.Add(reader("NTB").ToString)
                            li.SubItems.Add(reader("Promo").ToString)
                            li.SubItems.Add(reader("Subject").ToString)
                            li.SubItems.Add(reader("ClassW").ToString)
                            li.SubItems.Add(reader("Exams").ToString)
                            li.SubItems.Add(reader("Total").ToString)
                            li.SubItems.Add(reader("Grade").ToString)
                            li.SubItems.Add(reader("Remarks").ToString)
                            li.SubItems.Add(reader("Att1").ToString)
                            li.SubItems.Add(reader("Att2").ToString)
                            li.SubItems.Add(reader("ClassTrem").ToString)
                            li.SubItems.Add(reader("HeadRem").ToString)
                            li.SubItems.Add(reader("Headname").ToString)
                            li.SubItems.Add(reader("Yr").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub
    'End Sub
    Private Sub srchs()
        lvUser.Items.Clear()
        Dim SqlString1 As String = "SELECT * FROM tbgrades where (Subject LIKE '%" & txtsub.Text & "%')"
        'Function for searching by candidate ID number

        Using conn As New SqlConnection
            conn.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
            Using cmd As New SqlCommand(SqlString1, conn)
                cmd.CommandType = CommandType.Text
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim li As New ListViewItem
                            li.Text = reader("ID").ToString
                            li.SubItems.Add(reader("StudentID").ToString)
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Sem").ToString)
                            li.SubItems.Add(reader("ClassT").ToString)
                            li.SubItems.Add(reader("VacDate").ToString)
                            li.SubItems.Add(reader("NTB").ToString)
                            li.SubItems.Add(reader("Promo").ToString)
                            li.SubItems.Add(reader("Subject").ToString)
                            li.SubItems.Add(reader("ClassW").ToString)
                            li.SubItems.Add(reader("Exams").ToString)
                            li.SubItems.Add(reader("Total").ToString)
                            li.SubItems.Add(reader("Grade").ToString)
                            li.SubItems.Add(reader("Remarks").ToString)
                            li.SubItems.Add(reader("Att1").ToString)
                            li.SubItems.Add(reader("Att2").ToString)
                            li.SubItems.Add(reader("ClassTrem").ToString)
                            li.SubItems.Add(reader("HeadRem").ToString)
                            li.SubItems.Add(reader("Headname").ToString)
                            li.SubItems.Add(reader("Yr").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub

    Private Sub srchsem()
        lvUser.Items.Clear()
        Dim SqlStringsem As String = "SELECT * FROM tbgrades where (Sem LIKE '%" & txtsem.Text & "%')"
        'Function for searching by candidate ID number

        Using conn As New SqlConnection
            conn.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
            Using cmd As New SqlCommand(SqlStringsem, conn)
                cmd.CommandType = CommandType.Text
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim li As New ListViewItem
                            li.Text = reader("ID").ToString
                            li.SubItems.Add(reader("StudentID").ToString)
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Sem").ToString)
                            li.SubItems.Add(reader("ClassT").ToString)
                            li.SubItems.Add(reader("VacDate").ToString)
                            li.SubItems.Add(reader("NTB").ToString)
                            li.SubItems.Add(reader("Promo").ToString)
                            li.SubItems.Add(reader("Subject").ToString)
                            li.SubItems.Add(reader("ClassW").ToString)
                            li.SubItems.Add(reader("Exams").ToString)
                            li.SubItems.Add(reader("Total").ToString)
                            li.SubItems.Add(reader("Grade").ToString)
                            li.SubItems.Add(reader("Remarks").ToString)
                            li.SubItems.Add(reader("Att1").ToString)
                            li.SubItems.Add(reader("Att2").ToString)
                            li.SubItems.Add(reader("ClassTrem").ToString)
                            li.SubItems.Add(reader("HeadRem").ToString)
                            li.SubItems.Add(reader("Headname").ToString)
                            li.SubItems.Add(reader("Yr").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub

    Private Sub srchprom()
        lvUser.Items.Clear()
        Dim SqlStringpromo As String = "SELECT * FROM tbgrades where (Promo LIKE '%" & txtprom.Text & "%')"
        'Function for searching by candidate ID number

        Using conn As New SqlConnection
            conn.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
            Using cmd As New SqlCommand(SqlStringpromo, conn)
                cmd.CommandType = CommandType.Text
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim li As New ListViewItem
                            li.Text = reader("ID").ToString
                            li.SubItems.Add(reader("StudentID").ToString)
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Sem").ToString)
                            li.SubItems.Add(reader("ClassT").ToString)
                            li.SubItems.Add(reader("VacDate").ToString)
                            li.SubItems.Add(reader("NTB").ToString)
                            li.SubItems.Add(reader("Promo").ToString)
                            li.SubItems.Add(reader("Subject").ToString)
                            li.SubItems.Add(reader("ClassW").ToString)
                            li.SubItems.Add(reader("Exams").ToString)
                            li.SubItems.Add(reader("Total").ToString)
                            li.SubItems.Add(reader("Grade").ToString)
                            li.SubItems.Add(reader("Remarks").ToString)
                            li.SubItems.Add(reader("Att1").ToString)
                            li.SubItems.Add(reader("Att2").ToString)
                            li.SubItems.Add(reader("ClassTrem").ToString)
                            li.SubItems.Add(reader("HeadRem").ToString)
                            li.SubItems.Add(reader("Headname").ToString)
                            li.SubItems.Add(reader("Yr").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub


    Private Sub srchg()
        lvUser.Items.Clear()
        Dim SqlStringg As String = "SELECT * FROM tbgrades where (Grade LIKE '%" & txtgrade.Text & "%')"
        'Function for searching by candidate ID number

        Using conn As New SqlConnection
            conn.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
            Using cmd As New SqlCommand(SqlStringg, conn)
                cmd.CommandType = CommandType.Text
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim li As New ListViewItem
                            li.Text = reader("ID").ToString
                            li.SubItems.Add(reader("StudentID").ToString)
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Sem").ToString)
                            li.SubItems.Add(reader("ClassT").ToString)
                            li.SubItems.Add(reader("VacDate").ToString)
                            li.SubItems.Add(reader("NTB").ToString)
                            li.SubItems.Add(reader("Promo").ToString)
                            li.SubItems.Add(reader("Subject").ToString)
                            li.SubItems.Add(reader("ClassW").ToString)
                            li.SubItems.Add(reader("Exams").ToString)
                            li.SubItems.Add(reader("Total").ToString)
                            li.SubItems.Add(reader("Grade").ToString)
                            li.SubItems.Add(reader("Remarks").ToString)
                            li.SubItems.Add(reader("Att1").ToString)
                            li.SubItems.Add(reader("Att2").ToString)
                            li.SubItems.Add(reader("ClassTrem").ToString)
                            li.SubItems.Add(reader("HeadRem").ToString)
                            li.SubItems.Add(reader("Headname").ToString)
                            li.SubItems.Add(reader("Yr").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub
    Private Sub txtfname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfname.TextChanged
        srch()
    End Sub

    Private Sub txtsub_TextChanged(sender As Object, e As EventArgs) Handles txtsub.TextChanged
        srchs()
    End Sub

    Private Sub txtsem_TextChanged(sender As Object, e As EventArgs) Handles txtsem.TextChanged
        srchsem()
    End Sub

    Private Sub txtprom_TextChanged(sender As Object, e As EventArgs) Handles txtprom.TextChanged
        srchprom()
    End Sub

    Private Sub txtgrade_TextChanged(sender As Object, e As EventArgs) Handles txtgrade.TextChanged
        srchg()
    End Sub
End Class