
Imports System.Data
Imports System.Data.SqlClient
Public Class frmUpdate


    Private Sub frmUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_user()
    End Sub
    Private Sub display_user()
        'Display registered students in listview  for update

        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
        con.Open()
        Dim Dt As New DataTable("tbEnroll")
        Dim rs As SqlDataAdapter

        rs = New SqlDataAdapter("Select StudentID,Firstname,Lastname,Othername,Gender,Sem,GFirstname,GLastname,GTel,GEmail,GResidence,Status from tbEnroll", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvUser.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            'If IsDBNull(lv.SubItems.Add(Dt.Rows(indx).Item("Picture"))) Then
            lv.Text = Dt.Rows(indx).Item("StudentID")
            'lv.SubItems.Add(Dt.Rows(indx).Item("StudentID"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Firstname"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Lastname"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Othername"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Gender"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Sem"))
            lv.SubItems.Add(Dt.Rows(indx).Item("GFirstname"))
            lv.SubItems.Add(Dt.Rows(indx).Item("GLastname"))
            lv.SubItems.Add(Dt.Rows(indx).Item("GTel"))
            lv.SubItems.Add(Dt.Rows(indx).Item("GEmail"))
            lv.SubItems.Add(Dt.Rows(indx).Item("GResidence"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Status"))
            'lv.SubItems.Add(Image.FromFile(Application.StartupPath & "\noimage.png"))
            lvUser.Items.Add(lv)
            'End If
        Next

    End Sub

    Private Sub srch()
        lvUser.Items.Clear()
        Dim SqlString As String = "SELECT StudentID,Firstname,Lastname,Othername,Gender,Sem,GFirstname,GLastname,GTel,GEmail,GResidence,Status FROM tbEnroll where (StudentID LIKE '%" & txtstuid.Text & "%')"
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
                            li.Text = reader("StudentID").ToString
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Othername").ToString)
                            li.SubItems.Add(reader("Gender").ToString)
                            li.SubItems.Add(reader("Sem").ToString)
                            li.SubItems.Add(reader("GFirstname").ToString)
                            li.SubItems.Add(reader("GLastname").ToString)
                            li.SubItems.Add(reader("GTel").ToString)
                            li.SubItems.Add(reader("GEmail").ToString)
                            li.SubItems.Add(reader("GResidence").ToString)
                            li.SubItems.Add(reader("Status").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub
    'End Sub

    Private Sub txtstuid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstuid.TextChanged
        srch()
    End Sub

    Private Sub srchfname()
        lvUser.Items.Clear()
        Dim SqlStringfname As String = "SELECT StudentID,Firstname,Lastname,Othername,Gender,Sem,GFirstname,GLastname,GTel,GEmail,GResidence,Status FROM tbEnroll where (Firstname LIKE '%" & txtfname.Text & "%')"
        'Function for searching by candidate ID number

        Using conn As New SqlConnection
            conn.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
            Using cmd As New SqlCommand(SqlStringfname, conn)
                cmd.CommandType = CommandType.Text
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim li As New ListViewItem
                            li.Text = reader("StudentID").ToString
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Othername").ToString)
                            li.SubItems.Add(reader("Gender").ToString)
                            li.SubItems.Add(reader("Sem").ToString)
                            li.SubItems.Add(reader("GFirstname").ToString)
                            li.SubItems.Add(reader("GLastname").ToString)
                            li.SubItems.Add(reader("GTel").ToString)
                            li.SubItems.Add(reader("GEmail").ToString)
                            li.SubItems.Add(reader("GResidence").ToString)
                            li.SubItems.Add(reader("Status").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub
    'End Sub

    Private Sub txtfname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfname.TextChanged
        srchfname()
    End Sub
    Private Sub srchlname()
        lvUser.Items.Clear()
        Dim SqlStringlname As String = "SELECT StudentID,Firstname,Lastname,Othername,Gender,Sem,GFirstname,GLastname,GTel,GEmail,GResidence,Status FROM tbEnroll where (Lastname LIKE '%" & txtlname.Text & "%')"
        'Function for searching by candidate ID number

        Using conn As New SqlConnection
            conn.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
            Using cmd As New SqlCommand(SqlStringlname, conn)
                cmd.CommandType = CommandType.Text
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim li As New ListViewItem
                            li.Text = reader("StudentID").ToString
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Othername").ToString)
                            li.SubItems.Add(reader("Gender").ToString)
                            li.SubItems.Add(reader("Sem").ToString)
                            li.SubItems.Add(reader("GFirstname").ToString)
                            li.SubItems.Add(reader("GLastname").ToString)
                            li.SubItems.Add(reader("GTel").ToString)
                            li.SubItems.Add(reader("GEmail").ToString)
                            li.SubItems.Add(reader("GResidence").ToString)
                            li.SubItems.Add(reader("Status").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub
    'End Sub

    Private Sub txtlname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlname.TextChanged
        srchlname()
    End Sub

    Private Sub srchsem()
        lvUser.Items.Clear()
        Dim SqlStringsem As String = "SELECT StudentID,Firstname,Lastname,Othername,Gender,Sem,GFirstname,GLastname,GTel,GEmail,GResidence,Status FROM tbEnroll where (Sem LIKE '%" & txtsem.Text & "%')"
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
                            li.Text = reader("StudentID").ToString
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Othername").ToString)
                            li.SubItems.Add(reader("Gender").ToString)
                            li.SubItems.Add(reader("Sem").ToString)
                            li.SubItems.Add(reader("GFirstname").ToString)
                            li.SubItems.Add(reader("GLastname").ToString)
                            li.SubItems.Add(reader("GTel").ToString)
                            li.SubItems.Add(reader("GEmail").ToString)
                            li.SubItems.Add(reader("GResidence").ToString)
                            li.SubItems.Add(reader("Status").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub
    'End Sub

    Private Sub txtsem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsem.TextChanged
        srchsem()
    End Sub

    Private Sub srchres()
        lvUser.Items.Clear()
        Dim SqlStringres As String = "SELECT StudentID,Firstname,Lastname,Othername,Gender,Sem,GFirstname,GLastname,GTel,GEmail,GResidence,Status FROM tbEnroll where (GResidence LIKE '%" & txtres.Text & "%')"
        'Function for searching by candidate ID number

        Using conn As New SqlConnection
            conn.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
            Using cmd As New SqlCommand(SqlStringres, conn)
                cmd.CommandType = CommandType.Text
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            Dim li As New ListViewItem
                            li.Text = reader("StudentID").ToString
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Othername").ToString)
                            li.SubItems.Add(reader("Gender").ToString)
                            li.SubItems.Add(reader("Sem").ToString)
                            li.SubItems.Add(reader("GFirstname").ToString)
                            li.SubItems.Add(reader("GLastname").ToString)
                            li.SubItems.Add(reader("GTel").ToString)
                            li.SubItems.Add(reader("GEmail").ToString)
                            li.SubItems.Add(reader("GResidence").ToString)
                            li.SubItems.Add(reader("Status").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub
    'End Sub

    Private Sub txtres_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtres.TextChanged
        srchres()
    End Sub

End Class