Imports System.Data
Imports System.Data.SqlClient

Public Class salary

    Dim con As New SqlConnection("Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim dr As SqlDataReader

    Dim i As Integer
    Private Sub salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SisDataSet7.tbBill' table. You can move, or remove it, as needed.
        Me.TbBillTableAdapter.Fill(Me.SisDataSet7.tbBill)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New searchfac
        frm.ShowDialog()
        txtid.Text = frm.lvList.SelectedItems(0).Text
        disp()
    End Sub
    Private Sub disp()
        If txtid.Text = "" Then
            MsgBox("Please Search Staff", MsgBoxStyle.Information, " error")
            Exit Sub
        Else

            Dim ct As String
            con = New SqlConnection("Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True")
            con.Open()
            Try
                cmd = New SqlCommand("select count (*) from tbStaff where StaffID='" & txtid.Text & "'", con)

                ct = cmd.ExecuteScalar
                If ct > 0 Then
                    cmd = New SqlCommand("select * from tbStaff where StaffID='" & txtid.Text & "'", con)

                    dr = cmd.ExecuteReader()
                    dr.Read()
                    txtid.Text = ""
                    txtstuid.Text = dr("StaffID")
                    txtfname.Text = dr("Firstname")
                    txtlname.Text = dr("Lastname")
                    'txtsem.Text = dr("Month")
                    ' txtBatch.Text = dr("Batch")
                    'txtClass.Text = dr("Class")
                    dr.Close()
                    Exit Sub


                End If

                'End While
                dr.Close()


                dr = cmd.ExecuteReader
                dr.Read()

                If dr.HasRows = True Then
                    txtid.Text = ""
                    txtstuid.Text = dr("StaffID")
                    txtfname.Text = dr("Firstname") & "" & dr("Lastname")
                    txtlname.Text = dr("Lastname")
                    ' txtsem.Text = dr("Month")
                    'txtBatch.Text = dr("Batch")
                    'txtClass.Text = dr("Class")
                    'picImage.Image = IMG
                Else
                    MsgBox("Account Number does not exist", MsgBoxStyle.Information)
                    dr.Close()

                End If
                dr.Close()

                cmd.Dispose()
                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        con.Close()
        con.Open()
        Using cmd As New SqlClient.SqlCommand("Insert into tbBill(ID,BilliD,StaffID,Firstname,Lastname,Description,BillCost,BillDate,Month,Status)Values('" & txtid.Text & "','" & txtbillid.Text & "','" & txtstuid.Text & "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtdesc.Text & "','" & txtcost.Text & "','" & txtdate.Text & "','" & txtsem.Text & "','" & txtstatus.Text & "')", con)
            '            cmd.Parameters.Add(New SqlClient.SqlParameter("@picturebox1", SqlDbType.Image)).Value = IO.File.ReadAllBytes(a.FileName)
            i = cmd.ExecuteNonQuery
        End Using
        If (i > 0) Then
            MsgBox("Save" & i & "record successfully")
        End If
        con.Close()
        showrecord()
    End Sub


    Public Sub showrecord()
        con = New SqlConnection("Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True")
        con.Open()

        Dim cmd As SqlCommand = New SqlCommand("Select * From tbBill", con)

        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        ' DataGridView1.RowTemplate.Height = 70
        DataGridView1.DataSource = dt
        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            If TypeOf DataGridView1.Columns(i) Is DataGridViewImageColumn Then
                DirectCast(DataGridView1.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
            End If
        Next
        con.Close()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtid.Text = DataGridView1.Item(0, e.RowIndex).Value
            txtbillid.Text = DataGridView1.Item(1, e.RowIndex).Value
            txtstuid.Text = DataGridView1.Item(2, e.RowIndex).Value
            txtfname.Text = DataGridView1.Item(3, e.RowIndex).Value
            txtlname.Text = DataGridView1.Item(4, e.RowIndex).Value
            txtdesc.Text = DataGridView1.Item(5, e.RowIndex).Value
            txtcost.Text = DataGridView1.Item(6, e.RowIndex).Value
            txtdate.Text = DataGridView1.Item(7, e.RowIndex).Value
            txtsem.Text = DataGridView1.Item(8, e.RowIndex).Value
            txtstatus.Text = DataGridView1.Item(9, e.RowIndex).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdclear_Click(sender As Object, e As EventArgs) Handles cmdclear.Click
        txtid.Text = ""
        txtbillid.Text = ""
        txtstuid.Text = ""
        txtfname.Text = ""
        txtlname.Text = ""
        txtdesc.Text = ""
        txtcost.Text = ""
        txtdate.Text = ""
        '  txtsem.Text = ""
        ' txtstatus = ""
    End Sub
    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        con = New SqlConnection("Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True")
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("Delete FROM tbBill WHERE ID ='" & DataGridView1.SelectedRows(0).Cells(0).Value & "'", con)

        i = cmd.ExecuteNonQuery
        If (i > 0) Then
            MsgBox("Delete" & i & "rowsuccessfully")
        End If
        con.Close()
        showrecord()
    End Sub

    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        con = New SqlConnection("Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True")
        con.Open()
        Dim wop As String = DataGridView1.SelectedRows(0).Cells(0).Value
        Using cmd As New SqlClient.SqlCommand("UPDATE tbBill Set ID='" & txtid.Text & "',Billid='" & txtbillid.Text & "',StaffID='" & txtstuid.Text & "',Firstname='" & txtfname.Text & "',Lastname='" & txtlname.Text & "',Description='" & txtdesc.Text & "',BillCost='" & txtcost.Text & "',BillDate='" & txtdate.Text & "',Month='" & txtsem.Text & "',Status='" & txtstatus.Text & "' where ID = '" & wop & "' ", con)

            i = cmd.ExecuteNonQuery
        End Using
        If (i > 0) Then
            MsgBox("Save" & i & "record successfully")
        End If
        con.Close()
        showrecord()

    End Sub
    Private Sub cmdSearchs_Click(sender As Object, e As EventArgs) Handles cmdSearchs.Click
        con.Open()
        With cmd
            .Connection = con
            .CommandText = "Select * FROM tbBill WHERE Firstname like '%" & txtsearch.Text & "%'"
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        DataGridView1.RowTemplate.Height = 70
        DataGridView1.DataSource = dt
        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            If TypeOf DataGridView1.Columns(i) Is DataGridViewImageColumn Then
                DirectCast(DataGridView1.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
            End If
        Next
        con.Close()
    End Sub

End Class