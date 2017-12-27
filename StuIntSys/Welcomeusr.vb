Public Class Welcomeusr


    Private Sub rbabout_Click(sender As Object, e As EventArgs) Handles rbabout.Click
        about.Show()
    End Sub




    Private Sub rbedit_Click(sender As Object, e As EventArgs) Handles rbedit.Click
        frmmanage.Show()
    End Sub

    Private Sub rbeditf_Click(sender As Object, e As EventArgs) Handles rbeditf.Click
        frmfacmanage.Show()
    End Sub

    Private Sub rbfees_Click(sender As Object, e As EventArgs) Handles rbfees.Click
        Pay.Show()
    End Sub

    Private Sub rbfeesshow_Click(sender As Object, e As EventArgs) Handles rbfeesshow.Click
        frmstructvb.Show()
    End Sub

    Private Sub rbgrading_Click(sender As Object, e As EventArgs) Handles rbgrading.Click
        frmGrading.Show()
    End Sub

    Private Sub rbhelp_Click(sender As Object, e As EventArgs) Handles rbhelp.Click
        help.Show()
    End Sub

    Private Sub rblogout_Click(sender As Object, e As EventArgs) Handles rblogout.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub rbman_Click(sender As Object, e As EventArgs) Handles rbman.Click
        manageuservb.Show()
    End Sub

    Private Sub rbsalary_Click(sender As Object, e As EventArgs) Handles rbsalary.Click
        salary.Show()
    End Sub

    Private Sub rbview_Click(sender As Object, e As EventArgs) Handles rbview.Click
        frmUpdate.Show()
    End Sub

    Private Sub rbviewf_Click(sender As Object, e As EventArgs) Handles rbviewf.Click
        searchf.Show()
    End Sub

    Private Sub rbviewgrad_Click(sender As Object, e As EventArgs) Handles rbviewgrad.Click
        viewgrade.Show()
    End Sub

    Private Sub Welcomeusr_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub Welcomeusr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
