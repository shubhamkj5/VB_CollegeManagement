Imports System.Data
Imports System.Data.SqlClient
Public Class login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con.ConnectionString = "Data Source=SHUBHAMKJ5;Initial Catalog=sis;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select LoginId,Pwd from tbUser where LoginId = '" & txtuser.Text & "' And Pwd = '" & txtpass.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Timer1.Start()
            ProgressBar1.Show()

        Else
            MessageBox.Show("Incorrect Id or Passwword")
            txtuser.Text = ""
            txtpass.Text = ""
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(25)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            MessageBox.Show("Welcome User")
            txtuser.Text = ""
            txtpass.Text = ""
            ProgressBar1.Value = 0
            Me.Hide()
            Welcomeusr.Show()

            End If
    End Sub

    Private Sub login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


End Class