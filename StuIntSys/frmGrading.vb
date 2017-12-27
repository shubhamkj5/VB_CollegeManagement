Imports System.Data
Imports System.Data.SqlClient

Public Class frmGrading
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private Sub frmGrading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtGrade.Text = "-"
        txtRem.Text = "-"
        GroupBox2.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim frm As New frmSearch
        frm.ShowDialog()
        txtid.Text = frm.lvList.SelectedItems(0).Text
        disp()

        GroupBox2.Enabled = True

    End Sub

    Private Sub disp()
        If txtid.Text = "" Then
            MsgBox("Please Search Student", MsgBoxStyle.Information, " error")
            Exit Sub
        Else

            Dim ct As String
            con = New SqlConnection("Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True")
            con.Open()
            Try
                cmd = New SqlCommand("select count (*) from tbEnroll where StudentID='" & txtid.Text & "'", con)

                ct = cmd.ExecuteScalar
                If ct > 0 Then
                    cmd = New SqlCommand("select * from tbEnroll where StudentID='" & txtid.Text & "'", con)

                    dr = cmd.ExecuteReader()
                    dr.Read()

                    'txtID.Text = dr("StudentID")
                    txtFN.Text = dr("Firstname")
                    txtLN.Text = dr("Lastname")
                    '  txtClass.Text = dr("Class")
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
                    'txtID.Text = dr("StudentID")
                    txtFN.Text = dr("Firstname") & "" & dr("Lastname")
                    txtLN.Text = dr("Lastname")
                    'txtClass.Text = dr("Class")
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

    Private Sub txtAtt1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAtt1.GotFocus
        txtAtt1.Text = ""
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAtt1.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAtt1.TextChanged

    End Sub

    Private Sub txtAtt2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAtt2.GotFocus
        txtAtt2.Text = ""
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAtt2.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAtt2.TextChanged

    End Sub

   

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub add()
        Dim i As Integer = 0
        dgv.Rows.Add()
        dgv.Rows(dgv.RowCount - 1).Cells("Subject").Value = cboSubject.Text
        dgv.Rows(dgv.RowCount - 1).Cells("thirty").Value = txtClassW.Text
        dgv.Rows(dgv.RowCount - 1).Cells("seventy").Value = txtExams.Text
        dgv.Rows(dgv.RowCount - 1).Cells("tot").Value = txtTot.Text
        dgv.Rows(dgv.RowCount - 1).Cells("grade").Value = txtGrade.Text
        dgv.Rows(dgv.RowCount - 1).Cells("Remarks").Value = txtRem.Text

        txtClassW.Text = "0"
        txtExams.Text = "0"
        txtTot.Text = "0"
        txtGrade.Text = "-"
        txtRem.Text = "-"
        cboSubject.Text = "--Select Subject--"
    End Sub

    Private Sub txtClassW_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClassW.GotFocus
        txtClassW.Text = ""
    End Sub

    Private Sub txtClassW_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClassW.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtExams_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExams.GotFocus
        txtExams.Text = ""
    End Sub

    Private Sub txtExams_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExams.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

  
    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If txtClassW.Text = "0" And txtExams.Text = "0" Or cboSubject.Text = "--Select Subject--" Then
            MsgBox("Please make sure Subject, Class Work and Exams score are filled correctly")
            Exit Sub
        Else
            add()
        End If
        'add()

    End Sub

    Private Sub txtExams_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExams.TextChanged
        Dim sngYearMark, sngExamMark, sngFinalMark As Single
        sngYearMark = Val(Me.txtClassW.Text) * 0.3
        sngExamMark = Val(Me.txtExams.Text) * 0.7
        sngFinalMark = sngYearMark + sngExamMark
        txtTot.Text = sngFinalMark
        Select Case sngFinalMark
            Case sngFinalMark = 0 To 44
                txtGrade.Text = "F"
                txtRem.Text = "Fail"
            Case sngFinalMark = 45 To 59
                txtGrade.Text = "E"
                txtRem.Text = "Pass"
            Case sngFinalMark = 60 To 69
                txtGrade.Text = "D"
                txtRem.Text = "Credit"
            Case sngFinalMark = 70 To 79
                txtGrade.Text = "C"
                txtRem.Text = "Good"
            Case sngFinalMark = 80 To 89
                txtGrade.Text = "B"
                txtRem.Text = "Very Good"
            Case sngFinalMark = 90 To 100
                txtGrade.Text = "A"
                txtRem.Text = "Excellent"
            Case Else
                System.Console.WriteLine("Not a valid Student Mark.")
        End Select
    End Sub

    Private Sub insrt()
        Dim con As New SqlConnection("Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True")
        con.Open()
        For Each row As DataGridViewRow In dgv.Rows
            Dim cmd As New SqlCommand("insert into tbGrades(StudentID,Firstname,Lastname,Sem,ClassT,VacDate,NTB,Promo,Subject,ClassW,Exams,[Total],Grade,Remarks,Att1,Att2,ClassTrem,HeadRem,Headname)values('" & txtid.Text & "','" & txtFN.Text & "','" & txtLN.Text & "','" & txtSem.Text & "','" & txtClassT.Text & "','" & DPKVac.Text & "','" & DPKNTB.Text & "','" & txtPromot.Text & "','" & row.Cells("subject").Value & "','" & row.Cells("thirty").Value & "','" & row.Cells("seventy").Value & "','" & row.Cells("tot").Value & "','" & row.Cells("grade").Value & "','" & row.Cells("Remarks").Value & "','" & txtAtt1.Text & "','" & txtAtt2.Text & "','" & txtTeachRem.Text & "','" & txtHMRem.Text & "','" & txtHMName.Text & "')", con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next
        con.Close()
        MsgBox("Transaction done successully")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtyr.Text = "" Then
            MsgBox("Please enter Year before proceeding")
            Exit Sub
        Else

            Try
                insrt()
                clearTXT()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub clearTXT()
        txtid.Clear()
        txtFN.Clear()
        txtLN.Clear()

        txtClassT.Clear()
        txtAtt1.Clear()
        txtAtt2.Clear()

        txtTeachRem.Clear()
        txtHMName.Clear()
        txtHMRem.Clear()
        txtPromot.Clear()
        dgv.Rows.Clear()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "quit") = MsgBoxResult.Yes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
End Class