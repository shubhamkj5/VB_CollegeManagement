Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class manageuservb
    Dim cn As New SqlConnection("Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim i As Integer
    Dim a As New OpenFileDialog
    Private Sub manageuservb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SisDataSet9.tbUser' table. You can move, or remove it, as needed.
        Me.TbUserTableAdapter.Fill(Me.SisDataSet9.tbUser)

    End Sub


    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click

        cn.Open()
        Using cmd As New SqlClient.SqlCommand("Insert into tbUser(ID,LoginID,Pwd,Favcolor)Values('" & txtid.Text & "','" & logid.Text & "','" & txtpass.Text & "','" & txtfavc.Text & "')", cn)

            i = cmd.ExecuteNonQuery
        End Using
        If (i > 0) Then
            MsgBox("Save" & i & "record successfully")
        End If
        cn.Close()
        showrecord()
    End Sub


    Sub showrecord()
        cn.Open()
        With cmd
            .Connection = cn
            .CommandText = "Select * From tbUser"
        End With
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        ' DataGridView1.RowTemplate.Height = 70
        DataGridView1.DataSource = dt
        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            '    If TypeOf DataGridView1.Columns(i) Is DataGridViewImageColumn Then
            '   DirectCast(DataGridView1.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
            '  End If
        Next
        cn.Close()
    End Sub
    'Sub clear()
    '    txtid.Clear()
    '    txtstuid.Clear()
    '    txtfname.Clear()
    '    txtlname.Clear()
    '    txtoname.Clear()
    '    txthome.Clear()
    '    txtgfname.Clear()
    '    txtglname.Clear()
    '    txtgresidence.Clear()
    '    txtgemail.Clear()
    '    txtgcontact.Clear()
    '    txtfees.Clear()
    '    PictureBox1.Image = Nothing
    '    txtid.Focus()
    'End Sub

    '  Function changephoto(ByVal photo As Integer) As Byte()
    '     cn.Open()
    'With cmd
    '.Connection = cn
    '.CommandText = "Select picturebox1 from tbStaff where id=" & DataGridView1.SelectedRows(0).Cells(0).Value

    'End With
    'Dim myphoto() As Byte = CType(cmd.ExecuteScalar(), Byte())
    '   cn.Close()
    'Return myphoto

    'End Function
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtid.Text = DataGridView1.Item(0, e.RowIndex).Value
            logid.Text = DataGridView1.Item(1, e.RowIndex).Value
            txtpass.Text = DataGridView1.Item(2, e.RowIndex).Value
            txtfavc.Text = DataGridView1.Item(3, e.RowIndex).Value
            '  txtlname.Text = DataGridView1.Item(4, e.RowIndex).Value
            '   txtoname.Text = DataGridView1.Item(5, e.RowIndex).Value
            '    txtgender.Text = DataGridView1.Item(6, e.RowIndex).Value
            '     txtposition.Text = DataGridView1.Item(7, e.RowIndex).Value
            '      txtcontact.Text = DataGridView1.Item(8, e.RowIndex).Value
            '       Dim ms As New MemoryStream(changephoto(CInt(DataGridView1.SelectedCells(0).Value)))
            ' PictureBox1.Image = Image.FromStream(ms)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        cn.Close()
        cn.Open()
        Dim wop As String = DataGridView1.SelectedRows(0).Cells(0).Value
        Using cmd As New SqlClient.SqlCommand("UPDATE tbUSer Set ID='" & txtid.Text & "',LoginID='" & logid.Text & "',Pwd='" & txtpass.Text & "',Favcolor='" & txtfavc.Text & "' where Id = '" & wop & "' ", cn)
            'cmd.Parameters.Add(New SqlClient.SqlParameter("@picturebox1", SqlDbType.Image)).Value = IO.File.ReadAllBytes(a.FileName)
            i = cmd.ExecuteNonQuery
        End Using
        If (i > 0) Then
            MsgBox("Save" & i & "record successfully")
        End If
        cn.Close()
        showrecord()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        cn.Close()

        cn.Open()
        With cmd
            .Connection = cn
            .CommandText = "Delete FROM tbUser WHERE ID =" & DataGridView1.SelectedRows(0).Cells(0).Value
            i = cmd.ExecuteNonQuery
        End With
        If (i > 0) Then
            MsgBox("Delete" & i & "rowsuccessfully")
        End If
        cn.Close()
        showrecord()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles logid.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class