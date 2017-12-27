
Imports System.Data
Imports System.Data.SqlClient
Public Class searchf


    Private Sub searchf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        display_user()
    End Sub
    Private Sub display_user()
        'Display registered students in listview  for update

        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
        con.Open()
        Dim Dt As New DataTable("tbstaff")
        Dim rs As SqlDataAdapter

        rs = New SqlDataAdapter("Select StaffID,Title,Firstname,Lastname,Other,Gender,Position,Tel from tbstaff", con)

        rs.Fill(Dt)
        Dim indx As Integer
        lvUser.Items.Clear()
        For indx = 0 To Dt.Rows.Count - 1
            Dim lv As New ListViewItem
            'If IsDBNull(lv.SubItems.Add(Dt.Rows(indx).Item("Picture"))) Then
            lv.Text = Dt.Rows(indx).Item("StaffID")
            'lv.SubItems.Add(Dt.Rows(indx).Item("StudentID"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Title"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Firstname"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Lastname"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Other"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Gender"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Position"))
            lv.SubItems.Add(Dt.Rows(indx).Item("Tel"))
            'lv.SubItems.Add(Image.FromFile(Application.StartupPath & "\noimage.png"))
            lvUser.Items.Add(lv)
            'End If
        Next

    End Sub

    Private Sub srchstaff()
        lvUser.Items.Clear()
        Dim SqlString As String = "SELECT StaffID,Title,Firstname,Lastname,Other,Gender,Position,Tel FROM tbstaff where (StaffID LIKE '%" & txtstaffid.Text & "%')"
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
                            li.Text = reader("StaffID").ToString
                            li.SubItems.Add(reader("Title").ToString)
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Other").ToString)
                            li.SubItems.Add(reader("Gender").ToString)
                            li.SubItems.Add(reader("Position").ToString)
                            li.SubItems.Add(reader("Tel").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub
    'End Sub

    Private Sub Textstaffid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstaffid.TextChanged
        srchstaff()
    End Sub

    Private Sub srchfname()
        lvUser.Items.Clear()
        Dim SqlString As String = "SELECT StaffID,Title,Firstname,Lastname,Other,Gender,Position,Tel FROM tbstaff where (Firstname LIKE '%" & TextBox1.Text & "%')"
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
                            li.Text = reader("StaffID").ToString
                            li.SubItems.Add(reader("Title").ToString)
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Other").ToString)
                            li.SubItems.Add(reader("Gender").ToString)
                            li.SubItems.Add(reader("Position").ToString)
                            li.SubItems.Add(reader("Tel").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub
    'End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        srchfname()
    End Sub

    Private Sub srchlname()
        lvUser.Items.Clear()
        Dim SqlString As String = "SELECT StaffID,Title,Firstname,Lastname,Other,Gender,Position,Tel FROM tbstaff where (Lastname LIKE '%" & txtlname.Text & "%')"
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
                            li.Text = reader("StaffID").ToString
                            li.SubItems.Add(reader("Title").ToString)
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Other").ToString)
                            li.SubItems.Add(reader("Gender").ToString)
                            li.SubItems.Add(reader("Position").ToString)
                            li.SubItems.Add(reader("Tel").ToString)
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

    Private Sub srchpos()
        lvUser.Items.Clear()
        Dim SqlString As String = "SELECT StaffID,Title,Firstname,Lastname,Other,Gender,Position,Tel FROM tbstaff where (Position LIKE '%" & txtpos.Text & "%')"
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
                            li.Text = reader("StaffID").ToString
                            li.SubItems.Add(reader("Title").ToString)
                            li.SubItems.Add(reader("Firstname").ToString)
                            li.SubItems.Add(reader("Lastname").ToString)
                            li.SubItems.Add(reader("Other").ToString)
                            li.SubItems.Add(reader("Gender").ToString)
                            li.SubItems.Add(reader("Position").ToString)
                            li.SubItems.Add(reader("Tel").ToString)
                            lvUser.Items.Add(li)
                        End While
                    End If
                End Using
            End Using
        End Using

    End Sub
    'End Sub

    Private Sub txtpos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpos.TextChanged
        srchpos()
    End Sub
End Class